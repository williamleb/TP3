using System;
using System.Drawing;
using System.Windows.Forms;
using WMPLib;
using System.Diagnostics;

namespace TP3
{
  public partial class JeuTetris : Form
  {
    public JeuTetris()
    {
      InitializeComponent();
    }

    // <WLebel> (et mika gauthier, voir plus bas dans la région Variable partagées)
    #region Variables patagées
    // Représentation visuelles du jeu en mémoire.
    PictureBox[,] toutesImagesVisuelles = null;

    // Nombre de lignes que contient le jeu.
    int nbLignesJeu = 20;

    // Nombre de colonnes que contient le jeu.
    int nbColonnesJeu = 10;

    // Tableau qui représente les pièces dans le tableau du jeu.
    PieceTeris[,] tableauPieces = null;

    // Ligne qui correspond à la position relative des blocs dans le tableau du jeu.
    int ligneCourante = 0;

    // Colonne qui correspond à la position relative des blocs dans le tableau du jeu.
    int colonneCourante = 0;

    // Colonne où les nouveaux blocs apparaissent sur la surface du jeu.
    int colonneDeDepart = 5;

    // Tableau qui représente les positions vertivales relativent des blocs d'une pièce 
    // par rapport aux variables ligneCourante et colonneCourante.
    int[] blocActifY = new int[4];

    // Tableau qui représente les positions horizontales relativent des blocs d'une pièce 
    // par rapport aux variables ligneCourante et colonneCourante.
    int[] blocActifX = new int[4];

    // Type de la pièce qui est jouée.
    PieceTeris pieceEnCours = PieceTeris.Rien;

    // Variable qui sert à choisir une pièce de manière aléatoire.
    Random rnd = new Random();

    // Sert à savoir si le jeu est en cours d'exécution.
    bool jeuEstEnCours = false;

    // Sert à savoir si on doit jouer une musique durant la partie.
    bool doitJouerMusique = true;

    // Variable qui sert à jouer la musique.
    WindowsMediaPlayer musique = new WindowsMediaPlayer();

    // Variable qui représente le pointage du joueur pour la partie en cours.
    int pointage = 0;

    // Indique le niveau de difficulté en cours du jeu. Le niveau de difficulté
    // influence la descente de la pièce ainsi que le pointage obtenu.
    // Le niveau de difficulté peut varier de 1 à 9.
    int niveauDifficluteDe1A9 = 1;

    // Variable qui indique le nombre de ligne complétées total dans une partie.
    int nbLignesCompleteesAuTotal = 0;

    // Variables qui détermine quelle touche est utilisée pour quelle commande du joueur.
    // Touche pour déplacer la pièce à gauche. Par défaut: 'a'.
    char toucheDeplacerGauche = 'a';
    // Touche pour descendre la pièce d'une case. Par défaut: 's'.
    char toucheDeplacerBas = 's';
    // Touche pour déplacer la pièce à droite. Par défaut: 'd'.
    char toucheDeplacerDroite = 'd';
    // Touche pour tourner la pièce de façon horaire. Par défaut: 'q'.
    char toucheRotationHoraire = 'q';
    // Touche pour tourner la pièce de façon anti-horaire. Par défaut: 'e'.
    char toucheRotationAntihoraire = 'e';
    // Touche pour faire tomber la pièce. Par défaut: barre espace.
    char toucheTomber = (char)32;

    //Mika Gauthier
    //État du joueur au début
    Mouvement keyUsed = Mouvement.Immobile;

    //Nombre de pièces utilisées + type de la pièce
    float nbPieceBloc = 0; //couleur jaune
    float nbPieceBarreVerticale = 0; //couleur cyan
    float nbPieceBarreHorizontale = 0; //couleur cyan
    float nbPieceEnT = 0; //couleur mauve
    float nbPieceEnJ = 0; //couleur orange
    float nbPieceEnL = 0; //couleur bleu foncé
    float nbPieceEnS = 0; //couleur rouge
    float nbPieceEnZ = 0; //couleur rose

    float sommeDesPieces = 0; //Somme de toutes les pièces

    // Tableau qui représente les positions vertivales relativent des blocs d'une pièce 
    // par rapport aux variables ligneCourante et colonneCourante. Sert à la sécurité
    // du programme
    int[] VerificationBlocActifY = new int[4];

    // Tableau qui représente les positions horizontales relativent des blocs d'une pièce 
    // par rapport aux variables ligneCourante et colonneCourante. Sert à la sécurité
    // du programme
    int[] VerificationBlocActifX = new int[4];
    //Mika Gauthier
    #endregion
    // </WLebel>

    #region Code fourni

    private void InitialiserSurfaceDeJeu(int nbLignes, int nbCols)
    {
      // Création d'une surface de jeu 10 colonnes x 20 lignes
      toutesImagesVisuelles = new PictureBox[nbLignes, nbCols];
      tableauJeu.Controls.Clear();
      tableauJeu.ColumnCount = toutesImagesVisuelles.GetLength(1);
      tableauJeu.RowCount = toutesImagesVisuelles.GetLength(0);
      for (int i = 0; i < tableauJeu.RowCount; i++)
      {
        tableauJeu.RowStyles[i].Height = tableauJeu.Height / tableauJeu.RowCount;
        for (int j = 0; j < tableauJeu.ColumnCount; j++)
        {
          tableauJeu.ColumnStyles[j].Width = tableauJeu.Width / tableauJeu.ColumnCount;
          // Création dynamique des PictureBox qui contiendront les pièces de jeu
          PictureBox newPictureBox = new PictureBox();
          newPictureBox.Width = tableauJeu.Width / tableauJeu.ColumnCount;
          newPictureBox.Height = tableauJeu.Height / tableauJeu.RowCount;
          newPictureBox.BackColor = Color.Black;
          newPictureBox.Margin = new Padding(0, 0, 0, 0);
          newPictureBox.BorderStyle = BorderStyle.FixedSingle;
          newPictureBox.Dock = DockStyle.Fill;

          // Assignation de la représentation visuelle.
          toutesImagesVisuelles[i, j] = newPictureBox;
          // Ajout dynamique du PictureBox créé dans la grille de mise en forme.
          // A noter que l' "origine" du repère dans le tableau est en haut à gauche.
          tableauJeu.Controls.Add(newPictureBox, j, i);
        }
      }
    }
    #endregion

    #region Code à développer

    // <summary>
    /// Gestionnaire de l'événement se produisant lors du premier affichage 
    /// du formulaire principal.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void frmLoad(object sender, EventArgs e)
    {
      // Ne pas oublier de mettre en place les valeurs nécessaires à une partie.
      ExecuterTestsUnitaires();

      // <WLebel>
      InitialiserValeursJeu(nbLignesJeu, nbColonnesJeu);

      musique.settings.autoStart = false;
      musique.URL = @"Resources/MusiqueTetris.mp3";
      musique.settings.setMode("loop", true);
      // </WLebel>

    }
    
    // <WLebel>
    /// <summary>
    /// Méthode qui initialise le nombre de lignes et de colonnes du jeu, la surface de jeu,
    /// le tableau des pièces du jeu et la position de départ des blocs selon un nouveau
    /// nombre de lignes et de colonnes données.
    /// </summary>
    /// <param name="nouveauNbLignes">Nouveau nombre de lignes qui composeront le jeu.</param>
    /// <param name="nouveauNbColonnes">Nouveau nombre de colonnes qui composeront le jeu.</param>
    void InitialiserValeursJeu(int nouveauNbLignes, int nouveauNbColonnes)
    {
      nbColonnesJeu = nouveauNbColonnes;
      nbLignesJeu = nouveauNbLignes;

      InitialiserSurfaceDeJeu(nbLignesJeu, nbColonnesJeu);

      tableauPieces = new PieceTeris[nbLignesJeu, nbColonnesJeu];
      // Initialise le tableau de pièces à vide.
      for (int i = 0; i < tableauPieces.GetLength(0); i++)
      {
        for (int j = 0; j < tableauPieces.GetLength(1); j++)
        {
          tableauPieces[i, j] = PieceTeris.Rien;
        }
      }

      // Sélectionne la colonne du milieu
      colonneDeDepart = nbColonnesJeu / 2;
    }
    // </WLebel>

    // <WLebel>
    /// <summary>
    /// Méthode qui permet de remplacer les coordonées des pièces courantes avec un autre type de pièce
    /// dans le but d'actualiser la nouvelle position des pièces.
    /// </summary>
    /// <param name="pieceQuiRemplace">Pièce qui sera attribuée aux coordonnées présentes de la pièce.</param>
    void ActualiserTableauPieces(PieceTeris pieceQuiRemplace)
    {
      for (int i = 0; i < blocActifY.Length; i++)
      {
        tableauPieces[blocActifY[i] + ligneCourante, blocActifX[i] + colonneCourante] = pieceQuiRemplace;
      }
    }
    // </WLebel>

    // <WLebel>
    /// <summary>
    /// Affiche le tableau de jeu au joueur en utilisant différentes couleurs pour les différents types de pièce.
    /// </summary>
    void AfficherJeu()
    {
      // Affiche une couleur de fond selon la pièce.
      for (int i = 0; i < tableauPieces.GetLength(0); i++)
      {
        for (int j = 0; j < tableauPieces.GetLength(1); j++)
        {
          if (tableauPieces[i, j] == PieceTeris.Rien)
          {
            toutesImagesVisuelles[i, j].BackColor = Color.Black;
          }
          else if (tableauPieces[i, j] == PieceTeris.Gelee)
          {
            toutesImagesVisuelles[i, j].BackColor = Color.Gray;
          }
          else if (tableauPieces[i, j] == PieceTeris.block)
          {
            toutesImagesVisuelles[i, j].BackColor = Color.Yellow;
          }
          else if (tableauPieces[i, j] == PieceTeris.barreVerticale || tableauPieces[i, j] == PieceTeris.barreHorizontale)
          {
            toutesImagesVisuelles[i, j].BackColor = Color.Cyan;
          }
          else if (tableauPieces[i, j] == PieceTeris.pieceEnT)
          {
            toutesImagesVisuelles[i, j].BackColor = Color.Purple;
          }
          else if (tableauPieces[i, j] == PieceTeris.pieceEnJ)
          {
            toutesImagesVisuelles[i, j].BackColor = Color.Orange;
          }
          else if (tableauPieces[i, j] == PieceTeris.pieceEnL)
          {
            toutesImagesVisuelles[i, j].BackColor = Color.DarkBlue;
          }
          else if (tableauPieces[i, j] == PieceTeris.pieceEnS)
          {
            toutesImagesVisuelles[i, j].BackColor = Color.Red;
          }
          else if (tableauPieces[i, j] == PieceTeris.pieceEnZ)
          {
            toutesImagesVisuelles[i, j].BackColor = Color.Pink;
          }
        }
      }
    }

    #region Méthodes qui gèrent les déplacements des pièces

    // <WLebel>
    /// <summary>
    /// Méthode qui détermine si la pièce active peut bouger dans un certain sens.
    /// La pièce peut bouger si son mouvement n'entraîne pas une sortie du jeu
    /// ou une collision avec une pièce gelée.
    /// </summary>
    /// <param name="sens">Détermine le sens du déplacement à tester.</param>
    /// <returns></returns>
    bool DeterminerSiBlocPeutBouger(Mouvement sens)
    {
      bool peutBouger = true;

      if (sens == Mouvement.DeplacerBas)
      {
        // Pour tous les blocs actifs.
        for (int i = 0; i < blocActifY.Length; i++)
        {
          // Test si le nouvement causera un débordement de tableau (si le mouvement positionne les 
          // blocs en dehors du jeu).
          // Sinon, test si à la nouvelle position se trouve une pièce gelée.
          if (blocActifY[i] + ligneCourante + 1 >= nbLignesJeu)
          {
            peutBouger = false;
          }
          else if (tableauPieces[blocActifY[i] + ligneCourante + 1, blocActifX[i] + colonneCourante] == PieceTeris.Gelee)
          {
            peutBouger = false;
          }
        }
      }
      else if (sens == Mouvement.DeplacerGauche)
      {
        for (int i = 0; i < blocActifY.Length; i++)
        {
          if (blocActifX[i] + colonneCourante - 1 < 0)
          {
            peutBouger = false;
          }
          else if (tableauPieces[blocActifY[i] + ligneCourante, blocActifX[i] + colonneCourante - 1] == PieceTeris.Gelee)
          {
            peutBouger = false;
          }
        }
      }
      else if (sens == Mouvement.DeplacerDroite)
      {
        for (int i = 0; i < blocActifY.Length; i++)
        {
          if (blocActifX[i] + colonneCourante + 1 >= nbColonnesJeu)
          {
            peutBouger = false;
          }
          else if (tableauPieces[blocActifY[i] + ligneCourante, blocActifX[i] + colonneCourante + 1] == PieceTeris.Gelee)
          {
            peutBouger = false;
          }
        }
      }
      else if (sens == Mouvement.RotationAntihoraire)
      {
        for (int i = 0; i < blocActifY.Length; i++)
        {
          if (-blocActifX[i] + ligneCourante < 0 || -blocActifX[i] + ligneCourante >= nbLignesJeu || blocActifY[i] + colonneCourante < 0 || blocActifY[i] + colonneCourante >= nbColonnesJeu)
          {
            peutBouger = false;
          }
          else if (tableauPieces[-blocActifX[i] + ligneCourante, blocActifY[i] + colonneCourante] == PieceTeris.Gelee)
          {
            peutBouger = false;
          }
        }
      }
      else if (sens == Mouvement.RotationHoraire)
      {
        for (int i = 0; i < blocActifY.Length; i++)
        {
          if (blocActifX[i] + ligneCourante < 0 || blocActifX[i] + ligneCourante >= nbLignesJeu || -blocActifY[i] + colonneCourante < 0 || -blocActifY[i] + colonneCourante >= nbColonnesJeu)
          {
            peutBouger = false;
          }
          else if (tableauPieces[blocActifX[i] + ligneCourante, -blocActifY[i] + colonneCourante] == PieceTeris.Gelee)
          {
            peutBouger = false;
          }
        }
      }
      else if (sens == Mouvement.DeplacerHaut) // Seulement à titre de test.
      {
        for (int i = 0; i < blocActifY.Length; i++)
        {
          if (blocActifY[i] + ligneCourante - 1 < 0)
          {
            peutBouger = false;
          }
          else if (tableauPieces[blocActifY[i] + ligneCourante - 1, blocActifX[i] + colonneCourante] == PieceTeris.Gelee)
          {
            peutBouger = false;
          }
        }
      }

      return peutBouger;
    }
    // </WLebel>

    #endregion

    // <WLebel> et Mika Gauthier
    #region Générateurs des différentes pièces.

    /// <summary>
    /// Génère la pièce « Carré ».
    /// </summary>
    void GenererCarre()
    {
      pieceEnCours = PieceTeris.block;

      blocActifY[0] = 0;
      blocActifY[1] = 0;
      blocActifY[2] = 1;
      blocActifY[3] = 1;

      blocActifX[0] = 0;
      blocActifX[1] = 1;
      blocActifX[2] = 0;
      blocActifX[3] = 1;

      //Mesure de sécurité (en cas de bogue)
      for (int i = 0; i < blocActifY.Length;i++)
      {
        VerificationBlocActifY[i] = blocActifY[i];
      }
      for (int j = 0; j < blocActifX.Length; j++)
      {
        VerificationBlocActifX[j] = blocActifX[j];
      }
    }


    /// <summary>
    /// Génère la pièce « Barre horizontale ».
    /// </summary>
    void GenererBarreH()
    {
      pieceEnCours = PieceTeris.barreHorizontale;

      blocActifY[0] = 0;
      blocActifY[1] = 0;
      blocActifY[2] = 0;
      blocActifY[3] = 0;

      blocActifX[0] = 0;
      blocActifX[1] = 1;
      blocActifX[2] = 2;
      blocActifX[3] = 3;

      //Mesure de sécurité (en cas de bogue)
      for (int i = 0; i < blocActifY.Length; i++)
      {
        VerificationBlocActifY[i] = blocActifY[i];
      }
      for (int j = 0; j < blocActifX.Length; j++)
      {
        VerificationBlocActifX[j] = blocActifX[j];
      }
    }


    /// <summary>
    /// Génère la pièce « Barre Verticale».
    /// </summary>
    void GenererBarreV()
    {
      pieceEnCours = PieceTeris.barreVerticale;

      blocActifY[0] = 0;
      blocActifY[1] = 1;
      blocActifY[2] = 2;
      blocActifY[3] = 3;

      blocActifX[0] = 0;
      blocActifX[1] = 0;
      blocActifX[2] = 0;
      blocActifX[3] = 0;

      //Mesure de sécurité (en cas de bogue)
      for (int i = 0; i < blocActifY.Length; i++)
      {
        VerificationBlocActifY[i] = blocActifY[i];
      }
      for (int j = 0; j < blocActifX.Length; j++)
      {
        VerificationBlocActifX[j] = blocActifX[j];
      }
    }

    /// <summary>
    /// Génère la pièce en forme de T.
    /// </summary>
    void GenererT()
    {
      pieceEnCours = PieceTeris.pieceEnT;

      blocActifY[0] = 0;
      blocActifY[1] = 1;
      blocActifY[2] = 1;
      blocActifY[3] = 1;

      blocActifX[0] = 1;
      blocActifX[1] = 0;
      blocActifX[2] = 1;
      blocActifX[3] = 2;

      //Mesure de sécurité (en cas de bogue)
      for (int i = 0; i < blocActifY.Length; i++)
      {
        VerificationBlocActifY[i] = blocActifY[i];
      }
      for (int j = 0; j < blocActifX.Length; j++)
      {
        VerificationBlocActifX[j] = blocActifX[j];
      }
    }

    /// <summary>
    /// Génère la pièce en forme de J.
    /// </summary>
    void GenererJ()
    {
      pieceEnCours = PieceTeris.pieceEnJ;

      blocActifY[0] = 0;
      blocActifY[1] = 1;
      blocActifY[2] = 2;
      blocActifY[3] = 2;

      blocActifX[0] = 1;
      blocActifX[1] = 1;
      blocActifX[2] = 0;
      blocActifX[3] = 1;

      //Mesure de sécurité (en cas de bogue)
      for (int i = 0; i < blocActifY.Length; i++)
      {
        VerificationBlocActifY[i] = blocActifY[i];
      }
      for (int j = 0; j < blocActifX.Length; j++)
      {
        VerificationBlocActifX[j] = blocActifX[j];
      }
    }

    /// <summary>
    /// Génère la pièce en forme de L.
    /// </summary>
    void GenererL()
    {
      pieceEnCours = PieceTeris.pieceEnL;

      blocActifY[0] = 0;
      blocActifY[1] = 1;
      blocActifY[2] = 2;
      blocActifY[3] = 2;

      blocActifX[0] = 0;
      blocActifX[1] = 0;
      blocActifX[2] = 0;
      blocActifX[3] = 1;

      //Mesure de sécurité (en cas de bogue)
      for (int i = 0; i < blocActifY.Length; i++)
      {
        VerificationBlocActifY[i] = blocActifY[i];
      }
      for (int j = 0; j < blocActifX.Length; j++)
      {
        VerificationBlocActifX[j] = blocActifX[j];
      }
    }

    /// <summary>
    /// Génère la pièce en forme de S.
    /// </summary>
    void GenererS()
    {
      pieceEnCours = PieceTeris.pieceEnS;

      blocActifY[0] = 0;
      blocActifY[1] = 1;
      blocActifY[2] = 1;
      blocActifY[3] = 2;

      blocActifX[0] = 0;
      blocActifX[1] = 0;
      blocActifX[2] = 1;
      blocActifX[3] = 1;

      //Mesure de sécurité (en cas de bogue)
      for (int i = 0; i < blocActifY.Length; i++)
      {
        VerificationBlocActifY[i] = blocActifY[i];
      }
      for (int j = 0; j < blocActifX.Length; j++)
      {
        VerificationBlocActifX[j] = blocActifX[j];
      }
    }

    /// <summary>
    /// Génère la pièce en forme de Z.
    /// </summary>
    void GenererZ()
    {
      pieceEnCours = PieceTeris.pieceEnZ;

      blocActifY[0] = 0;
      blocActifY[1] = 1;
      blocActifY[2] = 1;
      blocActifY[3] = 2;

      blocActifX[0] = 1;
      blocActifX[1] = 0;
      blocActifX[2] = 1;
      blocActifX[3] = 0;

      //Mesure de sécurité (en cas de bogue)
      for (int i = 0; i < blocActifY.Length; i++)
      {
        VerificationBlocActifY[i] = blocActifY[i];
      }
      for (int j = 0; j < blocActifX.Length; j++)
      {
        VerificationBlocActifX[j] = blocActifX[j];
      }
    }

    /// <summary>
    /// Supprime toute pièce générée en remplaçant leurs coordonnées par 0.
    /// </summary>
    void ResetPiece()
    {
      pieceEnCours = PieceTeris.Rien;

      blocActifY[0] = 0;
      blocActifY[1] = 0;
      blocActifY[2] = 0;
      blocActifY[3] = 0;

      blocActifX[0] = 0;
      blocActifX[1] = 0;
      blocActifX[2] = 0;
      blocActifX[3] = 0;

      //Mesure de sécurité (en cas de bogue)
      for (int i = 0; i < blocActifY.Length;i++)
      {
        VerificationBlocActifY[i] = blocActifY[i];
      }
      for (int j = 0; j < blocActifX.Length; j++)
      {
        VerificationBlocActifX[j] = blocActifX[j];
      }
    }
    #endregion
    // </WLebel> et Mika Gauthier

    // <WLebel>
    /// <summary>
    /// Méthode appelée lorsque le joueur appuie sur le menu « Jouer ».
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnClickMenuJouer(object sender, EventArgs e)
    {
      // Si le jeu est en cours, on demande au joueur s'il veut vraiment terminer
      // sa partie en cours.
      if (jeuEstEnCours)
      {
        if (DemanderAbandonnerPartie() == true)
        {
          ArreterExecutionJeu();
          CommencerJeu();
        }
      }
      else
      {
        CommencerJeu();
      }
    }
    // </WLebel> et Mika Gauthier

    /// <summary>
    /// Méthode qui est appelé à une certaine intervalle lorsque le jeu est commencé
    /// et qui permet de vérifier si la partie est terminée et, si ce n'est pas le cas, de
    /// descendre ou de geler la pièce en cours selon son état.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnTickTimerJeu(object sender, EventArgs e)
    {
      //Mika Gauthier
      //Vérification si la partie est terminée
      if (jeuEstEnCours == false)
      {
        ArreterExecutionJeu();
      }
      // <WLebel>
      else if (DeterminerSiBlocPeutBouger(Mouvement.DeplacerBas))
      {
        ActualiserTableauPieces(PieceTeris.Rien);
        ligneCourante++;
        ActualiserTableauPieces(pieceEnCours);
        AfficherJeu();
      }
      else
      {
        ActualiserTableauPieces(PieceTeris.Gelee);
        ActualiserPointage();
        AfficherJeu();
        ActualiserNieauDifficulte();
        VérificationFinPartie();
        if (jeuEstEnCours == true)
        {
          GenererPieceAleatoire();
          colonneCourante = colonneDeDepart;
          ligneCourante = 0;
          ActualiserTableauPieces(pieceEnCours);
          AfficherJeu();
        }
        else
        {
          ArreterExecutionJeu();
        }
      }
      // </WLebel> et Mika gauthier
    }

    /// <summary>
    /// Permet de vérifier le niveau de difficulté et de le changer quand c'est nécessaire.
    /// </summary>
    void ActualiserNieauDifficulte()
    {
      int niveauDifficulteEvalue = 1;

      // Le niveau de difficulté est évalué selon les lignes complétées.
      if (nbLignesCompleteesAuTotal > 40)
      {
        niveauDifficulteEvalue = 9;
      }
      else if (nbLignesCompleteesAuTotal > 35)
      {
        niveauDifficulteEvalue = 8;
      }
      else if (nbLignesCompleteesAuTotal > 30)
      {
        niveauDifficulteEvalue = 7;
      }
      else if (nbLignesCompleteesAuTotal > 25)
      {
        niveauDifficulteEvalue = 6;
      }
      else if (nbLignesCompleteesAuTotal > 20)
      {
        niveauDifficulteEvalue = 5;
      }
      else if (nbLignesCompleteesAuTotal > 15)
      {
        niveauDifficulteEvalue = 4;
      }
      else if (nbLignesCompleteesAuTotal > 10)
      {
        niveauDifficulteEvalue = 3;
      }
      else if (nbLignesCompleteesAuTotal > 5)
      {
        niveauDifficulteEvalue = 2;
      }

      // Si le niveau de difficulté a changé, on traite le nouveau niveau de difficulté
      // et on l'affiche au joueur.
      if (niveauDifficulteEvalue != niveauDifficluteDe1A9)
      {
        TraiterNouveauNiveauDifficulté(niveauDifficulteEvalue);
        AfficherNiveauDansFenetreJeu();
      }
    }

    /// <summary>
    /// Méthode qui permet d'initialiser un nouveau niveau de difficulté ainsi que de changer
    /// la rapidité de descente de la pièce selon ce niveau de difficulté.
    /// </summary>
    /// <param name="nouveauNiveauDifficulte">Le nouveau niveau de difficulté.</param>
    void TraiterNouveauNiveauDifficulté(int nouveauNiveauDifficulte)
    {
      // On détermine le nouveau niveau de difficulté.
      niveauDifficluteDe1A9 = nouveauNiveauDifficulte;

      // On change ensuite la rapidité de la pièce selon le niveau de difficulté.
      switch (niveauDifficluteDe1A9)
      {
        case 9:
          timerJeu.Interval = 100;
          break;
        case 8:
          timerJeu.Interval = 150;
          break;
        case 7:
          timerJeu.Interval = 200;
          break;
        case 6:
          timerJeu.Interval = 250;
          break;
        case 5:
          timerJeu.Interval = 300;
          break;
        case 4:
          timerJeu.Interval = 350;
          break;
        case 3:
          timerJeu.Interval = 400;
          break;
        case 2:
          timerJeu.Interval = 450;
          break;
        default:
          timerJeu.Interval = 500;
          break;
      }
    }

    // <WLebel>
    /// <summary>
    /// Méthode qui permet de commencer le jeu en initialisant les valeurs.
    /// </summary>
    void CommencerJeu()
    {
      // Commence la musique si elle est activée.
      if (doitJouerMusique)
      {
        musique.controls.play();
      }

      // Génère la première pièce.
      GenererPieceAleatoire();

      // Active le timer.
      timerJeu.Enabled = true;
      
      // Détermine la position de départ des pièces.
      colonneDeDepart = nbColonnesJeu / 2;
      colonneCourante = colonneDeDepart;
      ligneCourante = 0;

      // Actualise le tableau des pièces et affiche le jeu.
      ActualiserTableauPieces(pieceEnCours);
      AfficherJeu();

      // Définit que le jeu est en cours.
      jeuEstEnCours = true;

      // Désactive les paramètres.
      numLignes.Enabled = false;
      numColonnes.Enabled = false;
      checkBoxMusique.Enabled = false;
      //btnValider.Enabled = false;
    }
    // </WLebel>

    // <WLebel>
    /// <summary>
    /// Méthode qui permet d'arrêter l'exécution du jeu et d'afficher le jeu à son état vide.
    /// </summary>
    void ArreterExecutionJeu()
    {
      // Arrête le timer.
      timerJeu.Enabled = false;

      // Désactive la pièce.
      ResetPiece();

      // Arrête la musique
      musique.controls.stop();

      // Remet le tableau jeu à son état initial et réaffiche au joueur son état vide.
      for (int i = 0; i < tableauPieces.GetLength(0); i++)
      {
        for (int j = 0; j < tableauPieces.GetLength(1); j++)
        {
          tableauPieces[i, j] = PieceTeris.Rien;
        }
      }
      AfficherJeu();
      
      // Mika Gauthier
      //Apporter les modification au formulaire des statistiques de fin de partie
      sommeDesPieces = nbPieceBarreHorizontale + nbPieceBarreVerticale + nbPieceBloc + nbPieceEnJ + nbPieceEnL + nbPieceEnS + nbPieceEnT + nbPieceEnZ;
      frmFinDePartie finDePartie = new frmFinDePartie();
      finDePartie.AfficherNbPieceGenere(
      nbPieceBloc, nbPieceBarreVerticale,
      nbPieceBarreHorizontale, nbPieceEnT, 
      nbPieceEnJ, nbPieceEnL, 
      nbPieceEnS, nbPieceEnZ,
      sommeDesPieces
      );
      finDePartie.AfficherPointage(pointage);
      finDePartie.ShowDialog();

      //Remise à 0
      RemiseDesValeurInitiales();

      // Mika Gauthier

      AfficherPointageDansFenetreJeu();
      AfficherNiveauDansFenetreJeu();
    }
    // </WLebel>

    // <WLebel> et Mika Gauthier
    /// <summary>
    /// Méthode qui choisit une pièce aléatoirement et la génère.
    /// </summary>
    void GenererPieceAleatoire()
    {
      int pieceAleatoire = rnd.Next(0, 8);

      switch (pieceAleatoire)
      {
        case 0:
          GenererCarre();
          nbPieceBloc++;
          break;
        case 1:
          GenererBarreH();
          nbPieceBarreHorizontale++;
          break;
        case 2:
          GenererBarreV();
          nbPieceBarreVerticale++;
          break;
        case 3:
          GenererT();
          nbPieceEnT++;
          break;
        case 4:
          GenererJ();
          nbPieceEnJ++;
          break;
        case 5:
          GenererL();
          nbPieceEnL++;
          break;
        case 6:
          GenererS();
          nbPieceEnS++;
          break;
        case 7:
          GenererZ();
          nbPieceEnZ++;
          break;
        default:
          ResetPiece();
          break;
      }
    }
    // </WLebel> et Mika Gauthier

    // <WLebel>
    /// <summary>
    /// Pause le jeu et affiche une boîte de message au joueur demandant s'il veut abandonner la partie en cours.
    /// </summary>
    /// <returns>Un booléen qui indique si le joueur veut abandonner (vrai) ou non (faux).</returns>
    bool DemanderAbandonnerPartie()
    {
      bool veutAbandonner = false;

      timerJeu.Enabled = false;

      if (MessageBox.Show("Êtes-vous certain de vouloir abandonner la partie en cours?", "Attention",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
      {
        veutAbandonner = true;
      }

      timerJeu.Enabled = true;

      return veutAbandonner;
    }
    // </WLebel>

    // <WLebel>
    /// <summary>
    /// Métode appelée lorsque le joueur clique sur le menu « Configuration ». 
    /// La méthode affiche une fenêtre de configuration qui permet au joueur
    /// de configurer le jeu.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnClickMenuConfiguration(object sender, EventArgs e)
    {
      // Si le jeu est en cours, on demande au joueur s'il veut abandonner sa partie.
      if (jeuEstEnCours)
      {
        if (DemanderAbandonnerPartie() == true)
        {
          ArreterExecutionJeu();
        }
      }

      ConfigurationFenetre fenetreDeConfiguration = new ConfigurationFenetre();
      // Affectation des valeurs en cours dans le nouveau formulaire.
      fenetreDeConfiguration.nombreDeLignesDansLeJeu = nbLignesJeu;
      fenetreDeConfiguration.nombreDeColonnesDansLeJeu = nbColonnesJeu;
      fenetreDeConfiguration.doitJouerMusique = doitJouerMusique;
      fenetreDeConfiguration.toucheDeplacerBas = toucheDeplacerBas;
      fenetreDeConfiguration.toucheDeplacerDroite = toucheDeplacerDroite;
      fenetreDeConfiguration.toucheDeplacerGauche = toucheDeplacerGauche;
      fenetreDeConfiguration.toucheRotationAntihoraire = toucheRotationAntihoraire;
      fenetreDeConfiguration.toucheRotationHoraire = toucheRotationHoraire;
      fenetreDeConfiguration.toucheTomber = toucheTomber;

      // Prise des choix du joueur si le joueur a cliqué sur « Ok ».
      if (fenetreDeConfiguration.ShowDialog() == DialogResult.OK)
      {
        nbLignesJeu = fenetreDeConfiguration.nombreDeLignesDansLeJeu;
        nbColonnesJeu = fenetreDeConfiguration.nombreDeColonnesDansLeJeu;
        doitJouerMusique = fenetreDeConfiguration.doitJouerMusique;
        toucheDeplacerBas = fenetreDeConfiguration.toucheDeplacerBas;
        toucheDeplacerDroite = fenetreDeConfiguration.toucheDeplacerDroite;
        toucheDeplacerGauche = fenetreDeConfiguration.toucheDeplacerGauche;
        toucheRotationAntihoraire = fenetreDeConfiguration.toucheRotationAntihoraire;
        toucheRotationHoraire = fenetreDeConfiguration.toucheRotationHoraire;
        toucheTomber = fenetreDeConfiguration.toucheTomber;

        // Initialise et affiche les changements.
        InitialiserValeursJeu(nbLignesJeu, nbColonnesJeu);
        AfficherTouchesDansFenetreJeu();
      }

    }
    // </WLebel>

    //<WLebel>
    /// <summary>
    /// Affiche le pointage donnée par la variable partagée «pointage» au joueur pendant la partie.
    /// </summary>
    void AfficherPointageDansFenetreJeu()
    {
      lblPointage.Text = "Pointage : " + pointage;
    }
    // </WLebel>

    // <WLebel>
    /// <summary>
    /// Affiche le nibeau de difficulté donné par la variable «niveauDifficulteDe1A9» 
    /// au joueur pendant la partie.
    /// </summary>
    void AfficherNiveauDansFenetreJeu()
    {
      lblNiveau.Text = "Niveau : " + niveauDifficluteDe1A9;
    }
    // </WLebel>

    // <WLebel>
    /// <summary>
    /// Méthode qui affiche les touches au joueurs dans le «layoutControles» selon
    /// les touches qui se trouvent dans la variable partagée.
    /// </summary>
    void AfficherTouchesDansFenetreJeu()
    {
      // Gauche.
      lblGauche.Text = "Gauche : ";
      // Si c'est une lettre, on la met en majuscule.
      if (Char.IsLetter(toucheDeplacerGauche))
      {
        lblGauche.Text += Char.ToUpper(toucheDeplacerGauche);
      }
      // Si c'est un caractère spécial, on l'écrit.
      else
      {
        // Shift.
        if (toucheDeplacerGauche == (char)14 || toucheDeplacerGauche == (char)14)
        {
          lblGauche.Text += "SHIFT";
        }
        // Barre espace.
        if (toucheDeplacerGauche == (char)32)
        {
          lblGauche.Text += "SPACE";
        }
      }

      // Bas.
      lblBas.Text = "Bas : ";
      // Si c'est une lettre, on la met en majuscule.
      if (Char.IsLetter(toucheDeplacerBas))
      {
        lblBas.Text += Char.ToUpper(toucheDeplacerBas);
      }
      // Si c'est un caractère spécial, on l'écrit.
      else
      {
        // Shift.
        if (toucheDeplacerBas == (char)14 || toucheDeplacerBas == (char)14)
        {
          lblBas.Text += "SHIFT";
        }
        // Barre espace.
        if (toucheDeplacerBas == (char)32)
        {
          lblBas.Text += "SPACE";
        }
      }

      // Droite.
      lblDroite.Text = "Droite : ";
      // Si c'est une lettre, on la met en majuscule.
      if (Char.IsLetter(toucheDeplacerDroite))
      {
        lblDroite.Text += Char.ToUpper(toucheDeplacerDroite);
      }
      // Si c'est un caractère spécial, on l'écrit.
      else
      {
        // Shift.
        if (toucheDeplacerDroite == (char)14 || toucheDeplacerDroite == (char)14)
        {
          lblDroite.Text += "SHIFT";
        }
        // Barre espace.
        if (toucheDeplacerDroite == (char)32)
        {
          lblDroite.Text += "SPACE";
        }
      }

      // Horaire.
      lblHoraire.Text = "Horaire : ";
      // Si c'est une lettre, on la met en majuscule.
      if (Char.IsLetter(toucheRotationHoraire))
      {
        lblHoraire.Text += Char.ToUpper(toucheRotationHoraire);
      }
      // Si c'est un caractère spécial, on l'écrit.
      else
      {
        // Shift.
        if (toucheRotationHoraire == (char)14 || toucheRotationHoraire == (char)14)
        {
          lblHoraire.Text += "SHIFT";
        }
        // Barre espace.
        if (toucheRotationHoraire == (char)32)
        {
          lblHoraire.Text += "SPACE";
        }
      }

      // Antihoraire.
      lblAntihoraire.Text = "Antihoraire : ";
      // Si c'est une lettre, on la met en majuscule.
      if (Char.IsLetter(toucheRotationAntihoraire))
      {
        lblAntihoraire.Text += Char.ToUpper(toucheRotationAntihoraire);
      }
      // Si c'est un caractère spécial, on l'écrit.
      else
      {
        // Shift.
        if (toucheRotationAntihoraire == (char)14 || toucheRotationAntihoraire == (char)14)
        {
          lblAntihoraire.Text += "SHIFT";
        }
        // Barre espace.
        if (toucheRotationAntihoraire == (char)32)
        {
          lblAntihoraire.Text += "SPACE";
        }
      }

      // Tomber.
      lblTomber.Text = "Tomber : ";
      // Si c'est une lettre, on la met en majuscule.
      if (Char.IsLetter(toucheTomber))
      {
        lblTomber.Text += Char.ToUpper(toucheTomber);
      }
      // Si c'est un caractère spécial, on l'écrit.
      else
      {
        // Shift.
        if (toucheTomber == (char)14 || toucheTomber == (char)14)
        {
          lblTomber.Text += "SHIFT";
        }
        // Barre espace.
        if (toucheTomber == (char)32)
        {
          lblTomber.Text += "SPACE";
        }
      }

    }
    // </WLebel>

    // <WLebel>
    /// <summary>
    /// Méthode appelée lorsque le joueur clique sur le menu « Quitter ».
    /// La métode quite le jeu.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void menuQuitter_Click(object sender, EventArgs e)
    {
      if (jeuEstEnCours)
      {
        if (DemanderAbandonnerPartie() == true)
        {
          ArreterExecutionJeu();
          Application.Exit();
        }
      }
      else
      {
        Application.Exit();
      }
    }
    // </WLebel>
 

    //Mika Gauthier
    /// <summary>
    /// Cette fonction déplace le bloc courant selon les volontées du joueur
    /// </summary>
    /// <param name="tableauPieces">tableau 2D de PieceTeris contenant toutes les pièce qui sont en jeu</param>
    void DeplacerBloc(PieceTeris[,] tableauPieces)
    {
      //Déplace le bloc vers la gauche si le joueur appuie sur la lettre a
      if (keyUsed == Mouvement.DeplacerGauche)
      {
        //Vérification si le déplacement est possible
        if (DeterminerSiBlocPeutBouger(Mouvement.DeplacerGauche))
        {
          //Actualisation + affichage du tableau 
          ActualiserTableauPieces(PieceTeris.Rien);
          colonneCourante--;
          ActualiserTableauPieces(pieceEnCours);
          AfficherJeu();
        }

      }
      //Déplace le bloc vers la droite si le joueur appuie sur la lettre d
      if (keyUsed == Mouvement.DeplacerDroite)
      {
        //Vérification si le déplacement est possible
        if (DeterminerSiBlocPeutBouger(Mouvement.DeplacerDroite))
        {
          //Actualisation + affichage du tableau 
          ActualiserTableauPieces(PieceTeris.Rien);
          colonneCourante++;
          ActualiserTableauPieces(pieceEnCours);
          AfficherJeu();
        }
      }
      //Déplace le bloc vers le bas si le joueur appuie sur la lettre s
      if (keyUsed == Mouvement.DeplacerBas)
      {
        //Vérification si le déplacement est possible
        if (DeterminerSiBlocPeutBouger(Mouvement.DeplacerBas))
        {
          //Actualisation + affichage du tableau 
          ActualiserTableauPieces(PieceTeris.Rien);
          ligneCourante++;
          ActualiserTableauPieces(pieceEnCours);
          AfficherJeu();
        }
      }
      //easter egg
      //Déplace le bloc vers le haut si le joueur appuie sur la lettre w
      if (keyUsed == Mouvement.DeplacerHaut)
      {
        //Vérification si le déplacement est possible
        if (DeterminerSiBlocPeutBouger(Mouvement.DeplacerHaut))
        {
          //Actualisation + affichage du tableau 
          ActualiserTableauPieces(PieceTeris.Rien);
          ligneCourante--;
          ActualiserTableauPieces(pieceEnCours);
          AfficherJeu();
        }
      }
      //Rotation du bloc dans le sens horaire si le joueur appuie sur la lettre e
      if (keyUsed == Mouvement.RotationHoraire)
      {
        //Vérification si le déplacement est possible
        if (DeterminerSiBlocPeutBouger(Mouvement.RotationHoraire))
        {
          //Actualisation + affichage du tableau 
          ActualiserTableauPieces(PieceTeris.Rien);
          int[] tableauTemporaire = new int[blocActifY.Length];
          for (int i = 0; i < blocActifY.Length; i++)
          {
            tableauTemporaire[i] = blocActifY[i];
            blocActifY[i] = blocActifX[i];
          }
          for (int j = 0; j < blocActifX.Length; j++)
          {
            blocActifX[j] = -tableauTemporaire[j];
          }
          ActualiserTableauPieces(pieceEnCours);
          AfficherJeu();
        }
      }
      //Rotation du bloc dans le sens Antihoraire si le joueur appuie sur la lettre q
      if (keyUsed == Mouvement.RotationAntihoraire)
      {
        //Vérification si le déplacement est possible
        if (DeterminerSiBlocPeutBouger(Mouvement.RotationAntihoraire))
        {
          //Actualisation + affichage du tableau 
          ActualiserTableauPieces(PieceTeris.Rien);
          int[] tableauTemporaire = new int[blocActifY.Length];
          for (int i = 0; i < blocActifY.Length; i++)
          {
            tableauTemporaire[i] = blocActifY[i];
            blocActifY[i] = -blocActifX[i];
          }
          for (int j = 0; j < blocActifX.Length; j++)
          {
            blocActifX[j] = tableauTemporaire[j];
          }
          ActualiserTableauPieces(pieceEnCours);
          AfficherJeu();
        }
      }
      // <WLebel>
      if (keyUsed == Mouvement.Tomber)
      {
        // Tant que le déplacement vers le bas est possible.
        while (DeterminerSiBlocPeutBouger(Mouvement.DeplacerBas))
        {
          // Actualise et affiche le tableau.
          ActualiserTableauPieces(PieceTeris.Rien);
          ligneCourante++;
          ActualiserTableauPieces(pieceEnCours);
          AfficherJeu();
        }

      }
      // </WLebel>
    }

    /// <summary>
    /// Cette fonction détermine si le joueur appuie sur l'une des touches du jeu,
    /// il permet aussi le déplacement de la pièce si l'une des touches (a,s,d,w,e,q)
    /// est choisie
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void JeuTetris_KeyPress(object sender, KeyPressEventArgs e)
    {
      //Déplacement du joueur selon la touche choisie(a,s,d,w,e,q)
      //Déplacement vers la gauche(a)
      if (e.KeyChar == toucheDeplacerGauche)
      {
        keyUsed = Mouvement.DeplacerGauche;
        DeplacerBloc(tableauPieces);
      }

      //Déplacement vers la droite(d)
      if (e.KeyChar == toucheDeplacerDroite)
      {
        keyUsed = Mouvement.DeplacerDroite;
        DeplacerBloc(tableauPieces);
      }

      //déplacement vers le bas(s)
      if (e.KeyChar == toucheDeplacerBas)
      {
        keyUsed = Mouvement.DeplacerBas;
        DeplacerBloc(tableauPieces);
      }

      /*
      easter egg
      //Déplacement vers le haut(w)
      if (e.KeyChar == 'w')
      {
        keyUsed = Mouvement.DeplacerHaut;
        DeplacerBloc(tableauPieces);
      }
      */

      //Rotation dans le sens antihoraire(q)
      if (e.KeyChar == toucheRotationAntihoraire)
      {
        keyUsed = Mouvement.RotationAntihoraire;
        DeplacerBloc(tableauPieces);
      }

      //Rotation dans le sens horaire(e)
      if (e.KeyChar == toucheRotationHoraire)
      {
        keyUsed = Mouvement.RotationHoraire;
        DeplacerBloc(tableauPieces);
      }
      // <WLebel>
      // Si le joueur appuie sur la barre espace, la pièce tombe.
      if (e.KeyChar == toucheTomber)
      {
        keyUsed = Mouvement.Tomber;
        DeplacerBloc(tableauPieces);
      }
      // </WLebel>
      
    }
    //Mika Gauhtier

    //Mika Gauthier
    /// <summary>
    /// Cette fonction vérifie si de nouvelles pièces peuvent être générées
    /// au début du jeu sans problème
    /// </summary>
    void VérificationFinPartie()
    {
      for (int i = 0; i < blocActifY.Length; i++)
      {
        if (tableauPieces[VerificationBlocActifY[i], VerificationBlocActifX[i] + colonneDeDepart] == PieceTeris.Gelee)
        {
          jeuEstEnCours = false;
       
        }
      }
    }

    /// <summary>
    /// 
    /// </summary>
    void RemiseDesValeurInitiales()
    {
      // Remise à niveau des statistiques
      pointage = 0;
      TraiterNouveauNiveauDifficulté(1);
      nbLignesCompletesAuTotal = 0;
      jeuEstEnCours = false;

      nbPieceBloc = 0; //couleur jaune
      nbPieceBarreVerticale = 0; //couleur cyan
      nbPieceBarreHorizontale = 0; //couleur cyan
      nbPieceEnT = 0; //couleur mauve
      nbPieceEnJ = 0; //couleur orange
      nbPieceEnL = 0; //couleur bleu foncé
      nbPieceEnS = 0; //couleur rouge
      nbPieceEnZ = 0; //couleur rose
      sommeDesPieces = 0; //Somme de toutes les pièces

      // Active les paramètres.
      numLignes.Enabled = true;
      numColonnes.Enabled = true;
      checkBoxMusique.Enabled = true;
      btnValider.Enabled = true;
    }

  //Mika Gauthier

  // <WLebel>
  #region Métodes qui permettent de gérer les lignes complétées
  /// <summary>
  /// Méthode qui vérifie si des lignes dans le jeu sont complétés et les retire si c'est le cas.
  /// Actualise le pointage en conséquent.
  /// </summary>
  void ActualiserPointage()
    {

      // Valeurs de base.
      // 1 ligne retirée = 250pts
      // 2 lignes retirées = 500pts
      // 3 lignes retirées = 1000pts
      // 4 lignes retirées = 2000pts
      int pointageAAjouter = 0;
      switch (RetirerLignesCompletees())
      {
        case 1:
          pointageAAjouter = 250;
          break;
        case 2:
          pointageAAjouter = 500;
          break;
        case 3:
          pointageAAjouter = 1000;
          break;
        case 4:
          pointageAAjouter = 2000;
          break;
      }

      // Le pointage est ensuite multiplié par le niveau de difficulté en cours du jeu.
      pointageAAjouter *= niveauDifficluteDe1A9;

      // On ajoute le pointage.
      pointage += pointageAAjouter;

      // On affiche le pointage au joueur.
      AfficherPointageDansFenetreJeu();
    }

    /// <summary>
    /// Méthode qui supprime toutes les lignes de jeu qui ont été entièrement complétées en 
    /// décalant les autres lignes en conséquent et compte le nombre de lignes qui ont été supprimées.
    /// </summary>
    /// <returns>Correspond au nombre de lignes complétées qui ont été retirées.</returns>
    int RetirerLignesCompletees()
    {
      int nbLignesCompletees = 0;

      // Pour toutes les lignes du jeu.
      for (int i = 0; i < nbLignesJeu; i++)
      {
        // Si la ligne est complète.
        if (VerifierSiEstUneLigneComplete(i))
        {
          // On la supprime et on décale les autres lignes.
          DecalerLignes(i);
          // On incrémente le nombre de lignes complétées.
          nbLignesCompletees++;
        }
      }

      nbLignesCompleteesAuTotal += nbLignesCompletees;
      return nbLignesCompletees;
    }

    /// <summary>
    /// Méthode qui vérifie si la ligne située à l'index passé en paramètre est une ligne complète.
    /// </summary>
    /// <param name="ligne">L'index de la ligne dans le tableau «tableauPieces» à laquelle sera vérifier
    /// si la ligne est complète.</param>
    /// <returns>Vrai si la ligne est complète, faux sinon.</returns>
    bool VerifierSiEstUneLigneComplete(int ligne)
    {
      bool estUneLigneComplete = true;

      // Si l'index de a ligne donné en paramètre est valide.
      if (ligne >= 0 && ligne < nbLignesJeu)
      {
        // Pour tous les pièces de la ligne.
        for (int j = 0; j < nbColonnesJeu; j++)
        {
          // Si la case est vide, c'est que ce n'est pas une ligne complète.
          if (tableauPieces[ligne, j] == PieceTeris.Rien)
          {
            estUneLigneComplete = false;
          }
        }
      }

      return estUneLigneComplete;
    }

    /// <summary>
    /// Méthode qui retire une ligne de jeu et qui décale les lignes qui sont plus hautes 
    /// que la ligne retirée vers le bas, remplaçant la première ligne du jeu par une ligne vide.
    /// </summary>
    /// <param name="ligneDeDepart">Représente l’index de la ligne dans le tableau «tableauPieces» à partir de
    /// laquelle commencer le décalage, c’est-à-dire la ligne à supprimer.</param>
    void DecalerLignes(int ligneDeDepart)
    {
      // Si l'index de la ligne donné en paramètre est valide.
      if (ligneDeDepart >= 0 && ligneDeDepart < nbLignesJeu)
      {

        // Pour toutes les lignes à partir de la ligne donnée en paramètre (exepté la première ligne du jeu).
        for (int i = ligneDeDepart; i > 1; i--)
        {
          // Pour toutes les cases de la ligne choisie
          for (int j = 0; j < nbColonnesJeu; j++)
          {
            // On prend la valeur de la case correspondante de la ligne du haut.
            tableauPieces[i, j] = tableauPieces[i - 1, j];
          }
        }

        // Pour toutes les cases de la première ligne du jeu.
        for (int j = 0; j < nbColonnesJeu; j++)
        {
          // On vide la case.
          tableauPieces[0, j] = PieceTeris.Rien;
        }
      }
    }    
    
    //Mika Gauthier
    /// <summary>
    /// Fonction appelée par le joueur pour redémarer le jeu
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void menuReinitialiser_Click(object sender, EventArgs e)
    {
      if (DemanderAbandonnerPartie() == true)
      {
        ArreterExecutionJeu();
        AfficherJeu();
      }
    }
    //Mika Gauhtier

    #endregion
    // </WLebel>

    // <WLebel>
    /// <summary>
    /// Méthode qui est appelée lorsque le joueur clique sur le bouton «Valider» et qui permet
    /// d'appliquer les changements faits dans la section «Paramètres» du jeu au jeu.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnMouseClickBtnValider(object sender, MouseEventArgs e)
    {

      // Si le jeu n'est pas en cours.
      if (!jeuEstEnCours)
      {
        // Appliquer le choix de nombres de lignes et de colonnes.
        nbLignesJeu = Decimal.ToInt32(numLignes.Value);
        nbColonnesJeu = Decimal.ToInt32(numColonnes.Value);

        // Appliquer le choix de jouer la musique ou non.
        if (checkBoxMusique.Checked == true)
        {
          doitJouerMusique = true;
        }
        else
        {
          doitJouerMusique = false;
        }

        InitialiserValeursJeu(nbLignesJeu, nbColonnesJeu);
      }
    
    }
    // </WLebel>

    #region Tests unitaires
    /// <summary>
    /// Faites ici les appels requis pour vos tests unitaires.
    /// </summary>
    void ExecuterTestsUnitaires()
    {
      TesterRetirerLignesCompletees();
      ExecuterTestABC();
      // A compléter...
    }

    // <WLebel>
    #region Test de la méthode RetirerLignesCompletees
    /// <summary>
    /// Méthode qui teste plusieurs cas de la méthode RetirerLignesCompletees.
    /// </summary>
    void TesterRetirerLignesCompletees()
    {
      // Effectuer les tests.
      TesterRetraitUneLigneSeule();
      TesterDecalage();
      TesterRetraitDeuxLignesConsecutives();
      TesterRetraitDeuxLignesDistantes();
      TesterRetraitTroisLignes();
      TesterRetraitQuatreLignes();

      // Clean-up global.
      pointage = 0;
      niveauDifficluteDe1A9 = 1;
      nbLignesCompleteesAuTotal = 0;
      nbPieceBloc = 0;
      nbPieceBarreVerticale = 0;
      nbPieceBarreHorizontale = 0;
      nbPieceEnT = 0;
      nbPieceEnJ = 0;
      nbPieceEnL = 0;
      nbPieceEnS = 0;
      nbPieceEnZ = 0;

    }

    /// <summary>
    /// Teste le retrait d'une seule ligne.
    /// </summary>
    void TesterRetraitUneLigneSeule()
    {
      // Mise en place des données du test
      InitialiserValeursJeu(nbLignesJeu, nbColonnesJeu);
      for (int j = 0; j < nbColonnesJeu; j++)
      {
        tableauPieces[0, j] = PieceTeris.Gelee;
      }

      // Exécuter de la méthode à tester
      int nbLignesCompletes = RetirerLignesCompletees();

      // Validation des résultats
      Debug.Assert(nbLignesCompletes == 1, "Le nombre de lignes complétées ne correspond pas.");
      for (int i = 0; i < tableauPieces.GetLength(0); i++)
      {
        for (int j = 0; j < tableauPieces.GetLength(1); j++)
        {
          Debug.Assert(tableauPieces[i, j] == PieceTeris.Rien, "Une ligne n'a pas été retirée correctement.");
        }
      }

      // Clean-up
      for (int i = 0; i < tableauPieces.GetLength(0); i++)
      {
        for (int j = 0; j < tableauPieces.GetLength(1); j++)
        {
          tableauPieces[i, j] = PieceTeris.Rien;
        }
      }
    }

    /// <summary>
    /// Teste le retrait d'une ligne avec décalage.
    /// </summary>
    void TesterDecalage()
    {
      // Mise en place des données du test
      InitialiserValeursJeu(nbLignesJeu, nbColonnesJeu);
      for (int j = 0; j < nbColonnesJeu; j++)
      {
        tableauPieces[nbLignesJeu - 1, j] = PieceTeris.Gelee;
      }
      tableauPieces[nbLignesJeu - 2, 0] = PieceTeris.Gelee;
      tableauPieces[nbLignesJeu - 2, nbColonnesJeu - 1] = PieceTeris.Gelee;
      tableauPieces[nbLignesJeu - 3, 0] = PieceTeris.Gelee;
      tableauPieces[nbLignesJeu - 3, nbColonnesJeu - 1] = PieceTeris.Gelee;

      // Exécuter de la méthode à tester
      int nbLignesCompletes = RetirerLignesCompletees();

      // Validation des résultats
      Debug.Assert(nbLignesCompletes == 1, "Le nombre de lignes complétées ne correspond pas.");
      Debug.Assert(tableauPieces[nbLignesJeu - 1, 0] == PieceTeris.Gelee, "Le décalage ne s'effectue pas correctement");
      Debug.Assert(tableauPieces[nbLignesJeu - 1, nbColonnesJeu - 1] == PieceTeris.Gelee, "Le décalage ne s'effectue pas correctement");
      Debug.Assert(tableauPieces[nbLignesJeu - 2, 0] == PieceTeris.Gelee, "Le décalage ne s'effectue pas correctement");
      Debug.Assert(tableauPieces[nbLignesJeu - 2, nbColonnesJeu - 1] == PieceTeris.Gelee, "Le décalage ne s'effectue pas correctement");
      for (int i = 0; i < tableauPieces.GetLength(0); i++)
      {
        for (int j = 0; j < tableauPieces.GetLength(1); j++)
        {
          if (!(i == nbLignesJeu - 1 || i == nbLignesJeu - 2) && (j == 0 || j == nbColonnesJeu - 1 ))
          {
            Debug.Assert(tableauPieces[i, j] == PieceTeris.Rien, "Une ligne n'a pas été retirée correctement.");
          }
        }
      }
      // Clean-up
      for (int i = 0; i < tableauPieces.GetLength(0); i++)
      {
        for (int j = 0; j < tableauPieces.GetLength(1); j++)
        {
          tableauPieces[i, j] = PieceTeris.Rien;
        }
      }
    }

    /// <summary>
    /// Teste le retrait de deux lignes consécutives.
    /// </summary>
    void TesterRetraitDeuxLignesConsecutives()
    {
      // Mise en place des données du test
      InitialiserValeursJeu(nbLignesJeu, nbColonnesJeu);
      for (int j = 0; j < nbColonnesJeu; j++)
      {
        tableauPieces[nbLignesJeu - 1, j] = PieceTeris.Gelee;
        tableauPieces[nbLignesJeu - 2, j] = PieceTeris.Gelee;
      }

      // Exécuter de la méthode à tester
      int nbLignesCompletes = RetirerLignesCompletees();

      // Validation des résultats
      Debug.Assert(nbLignesCompletes == 2, "Le nombre de lignes complétées ne correspond pas.");
      for (int i = 0; i < tableauPieces.GetLength(0); i++)
      {
        for (int j = 0; j < tableauPieces.GetLength(1); j++)
        {
          Debug.Assert(tableauPieces[i, j] == PieceTeris.Rien, "Une ligne n'a pas été retirée correctement.");
        }
      }

      // Clean-up
      for (int i = 0; i < tableauPieces.GetLength(0); i++)
      {
        for (int j = 0; j < tableauPieces.GetLength(1); j++)
        {
          tableauPieces[i, j] = PieceTeris.Rien;
        }
      }
    }

    /// <summary>
    /// Teste le retrait de deux lignes non consécutives.
    /// </summary>
    void TesterRetraitDeuxLignesDistantes()
    {
      // Mise en place des données du test
      InitialiserValeursJeu(nbLignesJeu, nbColonnesJeu);
      for (int j = 0; j < nbColonnesJeu; j++)
      {
        tableauPieces[nbLignesJeu - 1, j] = PieceTeris.Gelee;
        tableauPieces[nbLignesJeu - 4, j] = PieceTeris.Gelee;
      }

      // Exécuter de la méthode à tester
      int nbLignesCompletes = RetirerLignesCompletees();

      // Validation des résultats
      Debug.Assert(nbLignesCompletes == 2, "Le nombre de lignes complétées ne correspond pas.");
      for (int i = 0; i < tableauPieces.GetLength(0); i++)
      {
        for (int j = 0; j < tableauPieces.GetLength(1); j++)
        {
          Debug.Assert(tableauPieces[i, j] == PieceTeris.Rien, "Une ligne n'a pas été retirée correctement.");
        }
      }

      // Clean-up
      for (int i = 0; i < tableauPieces.GetLength(0); i++)
      {
        for (int j = 0; j < tableauPieces.GetLength(1); j++)
        {
          tableauPieces[i, j] = PieceTeris.Rien;
        }
      }
    }

    /// <summary>
    /// Teste le retrait de trois lignes.
    /// </summary>
    void TesterRetraitTroisLignes()
    {
      // Mise en place des données du test
      InitialiserValeursJeu(nbLignesJeu, nbColonnesJeu);
      for (int j = 0; j < nbColonnesJeu; j++)
      {
        tableauPieces[nbLignesJeu - 1, j] = PieceTeris.Gelee;
        tableauPieces[nbLignesJeu - 2, j] = PieceTeris.Gelee;
        tableauPieces[nbLignesJeu - 3, j] = PieceTeris.Gelee;
      }

      // Exécuter de la méthode à tester
      int nbLignesCompletes = RetirerLignesCompletees();

      // Validation des résultats
      Debug.Assert(nbLignesCompletes == 3, "Le nombre de lignes complétées ne correspond pas.");
      for (int i = 0; i < tableauPieces.GetLength(0); i++)
      {
        for (int j = 0; j < tableauPieces.GetLength(1); j++)
        {
          Debug.Assert(tableauPieces[i, j] == PieceTeris.Rien, "Une ligne n'a pas été retirée correctement.");
        }
      }

      // Clean-up
      for (int i = 0; i < tableauPieces.GetLength(0); i++)
      {
        for (int j = 0; j < tableauPieces.GetLength(1); j++)
        {
          tableauPieces[i, j] = PieceTeris.Rien;
        }
      }
    }

    /// <summary>
    /// Teste le retrait de quatre lignes.
    /// </summary>
    void TesterRetraitQuatreLignes()
    {
      // Mise en place des données du test
      InitialiserValeursJeu(nbLignesJeu, nbColonnesJeu);
      for (int j = 0; j < nbColonnesJeu; j++)
      {
        tableauPieces[nbLignesJeu - 1, j] = PieceTeris.Gelee;
        tableauPieces[nbLignesJeu - 2, j] = PieceTeris.Gelee;
        tableauPieces[nbLignesJeu - 3, j] = PieceTeris.Gelee;
        tableauPieces[nbLignesJeu - 4, j] = PieceTeris.Gelee;
      }

      // Exécuter de la méthode à tester
      int nbLignesCompletes = RetirerLignesCompletees();

      // Validation des résultats
      Debug.Assert(nbLignesCompletes == 4, "Le nombre de lignes complétées ne correspond pas.");
      for (int i = 0; i < tableauPieces.GetLength(0); i++)
      {
        for (int j = 0; j < tableauPieces.GetLength(1); j++)
        {
          Debug.Assert(tableauPieces[i, j] == PieceTeris.Rien, "Une ligne n'a pas été retirée correctement.");
        }
      }

      // Clean-up
      for (int i = 0; i < tableauPieces.GetLength(0); i++)
      {
        for (int j = 0; j < tableauPieces.GetLength(1); j++)
        {
          tableauPieces[i, j] = PieceTeris.Rien;
        }
      }
    }
    #endregion
    // </WLebel>

    // A renommer et commenter!
    void ExecuterTestABC()
    {
      // Mise en place des données du test

      // Exécuter de la méthode à tester

      // Validation des résultats

      // Clean-up
    }


    #endregion

    #endregion


  }
}   
