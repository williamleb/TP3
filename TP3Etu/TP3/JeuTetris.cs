using System;
using System.Drawing;
using System.Windows.Forms;

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
      InitialiserValeursJeu(20, 10);
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

    /// <WLebel>
    /// <summary>
    /// Méthode appelée lorsque le joueur appuie sur le menu « Jouer ».
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    /// </WLebel>
    private void OnClickMenuJouer(object sender, EventArgs e)
    {
      // Toutes ces instructions sont pour des tests. Si tu veux essayer d'autres pièces, t'as qu'à changer la méthode de génération de pièce.
      GenererCarre(); // Ça sera généré aléatoirement (et aussi ça sera pas juste fait une fois au début du jeu), mais c'est un test. (c'est dans ma partie)
      colonneDeDepart = nbColonnesJeu / 2;
      colonneCourante = colonneDeDepart;
      ligneCourante = 0;
      ActualiserTableauPieces(pieceEnCours);
      AfficherJeu();
      timerJeu.Enabled = true;
    }

    /// <summary>
    /// Méthode qui [à ompléter]
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnTickTimerJeu(object sender, EventArgs e)
    {
      // Avant ça doit tester si c'est la fin de la partie (c'est dans ta partie)
      /*else*/if (DeterminerSiBlocPeutBouger(Mouvement.DeplacerBas))
      {
        ActualiserTableauPieces(PieceTeris.Rien);
        ligneCourante++;
        ActualiserTableauPieces(pieceEnCours);
        AfficherJeu();
      }
      else
      {
        // Changer les pièces en pièces gelées (c'est dans ma partie)
      }
    }
  }








}
