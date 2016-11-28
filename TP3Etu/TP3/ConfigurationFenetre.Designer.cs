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
      this.txtBoxNbColonnes = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.layoutBtns = new System.Windows.Forms.TableLayoutPanel();
      this.btnValider = new System.Windows.Forms.Button();
      this.btnAnnuler = new System.Windows.Forms.Button();
      this.layoutConfig.SuspendLayout();
      this.layoutBtns.SuspendLayout();
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
      this.layoutConfig.Controls.Add(this.txtBoxNbColonnes, 1, 1);
      this.layoutConfig.Controls.Add(this.textBox2, 1, 0);
      this.layoutConfig.Controls.Add(this.layoutBtns, 0, 4);
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
      // txtBoxNbColonnes
      // 
      this.txtBoxNbColonnes.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtBoxNbColonnes.Enabled = false;
      this.txtBoxNbColonnes.Location = new System.Drawing.Point(102, 37);
      this.txtBoxNbColonnes.Name = "txtBoxNbColonnes";
      this.txtBoxNbColonnes.Size = new System.Drawing.Size(63, 20);
      this.txtBoxNbColonnes.TabIndex = 7;
      this.txtBoxNbColonnes.Text = "10";
      this.txtBoxNbColonnes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // textBox2
      // 
      this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.textBox2.Enabled = false;
      this.textBox2.Location = new System.Drawing.Point(102, 3);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(63, 20);
      this.textBox2.TabIndex = 8;
      this.textBox2.Text = "20";
      this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
      // ConfigurationFenetre
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(318, 174);
      this.Controls.Add(this.layoutConfig);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ConfigurationFenetre";
      this.ShowIcon = false;
      this.Text = "Configuration";
      this.Load += new System.EventHandler(this.OnLoadConfigurationFenetre);
      this.layoutConfig.ResumeLayout(false);
      this.layoutConfig.PerformLayout();
      this.layoutBtns.ResumeLayout(false);
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
    private System.Windows.Forms.TextBox txtBoxNbColonnes;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TableLayoutPanel layoutBtns;
  }
}