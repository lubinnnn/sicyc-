using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProjetSicy.Modele;
using ProjSicilynes;


namespace ProjetSicy.DAL
{
    public class LiaisonDAO
    {

        private static string provider = "localhost";

        private static string dataBase = "sicilylines";

        private static string uid = "root";

        private static string mdp = "";

        private static ConnexionSql maConnexionSql;



        public static void updateLiaison(Liaison l)
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                MySqlCommand Ocom = maConnexionSql.reqExec("update Secteur set nom = '" + l.Duree + "' where id = '" + l.idLiaison);



                int i = Ocom.ExecuteNonQuery();



                maConnexionSql.closeConnection();
            }

            catch(Exception uneLiaison)
            {
                throw(uneLiaison);
            }
            
        }

        public static void DeleteLiaison(Liaison l)
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                MySqlCommand Ocom = maConnexionSql.reqExec("delete Liaison  where id = '" + l.idLiaison);

                int i = Ocom.ExecuteNonQuery();



                maConnexionSql.closeConnection();
            }


            catch(Exception uneLiaison)
            {
                throw (uneLiaison);
            }
        }

        public static void insertLiaison(Liaison l)
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                MySqlCommand Ocom = maConnexionSql.reqExec("insert into Liaison  where id = '" + l.idLiaison);

                int i = Ocom.ExecuteNonQuery();



                maConnexionSql.closeConnection();
            }

            catch( Exception uneLiaison)
            {
                throw (uneLiaison );
            }
        }

        public static List<Liaison> GetLiaisons(int idSecteur)
        {
            List<Liaison> liaison = new List<Liaison>();
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                MySqlCommand Ocom = maConnexionSql.reqExec("Select * from liaison where idSecteur = " + idSecteur + " + 1 ");

                MySqlDataReader reader = Ocom.ExecuteReader();




                while (reader.Read())
                {
                    int unId = (int)reader.GetValue(0);
                    string uneDuree = (string)reader.GetValue(1);

                    Liaison laLiaison = new Liaison(unId, uneDuree);

                    liaison.Add(laLiaison);
                }

                reader.Close();
                maConnexionSql.closeConnection();

                return (liaison);

            }

            catch (Exception ex)
            {
                throw (ex);
            }
        }


    }
}
