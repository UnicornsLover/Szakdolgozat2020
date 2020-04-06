using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szakdolgozat2020.Database;
using Szakdolgozat2020.Modell.Event;

namespace Szakdolgozat2020.Repository.Events
{
    public partial class EventDatabaseCommand
    {
        private readonly string connectionString;
        public EventDatabaseCommand()
        {
            Connection cs = new Connection();
            connectionString = cs.getConnectionString();
        }

        /// <summary>
        /// Az események kiolvasása az adatbázisból
        /// </summary>
        /// <returns>Események</returns>
        public List<Event> getEventFromDatabase()
        {
            List<Event> events = new List<Event>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = Event.getSQLCommandGetAllRecord();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    bool goodResult = false;
                    int id = -1;

                    goodResult = int.TryParse(dr["ID"].ToString(), out id);
                    string title = dr["title"].ToString();
                    string details = dr["details"].ToString();
                    

                    if (goodResult)
                    {
                        string by = dr["by"].ToString();
                        Event eve = new Event(id, title, details, by);
                        events.Add(eve);
                    }
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                connection.Close();
                Debug.WriteLine(ex.Message + "Esemény adatainak beolvasása************************************************************");
                throw new RepositoryEventsReadyDataFromEmployes_LoginException("Esemény adatainak beolvasása sikertlen,vagy nem érthető el az adatbázis.");
            }
            return events;
        }

        /// <summary>
        /// Esemeny törlése az adatbázisól
        /// </summary>
        /// <param name="id">Adott Esemeny id-ja</param>
        public void deleteEventFromDatabase(int id)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "DELETE FROM children_events WHERE ID=" + id;
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine("DeleteEvent***********************" + id + " idéjű esemény törlése nem sikerült.");
                throw new RepositoryEventException("Sikertelen törlés az adatbázisból.");
            }
        }

        /// <summary>
        /// Esemény módsítása az adatbázisban
        /// </summary>
        /// <param name="id">Esemény id-ja</param>
        /// <param name="modified">Adott Esemény módosítása</param>
        public void updateEventInDatabase(int id, Event modified)
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
                Debug.WriteLine("UpdateSchool***************************" + id + " idéjű iskola módosítása nem sikerült.");
                throw new RepositoryEventException("Sikertelen módosítás az adatbázisból.");
            }
        }

        /// <summary>
        /// Esemény hozzáadása a z adatbázishoz
        /// </summary>
        /// <param name="newEvent">Az adott esemény amit beszúrunk</param>
        public void insertEventToDatabase(Event newEvent)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = newEvent.getInsert();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine("InsertEsemeny*******************************" + newEvent + " gyermek beszúrása adatbázisba nem sikerült.");
                throw new RepositoryEventException("Sikertelen beszúrás az adatbázisból.");
            }
        }
    }
}
