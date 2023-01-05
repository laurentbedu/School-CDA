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
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.boxLabelClasse = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numAnciennete)).BeginInit();
            this.SuspendLayout();
            // 
            // boxNom
            // 
            this.boxNom.Location = new System.Drawing.Point(104, 16);
            this.boxNom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boxNom.Name = "boxNom";
            this.boxNom.Size = new System.Drawing.Size(114, 27);
            this.boxNom.TabIndex = 0;
            this.boxNom.TextChanged += new System.EventHandler(this.boxNom_TextChanged);
            // 
            // boxPrenom
            // 
            this.boxPrenom.Location = new System.Drawing.Point(104, 55);
            this.boxPrenom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boxPrenom.Name = "boxPrenom";
            this.boxPrenom.Size = new System.Drawing.Size(114, 27);
            this.boxPrenom.TabIndex = 1;
            // 
            // boxLogin
            // 
            this.boxLogin.Location = new System.Drawing.Point(104, 93);
            this.boxLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boxLogin.Name = "boxLogin";
            this.boxLogin.Size = new System.Drawing.Size(114, 27);
            this.boxLogin.TabIndex = 2;
            // 
            // boxPassword
            // 
            this.boxPassword.Location = new System.Drawing.Point(104, 132);
            this.boxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boxPassword.Name = "boxPassword";
            this.boxPassword.Size = new System.Drawing.Size(114, 27);
            this.boxPassword.TabIndex = 3;
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Location = new System.Drawing.Point(26, 20);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(42, 20);
            this.nom.TabIndex = 4;
            this.nom.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 171);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Creer professeur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkAdmin
            // 
            this.checkAdmin.AutoSize = true;
            this.checkAdmin.Location = new System.Drawing.Point(225, 21);
            this.checkAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkAdmin.Name = "checkAdmin";
            this.checkAdmin.Size = new System.Drawing.Size(144, 24);
            this.checkAdmin.TabIndex = 9;
            this.checkAdmin.Text = "Administrateur ? ";
            this.checkAdmin.UseVisualStyleBackColor = true;
            // 
            // boxNomEleve
            // 
            this.boxNomEleve.Location = new System.Drawing.Point(447, 21);
            this.boxNomEleve.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boxNomEleve.Name = "boxNomEleve";
            this.boxNomEleve.Size = new System.Drawing.Size(114, 27);
            this.boxNomEleve.TabIndex = 10;
            this.boxNomEleve.TextChanged += new System.EventHandler(this.boxNomEleve_TextChanged);
            // 
            // boxPrenomEleve
            // 
            this.boxPrenomEleve.Location = new System.Drawing.Point(447, 65);
            this.boxPrenomEleve.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boxPrenomEleve.Name = "boxPrenomEleve";
            this.boxPrenomEleve.Size = new System.Drawing.Size(114, 27);
            this.boxPrenomEleve.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Prenom";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(437, 171);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 31);
            this.button2.TabIndex = 14;
            this.button2.Text = "Creer élève";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Anciennete";
            // 
            // numAnciennete
            // 
            this.numAnciennete.Location = new System.Drawing.Point(447, 125);
            this.numAnciennete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numAnciennete.Name = "numAnciennete";
            this.numAnciennete.Size = new System.Drawing.Size(137, 27);
            this.numAnciennete.TabIndex = 16;
            // 
            // cbBoxNiveau
            // 
            this.cbBoxNiveau.FormattingEnabled = true;
            this.cbBoxNiveau.Location = new System.Drawing.Point(675, 92);
            this.cbBoxNiveau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbBoxNiveau.Name = "cbBoxNiveau";
            this.cbBoxNiveau.Size = new System.Drawing.Size(138, 28);
            this.cbBoxNiveau.TabIndex = 17;
            this.cbBoxNiveau.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(725, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Classe";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(659, 129);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 31);
            this.button3.TabIndex = 19;
            this.button3.Text = "Creer nouvelle classe";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(659, 164);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(185, 31);
            this.button4.TabIndex = 21;
            this.button4.Text = "Ajouter professeur";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(72, 210);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(169, 31);
            this.button5.TabIndex = 22;
            this.button5.Text = "Supprimer professeur";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(659, 223);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(185, 31);
            this.button6.TabIndex = 23;
            this.button6.Text = "Supprimer élève";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(659, 195);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(185, 31);
            this.button7.TabIndex = 24;
            this.button7.Text = "Ajouter élève";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // boxLabelClasse
            // 
            this.boxLabelClasse.Location = new System.Drawing.Point(675, 47);
            this.boxLabelClasse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boxLabelClasse.Name = "boxLabelClasse";
            this.boxLabelClasse.Size = new System.Drawing.Size(138, 27);
            this.boxLabelClasse.TabIndex = 26;
            this.boxLabelClasse.TextChanged += new System.EventHandler(this.boxLabelClasse_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Selectionner un élève";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(36, 320);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(333, 184);
            this.listBox1.TabIndex = 29;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(408, 324);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(192, 29);
            this.button8.TabIndex = 30;
            this.button8.Text = "Charger DATALIST";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.boxLabelClasse);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private TextBox boxLabelClasse;
        private Label label8;
        private ListBox listBox1;
        private Button button8;
    }
}