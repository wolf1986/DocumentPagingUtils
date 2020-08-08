using System.Collections.Generic;
using System.IO;
using Common.DocumentPagingUtils;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Utils.Pdf.iTextSharp
{
    public class PdfITextSharp : DocumentUtilsBase
    {
        public PdfITextSharp(string pathLibrary) : base(pathLibrary)
        {
        }

        public PdfITextSharp()
            : base("iTextSharp PDF Library")
        {
        }

        public override string DefaultExtension
        {
            get { return ".pdf"; }
        }
        public override void Create(string pathFile, IEnumerable<string> pathFilesFrom)
        {
            using (var stream = new FileStream(pathFile, FileMode.Create))
            using (var doc = new Document())
            using (var pdf = new PdfCopy(doc, stream))
            {
                doc.Open();

                foreach (var file in pathFilesFrom)
                {
                    var reader = new PdfReader(file);

                    for (var i = 1; i <= reader.NumberOfPages; i++)
                    {
                        var page = pdf.GetImportedPage(reader, i);
                        pdf.AddPage(page);
                    }

                    pdf.FreeReader(reader);
                    reader.Close();
                }
            }
        }

        public override void DeletePage(string pathFile, int pageToDelete)
        {
            // Intialize a new PdfReader instance with the 
            // contents of the source Pdf file:
            var reader = new PdfReader(pathFile);

            var path_temp = Path.Combine(
                Path.GetDirectoryName(pathFile),
                "temp_" + Path.GetFileName(pathFile)
            );

            // For simplicity, I am assuming all the pages share the same size
            // and rotation as the first page:
            using (var source_document = new Document())
            using (var pdf_copy_provider = new PdfCopy(source_document, new FileStream(path_temp, FileMode.Create)))
            {
                source_document.Open();

                // Walk the array and add the page copies to the output file:
                for (var i = 1; i <= reader.NumberOfPages; i++)
                {
                    if(i == pageToDelete)
                        continue;

                    var imported_page = pdf_copy_provider.GetImportedPage(reader, i);
                    pdf_copy_provider.AddPage(imported_page);
                }

                source_document.Close();
                reader.Close();
            }

            if (File.Exists(path_temp))
            {
                File.Delete(pathFile);
                File.Move(path_temp, pathFile);
            }
        }

        public override void Insert(string pathFileTo, string pathFileFrom, int index)
        {
            var path_file_temp = Path.Combine(
                Path.GetDirectoryName(pathFileTo),
                "temp_" + Path.GetFileName(pathFileTo)
            );

            using (var reader_from = new PdfReader(pathFileFrom))
            using (var reader_to = new PdfReader(pathFileTo))
            using (var stream = new FileStream(path_file_temp, FileMode.Create))
            using (var doc = new Document())
            using (var new_pdf = new PdfCopy(doc, stream))
            {

                doc.Open();

                // Identify correct index
                if (index < 0)
                    index = reader_to.NumberOfPages + 1;

                // Copy all the pages before the desired index
                var pages_appended = 0;
                for (var i = 1; i < index && i <= reader_to.NumberOfPages; i++)
                {
                    var page = new_pdf.GetImportedPage(reader_to, i);
                    new_pdf.AddPage(page);
                }

                for (var i = 1; i <= reader_from.NumberOfPages; i++)
                {
                    var page = new_pdf.GetImportedPage(reader_from, i);
                    new_pdf.AddPage(page);
                }

                for (var i = index; i <= reader_to.NumberOfPages; i++)
                {
                    var page = new_pdf.GetImportedPage(reader_to, i);
                    new_pdf.AddPage(page);
                }
            }

            if (File.Exists(path_file_temp))
            {
                File.Delete(pathFileTo);
                File.Move(path_file_temp, pathFileTo);
            }
        }

        public override int SplitToPages(string pathFile, string folder = null)
        {
            // Determine name, use default if necessary 
            if (string.IsNullOrEmpty(folder))
                folder = pathFile + @"_Pages\";

            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            using (var reader = new PdfReader(pathFile))
            {
                var count_pages = reader.NumberOfPages;
                int current_page;

                for (current_page = 0; current_page < count_pages; current_page ++)
                {
                    var path_file_to = 
                        Path.Combine(
                            folder,
                            string.Format("{0}{1:D3}{2}", PrefixPage, current_page, DefaultExtension)
                        );

                    using (var stream = new FileStream(path_file_to, FileMode.Create))
                    using (var doc = new Document())
                    using (var pdf = new PdfCopy(doc, stream))
                    {
                        doc.Open();

                        var page = pdf.GetImportedPage(reader, current_page + 1);
                        pdf.AddPage(page);

                        pdf.FreeReader(reader);
                    }
                }

                return current_page;
            }
        }

        public override void BindDir(string fileNameTo, string pathDir, string searchPattern)
        {
            var l_files = Directory.GetFiles(pathDir, searchPattern);
            Create(fileNameTo, l_files);
        }
    }
}
