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
        public void fillTestUsers()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query =
                    "INSERT INTO `loginusers` (`id`, `fname`, `password`,`job`) VALUES " +
                            " (1, 'bisti', 'admin', 'boss'), " +
                            " (2, 'nevelo', 'nevelo1', 'nevelo'), " +
                            " (3, 'intv', 'intv1', 'intvezeto'), " +
                            " (4, 'intu', 'intu1', 'intugyintezo'), " +
                            " (5, 'lelek', 'lelek1', 'pszichologus'); ";
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
