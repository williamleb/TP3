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

    public void AfficherTimer(DateTime tempsDebutPartie, DateTime tempsDeLaPartie)
    {
      TimeSpan tempsEcoule = (tempsDeLaPartie - tempsDebutPartie);
      lblTempsEcoule.Text = tempsEcoule.ToString();
    }



    public void AfficherNbPieceGenere(
      float nbPieceBloc, float nbPieceBarreVerticale,
      float nbPieceBarreHorizontale, float nbPieceEnT,
      float nbPieceEnJ, float nbPieceEnL,
      float nbPieceEnS, float nbPieceEnZ,
      float sommeDesPieces
      )
    {
      txtBNbBloc.Text = nbPieceBloc.ToString() + "\t Pourcentage : " + (nbPieceBloc / sommeDesPieces).ToString("p");
      txtBNbBarreVerticale.Text = nbPieceBarreVerticale.ToString() + "\t Pourcentage : " + (nbPieceBarreVerticale / sommeDesPieces).ToString("p");
      txtBNbBarreHorizontale.Text = nbPieceBarreHorizontale.ToString() + "\t Pourcentage : " + (nbPieceBarreHorizontale / sommeDesPieces).ToString("p");
      txtBNbEnT.Text = nbPieceEnT.ToString() + "\t Pourcentage : " + (nbPieceEnT/sommeDesPieces).ToString("p");
      txtBNbEnJ.Text = nbPieceEnJ.ToString() + "\t Pourcentage : " + (nbPieceEnJ / sommeDesPieces).ToString("p");
      txtBNbEnL.Text = nbPieceEnL.ToString() + "\t Pourcentage : " + (nbPieceEnL / sommeDesPieces).ToString("p");
      txtBNbEnS.Text = nbPieceEnS.ToString() + "\t Pourcentage : " + (nbPieceEnS / sommeDesPieces).ToString("p");
      txtBNbEnZ.Text = nbPieceEnZ.ToString() + "\t Pourcentage : " + (nbPieceEnZ / sommeDesPieces).ToString("p");
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
