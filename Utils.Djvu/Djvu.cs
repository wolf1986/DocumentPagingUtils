using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Common.DocumentPagingUtils;

namespace DocumentPagingUtils
{
    public class Djvu : DocumentUtilsBase
    {
        public Djvu()
            : base(@"DjVuLibre\") {}

        public override void BindDir(string fileNameTo, string pathDir, string searchPattern)
        {
            // Creation using Djvu-Libre seems to be buggy. Use append method instead
            var l_files = Directory.GetFiles(pathDir, searchPattern);
            //Create(FileNameTo, l_files);

            File.Copy(l_files.First(), fileNameTo);
            Append(fileNameTo, l_files.Skip(1).ToArray());
        }

        public override void DeletePage(string pathFile, int page)
        {
            if(0 != Exec(PathLibrary + "djvm", "-delete \"" + pathFile + "\" " + page))
                throw new Exception("DjVuLibre: Could not perform operation using command line");
        }

        public override void Insert(string pathFileTo, string pathFileFrom, int index)
        {
            if( 0!= Exec(PathLibrary + "djvm", "-insert \"" + pathFileTo + "\" \"" + pathFileFrom + "\" " + index))
                throw new Exception("DjVuLibre: Could not perform operation using command line");
        }

        public override void Create(string pathFile, IEnumerable<string> pathFilesFrom)
        {
            var str_files_from = "";

            foreach (string path in pathFilesFrom)
            {
                str_files_from += "\"" + path + "\" ";
            }
            str_files_from = str_files_from.TrimEnd(new [] { ' ' });

            if( 0!= Exec(PathLibrary + "djvm", "-create \"" + pathFile + "\" " + str_files_from))
                throw new Exception("DjVuLibre: Could not perform operation using command line");
        }

        public void ExtractPage(string pathFile, int page, string pathFileTo)
        {
            if (0 != Exec(
                        PathLibrary + "djvused",
                        string.Format("\"{0}\" -e \"select {1}; save-page-with '{2}'\"", 
                                      pathFile, page, pathFileTo.Replace('\\', '/'))
                        ))
                throw new Exception("DjVuLibre: Could not perform operation using command line");
        }

        public int GetPagesCount(string pathFile)
        {
            string std_out;
            if (0 != Exec(
                        PathLibrary + "djvused",
                        string.Format("\"{0}\" -e n", pathFile),
                        out std_out
                        ))
                throw new Exception("DjVuLibre: Could not perform operation using command line");

            return int.Parse(std_out);
        }

        public override int SplitToPages(string pathFile, string folder = null)
        {
            // Determine name, use default if necessary 
            string path_pages;
            if (string.IsNullOrEmpty(folder))
                path_pages = pathFile + @"_Pages\";
            else
                path_pages = folder;

            if (!Directory.Exists(path_pages))
                Directory.CreateDirectory(path_pages);

            var count_pages = GetPagesCount(pathFile);
            for (var current_page = 1; current_page <= count_pages; current_page ++ )
            {
                var path_file_to =
                    Path.Combine(
                        path_pages,
                        string.Format("Page{0:D3}{1}", current_page - 1, DefaultExtension)
                    );

                ExtractPage(pathFile, current_page, path_file_to);
            }

            return count_pages;
        }

        public override string DefaultExtension
        {
            get { return ".djvu"; }
        }
    }
}