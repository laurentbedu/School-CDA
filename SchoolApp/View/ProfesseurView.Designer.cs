namespace SchoolApp.View
{
    partial class ProfesseurView
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelClasse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelClasse
            // 
            this.labelClasse.AutoSize = true;
            this.labelClasse.Location = new System.Drawing.Point(31, 18);
            this.labelClasse.Name = "labelClasse";
            this.labelClasse.Size = new System.Drawing.Size(147, 20);
            this.labelClasse.TabIndex = 0;
            this.labelClasse.Text = "Classe de CP Voltaire";
            // 
            // ProfesseurView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelClasse);
            this.Name = "ProfesseurView";
            this.Size = new System.Drawing.Size(1098, 649);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelClasse;
    }
}
