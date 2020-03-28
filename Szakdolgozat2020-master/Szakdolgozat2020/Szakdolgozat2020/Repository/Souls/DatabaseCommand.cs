using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Szakdolgozat2020.Database;
using Szakdolgozat2020.Modell.Soul;

namespace Szakdolgozat2020.Repository.Souls
{
    public class DatabaseSoulCommand
    {
        private readonly string connectionString;
        public DatabaseSoulCommand()
        {
            Connection cs = new Connection();
            connectionString = cs.getConnectionString();
        }

        /// <summary>
        /// Akta kiolvasása az adatbázisból
        /// </summary>
        /// <returns>Akta</returns>
        public List<SoulM> getSoulsFromDatabase()
        {
            List<SoulM> souls = new List<SoulM>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = SoulM.getSQLCommandGetAllRecord();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    bool goodResult = false;
                    int id = -1;

                    goodResult = int.TryParse(dr["boardID"].ToString(), out id);
                    string cname = dr["cname"].ToString();
                    string type = dr["type"].ToString();
                    string details = dr["details"].ToString();
                    string spt = dr["special_treatment"].ToString();
                    string treatdate = dr["treatdate"].ToString();
                    

                    if (goodResult)
                    {
                        string bynamee = dr["by"].ToString();
                        SoulM sol = new SoulM(id, cname, type, details, spt, treatdate, bynamee);
                        souls.Add(sol);
                    }
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                connection.Close();
                Debug.WriteLine(ex.Message + "Akták adatainak beolvasása************************************************************");
                throw new RepositorySoulsReadyDataFromEmployes_LoginException("Akták adatainak beolvasása sikertlen, nem elérthető az adatbázis.");
            }
            return souls;
        }

        /// <summary>
        /// Akták törlése az adatbázisól
        /// </summary>
        /// <param name="id">Adott akta id-ja</param>
        public void deleteSoulFromDatabase(int id)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "DELETE FROM children_healths WHERE boardID=" + id;
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine("DeleteSoul***********************" + id + " idéjű akta törlése nem sikerült.");
                throw new RepositorySoulException("Sikertelen törlés az adatbázisból.");
            }
        }

        /// <summary>
        /// Akta módsítása az adatbázisban
        /// </summary>
        /// <param name="id">Akta id-ja</param>
        /// <param name="modified">Adott akta módosítása</param>
        public void updateSoulInDatabase(int id, SoulM modified)
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
                Debug.WriteLine("UpdateSoul***************************" + id + " idéjű akta módosítása nem sikerült.");
                throw new RepositorySoulException("Sikertelen módosítás az adatbázisból.");
            }
        }

        /// <summary>
        /// Akta hozzáadása a z adatbázishoz
        /// </summary>
        /// <param name="newSoul">Az adott akta akit beszúrunk</param>
        public void insertSoulToDatabase(SoulM newSoul)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = newSoul.getInsert();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine("InsertParent*******************************" + newSoul + " akták beszúrása adatbázisba nem sikerült.");
                throw new RepositorySoulException("Sikertelen beszúrás az adatbázisból.");
            }
        }
    }
}
