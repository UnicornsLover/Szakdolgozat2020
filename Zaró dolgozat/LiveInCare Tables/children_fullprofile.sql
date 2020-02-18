-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2020. Feb 18. 10:52
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

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `children_fullprofile`
--
ALTER TABLE `children_fullprofile`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `motherID` (`motherID`),
  ADD KEY `fatherID` (`fatherID`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `children_fullprofile`
--
ALTER TABLE `children_fullprofile`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `children_fullprofile`
--
ALTER TABLE `children_fullprofile`
  ADD CONSTRAINT `children_fullprofile_ibfk_1` FOREIGN KEY (`motherID`) REFERENCES `parents` (`ID`),
  ADD CONSTRAINT `children_fullprofile_ibfk_2` FOREIGN KEY (`fatherID`) REFERENCES `parents` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
