using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szakdolgozat2020.Database;
using Szakdolgozat2020.Modell.Children;

namespace Szakdolgozat2020.Repository.Children
{
    partial class RepositoryDatabaseChildren
    {
        private readonly string connectionString;
        public RepositoryDatabaseChildren()
        {
            Connection cs = new Connection();
            connectionString = cs.getConnectionString();
        }

        /// <summary>
        /// Gyerekek kiolvasása az adatbázisból
        /// </summary>
        /// <returns>Gyerekek</returns>
        public List<Child> getChildrenFromDatabase()
        {
            List<Child> children = new List<Child>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = Child.getSQLCommandGetAllRecord();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    bool goodResult = false;
                    int id = -1;

                    goodResult = int.TryParse(dr["ID"].ToString(), out id);
                    string cname = dr["cname"].ToString();
                    string csex = dr["csex"].ToString();
                    string cidcard = dr["cidcardnumber"].ToString();
                    string ctaj = dr["ctajnumber"].ToString();
                    string cbirth = dr["cbirth"].ToString();
                    string cbplace = dr["cbirthplace"].ToString();
                    string ccoming = dr["ccoming"].ToString();

                    if (goodResult)
                    {
                        string clocation = dr["clocation"].ToString();
                        Child chi = new Child(id, cname, csex, cidcard, ctaj, cbirth, cbplace, ccoming, clocation);
                        children.Add(chi);
                    }
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                connection.Close();
                Debug.WriteLine(ex.Message + "Gyermekek adatainak beolvasása************************************************************");
                throw new RepositoryChildrenReadyDataFromEmployes_LoginException("Gyermekek adatainak beolvasása sikertlen, nem elérthető az adatbázis.");
            }
            return children;
        }

        /// <summary>
        /// Gyermek törlése az adatbázisól
        /// </summary>
        /// <param name="id">Adott gyerek id-ja</param>
        public void deleteChildFromDatabase(int id)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "DELETE FROM children_fullprofile WHERE ID=" + id;
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine("DeleteChild***********************" + id + " idéjű gyermek törlése nem sikerült.");
                throw new RepositoryChildException("Sikertelen törlés az adatbázisból.");
            }
        }

        /// <summary>
        /// Gyermek módsítása az adatbázisban
        /// </summary>
        /// <param name="id">Gyermek id-ja</param>
        /// <param name="modified">Adott gyermek módosítása</param>
        public void updateChildrenInDatabase(int id, Child modified)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = modified.getUpdate(id);
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine("UpdateChild***************************" + id + " idéjű dolgozó módosítása nem sikerült.");
                throw new RepositoryChildException("Sikertelen módosítás az adatbázisból.");
            }
        }

        /// <summary>
        /// Gyermek hozzáadása a z adatbázishoz
        /// </summary>
        /// <param name="newEmployee">Az adott gyermek akit beszúrunk</param>
        public void insertChildrenToDatabase(Child newChild)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = newChild.getInsert();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine("InsertChild*******************************" + newChild + " gyermek beszúrása adatbázisba nem sikerült.");
                throw new RepositoryChildException("Sikertelen beszúrás az adatbázisból.");
            }
        }
    }
}
