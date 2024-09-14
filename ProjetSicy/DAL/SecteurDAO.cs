using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ProjetSicy.Modele;
using ProjSicilynes;

namespace ProjetSicy.DAL
{
    public class SecteurDAO
    {
        private static string provider = "localhost";

        private static string dataBase = "sicilylines";

        private static string uid = "root";

        private static string mdp = "";

        private static ConnexionSql maConnexionSql;




        public static void updateSecteur(Secteur s)
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                MySqlCommand Ocom = maConnexionSql.reqExec("update Secteur set nom = '"+ s.getName() + "' where id = '" +s.getId());

     

                int i = Ocom.ExecuteNonQuery();



                maConnexionSql.closeConnection();
            }

            catch(Exception unSecteur)
            
            {
                throw (unSecteur);
            }
        }

        public static void deleteSecteur(Secteur s)
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                MySqlCommand Ocom = maConnexionSql.reqExec("delete Secteur  where id = '" + s.getId());

                int i = Ocom.ExecuteNonQuery();



                maConnexionSql.closeConnection();

            }

            catch(Exception unSecteur)
            {
                throw (unSecteur);
            }
        }


        public static void insertSecteur(Secteur s)
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                MySqlCommand Ocom = maConnexionSql.reqExec("insert into secteur (nom) values("+s.getName()+")");
                int i = Ocom.ExecuteNonQuery();



                maConnexionSql.closeConnection();
            }

            catch (Exception unSecteur)
            {
                throw (unSecteur);
            }
        }




        public static List<Secteur> getSecteur()
        {
            List<Secteur> secteurs = new List<Secteur>();
            try
            {
                {
                    maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                    maConnexionSql.openConnection();
                    MySqlCommand Ocom = maConnexionSql.reqExec("select * from secteur");

                    MySqlDataReader reader = Ocom.ExecuteReader();

                    Secteur s;

                    while (reader.Read())
                    {
                        int unId = (int)reader.GetValue(0);
                        string unNom = (string)reader.GetValue(1);

                        s = new Secteur(unId, unNom);

                        secteurs.Add(s);
                    }

                    reader.Close();
                    maConnexionSql.closeConnection();

                    return (secteurs);
                }
            }

            catch (Exception unSecteur)
            {
                throw (unSecteur);
            }


        }
        
    }
}



