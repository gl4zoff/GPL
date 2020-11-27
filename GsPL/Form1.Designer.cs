namespace GsPL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Code = new System.Windows.Forms.ListBox();
            this.OpenFile = new System.Windows.Forms.Button();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.FileName = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Code
            // 
            this.Code.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Code.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Code.FormattingEnabled = true;
            this.Code.ItemHeight = 23;
            this.Code.Location = new System.Drawing.Point(13, 105);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(345, 577);
            this.Code.TabIndex = 0;
            // 
            // OpenFile
            // 
            this.OpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFile.Location = new System.Drawing.Point(12, 40);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(167, 50);
            this.OpenFile.TabIndex = 1;
            this.OpenFile.Text = "Open";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(13, 12);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(166, 22);
            this.FileName.TabIndex = 2;
            // 
            // Start
            // 
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Location = new System.Drawing.Point(185, 40);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(173, 50);
            this.Start.TabIndex = 4;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(185, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "(File name)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 700);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.OpenFile);
            this.Controls.Add(this.Code);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "gpl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Code;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label1;
    }
}

