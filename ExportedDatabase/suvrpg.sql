-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Värd: 127.0.0.1
-- Tid vid skapande: 18 nov 2022 kl 09:46
-- Serverversion: 10.4.25-MariaDB
-- PHP-version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Databas: `suvrpg`
--

-- --------------------------------------------------------

--
-- Tabellstruktur `leveldata`
--

CREATE TABLE `leveldata` (
  `playerid` int(11) NOT NULL,
  `mapData` text NOT NULL,
  `playerStartPosX` int(11) NOT NULL,
  `playerStartPosY` int(11) NOT NULL,
  `currentlevel` int(11) NOT NULL,
  `LoadedLevel` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumpning av Data i tabell `leveldata`
--

INSERT INTO `leveldata` (`playerid`, `mapData`, `playerStartPosX`, `playerStartPosY`, `currentlevel`, `LoadedLevel`) VALUES
(1, '0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,0,0,0\r\n0,0,0,4,5,1,1,1,5,4,0,0,0,0,0,5,1,1,2,1,1,1,0\r\n0,0,0,5,0,0,1,0,0,5,0,0,0,0,0,2,0,0,0,1,1,1,0\r\n0,0,0,1,0,0,1,0,0,1,0,1,1,1,1,4,0,0,0,1,4,1,0\r\n0,0,0,1,1,1,1,1,1,1,0,1,1,4,1,1,0,0,0,1,1,1,0\r\n0,0,0,1,0,0,1,0,0,1,2,1,1,0,1,1,0,0,0,1,1,1,0\r\n0,0,0,5,0,0,1,0,0,5,0,1,1,1,1,1,0,0,0,1,1,1,0\r\n0,0,0,4,5,1,1,1,5,4,0,1,1,1,1,1,0,0,0,1,1,5,0\r\n0,6,0,0,0,0,0,0,0,2,0,0,0,0,0,0,0,0,0,0,0,2,0\r\n0,1,1,1,1,1,1,1,0,5,1,1,1,1,1,5,2,5,1,1,1,4,0\r\n0,1,1,1,1,1,1,1,0,1,1,1,1,1,1,1,0,1,1,1,1,1,0\r\n0,1,1,4,4,4,1,1,0,1,1,1,0,4,1,1,0,1,1,1,1,1,0\r\n0,1,1,4,4,4,1,1,0,1,1,4,4,4,1,1,0,1,1,1,1,1,0\r\n0,1,1,4,4,4,1,1,0,1,1,0,4,0,1,1,0,1,1,1,1,1,0\r\n0,5,1,1,1,1,1,1,0,1,1,1,1,1,1,1,0,1,1,1,1,1,0\r\n0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0,0,0\r\n0,1,0,1,1,1,1,1,1,1,2,1,1,1,1,1,2,1,1,5,1,1,0\r\n0,5,0,1,1,1,1,1,1,1,0,5,0,1,1,1,0,1,1,1,1,1,0\r\n0,1,0,1,5,5,5,1,1,1,0,4,5,1,1,1,0,4,4,1,1,1,0\r\n0,5,0,1,5,4,5,1,1,1,0,0,0,2,0,0,0,0,0,0,0,2,0\r\n0,1,0,1,5,5,5,1,1,1,0,4,5,1,1,1,0,1,1,1,0,1,0\r\n0,5,0,1,1,1,1,1,1,1,0,0,0,1,1,1,0,1,4,1,0,1,0\r\n0,1,0,1,1,1,1,1,1,1,0,4,5,1,1,1,0,1,4,1,0,1,0\r\n0,2,0,0,0,0,0,2,0,2,0,0,0,2,0,0,0,1,1,1,0,1,0\r\n0,5,1,1,1,1,1,1,0,1,1,1,1,1,2,5,2,1,1,1,0,1,0\r\n0,1,1,4,1,1,1,1,0,1,1,1,1,1,0,0,0,0,0,0,0,1,0\r\n0,1,1,1,4,1,1,1,0,1,1,1,4,5,2,1,1,1,1,1,1,1,0\r\n0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0', 19, 7, 1, 0);

-- --------------------------------------------------------

--
-- Tabellstruktur `player`
--

CREATE TABLE `player` (
  `id` int(11) NOT NULL,
  `name` varchar(32) NOT NULL,
  `characterDescription` text NOT NULL,
  `hp` int(11) NOT NULL,
  `maxhp` int(11) NOT NULL,
  `armor` int(11) NOT NULL,
  `attackdmg` int(11) NOT NULL,
  `race` varchar(32) NOT NULL,
  `currentGold` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumpning av Data i tabell `player`
--

INSERT INTO `player` (`id`, `name`, `characterDescription`, `hp`, `maxhp`, `armor`, `attackdmg`, `race`, `currentGold`) VALUES
(1, 'Belle', 'Gillar fisk', 26, 30, 4, 5, 'Human', 48);

--
-- Index för dumpade tabeller
--

--
-- Index för tabell `leveldata`
--
ALTER TABLE `leveldata`
  ADD KEY `playerid` (`playerid`);

--
-- Index för tabell `player`
--
ALTER TABLE `player`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT för dumpade tabeller
--

--
-- AUTO_INCREMENT för tabell `player`
--
ALTER TABLE `player`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Restriktioner för dumpade tabeller
--

--
-- Restriktioner för tabell `leveldata`
--
ALTER TABLE `leveldata`
  ADD CONSTRAINT `leveldata_ibfk_1` FOREIGN KEY (`playerid`) REFERENCES `player` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
