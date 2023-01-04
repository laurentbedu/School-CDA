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
            this.boxNomEleve = new System.Windows.Forms.TextBox();
            this.boxPrenomEleve = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numAnciennete = new System.Windows.Forms.NumericUpDown();
            this.cbBoxNiveau = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.boxLabelClasse = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numAnciennete)).BeginInit();
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
            // boxNomEleve
            // 
            this.boxNomEleve.Location = new System.Drawing.Point(391, 16);
            this.boxNomEleve.Name = "boxNomEleve";
            this.boxNomEleve.Size = new System.Drawing.Size(100, 23);
            this.boxNomEleve.TabIndex = 10;
            // 
            // boxPrenomEleve
            // 
            this.boxPrenomEleve.Location = new System.Drawing.Point(391, 49);
            this.boxPrenomEleve.Name = "boxPrenomEleve";
            this.boxPrenomEleve.Size = new System.Drawing.Size(100, 23);
            this.boxPrenomEleve.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Prenom";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(382, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Creer élève";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(318, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Anciennete";
            // 
            // numAnciennete
            // 
            this.numAnciennete.Location = new System.Drawing.Point(391, 94);
            this.numAnciennete.Name = "numAnciennete";
            this.numAnciennete.Size = new System.Drawing.Size(120, 23);
            this.numAnciennete.TabIndex = 16;
            // 
            // cbBoxNiveau
            // 
            this.cbBoxNiveau.FormattingEnabled = true;
            this.cbBoxNiveau.Location = new System.Drawing.Point(588, 75);
            this.cbBoxNiveau.Name = "cbBoxNiveau";
            this.cbBoxNiveau.Size = new System.Drawing.Size(121, 23);
            this.cbBoxNiveau.TabIndex = 17;
            this.cbBoxNiveau.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(634, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Classe";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(573, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Creer nouvelle classe";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // boxLabelClasse
            // 
            this.boxLabelClasse.Location = new System.Drawing.Point(588, 41);
            this.boxLabelClasse.Name = "boxLabelClasse";
            this.boxLabelClasse.Size = new System.Drawing.Size(100, 23);
            this.boxLabelClasse.TabIndex = 20;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(573, 104);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(162, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "Ajouter professeur";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.boxLabelClasse);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbBoxNiveau);
            this.Controls.Add(this.numAnciennete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxPrenomEleve);
            this.Controls.Add(this.boxNomEleve);
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
            ((System.ComponentModel.ISupportInitialize)(this.numAnciennete)).EndInit();
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
        private TextBox boxNomEleve;
        private TextBox boxPrenomEleve;
        private Label label1;
        private Label label5;
        private Button button2;
        private Label label6;
        private NumericUpDown numAnciennete;
        private ComboBox cbBoxNiveau;
        private Label label7;
        private Button button3;
        private TextBox boxLabelClasse;
        private Button button4;
    }
}