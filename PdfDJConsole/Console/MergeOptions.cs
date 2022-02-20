using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLine;

namespace PdfDJ.PdfDJConsole.Console
{
    [Verb("merge", HelpText = "Merge Options.")]
    internal class MergeOptions
    {
        [Option('i', "inputfiles", Required = true, HelpText = "Input pdf files to be merged.")]
        public IEnumerable<string> InputFiles { get; set; }

        [Option('o', "outputdirectory", Required = true, HelpText = "Output directory where the merged file is created.")]
        public string OutpuDir{ get; set; }
    }
}
