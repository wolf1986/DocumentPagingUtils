using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Common.DocumentPagingUtils
{
    /// <summary>
    /// Base class for utilities that manipulate multi-page documents
    /// </summary>
    public abstract class DocumentUtilsBase
    {
        // Constants
        protected const string PrefixPage = "Page";

        /// <summary>
        /// Extension of the file-type, including the prefexing dot
        /// </summary>
        public abstract string DefaultExtension { get; }

        /// <summary>
        /// Constructs an object and stores path to the core-library
        /// </summary>
        protected DocumentUtilsBase(string pathLibrary)
        {
            PathLibrary = pathLibrary;
        }

        /// <summary>
        /// Aggregates many documents into a single multi-page document
        /// </summary>
        public abstract void Create(string pathFile, IEnumerable<string> pathFilesFrom); 

        /// <summary>
        /// Deletes a signle page from the document
        /// </summary>
        /// <param name="page">One-based index of page</param>
        public abstract void DeletePage(string pathFile, int page);

        /// <summary>
        /// Inserts whole document in-front of the given page-index
        /// </summary>
        /// <param name="pathFileTo">Path to main document</param>
        /// <param name="pathFileFrom">Path to document to be inserted</param>
        /// <param name="index">Page before to insert (one-based); -1 means document should be appended to the end</param>
        public abstract void Insert(string pathFileTo, string pathFileFrom, int index);

        /// <summary>
        /// Splits a given document to many single-paged files. Pages will be named Page###.ext
        /// </summary>
        /// <param name="folder">Path to output containing folder; Folder will be created if needed</param>
        /// <returns>The amount of pages extracted from the document</returns>
        public abstract int SplitToPages(string pathFile, string folder = null);

        /// <summary>
        /// Merges all of the given files matching a given pattern to a single multi-page document
        /// </summary>
        /// <param name="fileNameTo">Path to output file</param>
        /// <param name="pathDir">Path to dir containing the originals</param>
        /// <param name="searchPattern">Wildcard pattern that describes the search pattern for the files</param>
        public abstract void BindDir(string fileNameTo, string pathDir, string searchPattern);

        /// <summary>
        /// Appends many documents to the end of another one
        /// </summary>
        /// <param name="pathFileTo">Path to main document</param>
        /// <param name="pathFilesFrom">List of documents that will be appended to the end of the first one</param>
        public virtual void Append(string pathFileTo, IEnumerable<string> pathFilesFrom)
        {
            foreach (var path in pathFilesFrom)
                Insert(pathFileTo, path, -1);
        }

        /// <summary>
        /// Reverses the order of pages in a given document
        /// </summary>
        /// <param name="pathFileFrom">Path to original document</param>
        /// <param name="pathFileTo">Path to save output</param>
        public virtual void Reverse(string pathFileFrom, string pathFileTo)
        {
            var is_paths_directories = Directory.Exists(pathFileFrom) && Directory.Exists(pathFileTo);

            // If given directories instead of files, only rename files
            if (is_paths_directories) 
            {
                var paths = Directory.GetFiles(pathFileFrom);

                // Assume order by filename
                var counter = paths.Length;
                foreach (var path_file in paths)
                {
                    // Append zero padded index to the old filename
                    var old_filename = counter.ToString("D3") + "_" + Path.GetFileName(path_file);
                    
                    var path_new = Path.Combine(pathFileTo, old_filename);

                    File.Move(path_file, path_new);
                    counter--;
                }

                return;
            }

            // Prepare folder
            var path_pages = pathFileFrom + @"_Pages\";
            Directory.CreateDirectory(path_pages);

            var num_of_pages = SplitToPages(pathFileFrom, path_pages);
            var list_paths = Directory.GetFiles(path_pages);

            var last_path = list_paths[list_paths.Length - 1];

            // Assemble files back in reverse order
            // Insert all of the pages after the last page (in reverse)
            for (var index_cur_page = num_of_pages - 2; index_cur_page >= 0; index_cur_page-- )
                Append(last_path, new[] { list_paths[index_cur_page] });

            // Cleanup
            if (File.Exists(pathFileTo))
                File.Delete(pathFileTo);

            File.Move(last_path, pathFileTo);
            Directory.Delete(path_pages.TrimEnd('\\'), true);
        }

        /// <summary>
        /// Combines two different documents that represent the Odd and the Even sides
        /// </summary>
        /// <param name="pathFileTo">Path to output file</param>
        /// <param name="reverseEven">Indicates whether even pages are reversed</param>
        public virtual void Interlace(string pathFileOdd, string pathFileEven, string pathFileTo, bool reverseEven = false)
        {
            var is_paths_directories = Directory.Exists(pathFileOdd) && Directory.Exists(pathFileEven);

            // Prepare folder
            var path_pages_odd = pathFileOdd + @"_Pages\";
            var path_pages_even = pathFileEven + @"_Pages\";

            var num_of_odd = 0;
            var num_of_even = 0;

            // Split to pages if files were given
            if (!is_paths_directories)
            {
                num_of_odd = SplitToPages(pathFileOdd, path_pages_odd);
                num_of_even = SplitToPages(pathFileEven, path_pages_even);
            }
            else
            {
                path_pages_odd = pathFileOdd;
                path_pages_even = pathFileEven;
            }

            if (File.Exists(pathFileTo))
                File.Delete(pathFileTo);

            var search_pattern = "*" + DefaultExtension;

            var list_path_odd = Directory.GetFiles(path_pages_odd, search_pattern);
            var list_path_even = Directory.GetFiles(path_pages_even, search_pattern);

            if (is_paths_directories) // Read number of files in dirs
            {
                num_of_odd = list_path_odd.Length;
                num_of_even = list_path_even.Length;
            }

            File.Copy(list_path_odd[0], pathFileTo);

            var index_cur_odd = 1;
            var index_cur_even = 0;

            while (index_cur_odd < num_of_odd || index_cur_even < num_of_even)
            {
                // Append Even
                if (index_cur_even < num_of_even)
                {
                    var path_cur_from = reverseEven
                        ? list_path_even[num_of_even - index_cur_even - 1]
                        : list_path_even[index_cur_even]; 
                    
                    Append(pathFileTo, new[] { path_cur_from });
                    index_cur_even++;
                }

                // Append Odd
                if (index_cur_odd < num_of_odd)
                {
                    Append(pathFileTo, new[] { list_path_odd[index_cur_odd] });
                    index_cur_odd++;
                }
            }

            // Cleanup
            if (!is_paths_directories)
            {
                Directory.Delete(path_pages_even, true);
                Directory.Delete(path_pages_odd, true);
            }
        }

        /// <summary>
        /// Represents the function of the class in an understandable form
        /// </summary>
        /// <returns>Nice human-readable string</returns>
        public override string ToString()
        {
            return string.Format(
                "Manipulate '{0}' files using '{1}'",
                DefaultExtension, PathLibrary
            );
        }

        /// <summary>
        /// Executes a path (using shell-execute)
        /// </summary>
        /// <param name="path">Path to program</param>
        /// <param name="args">Args for starting a process</param>
        /// <returns>Exit code of the process</returns>
        static public int Exec(string path, string args)
        {
            string std_out;
            return Exec(path, args, out std_out);
        }

        /// <summary>
        /// Executes a path (using shell-execute), retrieves the output stream
        /// </summary>
        /// <param name="path">Path to program</param>
        /// <param name="args">Args for starting a process</param>
        /// <param name="stdOut">Standard output</param>
        /// <returns>Exit code of the process</returns>
        static public int Exec(string path, string args, out string stdOut)
        {
            const bool DontRedirectOutput = false;

            // Make sure that we find the library using relative path
            Environment.CurrentDirectory = Path.GetDirectoryName(Environment.CommandLine.Trim('"', ' ')) ?? ".";

            // Start the child process.

            var p = new Process
            {
                StartInfo =
                {
                    UseShellExecute = DontRedirectOutput,
                    RedirectStandardOutput = !DontRedirectOutput,
                    RedirectStandardError = !DontRedirectOutput,
                    FileName = path,
                    Arguments = args,
                    CreateNoWindow = true
                }
            };

            p.Start();

            // Read the output stream first and then wait.
            stdOut = p.StandardOutput.ReadToEnd();

            // Read errors if any
            var err = p.StandardError.ReadToEnd();

            if (!string.IsNullOrEmpty(err))
                MessageBox.Show(err, "Error Occured:");

            p.WaitForExit();
            return p.ExitCode;
        }

        /// <summary>
        /// Verifies that exitCode is 0, throws an exception otherwise
        /// </summary>
        /// <param name="exitCode">Exit code of a process</param>
        protected static void AssertCli(int exitCode)
        {
            if (0 != exitCode)
                throw new Exception("Could not perform operation using command line");
        }

        protected string PathLibrary;
    }
}
