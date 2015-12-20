-- phpMyAdmin SQL Dump
-- version 4.2.11
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Dec 13, 2015 at 05:07 PM
-- Server version: 5.6.21
-- PHP Version: 5.6.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `db_sma`
--

-- --------------------------------------------------------

--
-- Table structure for table `orangtua`
--

CREATE TABLE IF NOT EXISTS `orangtua` (
`id_ortu` int(11) NOT NULL,
  `nis_siswa` varchar(13) NOT NULL,
  `nama_ayah` varchar(30) NOT NULL,
  `nama_ibu` varchar(30) NOT NULL,
  `alamat_ortu` text NOT NULL,
  `no_telp` varchar(50) DEFAULT '',
  `pekerjaan_ayah` varchar(20) NOT NULL,
  `pekerjaan_ibu` varchar(20) NOT NULL,
  `nama_wali` varchar(30) DEFAULT '',
  `alamat_wali` text,
  `pekerjaan_wali` varchar(20) DEFAULT ''
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `orangtua`
--
ALTER TABLE `orangtua`
 ADD PRIMARY KEY (`id_ortu`), ADD KEY `nis_siswa` (`nis_siswa`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `orangtua`
--
ALTER TABLE `orangtua`
MODIFY `id_ortu` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=10;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `orangtua`
--
ALTER TABLE `orangtua`
ADD CONSTRAINT `orangtua_ibfk_1` FOREIGN KEY (`nis_siswa`) REFERENCES `siswa` (`nis_siswa`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
