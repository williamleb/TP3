//Mika Gauthier
/*
 * Ce formulaire affiche au joueur toutes les statistiques de la partie en cours
 * Il contient le nombre de chaque pièce utilisée ainsi que son pourcentage d'utilisation
 * Affiche le pointage, le nombre de lignes enlevées, le temps de jeu 
 * ainsi que le niveau du jeu
 * 
 * Auteur: 
 * Mika Gauthier
 */


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

    /// <summary>
    /// Cette fonction affiche le temps de jeu d'une partie à l'écran
    /// </summary>
    /// <param name="tempsDebutPartie"></param>
    /// <param name="tempsDeLaPartie"></param>
    public void AfficherTimer(DateTime tempsDebutPartie, DateTime tempsDeLaPartie)
    {
      TimeSpan tempsEcoule = (tempsDeLaPartie - tempsDebutPartie);
      lblTempsEcoule.Text = tempsEcoule.ToString();
    }


    /// <summary>
    /// Cette fonction affiche et converti en pourcentage le nombre de chaque pièce utilisée au cours
    /// de la partie
    /// </summary>
    /// <param name="nbPieceBloc">entier qui représente le nombre de pièce de type bloc</param>
    /// <param name="nbPieceBarreVerticale">entier qui représente le nombre de pièce de type barre verticale/param>
    /// <param name="nbPieceBarreHorizontale">entier qui représente le nombre de pièce de type horizontale</param>
    /// <param name="nbPieceEnT">entier qui représente le nombre de pièce de type T</param>
    /// <param name="nbPieceEnJ">entier qui représente le nombre de pièce de type J</param>
    /// <param name="nbPieceEnL">entier qui représente le nombre de pièce de type L</param>
    /// <param name="nbPieceEnS">entier qui représente le nombre de pièce de type S</param>
    /// <param name="nbPieceEnZ">entier qui représente le nombre de pièce de type Z</param>
    /// <param name="sommeDesPieces">entier qui représente la somme de toutes les pièces</param>
    public void AfficherNbPieceGenere(
      float nbPieceBloc, float nbPieceBarreVerticale,
      float nbPieceBarreHorizontale, float nbPieceEnT,
      float nbPieceEnJ, float nbPieceEnL,
      float nbPieceEnS, float nbPieceEnZ,
      float sommeDesPieces
      )
    {

      //Modification des textBox pour le nombre de pièces utilisées
      txtBNbBloc.Text = nbPieceBloc.ToString() + "\t Pourcentage : " + (nbPieceBloc / sommeDesPieces).ToString("p");
      txtBNbBarreVerticale.Text = nbPieceBarreVerticale.ToString() + "\t Pourcentage : " + (nbPieceBarreVerticale / sommeDesPieces).ToString("p");
      txtBNbBarreHorizontale.Text = nbPieceBarreHorizontale.ToString() + "\t Pourcentage : " + (nbPieceBarreHorizontale / sommeDesPieces).ToString("p");
      txtBNbEnT.Text = nbPieceEnT.ToString() + "\t Pourcentage : " + (nbPieceEnT/sommeDesPieces).ToString("p");
      txtBNbEnJ.Text = nbPieceEnJ.ToString() + "\t Pourcentage : " + (nbPieceEnJ / sommeDesPieces).ToString("p");
      txtBNbEnL.Text = nbPieceEnL.ToString() + "\t Pourcentage : " + (nbPieceEnL / sommeDesPieces).ToString("p");
      txtBNbEnS.Text = nbPieceEnS.ToString() + "\t Pourcentage : " + (nbPieceEnS / sommeDesPieces).ToString("p");
      txtBNbEnZ.Text = nbPieceEnZ.ToString() + "\t Pourcentage : " + (nbPieceEnZ / sommeDesPieces).ToString("p");
    }

    /// <summary>
    /// Cette fonction affiche le pointage du joueur à l'écran (score, niveau atteint, nombre de lignes enlevées)
    /// </summary>
    /// <param name="pointage"></param>
    public void AfficherPointage(int pointage, int nbLignesCompleteesAuTotal, int niveauDifficluteDe1A9)
    {
      lblPointage.Text += pointage.ToString();
      lblNiveau.Text += niveauDifficluteDe1A9.ToString();
      lblLigneEnlever.Text += nbLignesCompleteesAuTotal.ToString();
    }
  }
}
// Mika Gauthier
