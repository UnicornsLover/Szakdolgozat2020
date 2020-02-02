﻿using MySql.Data.MySqlClient;
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
        /// <returns></returns>
        public List<Employe> getEmployeFromDatabase()
        {
            List<Employe> employes = new List<Employe>();
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
                        employes.Add(emp);
                    }
                }
                connection.Close();
            } catch (Exception ex)
            {
                connection.Close();
                Debug.WriteLine(ex.Message+"Dolgozók adatainak beolvasása************************************************************");
                throw new RepositoryReadyDataFromEmployes_LoginException("Dolgozók adatainak beolvasása sikertlen.");
            }
            return employes;
        }
    }
}