# DocumentPagingUtils #
A Set of libraries in C# and a simple GUI to manipulate multi-page documents such as tiff, pdf, djvu


## Supported Page Operations ##
1. **Merge** all files in directory.
1. **Split** a file to a directory, each page gets it's own file.
1. **Insert** a file to another (at a given page-number).
1. **Delete** a given page from a file.
1. **Reverse** the order of pages in a given file.
1. **Interleave** pages from two files. Great for manually scanned duplex (double sided) documents, one containing the Odd pages, and one containing the Even pages.
1. Rename all files in a directory to their modifeid datestamp.

## Supported Formats ##
1. **Tiff** - <br />
    Using the ImageMagik library as a Command Line Interface. <br />
    Many thanks to _http://www.imagemagick.org_

1. **DjVu** - <br />
    Using the DjVuLibre library as a Command Line Interface. <br />
    Many thanks to _http://djvu.sourceforge.net/_

1. **PDF** - <br />
    Using the Adobe Acrobat Interapplication Communication (Adobe Acrobat IAC) <br />
    (Yes, this means that **Adobe Acrobat** must be installed. This library only automates it for easy access)
    Please note that this will not work with _**Adobe Acrobat Reader**_

    Also, using iTextSharp library - this allows anyone to manipulate PDF files regardless of having Adobe Acrobat installed!
