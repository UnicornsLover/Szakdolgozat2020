using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szakdolgozat2020.Database;
using Szakdolgozat2020.Modell.EventChildren;

namespace Szakdolgozat2020.Repository.ChildrenEvents
{
    public partial class EventChildrenDatabaseCommand
    {
        private readonly string connectionString;
        public EventChildrenDatabaseCommand()
        {
            Connection cs = new Connection();
            connectionString = cs.getConnectionString();
        }

        /// <summary>
        /// Esemény és yerek kiolvasása az adatbázisból
        /// </summary>
        /// <returns>Gyerekek</returns>
        public List<EventChild> getEventChildrenFromDatabase()
        {
            List<EventChild> eventchildren = new List<EventChild>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = EventChild.getSQLCommandGetAllRecord();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    bool goodResult = false;
                    int id = -1;

                    goodResult = int.TryParse(dr["ID"].ToString(), out id);
                    string cname = dr["cname"].ToString();
                    string title = dr["title"].ToString();

                    if (goodResult)
                    {
                        string timer = dr["timer"].ToString();
                        EventChild evechi = new EventChild(id, cname, title, timer);
                        eventchildren.Add(evechi);
                    }
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                connection.Close();
                Debug.WriteLine(ex.Message + "Esemény Gyerek adatainak beolvasása************************************************************");
                throw new RepositoryEventChildrenReadyDataFromEmployes_LoginException("Gyermekek esemény adatainak beolvasása sikertlen, nem elérthető az adatbázis.");
            }
            return eventchildren;
        }

        /// <summary>
        /// Gyermek esemény törlése az adatbázisól
        /// </summary>
        /// <param name="id">Adott gyerek esemény id-ja</param>
        public void deleteEventChildFromDatabase(int id)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "DELETE FROM ceventsk WHERE ID=" + id;
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine("DeleteEventChild***********************" + id + " idéjű gyermek-esemény törlése nem sikerült.");
                throw new RepositoryEventChildException("Sikertelen törlés az adatbázisból.");
            }
        }

        /// <summary>
        /// Gyermek-esemény módsítása az adatbázisban
        /// </summary>
        /// <param name="id">Gyermek-esemény id-ja</param>
        /// <param name="modified">Adott gyermek-esemeny módosítása</param>
        public void updateChildrenInDatabase(int id, EventChild modified)
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
                Debug.WriteLine("UpdateEventChild***************************" + id + " idéjű dolgozó módosítása nem sikerült.");
                throw new RepositoryEventChildException("Sikertelen módosítás az adatbázisból.");
            }
        }

        /// <summary>
        /// Gyermek hozzáadása a z adatbázishoz
        /// </summary>
        /// <param name="newEventChild">Az adott gyermek akit beszúrunk</param>
        public void insertEventChildrenToDatabase(EventChild newEventChild)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = newEventChild.getInsert();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine("InsertChild*******************************" + newEventChild + " gyermek-esemény beszúrása adatbázisba nem sikerült.");
                throw new RepositoryEventChildException("Sikertelen beszúrás az adatbázisból.");
            }
        }
    }
}
