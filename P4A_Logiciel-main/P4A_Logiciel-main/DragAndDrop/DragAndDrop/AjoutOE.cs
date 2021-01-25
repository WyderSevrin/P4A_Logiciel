//using 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace DragAndDrop
{
    public partial class AjoutOE : UserControl
    {
        public AjoutOE()
        {
            InitializeComponent();
        }

        private void TBAuteur_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonValide_Click(object sender, EventArgs e)
        {

            string titre = TBTitre.Text;
            string auteur = TBAuteur.Text;
            string genre = TBGenre.Text;
            string typeOE = CBTypeOE.Text;
            string mouvLitt = CBMouvLitt.Text;

            // Li

            Console.WriteLine("auteur : " + auteur + " genre : " + genre);
            Console.WriteLine("mouvement littéraire : " + mouvLitt);
            Console.WriteLine("Type d'oeuvre : " + typeOE);
        }

        private void PanelDD_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AjoutOE_Load(object sender, EventArgs e)
        {

        }

        private void PanelDD_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void PanelDD_DragDrop(object sender, DragEventArgs e)
        {
            // Socke les items dans un tableau
            string[] droppedFile = (string[])e.Data.GetData(DataFormats.FileDrop);

            // Afficher le nom du livre
            foreach(string file in droppedFile)
            {
                // Remplir automatiquement le titre avec le nom du fichier
                TBTitre.Text = getBookName(file);
                MessageBox.Show(TBTitre.Text + " a été ajouté ");
            }
                
        }

        private string getBookName(string path)
        {
            return Path.GetFileNameWithoutExtension(path);
        }
    }
}
