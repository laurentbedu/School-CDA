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
            this.buttonAddEleve = new System.Windows.Forms.Button();
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
            this.textBoxNomClass = new System.Windows.Forms.TextBox();
            this.buttonAddClasse = new System.Windows.Forms.Button();
            this.buttonRemoveClasse = new System.Windows.Forms.Button();
            this.buttonRemoveProf = new System.Windows.Forms.Button();
            this.buttonAddProf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAncienneteEleve)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreerProf
            // 
            this.buttonCreerProf.Location = new System.Drawing.Point(607, 39);
            this.buttonCreerProf.Name = "buttonCreerProf";
            this.buttonCreerProf.Size = new System.Drawing.Size(132, 27);
            this.buttonCreerProf.TabIndex = 0;
            this.buttonCreerProf.Text = "Créer prof";
            this.buttonCreerProf.UseVisualStyleBackColor = true;
            this.buttonCreerProf.Click += new System.EventHandler(this.buttonAddProf_Click);
            // 
            // buttonAddEleve
            // 
            this.buttonAddEleve.Location = new System.Drawing.Point(96, 164);
            this.buttonAddEleve.Name = "buttonAddEleve";
            this.buttonAddEleve.Size = new System.Drawing.Size(132, 34);
            this.buttonAddEleve.TabIndex = 1;
            this.buttonAddEleve.Text = "Ajouter eleve";
            this.buttonAddEleve.UseVisualStyleBackColor = true;
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
            this.label3.Location = new System.Drawing.Point(17, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Classe :";
            // 
            // textBoxPrenomProf
            // 
            this.textBoxPrenomProf.Location = new System.Drawing.Point(453, 39);
            this.textBoxPrenomProf.Name = "textBoxPrenomProf";
            this.textBoxPrenomProf.Size = new System.Drawing.Size(148, 27);
            this.textBoxPrenomProf.TabIndex = 11;
            // 
            // textBoxNomProf
            // 
            this.textBoxNomProf.Location = new System.Drawing.Point(299, 39);
            this.textBoxNomProf.Name = "textBoxNomProf";
            this.textBoxNomProf.Size = new System.Drawing.Size(148, 27);
            this.textBoxNomProf.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Anciennete :";
            // 
            // comboBoxClasseEleve
            // 
            this.comboBoxClasseEleve.FormattingEnabled = true;
            this.comboBoxClasseEleve.Location = new System.Drawing.Point(80, 97);
            this.comboBoxClasseEleve.Name = "comboBoxClasseEleve";
            this.comboBoxClasseEleve.Size = new System.Drawing.Size(148, 28);
            this.comboBoxClasseEleve.TabIndex = 17;
            // 
            // numericUpDownAncienneteEleve
            // 
            this.numericUpDownAncienneteEleve.Location = new System.Drawing.Point(140, 131);
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
            this.buttonCreerClasse.Location = new System.Drawing.Point(430, 238);
            this.buttonCreerClasse.Name = "buttonCreerClasse";
            this.buttonCreerClasse.Size = new System.Drawing.Size(134, 29);
            this.buttonCreerClasse.TabIndex = 22;
            this.buttonCreerClasse.Text = "Créer classe";
            this.buttonCreerClasse.UseVisualStyleBackColor = true;
            this.buttonCreerClasse.Click += new System.EventHandler(this.buttonCreerClasse_Click);
            // 
            // textBoxNomClass
            // 
            this.textBoxNomClass.Location = new System.Drawing.Point(299, 238);
            this.textBoxNomClass.Name = "textBoxNomClass";
            this.textBoxNomClass.Size = new System.Drawing.Size(125, 27);
            this.textBoxNomClass.TabIndex = 24;
            // 
            // buttonAddClasse
            // 
            this.buttonAddClasse.Location = new System.Drawing.Point(299, 72);
            this.buttonAddClasse.Name = "buttonAddClasse";
            this.buttonAddClasse.Size = new System.Drawing.Size(117, 34);
            this.buttonAddClasse.TabIndex = 26;
            this.buttonAddClasse.Text = "Ajouter classe";
            this.buttonAddClasse.UseVisualStyleBackColor = true;
            this.buttonAddClasse.Click += new System.EventHandler(this.buttonAddClasse_Click);
            // 
            // buttonRemoveClasse
            // 
            this.buttonRemoveClasse.Location = new System.Drawing.Point(422, 72);
            this.buttonRemoveClasse.Name = "buttonRemoveClasse";
            this.buttonRemoveClasse.Size = new System.Drawing.Size(117, 34);
            this.buttonRemoveClasse.TabIndex = 27;
            this.buttonRemoveClasse.Text = "Enlever classe";
            this.buttonRemoveClasse.UseVisualStyleBackColor = true;
            this.buttonRemoveClasse.Click += new System.EventHandler(this.buttonRemoveClasse_Click);
            // 
            // buttonRemoveProf
            // 
            this.buttonRemoveProf.Location = new System.Drawing.Point(422, 271);
            this.buttonRemoveProf.Name = "buttonRemoveProf";
            this.buttonRemoveProf.Size = new System.Drawing.Size(117, 34);
            this.buttonRemoveProf.TabIndex = 29;
            this.buttonRemoveProf.Text = "Enlever prof";
            this.buttonRemoveProf.UseVisualStyleBackColor = true;
            this.buttonRemoveProf.Click += new System.EventHandler(this.buttonRemoveProf_Click);
            // 
            // buttonAddProf
            // 
            this.buttonAddProf.Location = new System.Drawing.Point(299, 271);
            this.buttonAddProf.Name = "buttonAddProf";
            this.buttonAddProf.Size = new System.Drawing.Size(117, 34);
            this.buttonAddProf.TabIndex = 28;
            this.buttonAddProf.Text = "Ajouter prof";
            this.buttonAddProf.UseVisualStyleBackColor = true;
            this.buttonAddProf.Click += new System.EventHandler(this.buttonAddProf_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 450);
            this.Controls.Add(this.buttonRemoveProf);
            this.Controls.Add(this.buttonAddProf);
            this.Controls.Add(this.buttonRemoveClasse);
            this.Controls.Add(this.buttonAddClasse);
            this.Controls.Add(this.textBoxNomClass);
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
            this.Controls.Add(this.buttonAddEleve);
            this.Controls.Add(this.buttonCreerProf);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAncienneteEleve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonCreerProf;
        private Button buttonAddEleve;
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
        private TextBox textBoxNomClass;
        private Button buttonAddClasse;
        private Button buttonRemoveClasse;
        private Button buttonRemoveProf;
        private Button buttonAddProf;
    }
}