-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2020. Feb 18. 13:06
-- Kiszolgáló verziója: 10.4.6-MariaDB
-- PHP verzió: 7.3.8

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
  `Timer` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `ceventsk`
--

INSERT INTO `ceventsk` (`ID`, `childrenID`, `eventsID`, `Timer`) VALUES
(1, 1, 2, '2009-09-15'),
(2, 2, 1, '2012-08-23');

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
(2, 'Strand a Balatonon', 'Az intézmény szervezése által jutott el a Balatonra, amit nagyon élvezett mert nem volt még Balatonon. Vizibicklizés volt.', NULL, 'Chat Elek');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `children_fullprofile`
--

CREATE TABLE `children_fullprofile` (
  `ID` int(11) NOT NULL,
  `cname` varchar(50) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `csex` varchar(10) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `cidcardnuumber` varchar(10) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `ctajnumber` varchar(10) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `cbirth` date DEFAULT NULL,
  `cbirthplace` varchar(40) COLLATE utf8_hungarian_ci NOT NULL,
  `motherID` int(10) NOT NULL,
  `fatherID` int(10) NOT NULL,
  `ccoming` date DEFAULT NULL,
  `clocation` varchar(40) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `children_fullprofile`
--

INSERT INTO `children_fullprofile` (`ID`, `cname`, `csex`, `cidcardnuumber`, `ctajnumber`, `cbirth`, `cbirthplace`, `motherID`, `fatherID`, `ccoming`, `clocation`) VALUES
(1, 'Szabó Péter', '0', '785962LO', '789963365', '2005-12-04', 'Szeged', 2, 1, '2008-06-01', 'Szeged'),
(2, 'Tótk Luca', '1', '788522CV', '780120412', '1995-07-29', 'Budapest', 4, 3, '2011-11-01', 'Szeged');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `children_health`
--

CREATE TABLE `children_health` (
  `boardID` int(11) NOT NULL,
  `childrenID` int(11) NOT NULL,
  `type` varchar(20) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `details` text COLLATE utf8_hungarian_ci DEFAULT NULL,
  `special_treament` varchar(50) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `treatdate` date NOT NULL,
  `by` varchar(30) COLLATE utf8_hungarian_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `children_health`
--

INSERT INTO `children_health` (`boardID`, `childrenID`, `type`, `details`, `special_treament`, `treatdate`, `by`) VALUES
(1, 2, 'Diszlekszia', 'Nehézkes a szövegértése hangos olvasása  mellett, ha magában többször elolvassa akkor meg is tudja érteni. A helyesírásnál nem érti a ragozást. Betűket kever össze.', 'Korepetálás, gyakorlás. Felmentés helyesírás alól.', '2011-12-18', 'Major Anna'),
(2, 2, 'Szemvizsgálat', 'A látása rossz távolra. Szemtengely ferdülése van, vagyis egyik szeme jobb mint a másik.', 'Szemüveg beszerzése.', '2013-06-13', 'Dr. Marton József'),
(3, 1, 'SNI', 'Nehézen lehet a figyelmét lekötni, inkább a saját útját járja. Ezzel rendszeresen zavarva a társait. Tanulás folyamata sokkal lassan mit vele egy körű társaihoz hasonlítva. Ezért kivonja magát ebből.', 'Speciális oda figyelés, figyelem fejlesztés.', '2008-08-15', 'Major Anna');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `children_school`
--

CREATE TABLE `children_school` (
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

INSERT INTO `children_school` (`schoolID`, `childrenID`, `fromDate`, `expectedFinish`, `type`, `headteacher`) VALUES
(1, 2, '2001-09-01', '2009-07-15', 'Általános', 'Szabó Emese'),
(2, 2, '2009-09-01', '2013-07-31', 'Biólogia és Kémia szak', 'Tóth Attila'),
(3, 2, '2013-09-01', '2018-05-31', 'Orvosi', '-'),
(4, 1, '2011-09-01', '2019-07-15', 'Általános', 'Király Attila'),
(5, 1, '2019-09-01', '2023-05-31', 'Informatikai', 'Forgó Gábor');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `employes_login`
--

CREATE TABLE `employes_login` (
  `ID` int(11) NOT NULL,
  `ename` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `emaidenname` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `esex` tinyint(1) NOT NULL,
  `ebirth` date NOT NULL,
  `ebirthplace` varchar(40) COLLATE utf8_hungarian_ci NOT NULL,
  `ejob` varchar(18) COLLATE utf8_hungarian_ci NOT NULL,
  `elocation` varchar(40) COLLATE utf8_hungarian_ci NOT NULL,
  `euname` varchar(25) COLLATE utf8_hungarian_ci NOT NULL,
  `epassword` varchar(25) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `employes_login`
--

INSERT INTO `employes_login` (`ID`, `ename`, `emaidenname`, `esex`, `ebirth`, `ebirthplace`, `ejob`, `elocation`, `euname`, `epassword`) VALUES
(1, 'Bálint István', '-', 0, '1999-09-12', 'Székesfehérvár', 'boss', 'Szeged', 'bisti', 'admin'),
(2, 'Chat Elek', '-', 0, '1985-03-14', 'Facebook', 'nevelo', 'Szeged', 'chaele', 'nevelo1'),
(3, 'Zuhany Rózsa', 'Zuhany Rózsa', 1, '1963-11-08', 'Zalakaros', 'intvezeto', 'Szeged', 'zuhroz', 'intv1'),
(4, ' Fejet Lenke ', ' Fejet Lenke ', 1, '1977-02-21', 'Fejes', 'intugyintezo', 'Szeged', 'fejlen', 'intu1'),
(5, 'Major Anna ', 'Kiss Anna ', 1, '1972-09-12', 'Fűszerpor', 'pszichologus', 'Kína', 'majann', 'lelek1');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `parents`
--

CREATE TABLE `parents` (
  `ID` int(11) NOT NULL,
  `pname` varchar(40) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `pmaidenname` varchar(40) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `pbirth` date DEFAULT NULL,
  `psex` varchar(10) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `pidcardnumber` varchar(10) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `loginpermission` tinyint(1) NOT NULL,
  `loginuser` varchar(25) COLLATE utf8_hungarian_ci NOT NULL,
  `loginpsw` varchar(25) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `parents`
--

INSERT INTO `parents` (`ID`, `pname`, `pmaidenname`, `pbirth`, `psex`, `pidcardnumber`, `loginpermission`, `loginuser`, `loginpsw`) VALUES
(1, 'Szabó István', '-', '1994-05-17', '0', ' 153678AS', 1, 'szaist', 'szaist01'),
(2, 'Nagy Viola', 'Nagy Viola', '1996-07-21', '1', '784253QW', 1, 'nagvio', 'nagvio01'),
(3, 'Tóth József', '-', '1977-05-17', '0', '785693DF', 0, 'totjoz', 'totjoz01'),
(4, 'Tóthné Bene Aranka', 'Bene Aranka', '1979-01-02', '1', '789566YX', 1, 'totben', 'totben01');

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
(1, 'Kecskeméti Református Általános Iskola', '6000 Kecskemét, Szabadság tér 7.', '0676458796'),
(2, 'Kecskeméti Református Gimnázium', '6000 Kecskemét, Szabadság tér 7.', '0676458144'),
(3, 'Károli Gáspár Református Egyetem', '1091 Budapest, Kálvin tér 9.', '0614559060'),
(4, 'SZTEJKI Kossuth Lajos Általános Iskola', '6771 Szeged, Szerb u. 15.', '0662547134'),
(5, 'SZSZC Vasvári Pál Gazdasági és Informatikai Szakgimnáziuma', 'Szeged, Gutenberg u. 11, 6722', '0662425322');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `ceventsk`
--
ALTER TABLE `ceventsk`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `childrenID` (`childrenID`),
  ADD KEY `eventsID` (`eventsID`);

--
-- A tábla indexei `children_events`
--
ALTER TABLE `children_events`
  ADD PRIMARY KEY (`ID`);

--
-- A tábla indexei `children_fullprofile`
--
ALTER TABLE `children_fullprofile`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `motherID` (`motherID`),
  ADD KEY `fatherID` (`fatherID`);

--
-- A tábla indexei `children_health`
--
ALTER TABLE `children_health`
  ADD PRIMARY KEY (`boardID`),
  ADD KEY `childrenID` (`childrenID`);

--
-- A tábla indexei `children_school`
--
ALTER TABLE `children_school`
  ADD PRIMARY KEY (`schoolID`),
  ADD KEY `childrenID` (`childrenID`);

--
-- A tábla indexei `employes_login`
--
ALTER TABLE `employes_login`
  ADD PRIMARY KEY (`ID`);

--
-- A tábla indexei `parents`
--
ALTER TABLE `parents`
  ADD PRIMARY KEY (`ID`);

--
-- A tábla indexei `school`
--
ALTER TABLE `school`
  ADD PRIMARY KEY (`ID`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `ceventsk`
--
ALTER TABLE `ceventsk`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT a táblához `children_events`
--
ALTER TABLE `children_events`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT a táblához `children_fullprofile`
--
ALTER TABLE `children_fullprofile`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT a táblához `children_health`
--
ALTER TABLE `children_health`
  MODIFY `boardID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT a táblához `children_school`
--
ALTER TABLE `children_school`
  MODIFY `schoolID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT a táblához `employes_login`
--
ALTER TABLE `employes_login`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT a táblához `parents`
--
ALTER TABLE `parents`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

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
  ADD CONSTRAINT `ceventsk_ibfk_2` FOREIGN KEY (`eventsID`) REFERENCES `children_events` (`ID`),
  ADD CONSTRAINT `ceventsk_ibfk_3` FOREIGN KEY (`childrenID`) REFERENCES `children_fullprofile` (`ID`);

--
-- Megkötések a táblához `children_fullprofile`
--
ALTER TABLE `children_fullprofile`
  ADD CONSTRAINT `children_fullprofile_ibfk_1` FOREIGN KEY (`motherID`) REFERENCES `parents` (`ID`),
  ADD CONSTRAINT `children_fullprofile_ibfk_2` FOREIGN KEY (`fatherID`) REFERENCES `parents` (`ID`);

--
-- Megkötések a táblához `children_health`
--
ALTER TABLE `children_health`
  ADD CONSTRAINT `children_health_ibfk_1` FOREIGN KEY (`childrenID`) REFERENCES `children_fullprofile` (`ID`);

--
-- Megkötések a táblához `children_school`
--
ALTER TABLE `children_school`
  ADD CONSTRAINT `children_school_ibfk_1` FOREIGN KEY (`schoolID`) REFERENCES `school` (`ID`),
  ADD CONSTRAINT `children_school_ibfk_2` FOREIGN KEY (`childrenID`) REFERENCES `children_fullprofile` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
