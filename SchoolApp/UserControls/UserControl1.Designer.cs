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
            this.checkBoxSuperAdmin = new System.Windows.Forms.CheckBox();
            this.textBoxMdpProf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLoginProf = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonImportProfs = new System.Windows.Forms.Button();
            this.buttonExportProfs = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxPrenomProf = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxNomProf = new System.Windows.Forms.TextBox();
            this.buttonAjouterProf = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewProfesseurs = new System.Windows.Forms.DataGridView();
            this.tabPageClasse = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonImportClasses = new System.Windows.Forms.Button();
            this.buttonExportClasses = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxNomClasse = new System.Windows.Forms.TextBox();
            this.buttonAjouterClasse = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewClasse = new System.Windows.Forms.DataGridView();
            this.tabPageMatiere = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxNomMatiere = new System.Windows.Forms.TextBox();
            this.buttonAjouterMatiere = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewMatiere = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfesseurs)).BeginInit();
            this.tabPageClasse.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClasse)).BeginInit();
            this.tabPageMatiere.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatiere)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(908, 497);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageEleve
            // 
            this.tabPageEleve.Controls.Add(this.groupBoxAjoutEleve);
            this.tabPageEleve.Controls.Add(this.tableLayoutPanelEleve);
            this.tabPageEleve.Location = new System.Drawing.Point(4, 24);
            this.tabPageEleve.Name = "tabPageEleve";
            this.tabPageEleve.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEleve.Size = new System.Drawing.Size(900, 469);
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
            this.groupBoxAjoutEleve.Location = new System.Drawing.Point(3, 349);
            this.groupBoxAjoutEleve.Name = "groupBoxAjoutEleve";
            this.groupBoxAjoutEleve.Size = new System.Drawing.Size(894, 117);
            this.groupBoxAjoutEleve.TabIndex = 6;
            this.groupBoxAjoutEleve.TabStop = false;
            this.groupBoxAjoutEleve.Text = "Ajout d\'un eleve :";
            // 
            // textBoxCheminListe
            // 
            this.textBoxCheminListe.Location = new System.Drawing.Point(313, 91);
            this.textBoxCheminListe.Name = "textBoxCheminListe";
            this.textBoxCheminListe.Size = new System.Drawing.Size(578, 23);
            this.textBoxCheminListe.TabIndex = 12;
            // 
            // labelCheminListeEleve
            // 
            this.labelCheminListeEleve.AutoSize = true;
            this.labelCheminListeEleve.Location = new System.Drawing.Point(313, 75);
            this.labelCheminListeEleve.Name = "labelCheminListeEleve";
            this.labelCheminListeEleve.Size = new System.Drawing.Size(163, 15);
            this.labelCheminListeEleve.TabIndex = 6;
            this.labelCheminListeEleve.Text = "Chemin vers la liste en cours :";
            // 
            // buttonChargerListeEleve
            // 
            this.buttonChargerListeEleve.Location = new System.Drawing.Point(607, 66);
            this.buttonChargerListeEleve.Name = "buttonChargerListeEleve";
            this.buttonChargerListeEleve.Size = new System.Drawing.Size(123, 23);
            this.buttonChargerListeEleve.TabIndex = 11;
            this.buttonChargerListeEleve.Text = "Importer une liste ...";
            this.buttonChargerListeEleve.UseVisualStyleBackColor = true;
            this.buttonChargerListeEleve.Click += new System.EventHandler(this.buttonChargerListeEleve_Click);
            // 
            // buttonSauvegarderListeEleve
            // 
            this.buttonSauvegarderListeEleve.Location = new System.Drawing.Point(482, 66);
            this.buttonSauvegarderListeEleve.Name = "buttonSauvegarderListeEleve";
            this.buttonSauvegarderListeEleve.Size = new System.Drawing.Size(119, 23);
            this.buttonSauvegarderListeEleve.TabIndex = 10;
            this.buttonSauvegarderListeEleve.Text = "Exporter une liste...";
            this.buttonSauvegarderListeEleve.UseVisualStyleBackColor = true;
            this.buttonSauvegarderListeEleve.Click += new System.EventHandler(this.buttonSauvegarderListeEleve_Click);
            // 
            // textBoxEleveAnciennete
            // 
            this.textBoxEleveAnciennete.Location = new System.Drawing.Point(186, 67);
            this.textBoxEleveAnciennete.Name = "textBoxEleveAnciennete";
            this.textBoxEleveAnciennete.Size = new System.Drawing.Size(100, 23);
            this.textBoxEleveAnciennete.TabIndex = 6;
            // 
            // labelAncienneteEleve
            // 
            this.labelAncienneteEleve.AutoSize = true;
            this.labelAncienneteEleve.Location = new System.Drawing.Point(107, 70);
            this.labelAncienneteEleve.Name = "labelAncienneteEleve";
            this.labelAncienneteEleve.Size = new System.Drawing.Size(73, 15);
            this.labelAncienneteEleve.TabIndex = 8;
            this.labelAncienneteEleve.Text = "Anciennété :";
            // 
            // buttonModifierEleve
            // 
            this.buttonModifierEleve.Location = new System.Drawing.Point(3, 70);
            this.buttonModifierEleve.Name = "buttonModifierEleve";
            this.buttonModifierEleve.Size = new System.Drawing.Size(98, 23);
            this.buttonModifierEleve.TabIndex = 3;
            this.buttonModifierEleve.Text = "Modifier eleve";
            this.buttonModifierEleve.UseVisualStyleBackColor = true;
            // 
            // labelElevePrenom
            // 
            this.labelElevePrenom.AutoSize = true;
            this.labelElevePrenom.Location = new System.Drawing.Point(125, 46);
            this.labelElevePrenom.Name = "labelElevePrenom";
            this.labelElevePrenom.Size = new System.Drawing.Size(55, 15);
            this.labelElevePrenom.TabIndex = 6;
            this.labelElevePrenom.Text = "Prénom :";
            // 
            // textBoxElevePrenom
            // 
            this.textBoxElevePrenom.Location = new System.Drawing.Point(186, 41);
            this.textBoxElevePrenom.Name = "textBoxElevePrenom";
            this.textBoxElevePrenom.Size = new System.Drawing.Size(100, 23);
            this.textBoxElevePrenom.TabIndex = 5;
            // 
            // labelAjoutEleveNom
            // 
            this.labelAjoutEleveNom.AutoSize = true;
            this.labelAjoutEleveNom.Location = new System.Drawing.Point(140, 19);
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
            this.buttonAjouterEleve.Location = new System.Drawing.Point(3, 21);
            this.buttonAjouterEleve.Name = "buttonAjouterEleve";
            this.buttonAjouterEleve.Size = new System.Drawing.Size(98, 23);
            this.buttonAjouterEleve.TabIndex = 1;
            this.buttonAjouterEleve.Text = "Ajouter eleve";
            this.buttonAjouterEleve.UseVisualStyleBackColor = true;
            this.buttonAjouterEleve.Click += new System.EventHandler(this.buttonAjouterEleve_Click);
            // 
            // buttonRetirerEleve
            // 
            this.buttonRetirerEleve.Location = new System.Drawing.Point(3, 46);
            this.buttonRetirerEleve.Name = "buttonRetirerEleve";
            this.buttonRetirerEleve.Size = new System.Drawing.Size(98, 23);
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
            this.tableLayoutPanelEleve.Size = new System.Drawing.Size(894, 463);
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
            this.dataGridViewEleve.ReadOnly = true;
            this.dataGridViewEleve.RowTemplate.Height = 25;
            this.dataGridViewEleve.Size = new System.Drawing.Size(888, 321);
            this.dataGridViewEleve.TabIndex = 0;
            // 
            // tabPageProfesseur
            // 
            this.tabPageProfesseur.Controls.Add(this.groupBox3);
            this.tabPageProfesseur.Controls.Add(this.tableLayoutPanel4);
            this.tabPageProfesseur.Location = new System.Drawing.Point(4, 24);
            this.tabPageProfesseur.Name = "tabPageProfesseur";
            this.tabPageProfesseur.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProfesseur.Size = new System.Drawing.Size(900, 469);
            this.tabPageProfesseur.TabIndex = 4;
            this.tabPageProfesseur.Text = "Gestion Professeurs";
            this.tabPageProfesseur.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxSuperAdmin);
            this.groupBox3.Controls.Add(this.textBoxMdpProf);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBoxLoginProf);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.textBox9);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.buttonImportProfs);
            this.groupBox3.Controls.Add(this.buttonExportProfs);
            this.groupBox3.Controls.Add(this.button13);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textBoxPrenomProf);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.textBoxNomProf);
            this.groupBox3.Controls.Add(this.buttonAjouterProf);
            this.groupBox3.Controls.Add(this.button15);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(3, 349);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(894, 117);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ajout d\'un prof";
            // 
            // checkBoxSuperAdmin
            // 
            this.checkBoxSuperAdmin.AutoSize = true;
            this.checkBoxSuperAdmin.Location = new System.Drawing.Point(442, 21);
            this.checkBoxSuperAdmin.Name = "checkBoxSuperAdmin";
            this.checkBoxSuperAdmin.Size = new System.Drawing.Size(103, 19);
            this.checkBoxSuperAdmin.TabIndex = 17;
            this.checkBoxSuperAdmin.Text = "Super Admin ?";
            this.checkBoxSuperAdmin.UseVisualStyleBackColor = true;
            // 
            // textBoxMdpProf
            // 
            this.textBoxMdpProf.Location = new System.Drawing.Point(336, 18);
            this.textBoxMdpProf.Name = "textBoxMdpProf";
            this.textBoxMdpProf.Size = new System.Drawing.Size(100, 23);
            this.textBoxMdpProf.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mdp :";
            // 
            // textBoxLoginProf
            // 
            this.textBoxLoginProf.Location = new System.Drawing.Point(186, 73);
            this.textBoxLoginProf.Name = "textBoxLoginProf";
            this.textBoxLoginProf.Size = new System.Drawing.Size(100, 23);
            this.textBoxLoginProf.TabIndex = 14;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(137, 73);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(43, 15);
            this.label21.TabIndex = 13;
            this.label21.Text = "Login :";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(310, 88);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(578, 23);
            this.textBox9.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(310, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Chemin vers la liste en cours :";
            // 
            // buttonImportProfs
            // 
            this.buttonImportProfs.Location = new System.Drawing.Point(604, 65);
            this.buttonImportProfs.Name = "buttonImportProfs";
            this.buttonImportProfs.Size = new System.Drawing.Size(123, 23);
            this.buttonImportProfs.TabIndex = 11;
            this.buttonImportProfs.Text = "Importer une liste ...";
            this.buttonImportProfs.UseVisualStyleBackColor = true;
            // 
            // buttonExportProfs
            // 
            this.buttonExportProfs.Location = new System.Drawing.Point(479, 65);
            this.buttonExportProfs.Name = "buttonExportProfs";
            this.buttonExportProfs.Size = new System.Drawing.Size(119, 23);
            this.buttonExportProfs.TabIndex = 10;
            this.buttonExportProfs.Text = "Exporter une liste...";
            this.buttonExportProfs.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(3, 73);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(93, 23);
            this.button13.TabIndex = 3;
            this.button13.Text = "Modifier prof";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(128, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 15);
            this.label11.TabIndex = 6;
            this.label11.Text = "Prénom :";
            // 
            // textBoxPrenomProf
            // 
            this.textBoxPrenomProf.Location = new System.Drawing.Point(186, 44);
            this.textBoxPrenomProf.Name = "textBoxPrenomProf";
            this.textBoxPrenomProf.Size = new System.Drawing.Size(100, 23);
            this.textBoxPrenomProf.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(143, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 15);
            this.label12.TabIndex = 5;
            this.label12.Text = "Nom :";
            // 
            // textBoxNomProf
            // 
            this.textBoxNomProf.Location = new System.Drawing.Point(186, 17);
            this.textBoxNomProf.Name = "textBoxNomProf";
            this.textBoxNomProf.Size = new System.Drawing.Size(100, 23);
            this.textBoxNomProf.TabIndex = 4;
            // 
            // buttonAjouterProf
            // 
            this.buttonAjouterProf.Location = new System.Drawing.Point(3, 20);
            this.buttonAjouterProf.Name = "buttonAjouterProf";
            this.buttonAjouterProf.Size = new System.Drawing.Size(93, 23);
            this.buttonAjouterProf.TabIndex = 1;
            this.buttonAjouterProf.Text = "Ajouter prof";
            this.buttonAjouterProf.UseVisualStyleBackColor = true;
            this.buttonAjouterProf.Click += new System.EventHandler(this.buttonAjouterProf_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(3, 44);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(93, 23);
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
            this.tableLayoutPanel4.Controls.Add(this.dataGridViewProfesseurs, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.79646F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.20354F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(894, 463);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // dataGridViewProfesseurs
            // 
            this.dataGridViewProfesseurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProfesseurs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewProfesseurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProfesseurs.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewProfesseurs.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewProfesseurs.Name = "dataGridViewProfesseurs";
            this.dataGridViewProfesseurs.ReadOnly = true;
            this.dataGridViewProfesseurs.RowTemplate.Height = 25;
            this.dataGridViewProfesseurs.Size = new System.Drawing.Size(888, 321);
            this.dataGridViewProfesseurs.TabIndex = 0;
            // 
            // tabPageClasse
            // 
            this.tabPageClasse.Controls.Add(this.groupBox4);
            this.tabPageClasse.Controls.Add(this.tableLayoutPanel5);
            this.tabPageClasse.Location = new System.Drawing.Point(4, 24);
            this.tabPageClasse.Name = "tabPageClasse";
            this.tabPageClasse.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClasse.Size = new System.Drawing.Size(900, 469);
            this.tabPageClasse.TabIndex = 5;
            this.tabPageClasse.Text = "Gestion Classe";
            this.tabPageClasse.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox13);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.buttonImportClasses);
            this.groupBox4.Controls.Add(this.buttonExportClasses);
            this.groupBox4.Controls.Add(this.button18);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.textBoxNomClasse);
            this.groupBox4.Controls.Add(this.buttonAjouterClasse);
            this.groupBox4.Controls.Add(this.button20);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(3, 349);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(894, 117);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ajout d\'un eleve :";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(389, 91);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(500, 23);
            this.textBox13.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(391, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(163, 15);
            this.label13.TabIndex = 6;
            this.label13.Text = "Chemin vers la liste en cours :";
            // 
            // buttonImportClasses
            // 
            this.buttonImportClasses.Location = new System.Drawing.Point(686, 66);
            this.buttonImportClasses.Name = "buttonImportClasses";
            this.buttonImportClasses.Size = new System.Drawing.Size(120, 25);
            this.buttonImportClasses.TabIndex = 11;
            this.buttonImportClasses.Text = "Importer une liste ...";
            this.buttonImportClasses.UseVisualStyleBackColor = true;
            // 
            // buttonExportClasses
            // 
            this.buttonExportClasses.Location = new System.Drawing.Point(560, 66);
            this.buttonExportClasses.Name = "buttonExportClasses";
            this.buttonExportClasses.Size = new System.Drawing.Size(120, 25);
            this.buttonExportClasses.TabIndex = 10;
            this.buttonExportClasses.Text = "Exporter une liste...";
            this.buttonExportClasses.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button18.AutoSize = true;
            this.button18.Location = new System.Drawing.Point(10, 80);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(100, 25);
            this.button18.TabIndex = 3;
            this.button18.Text = "Modifier classe";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(120, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 15);
            this.label16.TabIndex = 5;
            this.label16.Text = "Nom :";
            // 
            // textBoxNomClasse
            // 
            this.textBoxNomClasse.Location = new System.Drawing.Point(160, 20);
            this.textBoxNomClasse.Name = "textBoxNomClasse";
            this.textBoxNomClasse.Size = new System.Drawing.Size(100, 23);
            this.textBoxNomClasse.TabIndex = 4;
            // 
            // buttonAjouterClasse
            // 
            this.buttonAjouterClasse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonAjouterClasse.AutoSize = true;
            this.buttonAjouterClasse.Location = new System.Drawing.Point(10, 20);
            this.buttonAjouterClasse.Name = "buttonAjouterClasse";
            this.buttonAjouterClasse.Size = new System.Drawing.Size(100, 25);
            this.buttonAjouterClasse.TabIndex = 1;
            this.buttonAjouterClasse.Text = "Ajouter Classe";
            this.buttonAjouterClasse.UseVisualStyleBackColor = true;
            this.buttonAjouterClasse.Click += new System.EventHandler(this.buttonAjouterClasse_Click);
            // 
            // button20
            // 
            this.button20.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button20.AutoSize = true;
            this.button20.Location = new System.Drawing.Point(10, 50);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(100, 25);
            this.button20.TabIndex = 2;
            this.button20.Text = "Retirer classe";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.dataGridViewClasse, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.79646F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.20354F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(894, 463);
            this.tableLayoutPanel5.TabIndex = 7;
            // 
            // dataGridViewClasse
            // 
            this.dataGridViewClasse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClasse.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewClasse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClasse.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewClasse.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewClasse.Name = "dataGridViewClasse";
            this.dataGridViewClasse.ReadOnly = true;
            this.dataGridViewClasse.RowTemplate.Height = 25;
            this.dataGridViewClasse.Size = new System.Drawing.Size(888, 321);
            this.dataGridViewClasse.TabIndex = 0;
            // 
            // tabPageMatiere
            // 
            this.tabPageMatiere.Controls.Add(this.groupBox5);
            this.tabPageMatiere.Controls.Add(this.tableLayoutPanel6);
            this.tabPageMatiere.Location = new System.Drawing.Point(4, 24);
            this.tabPageMatiere.Name = "tabPageMatiere";
            this.tabPageMatiere.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMatiere.Size = new System.Drawing.Size(900, 469);
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
            this.groupBox5.Controls.Add(this.button23);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.textBoxNomMatiere);
            this.groupBox5.Controls.Add(this.buttonAjouterMatiere);
            this.groupBox5.Controls.Add(this.button25);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox5.Location = new System.Drawing.Point(3, 349);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(894, 117);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ajout d\'un eleve :";
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(388, 91);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(500, 23);
            this.textBox17.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(388, 74);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(163, 15);
            this.label17.TabIndex = 6;
            this.label17.Text = "Chemin vers la liste en cours :";
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(683, 66);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(120, 25);
            this.button21.TabIndex = 11;
            this.button21.Text = "Importer une liste ...";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(557, 66);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(120, 25);
            this.button22.TabIndex = 10;
            this.button22.Text = "Exporter une liste...";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(10, 80);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(100, 25);
            this.button23.TabIndex = 3;
            this.button23.Text = "Modifier matière";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(120, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 15);
            this.label20.TabIndex = 5;
            this.label20.Text = "Nom :";
            // 
            // textBoxNomMatiere
            // 
            this.textBoxNomMatiere.Location = new System.Drawing.Point(160, 20);
            this.textBoxNomMatiere.Name = "textBoxNomMatiere";
            this.textBoxNomMatiere.Size = new System.Drawing.Size(100, 23);
            this.textBoxNomMatiere.TabIndex = 4;
            // 
            // buttonAjouterMatiere
            // 
            this.buttonAjouterMatiere.Location = new System.Drawing.Point(10, 20);
            this.buttonAjouterMatiere.Name = "buttonAjouterMatiere";
            this.buttonAjouterMatiere.Size = new System.Drawing.Size(100, 25);
            this.buttonAjouterMatiere.TabIndex = 1;
            this.buttonAjouterMatiere.Text = "Ajouter matière";
            this.buttonAjouterMatiere.UseVisualStyleBackColor = true;
            this.buttonAjouterMatiere.Click += new System.EventHandler(this.buttonAjouterMatiere_Click);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(10, 50);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(100, 25);
            this.button25.TabIndex = 2;
            this.button25.Text = "Retirer matière";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.AutoSize = true;
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Controls.Add(this.dataGridViewMatiere, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.79646F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.20354F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(894, 463);
            this.tableLayoutPanel6.TabIndex = 7;
            // 
            // dataGridViewMatiere
            // 
            this.dataGridViewMatiere.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMatiere.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewMatiere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatiere.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewMatiere.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewMatiere.Name = "dataGridViewMatiere";
            this.dataGridViewMatiere.ReadOnly = true;
            this.dataGridViewMatiere.RowTemplate.Height = 25;
            this.dataGridViewMatiere.Size = new System.Drawing.Size(888, 321);
            this.dataGridViewMatiere.TabIndex = 0;
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
            this.Size = new System.Drawing.Size(924, 508);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfesseurs)).EndInit();
            this.tabPageClasse.ResumeLayout(false);
            this.tabPageClasse.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClasse)).EndInit();
            this.tabPageMatiere.ResumeLayout(false);
            this.tabPageMatiere.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatiere)).EndInit();
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
        private Button buttonImportProfs;
        private Button buttonExportProfs;
        private Button button13;
        private Label label11;
        private TextBox textBoxPrenomProf;
        private Label label12;
        private TextBox textBoxNomProf;
        private Button buttonAjouterProf;
        private Button button15;
        private TableLayoutPanel tableLayoutPanel4;
        private DataGridView dataGridViewProfesseurs;
        private TabPage tabPageClasse;
        private GroupBox groupBox4;
        private TextBox textBox13;
        private Label label13;
        private Button buttonImportClasses;
        private Button buttonExportClasses;
        private Button button18;
        private Label label16;
        private TextBox textBoxNomClasse;
        private Button buttonAjouterClasse;
        private Button button20;
        private TableLayoutPanel tableLayoutPanel5;
        private DataGridView dataGridViewClasse;
        private TabPage tabPageMatiere;
        private GroupBox groupBox5;
        private TextBox textBox17;
        private Label label17;
        private Button button21;
        private Button button22;
        private Button button23;
        private Label label20;
        private TextBox textBoxNomMatiere;
        private Button buttonAjouterMatiere;
        private Button button25;
        private TableLayoutPanel tableLayoutPanel6;
        private DataGridView dataGridViewMatiere;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private ToolTip toolTip1;
        private TextBox textBoxLoginProf;
        private TextBox textBoxMdpProf;
        private Label label1;
        private CheckBox checkBoxSuperAdmin;
    }
}
