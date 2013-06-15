using System.Collections.Generic;
using System.IO;
using System.Linq;
using Common.DocumentPagingUtils;

namespace DocumentPagingUtils
{
    public class Tiff : DocumentUtilsBase
    {
        public Tiff()
            : base(@"ImageMagick\") { }

        public void Gamma(string PathFile, double gammaValue)
        {
            AssertCli(Exec(PathLibrary + "convert",
                           "-limit memory 256MiB -limit map 512MiB -gamma " + gammaValue + " \"" + PathFile + "\" \"" +
                           PathFile + "\""));
        }

        public void Gamma(IEnumerable<string> pathFiles, double gammaValue)
        {
            foreach (var path in pathFiles)
                Gamma(path, gammaValue);
        }

        public override void DeletePage(string PathFile, int Page)
        {
            AssertCli(Exec(PathLibrary + "convert", "-delete " + (Page - 1) +
                                                         " \"" + PathFile + "\"" + " \"" + PathFile + "\""));
        }

        public override int SplitToPages(string pathFile, string Folder = null)
        {
            // Prepare folder
            string file_ext = Path.GetExtension(pathFile);
        
            string path_pages = Folder; // Determine name, use default if necessary 

            // Only delete directory if the name was auto-generated
            if ( null == Folder)
            {
                path_pages = pathFile + @"_Pages\";

                if (Directory.Exists(path_pages))
                    Directory.Delete(path_pages, true);
            }
            if (!Directory.Exists(path_pages))
                Directory.CreateDirectory(path_pages);

            if (!path_pages.EndsWith(@"\"))
                path_pages += @"\";

            AssertCli(Exec(PathLibrary + "convert ",
                           "+adjoin \"" + pathFile + "[0--1]\" \"" + path_pages + "Page%03d" + file_ext + "\""));

            var list_path_files = Directory.GetFiles(path_pages);        // Count pages
            return list_path_files.Length;
        }

        public override void Insert(string pathFileTo, string pathFileFrom, int index)
        {
            if (index > 0) index--;   // Convert to zero-based

            var append_token = (index > 0)
                ? string.Format("-insert {0}", index)
                : "";

            AssertCli(Exec(
                Path.Combine(PathLibrary, "convert"), 
                string.Format("\"{0}\" \"{1}\" {2} \"{0}\"", 
                    pathFileTo, pathFileFrom, append_token)
            ));
        }

        public override void Reverse(string pathFileFrom, string pathFileTo)
        {
            AssertCli(Exec(PathLibrary + "convert", "\"" + pathFileFrom +
                                                         "\" -reverse " + " \"" + pathFileTo + "\""));
        }

        public override void BindDir(string FileNameTo, string PathDir, string SearchPattern = "*.tiff|*.tif")
        {
            var l_files = new List<string>();

            // Find all files matching any of the given patterns, spearated by '|'
            var list_of_search_patterns = SearchPattern.Split('|');
            foreach (var pattern in list_of_search_patterns)
                l_files.AddRange(Directory.GetFiles(PathDir, pattern));
        
            Create(FileNameTo, l_files);
        }

        public override string DefaultExtension
        {
            get { return ".tiff"; }
        }

        public override void Create(string pathFile, IEnumerable<string> pathFilesFrom)
        {
            var str_files_from = string.Join(
                " ", 
                pathFilesFrom.Select(
                    x => string.Format("\"{0}\"", x)).ToArray()
            );

            var exe = Path.Combine(PathLibrary, "convert");

            AssertCli(Exec(
                exe,
                string.Format(@"{0} -limit memory 256MiB -limit map 512MiB -adjoin ""{1}""", str_files_from, pathFile)));
        }
    }
}
