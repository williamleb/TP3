namespace TP3
{
  partial class JeuTetris
  {
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose( bool disposing )
    {
      if ( disposing && ( components != null ) )
      {
        components.Dispose( );
      }
      base.Dispose( disposing );
    }

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent( )
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JeuTetris));
      this.tableauJeu = new System.Windows.Forms.TableLayoutPanel();
      this.tblLayoutJeu = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.grpBoxStatistiquesJeu = new System.Windows.Forms.GroupBox();
      this.lblNiveau = new System.Windows.Forms.Label();
      this.lblPointage = new System.Windows.Forms.Label();
      this.grpBoxParametresJeu = new System.Windows.Forms.GroupBox();
      this.layoutParametresJeu = new System.Windows.Forms.TableLayoutPanel();
      this.btnValider = new System.Windows.Forms.Button();
      this.lblLignes = new System.Windows.Forms.Label();
      this.lblColonnes = new System.Windows.Forms.Label();
      this.checkBoxMusique = new System.Windows.Forms.CheckBox();
      this.lblMusique = new System.Windows.Forms.Label();
      this.numLignes = new System.Windows.Forms.NumericUpDown();
      this.numColonnes = new System.Windows.Forms.NumericUpDown();
      this.layoutControles = new System.Windows.Forms.TableLayoutPanel();
      this.lblGauche = new System.Windows.Forms.Label();
      this.lblBas = new System.Windows.Forms.Label();
      this.lblDroite = new System.Windows.Forms.Label();
      this.lblHoraire = new System.Windows.Forms.Label();
      this.lblAntihoraire = new System.Windows.Forms.Label();
      this.lblTomber = new System.Windows.Forms.Label();
      this.menuStripJeu = new System.Windows.Forms.MenuStrip();
      this.menuPartie = new System.Windows.Forms.ToolStripMenuItem();
      this.menuJouer = new System.Windows.Forms.ToolStripMenuItem();
      this.menuReinitialiser = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.menuQuitter = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStatistiques = new System.Windows.Forms.ToolStripMenuItem();
      this.menuConfiguration = new System.Windows.Forms.ToolStripMenuItem();
      this.timerJeu = new System.Windows.Forms.Timer(this.components);
      this.timerTempsDeJeu = new System.Windows.Forms.Timer(this.components);
      this.lblTimerDuLaPartie = new System.Windows.Forms.Label();
      this.tblLayoutJeu.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.grpBoxStatistiquesJeu.SuspendLayout();
      this.grpBoxParametresJeu.SuspendLayout();
      this.layoutParametresJeu.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numLignes)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numColonnes)).BeginInit();
      this.layoutControles.SuspendLayout();
      this.menuStripJeu.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableauJeu
      // 
      this.tableauJeu.ColumnCount = 20;
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.63538F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.220217F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.01805F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.01805F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.01805F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.01805F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.01805F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.01805F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.01805F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.01805F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
      this.tableauJeu.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableauJeu.Location = new System.Drawing.Point(240, 0);
      this.tableauJeu.Margin = new System.Windows.Forms.Padding(0);
      this.tableauJeu.Name = "tableauJeu";
      this.tableauJeu.RowCount = 30;
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.628941F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.350646F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableauJeu.Size = new System.Drawing.Size(338, 565);
      this.tableauJeu.TabIndex = 1;
      // 
      // tblLayoutJeu
      // 
      this.tblLayoutJeu.ColumnCount = 2;
      this.tblLayoutJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
      this.tblLayoutJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.33333F));
      this.tblLayoutJeu.Controls.Add(this.tableauJeu, 1, 0);
      this.tblLayoutJeu.Controls.Add(this.tableLayoutPanel1, 0, 0);
      this.tblLayoutJeu.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tblLayoutJeu.Location = new System.Drawing.Point(0, 24);
      this.tblLayoutJeu.Name = "tblLayoutJeu";
      this.tblLayoutJeu.RowCount = 1;
      this.tblLayoutJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tblLayoutJeu.Size = new System.Drawing.Size(578, 565);
      this.tblLayoutJeu.TabIndex = 2;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.grpBoxStatistiquesJeu, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.grpBoxParametresJeu, 0, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(234, 559);
      this.tableLayoutPanel1.TabIndex = 2;
      // 
      // grpBoxStatistiquesJeu
      // 
      this.grpBoxStatistiquesJeu.Controls.Add(this.lblTimerDuLaPartie);
      this.grpBoxStatistiquesJeu.Controls.Add(this.lblNiveau);
      this.grpBoxStatistiquesJeu.Controls.Add(this.lblPointage);
      this.grpBoxStatistiquesJeu.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grpBoxStatistiquesJeu.Location = new System.Drawing.Point(3, 3);
      this.grpBoxStatistiquesJeu.Name = "grpBoxStatistiquesJeu";
      this.grpBoxStatistiquesJeu.Size = new System.Drawing.Size(228, 413);
      this.grpBoxStatistiquesJeu.TabIndex = 0;
      this.grpBoxStatistiquesJeu.TabStop = false;
      this.grpBoxStatistiquesJeu.Text = "Statistiques";
      // 
      // lblNiveau
      // 
      this.lblNiveau.AutoSize = true;
      this.lblNiveau.Location = new System.Drawing.Point(9, 86);
      this.lblNiveau.Name = "lblNiveau";
      this.lblNiveau.Size = new System.Drawing.Size(56, 13);
      this.lblNiveau.TabIndex = 1;
      this.lblNiveau.Text = "Niveau : 1";
      // 
      // lblPointage
      // 
      this.lblPointage.AutoSize = true;
      this.lblPointage.Location = new System.Drawing.Point(9, 42);
      this.lblPointage.Name = "lblPointage";
      this.lblPointage.Size = new System.Drawing.Size(64, 13);
      this.lblPointage.TabIndex = 0;
      this.lblPointage.Text = "Pointage : 0";
      // 
      // grpBoxParametresJeu
      // 
      this.grpBoxParametresJeu.Controls.Add(this.layoutParametresJeu);
      this.grpBoxParametresJeu.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grpBoxParametresJeu.Location = new System.Drawing.Point(3, 422);
      this.grpBoxParametresJeu.Name = "grpBoxParametresJeu";
      this.grpBoxParametresJeu.Size = new System.Drawing.Size(228, 134);
      this.grpBoxParametresJeu.TabIndex = 1;
      this.grpBoxParametresJeu.TabStop = false;
      this.grpBoxParametresJeu.Text = "Paramètres";
      // 
      // layoutParametresJeu
      // 
      this.layoutParametresJeu.ColumnCount = 3;
      this.layoutParametresJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.12613F));
      this.layoutParametresJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.42342F));
      this.layoutParametresJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.layoutParametresJeu.Controls.Add(this.btnValider, 0, 3);
      this.layoutParametresJeu.Controls.Add(this.lblLignes, 0, 0);
      this.layoutParametresJeu.Controls.Add(this.lblColonnes, 0, 1);
      this.layoutParametresJeu.Controls.Add(this.checkBoxMusique, 1, 2);
      this.layoutParametresJeu.Controls.Add(this.lblMusique, 0, 2);
      this.layoutParametresJeu.Controls.Add(this.numLignes, 1, 0);
      this.layoutParametresJeu.Controls.Add(this.numColonnes, 1, 1);
      this.layoutParametresJeu.Controls.Add(this.layoutControles, 2, 0);
      this.layoutParametresJeu.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutParametresJeu.Location = new System.Drawing.Point(3, 16);
      this.layoutParametresJeu.Name = "layoutParametresJeu";
      this.layoutParametresJeu.RowCount = 4;
      this.layoutParametresJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.layoutParametresJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.layoutParametresJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.layoutParametresJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.layoutParametresJeu.Size = new System.Drawing.Size(222, 115);
      this.layoutParametresJeu.TabIndex = 0;
      // 
      // btnValider
      // 
      this.layoutParametresJeu.SetColumnSpan(this.btnValider, 2);
      this.btnValider.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnValider.Location = new System.Drawing.Point(3, 87);
      this.btnValider.Name = "btnValider";
      this.btnValider.Size = new System.Drawing.Size(104, 25);
      this.btnValider.TabIndex = 0;
      this.btnValider.Text = "Valider";
      this.btnValider.UseVisualStyleBackColor = true;
      this.btnValider.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnMouseClickBtnValider);
      // 
      // lblLignes
      // 
      this.lblLignes.AutoSize = true;
      this.lblLignes.Location = new System.Drawing.Point(3, 0);
      this.lblLignes.Name = "lblLignes";
      this.lblLignes.Size = new System.Drawing.Size(38, 13);
      this.lblLignes.TabIndex = 1;
      this.lblLignes.Text = "Lignes";
      // 
      // lblColonnes
      // 
      this.lblColonnes.AutoSize = true;
      this.lblColonnes.Location = new System.Drawing.Point(3, 28);
      this.lblColonnes.Name = "lblColonnes";
      this.lblColonnes.Size = new System.Drawing.Size(51, 13);
      this.lblColonnes.TabIndex = 2;
      this.lblColonnes.Text = "Colonnes";
      // 
      // checkBoxMusique
      // 
      this.checkBoxMusique.AutoSize = true;
      this.checkBoxMusique.Checked = true;
      this.checkBoxMusique.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBoxMusique.Dock = System.Windows.Forms.DockStyle.Left;
      this.checkBoxMusique.Location = new System.Drawing.Point(61, 59);
      this.checkBoxMusique.Name = "checkBoxMusique";
      this.checkBoxMusique.Size = new System.Drawing.Size(15, 22);
      this.checkBoxMusique.TabIndex = 4;
      this.checkBoxMusique.UseVisualStyleBackColor = true;
      // 
      // lblMusique
      // 
      this.lblMusique.AutoSize = true;
      this.lblMusique.Location = new System.Drawing.Point(3, 56);
      this.lblMusique.Name = "lblMusique";
      this.lblMusique.Size = new System.Drawing.Size(47, 13);
      this.lblMusique.TabIndex = 3;
      this.lblMusique.Text = "Musique";
      // 
      // numLignes
      // 
      this.numLignes.Dock = System.Windows.Forms.DockStyle.Left;
      this.numLignes.Location = new System.Drawing.Point(61, 3);
      this.numLignes.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
      this.numLignes.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
      this.numLignes.Name = "numLignes";
      this.numLignes.Size = new System.Drawing.Size(46, 20);
      this.numLignes.TabIndex = 5;
      this.numLignes.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
      // 
      // numColonnes
      // 
      this.numColonnes.Dock = System.Windows.Forms.DockStyle.Left;
      this.numColonnes.Location = new System.Drawing.Point(61, 31);
      this.numColonnes.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
      this.numColonnes.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
      this.numColonnes.Name = "numColonnes";
      this.numColonnes.Size = new System.Drawing.Size(46, 20);
      this.numColonnes.TabIndex = 6;
      this.numColonnes.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
      // 
      // layoutControles
      // 
      this.layoutControles.ColumnCount = 1;
      this.layoutControles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.layoutControles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.layoutControles.Controls.Add(this.lblGauche, 0, 0);
      this.layoutControles.Controls.Add(this.lblBas, 0, 1);
      this.layoutControles.Controls.Add(this.lblDroite, 0, 2);
      this.layoutControles.Controls.Add(this.lblHoraire, 0, 3);
      this.layoutControles.Controls.Add(this.lblAntihoraire, 0, 4);
      this.layoutControles.Controls.Add(this.lblTomber, 0, 5);
      this.layoutControles.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControles.Location = new System.Drawing.Point(113, 3);
      this.layoutControles.Name = "layoutControles";
      this.layoutControles.RowCount = 6;
      this.layoutParametresJeu.SetRowSpan(this.layoutControles, 4);
      this.layoutControles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
      this.layoutControles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
      this.layoutControles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
      this.layoutControles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
      this.layoutControles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
      this.layoutControles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
      this.layoutControles.Size = new System.Drawing.Size(106, 109);
      this.layoutControles.TabIndex = 7;
      // 
      // lblGauche
      // 
      this.lblGauche.AutoSize = true;
      this.lblGauche.Location = new System.Drawing.Point(3, 0);
      this.lblGauche.Name = "lblGauche";
      this.lblGauche.Size = new System.Drawing.Size(61, 13);
      this.lblGauche.TabIndex = 0;
      this.lblGauche.Text = "Gauche : A";
      // 
      // lblBas
      // 
      this.lblBas.AutoSize = true;
      this.lblBas.Location = new System.Drawing.Point(3, 18);
      this.lblBas.Name = "lblBas";
      this.lblBas.Size = new System.Drawing.Size(41, 13);
      this.lblBas.TabIndex = 1;
      this.lblBas.Text = "Bas : S";
      // 
      // lblDroite
      // 
      this.lblDroite.AutoSize = true;
      this.lblDroite.Location = new System.Drawing.Point(3, 36);
      this.lblDroite.Name = "lblDroite";
      this.lblDroite.Size = new System.Drawing.Size(52, 13);
      this.lblDroite.TabIndex = 2;
      this.lblDroite.Text = "Droite : D";
      // 
      // lblHoraire
      // 
      this.lblHoraire.AutoSize = true;
      this.lblHoraire.Location = new System.Drawing.Point(3, 54);
      this.lblHoraire.Name = "lblHoraire";
      this.lblHoraire.Size = new System.Drawing.Size(58, 13);
      this.lblHoraire.TabIndex = 3;
      this.lblHoraire.Text = "Horaire : Q";
      // 
      // lblAntihoraire
      // 
      this.lblAntihoraire.AutoSize = true;
      this.lblAntihoraire.Location = new System.Drawing.Point(3, 72);
      this.lblAntihoraire.Name = "lblAntihoraire";
      this.lblAntihoraire.Size = new System.Drawing.Size(73, 13);
      this.lblAntihoraire.TabIndex = 4;
      this.lblAntihoraire.Text = "Antihoraire : E";
      // 
      // lblTomber
      // 
      this.lblTomber.AutoSize = true;
      this.lblTomber.Location = new System.Drawing.Point(3, 90);
      this.lblTomber.Name = "lblTomber";
      this.lblTomber.Size = new System.Drawing.Size(90, 13);
      this.lblTomber.TabIndex = 5;
      this.lblTomber.Text = "Tomber :  SPACE";
      // 
      // menuStripJeu
      // 
      this.menuStripJeu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPartie,
            this.menuStatistiques,
            this.menuConfiguration});
      this.menuStripJeu.Location = new System.Drawing.Point(0, 0);
      this.menuStripJeu.Name = "menuStripJeu";
      this.menuStripJeu.Size = new System.Drawing.Size(578, 24);
      this.menuStripJeu.TabIndex = 3;
      this.menuStripJeu.Text = "menuStrip1";
      // 
      // menuPartie
      // 
      this.menuPartie.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuJouer,
            this.menuReinitialiser,
            this.toolStripMenuItem1,
            this.menuQuitter});
      this.menuPartie.Name = "menuPartie";
      this.menuPartie.Size = new System.Drawing.Size(49, 20);
      this.menuPartie.Text = "Partie";
      // 
      // menuJouer
      // 
      this.menuJouer.Name = "menuJouer";
      this.menuJouer.Size = new System.Drawing.Size(134, 22);
      this.menuJouer.Text = "Jouer";
      this.menuJouer.Click += new System.EventHandler(this.OnClickMenuJouer);
      // 
      // menuReinitialiser
      // 
      this.menuReinitialiser.Name = "menuReinitialiser";
      this.menuReinitialiser.Size = new System.Drawing.Size(134, 22);
      this.menuReinitialiser.Text = "Réinitialiser";
      this.menuReinitialiser.Click += new System.EventHandler(this.menuReinitialiser_Click);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(131, 6);
      // 
      // menuQuitter
      // 
      this.menuQuitter.Name = "menuQuitter";
      this.menuQuitter.Size = new System.Drawing.Size(134, 22);
      this.menuQuitter.Text = "Quitter";
      this.menuQuitter.Click += new System.EventHandler(this.menuQuitter_Click);
      // 
      // menuStatistiques
      // 
      this.menuStatistiques.Name = "menuStatistiques";
      this.menuStatistiques.Size = new System.Drawing.Size(79, 20);
      this.menuStatistiques.Text = "Statistiques";
      // 
      // menuConfiguration
      // 
      this.menuConfiguration.Name = "menuConfiguration";
      this.menuConfiguration.Size = new System.Drawing.Size(93, 20);
      this.menuConfiguration.Text = "Configuration";
      this.menuConfiguration.Click += new System.EventHandler(this.OnClickMenuConfiguration);
      // 
      // timerJeu
      // 
      this.timerJeu.Interval = 500;
      this.timerJeu.Tick += new System.EventHandler(this.OnTickTimerJeu);
      // 
      // timerTempsDeJeu
      // 
      this.timerTempsDeJeu.Interval = 1000;
      this.timerTempsDeJeu.Tick += new System.EventHandler(this.timerTempsDeJeu_Tick);
      // 
      // lblTimerDuLaPartie
      // 
      this.lblTimerDuLaPartie.AutoSize = true;
      this.lblTimerDuLaPartie.Location = new System.Drawing.Point(9, 125);
      this.lblTimerDuLaPartie.Name = "lblTimerDuLaPartie";
      this.lblTimerDuLaPartie.Size = new System.Drawing.Size(54, 13);
      this.lblTimerDuLaPartie.TabIndex = 2;
      this.lblTimerDuLaPartie.Text = "Temps : 0";
      // 
      // JeuTetris
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(578, 589);
      this.Controls.Add(this.tblLayoutJeu);
      this.Controls.Add(this.menuStripJeu);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.MainMenuStrip = this.menuStripJeu;
      this.Name = "JeuTetris";
      this.Text = "Tetris";
      this.Load += new System.EventHandler(this.frmLoad);
      this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JeuTetris_KeyPress);
      this.tblLayoutJeu.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.grpBoxStatistiquesJeu.ResumeLayout(false);
      this.grpBoxStatistiquesJeu.PerformLayout();
      this.grpBoxParametresJeu.ResumeLayout(false);
      this.layoutParametresJeu.ResumeLayout(false);
      this.layoutParametresJeu.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numLignes)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numColonnes)).EndInit();
      this.layoutControles.ResumeLayout(false);
      this.layoutControles.PerformLayout();
      this.menuStripJeu.ResumeLayout(false);
      this.menuStripJeu.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableauJeu;
    private System.Windows.Forms.TableLayoutPanel tblLayoutJeu;
    private System.Windows.Forms.MenuStrip menuStripJeu;
    private System.Windows.Forms.ToolStripMenuItem menuPartie;
    private System.Windows.Forms.ToolStripMenuItem menuJouer;
    private System.Windows.Forms.ToolStripMenuItem menuReinitialiser;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem menuQuitter;
    private System.Windows.Forms.ToolStripMenuItem menuStatistiques;
    private System.Windows.Forms.ToolStripMenuItem menuConfiguration;
    private System.Windows.Forms.Timer timerJeu;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.GroupBox grpBoxStatistiquesJeu;
    private System.Windows.Forms.GroupBox grpBoxParametresJeu;
    private System.Windows.Forms.TableLayoutPanel layoutParametresJeu;
    private System.Windows.Forms.Button btnValider;
    private System.Windows.Forms.Label lblLignes;
    private System.Windows.Forms.Label lblColonnes;
    private System.Windows.Forms.CheckBox checkBoxMusique;
    private System.Windows.Forms.Label lblMusique;
    private System.Windows.Forms.NumericUpDown numLignes;
    private System.Windows.Forms.NumericUpDown numColonnes;
    private System.Windows.Forms.TableLayoutPanel layoutControles;
    private System.Windows.Forms.Label lblGauche;
    private System.Windows.Forms.Label lblBas;
    private System.Windows.Forms.Label lblDroite;
    private System.Windows.Forms.Label lblHoraire;
    private System.Windows.Forms.Label lblAntihoraire;
    private System.Windows.Forms.Label lblTomber;
    private System.Windows.Forms.Label lblNiveau;
    private System.Windows.Forms.Label lblPointage;
    private System.Windows.Forms.Timer timerTempsDeJeu;
    private System.Windows.Forms.Label lblTimerDuLaPartie;
  }
}

