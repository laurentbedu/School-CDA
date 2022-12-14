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
            this.buttonAddProf = new System.Windows.Forms.Button();
            this.buttonAddEleve = new System.Windows.Forms.Button();
            this.textBoxNomEleve = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPrenomEleve = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPrenomProf = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNomProf = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxClasseEleve = new System.Windows.Forms.ComboBox();
            this.numericUpDownAncienneteEleve = new System.Windows.Forms.NumericUpDown();
            this.comboBoxClasseProf = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAncienneteEleve)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddProf
            // 
            this.buttonAddProf.Location = new System.Drawing.Point(418, 122);
            this.buttonAddProf.Name = "buttonAddProf";
            this.buttonAddProf.Size = new System.Drawing.Size(132, 34);
            this.buttonAddProf.TabIndex = 0;
            this.buttonAddProf.Text = "Ajouter prof";
            this.buttonAddProf.UseVisualStyleBackColor = true;
            // 
            // buttonAddEleve
            // 
            this.buttonAddEleve.Location = new System.Drawing.Point(110, 155);
            this.buttonAddEleve.Name = "buttonAddEleve";
            this.buttonAddEleve.Size = new System.Drawing.Size(132, 34);
            this.buttonAddEleve.TabIndex = 1;
            this.buttonAddEleve.Text = "Ajouter eleve";
            this.buttonAddEleve.UseVisualStyleBackColor = true;
            this.buttonAddEleve.Click += new System.EventHandler(this.buttonAddEleve_Click);
            // 
            // textBoxNomEleve
            // 
            this.textBoxNomEleve.Location = new System.Drawing.Point(110, 23);
            this.textBoxNomEleve.Name = "textBoxNomEleve";
            this.textBoxNomEleve.Size = new System.Drawing.Size(190, 27);
            this.textBoxNomEleve.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prénom :";
            // 
            // textBoxPrenomEleve
            // 
            this.textBoxPrenomEleve.Location = new System.Drawing.Point(110, 56);
            this.textBoxPrenomEleve.Name = "textBoxPrenomEleve";
            this.textBoxPrenomEleve.Size = new System.Drawing.Size(190, 27);
            this.textBoxPrenomEleve.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Classe :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Classe :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Prénom :";
            // 
            // textBoxPrenomProf
            // 
            this.textBoxPrenomProf.Location = new System.Drawing.Point(418, 56);
            this.textBoxPrenomProf.Name = "textBoxPrenomProf";
            this.textBoxPrenomProf.Size = new System.Drawing.Size(190, 27);
            this.textBoxPrenomProf.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nom :";
            // 
            // textBoxNomProf
            // 
            this.textBoxNomProf.Location = new System.Drawing.Point(418, 23);
            this.textBoxNomProf.Name = "textBoxNomProf";
            this.textBoxNomProf.Size = new System.Drawing.Size(190, 27);
            this.textBoxNomProf.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Anciennete :";
            // 
            // comboBoxClasseEleve
            // 
            this.comboBoxClasseEleve.FormattingEnabled = true;
            this.comboBoxClasseEleve.Location = new System.Drawing.Point(110, 88);
            this.comboBoxClasseEleve.Name = "comboBoxClasseEleve";
            this.comboBoxClasseEleve.Size = new System.Drawing.Size(190, 28);
            this.comboBoxClasseEleve.TabIndex = 17;
            // 
            // numericUpDownAncienneteEleve
            // 
            this.numericUpDownAncienneteEleve.Location = new System.Drawing.Point(110, 122);
            this.numericUpDownAncienneteEleve.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownAncienneteEleve.Name = "numericUpDownAncienneteEleve";
            this.numericUpDownAncienneteEleve.Size = new System.Drawing.Size(190, 27);
            this.numericUpDownAncienneteEleve.TabIndex = 18;
            // 
            // comboBoxClasseProf
            // 
            this.comboBoxClasseProf.FormattingEnabled = true;
            this.comboBoxClasseProf.Location = new System.Drawing.Point(418, 88);
            this.comboBoxClasseProf.Name = "comboBoxClasseProf";
            this.comboBoxClasseProf.Size = new System.Drawing.Size(190, 28);
            this.comboBoxClasseProf.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 450);
            this.Controls.Add(this.comboBoxClasseProf);
            this.Controls.Add(this.numericUpDownAncienneteEleve);
            this.Controls.Add(this.comboBoxClasseEleve);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPrenomProf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxNomProf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPrenomEleve);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNomEleve);
            this.Controls.Add(this.buttonAddEleve);
            this.Controls.Add(this.buttonAddProf);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAncienneteEleve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonAddProf;
        private Button buttonAddEleve;
        private TextBox textBoxNomEleve;
        private Label label1;
        private Label label2;
        private TextBox textBoxPrenomEleve;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxPrenomProf;
        private Label label6;
        private TextBox textBoxNomProf;
        private Label label7;
        private ComboBox comboBoxClasseEleve;
        private NumericUpDown numericUpDownAncienneteEleve;
        private ComboBox comboBoxClasseProf;
    }
}