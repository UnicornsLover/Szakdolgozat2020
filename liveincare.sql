-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2020. Ápr 09. 15:29
-- Kiszolgáló verziója: 10.4.11-MariaDB
-- PHP verzió: 7.4.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `liveincare`
--
CREATE DATABASE IF NOT EXISTS `liveincare` DEFAULT CHARACTER SET utf8 COLLATE utf8_hungarian_ci;
USE `liveincare`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `ceventsk`
--

CREATE TABLE `ceventsk` (
  `ID` int(11) NOT NULL,
  `childrenID` int(11) DEFAULT NULL,
  `eventsID` int(11) DEFAULT NULL,
  `timer` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `ceventsk`
--

INSERT INTO `ceventsk` (`ID`, `childrenID`, `eventsID`, `timer`) VALUES
(1, 1, 1, '2009-09-15'),
(2, 2, 2, '2012-11-01'),
(3, 1, 3, '2016-08-23'),
(4, 2, 4, '2019-11-15'),
(5, 3, 5, '2020-01-26');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `children_events`
--

CREATE TABLE `children_events` (
  `ID` int(11) NOT NULL,
  `title` varchar(30) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `details` text COLLATE utf8_hungarian_ci DEFAULT NULL,
  `img` longblob DEFAULT NULL,
  `by` varchar(20) COLLATE utf8_hungarian_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `children_events`
--

INSERT INTO `children_events` (`ID`, `title`, `details`, `img`, `by`) VALUES
(1, 'Kirándulás a mecsekben', 'Osztálykiránduláson vett részt Aranka. Ez 3 napos volt. De nagyon sok mindent mesélt. Például most már a gomba fajtákat is meg tudja különböztetni.', NULL, 'Chat Elek'),
(2, 'Strand a Balatonon', 'Az intézmény szervezése által jutott el a Balatonra, amit nagyon élvezett mert nem volt még Balatonon. Vizibicklizés volt.', NULL, 'Chat Elek'),
(3, 'Meglátogatni az állatkertet', 'Az állatok és növényeket ismert meg. Egy két állatot meg is lehetet simogatni. Volt kis nai állatoknak és pár állatnak bből tudtt is adni. Nagyon örült a lehetőségnek utólag. is', NULL, 'Chat Elek'),
(4, 'Skyland ugráló', 'Itt egy olyan helység volt, ahol minden fele ugrálhatak a gyerkek trambulinok segítségével. Nagyon élvezte és majd nem 2 órát is voltunk. Különböző feladatokat kellettt ott teljesíteni. Lelekes volt végig', NULL, 'Chat Elek'),
(5, 'Írány a kalandparkba', 'A kalandparkba különböző magasságokban próbálhata ki magát a gyerköc. Nagyon élvezte. És voltk erőléti és logikai játékok is  a levgőben. Ő a logikait jobban szerette.', NULL, 'Chat Elek'),
(6, 'Tropicarium, állat nézegetés', 'Különbüző hüllőket tudott ott megnézbi. Neki különösen a gekó tetszett. Ha lehetet volna minden állatból visz haza egyet.', NULL, 'Chat Elek');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `children_fullprofile`
--

CREATE TABLE `children_fullprofile` (
  `ID` int(11) NOT NULL,
  `cname` varchar(50) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `csex` varchar(10) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `cidcardnumber` varchar(10) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `ctajnumber` varchar(10) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `cbirth` date DEFAULT NULL,
  `cbirthplace` varchar(40) COLLATE utf8_hungarian_ci NOT NULL,
  `ccoming` date DEFAULT NULL,
  `clocation` varchar(40) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `children_fullprofile`
--

INSERT INTO `children_fullprofile` (`ID`, `cname`, `csex`, `cidcardnumber`, `ctajnumber`, `cbirth`, `cbirthplace`, `ccoming`, `clocation`) VALUES
(1, 'Szabó Péter', 'férfi', '785962LO', '789963365', '2005-12-04', 'Szeged', '2008-06-01', 'Szeged'),
(2, 'Tóth Luca', 'nő', '788522CV', '780120412', '1995-07-29', 'Budapest', '2011-11-01', 'Szeged'),
(3, 'Szabó István', 'férfi', '147852DF', '785236941', '2007-07-26', 'Kecskemét', '2012-12-01', 'Kecskemét'),
(4, 'Nagy Irma', 'nő', '124578NM', '120125478', '1999-07-12', 'Szeged', '2004-12-01', 'Szeged'),
(5, 'Horváth Eperke', 'nő', '175415KL', '120125169', '1999-12-31', 'Kecskemét', '2001-01-01', 'Kecskemét'),
(6, 'Almos Adrienn', 'nő', '123568MN', '1205470123', '2002-03-24', 'Orosháza', '2004-05-01', 'Szeged');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `children_healths`
--

CREATE TABLE `children_healths` (
  `boardID` int(11) NOT NULL,
  `childrenID` int(11) NOT NULL,
  `type` varchar(20) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `details` text COLLATE utf8_hungarian_ci DEFAULT NULL,
  `special_treatment` varchar(50) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `treatdate` date NOT NULL,
  `by` varchar(30) COLLATE utf8_hungarian_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `children_healths`
--

INSERT INTO `children_healths` (`boardID`, `childrenID`, `type`, `details`, `special_treatment`, `treatdate`, `by`) VALUES
(1, 2, 'Diszlekszia', 'Nehézkes a szövegértése hangos olvasása  mellett, ha magában többször elolvassa akkor meg is tudja érteni. A helyesírásnál nem érti a ragozást. Betűket kever össze.', 'Korepetálás, gyakorlás. Felmentés helyesírás alól.', '2011-12-18', 'Major Anna'),
(2, 2, 'Szemvizsgálat', 'A látása rossz távolra. Szemtengely ferdülése van, vagyis egyik szeme jobb mint a másik.', 'Szemüveg beszerzése.', '2013-06-13', 'Dr. Marton József'),
(3, 1, 'SNI', 'Nehézen lehet a figyelmét lekötni, inkább a saját útját járja. Ezzel rendszeresen zavarva a társait. Tanulás folyamata sokkal lassan mit vele egy körű társaihoz hasonlítva. Ezért kivonja magát ebből.', 'Speciális oda figyelés, figyelem fejlesztés.', '2008-08-15', 'Major Anna');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `children_school`
--

CREATE TABLE `children_school` (
  `ID` int(11) NOT NULL,
  `schoolID` int(11) NOT NULL,
  `childrenID` int(11) NOT NULL,
  `fromDate` date DEFAULT NULL,
  `expectedFinish` date DEFAULT NULL,
  `type` varchar(25) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `headteacher` varchar(50) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `children_school`
--

INSERT INTO `children_school` (`ID`, `schoolID`, `childrenID`, `fromDate`, `expectedFinish`, `type`, `headteacher`) VALUES
(1, 1, 2, '2001-09-01', '2009-07-15', 'Általános Iskola', 'Szabó Emese'),
(2, 2, 2, '2009-09-01', '2013-07-31', 'Gimnázium', 'Tóth Attila'),
(3, 3, 2, '2013-09-01', '2018-05-31', 'Egyetem', '-'),
(4, 4, 1, '2011-09-01', '2019-07-15', 'Általános', 'Király Attila'),
(5, 5, 1, '2019-09-01', '2023-05-31', 'OKJ', 'Forgó Gábor');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `employes_login`
--

CREATE TABLE `employes_login` (
  `ID` int(11) NOT NULL,
  `ename` varchar(50) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `emaidenname` varchar(50) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `esex` varchar(10) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `ebirth` date DEFAULT NULL,
  `ebirthplace` varchar(40) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `ejob` varchar(18) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `elocation` varchar(25) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `idcard` varchar(10) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `euname` varchar(25) COLLATE utf8_hungarian_ci NOT NULL,
  `epassword` varchar(25) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `employes_login`
--

INSERT INTO `employes_login` (`ID`, `ename`, `emaidenname`, `esex`, `ebirth`, `ebirthplace`, `ejob`, `elocation`, `idcard`, `euname`, `epassword`) VALUES
(1, 'Bálint István', '-', 'férfi', '1999-09-12', 'Székesfehérvár', 'Rendszergazda', 'Kiskunmajsa, Kovács Béla ', '120123AA', 'bisti', 'admin'),
(2, 'Chat Elek', '-', 'férfi', '1985-03-14', 'Facebook', 'Nevelő', 'Szeged, Kiss Ödön út 1.', '121345AB', 'chaele', 'nevelo1'),
(3, 'Zuhany Rózsa', 'Zuhany Rózsa', 'nő', '1963-11-08', 'Zalakaros', 'Intézményvezető', 'Lajosmizse, Alma körút 45', '124543AC', 'zuhroz', 'intv1'),
(4, 'Fejet Lenke ', 'Fejet Lenke ', 'nő', '1977-02-21', 'Fejes', 'Ügyintéző', 'Szeged, Rózsa utca 112.', '345231XC', 'fejlen', 'intu1'),
(5, 'Major Anna ', 'Kiss Anna ', 'nő', '1972-09-12', 'Fűszerpor', 'Pszichológus', 'Tókió, Humululu Street 43', '200123VB', 'majann', 'lelek1'),
(6, 'Szántó Tamás', '-', 'nő', '1998-06-10', 'Szeged', 'Pszichológus', 'Vásárhely, Csillag tér 1/', '250123AS', 'szantam', 'abc123'),
(7, 'Rózsa István', '-', 'férfi', '1998-12-21', 'Szeged', 'Intézményvezető', 'Szeged, Alajos utca 32.', '345200QW', 'rozist', 'qwe123'),
(8, 'Horváth Gellért', '-', 'férfi', '1995-02-12', 'Kalocsa', 'Nevelő', 'Kalocsa, Himzes út 54.', '670120FG', 'horgel', 'nev1'),
(9, 'Bálint Sára', 'Bálint Sára', 'nő', '1995-04-22', 'Székesfehérvár', 'Nevelő', 'Szeged, Anya utca 13.', '420123NM', 'balsar', 'tzu123'),
(10, 'Kovács Zsolt', '-', 'férfi', '1976-12-01', 'Győr', 'Ügyintéző', 'Kecskemét, Diósgyőr utca ', '567800PL', 'kovzso', 'fgh123');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `parents`
--

CREATE TABLE `parents` (
  `ID` int(11) NOT NULL,
  `pname` varchar(40) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `pbirth` date DEFAULT NULL,
  `psex` varchar(10) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `pidcardnumber` varchar(10) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `loginpermission` tinyint(1) DEFAULT 0,
  `loginuser` varchar(25) COLLATE utf8_hungarian_ci NOT NULL,
  `loginpsw` varchar(25) COLLATE utf8_hungarian_ci NOT NULL,
  `reg` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `parents`
--

INSERT INTO `parents` (`ID`, `pname`, `pbirth`, `psex`, `pidcardnumber`, `loginpermission`, `loginuser`, `loginpsw`, `reg`) VALUES
(1, 'Szabó István', '1994-05-17', 'férfi', '153678AS', 1, 'szaist', 'szaist01', 1),
(2, 'Nagy Viola', '1996-07-21', 'nő', '784253QW', 1, 'nagvio', 'nagvio01', 0),
(3, 'Tóth József', '1977-05-17', 'férfi', '785693DF', 0, 'totjoz', 'totjoz01', 0),
(4, 'Tóthné Bene Aranka', '1979-01-02', 'nő', '789566YX', 1, 'totben', 'totben01', 1),
(5, 'Okos Anna', '1985-11-24', 'nő', '123586VB', 1, 'okoann', 'abc123', 0),
(6, 'Kiss Elemér', '1984-07-02', 'férfi', '785444OP', 0, 'kisele', 'asd123', 0);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `parentsk`
--

CREATE TABLE `parentsk` (
  `ID` int(11) NOT NULL,
  `pID` int(11) DEFAULT NULL,
  `childrenID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `parentsk`
--

INSERT INTO `parentsk` (`ID`, `pID`, `childrenID`) VALUES
(1, 3, 2),
(2, 4, 2),
(3, 1, 3),
(4, 2, 3),
(5, 2, 1),
(6, 1, 1);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `school`
--

CREATE TABLE `school` (
  `ID` int(11) NOT NULL,
  `schoolName` varchar(80) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `schoolLocation` varchar(40) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `schoolPhone` varchar(14) COLLATE utf8_hungarian_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `school`
--

INSERT INTO `school` (`ID`, `schoolName`, `schoolLocation`, `schoolPhone`) VALUES
(1, 'Kecskeméti Református Általános Iskola', 'Kecskemét', '0676895214'),
(2, 'Kecskeméti Református Gimnázium', 'Kecskemét', '0676895123'),
(3, 'Károli Gáspár Református Egyetem', 'Budapest', '0676478956'),
(4, 'Kossuth Lajos Általános Iskola', 'Szeged', '0676332112'),
(5, 'SZSZC Vasvári Pál Gazdasági és Informatikai Szakgimnáziuma', 'Szeged', '0676852225');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `ceventsk`
--
ALTER TABLE `ceventsk`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `ID` (`ID`),
  ADD UNIQUE KEY `ID_2` (`ID`),
  ADD KEY `ceventsk_ibfk_1` (`childrenID`),
  ADD KEY `ceventsk_ibfk_2` (`eventsID`);

--
-- A tábla indexei `children_events`
--
ALTER TABLE `children_events`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `ID` (`ID`),
  ADD UNIQUE KEY `ID_2` (`ID`),
  ADD UNIQUE KEY `title` (`title`),
  ADD UNIQUE KEY `title_2` (`title`);

--
-- A tábla indexei `children_fullprofile`
--
ALTER TABLE `children_fullprofile`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `ID` (`ID`),
  ADD UNIQUE KEY `ID_2` (`ID`),
  ADD UNIQUE KEY `cidcardnumber` (`cidcardnumber`,`ctajnumber`),
  ADD UNIQUE KEY `cidcardnumber_2` (`cidcardnumber`,`ctajnumber`);

--
-- A tábla indexei `children_healths`
--
ALTER TABLE `children_healths`
  ADD PRIMARY KEY (`boardID`),
  ADD UNIQUE KEY `boardID` (`boardID`),
  ADD UNIQUE KEY `boardID_2` (`boardID`),
  ADD KEY `children_health_ibfk_1` (`childrenID`);

--
-- A tábla indexei `children_school`
--
ALTER TABLE `children_school`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `ID` (`ID`),
  ADD UNIQUE KEY `ID_2` (`ID`),
  ADD KEY `children_school_ibfk_1` (`schoolID`),
  ADD KEY `children_school_ibfk_2` (`childrenID`);

--
-- A tábla indexei `employes_login`
--
ALTER TABLE `employes_login`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `ID` (`ID`),
  ADD UNIQUE KEY `ID_2` (`ID`),
  ADD UNIQUE KEY `idcard` (`idcard`),
  ADD UNIQUE KEY `idcard_2` (`idcard`);

--
-- A tábla indexei `parents`
--
ALTER TABLE `parents`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `ID` (`ID`),
  ADD UNIQUE KEY `ID_2` (`ID`),
  ADD UNIQUE KEY `pidcardnumber` (`pidcardnumber`),
  ADD UNIQUE KEY `pidcardnumber_2` (`pidcardnumber`);

--
-- A tábla indexei `parentsk`
--
ALTER TABLE `parentsk`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `ID` (`ID`),
  ADD UNIQUE KEY `ID_2` (`ID`),
  ADD KEY `parentsk_ibfk_1` (`childrenID`),
  ADD KEY `parentsk_ibfk_2` (`pID`);

--
-- A tábla indexei `school`
--
ALTER TABLE `school`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `ID` (`ID`),
  ADD UNIQUE KEY `ID_2` (`ID`),
  ADD UNIQUE KEY `schoolName` (`schoolName`),
  ADD UNIQUE KEY `schoolName_2` (`schoolName`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `ceventsk`
--
ALTER TABLE `ceventsk`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT a táblához `children_events`
--
ALTER TABLE `children_events`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT a táblához `children_fullprofile`
--
ALTER TABLE `children_fullprofile`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT a táblához `children_healths`
--
ALTER TABLE `children_healths`
  MODIFY `boardID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT a táblához `children_school`
--
ALTER TABLE `children_school`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT a táblához `employes_login`
--
ALTER TABLE `employes_login`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT a táblához `parents`
--
ALTER TABLE `parents`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT a táblához `parentsk`
--
ALTER TABLE `parentsk`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT a táblához `school`
--
ALTER TABLE `school`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `ceventsk`
--
ALTER TABLE `ceventsk`
  ADD CONSTRAINT `ceventsk_ibfk_1` FOREIGN KEY (`childrenID`) REFERENCES `children_fullprofile` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ceventsk_ibfk_2` FOREIGN KEY (`eventsID`) REFERENCES `children_events` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Megkötések a táblához `children_healths`
--
ALTER TABLE `children_healths`
  ADD CONSTRAINT `children_health_ibfk_1` FOREIGN KEY (`childrenID`) REFERENCES `children_fullprofile` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Megkötések a táblához `children_school`
--
ALTER TABLE `children_school`
  ADD CONSTRAINT `children_school_ibfk_1` FOREIGN KEY (`schoolID`) REFERENCES `school` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `children_school_ibfk_2` FOREIGN KEY (`childrenID`) REFERENCES `children_fullprofile` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Megkötések a táblához `parentsk`
--
ALTER TABLE `parentsk`
  ADD CONSTRAINT `parentsk_ibfk_1` FOREIGN KEY (`childrenID`) REFERENCES `children_fullprofile` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `parentsk_ibfk_2` FOREIGN KEY (`pID`) REFERENCES `parents` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
