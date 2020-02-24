-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2020. Feb 24. 18:55
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
(4, 'Tóthné Bene Aranka', 'Bene Aranka', '1979-01-02', '1', '789566YX', 1, 'totben', 'totben01'),
(5, 'Okos Anna', 'Okos Anna', '1985-11-24', '1', '123586VB', 0, '-', '-'),
(6, 'Kiss Elemér', '-', '1984-07-02', '0', '7854445OP', 0, '-', '-');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `parents`
--
ALTER TABLE `parents`
  ADD PRIMARY KEY (`ID`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `parents`
--
ALTER TABLE `parents`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
