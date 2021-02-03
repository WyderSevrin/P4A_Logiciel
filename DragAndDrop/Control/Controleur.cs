using Communication;
using Modeles;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Control
{
    public class Controleur
    {
        private SQL sqlManager;
        private FTP ftpManager;
        private Fabrique fabrique;
        //private SQL_constante;
        private List<Livre> bibliotheque;
        public List<Commentaire> commentaires;

        //private Utilisateur utilisateur { get; set; }

        public Controleur()
        {
            init();
           // updateListLivre();
            
        }

        private void init()
        {
            this.ftpManager = new FTP();
            this.sqlManager = new SQL();
            this.fabrique = new Fabrique();

            this.bibliotheque = new List<Livre>();
            this.commentaires = new List<Commentaire>();
        }


        public void ajouterLivreBDD(string Nom, string Genre, string Text, string Resumer, string Nb_Pages, string Mouvement, string Auteur)
        {
            this.sqlManager.SqlINSERT_Livre(Nom, Genre, Text, Resumer, Nb_Pages, Mouvement, Auteur);
        }


        public async Task ajouterLivreFTPAsync(string path)
        {
             //ftpManager.upload_Async(path);
            await ftpManager.upload_Async(path);

        }





















        /// <summary>
        /// Permet d'obtenir tout les livres de la librairie
        /// </summary>
        public void updateListLivre()
        {
            
            List<List<string>> liste = sqlManager.SqlRequest(SQL_constants.selectAllBooks);
           
            this.bibliotheque = fabrique.CreateLivres(liste);
            
            Console.WriteLine("\n \n ===============    Test  Controleur  ================");
            foreach (Livre l in this.bibliotheque)
            {
                Console.WriteLine("Livre n° " + l.id + " Nom : " + l.titre);
            }
        }

        /// <summary>
        /// Permet d'obtenir tout les commentaires
        /// </summary>
        public void updateListCommentaire()
        {
            List<List<string>> liste = sqlManager.SqlRequest(SQL_constants.selectAllComments);
            Console.WriteLine(" \n n /// Liste des commentaire --> " + liste.Count);
            this.commentaires = fabrique.CreateCommentaires(liste);
        }

        public void updateListCommentaireById(String id)
        {
            List<List<string>> liste = sqlManager.SqlRequest(SQL_constants.selectCommentaireByIdLivre + id);

            Console.WriteLine(" \n n /// Liste des commentaire --> " + liste.Count);
            this.commentaires = fabrique.CreateCommentaires(liste);
        }

        /// <summary>
        /// on obtient tous les commentaires d'un livre
        /// </summary>
        /// <param name="idBook"></param>
        /// <returns></returns>
        public List<Commentaire> getCommentaireOfBook(int idBook)
        {
            List<Commentaire> output = new List<Commentaire>();
            foreach (Commentaire c in this.commentaires)
            {
                if (c.idLivre== idBook)
                {
                    output.Add(c);
                }
            }
            return output;
        }

        /// <summary>
        /// IMPLEMENTER 4AUTERU DANS LIVRE
        /// </summary>
        /// <param name="nom"></param>
        /// <returns></returns>
        public List<Livre> searchLivreByNom(string nom)
        {
            List<Livre> result = new List<Livre>();
            foreach (Livre l in this.bibliotheque)
            {
                if (l.titre == nom)
                {
                    result.Add(l);
                }

            }
            
            return result;
        }

        public List<Livre> searchLivreByGenre(string genre)
        {
            List<Livre> result = new List<Livre>();
            foreach (Livre l in this.bibliotheque)
            {
                if (l.genre == genre)
                {
                    result.Add(l);
                }

            }

            return result;
        }

        public List<Livre> searchLivreByMouvement(string mouv)
        {
            List<Livre> result = new List<Livre>();
            foreach (Livre l in this.bibliotheque)
            {
                if (l.mouvement == mouv)
                {
                    result.Add(l);
                }

            }

            return result;
        }

        //Par ordre

        //Par favoris


        public string getAuteurCommentaire(string id)
        {
            String outpute = "";

            //Console.WriteLine("\n \n ============= On TESTTTTT ====================================================\n \n ");

            List<List<String>> l = this.sqlManager.SqlRequest(SQL_constants.selectuserById + id);

           // Console.WriteLine("\n \n ============= On TESTTTTT ====================================================\n \n ");
            outpute += l[0][0];

            //Console.WriteLine("\n \n //// ======\n size = "+ l.Count +"  \n====== //// ==> Voici le retour de l'auteur du commentaire  ==>"+ outpute+"<===");
            return outpute;
        }

        public List<Livre> getBibliotheque()
        {
            return this.bibliotheque;
        }

        public List<Commentaire> getListCommentaires()
        {
            return this.commentaires;
        }

        /// <summary>
        /// on télécharge un livre par rapport à son id
        /// </summary>
        /// <param name="nom"></param>
        public void downLoadLivre(int idLivre)
        {
            string nom = "";
            foreach (Livre l in this.bibliotheque)
            {
                if (l.id == idLivre)
                {
                    nom = l.titre;
                    Console.WriteLine("\n \n ====== Je dl le Livre !! =====");
                    //ftpManager.download(nom+".pdf");
                    ftpManager.dowload2(nom+".pdf");
                    break;
                }
            }
            //await ftpManager.download_Async(nom);
            
        }
    }
}
