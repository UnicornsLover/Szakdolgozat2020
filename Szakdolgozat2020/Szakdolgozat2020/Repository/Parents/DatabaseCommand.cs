using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szakdolgozat2020.Database;
using Szakdolgozat2020.Modell.Parents;

namespace Szakdolgozat2020.Repository.Parents
{
    partial class RepositoryDatabaseParents
    {
        private readonly string connectionString;
        public RepositoryDatabaseParents()
        {
            Connection cs = new Connection();
            connectionString = cs.getConnectionString();
        }

        /// <summary>
        /// Szülők kiolvasása az adatbázisból
        /// </summary>
        /// <returns>Szülők</returns>
        public List<Parent> getParentsFromDatabase()
        {
            List<Parent> parents = new List<Parent>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = Parent.getSQLCommandGetAllRecord();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    bool goodResult = false;
                    int id = -1;

                    goodResult = int.TryParse(dr["ID"].ToString(), out id);
                    string pname = dr["pname"].ToString();
                    string pbirth = dr["pbirth"].ToString();
                    string psex = dr["psex"].ToString();
                    string pidcard = dr["pidcardnumber"].ToString();
                    string ploginper = dr["loginpermission"].ToString();
                    string user = dr["loginuser"].ToString();

                    if (goodResult)
                    {
                        string pass = dr["loginpsw"].ToString();
                        Parent par = new Parent(id, pname, psex, pbirth, pidcard, ploginper, user, pass);
                        parents.Add(par);
                    }
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                connection.Close();
                Debug.WriteLine(ex.Message + "Szülők adatainak beolvasása************************************************************");
                throw new RepositoryParentsReadyDataFromEmployes_LoginException("Szülők adatainak beolvasása sikertlen, nem elérthető az adatbázis.");
            }
            return parents;
        }

        /// <summary>
        /// Szülők törlése az adatbázisól
        /// </summary>
        /// <param name="id">Adott szülő id-ja</param>
        public void deleteParentFromDatabase(int id)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "DELETE FROM parents WHERE ID=" + id;
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine("DeleteParent***********************" + id + " idéjű szülő törlése nem sikerült.");
                throw new RepositoryParentException("Sikertelen törlés az adatbázisból.");
            }
        }

        /// <summary>
        /// Szülő módsítása az adatbázisban
        /// </summary>
        /// <param name="id">Szülő id-ja</param>
        /// <param name="modified">Adott szülö módosítása</param>
        public void updateParentInDatabase(int id, Parent modified)
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
                Debug.WriteLine("UpdateParent***************************" + id + " idéjű szülő módosítása nem sikerült.");
                throw new RepositoryParentException("Sikertelen módosítás az adatbázisból.");
            }
        }

        /// <summary>
        /// Szülő hozzáadása a z adatbázishoz
        /// </summary>
        /// <param name="newEmployee">Az adott szülő akit beszúrunk</param>
        public void insertParentToDatabase(Parent newParent)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = newParent.getInsert();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine("InsertParent*******************************" + newChild + " gyermek beszúrása adatbázisba nem sikerült.");
                throw new RepositoryParentException("Sikertelen beszúrás az adatbázisból.");
            }
        }
    }
}
