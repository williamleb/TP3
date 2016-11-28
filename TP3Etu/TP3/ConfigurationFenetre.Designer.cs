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
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.lblNbLignes = new System.Windows.Forms.Label();
      this.lblNbColonnes = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.checkBoxMusique = new System.Windows.Forms.CheckBox();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 3;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.37838F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.37838F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.24324F));
      this.tableLayoutPanel1.Controls.Add(this.lblNbLignes, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.lblNbColonnes, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.checkBoxMusique, 1, 2);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 5;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(318, 174);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // lblNbLignes
      // 
      this.lblNbLignes.AutoSize = true;
      this.lblNbLignes.Location = new System.Drawing.Point(3, 0);
      this.lblNbLignes.Name = "lblNbLignes";
      this.lblNbLignes.Size = new System.Drawing.Size(62, 26);
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
      this.checkBoxMusique.Location = new System.Drawing.Point(93, 71);
      this.checkBoxMusique.Name = "checkBoxMusique";
      this.checkBoxMusique.Size = new System.Drawing.Size(62, 17);
      this.checkBoxMusique.TabIndex = 3;
      this.checkBoxMusique.Text = "Activée";
      this.checkBoxMusique.UseVisualStyleBackColor = true;
      this.checkBoxMusique.CheckedChanged += new System.EventHandler(this.OnCheckCheckBoxMusique);
      // 
      // ConfigurationFenetre
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(318, 174);
      this.Controls.Add(this.tableLayoutPanel1);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ConfigurationFenetre";
      this.ShowIcon = false;
      this.Text = "Configuration";
      this.Load += new System.EventHandler(this.OnLoadConfigurationFenetre);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label lblNbLignes;
    private System.Windows.Forms.Label lblNbColonnes;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.CheckBox checkBoxMusique;
  }
}