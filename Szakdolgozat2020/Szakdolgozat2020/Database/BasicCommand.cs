﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat2020.Database
{
    class BasicCommand
    {
        private string connectionStringCreate;
        private string connectionString;
        DConnection cs = new DConnection();

        public void createDatabase()
        {
            connectionStringCreate = cs.getCreateConnectionString();
            MySqlConnection connection = new MySqlConnection(connectionStringCreate);
            try
            {
                connection.Open();
                string query =
                "CREATE DATABASE IF NOT EXISTS liveincare " +
                "DEFAULT CHARACTER SET utf8 " +
                "COLLATE utf8_hungarian_ci ";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message+"*******************************************************************************");
                //throw new DatabaseCreateException("Adatbázis létrehozás nem sikerült vagy már létezik.");
            }
        }

        public void createTableLogIn()
        {
            connectionString = cs.getConnectionString();
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string queryCreateTable =
                    "CREATE TABLE `liveincare`.`loginusers` ( " +
                    "`id` INT NULL," +
                    "`fname` VARCHAR(25) NOT NULL," +
                    " `password` VARCHAR(25) NOT NULL," +
                    " `job` VARCHAR(18) NOT NULL" +
                    ") ENGINE = InnoDB;";
                string queryPrimaryKey =
                    "ALTER TABLE `loginusers` ADD PRIMARY KEY(`id`); ";
                MySqlCommand cmdCreateTable = new MySqlCommand(queryCreateTable, connection);
                cmdCreateTable.ExecuteNonQuery();
                MySqlCommand cmdPrimaryKey = new MySqlCommand(queryPrimaryKey, connection);
                cmdPrimaryKey.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message+"*******************************************************************************");
                //throw new TableCreateException("Tábla lérehozása sikertelen.");
            }
        }
    }
}
