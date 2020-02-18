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
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `ceventsk`
--
ALTER TABLE `ceventsk`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `ceventsk`
--
ALTER TABLE `ceventsk`
  ADD CONSTRAINT `ceventsk_ibfk_2` FOREIGN KEY (`eventsID`) REFERENCES `children_events` (`ID`),
  ADD CONSTRAINT `ceventsk_ibfk_3` FOREIGN KEY (`childrenID`) REFERENCES `children_fullprofile` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
