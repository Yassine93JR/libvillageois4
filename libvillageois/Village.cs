using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libvillageois
{
    public class Village
    {
        private string description;
        private string name;
        private int superficie;
        private List<Villageois> mesHabitants;



        public Village(int superficie,string name,string description)
        {

            this.description = description;
            this.name = name;
            this.superficie = superficie;
            this.mesHabitants = new List<Villageois>();

        }


        public void AjouterVillageois(Villageois a)
        {


            mesHabitants.Add(a);


        }
        public void AjouterNewVillageois(string nom, int poids, bool malade, int dose)
        {


            Villageois nouveauvillageois = new Villageois(nom, poids, malade, dose);
            mesHabitants.Add(nouveauvillageois);

        }
        public Villageois GetVillageois(string nom)
        {
            Villageois? villageois = null;
            foreach (Villageois a in mesHabitants)
            {
                if (a.getNom() == nom)
                { 
                villageois = a;
                }

            } return villageois;
        }
        public List<Villageois> GetHabitant()
        { 
            return mesHabitants; 
        }

    public string getNom()
     {
            return name;
    }

        public List<Villageois> GetVillageois()
        {
            return mesHabitants;
        }

        public List<Villageois> GetList()
        {
            return  = "";
        }
    }

    }




    


