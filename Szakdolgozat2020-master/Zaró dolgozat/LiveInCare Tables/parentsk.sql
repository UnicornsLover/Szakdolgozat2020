-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2020. Feb 24. 18:58
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
(3, 2, 1),
(4, 1, 1),
(5, 5, 2),
(6, 6, 1);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `parentsk`
--
ALTER TABLE `parentsk`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `parentsk_ibfk_1` (`childrenID`),
  ADD KEY `parentsk_ibfk_2` (`pID`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `parentsk`
--
ALTER TABLE `parentsk`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `parentsk`
--
ALTER TABLE `parentsk`
  ADD CONSTRAINT `parentsk_ibfk_1` FOREIGN KEY (`childrenID`) REFERENCES `children_fullprofile` (`ID`),
  ADD CONSTRAINT `parentsk_ibfk_2` FOREIGN KEY (`pID`) REFERENCES `parents` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
