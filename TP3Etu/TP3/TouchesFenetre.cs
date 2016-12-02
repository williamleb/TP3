// <WLebel>
using System.Windows.Forms;
using System;

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
    // Touche pour tourner la pièce de façon antihoraire. Par défaut: 'e'.
    public char toucheRotationAntihoraire = 'e';
    // Touche pour faire tomber la pièce. Par défaut: barre espace.
    public char toucheTomber = (char)32;

    //Constantes qui détermine les touches par défaut.
    // Touche pour déplacer la pièce à gauche. Par défaut: 'a'.
    const char TOUCHE_GAUCHE_DEFAUT = 'a';
    // Touche pour descendre la pièce d'une case. Par défaut: 's'.
    const char TOUCHE_BAS_DEFAUT = 's';
    // Touche pour déplacer la pièce à droite. Par défaut: 'd'.
    const char TOUCHE_DROITE_DEFAUT = 'd';
    // Touche pour tourner la pièce de façon horaire. Par défaut: 'q'.
    const char TOUCHE_HORAIRE_DEFAUT = 'q';
    // Touche pour tourner la pièce de façon antihoraire. Par défaut: 'e'.
    const char TOUCHE_ANTIHORAIRE_DEFAUT = 'e';
    // Touche pour faire tomber la pièce. Par défaut: barre espace.
    const char TOUCHE_TOMBER_DEFAUT = (char)32;

    #endregion

    /// <summary>
    /// Méthode appelée au chargement du formulaire qui affiche les touches
    /// courantes au joueur.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnLoadTouchesFenetre(object sender, System.EventArgs e)
    {
      AfficherToutesLesTouches();
    }

    /// <summary>
    /// Méthode qui affiche toutes les touches courantes au joueur
    /// dans les différents boutons.
    /// </summary>
    void AfficherToutesLesTouches()
    {
      // Gauche.
      btnGauche.Text = "";
      // Si c'est une lettre, on la met en majuscule.
      if (Char.IsLetter(toucheDeplacerGauche))
      {
        btnGauche.Text += Char.ToUpper(toucheDeplacerGauche);
      }
      // Si c'est un caractère spécial, on l'écrit.
      else
      {
        // Shift.
        if (toucheDeplacerGauche == (char)14 || toucheDeplacerGauche == (char)14)
        {
          btnGauche.Text += "SHIFT";
        }
        // Barre espace.
        if (toucheDeplacerGauche == (char)32)
        {
          btnGauche.Text += "SPACE";
        }
      }

      // Bas.
      btnBas.Text = "";
      // Si c'est une lettre, on la met en majuscule.
      if (Char.IsLetter(toucheDeplacerBas))
      {
        btnBas.Text += Char.ToUpper(toucheDeplacerBas);
      }
      // Si c'est un caractère spécial, on l'écrit.
      else
      {
        // Shift.
        if (toucheDeplacerBas == (char)14 || toucheDeplacerBas == (char)14)
        {
          btnBas.Text += "SHIFT";
        }
        // Barre espace.
        if (toucheDeplacerBas == (char)32)
        {
          btnBas.Text += "SPACE";
        }
      }

      // Droite.
      btnDroite.Text = "";
      // Si c'est une lettre, on la met en majuscule.
      if (Char.IsLetter(toucheDeplacerDroite))
      {
        btnDroite.Text += Char.ToUpper(toucheDeplacerDroite);
      }
      // Si c'est un caractère spécial, on l'écrit.
      else
      {
        // Shift.
        if (toucheDeplacerDroite == (char)14 || toucheDeplacerDroite == (char)14)
        {
          btnDroite.Text += "SHIFT";
        }
        // Barre espace.
        if (toucheDeplacerDroite == (char)32)
        {
          btnDroite.Text += "SPACE";
        }
      }

      // Horaire.
      btnHoraire.Text = "";
      // Si c'est une lettre, on la met en majuscule.
      if (Char.IsLetter(toucheRotationHoraire))
      {
        btnHoraire.Text += Char.ToUpper(toucheRotationHoraire);
      }
      // Si c'est un caractère spécial, on l'écrit.
      else
      {
        // Shift.
        if (toucheRotationHoraire == (char)14 || toucheRotationHoraire == (char)14)
        {
          btnHoraire.Text += "SHIFT";
        }
        // Barre espace.
        if (toucheRotationHoraire == (char)32)
        {
          btnHoraire.Text += "SPACE";
        }
      }

      // Antihoraire.
      btnAntihoraire.Text = "";
      // Si c'est une lettre, on la met en majuscule.
      if (Char.IsLetter(toucheRotationAntihoraire))
      {
        btnAntihoraire.Text += Char.ToUpper(toucheRotationAntihoraire);
      }
      // Si c'est un caractère spécial, on l'écrit.
      else
      {
        // Shift.
        if (toucheRotationAntihoraire == (char)14 || toucheRotationAntihoraire == (char)14)
        {
          btnAntihoraire.Text += "SHIFT";
        }
        // Barre espace.
        if (toucheRotationAntihoraire == (char)32)
        {
          btnAntihoraire.Text += "SPACE";
        }
      }

      // Tomber.
      btnTomber.Text = "";
      // Si c'est une lettre, on la met en majuscule.
      if (Char.IsLetter(toucheTomber))
      {
        btnTomber.Text += Char.ToUpper(toucheTomber);
      }
      // Si c'est un caractère spécial, on l'écrit.
      else
      {
        // Shift.
        if (toucheTomber == (char)14 || toucheTomber == (char)15)
        {
          btnTomber.Text += "SHIFT";
        }
        // Barre espace.
        if (toucheTomber == (char)32)
        {
          btnTomber.Text += "SPACE";
        }
      }
    }

    /// <summary>
    /// Méthode qui se fait appeler lorsque le joueur clique sur le bouton «btnDefaut».
    /// La méthode réinitialise les touches par défaut et les affiche au joueur.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnClickBtnDefaut(object sender, EventArgs e)
    {
      // Assignation des valeurs par défaut.
      toucheDeplacerGauche = TOUCHE_GAUCHE_DEFAUT;
      toucheDeplacerBas = TOUCHE_BAS_DEFAUT;
      toucheDeplacerDroite = TOUCHE_DROITE_DEFAUT;
      toucheRotationHoraire = TOUCHE_HORAIRE_DEFAUT;
      toucheRotationAntihoraire = TOUCHE_ANTIHORAIRE_DEFAUT;
      toucheTomber = TOUCHE_TOMBER_DEFAUT;

      // Affichage des valeurs.
      AfficherToutesLesTouches();
    }

    /// <summary>
    /// Méthode qui est appelée lorsque le le joueur appuie sur une touche
    /// en sélectionnant le bouton «btnGauche». La métode sauvegarde la nouvelle
    /// touche du joueur pour un déplacement gauche.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnKeyPressBtnGauche(object sender, KeyPressEventArgs e)
    {
      // Si la touche est dans les caractères permis (c'est-à-dire toutes
      // les lettres, la barre espace et les deux shift), on le sauvegarde.
      if (Char.IsLetter(e.KeyChar))
      // les lettres , on le sauvegarde.
      if (Char.IsLetter(e.KeyChar) || e.KeyChar == (char)32 )
      {
        toucheDeplacerGauche = Char.ToLower(e.KeyChar);
      }
      else if (e.KeyChar == (char)32 || e.KeyChar == (char)14 || e.KeyChar == (char)15)
      {
        toucheDeplacerGauche = e.KeyChar;
      }

      // Affiche la nouvelle touche.
      AfficherToutesLesTouches();
    }

    /// <summary>
    /// Méthode qui est appelée lorsque le le joueur appuie sur une touche
    /// en sélectionnant le bouton «btnBas». La métode sauvegarde la nouvelle
    /// touche du joueur pour un déplacement bas.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnKeyPressBtnBas(object sender, KeyPressEventArgs e)
    {
      // Si la touche est dans les caractères permis (c'est-à-dire toutes
      // les lettres, la barre espace et les deux shift), on le sauvegarde.
      if (Char.IsLetter(e.KeyChar))
      {
        toucheDeplacerBas = Char.ToLower(e.KeyChar);
      }
      else if (e.KeyChar == (char)32 || e.KeyChar == (char)14 || e.KeyChar == (char)15)
      {
        toucheDeplacerBas = e.KeyChar;
      }

      // Affiche la nouvelle touche.
      AfficherToutesLesTouches();
    }

    /// <summary>
    /// Méthode qui est appelée lorsque le le joueur appuie sur une touche
    /// en sélectionnant le bouton «btnDroite». La métode sauvegarde la nouvelle
    /// touche du joueur pour un déplacement droite.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnKeyPressBtnDroite(object sender, KeyPressEventArgs e)
    {
      // Si la touche est dans les caractères permis (c'est-à-dire toutes
      // les lettres, la barre espace et les deux shift), on le sauvegarde.
      if (Char.IsLetter(e.KeyChar))
      {
        toucheDeplacerDroite = Char.ToLower(e.KeyChar);
      }
      else if (e.KeyChar == (char)32 || e.KeyChar == (char)14 || e.KeyChar == (char)15)
      {
        toucheDeplacerDroite = e.KeyChar;
      }

      // Affiche la nouvelle touche.
      AfficherToutesLesTouches();
    }

    /// <summary>
    /// Méthode qui est appelée lorsque le le joueur appuie sur une touche
    /// en sélectionnant le bouton «btnHoraire». La métode sauvegarde la nouvelle
    /// touche du joueur pour une rotation horaire.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnKeyPressBtnHoraire(object sender, KeyPressEventArgs e)
    {
      // Si la touche est dans les caractères permis (c'est-à-dire toutes
      // les lettres, la barre espace et les deux shift), on le sauvegarde.
      if (Char.IsLetter(e.KeyChar))
      {
        toucheRotationHoraire = Char.ToLower(e.KeyChar);
      }
      else if (e.KeyChar == (char)32 || e.KeyChar == (char)14 || e.KeyChar == (char)15)
      {
        toucheRotationHoraire = e.KeyChar;
      }

      // Affiche la nouvelle touche.
      AfficherToutesLesTouches();
    }

    /// <summary>
    /// Méthode qui est appelée lorsque le le joueur appuie sur une touche
    /// en sélectionnant le bouton «btnAntihoraire». La métode sauvegarde la nouvelle
    /// touche du joueur pour une rotation antihoraire.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnKeyPressBtnAntihoraire(object sender, KeyPressEventArgs e)
    {
      // Si la touche est dans les caractères permis (c'est-à-dire toutes
      // les lettres, la barre espace et les deux shift), on le sauvegarde.
      if (Char.IsLetter(e.KeyChar))
      {
        toucheRotationAntihoraire = Char.ToLower(e.KeyChar);
      }
      else if (e.KeyChar == (char)32 || e.KeyChar == (char)14 || e.KeyChar == (char)15)
      {
        toucheRotationAntihoraire = e.KeyChar;
      }

      // Affiche la nouvelle touche.
      AfficherToutesLesTouches();
    }

    /// <summary>
    /// Méthode qui est appelée lorsque le le joueur appuie sur une touche
    /// en sélectionnant le bouton «btnTomber». La métode sauvegarde la nouvelle
    /// touche du joueur pour faire tomber la pièce.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnKeyPressBtnTomber(object sender, KeyPressEventArgs e)
    {
      // Si la touche est dans les caractères permis (c'est-à-dire toutes
      // les lettres, la barre espace et les deux shift), on le sauvegarde.
      if (Char.IsLetter(e.KeyChar))
      {
        toucheTomber = Char.ToLower(e.KeyChar);
      }
      else if (e.KeyChar == (char)32 || e.KeyChar == (char)14 || e.KeyChar == (char)15)
      {
        toucheTomber = e.KeyChar;
      }

      // Affiche la nouvelle touche.
      AfficherToutesLesTouches();
    }
  }
}
// </WLebel>