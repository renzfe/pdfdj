using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PdfDJ.GUI.Forms
{
    public partial class MainPdfDJForm : Form
    {
        public MainPdfDJForm()
        {
            InitializeComponent();
        }

        private void MainPdfDJForm_Load(object sender, EventArgs e)
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);

            this.Text = string.Format("{0} - {1}", this.Text, fvi.FileVersion);
        }

        private void buttonMerge_Click(object sender, EventArgs e)
        {
            FormMerge f = new FormMerge();
            f.ShowDialog();
        }

        private void buttonSplit_Click(object sender, EventArgs e)
        {
            FormSplit f = new FormSplit();
            f.ShowDialog();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
