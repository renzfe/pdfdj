using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PdfDJ.GUI.Forms
{
    public partial class FormMerge : Form
    {
        private static readonly NLog.Logger l = NLog.LogManager.GetCurrentClassLogger();
        private bool isDirt = false;

        public FormMerge()
        {
            InitializeComponent();
        }

        private void setDirty(bool dirty)
        {
            if (dirty)
            {
                isDirt = true;
                textBoxOutput.BackColor = Color.Beige;
            }
            else
            {
                isDirt = false;
                textBoxOutput.BackColor = Color.White;

            }
        }

        private void textBox_DragDrop(object sender, DragEventArgs e)
        {
            textBoxMerged.Text = string.Empty;

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length != 0)
            {
                string pdfFilePath = files[0];
                ((TextBox)sender).Text = pdfFilePath;

                if (!isDirt) setDirOutput(pdfFilePath);
            }

        }

        private void textBox_DragOver(object sender, DragEventArgs e)
        {
            textBoxMerged.Text = string.Empty;

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void setDirOutput(string pdfFilePath)
        {
            FileInfo od = new FileInfo(pdfFilePath);
            textBoxOutput.Text = od.Directory.FullName;
        }


        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxFile1.Text = string.Empty;
            textBoxFile2.Text = string.Empty;
            textBoxOutput.Text = string.Empty;
            textBoxMerged.Text = string.Empty;
            setDirty(false);
        }

        private void buttonMerge_Click(object sender, EventArgs e)
        {
            l.Info("start merging button..");
            try
            {
                FileInfo pdfMerged = null;
                pdfMerged = PdfDJ.Library.Operations.Merge.Merge2Files(textBoxFile1.Text, textBoxFile2.Text, textBoxOutput.Text);
                textBoxMerged.Text = pdfMerged.FullName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            l.Info("end merging button.");
        }


        private void FormMerge_Load(object sender, EventArgs e)
        {
            setDirty(false);
        }

        private void textBoxFile1_DragDrop(object sender, DragEventArgs e)
        {
            textBox_DragDrop(sender, e);
        }

        private void textBoxFile1_DragOver(object sender, DragEventArgs e)
        {
            textBox_DragOver(sender, e);
        }

        private void textBoxFile2_DragDrop(object sender, DragEventArgs e)
        {
            textBox_DragDrop(sender, e);
        }

        private void textBoxFile2_DragOver(object sender, DragEventArgs e)
        {
            textBox_DragOver(sender, e);
        }

        private void textBoxOutput_KeyPress(object sender, KeyPressEventArgs e)
        {
            l.Debug("changed");
            setDirty(true);
        }

    }
}
