using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RATTRAPAGE1
{
    class Maison : Batiment
    {
        //attributs
        private int NbPiece;
        //constructeur par defaut
        public Maison()
        {
            this.NbPiece = 0;
            this.adresse = "";
        }
        //constructeur initialisation
        public Maison(string adresse , int NbPiece)
        {
            this.NbPiece = 0;
            this.adresse = "Adresse";
        }
        //Propriétés

        public int nbPiece
        {
            get { return this. NbPiece; }
            set {   NbPiece = 0; }
        }
        public string Adresse
        {
            get { return this.Adresse; }
            set { Adresse = value; }
        }
        //methode ToString
       new public  string ToString()
        {
            return "Maison" + base.ToString();
        }
    }
}
