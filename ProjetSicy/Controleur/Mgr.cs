using ProjetSicy.DAL;
using ProjetSicy.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSicy.Controleur
{
    public class Mgr
    {
        DAL.SecteurDAO empDAO = new DAL.SecteurDAO(); //accès à la classe SecteurDAO

        List<Modele.Secteur> maListeSecteur;

        public Mgr()
        {
            maListeSecteur = new List<Modele.Secteur>();
        }

        public List<Secteur>chargementEmpBD()
        {
            maListeSecteur = SecteurDAO.getSecteur();
            return maListeSecteur;
        }

    }
}
