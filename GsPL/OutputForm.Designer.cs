namespace GsPL
{
    partial class OutputForm
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
            this.OutputTB = new System.Windows.Forms.TextBox();
            this.InputTB = new System.Windows.Forms.TextBox();
            this.Enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OutputTB
            // 
            this.OutputTB.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputTB.Location = new System.Drawing.Point(13, 13);
            this.OutputTB.Multiline = true;
            this.OutputTB.Name = "OutputTB";
            this.OutputTB.Size = new System.Drawing.Size(489, 329);
            this.OutputTB.TabIndex = 0;
            // 
            // InputTB
            // 
            this.InputTB.Enabled = false;
            this.InputTB.Location = new System.Drawing.Point(13, 349);
            this.InputTB.Name = "InputTB";
            this.InputTB.Size = new System.Drawing.Size(373, 22);
            this.InputTB.TabIndex = 1;
            // 
            // Enter
            // 
            this.Enter.Enabled = false;
            this.Enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enter.Location = new System.Drawing.Point(392, 349);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(109, 22);
            this.Enter.TabIndex = 2;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = true;
            // 
            // OutputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 382);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.InputTB);
            this.Controls.Add(this.OutputTB);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OutputForm";
            this.ShowIcon = false;
            this.Text = "Console";
            this.Load += new System.EventHandler(this.OutputForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OutputTB;
        private System.Windows.Forms.TextBox InputTB;
        private System.Windows.Forms.Button Enter;
    }
}