namespace TP3
{
  partial class ConfigurationFenetre
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.layoutConfig = new System.Windows.Forms.TableLayoutPanel();
      this.lblNbLignes = new System.Windows.Forms.Label();
      this.lblNbColonnes = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.checkBoxMusique = new System.Windows.Forms.CheckBox();
      this.lblTouches = new System.Windows.Forms.Label();
      this.layoutBtns = new System.Windows.Forms.TableLayoutPanel();
      this.btnValider = new System.Windows.Forms.Button();
      this.btnAnnuler = new System.Windows.Forms.Button();
      this.trackBarNbLignes = new System.Windows.Forms.TrackBar();
      this.trackBarNbColonnes = new System.Windows.Forms.TrackBar();
      this.numNbLignes = new System.Windows.Forms.NumericUpDown();
      this.numNbColonnes = new System.Windows.Forms.NumericUpDown();
      this.btnConfigurerTouches = new System.Windows.Forms.Button();
      this.layoutConfig.SuspendLayout();
      this.layoutBtns.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarNbLignes)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarNbColonnes)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numNbLignes)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numNbColonnes)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutConfig
      // 
      this.layoutConfig.ColumnCount = 3;
      this.layoutConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.44654F));
      this.layoutConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.01258F));
      this.layoutConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.85535F));
      this.layoutConfig.Controls.Add(this.lblNbLignes, 0, 0);
      this.layoutConfig.Controls.Add(this.lblNbColonnes, 0, 1);
      this.layoutConfig.Controls.Add(this.label3, 0, 2);
      this.layoutConfig.Controls.Add(this.checkBoxMusique, 1, 2);
      this.layoutConfig.Controls.Add(this.lblTouches, 0, 3);
      this.layoutConfig.Controls.Add(this.layoutBtns, 0, 4);
      this.layoutConfig.Controls.Add(this.trackBarNbLignes, 2, 0);
      this.layoutConfig.Controls.Add(this.trackBarNbColonnes, 2, 1);
      this.layoutConfig.Controls.Add(this.numNbLignes, 1, 0);
      this.layoutConfig.Controls.Add(this.numNbColonnes, 1, 1);
      this.layoutConfig.Controls.Add(this.btnConfigurerTouches, 1, 3);
      this.layoutConfig.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutConfig.Location = new System.Drawing.Point(0, 0);
      this.layoutConfig.Name = "layoutConfig";
      this.layoutConfig.RowCount = 5;
      this.layoutConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.layoutConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.layoutConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.layoutConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.layoutConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.layoutConfig.Size = new System.Drawing.Size(318, 174);
      this.layoutConfig.TabIndex = 0;
      // 
      // lblNbLignes
      // 
      this.lblNbLignes.AutoSize = true;
      this.lblNbLignes.Location = new System.Drawing.Point(3, 0);
      this.lblNbLignes.Name = "lblNbLignes";
      this.lblNbLignes.Size = new System.Drawing.Size(89, 13);
      this.lblNbLignes.TabIndex = 0;
      this.lblNbLignes.Text = "Nombre de lignes";
      // 
      // lblNbColonnes
      // 
      this.lblNbColonnes.AutoSize = true;
      this.lblNbColonnes.Location = new System.Drawing.Point(3, 34);
      this.lblNbColonnes.Name = "lblNbColonnes";
      this.lblNbColonnes.Size = new System.Drawing.Size(62, 26);
      this.lblNbColonnes.TabIndex = 1;
      this.lblNbColonnes.Text = "Nombre de colonnes";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(3, 68);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(47, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Musique";
      // 
      // checkBoxMusique
      // 
      this.checkBoxMusique.AutoSize = true;
      this.checkBoxMusique.Location = new System.Drawing.Point(102, 71);
      this.checkBoxMusique.Name = "checkBoxMusique";
      this.checkBoxMusique.Size = new System.Drawing.Size(62, 17);
      this.checkBoxMusique.TabIndex = 3;
      this.checkBoxMusique.Text = "Activée";
      this.checkBoxMusique.UseVisualStyleBackColor = true;
      this.checkBoxMusique.CheckedChanged += new System.EventHandler(this.OnCheckCheckBoxMusique);
      // 
      // lblTouches
      // 
      this.lblTouches.AutoSize = true;
      this.lblTouches.Location = new System.Drawing.Point(3, 102);
      this.lblTouches.Name = "lblTouches";
      this.lblTouches.Size = new System.Drawing.Size(49, 13);
      this.lblTouches.TabIndex = 4;
      this.lblTouches.Text = "Touches";
      // 
      // layoutBtns
      // 
      this.layoutBtns.ColumnCount = 2;
      this.layoutConfig.SetColumnSpan(this.layoutBtns, 3);
      this.layoutBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.layoutBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.layoutBtns.Controls.Add(this.btnValider, 0, 0);
      this.layoutBtns.Controls.Add(this.btnAnnuler, 1, 0);
      this.layoutBtns.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutBtns.Location = new System.Drawing.Point(3, 139);
      this.layoutBtns.Name = "layoutBtns";
      this.layoutBtns.RowCount = 1;
      this.layoutBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.layoutBtns.Size = new System.Drawing.Size(312, 32);
      this.layoutBtns.TabIndex = 9;
      // 
      // btnValider
      // 
      this.btnValider.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnValider.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnValider.Location = new System.Drawing.Point(3, 3);
      this.btnValider.Name = "btnValider";
      this.btnValider.Size = new System.Drawing.Size(150, 26);
      this.btnValider.TabIndex = 5;
      this.btnValider.Text = "Valider";
      this.btnValider.UseVisualStyleBackColor = true;
      // 
      // btnAnnuler
      // 
      this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnAnnuler.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnAnnuler.Location = new System.Drawing.Point(159, 3);
      this.btnAnnuler.Name = "btnAnnuler";
      this.btnAnnuler.Size = new System.Drawing.Size(150, 26);
      this.btnAnnuler.TabIndex = 6;
      this.btnAnnuler.Text = "Annuler";
      this.btnAnnuler.UseVisualStyleBackColor = true;
      // 
      // trackBarNbLignes
      // 
      this.trackBarNbLignes.Dock = System.Windows.Forms.DockStyle.Fill;
      this.trackBarNbLignes.Location = new System.Drawing.Point(171, 3);
      this.trackBarNbLignes.Maximum = 30;
      this.trackBarNbLignes.Minimum = 5;
      this.trackBarNbLignes.Name = "trackBarNbLignes";
      this.trackBarNbLignes.Size = new System.Drawing.Size(144, 28);
      this.trackBarNbLignes.TabIndex = 10;
      this.trackBarNbLignes.Value = 20;
      this.trackBarNbLignes.Scroll += new System.EventHandler(this.OnScrollTrackBarNbLignes);
      // 
      // trackBarNbColonnes
      // 
      this.trackBarNbColonnes.Dock = System.Windows.Forms.DockStyle.Fill;
      this.trackBarNbColonnes.Location = new System.Drawing.Point(171, 37);
      this.trackBarNbColonnes.Maximum = 20;
      this.trackBarNbColonnes.Minimum = 8;
      this.trackBarNbColonnes.Name = "trackBarNbColonnes";
      this.trackBarNbColonnes.Size = new System.Drawing.Size(144, 28);
      this.trackBarNbColonnes.TabIndex = 11;
      this.trackBarNbColonnes.Value = 10;
      this.trackBarNbColonnes.Scroll += new System.EventHandler(this.OnScrollTrackBarNbColonnes);
      // 
      // numNbLignes
      // 
      this.numNbLignes.Dock = System.Windows.Forms.DockStyle.Fill;
      this.numNbLignes.Location = new System.Drawing.Point(102, 3);
      this.numNbLignes.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
      this.numNbLignes.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
      this.numNbLignes.Name = "numNbLignes";
      this.numNbLignes.Size = new System.Drawing.Size(63, 20);
      this.numNbLignes.TabIndex = 12;
      this.numNbLignes.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
      this.numNbLignes.ValueChanged += new System.EventHandler(this.OnChangeNumNbLignes);
      // 
      // numNbColonnes
      // 
      this.numNbColonnes.Dock = System.Windows.Forms.DockStyle.Fill;
      this.numNbColonnes.Location = new System.Drawing.Point(102, 37);
      this.numNbColonnes.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
      this.numNbColonnes.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
      this.numNbColonnes.Name = "numNbColonnes";
      this.numNbColonnes.Size = new System.Drawing.Size(63, 20);
      this.numNbColonnes.TabIndex = 13;
      this.numNbColonnes.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
      this.numNbColonnes.ValueChanged += new System.EventHandler(this.OnChangeNumNbColonnes);
      // 
      // btnConfigurerTouches
      // 
      this.layoutConfig.SetColumnSpan(this.btnConfigurerTouches, 2);
      this.btnConfigurerTouches.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnConfigurerTouches.Location = new System.Drawing.Point(102, 105);
      this.btnConfigurerTouches.Name = "btnConfigurerTouches";
      this.btnConfigurerTouches.Size = new System.Drawing.Size(213, 28);
      this.btnConfigurerTouches.TabIndex = 14;
      this.btnConfigurerTouches.Text = "Configurer les touches";
      this.btnConfigurerTouches.UseVisualStyleBackColor = true;
      this.btnConfigurerTouches.Click += new System.EventHandler(this.OnClickBtnConfigurerTouches);
      // 
      // ConfigurationFenetre
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(318, 174);
      this.Controls.Add(this.layoutConfig);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ConfigurationFenetre";
      this.ShowIcon = false;
      this.Text = "Configuration";
      this.Load += new System.EventHandler(this.OnLoadConfigurationFenetre);
      this.layoutConfig.ResumeLayout(false);
      this.layoutConfig.PerformLayout();
      this.layoutBtns.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.trackBarNbLignes)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarNbColonnes)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numNbLignes)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numNbColonnes)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel layoutConfig;
    private System.Windows.Forms.Label lblNbLignes;
    private System.Windows.Forms.Label lblNbColonnes;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.CheckBox checkBoxMusique;
    private System.Windows.Forms.Label lblTouches;
    private System.Windows.Forms.Button btnValider;
    private System.Windows.Forms.Button btnAnnuler;
    private System.Windows.Forms.TableLayoutPanel layoutBtns;
    private System.Windows.Forms.TrackBar trackBarNbLignes;
    private System.Windows.Forms.TrackBar trackBarNbColonnes;
    private System.Windows.Forms.NumericUpDown numNbLignes;
    private System.Windows.Forms.NumericUpDown numNbColonnes;
    private System.Windows.Forms.Button btnConfigurerTouches;
  }
}