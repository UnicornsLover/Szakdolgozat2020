using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szakdolgozat2020.Database;
using Szakdolgozat2020.Modell.Employes;

namespace Szakdolgozat2020.Repository.Employes
{
    partial class RepositoryDatabseAndTableEmploye
    {
        private readonly string connectionString;
        public RepositoryDatabseAndTableEmploye()
        {
            Connection cs = new Connection();
            connectionString = cs.getConnectionString();
        }
        public void deleteTableEmploye()
        {
            string query =
                "USE liveincare;" +
                "DROP TABLE employes_login;";
            MySqlConnection connection =
               new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryEmloyes_LoginDropException("Tábla törlése nem sikerült.");
            }
        }

        public void deleteDataFromEmployeTable()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = Employe.getSQLCommandDeleteAllRecord();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryDataDeleteFromEmloyes_LoginException("Tesztadatok törlése sikertelen volt.");
            }
        }

    }
}
