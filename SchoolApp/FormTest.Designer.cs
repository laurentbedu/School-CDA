namespace SchoolApp
{
    partial class FormTest
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
            this.button4 = new System.Windows.Forms.Button();
            this.panelGestion = new System.Windows.Forms.Panel();
            this.buttonGestion2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 119);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "gestion";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panelGestion
            // 
            this.panelGestion.Location = new System.Drawing.Point(93, 12);
            this.panelGestion.Name = "panelGestion";
            this.panelGestion.Size = new System.Drawing.Size(1128, 552);
            this.panelGestion.TabIndex = 4;
            // 
            // buttonGestion2
            // 
            this.buttonGestion2.Location = new System.Drawing.Point(12, 148);
            this.buttonGestion2.Name = "buttonGestion2";
            this.buttonGestion2.Size = new System.Drawing.Size(75, 42);
            this.buttonGestion2.TabIndex = 5;
            this.buttonGestion2.Text = "Super admin";
            this.buttonGestion2.UseVisualStyleBackColor = true;
            this.buttonGestion2.Click += new System.EventHandler(this.buttonGestion2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 258);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "testClasse";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 631);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.buttonGestion2);
            this.Controls.Add(this.panelGestion);
            this.Controls.Add(this.button4);
            this.Name = "FormTest";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private Button button4;
        private Panel panelGestion;
        private Button buttonGestion2;
        private Button button5;
    }
}