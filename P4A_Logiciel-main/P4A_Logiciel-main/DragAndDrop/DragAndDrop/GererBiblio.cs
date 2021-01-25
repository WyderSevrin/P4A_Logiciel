using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragAndDrop
{
    public partial class GererBiblio : UserControl
    {
        public GererBiblio()
        {
            InitializeComponent();
        }

        private void ButtonModif_Click(object sender, EventArgs e)
        {
            string titre = TBTitre.Text;
            string auteur = TBAuteur.Text;
            string genre = TBGenre.Text;
            string typeOE = CBTypeOE.Text;
            string mouvLitt = CBMouvLitt.Text;


        }
    }
}
