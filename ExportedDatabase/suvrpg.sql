-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 22, 2022 at 08:00 PM
-- Server version: 10.4.25-MariaDB
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `suvrpg`
--

-- --------------------------------------------------------

--
-- Table structure for table `leveldata`
--

CREATE TABLE `leveldata` (
  `playerid` int(11) NOT NULL,
  `mapData` text NOT NULL,
  `playerStartPosX` int(11) NOT NULL,
  `playerStartPosY` int(11) NOT NULL,
  `currentLevel` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `leveldata`
--

INSERT INTO `leveldata` (`playerid`, `mapData`, `playerStartPosX`, `playerStartPosY`, `currentLevel`) VALUES
(1, '0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,0,0,0C0,0,0,4,5,1,1,1,5,4,0,0,0,0,0,5,1,1,2,1,1,1,0C0,0,0,5,0,0,1,0,0,5,0,0,0,0,0,2,0,0,0,1,1,1,0C0,0,0,1,0,0,1,0,0,1,0,1,1,1,1,4,0,0,0,1,4,1,0C0,0,0,1,1,1,1,1,1,1,0,1,1,4,1,1,0,0,0,1,1,1,0C0,0,0,1,0,0,1,0,0,1,2,1,1,0,1,1,0,0,0,1,1,1,0C0,0,0,5,0,0,1,0,0,5,0,1,1,1,1,1,0,0,0,1,1,1,0C0,0,0,4,5,1,1,1,5,4,0,1,1,1,1,1,0,0,0,1,1,5,0C0,6,0,0,0,0,0,0,0,2,0,0,0,0,0,0,0,0,0,0,0,2,0C0,1,1,1,1,1,1,1,0,5,1,1,1,1,1,5,2,5,1,1,1,4,0C0,1,1,1,1,1,1,1,0,1,1,1,1,1,1,1,0,1,1,1,1,1,0C0,1,1,4,4,4,1,1,0,1,1,1,0,4,1,1,0,1,1,1,1,1,0C0,1,1,4,4,4,1,1,0,1,1,4,4,4,1,1,0,1,1,1,1,1,0C0,1,1,4,4,4,1,1,0,1,1,0,4,0,1,1,0,1,1,1,1,1,0C0,5,1,1,1,1,1,1,0,1,1,1,1,1,1,1,0,1,1,1,1,1,0C0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0,0,0C0,1,0,1,1,1,1,1,1,1,2,1,1,1,1,1,2,1,1,5,1,1,0C0,5,0,1,1,1,1,1,1,1,0,5,0,1,1,1,0,1,1,1,1,1,0C0,1,0,1,5,5,5,1,1,1,0,4,5,1,1,1,0,4,4,1,1,1,0C0,5,0,1,5,4,5,1,1,1,0,0,0,2,0,0,0,0,0,0,0,2,0C0,1,0,1,5,5,5,1,1,1,0,4,5,1,1,1,0,1,1,1,0,1,0C0,5,0,1,1,1,1,1,1,1,0,0,0,1,1,1,0,1,4,1,0,1,0C0,1,0,1,1,1,1,1,1,1,0,4,5,1,1,1,0,1,4,1,0,1,0C0,2,0,0,0,0,0,2,0,2,0,0,0,2,0,0,0,1,1,1,0,1,0C0,5,1,1,1,1,1,1,0,1,1,1,1,1,2,5,2,1,1,1,0,1,0C0,1,1,4,1,1,1,1,0,1,1,1,1,1,0,0,0,0,0,0,0,1,0C0,1,1,1,4,1,1,1,0,1,1,1,4,5,2,1,1,1,1,1,1,1,0C0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0C0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0', 19, 7, 1),
(2, '0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,0,0,0C0,0,0,4,5,1,1,1,5,4,0,0,0,0,0,5,1,1,2,1,1,1,0C0,0,0,5,0,0,1,0,0,5,0,0,0,0,0,2,0,0,0,1,1,1,0C0,0,0,1,0,0,1,0,0,1,0,1,1,1,1,4,0,0,0,1,1,1,0C0,0,0,1,1,1,1,1,1,1,0,1,1,4,1,1,0,0,0,1,1,1,0C0,0,0,1,0,0,1,0,0,1,2,1,1,0,1,1,0,0,0,1,1,1,0C0,0,0,5,0,0,1,0,0,5,0,1,1,1,1,1,0,0,0,1,1,1,0C0,0,0,4,5,1,1,1,5,4,0,1,1,1,1,1,0,0,0,1,1,5,0C0,6,0,0,0,0,0,0,0,2,0,0,0,0,0,0,0,0,0,0,0,2,0C0,1,1,1,1,1,1,1,0,5,1,1,1,1,1,5,2,5,1,1,1,4,0C0,1,1,1,1,1,1,1,0,1,1,1,1,1,1,1,0,1,1,1,1,1,0C0,1,1,4,4,4,1,1,0,1,1,1,0,4,1,1,0,1,1,1,1,1,0C0,1,1,4,4,4,1,1,0,1,1,4,4,4,1,1,0,1,1,1,1,1,0C0,1,1,4,4,4,1,1,0,1,1,0,4,0,1,1,0,1,1,1,1,1,0C0,5,1,1,1,1,1,1,0,1,1,1,1,1,1,1,0,1,1,1,1,1,0C0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0,0,0C0,1,0,1,1,1,1,1,1,1,2,1,1,1,1,1,2,1,1,5,1,1,0C0,5,0,1,1,1,1,1,1,1,0,5,0,1,1,1,0,1,1,1,1,1,0C0,1,0,1,5,5,5,1,1,1,0,4,5,1,1,1,0,4,4,1,1,1,0C0,5,0,1,5,4,5,1,1,1,0,0,0,2,0,0,0,0,0,0,0,2,0C0,1,0,1,5,5,5,1,1,1,0,4,5,1,1,1,0,1,1,1,0,1,0C0,5,0,1,1,1,1,1,1,1,0,0,0,1,1,1,0,1,4,1,0,1,0C0,1,0,1,1,1,1,1,1,1,0,4,5,1,1,1,0,1,4,1,0,1,0C0,2,0,0,0,0,0,2,0,2,0,0,0,2,0,0,0,1,1,1,0,1,0C0,5,1,1,1,1,1,1,0,1,1,1,1,1,2,5,2,1,1,1,0,1,0C0,1,1,4,1,1,1,1,0,1,1,1,1,1,0,0,0,0,0,0,0,1,0C0,1,1,1,4,1,1,1,0,1,1,1,4,5,2,1,1,1,1,1,1,1,0C0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0C0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0C', 2, 27, 1);

-- --------------------------------------------------------

--
-- Table structure for table `player`
--

CREATE TABLE `player` (
  `id` int(11) NOT NULL,
  `name` varchar(32) NOT NULL,
  `characterDescription` text NOT NULL,
  `health` int(11) NOT NULL,
  `maxhealth` int(11) NOT NULL,
  `armor` int(11) NOT NULL,
  `attackdmg` int(11) NOT NULL,
  `race` varchar(32) NOT NULL,
  `currentGold` int(11) NOT NULL,
  `highscore` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `player`
--

INSERT INTO `player` (`id`, `name`, `characterDescription`, `health`, `maxhealth`, `armor`, `attackdmg`, `race`, `currentGold`, `highscore`) VALUES
(1, 'Belle', 'Gillar fisk', 26, 30, 4, 5, 'Human', 48, 0),
(2, 'Christian', 'Gillar Fiskmås', 5, 30, 3, 3, 'Dwarf', 4, 0),
(5, '123', '', 28, 30, 0, 1, '', 16, 0),
(6, '123', '', 20, 30, 0, 0, '', 19, 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `leveldata`
--
ALTER TABLE `leveldata`
  ADD KEY `playerid` (`playerid`);

--
-- Indexes for table `player`
--
ALTER TABLE `player`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `player`
--
ALTER TABLE `player`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `leveldata`
--
ALTER TABLE `leveldata`
  ADD CONSTRAINT `leveldata_ibfk_1` FOREIGN KEY (`playerid`) REFERENCES `player` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
