using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLine;

namespace PdfDJ.PdfDJConsole.Console
{
    /// <summary>
    /// Console Executer class
    /// </summary>
    internal static class Executer
    {
        private static readonly NLog.Logger l = NLog.LogManager.GetCurrentClassLogger();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public static void Execute(string[] args)
        {

            int errno = CommandLine.Parser.Default.ParseArguments<MergeOptions, SplitOptions>(args)
                .MapResult(
                  (MergeOptions opts) => RunMergeAndReturnExitCode(opts),
                  (SplitOptions opts) => RunSplitAndReturnExitCode(opts),
                  errs => 1);
            
            l.Trace("errno={0}", errno);            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="opts"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        private static int RunMergeAndReturnExitCode(MergeOptions opts)
        {
            int retVal = 0;
            if(opts.InputFiles.ToList<string>().Count < 2)
            {
                throw new ArgumentException("numero file errato");
            }
            string file1 = opts.InputFiles.ToList<string>()[0];
            string file2 = opts.InputFiles.ToList<string>()[1];
            string fileMerged = opts.OutpuDir;
            FileInfo pdfMerged = null;

            pdfMerged = PdfDJ.Library.Operations.Merge.Merge2Files(file1, file2, fileMerged);
            l.Info("Merged document: {0}", pdfMerged.FullName);

            return retVal;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="opts"></param>
        /// <returns></returns>
        private static int RunSplitAndReturnExitCode(SplitOptions opts)
        {
            int retVal = 0;
            string inputFile1 = opts.InputFile;
            string outputDir = opts.OutpuDir;

            List<int> pages = opts.PagesNumber.ToList<int>();
            List<FileInfo> splittedPdf = PdfDJ.Library.Operations.Split.SplitPDFFile(inputFile1, outputDir, pages);
            string s = string.Empty;
            splittedPdf.ForEach(a => s = s + a.Name + "; ");
            l.Info("Splitted documents: {0}", s);

            return retVal;
        }

    }
}
