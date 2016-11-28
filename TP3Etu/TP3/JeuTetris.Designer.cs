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
      this.grpBoxOptionsJeu = new System.Windows.Forms.GroupBox();
      this.menuStripJeu = new System.Windows.Forms.MenuStrip();
      this.menuPartie = new System.Windows.Forms.ToolStripMenuItem();
      this.menuJouer = new System.Windows.Forms.ToolStripMenuItem();
      this.menuReinitialiser = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.menuQuitter = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStatistiques = new System.Windows.Forms.ToolStripMenuItem();
      this.menuConfiguration = new System.Windows.Forms.ToolStripMenuItem();
      this.timerJeu = new System.Windows.Forms.Timer(this.components);
      this.tblLayoutJeu.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
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
      this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
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
      this.tableLayoutPanel1.Controls.Add(this.grpBoxOptionsJeu, 0, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(234, 559);
      this.tableLayoutPanel1.TabIndex = 2;
      // 
      // grpBoxStatistiquesJeu
      // 
      this.grpBoxStatistiquesJeu.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grpBoxStatistiquesJeu.Location = new System.Drawing.Point(3, 3);
      this.grpBoxStatistiquesJeu.Name = "grpBoxStatistiquesJeu";
      this.grpBoxStatistiquesJeu.Size = new System.Drawing.Size(228, 329);
      this.grpBoxStatistiquesJeu.TabIndex = 0;
      this.grpBoxStatistiquesJeu.TabStop = false;
      this.grpBoxStatistiquesJeu.Text = "Statistiques";
      // 
      // grpBoxOptionsJeu
      // 
      this.grpBoxOptionsJeu.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grpBoxOptionsJeu.Location = new System.Drawing.Point(3, 338);
      this.grpBoxOptionsJeu.Name = "grpBoxOptionsJeu";
      this.grpBoxOptionsJeu.Size = new System.Drawing.Size(228, 218);
      this.grpBoxOptionsJeu.TabIndex = 1;
      this.grpBoxOptionsJeu.TabStop = false;
      this.grpBoxOptionsJeu.Text = "Options";
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
      this.timerJeu.Tick += new System.EventHandler(this.OnTickTimerJeu);
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
    private System.Windows.Forms.GroupBox grpBoxOptionsJeu;
  }
}

