using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PdfDJ.GUI.Forms
{
    public partial class FormSplit : Form
    {
        private static readonly NLog.Logger l = NLog.LogManager.GetCurrentClassLogger();

        public FormSplit()
        {
            InitializeComponent();
        }

        private void setDirOutput(string pdfFilePath)
        {
            FileInfo od = new FileInfo(pdfFilePath);
            textBoxOutput.Text = od.Directory.FullName;
        }

        private void FormSplit_Load(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxFile1.Text = string.Empty;
            textBoxOutput.Text = string.Empty;
            textBoxSplitted.Text = string.Empty;
            checkedListBoxPages.Items.Clear();
        }

        private void buttonSplit_Click(object sender, EventArgs e)
        {
            l.Info("start split button..");
            try
            {
                List<int> pages = new List<int>();
                foreach (var i in checkedListBoxPages.CheckedItems)
                {
                    pages.Add((int)i);
                }
                List<FileInfo> splittedPdf = PdfDJ.Library.Operations.Split.SplitPDFFile(this.textBoxFile1.Text, this.textBoxOutput.Text, pages);
                string s = string.Empty;
                splittedPdf.ForEach(a => s = s + a.Name + "; ");
                textBoxSplitted.Text = s;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            l.Info("end split button.");
        }

        private void buttonCheckPages_Click(object sender, EventArgs e)
        {
            l.Info("start check pages button..");
            try
            {
                int pages = PdfDJ.Library.Operations.Split.GetNumberOfPages(this.textBoxFile1.Text);
                checkedListBoxPages.Items.Clear();
                for (int i = 1; i <= pages; i++)
                {
                    checkedListBoxPages.Items.Add(i);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            l.Info("end check pages button.");
        }

        private void textBoxFile1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length != 0)
            {
                string pdfFilePath = files[0];
                ((TextBox)sender).Text = pdfFilePath;
                setDirOutput(pdfFilePath);
            }
        }

        private void textBoxFile1_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }
    }
}
