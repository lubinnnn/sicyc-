using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSicy.Modele
{
    public class Secteur
    {
        private int id;
        private string name;

        public Secteur(int id, string name){
            this.id = id;
            this.name = name;
        }


        

        public int getId() { return id; }

        public string getName() { return name; }

        public void setName(string name)
        {
            this.name = name;
   
        }



        public virtual string Description
        {
            get => "Id : " + this.id + " Nom :" + this.name;
        }







    }
}
