using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RATTRAPAGE1
{
    class Batiment
    {
        //attributs
        private string Adresse;
        //constructeur par defaut
        public Batiment()
        {
            this.adresse = "";
        }
        //constructeur initialisation
        public Batiment(string adresse)
        {
            this.adresse = "Adresse";
        }
        //Propriétés

        public string adresse
        {
            get { return this.Adresse; }
            set { Adresse = value; }
        }
        //methode ToString
       new public  string ToString()
        {
            return "batiment" + base.ToString();
        }
    }
}
