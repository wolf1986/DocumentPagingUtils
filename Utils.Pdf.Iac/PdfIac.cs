using System;
using System.Collections.Generic;
using System.IO;
using Acrobat;
using Common.DocumentPagingUtils;

namespace DocumentPagingUtils
{
    public class PdfIac : DocumentUtilsBase, IDisposable
    {
        protected readonly CAcroApp App;

        public PdfIac() : base("Adobe Acrobat Interop (Acrobat Iac)")
        {
            App = new AcroAppClass();
            App.Hide();
        }

        public override void BindDir(string fileNameTo, string pathDir, string searchPattern)
        {
            var l_files = Directory.GetFiles(pathDir, searchPattern);
            Create(fileNameTo, l_files);

//            File.Copy(l_files.First(), fileNameTo);
//            Append(fileNameTo, l_files.Skip(1).ToArray());
        }

        public override void DeletePage(string pathFile, int page)
        {
            var doc = new AcroPDDocClass();
            doc.Open(pathFile);

            doc.DeletePages(page - 1, page - 1);

            doc.Save((short)PDSaveFlags.PDSaveFull, pathFile);
            doc.Close();
        }

        public override void Insert(string pathFileTo, string pathFileFrom, int index)
        {
            var doc_to = new AcroPDDocClass();
            doc_to.Open(pathFileTo);

            var doc_from = new AcroPDDocClass();
            doc_from.Open(pathFileFrom);

            if (index == -1)
                index = doc_to.GetNumPages();
            else
                index -= 1;

            var count_pages = doc_from.GetNumPages();
            doc_to.InsertPages(index - 1, doc_from, 0, count_pages, 0);

            doc_from.Close();

            doc_to.Save((short)PDSaveFlags.PDSaveFull, pathFileTo);
            doc_to.Close();

        }

        public override void Create(string pathFile, IEnumerable<string> pathFilesFrom)
        {
            var doc_new = new AcroPDDocClass();
            doc_new.Create();

            var count_pages = 0;

            // Insert every file
            foreach (var path_file_from in pathFilesFrom)
            {
    			var av_doc = new AcroAVDocClass();
                av_doc.Open(path_file_from, "");
				var doc = (CAcroPDDoc)av_doc.GetPDDoc();

                var count_pages_new = doc.GetNumPages();
                doc_new.InsertPages(count_pages - 1, doc, 0, count_pages_new, 0);

                count_pages += count_pages_new;

                doc.Close();
                av_doc.Close(1);
            }

            doc_new.Save((short)PDSaveFlags.PDSaveFull, pathFile);
            doc_new.Close();
        }

        public void ExtractPage(string pathFile, int page, string pathFileTo)
        {
            var doc_view = new AcroAVDocClass();
            var is_ok = doc_view.Open(pathFile, "");
            var doc = (CAcroPDDoc)doc_view.GetPDDoc();

            CAcroPDDoc doc_extracted = new AcroPDDocClass();
            doc_extracted.Create();
            is_ok = doc_extracted.InsertPages(-1, doc, page - 1, 1, 0);
            doc_extracted.Save((short)PDSaveFlags.PDSaveFull, pathFileTo);
            doc_extracted.Close();

            doc.Close();
            doc_view.Close(1);
        }

        public int GetPagesCount(string pathFile)
        {
            var doc_view = new AcroAVDocClass();
            doc_view.Open(pathFile, "");
            var doc = (AcroPDDoc)doc_view.GetPDDoc();

            var count_pages = doc.GetNumPages();

            doc.Close();
            doc_view.Close(1);

            return count_pages;
        }

        public override int SplitToPages(string pathFile, string folder = null)
        {
            // Determine name, use default if necessary 
            string path_pages;
            if (string.IsNullOrEmpty(folder))
                path_pages = pathFile + @"_Pages\";
            else
                path_pages = folder;

            var doc_view = new AcroAVDocClass();
            doc_view.Open(pathFile, "");
            var doc = (AcroPDDoc)doc_view.GetPDDoc();
            
            // Create dir if necessary
            if (!Directory.Exists(path_pages))
                Directory.CreateDirectory(path_pages);

            // Extract every page
            var count_pages = doc.GetNumPages();
            for (var current_page = 1; current_page <= count_pages; current_page ++ )
            {
                var path_file_to =
                    Path.Combine(
                        path_pages,
                        string.Format("{0}{1:D3}{2}", PrefixPage, current_page - 1, DefaultExtension)
                    );

                ExtractPage(pathFile, current_page, path_file_to);
            }

            doc.Close();
            doc_view.Close(1);

            return count_pages;
        }

        public override string DefaultExtension
        {
            get { return ".pdf"; }
        }

        public void Dispose()
        {
            App.CloseAllDocs();
            App.Exit();
        }
    }
}