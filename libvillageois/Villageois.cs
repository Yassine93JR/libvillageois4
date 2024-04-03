using System.Collections.Generic;
using System.Net.Security;

namespace libvillageois
{
    public class Villageois

    {
        private string nom;
        private int poids;
        private bool malade;
        private int _dose;
        private Potion _mapotion;
        private int taux;
        private int _poids;

        public Villageois(string nom, int poids, bool malade)

        {
            this.nom = nom;
            this.poids = poids;
            this.malade = malade;
            this._mapotion = new Potion(0);
        }
        public Villageois(string nom)
        {
            this.nom = nom;
            this.malade = false;
            this._mapotion = new Potion(0);
        }

        public override string ToString()
        {
            return "Le  villageois se nomme " + this.nom + "peut soulever" + this.poids + " et est " + this.malade;
        }

        public Villageois(string nom, int poids, bool malade,int dose)

        {
            this.nom = nom;
            this.poids = poids;
            this.malade = malade;
            this._mapotion = new Potion(dose);
        }


        public string getNom()
        {
            return nom;
        }
        public int getPoids()
        {
            return poids;
        }
        public int poidsSouleve()
        {
            double dopage = _mapotion.ConséquencesDoses();
            int resultat = poids / 5;
            return resultat;
        }
        public int setPoids(int poids)
        {
            return poids;

        }
        public bool Soulevememepoids(Villageois a)
        {
            bool flag = false;
            if (this.poids == a.getPoids())
            {
                flag = true;
            }

            return flag;


        }
        public string plusfort(Villageois b)
        {
            string ret = "";
            if (this.Soulevememepoids(b) == true)
                ret = "Les villageois soulevent le meme poids";
            if (b.poidsSouleve() > this._poids)
                ret = $"Le villageois {b.getNom()} est plus fort que le villageois " + this.getNom();
            else
            {
                ret = "Le villageois " + this.getNom() + "est plus  fort que le villageois" + b.getNom();
            }

            return ret;


        }

        public Potion getPotion()
        {
            return _mapotion;
        }

        public void setDose(int v)
        {
            _mapotion.ajouterDose(v);
        }
        public Villageois AjouterVillageois(int a)
        {
            return this;
        }





    }
}