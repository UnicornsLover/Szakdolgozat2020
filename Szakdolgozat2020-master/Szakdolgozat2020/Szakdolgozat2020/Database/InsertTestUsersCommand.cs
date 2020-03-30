 using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szakdolgozat2020.Modell.Employes;

namespace Szakdolgozat2020.Database
{
    partial class CreateCommand
    {
        /// <summary>
        /// Bejelenkezés adatok feltöltése
        /// </summary>
        public void fillTestUsers()
        {
            Connection cs = new Connection();
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query =
                    "INSERT IGNORE  INTO `employes_login` (`ID`, `ename`, `emaidenname`, `esex`, `ebirth`, `ebirthplace`, `ejob`, `elocation`,`idcard`, `euname`, `epassword`) VALUES"
                    + "(1, 'Bálint István', '-', 'férfi', '1999-09-12', 'Székesfehérvár', 'Rendszergazda', 'Kiskunmajsa, Kovács Béla utca 12.','120123AA', 'bisti', 'admin'),"
                    + "(2, 'Chat Elek', '-', 'férfi', '1985-03-14', 'Facebook', 'Nevelő', 'Szeged, Kiss Ödön út 1.','121345AB', 'chaele', 'nevelo1'),"
                    + "(3, 'Zuhany Rózsa', 'Zuhany Rózsa', 'nő', '1963-11-08', 'Zalakaros', 'Intézményvezető', 'Lajosmizse, Alma körút 456.', '124543AC','zuhroz', 'intv1'),"
                    + "(4, 'Fejet Lenke ', 'Fejet Lenke ', 'nő', '1977-02-21', 'Fejes', 'Ügyintéző', 'Szeged, Rózsa utca 112.', '345231XC','fejlen', 'intu1'),"
                    + "(5, 'Major Anna ', 'Kiss Anna ', 'nő', '1972-09-12', 'Fűszerpor', 'Pszichológus', 'Tókió, Humululu Street 43.', '200123VB','majann', 'lelek1'),"
                    + "(6, 'Szántó Tamás', '-', 'nő', '1998-06-10', 'Szeged', 'Pszichológus', 'Vásárhely, Csillag tér 1/a', '250123AS','szantam', 'abc123'),"
                    + "(7, 'Rózsa István', '-', 'férfi', '1998-12-21', 'Szeged', 'Intézményvezető', 'Szeged, Alajos utca 32.', '345200QW','rozist', 'qwe123'),"
                    + "(8, 'Horváth Gellért', '-', 'férfi', '1995-02-12', 'Kalocsa', 'Nevelő', 'Kalocsa, Himzes út 54.','670120FG', 'horgel', 'nev1'),"
                    + "(9, 'Bálint Sára', 'Bálint Sára', 'nő', '1995-04-22', 'Székesfehérvár', 'Nevelő', 'Szeged, Anya utca 13.','420123NM', 'balsar', 'tzu123'),"
                    + "(10, 'Kovács Zsolt', '-', 'férfi', '1976-12-01', 'Győr', 'Ügyintéző', 'Kecskemét, Diósgyőr utca 45.', '567800PL','kovzso', 'fgh123');";
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
                    "INSERT IGNORE INTO `parents` (`pname`, `pbirth`, `psex`, `pidcardnumber`, `loginpermission`, `loginuser`, `loginpsw`, `reg`) VALUES"
                    + "('Szabó István', '1994-05-17', 'férfi', '153678AS', 1, 'szaist', 'szaist01','1'),"
                    +"('Nagy Viola', '1996-07-21', 'nő', '784253QW', 1, 'nagvio', 'nagvio01','0'),"
                    +"('Tóth József', '1977-05-17', 'férfi', '785693DF', 0, 'totjoz', 'totjoz01','0'),"
                    +"('Tóthné Bene Aranka', '1979-01-02', 'nő', '789566YX', 1, 'totben', 'totben01','1'),"
                    +"('Okos Anna', '1985-11-24', 'nő', '123586VB', 1, 'okoann', 'abc123','0'),"
                    +"('Kiss Elemér', '1984-07-02', 'férfi', '785444OP', 0, 'kisele', 'asd123','0');";


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
                    "INSERT IGNORE INTO `children_fullprofile` (`ID`, `cname`, `csex`, `cidcardnumber`, `ctajnumber`, `cbirth`, `cbirthplace`, `ccoming`, `clocation`) VALUES"
                    + "(1, 'Szabó Péter', 'férfi', '785962LO', '789963365', '2005-12-04', 'Szeged', '2008-06-01', 'Szeged'),"
                    + "(2, 'Tóth Luca', 'nő', '788522CV', '780120412', '1995-07-29', 'Budapest', '2011-11-01', 'Szeged'),"
                    +"(3, 'Erős István', 'férfi', '147852DF', '785236941', '2007-07-26', 'Kecskemét', '2012-12-01', 'Kecskemét'),"
                    +"(4, 'Nagy Irma', 'nő', '124578NM', '120125478', '1999-07-12', 'Szeged', '2004-12-01', 'Szeged'),"
                    +"(5, 'Horváth Eperke', 'nő', '175415KL', '120125169', '1999-12-31', 'Kecskemét', '2001-01-01', 'Kecskemét'),"
                    +"(6, 'Almos Adrienn', 'nő', '123568MN', '1205470123', '2002-03-24', 'Orosháza', '2004-05-01', 'Szeged');";

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
                    "INSERT IGNORE INTO `children_school` (`ID`,`schoolID`, `childrenID`, `fromDate`, `expectedFinish`, `type`, `headteacher`) VALUES"
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
                   "INSERT IGNORE INTO `children_healths` (`boardID`, `childrenID`, `type`, `details`, `special_treatment`, `treatdate`, `by`) VALUES"
                   + "(1, 2, 'Diszlekszia', 'Nehézkes a szövegértése hangos olvasása  mellett, ha magában többször elolvassa akkor meg is tudja érteni. A helyesírásnál nem érti a ragozást. Betűket kever össze.', 'Korepetálás, gyakorlás. Felmentés helyesírás alól.', '2011-12-18', 'Major Anna'),"
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
                   "INSERT IGNORE INTO `children_events` (`ID`, `title`, `details`, `img`, `by`) VALUES"
                   + "(1, 'Kirándulás a mecsekben', 'Osztálykiránduláson vett részt Aranka. Ez 3 napos volt. De nagyon sok mindent mesélt. Például most már a gomba fajtákat is meg tudja különböztetni.', NULL, 'Chat Elek'),"
                   + "(2, 'Strand a Balatonon', 'Az intézmény szervezése által jutott el a Balatonra, amit nagyon élvezett mert nem volt még Balatonon. Vizibicklizés volt.', NULL, 'Chat Elek'),"
                   + "(3,'Meglátogatni az állatkertet', 'Az állatok és növényeket ismert meg. Egy két állatot meg is lehetet simogatni. Volt kis nai állatoknak és pár állatnak bből tudtt is adni. Nagyon örült a lehetőségnek utólag. is', NULL, 'Chat Elek'),"
                   + "(4, 'Skyland ugráló', 'Itt egy olyan helység volt, ahol minden fele ugrálhatak a gyerkek trambulinok segítségével. Nagyon élvezte és majd nem 2 órát is voltunk. Különböző feladatokat kellettt ott teljesíteni. Lelekes volt végig', NULL, 'Chat Elek'),"
                   + "(5, 'Írány a kalandparkba', 'A kalandparkba különböző magasságokban próbálhata ki magát a gyerköc. Nagyon élvezte. És voltk erőléti és logikai játékok is  a levgőben. Ő a logikait jobban szerette.', NULL, 'Chat Elek'),"
                   + "(6, 'Tropicarium, állat nézegetés', 'Különbüző hüllőket tudott ott megnézbi. Neki különösen a gekó tetszett. Ha lehetet volna minden állatból visz haza egyet.', NULL, 'Chat Elek');";

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
                   "INSERT IGNORE INTO `ceventsk` (`ID`, `childrenID`, `eventsID`, `Timer`) VALUES"
                   + "(1, 1, 1, '2009-09-15'),"
                   + "(2, 2, 2, '2012-11-01'),"
                   + "(3, 1, 3, '2016-08-23'),"
                   + "(4, 2, 4, '2019-11-15'),"
                   + "(5, 3, 5, '2020-01-26');";

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
                  "INSERT IGNORE INTO `parentsk` (`ID`, `pID`, `childrenID`) VALUES"
                    + "(1, 3, 2),"
                    +"(2, 4, 2),"
                    + "(3, 1, 3),"
                    + "(4, 2, 3),"
                    + "(5, 2, 1),"
                    +"(6, 1, 1);";

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
                  "INSERT IGNORE INTO `school` (`ID`, `schoolName`, `schoolLocation`, `schoolPhone`) VALUES"
                  + "(1, 'Kecskeméti Református Általános Iskola', 'Kecskemét', '0676895214'),"
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

        public void changePasswordFirstLogIn(string username, string newPassword)
        {
            string connectionString = "SERVER=\"localhost\";DATABASE=\"liveincare\";UID=\"root\";PASSWORD=\"\";PORT=\"3306\";";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "UPDATE `employes_login` SET `epassword` = @epassword WHERE `employes_login`.`ename` = @ename";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@epassword", newPassword);
                cmd.Parameters.AddWithValue("@ename", username);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
