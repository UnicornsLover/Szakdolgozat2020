using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szakdolgozat2020.Database;
using Szakdolgozat2020.Modell.SchoolChildren;

namespace Szakdolgozat2020.Repository.ChildrenViews
{
    partial class RepositoryChildrenViewDatabaseCommand
    {
        private readonly string connectionString;
        public RepositoryChildrenViewDatabaseCommand()
        {
            Connection cs = new Connection();
            connectionString = cs.getConnectionString();
        }

        /// <summary>
        /// Párok kiolvasása az adatbázisból
        /// </summary>
        /// <returns>Párok</returns>
        public List<ChildrenView> getChildrenviewFromDatabase()
        {
            List<ChildrenView> childrenviews = new List<ChildrenView>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = ChildrenView.getSQLCommandGetAllRecord();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    bool goodResult = false;
                    int id = -1;

                    goodResult = int.TryParse(dr["ID"].ToString(), out id);
                    string sname = dr["schoolName"].ToString();
                    string cname = dr["cname"].ToString();
                    string fDate = dr["fromDate"].ToString();
                    string eFinish = dr["expectedFinish"].ToString();
                    string type = dr["type"].ToString();

                    if (goodResult)
                    {
                        string hteacher = dr["headteacher"].ToString();
                        ChildrenView chiv = new ChildrenView(id, cname, sname, fDate, eFinish, type, hteacher);
                        childrenviews.Add(chiv);
                    }
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                connection.Close();
                Debug.WriteLine(ex.Message + "Párok adatainak beolvasása************************************************************");
                throw new RepositoryChildrenViewReadyDataFromEmployes_LoginException("Párok adatainak beolvasása sikertlen, nem elérthető az adatbázis.");
            }
            return childrenviews;
        }

        /// <summary>
        /// Párok törlése az adatbázisól
        /// </summary>
        /// <param name="id">Adott párok id-ja</param>
        public void deleteChildrenViewFromDatabase(int id)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "DELETE FROM children_school WHERE ID=" + id;
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine("DeleteChildrenView***********************" + id + " idéjű párok törlése nem sikerült.");
                throw new RepositoryChildrenViewException("Sikertelen törlés az adatbázisból.");
            }
        }

        /// <summary>
        /// Párok módsítása az adatbázisban
        /// </summary>
        /// <param name="id">Párok id-ja</param>
        /// <param name="modified">Adott párok módosítása</param>
        public void updateChildrenViewInDatabase(int id, ChildrenView modified)
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
                Debug.WriteLine("UpdateChidrenView***************************" + id + " idéjű szülő módosítása nem sikerült.");
                throw new RepositoryChildrenViewException("Sikertelen módosítás az adatbázisból.");
            }
        }

        /// <summary>
        /// Szülő hozzáadása a z adatbázishoz
        /// </summary>
        /// <param name="newChildrenView">Az adott szülő akit beszúrunk</param>
        public void insertParentToDatabase(ChildrenView newChildrenView)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = newChildrenView.getInsert();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine("InsertChildrenView*******************************" + newChildrenView + " párok beszúrása adatbázisba nem sikerült.");
                throw new RepositoryChildrenViewException("Sikertelen beszúrás az adatbázisból.");
            }
        }

    }
}
