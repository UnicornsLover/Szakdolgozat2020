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
                    "INSERT INTO `employes_login` (`ID`, `ename`, `emaidenname`, `esex`, `ebirth`, `ebirthplace`,`ejob`, `elocation`, `euname`, `epassword`) VALUES" +
                    "(1, 'Bálint István','-','férfi', '1999-09-12','Székesfehérvár', 'boss','Kecskemét', 'bisti', 'admin')," +
                    "(2, 'Chat Elek','-','féfi', '1985-03-14','Kiskunfélegyháza','nevelo','Szeged', 'chaele', 'nevelo1')," +
                    "(3, 'Zuhany Rózsa','Magyar Izbella','nő', '1963-11-08','Budapest','intvezeto','Szeged', 'zuhroz', 'intv1')," +
                    "(4, ' Fejet Lenke ','Fejet Lenke','nő', '1977-02-21','Szárszó','intugyintezo','Orosháza','fejlen', 'intu1')," +
                    "(5, 'Major Anna','Kovács Zita','nő','1972-09-12','Dorozsma','pszichologus','Kőszeg', 'majann', 'lelek1');";
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
                    + "(1, 'Kovács Józsefné', 'Kiss Virág', '1977-12-14', 'nő', '123546RD', 1, 'kovjoz01', 'kovjoz01'),"
                    + "(2, 'Kovács József', '-', '1975-09-24', 'férfi', '741856932', 0, 'kovjoz02', 'kovjoz02'),"
                    + "(3, 'Szabó Béla', '-', '1989-06-12', 'férfi', '147326VB', 1, 'szabel01', 'szabel01'),"
                    + "(4, 'Orosz Anna', 'Orosz Anna', '1991-03-14', 'nő', '145236YX', 1, 'oroann01', 'oroann01');";

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
                    "INSERT INTO `children_fullprofile` (`ID`, `cname`, `csex`, `cidcardnumber`, `ctajnumber`, `cbirth`, `cbirthplace`, `motherID`, `fatherID`, `ccomingin`, `clocation`) VALUES"
                    + "(1, 'Kovács Zsolt', 'férfi', '147962QW', '74258968', '2012-01-02', 'Szeged', 1, 2, '2017-03-01', 'Szeged'),"
                    + "(2, 'Szabó Aranka', 'nő', '789412RT', '895741256', '2003-12-01', 'Kecskemét', 4, 3, '2007-07-01', 'Szeged');";


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
        public void fillTestSchools()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query =
                    "INSERT INTO `children_school` (`ID`, `childrenID`, `schoolname`, `fromdate`, `todate`, `headteacher`,`by`) VALUES"
                    + "(1, 2, 'Vasvári Pál Szakgimnázium OKJ (szoftvetfejlesztő)', '2018-09-01', '2020-06-30', 'Kiss Balázs','Chat Elek'),"
                    + "(2, 1, 'Kecskeméti Református Általános Iskola (2. osztály)', '2018-09-01', '2026-07-15', 'Kiss Gabriella','Chat Elek');";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message + "InsertSchool*******************************************************************************");
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
                   "INSERT INTO `children_healths` (`ID`, `type`, `details`, `special_treament`, `treatdate`, `by`) VALUES"
                   + "(1, 'SNI', 'Nehézen lehet a figyelmét lekötni, inkább a saját útját járja. Ezzel rendszeresen zavarva a társait. Tanulás folyamata sokkal lassan mit vele egy körű társaihoz hasonlítva. Ezért kivonja magát ebből.', 'Speciális oda figyelés, figyelem fejlesztés.', '2017-03-12', 'Major Anna'),"
                   + "(2, 'Dyslexia', 'Nehézkes a szövegértése hangos olvasása  mellett, ha magában többször elolvassa akkor meg is tudja érteni. A helyesírásnál nem érti a ragozást. Betűket kever össze.', 'Korepetálás, gyakorlás. Felmentés magyarból.', '2017-07-09', 'Major Anna '),"
                   + "(3, 'Szemvizsgálat', 'A látása rossz távolra. Szemtengely ferdülése van, vagyis egyik szeme jobb mint a másik. ', 'Szemüveg beszerzése.', '2018-11-01', 'Dr. Tóth Eszter');";

                ;
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
                Debug.WriteLine(e.Message + "InsertEvents*******************************************************************************");
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
                   "INSERT INTO `ceventsk` (`ID`, `childrenID`, `eventsID`, `timer`) VALUES"
                   + "(1, 2, 1, '2018-05-11'),"
                   + "(2, 1, 2, '2018-06-19');";

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
        /// Kapcolótábla a gyerk és egészségügyi állapota között
        /// </summary>
        public void fillTestHealthsK()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query =
                   "INSERT INTO `chealthsk` (`ID`, `childrenID`, `healthID`) VALUES"
                   + "(1, 1, 1),"
                   + "(2, 2, 2),"
                   + "(3, 2, 3);";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message + "InsertHealthsK*******************************************************************************");
            }
        }
    }
}
