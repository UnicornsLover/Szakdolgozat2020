using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat2020.Database
{
    partial class CreateCommand
    {
        /// <summary>
        /// Bejelenkezés adatok feltöltése
        /// </summary>
        public void fillTestUsers()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query =
                    "INSERT INTO `employes_login` (`ID`, `name`, `ebirth`, `ebirthplace`, `elocation`, `fname`, `password`, `job`) VALUES" +
                    "(1, 'Bálint István', '1999-09-12','Székesfehérvár', 'Kecskemét', 'bisti', 'admin', 'boss')," +
                    "(2, 'Chat Elek', '1985-03-14','Kiskunfélegyháza','Szeged', 'chaele', 'nevelo1', 'nevelo')," +
                    "(3, 'Zuhany Rózsa', '1963-11-08','Budapest','Szeged', 'zuhroz', 'intv1', 'intvezeto')," +
                    "(4, ' Fejet Lenke ', '1977-02-21','Szárszó','Orosháza', 'fejlen', 'intu1', 'intugyintezo')," +
                    "(5, 'Major Anna ', '1972-09-12','Dorozsma','Kőszeg', 'majann', 'lelek1', 'pszichologus');";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                //throw new InsertUsersException("Nem lehetet a teszt felhasználokat beszúrni!");
            }
        }
    }
}
