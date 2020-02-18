-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2020. Feb 18. 10:17
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

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `employes_login`
--
ALTER TABLE `employes_login`
  ADD PRIMARY KEY (`ID`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `employes_login`
--
ALTER TABLE `employes_login`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
