using System;

namespace PdfDJ.PdfDJConsole
{
    static class Program
    {
        private static readonly NLog.Logger l = NLog.LogManager.GetCurrentClassLogger();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            string exe = string.Empty;

            try
            {
                exe = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
                l.Info("Start {0}", exe);
                PdfDJ.PdfDJConsole.Console.Executer.Execute(args);
                l.Info("{0}: EXIT 0", exe);
                System.Environment.ExitCode = 0;
            }
            catch (Exception ex)
            {
                l.Error(ex.Message);
                l.Warn("{0}: EXIT 1", exe);
                System.Environment.ExitCode = 1;
            }
            finally
            {
            }
        }
    }
}