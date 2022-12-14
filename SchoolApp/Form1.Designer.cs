namespace SchoolApp
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbProfesseurNom = new System.Windows.Forms.TextBox();
            this.tbProfesseurPrenom = new System.Windows.Forms.TextBox();
            this.tbProfesseurLogin = new System.Windows.Forms.TextBox();
            this.TbProfesseurPassword = new System.Windows.Forms.TextBox();
            this.tbClasseLabel = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(536, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "create prof";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tbProfesseurNom
            // 
            this.tbProfesseurNom.Location = new System.Drawing.Point(12, 14);
            this.tbProfesseurNom.Name = "tbProfesseurNom";
            this.tbProfesseurNom.Size = new System.Drawing.Size(125, 27);
            this.tbProfesseurNom.TabIndex = 1;
            // 
            // tbProfesseurPrenom
            // 
            this.tbProfesseurPrenom.Location = new System.Drawing.Point(143, 13);
            this.tbProfesseurPrenom.Name = "tbProfesseurPrenom";
            this.tbProfesseurPrenom.Size = new System.Drawing.Size(125, 27);
            this.tbProfesseurPrenom.TabIndex = 2;
            // 
            // tbProfesseurLogin
            // 
            this.tbProfesseurLogin.Location = new System.Drawing.Point(274, 13);
            this.tbProfesseurLogin.Name = "tbProfesseurLogin";
            this.tbProfesseurLogin.Size = new System.Drawing.Size(125, 27);
            this.tbProfesseurLogin.TabIndex = 3;
            // 
            // TbProfesseurPassword
            // 
            this.TbProfesseurPassword.Location = new System.Drawing.Point(405, 13);
            this.TbProfesseurPassword.Name = "TbProfesseurPassword";
            this.TbProfesseurPassword.Size = new System.Drawing.Size(125, 27);
            this.TbProfesseurPassword.TabIndex = 4;
            // 
            // tbClasseLabel
            // 
            this.tbClasseLabel.Location = new System.Drawing.Point(12, 47);
            this.tbClasseLabel.Name = "tbClasseLabel";
            this.tbClasseLabel.Size = new System.Drawing.Size(125, 27);
            this.tbClasseLabel.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(143, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 29);
            this.button2.TabIndex = 6;
            this.button2.Text = "create classe";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(647, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 29);
            this.button3.TabIndex = 7;
            this.button3.Text = "add classe";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(744, 14);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 29);
            this.button4.TabIndex = 8;
            this.button4.Text = "remove classe";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(261, 47);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 29);
            this.button5.TabIndex = 9;
            this.button5.Text = "add prof";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(358, 47);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(103, 29);
            this.button6.TabIndex = 10;
            this.button6.Text = "remove prof";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbClasseLabel);
            this.Controls.Add(this.TbProfesseurPassword);
            this.Controls.Add(this.tbProfesseurLogin);
            this.Controls.Add(this.tbProfesseurPrenom);
            this.Controls.Add(this.tbProfesseurNom);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox tbProfesseurNom;
        private TextBox tbProfesseurPrenom;
        private TextBox tbProfesseurLogin;
        private TextBox TbProfesseurPassword;
        private TextBox tbClasseLabel;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}