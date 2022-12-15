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
            this.cbNiveauClasse = new System.Windows.Forms.ComboBox();
            this.tbEleveNom = new System.Windows.Forms.TextBox();
            this.tbElevePrenom = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.cbMatiere = new System.Windows.Forms.ComboBox();
            this.nudNoteValeur = new System.Windows.Forms.NumericUpDown();
            this.button12 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoteValeur)).BeginInit();
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
            this.button2.Location = new System.Drawing.Point(274, 47);
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
            this.button5.Location = new System.Drawing.Point(392, 47);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 29);
            this.button5.TabIndex = 9;
            this.button5.Text = "add prof";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(489, 48);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(103, 29);
            this.button6.TabIndex = 10;
            this.button6.Text = "remove prof";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // cbNiveauClasse
            // 
            this.cbNiveauClasse.FormattingEnabled = true;
            this.cbNiveauClasse.Location = new System.Drawing.Point(143, 48);
            this.cbNiveauClasse.Name = "cbNiveauClasse";
            this.cbNiveauClasse.Size = new System.Drawing.Size(125, 28);
            this.cbNiveauClasse.TabIndex = 11;
            // 
            // tbEleveNom
            // 
            this.tbEleveNom.Location = new System.Drawing.Point(12, 80);
            this.tbEleveNom.Name = "tbEleveNom";
            this.tbEleveNom.Size = new System.Drawing.Size(125, 27);
            this.tbEleveNom.TabIndex = 12;
            // 
            // tbElevePrenom
            // 
            this.tbElevePrenom.Location = new System.Drawing.Point(143, 80);
            this.tbElevePrenom.Name = "tbElevePrenom";
            this.tbElevePrenom.Size = new System.Drawing.Size(125, 27);
            this.tbElevePrenom.TabIndex = 13;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(274, 78);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(112, 29);
            this.button7.TabIndex = 14;
            this.button7.Text = "create eleve";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(392, 79);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(91, 29);
            this.button8.TabIndex = 15;
            this.button8.Text = "add classe";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(489, 80);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(115, 29);
            this.button9.TabIndex = 16;
            this.button9.Text = "remove classe";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(598, 48);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(91, 29);
            this.button10.TabIndex = 17;
            this.button10.Text = "add eleve";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(695, 47);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(123, 29);
            this.button11.TabIndex = 18;
            this.button11.Text = "remove eleve";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // cbMatiere
            // 
            this.cbMatiere.FormattingEnabled = true;
            this.cbMatiere.Location = new System.Drawing.Point(143, 113);
            this.cbMatiere.Name = "cbMatiere";
            this.cbMatiere.Size = new System.Drawing.Size(125, 28);
            this.cbMatiere.TabIndex = 19;
            // 
            // nudNoteValeur
            // 
            this.nudNoteValeur.DecimalPlaces = 1;
            this.nudNoteValeur.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudNoteValeur.Location = new System.Drawing.Point(84, 114);
            this.nudNoteValeur.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudNoteValeur.Name = "nudNoteValeur";
            this.nudNoteValeur.Size = new System.Drawing.Size(53, 27);
            this.nudNoteValeur.TabIndex = 20;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(274, 114);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(112, 29);
            this.button12.TabIndex = 21;
            this.button12.Text = "create note";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 450);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.nudNoteValeur);
            this.Controls.Add(this.cbMatiere);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.tbElevePrenom);
            this.Controls.Add(this.tbEleveNom);
            this.Controls.Add(this.cbNiveauClasse);
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
            ((System.ComponentModel.ISupportInitialize)(this.nudNoteValeur)).EndInit();
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
        private ComboBox cbNiveauClasse;
        private TextBox tbEleveNom;
        private TextBox tbElevePrenom;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private ComboBox cbMatiere;
        private NumericUpDown nudNoteValeur;
        private Button button12;
    }
}