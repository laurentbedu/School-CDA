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
            this.buttonCreerProf = new System.Windows.Forms.Button();
            this.buttonCreerEleve = new System.Windows.Forms.Button();
            this.textBoxNomEleve = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPrenomEleve = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPrenomProf = new System.Windows.Forms.TextBox();
            this.textBoxNomProf = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxClasseEleve = new System.Windows.Forms.ComboBox();
            this.numericUpDownAncienneteEleve = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonCreerClasse = new System.Windows.Forms.Button();
            this.textBoxNomClasse = new System.Windows.Forms.TextBox();
            this.buttonAddClasseProf = new System.Windows.Forms.Button();
            this.buttonRemoveClasseProf = new System.Windows.Forms.Button();
            this.buttonRemoveProfClasse = new System.Windows.Forms.Button();
            this.buttonAddProfClasse = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxClasseProf = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonRemoveClasseEleve = new System.Windows.Forms.Button();
            this.buttonAddClasseEleve = new System.Windows.Forms.Button();
            this.comboBoxNiveauClasse = new System.Windows.Forms.ComboBox();
            this.comboBoxProfClasse = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxPasswordProf = new System.Windows.Forms.TextBox();
            this.textBoxLoginProf = new System.Windows.Forms.TextBox();
            this.comboBoxEleveClasse = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.buttonRemoveEleveClasse = new System.Windows.Forms.Button();
            this.buttonAddEleveClasse = new System.Windows.Forms.Button();
            this.buttonJson = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAncienneteEleve)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreerProf
            // 
            this.buttonCreerProf.Location = new System.Drawing.Point(364, 166);
            this.buttonCreerProf.Name = "buttonCreerProf";
            this.buttonCreerProf.Size = new System.Drawing.Size(132, 27);
            this.buttonCreerProf.TabIndex = 0;
            this.buttonCreerProf.Text = "Créer prof";
            this.buttonCreerProf.UseVisualStyleBackColor = true;
            this.buttonCreerProf.Click += new System.EventHandler(this.buttonCreerProf_Click);
            // 
            // buttonCreerEleve
            // 
            this.buttonCreerEleve.Location = new System.Drawing.Point(95, 131);
            this.buttonCreerEleve.Name = "buttonCreerEleve";
            this.buttonCreerEleve.Size = new System.Drawing.Size(132, 34);
            this.buttonCreerEleve.TabIndex = 1;
            this.buttonCreerEleve.Text = "Creer eleve";
            this.buttonCreerEleve.UseVisualStyleBackColor = true;
            this.buttonCreerEleve.Click += new System.EventHandler(this.buttonCreerEleve_Click);
            // 
            // textBoxNomEleve
            // 
            this.textBoxNomEleve.Location = new System.Drawing.Point(80, 32);
            this.textBoxNomEleve.Name = "textBoxNomEleve";
            this.textBoxNomEleve.Size = new System.Drawing.Size(148, 27);
            this.textBoxNomEleve.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prénom :";
            // 
            // textBoxPrenomEleve
            // 
            this.textBoxPrenomEleve.Location = new System.Drawing.Point(80, 65);
            this.textBoxPrenomEleve.Name = "textBoxPrenomEleve";
            this.textBoxPrenomEleve.Size = new System.Drawing.Size(148, 27);
            this.textBoxPrenomEleve.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Classe :";
            // 
            // textBoxPrenomProf
            // 
            this.textBoxPrenomProf.Location = new System.Drawing.Point(348, 65);
            this.textBoxPrenomProf.Name = "textBoxPrenomProf";
            this.textBoxPrenomProf.Size = new System.Drawing.Size(148, 27);
            this.textBoxPrenomProf.TabIndex = 11;
            // 
            // textBoxNomProf
            // 
            this.textBoxNomProf.Location = new System.Drawing.Point(348, 32);
            this.textBoxNomProf.Name = "textBoxNomProf";
            this.textBoxNomProf.Size = new System.Drawing.Size(148, 27);
            this.textBoxNomProf.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Anciennete :";
            // 
            // comboBoxClasseEleve
            // 
            this.comboBoxClasseEleve.FormattingEnabled = true;
            this.comboBoxClasseEleve.Location = new System.Drawing.Point(80, 183);
            this.comboBoxClasseEleve.Name = "comboBoxClasseEleve";
            this.comboBoxClasseEleve.Size = new System.Drawing.Size(148, 28);
            this.comboBoxClasseEleve.TabIndex = 17;
            // 
            // numericUpDownAncienneteEleve
            // 
            this.numericUpDownAncienneteEleve.Location = new System.Drawing.Point(139, 98);
            this.numericUpDownAncienneteEleve.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownAncienneteEleve.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAncienneteEleve.Name = "numericUpDownAncienneteEleve";
            this.numericUpDownAncienneteEleve.Size = new System.Drawing.Size(88, 27);
            this.numericUpDownAncienneteEleve.TabIndex = 18;
            this.numericUpDownAncienneteEleve.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "ELEVE :";
            // 
            // buttonCreerClasse
            // 
            this.buttonCreerClasse.Location = new System.Drawing.Point(646, 99);
            this.buttonCreerClasse.Name = "buttonCreerClasse";
            this.buttonCreerClasse.Size = new System.Drawing.Size(134, 29);
            this.buttonCreerClasse.TabIndex = 22;
            this.buttonCreerClasse.Text = "Créer classe";
            this.buttonCreerClasse.UseVisualStyleBackColor = true;
            this.buttonCreerClasse.Click += new System.EventHandler(this.buttonCreerClasse_Click);
            // 
            // textBoxNomClasse
            // 
            this.textBoxNomClasse.Location = new System.Drawing.Point(654, 32);
            this.textBoxNomClasse.Name = "textBoxNomClasse";
            this.textBoxNomClasse.Size = new System.Drawing.Size(125, 27);
            this.textBoxNomClasse.TabIndex = 24;
            // 
            // buttonAddClasseProf
            // 
            this.buttonAddClasseProf.Location = new System.Drawing.Point(325, 254);
            this.buttonAddClasseProf.Name = "buttonAddClasseProf";
            this.buttonAddClasseProf.Size = new System.Drawing.Size(82, 60);
            this.buttonAddClasseProf.TabIndex = 26;
            this.buttonAddClasseProf.Text = "Ajouter classe";
            this.buttonAddClasseProf.UseVisualStyleBackColor = true;
            this.buttonAddClasseProf.Click += new System.EventHandler(this.buttonAddClasse_Click);
            // 
            // buttonRemoveClasseProf
            // 
            this.buttonRemoveClasseProf.Location = new System.Drawing.Point(413, 254);
            this.buttonRemoveClasseProf.Name = "buttonRemoveClasseProf";
            this.buttonRemoveClasseProf.Size = new System.Drawing.Size(82, 60);
            this.buttonRemoveClasseProf.TabIndex = 27;
            this.buttonRemoveClasseProf.Text = "Enlever classe";
            this.buttonRemoveClasseProf.UseVisualStyleBackColor = true;
            this.buttonRemoveClasseProf.Click += new System.EventHandler(this.buttonRemoveClasse_Click);
            // 
            // buttonRemoveProfClasse
            // 
            this.buttonRemoveProfClasse.Location = new System.Drawing.Point(704, 176);
            this.buttonRemoveProfClasse.Name = "buttonRemoveProfClasse";
            this.buttonRemoveProfClasse.Size = new System.Drawing.Size(77, 55);
            this.buttonRemoveProfClasse.TabIndex = 29;
            this.buttonRemoveProfClasse.Text = "Enlever prof";
            this.buttonRemoveProfClasse.UseVisualStyleBackColor = true;
            this.buttonRemoveProfClasse.Click += new System.EventHandler(this.buttonRemoveProf_Click);
            // 
            // buttonAddProfClasse
            // 
            this.buttonAddProfClasse.Location = new System.Drawing.Point(621, 176);
            this.buttonAddProfClasse.Name = "buttonAddProfClasse";
            this.buttonAddProfClasse.Size = new System.Drawing.Size(77, 57);
            this.buttonAddProfClasse.TabIndex = 28;
            this.buttonAddProfClasse.Text = "Ajouter prof";
            this.buttonAddProfClasse.UseVisualStyleBackColor = true;
            this.buttonAddProfClasse.Click += new System.EventHandler(this.buttonAddProf_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "PROFESSEUR :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Prénom :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Nom :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(654, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 33;
            this.label9.Text = "CLASSE :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(599, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 34;
            this.label10.Text = "Nom :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(563, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 20);
            this.label11.TabIndex = 36;
            this.label11.Text = "Niveau :";
            // 
            // comboBoxClasseProf
            // 
            this.comboBoxClasseProf.FormattingEnabled = true;
            this.comboBoxClasseProf.Location = new System.Drawing.Point(348, 213);
            this.comboBoxClasseProf.Name = "comboBoxClasseProf";
            this.comboBoxClasseProf.Size = new System.Drawing.Size(148, 28);
            this.comboBoxClasseProf.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(285, 221);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 20);
            this.label12.TabIndex = 37;
            this.label12.Text = "Classe :";
            // 
            // buttonRemoveClasseEleve
            // 
            this.buttonRemoveClasseEleve.Location = new System.Drawing.Point(146, 226);
            this.buttonRemoveClasseEleve.Name = "buttonRemoveClasseEleve";
            this.buttonRemoveClasseEleve.Size = new System.Drawing.Size(82, 60);
            this.buttonRemoveClasseEleve.TabIndex = 40;
            this.buttonRemoveClasseEleve.Text = "Enlever classe";
            this.buttonRemoveClasseEleve.UseVisualStyleBackColor = true;
            // 
            // buttonAddClasseEleve
            // 
            this.buttonAddClasseEleve.Location = new System.Drawing.Point(58, 226);
            this.buttonAddClasseEleve.Name = "buttonAddClasseEleve";
            this.buttonAddClasseEleve.Size = new System.Drawing.Size(82, 60);
            this.buttonAddClasseEleve.TabIndex = 39;
            this.buttonAddClasseEleve.Text = "Ajouter classe";
            this.buttonAddClasseEleve.UseVisualStyleBackColor = true;
            // 
            // comboBoxNiveauClasse
            // 
            this.comboBoxNiveauClasse.FormattingEnabled = true;
            this.comboBoxNiveauClasse.Location = new System.Drawing.Point(631, 65);
            this.comboBoxNiveauClasse.Name = "comboBoxNiveauClasse";
            this.comboBoxNiveauClasse.Size = new System.Drawing.Size(148, 28);
            this.comboBoxNiveauClasse.TabIndex = 41;
            // 
            // comboBoxProfClasse
            // 
            this.comboBoxProfClasse.FormattingEnabled = true;
            this.comboBoxProfClasse.Location = new System.Drawing.Point(632, 142);
            this.comboBoxProfClasse.Name = "comboBoxProfClasse";
            this.comboBoxProfClasse.Size = new System.Drawing.Size(148, 28);
            this.comboBoxProfClasse.TabIndex = 43;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(583, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 20);
            this.label13.TabIndex = 42;
            this.label13.Text = "Prof :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(269, 142);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 20);
            this.label14.TabIndex = 47;
            this.label14.Text = "Password :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(293, 107);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 20);
            this.label15.TabIndex = 46;
            this.label15.Text = "Login :";
            // 
            // textBoxPasswordProf
            // 
            this.textBoxPasswordProf.Location = new System.Drawing.Point(348, 133);
            this.textBoxPasswordProf.Name = "textBoxPasswordProf";
            this.textBoxPasswordProf.Size = new System.Drawing.Size(148, 27);
            this.textBoxPasswordProf.TabIndex = 45;
            // 
            // textBoxLoginProf
            // 
            this.textBoxLoginProf.Location = new System.Drawing.Point(348, 100);
            this.textBoxLoginProf.Name = "textBoxLoginProf";
            this.textBoxLoginProf.Size = new System.Drawing.Size(148, 27);
            this.textBoxLoginProf.TabIndex = 44;
            // 
            // comboBoxEleveClasse
            // 
            this.comboBoxEleveClasse.FormattingEnabled = true;
            this.comboBoxEleveClasse.Location = new System.Drawing.Point(632, 247);
            this.comboBoxEleveClasse.Name = "comboBoxEleveClasse";
            this.comboBoxEleveClasse.Size = new System.Drawing.Size(148, 28);
            this.comboBoxEleveClasse.TabIndex = 51;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(583, 255);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 20);
            this.label16.TabIndex = 50;
            this.label16.Text = "Eleve :";
            // 
            // buttonRemoveEleveClasse
            // 
            this.buttonRemoveEleveClasse.Location = new System.Drawing.Point(704, 281);
            this.buttonRemoveEleveClasse.Name = "buttonRemoveEleveClasse";
            this.buttonRemoveEleveClasse.Size = new System.Drawing.Size(77, 55);
            this.buttonRemoveEleveClasse.TabIndex = 49;
            this.buttonRemoveEleveClasse.Text = "Enlever eleve";
            this.buttonRemoveEleveClasse.UseVisualStyleBackColor = true;
            // 
            // buttonAddEleveClasse
            // 
            this.buttonAddEleveClasse.Location = new System.Drawing.Point(621, 281);
            this.buttonAddEleveClasse.Name = "buttonAddEleveClasse";
            this.buttonAddEleveClasse.Size = new System.Drawing.Size(77, 57);
            this.buttonAddEleveClasse.TabIndex = 48;
            this.buttonAddEleveClasse.Text = "Ajouter eleve";
            this.buttonAddEleveClasse.UseVisualStyleBackColor = true;
            this.buttonAddEleveClasse.Click += new System.EventHandler(this.buttonAddEleveClasse_Click);
            // 
            // buttonJson
            // 
            this.buttonJson.Location = new System.Drawing.Point(110, 386);
            this.buttonJson.Name = "buttonJson";
            this.buttonJson.Size = new System.Drawing.Size(94, 29);
            this.buttonJson.TabIndex = 52;
            this.buttonJson.Text = "lire json";
            this.buttonJson.UseVisualStyleBackColor = true;
            this.buttonJson.Click += new System.EventHandler(this.buttonJson_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 450);
            this.Controls.Add(this.buttonJson);
            this.Controls.Add(this.comboBoxEleveClasse);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.buttonRemoveEleveClasse);
            this.Controls.Add(this.buttonAddEleveClasse);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBoxPasswordProf);
            this.Controls.Add(this.textBoxLoginProf);
            this.Controls.Add(this.comboBoxProfClasse);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comboBoxNiveauClasse);
            this.Controls.Add(this.buttonRemoveClasseEleve);
            this.Controls.Add(this.buttonAddClasseEleve);
            this.Controls.Add(this.comboBoxClasseProf);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonRemoveProfClasse);
            this.Controls.Add(this.buttonAddProfClasse);
            this.Controls.Add(this.buttonRemoveClasseProf);
            this.Controls.Add(this.buttonAddClasseProf);
            this.Controls.Add(this.textBoxNomClasse);
            this.Controls.Add(this.buttonCreerClasse);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDownAncienneteEleve);
            this.Controls.Add(this.comboBoxClasseEleve);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxPrenomProf);
            this.Controls.Add(this.textBoxNomProf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPrenomEleve);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNomEleve);
            this.Controls.Add(this.buttonCreerEleve);
            this.Controls.Add(this.buttonCreerProf);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAncienneteEleve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonCreerProf;
        private Button buttonCreerEleve;
        private TextBox textBoxNomEleve;
        private Label label1;
        private Label label2;
        private TextBox textBoxPrenomEleve;
        private Label label3;
        private TextBox textBoxPrenomProf;
        private TextBox textBoxNomProf;
        private Label label7;
        private ComboBox comboBoxClasseEleve;
        private NumericUpDown numericUpDownAncienneteEleve;
        private Label label8;
        private Button buttonCreerClasse;
        private TextBox textBoxNomClasse;
        private Button buttonAddClasseProf;
        private Button buttonRemoveClasseProf;
        private Button buttonRemoveProfClasse;
        private Button buttonAddProfClasse;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label9;
        private Label label10;
        private Label label11;
        private ComboBox comboBoxClasseProf;
        private Label label12;
        private Button buttonRemoveClasseEleve;
        private Button buttonAddClasseEleve;
        private ComboBox comboBoxNiveauClasse;
        private ComboBox comboBoxProfClasse;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox textBoxPasswordProf;
        private TextBox textBoxLoginProf;
        private ComboBox comboBoxEleveClasse;
        private Label label16;
        private Button buttonRemoveEleveClasse;
        private Button buttonAddEleveClasse;
        private Button buttonJson;
    }
}