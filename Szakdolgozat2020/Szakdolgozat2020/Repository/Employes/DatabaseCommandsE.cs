using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szakdolgozat2020.Modell.Employes;

namespace Szakdolgozat2020.Repository.Employes
{
    partial class RepositoryDatabseAndTableEmploye
    {
        /// <summary>
        /// Adatok kiolvasása adatbázisból (employes_login)
        /// </summary>
        /// <returns> Dolgozók</returns>
        public List<Employe> getEmployeesFromDatabase()
        {
            List<Employe> employees = new List<Employe>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = Employe.getSQLCommandGetAllRecord();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    bool goodResult = false;
                    int id = -1;

                    goodResult = int.TryParse(dr["ID"].ToString(), out id);
                    string ename = dr["ename"].ToString();
                    string emaidenname = dr["emaidenname"].ToString();
                    string esex = dr["esex"].ToString();
                    string ebirth = dr["ebirth"].ToString();
                    string ebirthplace = dr["ebirthplace"].ToString();
                    string ejob = dr["ejob"].ToString();
                    string elocation = dr["elocation"].ToString();
                    string euname = dr["euname"].ToString();

                    if (goodResult)
                    {
                        string epassword = dr["epassword"].ToString();
                        Employe emp = new Employe(id,ename,emaidenname,esex,ebirth,ebirthplace,ejob,elocation,euname,epassword);
                        employees.Add(emp);
                    }
                }
                connection.Close();
            } catch (Exception ex)
            {
                connection.Close();
                Debug.WriteLine(ex.Message+"Dolgozók adatainak beolvasása************************************************************");
                throw new RepositoryEmployeesReadyDataFromEmployes_LoginException("Dolgozók adatainak beolvasása sikertlen, nem elérthető az adatbázis.");
            }
            return employees;
        }

        /// <summary>
        /// Dolgozók törlése az adatbázisból
        /// </summary>
        /// <param name="id">Adott dolgozó id-ja</param>
        public void deleteEmployeFromDatabase(int id)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "DELETE FROM employes_login WHERE ID=" + id;
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine("DeleteEmploye***********************"+id + " idéjű dolgozó törlése nem sikerült.");
                throw new RepositoryEmployeException("Sikertelen törlés az adatbázisból.");
            }
        }

        /// <summary>
        /// Dolgozó módosítás az adatbázisban
        /// </summary>
        /// <param name="id">Dolgozó id-ja</param>
        /// <param name="modified">Módosítando dolgozó</param>
        public void updateEmployeeInDatabase(int id, Employe modified)
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
                Debug.WriteLine("UpdateEmploye***************************"+id + " idéjű dolgozó módosítása nem sikerült.");
                throw new RepositoryEmployeException("Sikertelen módosítás az adatbázisból.");
            }
        }

        /// <summary>
        /// Dolgozó beszúrása az adatbázishoz
        /// </summary>
        /// <param name="newEmployee"> Az adoot dolgozó akit beszúrunk</param>
        public void insertEmployeeToDatabase(Employe newEmployee)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = newEmployee.getInsert();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine("InsertEmploye*******************************"+newEmployee + " dolgozó beszúrása adatbázisba nem sikerült.");
                throw new RepositoryEmployeException("Sikertelen beszúrás az adatbázisból.");
            }
        }
    }
}
