namespace TP3
{
  partial class TouchesFenetre
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
      this.btnGauche = new System.Windows.Forms.Button();
      this.btnBas = new System.Windows.Forms.Button();
      this.btnDroite = new System.Windows.Forms.Button();
      this.btnHoraire = new System.Windows.Forms.Button();
      this.btnAntihoraire = new System.Windows.Forms.Button();
      this.btnTomber = new System.Windows.Forms.Button();
      this.btnDefaut = new System.Windows.Forms.Button();
      this.btnValider = new System.Windows.Forms.Button();
      this.btnAnnuler = new System.Windows.Forms.Button();
      this.lblGauche = new System.Windows.Forms.Label();
      this.lblBas = new System.Windows.Forms.Label();
      this.lblDroite = new System.Windows.Forms.Label();
      this.lblHoraire = new System.Windows.Forms.Label();
      this.lblAntihoraire = new System.Windows.Forms.Label();
      this.lblTomber = new System.Windows.Forms.Label();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 4;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.Controls.Add(this.btnGauche, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.btnBas, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.btnDroite, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.btnHoraire, 3, 0);
      this.tableLayoutPanel1.Controls.Add(this.btnAntihoraire, 3, 1);
      this.tableLayoutPanel1.Controls.Add(this.btnTomber, 3, 2);
      this.tableLayoutPanel1.Controls.Add(this.btnDefaut, 0, 3);
      this.tableLayoutPanel1.Controls.Add(this.btnValider, 0, 4);
      this.tableLayoutPanel1.Controls.Add(this.btnAnnuler, 2, 4);
      this.tableLayoutPanel1.Controls.Add(this.lblGauche, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.lblBas, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.lblDroite, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.lblHoraire, 2, 0);
      this.tableLayoutPanel1.Controls.Add(this.lblAntihoraire, 2, 1);
      this.tableLayoutPanel1.Controls.Add(this.lblTomber, 2, 2);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 5;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(262, 164);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // btnGauche
      // 
      this.btnGauche.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnGauche.Location = new System.Drawing.Point(68, 3);
      this.btnGauche.Name = "btnGauche";
      this.btnGauche.Size = new System.Drawing.Size(59, 26);
      this.btnGauche.TabIndex = 0;
      this.btnGauche.Text = "A";
      this.btnGauche.UseVisualStyleBackColor = true;
      this.btnGauche.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPressBtnGauche);
      // 
      // btnBas
      // 
      this.btnBas.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnBas.Location = new System.Drawing.Point(68, 35);
      this.btnBas.Name = "btnBas";
      this.btnBas.Size = new System.Drawing.Size(59, 26);
      this.btnBas.TabIndex = 1;
      this.btnBas.Text = "S";
      this.btnBas.UseVisualStyleBackColor = true;
      // 
      // btnDroite
      // 
      this.btnDroite.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnDroite.Location = new System.Drawing.Point(68, 67);
      this.btnDroite.Name = "btnDroite";
      this.btnDroite.Size = new System.Drawing.Size(59, 26);
      this.btnDroite.TabIndex = 2;
      this.btnDroite.Text = "D";
      this.btnDroite.UseVisualStyleBackColor = true;
      // 
      // btnHoraire
      // 
      this.btnHoraire.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnHoraire.Location = new System.Drawing.Point(198, 3);
      this.btnHoraire.Name = "btnHoraire";
      this.btnHoraire.Size = new System.Drawing.Size(61, 26);
      this.btnHoraire.TabIndex = 3;
      this.btnHoraire.Text = "Q";
      this.btnHoraire.UseVisualStyleBackColor = true;
      // 
      // btnAntihoraire
      // 
      this.btnAntihoraire.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnAntihoraire.Location = new System.Drawing.Point(198, 35);
      this.btnAntihoraire.Name = "btnAntihoraire";
      this.btnAntihoraire.Size = new System.Drawing.Size(61, 26);
      this.btnAntihoraire.TabIndex = 4;
      this.btnAntihoraire.Text = "E";
      this.btnAntihoraire.UseVisualStyleBackColor = true;
      // 
      // btnTomber
      // 
      this.btnTomber.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnTomber.Location = new System.Drawing.Point(198, 67);
      this.btnTomber.Name = "btnTomber";
      this.btnTomber.Size = new System.Drawing.Size(61, 26);
      this.btnTomber.TabIndex = 5;
      this.btnTomber.Text = "SPACE";
      this.btnTomber.UseVisualStyleBackColor = true;
      // 
      // btnDefaut
      // 
      this.tableLayoutPanel1.SetColumnSpan(this.btnDefaut, 4);
      this.btnDefaut.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnDefaut.Location = new System.Drawing.Point(3, 99);
      this.btnDefaut.Name = "btnDefaut";
      this.btnDefaut.Size = new System.Drawing.Size(256, 26);
      this.btnDefaut.TabIndex = 6;
      this.btnDefaut.Text = "Valeurs par défaut";
      this.btnDefaut.UseVisualStyleBackColor = true;
      this.btnDefaut.Click += new System.EventHandler(this.OnClickBtnDefaut);
      // 
      // btnValider
      // 
      this.tableLayoutPanel1.SetColumnSpan(this.btnValider, 2);
      this.btnValider.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnValider.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnValider.Location = new System.Drawing.Point(3, 131);
      this.btnValider.Name = "btnValider";
      this.btnValider.Size = new System.Drawing.Size(124, 30);
      this.btnValider.TabIndex = 7;
      this.btnValider.Text = "Valider";
      this.btnValider.UseVisualStyleBackColor = true;
      // 
      // btnAnnuler
      // 
      this.tableLayoutPanel1.SetColumnSpan(this.btnAnnuler, 2);
      this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnAnnuler.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnAnnuler.Location = new System.Drawing.Point(133, 131);
      this.btnAnnuler.Name = "btnAnnuler";
      this.btnAnnuler.Size = new System.Drawing.Size(126, 30);
      this.btnAnnuler.TabIndex = 8;
      this.btnAnnuler.Text = "Annuler";
      this.btnAnnuler.UseVisualStyleBackColor = true;
      // 
      // lblGauche
      // 
      this.lblGauche.AutoSize = true;
      this.lblGauche.Location = new System.Drawing.Point(3, 0);
      this.lblGauche.Name = "lblGauche";
      this.lblGauche.Size = new System.Drawing.Size(45, 13);
      this.lblGauche.TabIndex = 9;
      this.lblGauche.Text = "Gauche";
      // 
      // lblBas
      // 
      this.lblBas.AutoSize = true;
      this.lblBas.Location = new System.Drawing.Point(3, 32);
      this.lblBas.Name = "lblBas";
      this.lblBas.Size = new System.Drawing.Size(25, 13);
      this.lblBas.TabIndex = 10;
      this.lblBas.Text = "Bas";
      // 
      // lblDroite
      // 
      this.lblDroite.AutoSize = true;
      this.lblDroite.Location = new System.Drawing.Point(3, 64);
      this.lblDroite.Name = "lblDroite";
      this.lblDroite.Size = new System.Drawing.Size(35, 13);
      this.lblDroite.TabIndex = 11;
      this.lblDroite.Text = "Droite";
      // 
      // lblHoraire
      // 
      this.lblHoraire.AutoSize = true;
      this.lblHoraire.Location = new System.Drawing.Point(133, 0);
      this.lblHoraire.Name = "lblHoraire";
      this.lblHoraire.Size = new System.Drawing.Size(41, 13);
      this.lblHoraire.TabIndex = 12;
      this.lblHoraire.Text = "Horaire";
      // 
      // lblAntihoraire
      // 
      this.lblAntihoraire.AutoSize = true;
      this.lblAntihoraire.Location = new System.Drawing.Point(133, 32);
      this.lblAntihoraire.Name = "lblAntihoraire";
      this.lblAntihoraire.Size = new System.Drawing.Size(57, 13);
      this.lblAntihoraire.TabIndex = 13;
      this.lblAntihoraire.Text = "Antihoraire";
      // 
      // lblTomber
      // 
      this.lblTomber.AutoSize = true;
      this.lblTomber.Location = new System.Drawing.Point(133, 64);
      this.lblTomber.Name = "lblTomber";
      this.lblTomber.Size = new System.Drawing.Size(43, 13);
      this.lblTomber.TabIndex = 14;
      this.lblTomber.Text = "Tomber";
      // 
      // TouchesFenetre
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(262, 164);
      this.Controls.Add(this.tableLayoutPanel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "TouchesFenetre";
      this.ShowIcon = false;
      this.Text = "Configuration des touches";
      this.Load += new System.EventHandler(this.OnLoadTouchesFenetre);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Button btnGauche;
    private System.Windows.Forms.Button btnBas;
    private System.Windows.Forms.Button btnDroite;
    private System.Windows.Forms.Button btnHoraire;
    private System.Windows.Forms.Button btnAntihoraire;
    private System.Windows.Forms.Button btnTomber;
    private System.Windows.Forms.Button btnDefaut;
    private System.Windows.Forms.Button btnValider;
    private System.Windows.Forms.Button btnAnnuler;
    private System.Windows.Forms.Label lblGauche;
    private System.Windows.Forms.Label lblBas;
    private System.Windows.Forms.Label lblDroite;
    private System.Windows.Forms.Label lblHoraire;
    private System.Windows.Forms.Label lblAntihoraire;
    private System.Windows.Forms.Label lblTomber;
  }
}