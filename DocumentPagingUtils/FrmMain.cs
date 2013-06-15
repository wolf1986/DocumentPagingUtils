using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Common.DocumentPagingUtils;

namespace DocumentPagingGui
{
    public partial class FrmMain
    {
        protected DocumentUtilsBase Pager;

        public FrmMain()
        {
            InitializeComponent();
        }

        public static IEnumerable<Type> GetImplementations(Type interfaceType, String pathDirectory)
        {
            var paths_assemblies = Directory.GetFiles(pathDirectory, "*.dll", SearchOption.AllDirectories);
            var paths_assemblies_loaded =
                from assembly in AppDomain.CurrentDomain.GetAssemblies()
                select assembly.Location;

            var assemblies =
                (
                    from path_temp in paths_assemblies
                    let path = Path.GetFullPath(path_temp)
                    where !paths_assemblies_loaded.Contains(path)
                    select Assembly.LoadFile(path)
                ).ToArray();

            return GetImplementations(interfaceType, assemblies);
            //return GetImplementations(interfaceType, AppDomain.CurrentDomain.GetAssemblies());
        }

        public static IEnumerable<Type> GetImplementations(Type interfaceType)
        {
           // Load all assemblies in the current folder
            var dir_base = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ".");
            return GetImplementations(interfaceType, dir_base);
        }

        public static IEnumerable<Type> GetImplementations(Type interfaceType, IEnumerable<Assembly> assemblies)
        {
            return
                from assembly in assemblies
                from type in assembly.GetExportedTypes()
                where interfaceType.IsAssignableFrom(type) && !type.IsAbstract
                select type;
        }

        protected string FilenameGenerateNew(string pathPreviousName)
        {
            string path_copy;
            int index_dup = 0;
            do
            {
                index_dup++;
                path_copy = Path.Combine(
                    Path.GetDirectoryName(pathPreviousName) ?? ".",
                    Path.GetFileNameWithoutExtension(pathPreviousName) + "_New_" + index_dup + Pager.DefaultExtension);
            } while (File.Exists(path_copy));

            return path_copy;
        }

        private void linkAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.The-Red-Pill.info");
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            try
            {
                Pager.BindDir(edtMergeFile.Text, edtMergeDir.Text, "*" + Pager.DefaultExtension);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error, Exception caught:");
            }
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            try
            {
                Pager.SplitToPages(edtSplitFile.Text, edtSplitDir.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error, Exception caught:");
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                var index_to_insert = int.Parse(edtInsertAtIndex.Text);
                var path_file_orig = edtInsertFile.Text;

                // Make a copy of the file before manipulation if necessary
                if (checkInsertNewFile.Checked)
                {
                    var path_copy = FilenameGenerateNew(path_file_orig);
                    File.Copy(path_file_orig, path_copy, false);
                    path_file_orig = path_copy;
                }

                Pager.Insert(path_file_orig, edtInsertPage.Text, index_to_insert);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error, Exception caught:");
            }
        }

        private void checkAppendToEnd_CheckedChanged(object sender, EventArgs e)
        {
            edtInsertAtIndex.Enabled = !checkAppendToEnd.Checked;
            edtInsertAtIndex.Text = "-1";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var index_to_delete = int.Parse(edtDeletePageIndex.Text);
                var path_file_orig = edtDeleteFile.Text;

                // Make a copy of the file before manipulation if necessary
                if (checkDeleteNewFile.Checked)
                {
                    var path_copy = FilenameGenerateNew(path_file_orig);

                    File.Copy(path_file_orig, path_copy, false);
                    path_file_orig = path_copy;
                }

                Pager.DeletePage(path_file_orig, index_to_delete);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error, Exception caught:");
            }
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            try
            {
                var path_file_orig = edtReverseFile.Text;

                // Make a copy, reverse has an exception in the implementation
                var path_copy = path_file_orig + "_CopyOf" + Pager.DefaultExtension;
                File.Copy(path_file_orig, path_copy, false);

                var path_reverse = FilenameGenerateNew(path_file_orig);
                if (!checkReverseNew.Checked)
                {
                    File.Delete(path_file_orig);
                    path_reverse = path_file_orig;
                }

                Pager.Reverse(path_copy, path_reverse);

                File.Delete(path_copy);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error, Exception caught:");
            }
        }

        private void btnInterleave_Click(object sender, EventArgs e)
        {
            try
            {
                Pager.Interlace(
                    edtInterleaveOdd.Text,
                    edtInterleaveEven.Text,
                    edtInterleaveOutFile.Text,
                    checkReverseEven.Checked);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error, Exception caught:");
            }
        }

        private void btnGeneralRename_Click(object sender, EventArgs e)
        {
            try
            {
                const string pattern_date = "yyyy.MM.dd - HH.mm.ss";

                string[] l_path_files = Directory.GetFiles(
                    edtGeneralRenameDirectory.Text,
                    "*.*", SearchOption.TopDirectoryOnly);

                foreach (var path_file in l_path_files)
                {
                    var filename_new = File.GetLastWriteTime(path_file).ToString(pattern_date);
                    var path_file_new = Path.GetDirectoryName(path_file) + @"\" + filename_new +
                                        Path.GetExtension(path_file);

                    // Skip files that already have the correct names
                    if (Path.GetFileName(path_file_new) == Path.GetFileName(path_file))
                        continue;
                    try
                    {
                        var index_duplicate = 0;
                        while (File.Exists(path_file_new))
                        {
                            index_duplicate++;
                            path_file_new = Path.Combine(
                                Path.GetDirectoryName(path_file) ?? ".",
                                filename_new + "_" + index_duplicate + Path.GetExtension(path_file));
                        }

                        File.Move(path_file, path_file_new);
                    }
                    catch
                    {
                    } // Ignore Errors
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error, Exception caught:");
            }
        }

        private void btnBrowseMergeDir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                edtMergeDir.Text = folderBrowserDialog.SelectedPath;
        }

        private void btnBrowseMergeFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                edtMergeFile.Text = saveFileDialog.FileName;
        }

        private void btnBrowseInsertFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                edtInsertFile.Text = openFileDialog.FileName;
        }

        private void btnBrowseInsertPages_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                edtInsertPage.Text = openFileDialog.FileName;
        }

        private void btnBrowseDeleteFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                edtDeleteFile.Text = openFileDialog.FileName;
        }

        private void btnBrowseReverseFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                edtReverseFile.Text = openFileDialog.FileName;
        }

        private void btnBrowseInterleaveOdd_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                edtInterleaveOdd.Text = openFileDialog.FileName;
        }

        private void btnBrowseInterleaveEven_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                edtInterleaveEven.Text = openFileDialog.FileName;
        }

        private void btnBrowseInterleaveOutFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                edtInterleaveOutFile.Text = saveFileDialog.FileName;
        }

        private void btnGeneralRenameBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                edtGeneralRenameDirectory.Text = folderBrowserDialog.SelectedPath;
        }

        private void btnBrowseSplitFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                edtSplitFile.Text = openFileDialog.FileName;
        }

        private void btnBrowseSplitDir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                edtSplitDir.Text = folderBrowserDialog.SelectedPath;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // Update path to include plugins
            Environment.SetEnvironmentVariable(
                "PATH", 
                Environment.GetEnvironmentVariable("PATH") + @";.\" + Properties.Settings.Default.PathDependencies
            ); 
            
            foreach (var implementation in GetImplementations(typeof(DocumentUtilsBase), "Plugins"))
                cmbDocType.Items.Add(Activator.CreateInstance(implementation));

            if(cmbDocType.Items.Count > 0)
                cmbDocType.SelectedIndex = 0;
            else
                throw new Exception("No plugins found! Please add some compatible plugins to the folder. ");
        }

        private void cmbDocType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pager = (DocumentUtilsBase)cmbDocType.SelectedItem;
        }
    }
}
