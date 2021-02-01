﻿//using 

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
            // Met les informations des Text Box dans des chaines de caractère 
            // afin de pouvoir les envoyer dans la base de données
            string titre = TBTitre.Text;
            string auteur = TBAuteur.Text;
            string genre = TBGenre.Text;
            string typeOE = CBTypeOE.Text;
            string mouvLitt = CBMouvLitt.Text;


            // Vérifier si un livre a bien été déposé avec toutes les informations nécéssaires
            if (TBTitre.Text != "")
            {
                if (RemplirChamps())
                {
                    // S'affiche dans la console, pour les tests
                    Console.WriteLine("titre : " + titre);
                    Console.WriteLine("auteur : " + auteur + " genre : " + genre);
                    Console.WriteLine("mouvement littéraire : " + mouvLitt);
                    Console.WriteLine("Type d'oeuvre : " + typeOE);

                    MessageBox.Show(TBTitre.Text + " a été ajouté dans la base de données.");

                    // Vide automatiquement les Text Box. Cela évite à l'utilisateur de 
                    // le faire par lui même et empêche d'entrer deux fois le même livre
                    // par inattention
                    TBTitre.Text = "";
                    TBAuteur.Text = "";
                    TBGenre.Text = "";
                    CBTypeOE.Text = "";
                    CBMouvLitt.Text = "";
                }

            }
            else
            {
                MessageBox.Show("Veuillez déposer un livre.");
            }
            
        }

        private bool RemplirChamps()
        {
            // Vérifie si tous les champs ont bien été entrés
            bool verif = true;
            if (TBAuteur.Text == "")
            {
                MessageBox.Show("Veuillez renseigner l'auteur.");
                TBAuteur.Focus();
                verif = false;
            }
            if (TBGenre.Text == "" && verif)
            {
                MessageBox.Show("Veuillez renseigner le genre.");
                TBGenre.Focus();
                verif = false;
            }
            if (CBTypeOE.Text == "" && verif)
            {
                MessageBox.Show("Veuillez renseigner un type.");
                CBTypeOE.Focus();
                verif = false;
            }
            if (CBMouvLitt.Text == "" && verif)
            {
                MessageBox.Show("Veuillez renseigner le mouvement.");
                CBMouvLitt.Focus();
                verif = false;
            }

            return verif;
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
                // Rempli automatiquement le titre avec le nom du fichier
                TBTitre.Text = getBookName(file);
                MessageBox.Show(TBTitre.Text + " a été ajouté ");
            }
                
        }

        private string getBookName(string path)
        {
            // Obtient le nom du du fichier afin de pouvoir renseigner automatiquement
            // le titre de l'oeuvre
            return Path.GetFileNameWithoutExtension(path);
        }
    }
}
