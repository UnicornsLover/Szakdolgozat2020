-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2020. Feb 18. 11:15
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

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `children_school`
--
ALTER TABLE `children_school`
  ADD PRIMARY KEY (`schoolID`),
  ADD KEY `childrenID` (`childrenID`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `children_school`
--
ALTER TABLE `children_school`
  MODIFY `schoolID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Megkötések a kiírt táblákhoz
--

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
