namespace SchoolApp
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
            this.boxNom = new System.Windows.Forms.TextBox();
            this.boxPrenom = new System.Windows.Forms.TextBox();
            this.boxLogin = new System.Windows.Forms.TextBox();
            this.boxPassword = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkAdmin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // boxNom
            // 
            this.boxNom.Location = new System.Drawing.Point(91, 12);
            this.boxNom.Name = "boxNom";
            this.boxNom.Size = new System.Drawing.Size(100, 23);
            this.boxNom.TabIndex = 0;
            this.boxNom.TextChanged += new System.EventHandler(this.boxNom_TextChanged);
            // 
            // boxPrenom
            // 
            this.boxPrenom.Location = new System.Drawing.Point(91, 41);
            this.boxPrenom.Name = "boxPrenom";
            this.boxPrenom.Size = new System.Drawing.Size(100, 23);
            this.boxPrenom.TabIndex = 1;
            // 
            // boxLogin
            // 
            this.boxLogin.Location = new System.Drawing.Point(91, 70);
            this.boxLogin.Name = "boxLogin";
            this.boxLogin.Size = new System.Drawing.Size(100, 23);
            this.boxLogin.TabIndex = 2;
            // 
            // boxPassword
            // 
            this.boxPassword.Location = new System.Drawing.Point(91, 99);
            this.boxPassword.Name = "boxPassword";
            this.boxPassword.Size = new System.Drawing.Size(100, 23);
            this.boxPassword.TabIndex = 3;
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Location = new System.Drawing.Point(23, 15);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(34, 15);
            this.nom.TabIndex = 4;
            this.nom.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Creer professeur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkAdmin
            // 
            this.checkAdmin.AutoSize = true;
            this.checkAdmin.Location = new System.Drawing.Point(197, 16);
            this.checkAdmin.Name = "checkAdmin";
            this.checkAdmin.Size = new System.Drawing.Size(116, 19);
            this.checkAdmin.TabIndex = 9;
            this.checkAdmin.Text = "Administrateur ? ";
            this.checkAdmin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkAdmin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.boxPassword);
            this.Controls.Add(this.boxLogin);
            this.Controls.Add(this.boxPrenom);
            this.Controls.Add(this.boxNom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox boxNom;
        private TextBox boxPrenom;
        private TextBox boxLogin;
        private TextBox boxPassword;
        private Label nom;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private CheckBox checkAdmin;
    }
}