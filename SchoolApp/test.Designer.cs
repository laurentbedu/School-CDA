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
            this.BoxNom = new System.Windows.Forms.TextBox();
            this.BoxPrenom = new System.Windows.Forms.TextBox();
            this.BtProf = new System.Windows.Forms.Button();
            this.BoxLogin = new System.Windows.Forms.TextBox();
            this.BoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BoxNom
            // 
            this.BoxNom.Location = new System.Drawing.Point(100, 15);
            this.BoxNom.Name = "BoxNom";
            this.BoxNom.Size = new System.Drawing.Size(100, 23);
            this.BoxNom.TabIndex = 0;
            this.BoxNom.TextChanged += new System.EventHandler(this.BoxNom_TextChanged);
            // 
            // BoxPrenom
            // 
            this.BoxPrenom.Location = new System.Drawing.Point(100, 44);
            this.BoxPrenom.Name = "BoxPrenom";
            this.BoxPrenom.Size = new System.Drawing.Size(100, 23);
            this.BoxPrenom.TabIndex = 1;
            // 
            // BtProf
            // 
            this.BtProf.Location = new System.Drawing.Point(100, 142);
            this.BtProf.Name = "BtProf";
            this.BtProf.Size = new System.Drawing.Size(100, 52);
            this.BtProf.TabIndex = 2;
            this.BtProf.Text = "Creer professeur";
            this.BtProf.UseVisualStyleBackColor = true;
            this.BtProf.Click += new System.EventHandler(this.BtProf_Click);
            // 
            // BoxLogin
            // 
            this.BoxLogin.Location = new System.Drawing.Point(100, 73);
            this.BoxLogin.Name = "BoxLogin";
            this.BoxLogin.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.BoxLogin.Size = new System.Drawing.Size(100, 23);
            this.BoxLogin.TabIndex = 3;
            this.BoxLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BoxPassword
            // 
            this.BoxPassword.Location = new System.Drawing.Point(100, 102);
            this.BoxPassword.Name = "BoxPassword";
            this.BoxPassword.Size = new System.Drawing.Size(100, 23);
            this.BoxPassword.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Password.Location = new System.Drawing.Point(12, 99);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(82, 21);
            this.Password.TabIndex = 6;
            this.Password.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Prenom";
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BoxPassword);
            this.Controls.Add(this.BoxLogin);
            this.Controls.Add(this.BtProf);
            this.Controls.Add(this.BoxPrenom);
            this.Controls.Add(this.BoxNom);
            this.Name = "test";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox BoxNom;
        private TextBox BoxPrenom;
        private Button BtProf;
        private TextBox BoxLogin;
        private TextBox BoxPassword;
        private Label label1;
        private Label Password;
        private Label label3;
        private Label label4;
    }
}