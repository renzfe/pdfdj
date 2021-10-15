using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iText.Kernel.Utils;
using iText.Kernel.Pdf;
using System.IO;

namespace PdfDJ.Library.Operations
{
    /// <summary>
    /// 
    /// </summary>
    class CustomSplitter : PdfSplitter
    {
        private int _order;
        private readonly string _destinationFolder;
        private string _splitDocumentName = "splitDocument1_";
        private List<FileInfo> _files = new List<FileInfo>();

        public List<FileInfo> GetSplittedFiles()
        {
            return _files;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pdfDocument"></param>
        /// <param name="destinationFolder"></param>
        /// <param name="singleFileName"></param>
        public CustomSplitter(PdfDocument pdfDocument, string destinationFolder, string singleFileName) : base(pdfDocument)
        {
            _destinationFolder = destinationFolder;
            _order = 1;
            _splitDocumentName = singleFileName;
            _files = new List<FileInfo>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pdfDocument"></param>
        /// <param name="destinationFolder"></param>
        public CustomSplitter(PdfDocument pdfDocument, string destinationFolder) : base(pdfDocument)
        {
            _destinationFolder = destinationFolder;
            _order = 1;
            _files = new List<FileInfo>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="documentPageRange"></param>
        /// <returns></returns>
        protected override PdfWriter GetNextPdfWriter(PageRange documentPageRange)
        {
            FileInfo info = new FileInfo(_destinationFolder + @"\" + _splitDocumentName + _order++ + ".pdf");
            _files.Add(info);
            return new PdfWriter(info.FullName);
        }
    }
}
