-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2020. Feb 18. 11:14
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
-- A tábla indexei `school`
--
ALTER TABLE `school`
  ADD PRIMARY KEY (`ID`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `school`
--
ALTER TABLE `school`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
