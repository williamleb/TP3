using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3
{
  public partial class frmFinDePartie : Form
  {
    public frmFinDePartie()
    {
      InitializeComponent();
    }

    private void frmFinDePartie_Load(object sender, EventArgs e)
    {

    }

    public void AfficherNbPieceGenere(
      int nbPieceBloc, int nbPieceBarreVerticale,
      int nbPieceBarreHorizontale, int nbPieceEnT,
      int nbPieceEnJ, int nbPieceEnL,
      int nbPieceEnS, int nbPieceEnZ)
    {
      txtBNbBloc.Text = nbPieceBloc.ToString();
      txtBNbBarreVerticale.Text = nbPieceBarreVerticale.ToString();
      txtBNbBarreHorizontale.Text = nbPieceBarreHorizontale.ToString();
      txtBNbEnT.Text = nbPieceEnT.ToString();
      txtBNbEnJ.Text = nbPieceEnJ.ToString();
      txtBNbEnL.Text = nbPieceEnL.ToString();
      txtBNbEnS.Text = nbPieceEnS.ToString();
      txtBNbEnZ.Text = nbPieceEnZ.ToString();
    }

    public void AfficherPointage(int pointage)
    {
      lblPointage.Text += pointage.ToString();
    }


    #region Fonction a ignorer(elle ne fond rien)
    private void tLPStatistiqueFinDePartie_Paint(object sender, PaintEventArgs e)
    {

    }

    private void label1lblFinDePartie_Click(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged_1(object sender, EventArgs e)
    {

    } 

    private void txtBNbBloc_TextChanged(object sender, EventArgs e)
    {

    }

    private void lblPointage_Click(object sender, EventArgs e)
    {

    }
    #endregion


  }
}
