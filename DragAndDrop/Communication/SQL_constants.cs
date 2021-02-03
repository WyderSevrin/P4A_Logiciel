using System;
using System.Collections.Generic;
using System.Text;

namespace Communication
{
    public class SQL_constants
    {
        #region MYSQL SELECT ALL FROM UTILISATEUR
        public static string selectAllQuery = "select * from utilisateur";
        #endregion


        #region MYSQL SELECT ALL BOOKS
        public static string selectAllBooks = "select * from livre";
        #endregion

        #region MYSQL SELECT ALL COMMENTS 
        public static string selectAllComments = "select * from Commentaire";
        #endregion

        #region MYSQL SELECT USER NAME BY ID
        public static string selectuserById = "SELECT Nom FROM utilisateur Where idUtilisateur =";
        #endregion

        
        #region MYSQL SELECT COMMENTAIRE BY ID LIVRE
        public static string selectCommentaireByIdLivre = "SELECT * FROM Commentaire Where Commentaire.Livre_idLivre =";
        #endregion

        #region MYSQL SELECT COMMENTAIRE BY ID LIVRE
        public static string insertLivre =  "INSERT INTO Livre(Nom, Genre, Text, Resumer, Nb_Pages, Mouvement, Auteur)VALUES(";
        #endregion

    }
}
