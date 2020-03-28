-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2020. Feb 18. 11:26
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

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `children_health`
--
ALTER TABLE `children_health`
  ADD PRIMARY KEY (`boardID`),
  ADD KEY `childrenID` (`childrenID`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `children_health`
--
ALTER TABLE `children_health`
  MODIFY `boardID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `children_health`
--
ALTER TABLE `children_health`
  ADD CONSTRAINT `children_health_ibfk_1` FOREIGN KEY (`childrenID`) REFERENCES `children_fullprofile` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
