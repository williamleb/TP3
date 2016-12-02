namespace TP3
{
  partial class frmFinDePartie
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
      this.lblPieceBloc = new System.Windows.Forms.Label();
      this.tLPStatistiqueFinDePartie = new System.Windows.Forms.TableLayoutPanel();
      this.lblBarreVerticale = new System.Windows.Forms.Label();
      this.lblBarreHorizontale = new System.Windows.Forms.Label();
      this.lblEnFormeDeT = new System.Windows.Forms.Label();
      this.lblEnJ = new System.Windows.Forms.Label();
      this.lblEnL = new System.Windows.Forms.Label();
      this.lblEnS = new System.Windows.Forms.Label();
      this.lblEnZ = new System.Windows.Forms.Label();
      this.txtBNbBloc = new System.Windows.Forms.TextBox();
      this.txtBNbBarreVerticale = new System.Windows.Forms.TextBox();
      this.txtBNbBarreHorizontale = new System.Windows.Forms.TextBox();
      this.txtBNbEnT = new System.Windows.Forms.TextBox();
      this.txtBNbEnJ = new System.Windows.Forms.TextBox();
      this.txtBNbEnL = new System.Windows.Forms.TextBox();
      this.txtBNbEnS = new System.Windows.Forms.TextBox();
      this.txtBNbEnZ = new System.Windows.Forms.TextBox();
      this.lblPointage = new System.Windows.Forms.Label();
      this.lblTempsEcoule = new System.Windows.Forms.Label();
      this.tLPStatistiqueFinDePartie.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblPieceBloc
      // 
      this.lblPieceBloc.AutoSize = true;
      this.lblPieceBloc.Location = new System.Drawing.Point(3, 0);
      this.lblPieceBloc.Name = "lblPieceBloc";
      this.lblPieceBloc.Size = new System.Drawing.Size(75, 13);
      this.lblPieceBloc.TabIndex = 0;
      this.lblPieceBloc.Text = "Bloc générés :";
      this.lblPieceBloc.Click += new System.EventHandler(this.label1lblFinDePartie_Click);
      // 
      // tLPStatistiqueFinDePartie
      // 
      this.tLPStatistiqueFinDePartie.ColumnCount = 4;
      this.tLPStatistiqueFinDePartie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tLPStatistiqueFinDePartie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tLPStatistiqueFinDePartie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tLPStatistiqueFinDePartie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tLPStatistiqueFinDePartie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tLPStatistiqueFinDePartie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tLPStatistiqueFinDePartie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tLPStatistiqueFinDePartie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tLPStatistiqueFinDePartie.Controls.Add(this.lblPieceBloc, 0, 0);
      this.tLPStatistiqueFinDePartie.Controls.Add(this.lblBarreVerticale, 0, 1);
      this.tLPStatistiqueFinDePartie.Controls.Add(this.lblBarreHorizontale, 0, 2);
      this.tLPStatistiqueFinDePartie.Controls.Add(this.lblEnFormeDeT, 0, 3);
      this.tLPStatistiqueFinDePartie.Controls.Add(this.lblEnJ, 0, 4);
      this.tLPStatistiqueFinDePartie.Controls.Add(this.lblEnL, 0, 5);
      this.tLPStatistiqueFinDePartie.Controls.Add(this.lblEnS, 0, 6);
      this.tLPStatistiqueFinDePartie.Controls.Add(this.lblEnZ, 0, 7);
      this.tLPStatistiqueFinDePartie.Controls.Add(this.txtBNbBloc, 1, 0);
      this.tLPStatistiqueFinDePartie.Controls.Add(this.txtBNbBarreVerticale, 1, 1);
      this.tLPStatistiqueFinDePartie.Controls.Add(this.txtBNbBarreHorizontale, 1, 2);
      this.tLPStatistiqueFinDePartie.Controls.Add(this.txtBNbEnT, 1, 3);
      this.tLPStatistiqueFinDePartie.Controls.Add(this.txtBNbEnJ, 1, 4);
      this.tLPStatistiqueFinDePartie.Controls.Add(this.txtBNbEnL, 1, 5);
      this.tLPStatistiqueFinDePartie.Controls.Add(this.txtBNbEnS, 1, 6);
      this.tLPStatistiqueFinDePartie.Controls.Add(this.txtBNbEnZ, 1, 7);
      this.tLPStatistiqueFinDePartie.Controls.Add(this.lblPointage, 3, 0);
      this.tLPStatistiqueFinDePartie.Controls.Add(this.lblTempsEcoule, 3, 4);
      this.tLPStatistiqueFinDePartie.Location = new System.Drawing.Point(13, 13);
      this.tLPStatistiqueFinDePartie.Name = "tLPStatistiqueFinDePartie";
      this.tLPStatistiqueFinDePartie.RowCount = 8;
      this.tLPStatistiqueFinDePartie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
      this.tLPStatistiqueFinDePartie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
      this.tLPStatistiqueFinDePartie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
      this.tLPStatistiqueFinDePartie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
      this.tLPStatistiqueFinDePartie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.57143F));
      this.tLPStatistiqueFinDePartie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.28571F));
      this.tLPStatistiqueFinDePartie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
      this.tLPStatistiqueFinDePartie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
      this.tLPStatistiqueFinDePartie.Size = new System.Drawing.Size(724, 700);
      this.tLPStatistiqueFinDePartie.TabIndex = 1;
      this.tLPStatistiqueFinDePartie.Paint += new System.Windows.Forms.PaintEventHandler(this.tLPStatistiqueFinDePartie_Paint);
      // 
      // lblBarreVerticale
      // 
      this.lblBarreVerticale.AutoSize = true;
      this.lblBarreVerticale.Location = new System.Drawing.Point(3, 87);
      this.lblBarreVerticale.Name = "lblBarreVerticale";
      this.lblBarreVerticale.Size = new System.Drawing.Size(128, 13);
      this.lblBarreVerticale.TabIndex = 1;
      this.lblBarreVerticale.Text = "Barre verticale générées :";
      // 
      // lblBarreHorizontale
      // 
      this.lblBarreHorizontale.AutoSize = true;
      this.lblBarreHorizontale.Location = new System.Drawing.Point(3, 174);
      this.lblBarreHorizontale.Name = "lblBarreHorizontale";
      this.lblBarreHorizontale.Size = new System.Drawing.Size(139, 13);
      this.lblBarreHorizontale.TabIndex = 2;
      this.lblBarreHorizontale.Text = "Barre horizontale générées :";
      // 
      // lblEnFormeDeT
      // 
      this.lblEnFormeDeT.AutoSize = true;
      this.lblEnFormeDeT.Location = new System.Drawing.Point(3, 261);
      this.lblEnFormeDeT.Name = "lblEnFormeDeT";
      this.lblEnFormeDeT.Size = new System.Drawing.Size(161, 13);
      this.lblEnFormeDeT.TabIndex = 3;
      this.lblEnFormeDeT.Text = "Pièces en forme de T générées :";
      // 
      // lblEnJ
      // 
      this.lblEnJ.AutoSize = true;
      this.lblEnJ.Location = new System.Drawing.Point(3, 348);
      this.lblEnJ.Name = "lblEnJ";
      this.lblEnJ.Size = new System.Drawing.Size(159, 13);
      this.lblEnJ.TabIndex = 4;
      this.lblEnJ.Text = "Pièces en forme de J générées :";
      // 
      // lblEnL
      // 
      this.lblEnL.AutoSize = true;
      this.lblEnL.Location = new System.Drawing.Point(3, 436);
      this.lblEnL.Name = "lblEnL";
      this.lblEnL.Size = new System.Drawing.Size(160, 13);
      this.lblEnL.TabIndex = 5;
      this.lblEnL.Text = "Pièces en forme de L générées :";
      // 
      // lblEnS
      // 
      this.lblEnS.AutoSize = true;
      this.lblEnS.Location = new System.Drawing.Point(3, 522);
      this.lblEnS.Name = "lblEnS";
      this.lblEnS.Size = new System.Drawing.Size(161, 13);
      this.lblEnS.TabIndex = 6;
      this.lblEnS.Text = "Pièces en forme de S générées :";
      // 
      // lblEnZ
      // 
      this.lblEnZ.AutoSize = true;
      this.lblEnZ.Location = new System.Drawing.Point(3, 609);
      this.lblEnZ.Name = "lblEnZ";
      this.lblEnZ.Size = new System.Drawing.Size(161, 13);
      this.lblEnZ.TabIndex = 7;
      this.lblEnZ.Text = "Pièces en forme de Z générées :";
      // 
      // txtBNbBloc
      // 
      this.txtBNbBloc.Enabled = false;
      this.txtBNbBloc.Location = new System.Drawing.Point(184, 3);
      this.txtBNbBloc.Name = "txtBNbBloc";
      this.txtBNbBloc.Size = new System.Drawing.Size(175, 20);
      this.txtBNbBloc.TabIndex = 8;
      this.txtBNbBloc.TextChanged += new System.EventHandler(this.txtBNbBloc_TextChanged);
      // 
      // txtBNbBarreVerticale
      // 
      this.txtBNbBarreVerticale.Enabled = false;
      this.txtBNbBarreVerticale.Location = new System.Drawing.Point(184, 90);
      this.txtBNbBarreVerticale.Name = "txtBNbBarreVerticale";
      this.txtBNbBarreVerticale.Size = new System.Drawing.Size(175, 20);
      this.txtBNbBarreVerticale.TabIndex = 9;
      this.txtBNbBarreVerticale.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // txtBNbBarreHorizontale
      // 
      this.txtBNbBarreHorizontale.Enabled = false;
      this.txtBNbBarreHorizontale.Location = new System.Drawing.Point(184, 177);
      this.txtBNbBarreHorizontale.Name = "txtBNbBarreHorizontale";
      this.txtBNbBarreHorizontale.Size = new System.Drawing.Size(175, 20);
      this.txtBNbBarreHorizontale.TabIndex = 10;
      // 
      // txtBNbEnT
      // 
      this.txtBNbEnT.Enabled = false;
      this.txtBNbEnT.Location = new System.Drawing.Point(184, 264);
      this.txtBNbEnT.Name = "txtBNbEnT";
      this.txtBNbEnT.Size = new System.Drawing.Size(175, 20);
      this.txtBNbEnT.TabIndex = 11;
      this.txtBNbEnT.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
      // 
      // txtBNbEnJ
      // 
      this.txtBNbEnJ.Enabled = false;
      this.txtBNbEnJ.Location = new System.Drawing.Point(184, 351);
      this.txtBNbEnJ.Name = "txtBNbEnJ";
      this.txtBNbEnJ.Size = new System.Drawing.Size(175, 20);
      this.txtBNbEnJ.TabIndex = 12;
      // 
      // txtBNbEnL
      // 
      this.txtBNbEnL.Enabled = false;
      this.txtBNbEnL.Location = new System.Drawing.Point(184, 439);
      this.txtBNbEnL.Name = "txtBNbEnL";
      this.txtBNbEnL.Size = new System.Drawing.Size(175, 20);
      this.txtBNbEnL.TabIndex = 13;
      // 
      // txtBNbEnS
      // 
      this.txtBNbEnS.Enabled = false;
      this.txtBNbEnS.Location = new System.Drawing.Point(184, 525);
      this.txtBNbEnS.Name = "txtBNbEnS";
      this.txtBNbEnS.Size = new System.Drawing.Size(175, 20);
      this.txtBNbEnS.TabIndex = 14;
      // 
      // txtBNbEnZ
      // 
      this.txtBNbEnZ.Enabled = false;
      this.txtBNbEnZ.Location = new System.Drawing.Point(184, 612);
      this.txtBNbEnZ.Name = "txtBNbEnZ";
      this.txtBNbEnZ.Size = new System.Drawing.Size(175, 20);
      this.txtBNbEnZ.TabIndex = 15;
      // 
      // lblPointage
      // 
      this.lblPointage.AutoSize = true;
      this.lblPointage.Location = new System.Drawing.Point(546, 0);
      this.lblPointage.Name = "lblPointage";
      this.lblPointage.Size = new System.Drawing.Size(55, 13);
      this.lblPointage.TabIndex = 16;
      this.lblPointage.Text = "Pointage :";
      this.lblPointage.Click += new System.EventHandler(this.lblPointage_Click);
      // 
      // lblTempsEcoule
      // 
      this.lblTempsEcoule.AutoSize = true;
      this.lblTempsEcoule.Location = new System.Drawing.Point(546, 348);
      this.lblTempsEcoule.Name = "lblTempsEcoule";
      this.lblTempsEcoule.Size = new System.Drawing.Size(35, 13);
      this.lblTempsEcoule.TabIndex = 17;
      this.lblTempsEcoule.Text = "label1";
      // 
      // frmFinDePartie
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(920, 725);
      this.Controls.Add(this.tLPStatistiqueFinDePartie);
      this.Name = "frmFinDePartie";
      this.Text = "Statistiques fin de partie";
      this.Load += new System.EventHandler(this.frmFinDePartie_Load);
      this.tLPStatistiqueFinDePartie.ResumeLayout(false);
      this.tLPStatistiqueFinDePartie.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label lblPieceBloc;
    private System.Windows.Forms.TableLayoutPanel tLPStatistiqueFinDePartie;
    private System.Windows.Forms.Label lblBarreVerticale;
    private System.Windows.Forms.Label lblBarreHorizontale;
    private System.Windows.Forms.Label lblEnFormeDeT;
    private System.Windows.Forms.Label lblEnJ;
    private System.Windows.Forms.Label lblEnL;
    private System.Windows.Forms.Label lblEnS;
    private System.Windows.Forms.Label lblEnZ;
    private System.Windows.Forms.TextBox txtBNbBloc;
    private System.Windows.Forms.TextBox txtBNbBarreVerticale;
    private System.Windows.Forms.TextBox txtBNbEnJ;
    private System.Windows.Forms.TextBox txtBNbEnT;
    private System.Windows.Forms.TextBox txtBNbBarreHorizontale;
    private System.Windows.Forms.TextBox txtBNbEnL;
    private System.Windows.Forms.TextBox txtBNbEnS;
    private System.Windows.Forms.TextBox txtBNbEnZ;
    private System.Windows.Forms.Label lblPointage;
    private System.Windows.Forms.Label lblTempsEcoule;
  }
}