using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLine;

namespace PdfDJ.PdfDJConsole.Console
{
    [Verb("split", HelpText = "Split Options.")]
    internal class SplitOptions
    {
        [Option('i', "inputfile", Required = true, HelpText = "Input pdf file to be splitted.")]
        public string InputFile { get; set; }

        [Option('o', "outputdirectory", Required = true, HelpText = "Output directory where the splitted files are created.")]
        public string OutpuDir { get; set; }

        [Option('p', "pages", Required = true, HelpText = "Pages where to split file.")]
        public IEnumerable<int> PagesNumber { get; set; }

    }
}
