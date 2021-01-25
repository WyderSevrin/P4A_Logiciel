using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Commentaire
    {
        private string pseudo;
        public string Nom
        {
            get { return pseudo; }
            set { pseudo = value; }
        }

        private string comm;
        public string Comm
        {
            get { return comm; }
            set { comm = value; }
        }
    }
}
