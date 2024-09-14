using ProjetSicy.Controleur;
using ProjetSicy.DAL;
using ProjetSicy.Modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjetSicy
{
    public partial class Form1 : Form
    {

        Mgr monManager;
        List<Secteur> lsecteur = new List<Secteur>();
        List<Liaison> laliaison = new List<Liaison>();

        public Form1()
        {
            InitializeComponent();
            monManager = new Mgr(); //permet d'acceder aux classes manager
   
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            affiche();
        }
        public void affiche()
        {
            try
            {

                lsecteur = monManager.chargementEmpBD();
                //Reset
                listBoxSecteur.DataSource = null;
                //Connection
                listBoxSecteur.DataSource = lsecteur;

                //Utilise la méthode
                listBoxSecteur.DisplayMember = "Description";
                listBoxLiaison.DataSource = null;
                listBoxLiaison.DataSource = laliaison;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            //Label Secteur
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //Label Liaison
        }

        private void listBoxSecteur_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int secteur = listBoxSecteur.SelectedIndex;
            listBoxLiaison.DataSource = null;
            listBoxLiaison.DataSource = LiaisonDAO.GetLiaisons(secteur);
            listBoxLiaison.DisplayMember = "Description";
        }

        private void label8_Click(object sender, EventArgs e)
        {
            //label Admin
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        


    }
}
