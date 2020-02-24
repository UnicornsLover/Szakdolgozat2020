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
        /// <summary>
        /// Bejelenkezés adatok feltöltése
        /// </summary>
        public void fillTestUsers()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query =
                    "INSERT INTO `employes_login` (`ID`, `ename`, `emaidenname`, `esex`, `ebirth`, `ebirthplace`, `ejob`, `elocation`, `euname`, `epassword`) VALUES"
                    + "(1, 'Bálint István', '-', 0, '1999-09-12', 'Székesfehérvár', 'boss', 'Szeged', 'bisti', 'admin'),"
                    + "(2, 'Chat Elek', '-', 0, '1985-03-14', 'Facebook', 'nevelo', 'Szeged', 'chaele', 'nevelo1'),"
                    + "(3, 'Zuhany Rózsa', 'Zuhany Rózsa', 1, '1963-11-08', 'Zalakaros', 'intvezeto', 'Szeged', 'zuhroz', 'intv1'),"
                    + "(4, ' Fejet Lenke ', ' Fejet Lenke ', 1, '1977-02-21', 'Fejes', 'intugyintezo', 'Szeged', 'fejlen', 'intu1'),"
                    + "(5, 'Major Anna ', 'Kiss Anna ', 1, '1972-09-12', 'Fűszerpor', 'pszichologus', 'Kína', 'majann', 'lelek1');";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message+"InsertEmployes*****************************************************************************");
                //throw new InsertUsersException("Nem lehetet a teszt felhasználokat beszúrni!");
            }
        }
        /// <summary>
        /// Teszt Szülők beszúrása a táblába
        /// </summary>
        public void fillTestParents()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query =
                    "INSERT INTO `parents` (`ID`, `pname`, `pmaidenname`, `pbirth`, `psex`, `pidcardnumber`, `loginpermission`, `loginuser`, `loginpsw`) VALUES"
                    +"(1, 'Szabó István', '-', '1994-05-17', '0', ' 153678AS', 1, 'szaist', 'szaist01'),"
                    +"(2, 'Nagy Viola', 'Nagy Viola', '1996-07-21', '1', '784253QW', 1, 'nagvio', 'nagvio01'),"
                    +"(3, 'Tóth József', '-', '1977-05-17', '0', '785693DF', 0, 'totjoz', 'totjoz01'),"
                    +"(4, 'Tóthné Bene Aranka', 'Bene Aranka', '1979-01-02', '1', '789566YX', 1, 'totben', 'totben01'),"
                    +"(5, 'Okos Anna', 'Okos Anna', '1985-11-24', '1', '123586VB', 0, '-', '-'),"
                    +"(6, 'Kiss Elemér', '-', '1984-07-02', '0', '7854445OP', 0, '-', '-');";


                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message+ "InsertParents*******************************************************************************");
            }
        }
         /// <summary>
         /// Teszt gyerkek beszúrása a táblába
         /// </summary>
        public void fillTestChildren()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query =
                    "INSERT INTO `children_fullprofile` (`ID`, `cname`, `csex`, `cidcardnuumber`, `ctajnumber`, `cbirth`, `cbirthplace`, `ccoming`, `clocation`) VALUES"
                    + "(1, 'Szabó Péter', '0', '785962LO', '789963365', '2005-12-04', 'Szeged', '2008-06-01', 'Szeged'),"
                    + "(2, 'Tótk Luca', '1', '788522CV', '780120412', '1995-07-29', 'Budapest', '2011-11-01', 'Szeged');";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message + "InsertChildren*******************************************************************************");
            }
        }
        /// <summary>
        /// Teszt gyerkek iskolai jogviszonyuk beszúrása
        /// </summary>
        public void fillTestSchoolsk()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query =
                    "INSERT INTO `children_school` (`ID`,`schoolID`, `childrenID`, `fromDate`, `expectedFinish`, `type`, `headteacher`) VALUES"
                    + "(1,1, 2, '2001-09-01', '2009-07-15', 'Általános', 'Szabó Emese'),"
                    +"(2,2, 2, '2009-09-01', '2013-07-31', 'Biólogia és Kémia szak', 'Tóth Attila'),"
                    +"(3,3, 2, '2013-09-01', '2018-05-31', 'Orvosi', '-'),"
                    +"(4,4, 1, '2011-09-01', '2019-07-15', 'Általános', 'Király Attila'),"
                    +"(5,5, 1, '2019-09-01', '2023-05-31', 'Informatikai', 'Forgó Gábor');";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message + "InsertSchoolK*******************************************************************************");
            }
        }

        /// <summary>
        /// Egészségügyi teszt adatok feltöltése a táblába
        /// </summary>
        public void fillTestHealths()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query =
                   "INSERT INTO `children_healths` (`boardID`, `childrenID`, `type`, `details`, `special_treament`, `treatdate`, `by`) VALUES"
                   +"(1, 2, 'Diszlekszia', 'Nehézkes a szövegértése hangos olvasása  mellett, ha magában többször elolvassa akkor meg is tudja érteni. A helyesírásnál nem érti a ragozást. Betűket kever össze.', 'Korepetálás, gyakorlás. Felmentés helyesírás alól.', '2011-12-18', 'Major Anna'),"
                   +"(2, 2, 'Szemvizsgálat', 'A látása rossz távolra. Szemtengely ferdülése van, vagyis egyik szeme jobb mint a másik.', 'Szemüveg beszerzése.', '2013-06-13', 'Dr. Marton József'),"
                   +"(3, 1, 'SNI', 'Nehézen lehet a figyelmét lekötni, inkább a saját útját járja. Ezzel rendszeresen zavarva a társait. Tanulás folyamata sokkal lassan mit vele egy körű társaihoz hasonlítva. Ezért kivonja magát ebből.', 'Speciális oda figyelés, figyelem fejlesztés.', '2008-08-15', 'Major Anna');";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message + "InsertHealths*******************************************************************************");
            }
        }

        /// <summary>
        /// Teszt történtek a gyerkekkel adatainak feltöltése a táblába
        /// </summary>
        public void fillTestEvents()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query =
                   "INSERT INTO `children_events` (`ID`, `title`, `details`, `img`, `by`) VALUES"
                   + "(1, 'Kirándulás a mecsekben', 'Osztálykiránduláson vett részt Aranka. Ez 3 napos volt. De nagyon sok mindent mesélt. Például most már a gomba fajtákat is meg tudja különböztetni.', NULL, 'Chat Elek'),"
                   + "(2, 'Strand a Balatonon', 'Az intézmény szervezése által jutott el a Balatonra, amit nagyon élvezett mert nem volt még Balatonon. Vizibicklizés volt.', NULL, 'Chat Elek');";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message + "InsertEvents******************************************************************************");
            }
        }
        //********************************* Kapcsolótáblák ***************************************************
        /// <summary>
        /// Kapcsólótábla a gyerek és a történtek között
        /// </summary>
        public void fillTestEventsK()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query =
                   "INSERT INTO `ceventsk` (`ID`, `childrenID`, `eventsID`, `Timer`) VALUES"
                   + "(1, 1, 2, '2009-09-15'),"
                   + "(2, 2, 1, '2012-08-23');";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message + "InsertEventsK*******************************************************************************");
            }
        }
        /// <summary>
        /// Kapcsólótábla a gyerek és a szülő között
        /// </summary>
        public void fillTestParentsK()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query =
                  "INSERT INTO `parentsk` (`ID`, `pID`, `childrenID`) VALUES"
                    +"(1, 3, 2),"
                    +"(2, 4, 2),"
                    +"(3, 2, 1),"
                    +"(4, 1, 1),"
                    +"(5, 5, 2),"
                    +"(6, 6, 1); ";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message + "InsertParentsK*******************************************************************************");
            }
        }
        /// <summary>
        /// Kapcsólótábla a gyerek és a suli között
        /// </summary>
        public void fillTestShool()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query =
                  "INSERT INTO `school` (`ID`, `schoolName`, `schoolLocation`, `schoolPhone`) VALUES"
                  +"(1, 'Kecskeméti Református Általános Sikola', 'Kecskemét', '0676895214'),"
                  +"(2, 'Kecskeméti Református Gimnázium', 'Kecskemét', '0676895123'),"
                  +"(3, 'Károli Gáspár Református Egyetem', 'Budapest', '0676478956'),"
                  +"(4, 'Kossuth Lajos Általános Iskola', 'Szeged', '0676332112'),"
                  +"(5, 'SZSZC Vasvári Pál Gazdasági és Informatikai Szakgimnáziuma', 'Szeged', '0676852225');";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message + "InsertParentsK*******************************************************************************");
            }
        }

    }
}
