-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2020. Feb 24. 17:43
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
  `ccoming` date DEFAULT NULL,
  `clocation` varchar(40) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `children_fullprofile`
--
ALTER TABLE `children_fullprofile`
  ADD PRIMARY KEY (`ID`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `children_fullprofile`
--
ALTER TABLE `children_fullprofile`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
