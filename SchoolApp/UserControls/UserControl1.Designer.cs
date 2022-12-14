namespace SchoolApp.UserControls
{
    partial class UserControl1
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageEleve = new System.Windows.Forms.TabPage();
            this.groupBoxAjoutEleve = new System.Windows.Forms.GroupBox();
            this.textBoxCheminListe = new System.Windows.Forms.TextBox();
            this.labelCheminListeEleve = new System.Windows.Forms.Label();
            this.buttonChargerListeEleve = new System.Windows.Forms.Button();
            this.buttonSauvegarderListeEleve = new System.Windows.Forms.Button();
            this.textBoxEleveAnciennete = new System.Windows.Forms.TextBox();
            this.labelAncienneteEleve = new System.Windows.Forms.Label();
            this.buttonModifierEleve = new System.Windows.Forms.Button();
            this.labelElevePrenom = new System.Windows.Forms.Label();
            this.textBoxElevePrenom = new System.Windows.Forms.TextBox();
            this.labelAjoutEleveNom = new System.Windows.Forms.Label();
            this.textBoxEleveNom = new System.Windows.Forms.TextBox();
            this.buttonAjouterEleve = new System.Windows.Forms.Button();
            this.buttonRetirerEleve = new System.Windows.Forms.Button();
            this.tableLayoutPanelEleve = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewEleve = new System.Windows.Forms.DataGridView();
            this.tabPageProfesseur = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tabPageClasse = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button18 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.tabPageMatiere = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.button23 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPageEleve.SuspendLayout();
            this.groupBoxAjoutEleve.SuspendLayout();
            this.tableLayoutPanelEleve.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEleve)).BeginInit();
            this.tabPageProfesseur.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabPageClasse.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.tabPageMatiere.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageEleve);
            this.tabControl1.Controls.Add(this.tabPageProfesseur);
            this.tabControl1.Controls.Add(this.tabPageClasse);
            this.tabControl1.Controls.Add(this.tabPageMatiere);
            this.tabControl1.Location = new System.Drawing.Point(8, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(908, 486);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageEleve
            // 
            this.tabPageEleve.Controls.Add(this.groupBoxAjoutEleve);
            this.tabPageEleve.Controls.Add(this.tableLayoutPanelEleve);
            this.tabPageEleve.Location = new System.Drawing.Point(4, 24);
            this.tabPageEleve.Name = "tabPageEleve";
            this.tabPageEleve.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEleve.Size = new System.Drawing.Size(900, 458);
            this.tabPageEleve.TabIndex = 0;
            this.tabPageEleve.Text = "Gestion eleves";
            this.tabPageEleve.UseVisualStyleBackColor = true;
            // 
            // groupBoxAjoutEleve
            // 
            this.groupBoxAjoutEleve.Controls.Add(this.textBoxCheminListe);
            this.groupBoxAjoutEleve.Controls.Add(this.labelCheminListeEleve);
            this.groupBoxAjoutEleve.Controls.Add(this.buttonChargerListeEleve);
            this.groupBoxAjoutEleve.Controls.Add(this.buttonSauvegarderListeEleve);
            this.groupBoxAjoutEleve.Controls.Add(this.textBoxEleveAnciennete);
            this.groupBoxAjoutEleve.Controls.Add(this.labelAncienneteEleve);
            this.groupBoxAjoutEleve.Controls.Add(this.buttonModifierEleve);
            this.groupBoxAjoutEleve.Controls.Add(this.labelElevePrenom);
            this.groupBoxAjoutEleve.Controls.Add(this.textBoxElevePrenom);
            this.groupBoxAjoutEleve.Controls.Add(this.labelAjoutEleveNom);
            this.groupBoxAjoutEleve.Controls.Add(this.textBoxEleveNom);
            this.groupBoxAjoutEleve.Controls.Add(this.buttonAjouterEleve);
            this.groupBoxAjoutEleve.Controls.Add(this.buttonRetirerEleve);
            this.groupBoxAjoutEleve.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxAjoutEleve.Location = new System.Drawing.Point(3, 338);
            this.groupBoxAjoutEleve.Name = "groupBoxAjoutEleve";
            this.groupBoxAjoutEleve.Size = new System.Drawing.Size(894, 117);
            this.groupBoxAjoutEleve.TabIndex = 6;
            this.groupBoxAjoutEleve.TabStop = false;
            this.groupBoxAjoutEleve.Text = "Ajout d\'un eleve :";
            // 
            // textBoxCheminListe
            // 
            this.textBoxCheminListe.Location = new System.Drawing.Point(292, 46);
            this.textBoxCheminListe.Name = "textBoxCheminListe";
            this.textBoxCheminListe.Size = new System.Drawing.Size(578, 23);
            this.textBoxCheminListe.TabIndex = 12;
            // 
            // labelCheminListeEleve
            // 
            this.labelCheminListeEleve.AutoSize = true;
            this.labelCheminListeEleve.Location = new System.Drawing.Point(292, 25);
            this.labelCheminListeEleve.Name = "labelCheminListeEleve";
            this.labelCheminListeEleve.Size = new System.Drawing.Size(163, 15);
            this.labelCheminListeEleve.TabIndex = 6;
            this.labelCheminListeEleve.Text = "Chemin vers la liste en cours :";
            // 
            // buttonChargerListeEleve
            // 
            this.buttonChargerListeEleve.Location = new System.Drawing.Point(586, 21);
            this.buttonChargerListeEleve.Name = "buttonChargerListeEleve";
            this.buttonChargerListeEleve.Size = new System.Drawing.Size(123, 23);
            this.buttonChargerListeEleve.TabIndex = 11;
            this.buttonChargerListeEleve.Text = "Importer une liste ...";
            this.buttonChargerListeEleve.UseVisualStyleBackColor = true;
            this.buttonChargerListeEleve.Click += new System.EventHandler(this.buttonChargerListeEleve_Click);
            // 
            // buttonSauvegarderListeEleve
            // 
            this.buttonSauvegarderListeEleve.Location = new System.Drawing.Point(461, 21);
            this.buttonSauvegarderListeEleve.Name = "buttonSauvegarderListeEleve";
            this.buttonSauvegarderListeEleve.Size = new System.Drawing.Size(119, 23);
            this.buttonSauvegarderListeEleve.TabIndex = 10;
            this.buttonSauvegarderListeEleve.Text = "Exporter une liste...";
            this.buttonSauvegarderListeEleve.UseVisualStyleBackColor = true;
            this.buttonSauvegarderListeEleve.Click += new System.EventHandler(this.buttonSauvegarderListeEleve_Click);
            // 
            // textBoxEleveAnciennete
            // 
            this.textBoxEleveAnciennete.Location = new System.Drawing.Point(186, 74);
            this.textBoxEleveAnciennete.Name = "textBoxEleveAnciennete";
            this.textBoxEleveAnciennete.Size = new System.Drawing.Size(100, 23);
            this.textBoxEleveAnciennete.TabIndex = 6;
            // 
            // labelAncienneteEleve
            // 
            this.labelAncienneteEleve.AutoSize = true;
            this.labelAncienneteEleve.Location = new System.Drawing.Point(107, 78);
            this.labelAncienneteEleve.Name = "labelAncienneteEleve";
            this.labelAncienneteEleve.Size = new System.Drawing.Size(73, 15);
            this.labelAncienneteEleve.TabIndex = 8;
            this.labelAncienneteEleve.Text = "Anciennété :";
            // 
            // buttonModifierEleve
            // 
            this.buttonModifierEleve.Location = new System.Drawing.Point(6, 79);
            this.buttonModifierEleve.Name = "buttonModifierEleve";
            this.buttonModifierEleve.Size = new System.Drawing.Size(93, 23);
            this.buttonModifierEleve.TabIndex = 3;
            this.buttonModifierEleve.Text = "Modifier eleve";
            this.buttonModifierEleve.UseVisualStyleBackColor = true;
            // 
            // labelElevePrenom
            // 
            this.labelElevePrenom.AutoSize = true;
            this.labelElevePrenom.Location = new System.Drawing.Point(125, 49);
            this.labelElevePrenom.Name = "labelElevePrenom";
            this.labelElevePrenom.Size = new System.Drawing.Size(55, 15);
            this.labelElevePrenom.TabIndex = 6;
            this.labelElevePrenom.Text = "Prénom :";
            // 
            // textBoxElevePrenom
            // 
            this.textBoxElevePrenom.Location = new System.Drawing.Point(186, 45);
            this.textBoxElevePrenom.Name = "textBoxElevePrenom";
            this.textBoxElevePrenom.Size = new System.Drawing.Size(100, 23);
            this.textBoxElevePrenom.TabIndex = 5;
            // 
            // labelAjoutEleveNom
            // 
            this.labelAjoutEleveNom.AutoSize = true;
            this.labelAjoutEleveNom.Location = new System.Drawing.Point(140, 20);
            this.labelAjoutEleveNom.Name = "labelAjoutEleveNom";
            this.labelAjoutEleveNom.Size = new System.Drawing.Size(40, 15);
            this.labelAjoutEleveNom.TabIndex = 5;
            this.labelAjoutEleveNom.Text = "Nom :";
            // 
            // textBoxEleveNom
            // 
            this.textBoxEleveNom.Location = new System.Drawing.Point(186, 17);
            this.textBoxEleveNom.Name = "textBoxEleveNom";
            this.textBoxEleveNom.Size = new System.Drawing.Size(100, 23);
            this.textBoxEleveNom.TabIndex = 4;
            // 
            // buttonAjouterEleve
            // 
            this.buttonAjouterEleve.Location = new System.Drawing.Point(15, 21);
            this.buttonAjouterEleve.Name = "buttonAjouterEleve";
            this.buttonAjouterEleve.Size = new System.Drawing.Size(84, 23);
            this.buttonAjouterEleve.TabIndex = 1;
            this.buttonAjouterEleve.Text = "Ajouter eleve";
            this.buttonAjouterEleve.UseVisualStyleBackColor = true;
            this.buttonAjouterEleve.Click += new System.EventHandler(this.buttonAjouterEleve_Click);
            // 
            // buttonRetirerEleve
            // 
            this.buttonRetirerEleve.Location = new System.Drawing.Point(15, 50);
            this.buttonRetirerEleve.Name = "buttonRetirerEleve";
            this.buttonRetirerEleve.Size = new System.Drawing.Size(84, 23);
            this.buttonRetirerEleve.TabIndex = 2;
            this.buttonRetirerEleve.Text = "Retirer eleve";
            this.buttonRetirerEleve.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelEleve
            // 
            this.tableLayoutPanelEleve.AutoSize = true;
            this.tableLayoutPanelEleve.ColumnCount = 1;
            this.tableLayoutPanelEleve.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelEleve.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelEleve.Controls.Add(this.dataGridViewEleve, 0, 0);
            this.tableLayoutPanelEleve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelEleve.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelEleve.Name = "tableLayoutPanelEleve";
            this.tableLayoutPanelEleve.RowCount = 2;
            this.tableLayoutPanelEleve.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.79646F));
            this.tableLayoutPanelEleve.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.20354F));
            this.tableLayoutPanelEleve.Size = new System.Drawing.Size(894, 452);
            this.tableLayoutPanelEleve.TabIndex = 7;
            // 
            // dataGridViewEleve
            // 
            this.dataGridViewEleve.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEleve.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewEleve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEleve.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewEleve.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewEleve.Name = "dataGridViewEleve";
            this.dataGridViewEleve.RowTemplate.Height = 25;
            this.dataGridViewEleve.Size = new System.Drawing.Size(888, 302);
            this.dataGridViewEleve.TabIndex = 0;
            // 
            // tabPageProfesseur
            // 
            this.tabPageProfesseur.Controls.Add(this.groupBox3);
            this.tabPageProfesseur.Controls.Add(this.tableLayoutPanel4);
            this.tabPageProfesseur.Location = new System.Drawing.Point(4, 24);
            this.tabPageProfesseur.Name = "tabPageProfesseur";
            this.tabPageProfesseur.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProfesseur.Size = new System.Drawing.Size(900, 458);
            this.tabPageProfesseur.TabIndex = 4;
            this.tabPageProfesseur.Text = "Gestion Professeurs";
            this.tabPageProfesseur.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.textBox9);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.button11);
            this.groupBox3.Controls.Add(this.button12);
            this.groupBox3.Controls.Add(this.textBox10);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.button13);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textBox11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.textBox12);
            this.groupBox3.Controls.Add(this.button14);
            this.groupBox3.Controls.Add(this.button15);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(3, 338);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(894, 117);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ajout d\'un prof";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(292, 79);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(43, 15);
            this.label21.TabIndex = 13;
            this.label21.Text = "Login :";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(292, 46);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(578, 23);
            this.textBox9.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(292, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Chemin vers la liste en cours :";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(586, 21);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(123, 23);
            this.button11.TabIndex = 11;
            this.button11.Text = "Importer une liste ...";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(461, 21);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(119, 23);
            this.button12.TabIndex = 10;
            this.button12.Text = "Exporter une liste...";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(186, 74);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 23);
            this.textBox10.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(107, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "Anciennété :";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(6, 79);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(93, 23);
            this.button13.TabIndex = 3;
            this.button13.Text = "Modifier prof";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(125, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 15);
            this.label11.TabIndex = 6;
            this.label11.Text = "Prénom :";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(186, 45);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 23);
            this.textBox11.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(140, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 15);
            this.label12.TabIndex = 5;
            this.label12.Text = "Nom :";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(186, 17);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 23);
            this.textBox12.TabIndex = 4;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(15, 21);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(84, 23);
            this.button14.TabIndex = 1;
            this.button14.Text = "Ajouter prof";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(15, 50);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(84, 23);
            this.button15.TabIndex = 2;
            this.button15.Text = "Retirer prof";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.dataGridView4, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.79646F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.20354F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(894, 452);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView4.Location = new System.Drawing.Point(3, 3);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 25;
            this.dataGridView4.Size = new System.Drawing.Size(888, 302);
            this.dataGridView4.TabIndex = 0;
            // 
            // tabPageClasse
            // 
            this.tabPageClasse.Controls.Add(this.groupBox4);
            this.tabPageClasse.Controls.Add(this.tableLayoutPanel5);
            this.tabPageClasse.Location = new System.Drawing.Point(4, 24);
            this.tabPageClasse.Name = "tabPageClasse";
            this.tabPageClasse.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClasse.Size = new System.Drawing.Size(900, 458);
            this.tabPageClasse.TabIndex = 5;
            this.tabPageClasse.Text = "Gestion Classe";
            this.tabPageClasse.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox13);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.button16);
            this.groupBox4.Controls.Add(this.button17);
            this.groupBox4.Controls.Add(this.textBox14);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.button18);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.textBox15);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.textBox16);
            this.groupBox4.Controls.Add(this.button19);
            this.groupBox4.Controls.Add(this.button20);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(3, 338);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(894, 117);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ajout d\'un eleve :";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(292, 46);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(578, 23);
            this.textBox13.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(292, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(163, 15);
            this.label13.TabIndex = 6;
            this.label13.Text = "Chemin vers la liste en cours :";
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(586, 21);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(123, 23);
            this.button16.TabIndex = 11;
            this.button16.Text = "Importer une liste ...";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(461, 21);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(119, 23);
            this.button17.TabIndex = 10;
            this.button17.Text = "Exporter une liste...";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(186, 74);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 23);
            this.textBox14.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(107, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 15);
            this.label14.TabIndex = 8;
            this.label14.Text = "Anciennété :";
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(6, 79);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(93, 23);
            this.button18.TabIndex = 3;
            this.button18.Text = "Modifier eleve";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(125, 49);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 15);
            this.label15.TabIndex = 6;
            this.label15.Text = "Prénom :";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(186, 45);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 23);
            this.textBox15.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(140, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 15);
            this.label16.TabIndex = 5;
            this.label16.Text = "Nom :";
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(186, 17);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(100, 23);
            this.textBox16.TabIndex = 4;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(15, 21);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(84, 23);
            this.button19.TabIndex = 1;
            this.button19.Text = "Ajouter eleve";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(15, 50);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(84, 23);
            this.button20.TabIndex = 2;
            this.button20.Text = "Retirer eleve";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.dataGridView5, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.79646F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.20354F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(894, 452);
            this.tableLayoutPanel5.TabIndex = 7;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView5.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView5.Location = new System.Drawing.Point(3, 3);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowTemplate.Height = 25;
            this.dataGridView5.Size = new System.Drawing.Size(888, 302);
            this.dataGridView5.TabIndex = 0;
            // 
            // tabPageMatiere
            // 
            this.tabPageMatiere.Controls.Add(this.groupBox5);
            this.tabPageMatiere.Controls.Add(this.tableLayoutPanel6);
            this.tabPageMatiere.Location = new System.Drawing.Point(4, 24);
            this.tabPageMatiere.Name = "tabPageMatiere";
            this.tabPageMatiere.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMatiere.Size = new System.Drawing.Size(900, 458);
            this.tabPageMatiere.TabIndex = 6;
            this.tabPageMatiere.Text = "Gestion Matières";
            this.tabPageMatiere.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox17);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.button21);
            this.groupBox5.Controls.Add(this.button22);
            this.groupBox5.Controls.Add(this.textBox18);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.button23);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.textBox19);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.textBox20);
            this.groupBox5.Controls.Add(this.button24);
            this.groupBox5.Controls.Add(this.button25);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox5.Location = new System.Drawing.Point(3, 338);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(894, 117);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ajout d\'un eleve :";
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(292, 46);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(578, 23);
            this.textBox17.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(292, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(163, 15);
            this.label17.TabIndex = 6;
            this.label17.Text = "Chemin vers la liste en cours :";
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(586, 21);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(123, 23);
            this.button21.TabIndex = 11;
            this.button21.Text = "Importer une liste ...";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(461, 21);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(119, 23);
            this.button22.TabIndex = 10;
            this.button22.Text = "Exporter une liste...";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(186, 74);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(100, 23);
            this.textBox18.TabIndex = 6;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(107, 78);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 15);
            this.label18.TabIndex = 8;
            this.label18.Text = "Anciennété :";
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(6, 79);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(93, 23);
            this.button23.TabIndex = 3;
            this.button23.Text = "Modifier eleve";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(125, 49);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 15);
            this.label19.TabIndex = 6;
            this.label19.Text = "Prénom :";
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(186, 45);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(100, 23);
            this.textBox19.TabIndex = 5;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(140, 20);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 15);
            this.label20.TabIndex = 5;
            this.label20.Text = "Nom :";
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(186, 17);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(100, 23);
            this.textBox20.TabIndex = 4;
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(15, 21);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(84, 23);
            this.button24.TabIndex = 1;
            this.button24.Text = "Ajouter eleve";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(15, 50);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(84, 23);
            this.button25.TabIndex = 2;
            this.button25.Text = "Retirer eleve";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.AutoSize = true;
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Controls.Add(this.dataGridView6, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.79646F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.20354F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(894, 452);
            this.tableLayoutPanel6.TabIndex = 7;
            // 
            // dataGridView6
            // 
            this.dataGridView6.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView6.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView6.Location = new System.Drawing.Point(3, 3);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.RowTemplate.Height = 25;
            this.dataGridView6.Size = new System.Drawing.Size(888, 302);
            this.dataGridView6.TabIndex = 0;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "eleves.log";
            this.saveFileDialog1.InitialDirectory = "\\\\";
            this.saveFileDialog1.Title = "Choisir une liste d\'élèves à exporter.";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "eleves.log";
            this.openFileDialog1.InitialDirectory = "\\\\";
            this.openFileDialog1.Title = "Choisir une liste d\'élèves à importer.";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(924, 502);
            this.tabControl1.ResumeLayout(false);
            this.tabPageEleve.ResumeLayout(false);
            this.tabPageEleve.PerformLayout();
            this.groupBoxAjoutEleve.ResumeLayout(false);
            this.groupBoxAjoutEleve.PerformLayout();
            this.tableLayoutPanelEleve.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEleve)).EndInit();
            this.tabPageProfesseur.ResumeLayout(false);
            this.tabPageProfesseur.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabPageClasse.ResumeLayout(false);
            this.tabPageClasse.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.tabPageMatiere.ResumeLayout(false);
            this.tabPageMatiere.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageEleve;
        private GroupBox groupBoxAjoutEleve;
        private TextBox textBoxCheminListe;
        private Label labelCheminListeEleve;
        private Button buttonChargerListeEleve;
        private Button buttonSauvegarderListeEleve;
        private TextBox textBoxEleveAnciennete;
        private Label labelAncienneteEleve;
        private Button buttonModifierEleve;
        private Label labelElevePrenom;
        private TextBox textBoxElevePrenom;
        private Label labelAjoutEleveNom;
        private TextBox textBoxEleveNom;
        private Button buttonAjouterEleve;
        private Button buttonRetirerEleve;
        private TableLayoutPanel tableLayoutPanelEleve;
        private DataGridView dataGridViewEleve;
        private TabPage tabPageProfesseur;
        private GroupBox groupBox3;
        private Label label21;
        private TextBox textBox9;
        private Label label9;
        private Button button11;
        private Button button12;
        private TextBox textBox10;
        private Label label10;
        private Button button13;
        private Label label11;
        private TextBox textBox11;
        private Label label12;
        private TextBox textBox12;
        private Button button14;
        private Button button15;
        private TableLayoutPanel tableLayoutPanel4;
        private DataGridView dataGridView4;
        private TabPage tabPageClasse;
        private GroupBox groupBox4;
        private TextBox textBox13;
        private Label label13;
        private Button button16;
        private Button button17;
        private TextBox textBox14;
        private Label label14;
        private Button button18;
        private Label label15;
        private TextBox textBox15;
        private Label label16;
        private TextBox textBox16;
        private Button button19;
        private Button button20;
        private TableLayoutPanel tableLayoutPanel5;
        private DataGridView dataGridView5;
        private TabPage tabPageMatiere;
        private GroupBox groupBox5;
        private TextBox textBox17;
        private Label label17;
        private Button button21;
        private Button button22;
        private TextBox textBox18;
        private Label label18;
        private Button button23;
        private Label label19;
        private TextBox textBox19;
        private Label label20;
        private TextBox textBox20;
        private Button button24;
        private Button button25;
        private TableLayoutPanel tableLayoutPanel6;
        private DataGridView dataGridView6;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private ToolTip toolTip1;
    }
}
