using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncher
{
    [Serializable]
    class Logiciel
    {
        private string urlRacourcis;
        private int nbJours;
        private int nbHeures;
        private int nbMinutes;
        private string nom;

        public Logiciel(string nom)
        {
            this.nom = nom;
            this.urlRacourcis = "";
            this.nbHeures = 0;
            this.nbJours = 0;
            this.nbMinutes = 0;
        }



        public string UrlRacourcis
        {
            get { return urlRacourcis; }
            set { urlRacourcis = value; }
        }

        public int NbJours
        {
            get { return nbJours; }
            set
            {
                if (value > 0)
                {
                    nbJours = value;
                }
                else
                {
                    nbJours = 0;
                }
            }
        }

        public int NbHeures
        {
            get { return nbHeures; }
            set
            {
                if (value >= 0 && value < 24)
                {
                    nbHeures = value;
                }
                else if (value >= 24)
                {
                    nbHeures = 0;
                    NbJours++;
                }
                else
                {
                    nbHeures = 0;
                }
            }
        }

        public int NbMinutes
        {
            get { return nbMinutes; }
            set
            {
                if (value >= 0 && value < 60)
                {
                    nbMinutes = value;
                }
                else if (value >= 60)
                {
                    nbMinutes = value - 60;
                    NbHeures++;
                }
                else
                {
                    nbMinutes = 0;
                }
            }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
    }
}
