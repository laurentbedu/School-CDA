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
            this.checkBoxAdminProf = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonVoirEleves = new System.Windows.Forms.Button();
            this.buttonVoirClasses = new System.Windows.Forms.Button();
            this.buttonVoirProfs = new System.Windows.Forms.Button();
            this.buttonVoirNiveaux = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAncienneteEleve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCreerProf
            // 
            this.buttonCreerProf.Location = new System.Drawing.Point(103, 198);
            this.buttonCreerProf.Name = "buttonCreerProf";
            this.buttonCreerProf.Size = new System.Drawing.Size(132, 27);
            this.buttonCreerProf.TabIndex = 0;
            this.buttonCreerProf.Text = "Créer prof";
            this.buttonCreerProf.UseVisualStyleBackColor = true;
            this.buttonCreerProf.Click += new System.EventHandler(this.ButtonCreerProf_Click);
            // 
            // buttonCreerEleve
            // 
            this.buttonCreerEleve.Location = new System.Drawing.Point(102, 725);
            this.buttonCreerEleve.Name = "buttonCreerEleve";
            this.buttonCreerEleve.Size = new System.Drawing.Size(132, 34);
            this.buttonCreerEleve.TabIndex = 1;
            this.buttonCreerEleve.Text = "Creer eleve";
            this.buttonCreerEleve.UseVisualStyleBackColor = true;
            this.buttonCreerEleve.Click += new System.EventHandler(this.ButtonCreerEleve_Click);
            // 
            // textBoxNomEleve
            // 
            this.textBoxNomEleve.Location = new System.Drawing.Point(87, 626);
            this.textBoxNomEleve.Name = "textBoxNomEleve";
            this.textBoxNomEleve.Size = new System.Drawing.Size(148, 27);
            this.textBoxNomEleve.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 633);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 666);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prénom :";
            // 
            // textBoxPrenomEleve
            // 
            this.textBoxPrenomEleve.Location = new System.Drawing.Point(87, 659);
            this.textBoxPrenomEleve.Name = "textBoxPrenomEleve";
            this.textBoxPrenomEleve.Size = new System.Drawing.Size(148, 27);
            this.textBoxPrenomEleve.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 830);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Classe :";
            // 
            // textBoxPrenomProf
            // 
            this.textBoxPrenomProf.Location = new System.Drawing.Point(87, 67);
            this.textBoxPrenomProf.Name = "textBoxPrenomProf";
            this.textBoxPrenomProf.Size = new System.Drawing.Size(148, 27);
            this.textBoxPrenomProf.TabIndex = 11;
            // 
            // textBoxNomProf
            // 
            this.textBoxNomProf.Location = new System.Drawing.Point(87, 34);
            this.textBoxNomProf.Name = "textBoxNomProf";
            this.textBoxNomProf.Size = new System.Drawing.Size(148, 27);
            this.textBoxNomProf.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 699);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Anciennete :";
            // 
            // comboBoxClasseEleve
            // 
            this.comboBoxClasseEleve.FormattingEnabled = true;
            this.comboBoxClasseEleve.Location = new System.Drawing.Point(93, 822);
            this.comboBoxClasseEleve.Name = "comboBoxClasseEleve";
            this.comboBoxClasseEleve.Size = new System.Drawing.Size(148, 28);
            this.comboBoxClasseEleve.TabIndex = 17;
            // 
            // numericUpDownAncienneteEleve
            // 
            this.numericUpDownAncienneteEleve.Location = new System.Drawing.Point(146, 692);
            this.numericUpDownAncienneteEleve.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownAncienneteEleve.Name = "numericUpDownAncienneteEleve";
            this.numericUpDownAncienneteEleve.Size = new System.Drawing.Size(88, 27);
            this.numericUpDownAncienneteEleve.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(87, 603);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "ELEVE :";
            // 
            // buttonCreerClasse
            // 
            this.buttonCreerClasse.Location = new System.Drawing.Point(98, 367);
            this.buttonCreerClasse.Name = "buttonCreerClasse";
            this.buttonCreerClasse.Size = new System.Drawing.Size(134, 29);
            this.buttonCreerClasse.TabIndex = 22;
            this.buttonCreerClasse.Text = "Créer classe";
            this.buttonCreerClasse.UseVisualStyleBackColor = true;
            this.buttonCreerClasse.Click += new System.EventHandler(this.ButtonCreerClasse_Click);
            // 
            // textBoxNomClasse
            // 
            this.textBoxNomClasse.Location = new System.Drawing.Point(106, 300);
            this.textBoxNomClasse.Name = "textBoxNomClasse";
            this.textBoxNomClasse.Size = new System.Drawing.Size(125, 27);
            this.textBoxNomClasse.TabIndex = 24;
            // 
            // buttonRemoveProfClasse
            // 
            this.buttonRemoveProfClasse.Location = new System.Drawing.Point(154, 484);
            this.buttonRemoveProfClasse.Name = "buttonRemoveProfClasse";
            this.buttonRemoveProfClasse.Size = new System.Drawing.Size(77, 55);
            this.buttonRemoveProfClasse.TabIndex = 29;
            this.buttonRemoveProfClasse.Text = "Enlever prof";
            this.buttonRemoveProfClasse.UseVisualStyleBackColor = true;
            this.buttonRemoveProfClasse.Click += new System.EventHandler(this.ButtonRemoveProf_Click);
            // 
            // buttonAddProfClasse
            // 
            this.buttonAddProfClasse.Location = new System.Drawing.Point(71, 484);
            this.buttonAddProfClasse.Name = "buttonAddProfClasse";
            this.buttonAddProfClasse.Size = new System.Drawing.Size(77, 57);
            this.buttonAddProfClasse.TabIndex = 28;
            this.buttonAddProfClasse.Text = "Ajouter prof";
            this.buttonAddProfClasse.UseVisualStyleBackColor = true;
            this.buttonAddProfClasse.Click += new System.EventHandler(this.ButtonAddProf_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "PROFESSEUR :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Prénom :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Nom :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(106, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 33;
            this.label9.Text = "CLASSE :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 34;
            this.label10.Text = "Nom :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 341);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 20);
            this.label11.TabIndex = 36;
            this.label11.Text = "Niveau :";
            // 
            // comboBoxClasseProf
            // 
            this.comboBoxClasseProf.FormattingEnabled = true;
            this.comboBoxClasseProf.Location = new System.Drawing.Point(82, 415);
            this.comboBoxClasseProf.Name = "comboBoxClasseProf";
            this.comboBoxClasseProf.Size = new System.Drawing.Size(148, 28);
            this.comboBoxClasseProf.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 423);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 20);
            this.label12.TabIndex = 37;
            this.label12.Text = "Classe :";
            // 
            // comboBoxNiveauClasse
            // 
            this.comboBoxNiveauClasse.FormattingEnabled = true;
            this.comboBoxNiveauClasse.Location = new System.Drawing.Point(83, 333);
            this.comboBoxNiveauClasse.Name = "comboBoxNiveauClasse";
            this.comboBoxNiveauClasse.Size = new System.Drawing.Size(148, 28);
            this.comboBoxNiveauClasse.TabIndex = 41;
            // 
            // comboBoxProfClasse
            // 
            this.comboBoxProfClasse.FormattingEnabled = true;
            this.comboBoxProfClasse.Location = new System.Drawing.Point(82, 450);
            this.comboBoxProfClasse.Name = "comboBoxProfClasse";
            this.comboBoxProfClasse.Size = new System.Drawing.Size(148, 28);
            this.comboBoxProfClasse.TabIndex = 43;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 458);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 20);
            this.label13.TabIndex = 42;
            this.label13.Text = "Prof :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 20);
            this.label14.TabIndex = 47;
            this.label14.Text = "Password :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(32, 109);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 20);
            this.label15.TabIndex = 46;
            this.label15.Text = "Login :";
            // 
            // textBoxPasswordProf
            // 
            this.textBoxPasswordProf.Location = new System.Drawing.Point(87, 135);
            this.textBoxPasswordProf.Name = "textBoxPasswordProf";
            this.textBoxPasswordProf.Size = new System.Drawing.Size(148, 27);
            this.textBoxPasswordProf.TabIndex = 45;
            this.textBoxPasswordProf.Text = "PasswordDefault";
            // 
            // textBoxLoginProf
            // 
            this.textBoxLoginProf.Location = new System.Drawing.Point(87, 102);
            this.textBoxLoginProf.Name = "textBoxLoginProf";
            this.textBoxLoginProf.Size = new System.Drawing.Size(148, 27);
            this.textBoxLoginProf.TabIndex = 44;
            this.textBoxLoginProf.Text = "LoginDefault";
            // 
            // comboBoxEleveClasse
            // 
            this.comboBoxEleveClasse.FormattingEnabled = true;
            this.comboBoxEleveClasse.Location = new System.Drawing.Point(92, 785);
            this.comboBoxEleveClasse.Name = "comboBoxEleveClasse";
            this.comboBoxEleveClasse.Size = new System.Drawing.Size(148, 28);
            this.comboBoxEleveClasse.TabIndex = 51;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(32, 793);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 20);
            this.label16.TabIndex = 50;
            this.label16.Text = "Eleve :";
            // 
            // buttonRemoveEleveClasse
            // 
            this.buttonRemoveEleveClasse.Location = new System.Drawing.Point(164, 856);
            this.buttonRemoveEleveClasse.Name = "buttonRemoveEleveClasse";
            this.buttonRemoveEleveClasse.Size = new System.Drawing.Size(77, 55);
            this.buttonRemoveEleveClasse.TabIndex = 49;
            this.buttonRemoveEleveClasse.Text = "Enlever classe";
            this.buttonRemoveEleveClasse.UseVisualStyleBackColor = true;
            this.buttonRemoveEleveClasse.Click += new System.EventHandler(this.ButtonRemoveEleveClasse_Click);
            // 
            // buttonAddEleveClasse
            // 
            this.buttonAddEleveClasse.Location = new System.Drawing.Point(71, 856);
            this.buttonAddEleveClasse.Name = "buttonAddEleveClasse";
            this.buttonAddEleveClasse.Size = new System.Drawing.Size(77, 57);
            this.buttonAddEleveClasse.TabIndex = 48;
            this.buttonAddEleveClasse.Text = "Ajouter classe";
            this.buttonAddEleveClasse.UseVisualStyleBackColor = true;
            this.buttonAddEleveClasse.Click += new System.EventHandler(this.ButtonAddEleveClasse_Click);
            // 
            // checkBoxAdminProf
            // 
            this.checkBoxAdminProf.AutoSize = true;
            this.checkBoxAdminProf.Location = new System.Drawing.Point(106, 168);
            this.checkBoxAdminProf.Name = "checkBoxAdminProf";
            this.checkBoxAdminProf.Size = new System.Drawing.Size(129, 24);
            this.checkBoxAdminProf.TabIndex = 54;
            this.checkBoxAdminProf.Text = "Administrateur";
            this.checkBoxAdminProf.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1322, 795);
            this.dataGridView1.TabIndex = 55;
            // 
            // buttonVoirEleves
            // 
            this.buttonVoirEleves.Location = new System.Drawing.Point(1058, 851);
            this.buttonVoirEleves.Name = "buttonVoirEleves";
            this.buttonVoirEleves.Size = new System.Drawing.Size(227, 58);
            this.buttonVoirEleves.TabIndex = 56;
            this.buttonVoirEleves.Text = "Voir la liste des élèves";
            this.buttonVoirEleves.UseVisualStyleBackColor = true;
            this.buttonVoirEleves.Click += new System.EventHandler(this.buttonVoirEleves_Click);
            // 
            // buttonVoirClasses
            // 
            this.buttonVoirClasses.Location = new System.Drawing.Point(573, 851);
            this.buttonVoirClasses.Name = "buttonVoirClasses";
            this.buttonVoirClasses.Size = new System.Drawing.Size(227, 58);
            this.buttonVoirClasses.TabIndex = 57;
            this.buttonVoirClasses.Text = "Voir la liste des classes";
            this.buttonVoirClasses.UseVisualStyleBackColor = true;
            this.buttonVoirClasses.Click += new System.EventHandler(this.buttonVoirClasses_Click);
            // 
            // buttonVoirProfs
            // 
            this.buttonVoirProfs.Location = new System.Drawing.Point(815, 851);
            this.buttonVoirProfs.Name = "buttonVoirProfs";
            this.buttonVoirProfs.Size = new System.Drawing.Size(227, 58);
            this.buttonVoirProfs.TabIndex = 58;
            this.buttonVoirProfs.Text = "Voir la liste des profs";
            this.buttonVoirProfs.UseVisualStyleBackColor = true;
            this.buttonVoirProfs.Click += new System.EventHandler(this.buttonVoirProfs_Click);
            // 
            // buttonVoirNiveaux
            // 
            this.buttonVoirNiveaux.Location = new System.Drawing.Point(331, 851);
            this.buttonVoirNiveaux.Name = "buttonVoirNiveaux";
            this.buttonVoirNiveaux.Size = new System.Drawing.Size(227, 58);
            this.buttonVoirNiveaux.TabIndex = 59;
            this.buttonVoirNiveaux.Text = "Voir la liste des niveaux";
            this.buttonVoirNiveaux.UseVisualStyleBackColor = true;
            this.buttonVoirNiveaux.Click += new System.EventHandler(this.buttonVoirNiveaux_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(284, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1328, 801);
            this.tableLayoutPanel1.TabIndex = 60;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1644, 934);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonVoirNiveaux);
            this.Controls.Add(this.buttonVoirProfs);
            this.Controls.Add(this.buttonVoirClasses);
            this.Controls.Add(this.buttonVoirEleves);
            this.Controls.Add(this.checkBoxAdminProf);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
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
        private CheckBox checkBoxAdminProf;
        private DataGridView dataGridView1;
        private Button buttonVoirEleves;
        private Button buttonVoirClasses;
        private Button buttonVoirProfs;
        private Button buttonVoirNiveaux;
        private TableLayoutPanel tableLayoutPanel1;
    }
}