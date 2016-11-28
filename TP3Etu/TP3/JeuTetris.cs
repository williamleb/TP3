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

    // <WLebel>
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
    //Déplacement du joueur au début
    Mouvement keyUsed = Mouvement.Immobile;
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

    // <WLebel>
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
    }

    /// <summary>
    /// Génère la pièce « Barre ».
    /// </summary>
    void GenererBarre()
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
    }
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
    // </WLebel>

    /// <summary>
    /// Méthode qui est appelé à une certaine intervalle lorsque le jeu est commencé
    /// et qui permet de vérifier si la partie est terminéeet et, si ce n'est pas le cas, de
    /// descendre ou de geler la pièce en cours selon son état.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnTickTimerJeu(object sender, EventArgs e)
    {
      // Avant ça doit tester si c'est la fin de la partie (c'est dans ta partie)
      // <WLebel>
      /*else*/if (DeterminerSiBlocPeutBouger(Mouvement.DeplacerBas))
      {
        ActualiserTableauPieces(PieceTeris.Rien);
        ligneCourante++;
        ActualiserTableauPieces(pieceEnCours);
        AfficherJeu();
      }
      else
      {
        ActualiserTableauPieces(PieceTeris.Gelee);
        AfficherJeu();
        GenererPieceAleatoire();
        colonneCourante = colonneDeDepart;
        ligneCourante = 0;
        ActualiserTableauPieces(pieceEnCours);
        AfficherJeu();
      }
      // </WLebel>
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

      jeuEstEnCours = false;
    }
    // </WLebel>

    // <WLebel>
    /// <summary>
    /// Méthode qui choisit une pièce aléatoirement et la génère.
    /// </summary>
    void GenererPieceAleatoire()
    {
      int pieceAleatoire = rnd.Next(0, 7);

      switch (pieceAleatoire)
      {
        case 0:
          GenererCarre();
          break;
        case 1:
          GenererBarre();
          break;
        case 2:
          GenererT();
          break;
        case 3:
          GenererJ();
          break;
        case 4:
          GenererL();
          break;
        case 5:
          GenererS();
          break;
        case 6:
          GenererZ();
          break;
        default:
          ResetPiece();
          break;
      }
    }
    // </WLebel>

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

      // Demande des nouvelles configurations au joueur.
      ConfigurationFenetre fenetreDeConfiguration = new ConfigurationFenetre();
      fenetreDeConfiguration.nombreDeLignesDansLeJeu = nbLignesJeu;
      fenetreDeConfiguration.nombreDeColonnesDansLeJeu = nbColonnesJeu;
      fenetreDeConfiguration.doitJouerMusique = doitJouerMusique;
      // Trucs pour commandes
      fenetreDeConfiguration.ShowDialog();

      // Prise des choix du joueur.
      nbLignesJeu = fenetreDeConfiguration.nombreDeLignesDansLeJeu;
      nbColonnesJeu = fenetreDeConfiguration.nombreDeColonnesDansLeJeu;
      doitJouerMusique = fenetreDeConfiguration.doitJouerMusique;
      //truc pour commandes

      InitialiserValeursJeu(nbLignesJeu, nbColonnesJeu);

    }
    // </WLebel>

    private void menuQuitter_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }
 
    //Mika Gauthier
    void DeplacerBloc(PieceTeris[,] tableauPieces)
    {
      if (keyUsed == Mouvement.DeplacerGauche)
      {
        if (DeterminerSiBlocPeutBouger(Mouvement.DeplacerGauche))
        {
          ActualiserTableauPieces(PieceTeris.Rien);
          colonneCourante--;
          ActualiserTableauPieces(pieceEnCours);
          AfficherJeu();
        }

      }
      if (keyUsed == Mouvement.DeplacerDroite)
      {
        if (DeterminerSiBlocPeutBouger(Mouvement.DeplacerDroite))
        {
          ActualiserTableauPieces(PieceTeris.Rien);
          colonneCourante++;
          ActualiserTableauPieces(pieceEnCours);
          AfficherJeu();
        }
      }
      if (keyUsed == Mouvement.DeplacerBas)
      {
        if (DeterminerSiBlocPeutBouger(Mouvement.DeplacerBas))
        {
          ActualiserTableauPieces(PieceTeris.Rien);
          ligneCourante++;
          ActualiserTableauPieces(pieceEnCours);
          AfficherJeu();
        }
      }
      if (keyUsed == Mouvement.DeplacerHaut)
      {
        if (DeterminerSiBlocPeutBouger(Mouvement.DeplacerHaut))
        {
          ActualiserTableauPieces(PieceTeris.Rien);
          ligneCourante--;
          ActualiserTableauPieces(pieceEnCours);
          AfficherJeu();
        }
      }
      if (keyUsed == Mouvement.RotationHoraire)
      {
        if (DeterminerSiBlocPeutBouger(Mouvement.RotationHoraire))
        {
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
      if (keyUsed == Mouvement.RotationAntihoraire)
      {
        if (DeterminerSiBlocPeutBouger(Mouvement.RotationAntihoraire))
        {
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

    private void JeuTetris_KeyPress(object sender, KeyPressEventArgs e)
    {
      /// <summary>
      /// Fonction qui détermine si le joueur a appuyé sur une touche ou non
      /// </summary>

      //Déplacement vers la gauche
      if (e.KeyChar == 'a')
      {
        keyUsed = Mouvement.DeplacerGauche;
        DeplacerBloc(tableauPieces);
      }

      //Déplacement vers la droite
      if (e.KeyChar == 'd')
      {
        keyUsed = Mouvement.DeplacerDroite;
        DeplacerBloc(tableauPieces);
      }

      //déplacement vers le bas
      if (e.KeyChar == 's')
      {
        keyUsed = Mouvement.DeplacerBas;
        DeplacerBloc(tableauPieces);
      }

      //Déplacement vers le haut
      if (e.KeyChar == 'w')
      {
        keyUsed = Mouvement.DeplacerHaut;
        DeplacerBloc(tableauPieces);
      }

      //Rotation dans le sens antihoraire
      if (e.KeyChar == 'e')
      {
        keyUsed = Mouvement.RotationAntihoraire;
        DeplacerBloc(tableauPieces);
      }

      //Rotation dans le sens horaire
      if (e.KeyChar == 'q')
      {
        keyUsed = Mouvement.RotationHoraire;
        DeplacerBloc(tableauPieces);
      }
    }
    //Mika Gauhtier
  }
}   
