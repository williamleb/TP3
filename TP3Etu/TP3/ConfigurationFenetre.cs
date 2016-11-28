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
  public partial class ConfigurationFenetre : Form
  {
    public ConfigurationFenetre()
    {
      InitializeComponent();
    }

    // Représente le nombre de lignes dans le jeu.
    public int nombreDeLignesDansLeJeu = 0;

    // Représente le nombre de colonnes dans le jeu.
    public int nombreDeColonnesDansLeJeu = 0;

    // Détermine si la musique doit être jouée (vrai) ou non (faux).
    public bool doitJouerMusique = false;

    private void OnLoadConfigurationFenetre(object sender, EventArgs e)
    {
      
      if (doitJouerMusique)
      {
        checkBoxMusique.Checked = true;
      }
    }

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

    //Commandes

  }
}
