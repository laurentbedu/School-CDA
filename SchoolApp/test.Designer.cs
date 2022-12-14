namespace SchoolApp
{
    partial class test
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
            this.bttest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttest
            // 
            this.bttest.Location = new System.Drawing.Point(117, 59);
            this.bttest.Name = "bttest";
            this.bttest.Size = new System.Drawing.Size(75, 23);
            this.bttest.TabIndex = 0;
            this.bttest.Text = "Test";
            this.bttest.UseVisualStyleBackColor = true;
            this.bttest.Click += new System.EventHandler(this.bttest_Click);
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttest);
            this.Name = "test";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button bttest;
    }
}