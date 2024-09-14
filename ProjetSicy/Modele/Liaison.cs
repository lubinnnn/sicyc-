using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSicy.Modele
{
    public class Liaison
    {
        private int id;
        private string duree; 


        public Liaison(int id, string duree)
        {
            this.id = id;
            this.duree = duree;
        }

        public int idLiaison{ get => id; set => id = value; }
        public string Duree { get => duree; set => duree = value; }

        public virtual string Description
        {
            get => "Id : " + this.id + " Nom :" + this.duree;
        }
    }
}
