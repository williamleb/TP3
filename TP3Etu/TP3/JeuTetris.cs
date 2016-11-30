using System;
using System.Drawing;
using System.Windows.Forms;
using WMPLib;

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
    bool doitJouerMusique = false;

    // Variable qui sert à jouer la musique.
    WindowsMediaPlayer musique = new WindowsMediaPlayer();

    //Mika Gauthier
    //État du joueur au début
    Mouvement keyUsed = Mouvement.Immobile;


    // Variable qui représente le pointage du joueur pour la partie en cours.
    int pointage = 0;

    //Nombre de pièces utilisées + type de la pièce
    int nbPieceBloc = 0; //couleur jaune
    int nbPieceBarreVerticale = 0; //couleur cyan
    int nbPieceBarreHorizontale = 0; //couleur cyan
    int nbPieceEnT = 0; //couleur mauve
    int nbPieceEnJ = 0; //couleur orange
    int nbPieceEnL = 0; //couleur bleu foncé
    int nbPieceEnS = 0; //couleur rouge
    int nbPieceEnZ = 0; //couleur rose

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

      GenererPieceAleatoire();
      ////// Désactivation du groupbox "Options"
      timerJeu.Enabled = true;
      colonneDeDepart = nbColonnesJeu / 2;
      colonneCourante = colonneDeDepart;
      ligneCourante = 0;
      ActualiserTableauPieces(pieceEnCours);
      AfficherJeu();

      jeuEstEnCours = true;
    }
    // </WLebel>

    // <WLebel>
    /// <summary>
    /// Méthode qui permet d'arrêter l'exécution du jeu et d'afficher le jeu à son état vide.
    /// </summary>
    void ArreterExecutionJeu()
    {
      // Remet les valeurs à leur état initial.
      //////// Activation du groupbox "Options"
      timerJeu.Enabled = false;
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
      //Apporter les modification au formulaire des statistiques de fin de partie
      // Mika Gauthier
      frmFinDePartie finDePartie = new frmFinDePartie();
      finDePartie.AfficherNbPieceGenere(
      nbPieceBloc, nbPieceBarreVerticale,
      nbPieceBarreHorizontale, nbPieceEnT, 
      nbPieceEnJ, nbPieceEnL, 
      nbPieceEnS, nbPieceEnZ
      );
      finDePartie.AfficherPointage(pointage);
      finDePartie.ShowDialog();
      // Mika Gauthier

      pointage = 0;
      jeuEstEnCours = false;
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
      // </WLebel>

      // Demande des nouvelles configurations au joueur.
      ConfigurationFenetre fenetreDeConfiguration = new ConfigurationFenetre();
      fenetreDeConfiguration.nombreDeLignesDansLeJeu = nbLignesJeu;
      fenetreDeConfiguration.nombreDeColonnesDansLeJeu = nbColonnesJeu;
      fenetreDeConfiguration.doitJouerMusique = doitJouerMusique;
      // Trucs pour commandes

      // Prise des choix du joueur si le joueur a cliqué sur « Ok ».
      if (fenetreDeConfiguration.ShowDialog() == DialogResult.OK)
      {
        nbLignesJeu = fenetreDeConfiguration.nombreDeLignesDansLeJeu;
        nbColonnesJeu = fenetreDeConfiguration.nombreDeColonnesDansLeJeu;
        doitJouerMusique = fenetreDeConfiguration.doitJouerMusique;
        //truc pour commandes

        InitialiserValeursJeu(nbLignesJeu, nbColonnesJeu);
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
      if (e.KeyChar == 'a')
      {
        keyUsed = Mouvement.DeplacerGauche;
        DeplacerBloc(tableauPieces);
      }

      //Déplacement vers la droite(d)
      if (e.KeyChar == 'd')
      {
        keyUsed = Mouvement.DeplacerDroite;
        DeplacerBloc(tableauPieces);
      }

      //déplacement vers le bas(s)
      if (e.KeyChar == 's')
      {
        keyUsed = Mouvement.DeplacerBas;
        DeplacerBloc(tableauPieces);
      }

      //Déplacement vers le haut(w)
      if (e.KeyChar == 'w')
      {
        keyUsed = Mouvement.DeplacerHaut;
        DeplacerBloc(tableauPieces);
      }

      //Rotation dans le sens antihoraire(q)
      if (e.KeyChar == 'e')
      {
        keyUsed = Mouvement.RotationAntihoraire;
        DeplacerBloc(tableauPieces);
      }

      //Rotation dans le sens horaire(e)
      if (e.KeyChar == 'q')
      {
        keyUsed = Mouvement.RotationHoraire;
        DeplacerBloc(tableauPieces);
      }
    }
    //Mika Gauhtier

    //Mika Gauthier
    /// <summary>
    /// Cette fonction vérifie si de nouvelles pièces peuvent être générées
    /// au début du jeu sans problème
    /// </summary>
    void VérificationFinPartie()
    {
    for (int i = 0; i<blocActifY.Length;i++)
    {
      if (tableauPieces[VerificationBlocActifY[i],VerificationBlocActifX[i] + colonneDeDepart] == PieceTeris.Gelee)
      {
         jeuEstEnCours = false;
      }
    }

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

      // 1 ligne retirée = 250pts
      // 2 lignes retirées = 500pts
      // 3 lignes retirées = 1000pts
      // 4 lignes retirées = 2000pts
      switch (RetirerLignesCompletees())
      {
        case 1:
          pointage += 250;
          break;
        case 2:
          pointage += 500;
          break;
        case 3:
          pointage += 1000;
          break;
        case 4:
          pointage += 2000;
          break;
      }
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
      if (ligne > 0 && ligne < nbLignesJeu)
      {
        // Pour tous les pièces de la ligne.
        for (int j = 0; j < nbColonnesJeu - 1; j++)
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
      if (ligneDeDepart > 0 && ligneDeDepart < nbLignesJeu)
      {

        // Pour toutes les lignes à partir de la ligne donnée en paramètre (exepté la première ligne du jeu).
        for (int i = ligneDeDepart; i > 1; i--)
        {
          // Pour toutes les cases de la ligne choisie
          for (int j = 0; j < nbColonnesJeu - 1; j++)
          {
            // On prend la valeur de la case correspondante de la ligne du haut.
            tableauPieces[i, j] = tableauPieces[i - 1, j];
          }
        }

        // Pour toutes les cases de la première ligne du jeu.
        for (int j = 0; j < nbColonnesJeu - 1; j++)
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

    #region Tests unitaires
    /// <summary>
    /// Faites ici les appels requis pour vos tests unitaires.
    /// </summary>
    void ExecuterTestsUnitaires()
    {
      ExecuterTestABC();
      // A compléter...
    }

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
