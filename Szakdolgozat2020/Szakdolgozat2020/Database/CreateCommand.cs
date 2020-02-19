using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat2020.Database
{
    partial class CreateCommand
    {
        private string connectionStringCreate;
        private string connectionString;
        Connection cs = new Connection();

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
                throw new DatabaseCreateException("Adatbázis létrehozás nem sikerült vagy már létezik.");
            }
        }

        /// <summary>
        /// Login tábla létrehozása, dolgozók adatai
        /// </summary>
        public void createTableLogIn()
        {
            connectionString = cs.getConnectionString();
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string queryCreateTable =
                    "CREATE TABLE `employes_login` ("
                    +"`ID` int(11) NOT NULL,"
                    +"`ename` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,"
                    +"`emaidenname` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,"
                    +"`esex` tinyint(1) NOT NULL,"
                    +"`ebirth` date NOT NULL,"
                    +"`ebirthplace` varchar(40) COLLATE utf8_hungarian_ci NOT NULL,"
                    +"`ejob` varchar(18) COLLATE utf8_hungarian_ci NOT NULL,"
                    +"`elocation` varchar(40) COLLATE utf8_hungarian_ci NOT NULL,"
                    +"`euname` varchar(25) COLLATE utf8_hungarian_ci NOT NULL,"
                    +"`epassword` varchar(25) COLLATE utf8_hungarian_ci NOT NULL"
                    +") ENGINE = InnoDB DEFAULT CHARSET = utf8 COLLATE = utf8_hungarian_ci;";
                string queryPrimaryKey =
                    "ALTER TABLE `employes_login` ADD PRIMARY KEY IF NOT EXISTS (`ID`);"
                    +"ALTER TABLE `employes_login` MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT = 1;";
                MySqlCommand cmdCreateTable = new MySqlCommand(queryCreateTable, connection);
                cmdCreateTable.ExecuteNonQuery();
                MySqlCommand cmdPrimaryKey = new MySqlCommand(queryPrimaryKey, connection);
                cmdPrimaryKey.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message+ "LogIn*******************************************************************************");
                //throw new TableCreateException("Tábla lérehozása sikertelen, vagy már létezik."); !!!! javítani
            }
        }
        /// <summary>
        /// Gyerekek adatai tárolő tábla létrehozása
        /// </summary>
        public void createTableChildrenFullProfile()
        {
            connectionString = cs.getConnectionString();
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string queryCreateTable =
                    "CREATE TABLE `children_fullprofile` ("
                    +"`ID` int(11) NOT NULL,"
                    +"`cname` varchar(50) COLLATE utf8_hungarian_ci DEFAULT NULL,"
                    +"`csex` varchar(10) COLLATE utf8_hungarian_ci DEFAULT NULL,"
                    +"`cidcardnuumber` varchar(10) COLLATE utf8_hungarian_ci DEFAULT NULL,"
                    +"`ctajnumber` varchar(10) COLLATE utf8_hungarian_ci DEFAULT NULL,"
                    +"`cbirth` date DEFAULT NULL,"
                    +"`cbirthplace` varchar(40) COLLATE utf8_hungarian_ci NOT NULL,"
                    +"`motherID` int(10) NOT NULL,"
                    +"`fatherID` int(10) NOT NULL,"
                    +"`ccoming` date DEFAULT NULL,"
                    +"`clocation` varchar(40) COLLATE utf8_hungarian_ci NOT NULL"
                    +") ENGINE = InnoDB DEFAULT CHARSET = utf8 COLLATE = utf8_hungarian_ci;";
                string queryPrimaryKey =
                //primary kulcs
                "ALTER TABLE `children_fullprofile`" 
                +"ADD PRIMARY KEY IF NOT EXISTS (`ID`);"
                //auto increment
                + "ALTER TABLE `children_fullprofile`"
                + "MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT = 1;"
                //idegen kulcsok
                + "ALTER TABLE `children_fullprofile`"
                + "ADD CONSTRAINT `children_fullprofile_ibfk_1` FOREIGN KEY IF NOT EXISTS (`fatherID`) REFERENCES `parents` (`ID`),"
                + "ADD CONSTRAINT `children_fullprofile_ibfk_2` FOREIGN KEY IF NOT EXISTS (`motherID`) REFERENCES `parents` (`ID`);";
                MySqlCommand cmdCreateTable = new MySqlCommand(queryCreateTable, connection);
                cmdCreateTable.ExecuteNonQuery();
                MySqlCommand cmdPrimaryKey = new MySqlCommand(queryPrimaryKey, connection);
                cmdPrimaryKey.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message + "ChildrenFullProfile*******************************************************************************");
                //throw new TableCreateException("Tábla lérehozása sikertelen, vagy már létezik."); !!!! javítani
            }
        }
        /// <summary>
        /// A gyerkekekkel történt események trolására tábla szülőknek
        /// </summary>
        public void createTableEvents()
        {
            connectionString = cs.getConnectionString();
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string queryCreateTable =
                    "CREATE TABLE `children_events` ("
                    +"`ID` int(11) NOT NULL,"
                    +"`title` varchar(30) COLLATE utf8_hungarian_ci DEFAULT NULL,"
                    +"`details` text COLLATE utf8_hungarian_ci DEFAULT NULL,"
                    +"`img` longblob DEFAULT NULL,"
                    +"`by` varchar(20) COLLATE utf8_hungarian_ci DEFAULT NULL"
                    +") ENGINE = InnoDB DEFAULT CHARSET = utf8 COLLATE = utf8_hungarian_ci;";

                string queryPrimaryKey =
                "ALTER TABLE `children_events` "
                +"MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1,"
                + "ADD PRIMARY KEY IF NOT EXISTS (`ID`);";
                MySqlCommand cmdCreateTable = new MySqlCommand(queryCreateTable, connection);
                cmdCreateTable.ExecuteNonQuery();
                MySqlCommand cmdPrimaryKey = new MySqlCommand(queryPrimaryKey, connection);
                cmdPrimaryKey.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message + "Events*******************************************************************************");
                //throw new TableCreateException("Tábla lérehozása sikertelen, vagy már létezik."); !!!! javítani
            }
        }
        /// <summary>
        /// A gyerkekekkel egészségügyi felmérések tárolására tábla
        /// </summary>
        public void createTableHealth()
        {
            connectionString = cs.getConnectionString();
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string queryCreateTable =
                    "CREATE TABLE `children_health` ("
                    +"`boardID` int(11) NOT NULL,"
                    +"`childrenID` int(11) NOT NULL,"
                    +"`type` varchar(20) COLLATE utf8_hungarian_ci DEFAULT NULL,"
                    +"`details` text COLLATE utf8_hungarian_ci DEFAULT NULL,"
                    +"`special_treament` varchar(50) COLLATE utf8_hungarian_ci DEFAULT NULL,"
                    +"`treatdate` date NOT NULL,"
                    +"`by` varchar(30) COLLATE utf8_hungarian_ci DEFAULT NULL"
                    +") ENGINE = InnoDB DEFAULT CHARSET = utf8 COLLATE = utf8_hungarian_ci;";


                string queryPrimaryKey =
                "ALTER TABLE `children_healths` "
                +"ADD PRIMARY KEY IF NOT EXISTS (`ID`),"
                +"MODIFY `boardID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1," 
                + "ADD CONSTRAINT `children_health_ibfk_1` FOREIGN KEY (`childrenID`) REFERENCES `children_fullprofile` (`ID`);";
                MySqlCommand cmdCreateTable = new MySqlCommand(queryCreateTable, connection);
                cmdCreateTable.ExecuteNonQuery();
                MySqlCommand cmdPrimaryKey = new MySqlCommand(queryPrimaryKey, connection);
                cmdPrimaryKey.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message + "Healths*******************************************************************************");
                //throw new TableCreateException("Tábla lérehozása sikertelen, vagy már létezik."); !!!! javítani
            }
        }

        /// <summary>
        /// A szülöket tároló tábla
        /// </summary>
        public void createTableParents()
        {
            connectionString = cs.getConnectionString();
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string queryCreateTable =
                    "CREATE TABLE `parents` ("
                    +"`ID` int(11) NOT NULL,"
                    +"`pname` varchar(40) COLLATE utf8_hungarian_ci DEFAULT NULL,"
                    +"`pmaidenname` varchar(40) COLLATE utf8_hungarian_ci DEFAULT NULL,"
                    +"`pbirth` date DEFAULT NULL,"
                    +"`psex` varchar(10) COLLATE utf8_hungarian_ci DEFAULT NULL,"
                    +"`pidcardnumber` varchar(10) COLLATE utf8_hungarian_ci DEFAULT NULL,"
                    +"`loginpermission` tinyint(1) NOT NULL,"
                    +"`loginuser` varchar(25) COLLATE utf8_hungarian_ci NOT NULL,"
                    +"`loginpsw` varchar(25) COLLATE utf8_hungarian_ci NOT NULL"
                    +") ENGINE = InnoDB DEFAULT CHARSET = utf8 COLLATE = utf8_hungarian_ci;";

                string queryPrimaryKey =
                //primary kulcs
                "ALTER TABLE `parents` " +
                "ADD PRIMARY KEY IF NOT EXISTS (`ID`);" +
                //autoincrement
                "ALTER TABLE `parents`" +
                "MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1;";
                MySqlCommand cmdCreateTable = new MySqlCommand(queryCreateTable, connection);
                cmdCreateTable.ExecuteNonQuery();
                MySqlCommand cmdPrimaryKey = new MySqlCommand(queryPrimaryKey, connection);
                cmdPrimaryKey.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message + "Parents*******************************************************************************");
                //throw new TableCreateException("Tábla lérehozása sikertelen, vagy már létezik."); !!!! javítani
            }
        }

        /// <summary>
        /// Iskolák tárolása adatbázisban
        /// </summary>
        public void createTableSchool()
        {
            connectionString = cs.getConnectionString();
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string queryCreateTable =
                    "CREATE TABLE `school` ("
                    +"`ID` int(11) NOT NULL,"
                    +"`schoolName` varchar(80) COLLATE utf8_hungarian_ci DEFAULT NULL,"
                    +"`schoolLocation` varchar(40) COLLATE utf8_hungarian_ci DEFAULT NULL,"
                    +"`schoolPhone` varchar(14) COLLATE utf8_hungarian_ci DEFAULT NULL"
                    +") ENGINE = InnoDB DEFAULT CHARSET = utf8 COLLATE = utf8_hungarian_ci;";

                string queryPrimaryKey =
                //primary kulcs
                "ALTER TABLE `children_school` " +
                "ADD PRIMARY KEY IF NOT EXISTS(`ID`);" +
                //autoincrement
                "ALTER TABLE `children_school`" +
                " MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;";



                MySqlCommand cmdCreateTable = new MySqlCommand(queryCreateTable, connection);
                cmdCreateTable.ExecuteNonQuery();
                MySqlCommand cmdPrimaryKey = new MySqlCommand(queryPrimaryKey, connection);
                cmdPrimaryKey.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message + "School*******************************************************************************");
                //throw new TableCreateException("Tábla lérehozása sikertelen, vagy már létezik."); !!!! javítani
            }
        }
        //********************************* Kapcsolótáblák ***************************************************

        /// <summary>
        /// Gyerek iskolákkal összekapcsolása, erre tábla
        /// </summary>
        public void createTableChildrenSchool()
        {
            connectionString = cs.getConnectionString();
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string queryCreateTable =
                    "CREATE TABLE `children_school` ("
                    + "`schoolID` int(11) NOT NULL,"
                    + "`childrenID` int(11) NOT NULL,"
                    + "`fromDate` date DEFAULT NULL,"
                    + "`expectedFinish` date DEFAULT NULL,"
                    + "`type` varchar(25) COLLATE utf8_hungarian_ci DEFAULT NULL,"
                    + "`headteacher` varchar(50) COLLATE utf8_hungarian_ci NOT NULL"
                    + ") ENGINE = InnoDB DEFAULT CHARSET = utf8 COLLATE = utf8_hungarian_ci;";


                string queryPrimaryKey =
                //
                "ALTER TABLE `children_school` " +
                "ADD PRIMARY KEY IF NOT EXISTS(`ID`);" +
                //
                "ALTER TABLE `children_school` " +
                "MODIFY `schoolID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1;" +
                //
                "ALTER TABLE `children_school` " +
                "ADD CONSTRAINT `children_school_ibfk_1` FOREIGN KEY (`schoolID`) REFERENCES `school` (`ID`)," +
                "ADD CONSTRAINT `children_school_ibfk_2` FOREIGN KEY(`childrenID`) REFERENCES `children_fullprofile` (`ID`);";
                MySqlCommand cmdCreateTable = new MySqlCommand(queryCreateTable, connection);
                cmdCreateTable.ExecuteNonQuery();
                MySqlCommand cmdPrimaryKey = new MySqlCommand(queryPrimaryKey, connection);
                cmdPrimaryKey.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message + "School*******************************************************************************");
                //throw new TableCreateException("Tábla lérehozása sikertelen, vagy már létezik."); !!!! javítani
            }
        }

        /// <summary>
        /// Kapcsoló tábla a children_fullprofile és a children_events között 
        /// </summary>
        public void createTableEventsK()
        {
            connectionString = cs.getConnectionString();
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string queryCreateTable =
                    "CREATE TABLE IF NOT EXISTS `ceventsk` ("
                    + "`ID` int(11) NOT NULL,"
                    + "`childrenID` int(11) DEFAULT NULL,"
                    + "`eventsID` int(11) DEFAULT NULL,"
                    + "`timer` date DEFAULT NULL"
                    + ") ENGINE = InnoDB DEFAULT CHARSET = utf8 COLLATE = utf8_hungarian_ci;";

                string queryPrimaryKey =
                "ALTER TABLE `ceventsk` ADD PRIMARY KEY IF NOT EXISTS (`ID`);"
                + "ALTER TABLE `ceventsk`"
                + "ADD CONSTRAINT `ceventsk_ibfk_1` FOREIGN KEY IF NOT EXISTS (`childrenID`) REFERENCES `children_fullprofile` (`ID`),"
                + "ADD CONSTRAINT `ceventsk_ibfk_2` FOREIGN KEY IF NOT EXISTS (`eventsID`) REFERENCES `children_events` (`ID`);";


                MySqlCommand cmdCreateTable = new MySqlCommand(queryCreateTable, connection);
                cmdCreateTable.ExecuteNonQuery();
                MySqlCommand cmdPrimaryKey = new MySqlCommand(queryPrimaryKey, connection);
                cmdPrimaryKey.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message + "EventsK*******************************************************************************");
                //throw new TableCreateException("Tábla lérehozása sikertelen, vagy már létezik."); !!!! javítani
            }
        }
        
        
    }
}
