using System;
using System.Collections.Generic;
using System.Text;

namespace Modeles
{
    public class Utilisateur
    {
        private int _id;
        private string _nom;
        private int _nbSignalement;

        private int id { get => _id; set => _id = value; }
        private string nom { get => _nom; set => _nom = value; }
        private int nbSignalement { get => _nbSignalement; set => _nbSignalement = value; }

        public Utilisateur(int id, string nom, int nbSignalement)
        {
            this._id = id;
            this._nom = nom;
            this._nbSignalement = nbSignalement;
        }

        public Utilisateur()
        {
        }
        


    }
}
