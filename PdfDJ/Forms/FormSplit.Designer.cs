
namespace PdfDJ.GUI.Forms
{
    partial class FormSplit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSplit));
            this.textBoxSplitted = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBoxPages = new System.Windows.Forms.CheckedListBox();
            this.buttonCheckPages = new System.Windows.Forms.Button();
            this.lblFileOut = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSplit = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.lblFile1 = new System.Windows.Forms.Label();
            this.textBoxFile1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxSplitted
            // 
            this.textBoxSplitted.Location = new System.Drawing.Point(12, 259);
            this.textBoxSplitted.Name = "textBoxSplitted";
            this.textBoxSplitted.ReadOnly = true;
            this.textBoxSplitted.Size = new System.Drawing.Size(650, 23);
            this.textBoxSplitted.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(657, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Select the pages to split";
            // 
            // checkedListBoxPages
            // 
            this.checkedListBoxPages.FormattingEnabled = true;
            this.checkedListBoxPages.Location = new System.Drawing.Point(668, 27);
            this.checkedListBoxPages.Name = "checkedListBoxPages";
            this.checkedListBoxPages.Size = new System.Drawing.Size(120, 256);
            this.checkedListBoxPages.TabIndex = 17;
            // 
            // buttonCheckPages
            // 
            this.buttonCheckPages.Location = new System.Drawing.Point(548, 154);
            this.buttonCheckPages.Name = "buttonCheckPages";
            this.buttonCheckPages.Size = new System.Drawing.Size(114, 23);
            this.buttonCheckPages.TabIndex = 15;
            this.buttonCheckPages.Text = "Discover pages";
            this.buttonCheckPages.UseVisualStyleBackColor = true;
            this.buttonCheckPages.Click += new System.EventHandler(this.buttonCheckPages_Click);
            // 
            // lblFileOut
            // 
            this.lblFileOut.AutoSize = true;
            this.lblFileOut.Location = new System.Drawing.Point(12, 80);
            this.lblFileOut.Name = "lblFileOut";
            this.lblFileOut.Size = new System.Drawing.Size(96, 15);
            this.lblFileOut.TabIndex = 21;
            this.lblFileOut.Text = "Outupt Directory";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(422, 227);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 20;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(503, 227);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 19;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSplit
            // 
            this.buttonSplit.Location = new System.Drawing.Point(587, 227);
            this.buttonSplit.Name = "buttonSplit";
            this.buttonSplit.Size = new System.Drawing.Size(75, 23);
            this.buttonSplit.TabIndex = 18;
            this.buttonSplit.Text = "Split";
            this.buttonSplit.UseVisualStyleBackColor = true;
            this.buttonSplit.Click += new System.EventHandler(this.buttonSplit_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(12, 98);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(650, 50);
            this.textBoxOutput.TabIndex = 14;
            // 
            // lblFile1
            // 
            this.lblFile1.AutoSize = true;
            this.lblFile1.Location = new System.Drawing.Point(12, 9);
            this.lblFile1.Name = "lblFile1";
            this.lblFile1.Size = new System.Drawing.Size(173, 15);
            this.lblFile1.TabIndex = 16;
            this.lblFile1.Text = "Drag && Drop the pdf document";
            // 
            // textBoxFile1
            // 
            this.textBoxFile1.AllowDrop = true;
            this.textBoxFile1.Location = new System.Drawing.Point(12, 27);
            this.textBoxFile1.Multiline = true;
            this.textBoxFile1.Name = "textBoxFile1";
            this.textBoxFile1.Size = new System.Drawing.Size(650, 50);
            this.textBoxFile1.TabIndex = 13;
            this.textBoxFile1.TextChanged += new System.EventHandler(this.textBoxFile1_TextChanged);
            this.textBoxFile1.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxFile1_DragDrop);
            this.textBoxFile1.DragOver += new System.Windows.Forms.DragEventHandler(this.textBoxFile1_DragOver);
            // 
            // FormSplit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 310);
            this.Controls.Add(this.textBoxSplitted);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBoxPages);
            this.Controls.Add(this.buttonCheckPages);
            this.Controls.Add(this.lblFileOut);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSplit);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.lblFile1);
            this.Controls.Add(this.textBoxFile1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSplit";
            this.Text = "Split a document";
            this.Load += new System.EventHandler(this.FormSplit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSplitted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBoxPages;
        private System.Windows.Forms.Button buttonCheckPages;
        private System.Windows.Forms.Label lblFileOut;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSplit;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Label lblFile1;
        private System.Windows.Forms.TextBox textBoxFile1;
    }
}