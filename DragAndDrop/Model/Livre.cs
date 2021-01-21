using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Livre
    {
        private string nom;
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        private string auteur;
        public string Auteur
        {
            get { return auteur; }
            set { auteur = value; }
        }

        private string typeOE;
        public string TypeOE
        {
            get { return typeOE; }
            set { typeOE = value; }
        }
        private string mouvLitt;
        public string MouvLitt
        {
            get { return mouvLitt; }
            set { mouvLitt = value; }
        }


        public Livre(string nom, string auteur, string typeOE, string mouvLitt)
        {
            this.nom = nom;
            this.auteur = auteur;
            this.typeOE = typeOE;
            this.mouvLitt = mouvLitt;
            Console.WriteLine("Livre " + nom + " a été ajouté.");
        }

        ~Livre()
        {
            Console.WriteLine("Objet détruit.");
        }

        public void envoiBDD(string nom,string auteur, string typeOE, string mouvLitt)
        {
            // requete SQL
        }

    }
}
