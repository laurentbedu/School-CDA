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
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxProf = new System.Windows.Forms.TextBox();
            this.textBoxEleve = new System.Windows.Forms.TextBox();
            this.buttonClasse = new System.Windows.Forms.Button();
            this.textBoxClasse = new System.Windows.Forms.TextBox();
            this.buttonMatiere = new System.Windows.Forms.Button();
            this.textBoxMatiere = new System.Windows.Forms.TextBox();
            this.buttonNiveau = new System.Windows.Forms.Button();
            this.textBoxNiveau = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ajouter Prof";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(27, 107);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 22);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ajouter Eleve";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxProf
            // 
            this.textBoxProf.Location = new System.Drawing.Point(251, 18);
            this.textBoxProf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxProf.Multiline = true;
            this.textBoxProf.Name = "textBoxProf";
            this.textBoxProf.Size = new System.Drawing.Size(234, 70);
            this.textBoxProf.TabIndex = 2;
            // 
            // textBoxEleve
            // 
            this.textBoxEleve.Location = new System.Drawing.Point(251, 107);
            this.textBoxEleve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEleve.Multiline = true;
            this.textBoxEleve.Name = "textBoxEleve";
            this.textBoxEleve.Size = new System.Drawing.Size(234, 66);
            this.textBoxEleve.TabIndex = 3;
            // 
            // buttonClasse
            // 
            this.buttonClasse.Location = new System.Drawing.Point(27, 200);
            this.buttonClasse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClasse.Name = "buttonClasse";
            this.buttonClasse.Size = new System.Drawing.Size(127, 22);
            this.buttonClasse.TabIndex = 4;
            this.buttonClasse.Text = "Ajouter Classe";
            this.buttonClasse.UseVisualStyleBackColor = true;
            this.buttonClasse.Click += new System.EventHandler(this.buttonClasse_Click);
            // 
            // textBoxClasse
            // 
            this.textBoxClasse.Location = new System.Drawing.Point(251, 201);
            this.textBoxClasse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxClasse.Name = "textBoxClasse";
            this.textBoxClasse.Size = new System.Drawing.Size(234, 23);
            this.textBoxClasse.TabIndex = 5;
            // 
            // buttonMatiere
            // 
            this.buttonMatiere.Location = new System.Drawing.Point(27, 252);
            this.buttonMatiere.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMatiere.Name = "buttonMatiere";
            this.buttonMatiere.Size = new System.Drawing.Size(127, 22);
            this.buttonMatiere.TabIndex = 6;
            this.buttonMatiere.Text = "Ajouter Matiere";
            this.buttonMatiere.UseVisualStyleBackColor = true;
            this.buttonMatiere.Click += new System.EventHandler(this.buttonMatiere_Click);
            // 
            // textBoxMatiere
            // 
            this.textBoxMatiere.Location = new System.Drawing.Point(251, 254);
            this.textBoxMatiere.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMatiere.Name = "textBoxMatiere";
            this.textBoxMatiere.Size = new System.Drawing.Size(234, 23);
            this.textBoxMatiere.TabIndex = 7;
            // 
            // buttonNiveau
            // 
            this.buttonNiveau.Location = new System.Drawing.Point(27, 226);
            this.buttonNiveau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNiveau.Name = "buttonNiveau";
            this.buttonNiveau.Size = new System.Drawing.Size(127, 22);
            this.buttonNiveau.TabIndex = 8;
            this.buttonNiveau.Text = "Ajouter Niveau";
            this.buttonNiveau.UseVisualStyleBackColor = true;
            this.buttonNiveau.Click += new System.EventHandler(this.buttonNiveau_Click);
            // 
            // textBoxNiveau
            // 
            this.textBoxNiveau.Location = new System.Drawing.Point(251, 227);
            this.textBoxNiveau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNiveau.Name = "textBoxNiveau";
            this.textBoxNiveau.Size = new System.Drawing.Size(234, 23);
            this.textBoxNiveau.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(27, 310);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 22);
            this.button3.TabIndex = 10;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 545);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBoxNiveau);
            this.Controls.Add(this.buttonNiveau);
            this.Controls.Add(this.textBoxMatiere);
            this.Controls.Add(this.buttonMatiere);
            this.Controls.Add(this.textBoxClasse);
            this.Controls.Add(this.buttonClasse);
            this.Controls.Add(this.textBoxEleve);
            this.Controls.Add(this.textBoxProf);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBoxProf;
        private TextBox textBoxEleve;
        private Button buttonClasse;
        private TextBox textBoxClasse;
        private Button buttonMatiere;
        private TextBox textBoxMatiere;
        private Button buttonNiveau;
        private TextBox textBoxNiveau;
        private Button button3;
    }
}