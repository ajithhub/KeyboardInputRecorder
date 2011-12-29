using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.textEntry = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textEntry
            // 
            this.textEntry.Location = new System.Drawing.Point(24, 13);
            this.textEntry.Multiline = true;
            this.textEntry.Name = "textEntry";
            this.textEntry.Size = new System.Drawing.Size(398, 466);
            this.textEntry.TabIndex = 0;
            this.textEntry.KeyDown += new KeyEventHandler(this.textEntry_KeyDown);
            this.textEntry.KeyUp += new KeyEventHandler(this.textEntry_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 514);
            this.Controls.Add(this.textEntry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textEntry;
    }
}

