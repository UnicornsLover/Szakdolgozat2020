using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szakdolgozat2020.Database;
using Szakdolgozat2020.Modell.ChildParent;

namespace Szakdolgozat2020.Repository.ChildrenParents
{
    public partial class ChildrenParentDatabaseCommand
    {
        private readonly string connectionString;
        public ChildrenParentDatabaseCommand()
        {
            Connection cs = new Connection();
            connectionString = cs.getConnectionString();
        }

        /// <summary>
        /// Gyerek-szülő kiolvasása az adatbázisból
        /// </summary>
        /// <returns>Gyerek-szülő</returns>
        public List<ChildParent> getChildrenParentsFromDatabase()
        {
            List<ChildParent> childrenparent = new List<ChildParent>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = ChildParent.getSQLCommandGetAllRecord();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    bool goodResult = false;
                    int id = -1;

                    goodResult = int.TryParse(dr["ID"].ToString(), out id);
                    string cname = dr["pname"].ToString();

                    if (goodResult)
                    {
                        string pname = dr["cname"].ToString();
                        ChildParent chi = new ChildParent(id, pname, cname);
                        childrenparent.Add(chi);
                    }
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                connection.Close();
                Debug.WriteLine(ex.Message + "Szülő-gyerek adatainak beolvasása************************************************************");
                throw new RepositoryChildrenParentReadyDataFromEmployes_LoginException("Gyermek-Szülő adatainak beolvasása sikertlen, nem elérthető az adatbázis.");
            }
            return childrenparent;
        }

        /// <summary>
        /// Gyermek-szülő törlése az adatbázisól
        /// </summary>
        /// <param name="id">Adott gyerek-szülő id-ja</param>
        public void deleteChildParentFromDatabase(int id)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "DELETE FROM parentsk WHERE ID=" + id;
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine("DeleteChild***********************" + id + " idéjű gyermek-szülő törlése nem sikerült.");
                throw new RepositoryChildParentException("Sikertelen törlés az adatbázisból.");
            }
        }

        /// <summary>
        /// Gyermek-szülő módsítása az adatbázisban
        /// </summary>
        /// <param name="id">Gyermek-szülő id-ja</param>
        /// <param name="modified">Adott gyermek-szülő módosítása</param>
        public void updateChildrenInDatabase(int id, ChildParent modified)
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
                Debug.WriteLine("UpdateChildParent***************************" + id + " idéjű szülő-gyerek módosítása nem sikerült.");
                throw new RepositoryChildParentException("Sikertelen módosítás az adatbázisból.");
            }
        }

        /// <summary>
        /// Gyermek-szülő hozzáadása a z adatbázishoz
        /// </summary>
        /// <param name="newChildParent">Az adott gyermek-szület akit beszúrunk</param>
        public void insertChildrenParentToDatabase(ChildParent newChildParent)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = newChildParent.getInsert();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine("InsertChildParent*******************************" + newChildParent + " gyermek-szülő beszúrása adatbázisba nem sikerült.");
                throw new RepositoryChildParentException("Sikertelen beszúrás az adatbázisból.");
            }
        }
    }
}
