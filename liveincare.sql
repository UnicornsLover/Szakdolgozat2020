-- phpMyAdmin SQL Dump
-- version 4.8.2
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2020. Jan 21. 10:54
-- Kiszolgáló verziója: 10.1.34-MariaDB
-- PHP verzió: 7.2.8

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
-- Tábla szerkezet ehhez a táblához `loginusers`
--

CREATE TABLE `loginusers` (
  `user_ID` int(11) NOT NULL,
  `fullname` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `fname` varchar(25) COLLATE utf8_hungarian_ci NOT NULL,
  `password` varchar(25) COLLATE utf8_hungarian_ci NOT NULL,
  `job` varchar(18) COLLATE utf8_hungarian_ci NOT NULL,
  `start_job` varchar(10) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `loginusers`
--

INSERT INTO `loginusers` (`user_ID`, `fullname`, `fname`, `password`, `job`, `start_job`) VALUES
(1, '', 'bisti', 'admin', 'boss', '2020-01-01'),
(2, '', 'nevelo', 'nevelo1', 'nevelo', '2020-01-01'),
(3, '', 'intv', 'intv1', 'intvezeto', '2020-01-01'),
(4, '', 'intu', 'intu1', 'intugyintezo', '2020-01-01'),
(5, '', 'lelek', 'lelek1', 'pszichologus', '2020-01-01');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `loginusers`
--
ALTER TABLE `loginusers`
  ADD PRIMARY KEY (`user_ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
