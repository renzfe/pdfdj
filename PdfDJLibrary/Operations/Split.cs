using System;
using System.Collections.Generic;
using System.IO;
using iText.Kernel.Pdf;

namespace PdfDJ.Library.Operations
{
    /// <summary>
    /// 
    /// </summary>
    public class Split
    {
        private static readonly NLog.Logger l = NLog.LogManager.GetCurrentClassLogger();
        private Split() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pdfFilePath"></param>
        /// <param name="outputDir"></param>
        /// <param name="pageNumbers"></param>
        /// <returns></returns>
        public static List<FileInfo> SplitPDFFile(string pdfFilePath, string outputDir, IList<int> pageNumbers)
        {
            try
            {
                FileInfo pdfFileInfo = new FileInfo(pdfFilePath);
                if (!pdfFileInfo.Exists) throw new Exception("pdf document does not exist");
                if (pageNumbers.Count < 1) throw new Exception("select pages to split");
                string pdfFileName = pdfFileInfo.Name.Substring(0, pdfFileInfo.Name.LastIndexOf(".")) + "_";

                using (var pdfDoc = new PdfDocument(new PdfReader(pdfFileInfo.FullName)))
                {
                    var splitter = new CustomSplitter(pdfDoc, outputDir, pdfFileName);
                    var splittedDocs = splitter.SplitByPageNumbers(pageNumbers);

                    foreach (var splittedDoc in splittedDocs)
                    {
                        PdfDocumentInfo i = splittedDoc.GetDocumentInfo();

                        splittedDoc.Close();

                    }
                    return splitter.GetSplittedFiles();
                }
            }
            catch (Exception ex)
            {
                l.Error("{0}", ex.Message);
                throw;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pdfFilePath"></param>
        /// <returns></returns>
        public static int GetNumberOfPages(string pdfFilePath)
        {
            int pages = -1;

            FileInfo pdfFileInfo = new FileInfo(pdfFilePath);
            if (!pdfFileInfo.Exists) throw new Exception("pdf does not exist");

            using (var pdfDoc = new PdfDocument(new PdfReader(pdfFileInfo.FullName)))
            {
                pages = pdfDoc.GetNumberOfPages();
            }

            return pages;
        }
    }
}
