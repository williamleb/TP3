// <WLebel>
using System.Windows.Forms;

namespace TP3
{
  public partial class TouchesFenetre : Form
  {
    public TouchesFenetre()
    {
      InitializeComponent();
    }

    #region Variables partagées
    // Variables qui détermine quelle touche est utilisée pour quelle commande du joueur.
    // Touche pour déplacer la pièce à gauche. Par défaut: 'a'.
    public char toucheDeplacerGauche = 'a';
    // Touche pour descendre la pièce d'une case. Par défaut: 's'.
    public char toucheDeplacerBas = 's';
    // Touche pour déplacer la pièce à droite. Par défaut: 'd'.
    public char toucheDeplacerDroite = 'd';
    // Touche pour tourner la pièce de façon horaire. Par défaut: 'q'.
    public char toucheRotationHoraire = 'q';
    // Touche pour tourner la pièce de façon anti-horaire. Par défaut: 'e'.
    public char toucheRotationAntiHoraire = 'e';
    // Touche pour faire tomber la pièce. Par défaut: barre espace.
    public char toucheTomber = (char)32;
    #endregion


  }
}
// </WLebel>