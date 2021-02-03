using System;
using System.Collections.Generic;
using System.Text;

namespace Modeles
{
    public class Commentaire
    {
        private int _idCommentaire;
        private string _titre;
        private string _contenu;
        private int _notation;
        private int _nbSignalement;
        private int _idUtilisateur;
        private int _idLivre;
       

        public int idCommentaire { get => _idCommentaire; set => _idCommentaire = value; }
        public string titre { get => _titre; set => _titre = value; }
        public string contenu { get => _contenu; set => _contenu = value; }
        public int notation { get => _notation; set => _notation = value; }
        public int nbSignalement { get => _nbSignalement; set => _nbSignalement = value; }
        public int idUtilisateur { get => _idUtilisateur; set => _idUtilisateur = value; }
        public int idLivre { get => _idLivre; set => _idLivre = value; } 
        
        
        
       

        /// <summary>
        ///   
        /// </summary>
        /// <param name="id"></param>
        /// <param name="titre"></param>
        /// <param name="contenu"></param>
        /// <param name="notation"></param>
        /// <param name="nbSignalement"></param>
        public Commentaire(int id, string titre, string contenu, int notation, int nbSignalement,int idUtilisateur, int idLivre)
        {
            this._idCommentaire = id;
            this._titre = titre;
            this._contenu = contenu;
            this._notation = notation;
            this._nbSignalement = nbSignalement;
            this._idUtilisateur = idUtilisateur;
            this._idLivre = idLivre;
        }


        public override string ToString()
        {
            Console.WriteLine(base.ToString()); 
            return base.ToString();
        }
    }
}
