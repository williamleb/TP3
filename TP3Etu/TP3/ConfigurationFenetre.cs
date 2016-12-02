// <WLebel>
using System;
using System.Windows.Forms;

namespace TP3
{
  public partial class ConfigurationFenetre : Form
  {
    public ConfigurationFenetre()
    {
      InitializeComponent();
    }

    #region Variables partagées
    // Représente le nombre de lignes dans le jeu.
    public int nombreDeLignesDansLeJeu = 0;

    // Représente le nombre de colonnes dans le jeu.
    public int nombreDeColonnesDansLeJeu = 0;

    // Détermine si la musique doit être jouée (vrai) ou non (faux).
    public bool doitJouerMusique = false;

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
    public char toucheRotationAntihoraire = 'e';
    // Touche pour faire tomber la pièce. Par défaut: barre espace.
    public char toucheTomber = (char)32;
    #endregion

    /// <summary>
    /// Méthode qui est appelée à l'ouverture du formulaire de configuration.
    /// Elle permet d'initialiser correctement les valeurs du formulaire.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnLoadConfigurationFenetre(object sender, EventArgs e)
    {
      // Ajuste lee maximum et le minimum des trackBars et des numericalupdowns
      // afin de ne pas créer de débordements.
      numNbLignes.Maximum = trackBarNbLignes.Maximum;
      numNbLignes.Minimum = trackBarNbLignes.Minimum;
      numNbColonnes.Maximum = trackBarNbColonnes.Maximum;
      trackBarNbColonnes.Minimum = trackBarNbColonnes.Minimum;

      // Initialise les valeurs dans la fenêtre.
      numNbLignes.Value = nombreDeLignesDansLeJeu;
      trackBarNbLignes.Value = nombreDeLignesDansLeJeu;
      numNbColonnes.Value = nombreDeColonnesDansLeJeu;
      trackBarNbColonnes.Value = nombreDeColonnesDansLeJeu;

      if (doitJouerMusique)
      {
        checkBoxMusique.Checked = true;
      }
    }

    /// <summary>
    /// Méthode qui est appelée lorsque le joueur appuie sur le checkbox « checkBoxMusique ».
    /// Elle permet d'activer la musique ou de la désactiver.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnCheckCheckBoxMusique(object sender, EventArgs e)
    {
      if (checkBoxMusique.Checked == true)
      {
        doitJouerMusique = true;
      }
      else
      {
        doitJouerMusique = false;
      }
    }

    /// <summary>
    /// Méthode qui est appelée lorsque l'utilisateur change le nombre de lignes du jeu à l'aide du numericalupdown correspondant.
    /// Elle permet de changer le nombre de ligne du jeu et d'actualiser son trackbar.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnChangeNumNbLignes(object sender, EventArgs e)
    {
      // Change le nombre de lignes.
      nombreDeLignesDansLeJeu = Decimal.ToInt32(numNbLignes.Value);
      // Actualise la valeur du trackbar correspondant.
      trackBarNbLignes.Value = Decimal.ToInt32(numNbLignes.Value);
    }

    /// <summary>
    /// Méthode qui est appelée lorsque l'utilisateur change le nombre de colonnes du jeu à l'aide du numericalupdown correspondant.
    /// Elle permet de changer le nombre de colonnes du jeu et d'actualiser son trackbar.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnChangeNumNbColonnes(object sender, EventArgs e)
    {
      // Change le nombre de colonnes.
      nombreDeColonnesDansLeJeu = Decimal.ToInt32(numNbColonnes.Value);
      // Actualise la valeur du trackbar correspondant.
      trackBarNbColonnes.Value = Decimal.ToInt32(numNbColonnes.Value);
    }

    /// <summary>
    /// Méthode qui est appelée lorsque l'utilisateur change le nombre de lignes du jeu à l'aide du trackbar correspondant.
    /// Elle permet de changer le nombre de lignes du jeu et d'actualiser son numericalupdown.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnScrollTrackBarNbLignes(object sender, EventArgs e)
    {
      // Change le nombre de lignes.
      nombreDeLignesDansLeJeu = trackBarNbLignes.Value;
      // Actualise la valeur du numericalupdown correspondant.
      numNbLignes.Value = trackBarNbLignes.Value;
    }

    /// <summary>
    /// Méthode qui est appelée lorsque l'utilisateur change le nombre de colonnes du jeu à l'aide du trackbar correspondant.
    /// Elle permet de changer le nombre de colonnes du jeu et d'actualiser son numericalupdown.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnScrollTrackBarNbColonnes(object sender, EventArgs e)
    {
      // Change le nombre de lignes.
      nombreDeColonnesDansLeJeu = trackBarNbColonnes.Value;
      // Actualise la valeur du numericalupdown correspondant.
      numNbColonnes.Value = trackBarNbColonnes.Value;
    }

    /// <summary>
    /// Méthode appelée lorsque le joueur clique sur le bouton «Configurer les touches».
    /// La méthode permet d'ouvrir un nouveau formulaire qui permet au joueur de configurer
    /// ses touches.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnClickBtnConfigurerTouches(object sender, EventArgs e)
    {
      TouchesFenetre configurationTouches = new TouchesFenetre();

      // Assignation des valeurs en cours dans le nouveau formulaire.
      configurationTouches.toucheDeplacerBas = toucheDeplacerBas;
      configurationTouches.toucheDeplacerDroite = toucheDeplacerDroite;
      configurationTouches.toucheDeplacerGauche = toucheDeplacerGauche;
      configurationTouches.toucheRotationAntihoraire = toucheRotationAntihoraire;
      configurationTouches.toucheRotationHoraire = toucheRotationHoraire;
      configurationTouches.toucheTomber = toucheTomber;

      // Si le joueur a valider ses touches on les garde en mémoire.
      if (configurationTouches.ShowDialog() == DialogResult.OK)
      {
        toucheDeplacerBas = configurationTouches.toucheDeplacerBas;
        toucheDeplacerDroite = configurationTouches.toucheDeplacerDroite;
        toucheDeplacerGauche = configurationTouches.toucheDeplacerGauche;
        toucheRotationAntihoraire = configurationTouches.toucheRotationAntihoraire;
        toucheRotationHoraire = configurationTouches.toucheRotationHoraire;
        toucheTomber = configurationTouches.toucheTomber;
      }
    }
  }
}
// </WLebel>