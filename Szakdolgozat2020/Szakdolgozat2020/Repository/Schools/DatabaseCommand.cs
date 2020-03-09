using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szakdolgozat2020.Database;
using Szakdolgozat2020.Modell.School;

namespace Szakdolgozat2020.Repository.Schools
{
    partial class DatabaseCommand
    {
        private readonly string connectionString;
        public DatabaseCommand()
        {
            Connection cs = new Connection();
            connectionString = cs.getConnectionString();
        }

        /// <summary>
        /// Az iskolák kiolvasása az adatbázisból
        /// </summary>
        /// <returns>Iskolák</returns>
        public List<School> getSchoolsFromDatabase()
        {
            List<School> schools = new List<School>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = School.getSQLCommandGetAllRecord();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    bool goodResult = false;
                    int id = -1;

                    goodResult = int.TryParse(dr["ID"].ToString(), out id);
                    string sname = dr["schoolName"].ToString();
                    string sLocation = dr["schoolLocation"].ToString();

                    if (goodResult)
                    {
                        string sPhone = dr["schoolPhone"].ToString();
                        School sch = new School(id, sname, sLocation, sPhone);
                        schools.Add(sch);
                    }
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                connection.Close();
                Debug.WriteLine(ex.Message + "Iskola adatainak beolvasása************************************************************");
                throw new RepositorySchoolsReadyDataFromEmployes_LoginException("Iskola adatainak beolvasása sikertlen,vagy nem érthető el az adatbázis.");
            }
            return schools;
        }

        /// <summary>
        /// Iskola törlése az adatbázisól
        /// </summary>
        /// <param name="id">Adott iskola id-ja</param>
        public void deleteSchoolFromDatabase(int id)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "DELETE FROM school WHERE ID=" + id;
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine("DeleteSchool***********************" + id + " idéjű iskola törlése nem sikerült.");
                throw new RepositorySchoolException("Sikertelen törlés az adatbázisból.");
            }
        }

        /// <summary>
        /// Iskola módsítása az adatbázisban
        /// </summary>
        /// <param name="id">Iskola id-ja</param>
        /// <param name="modified">Adott iskola módosítása</param>
        public void updateParentInDatabase(int id, School modified)
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
                throw new RepositorySchoolException("Sikertelen módosítás az adatbázisból.");
            }
        }

        /// <summary>
        /// Iskola hozzáadása a z adatbázishoz
        /// </summary>
        /// <param name="newSchool">Az adott iskola amit beszúrunk</param>
        public void insertParentToDatabase(School newSchool)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = newSchool.getInsert();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine("InsertSchool*******************************" + newSchool + " gyermek beszúrása adatbázisba nem sikerült.");
                throw new RepositorySchoolException("Sikertelen beszúrás az adatbázisból.");
            }
        }
    }
}
