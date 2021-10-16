
namespace PdfDJ.GUI.Forms
{
    partial class FormMerge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMerge));
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxMerged = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonMerge = new System.Windows.Forms.Button();
            this.lblFileOut = new System.Windows.Forms.Label();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.lblFile2 = new System.Windows.Forms.Label();
            this.textBoxFile2 = new System.Windows.Forms.TextBox();
            this.lblFile1 = new System.Windows.Forms.Label();
            this.textBoxFile1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(425, 258);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 13;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxMerged
            // 
            this.textBoxMerged.Location = new System.Drawing.Point(12, 296);
            this.textBoxMerged.Name = "textBoxMerged";
            this.textBoxMerged.ReadOnly = true;
            this.textBoxMerged.Size = new System.Drawing.Size(650, 23);
            this.textBoxMerged.TabIndex = 14;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(506, 258);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonMerge
            // 
            this.buttonMerge.Location = new System.Drawing.Point(587, 258);
            this.buttonMerge.Name = "buttonMerge";
            this.buttonMerge.Size = new System.Drawing.Size(75, 23);
            this.buttonMerge.TabIndex = 10;
            this.buttonMerge.Text = "Merge";
            this.buttonMerge.UseVisualStyleBackColor = true;
            this.buttonMerge.Click += new System.EventHandler(this.buttonMerge_Click);
            // 
            // lblFileOut
            // 
            this.lblFileOut.AutoSize = true;
            this.lblFileOut.Location = new System.Drawing.Point(12, 174);
            this.lblFileOut.Name = "lblFileOut";
            this.lblFileOut.Size = new System.Drawing.Size(96, 15);
            this.lblFileOut.TabIndex = 15;
            this.lblFileOut.Text = "Outupt Directory";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(12, 192);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(650, 50);
            this.textBoxOutput.TabIndex = 9;
            this.textBoxOutput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOutput_KeyPress);
            // 
            // lblFile2
            // 
            this.lblFile2.AutoSize = true;
            this.lblFile2.Location = new System.Drawing.Point(12, 92);
            this.lblFile2.Name = "lblFile2";
            this.lblFile2.Size = new System.Drawing.Size(182, 15);
            this.lblFile2.TabIndex = 11;
            this.lblFile2.Text = "Drag && Drop the pdf 2 document";
            // 
            // textBoxFile2
            // 
            this.textBoxFile2.AllowDrop = true;
            this.textBoxFile2.Location = new System.Drawing.Point(12, 112);
            this.textBoxFile2.Multiline = true;
            this.textBoxFile2.Name = "textBoxFile2";
            this.textBoxFile2.Size = new System.Drawing.Size(650, 50);
            this.textBoxFile2.TabIndex = 7;
            this.textBoxFile2.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxFile2_DragDrop);
            this.textBoxFile2.DragOver += new System.Windows.Forms.DragEventHandler(this.textBoxFile2_DragOver);
            // 
            // lblFile1
            // 
            this.lblFile1.AutoSize = true;
            this.lblFile1.Location = new System.Drawing.Point(12, 9);
            this.lblFile1.Name = "lblFile1";
            this.lblFile1.Size = new System.Drawing.Size(182, 15);
            this.lblFile1.TabIndex = 8;
            this.lblFile1.Text = "Drag && Drop the pdf 1 document";
            // 
            // textBoxFile1
            // 
            this.textBoxFile1.AllowDrop = true;
            this.textBoxFile1.Location = new System.Drawing.Point(12, 27);
            this.textBoxFile1.Multiline = true;
            this.textBoxFile1.Name = "textBoxFile1";
            this.textBoxFile1.Size = new System.Drawing.Size(650, 50);
            this.textBoxFile1.TabIndex = 6;
            this.textBoxFile1.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxFile1_DragDrop);
            this.textBoxFile1.DragOver += new System.Windows.Forms.DragEventHandler(this.textBoxFile1_DragOver);
            // 
            // FormMerge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 345);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textBoxMerged);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonMerge);
            this.Controls.Add(this.lblFileOut);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.lblFile2);
            this.Controls.Add(this.textBoxFile2);
            this.Controls.Add(this.lblFile1);
            this.Controls.Add(this.textBoxFile1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMerge";
            this.Text = "Merge two pdf documents";
            this.Load += new System.EventHandler(this.FormMerge_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxMerged;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonMerge;
        private System.Windows.Forms.Label lblFileOut;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Label lblFile2;
        private System.Windows.Forms.TextBox textBoxFile2;
        private System.Windows.Forms.Label lblFile1;
        private System.Windows.Forms.TextBox textBoxFile1;
    }
}