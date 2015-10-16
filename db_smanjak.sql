-- phpMyAdmin SQL Dump
-- version 4.2.11
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Oct 16, 2015 at 06:42 PM
-- Server version: 5.6.21
-- PHP Version: 5.6.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `db_smanjak`
--

-- --------------------------------------------------------

--
-- Table structure for table `detailkelassiswa`
--

CREATE TABLE IF NOT EXISTS `detailkelassiswa` (
`id_detail` int(11) NOT NULL,
  `kode_kelas` int(11) NOT NULL,
  `nis_siswa` varchar(13) NOT NULL,
  `keterangan` varchar(25) NOT NULL DEFAULT ''
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `detailkelassiswa`
--

INSERT INTO `detailkelassiswa` (`id_detail`, `kode_kelas`, `nis_siswa`, `keterangan`) VALUES
(3, 41, '23000', 'Data Siswa'),
(12, 43, '1001', 'Data Siswa'),
(13, 43, '100000', 'Data Siswa'),
(15, 41, '1111', 'Data Siswa'),
(16, 42, '000', 'Data Siswa'),
(17, 43, '9999', 'Data Siswa'),
(20, 44, '2222', 'Data Siswa');

-- --------------------------------------------------------

--
-- Table structure for table `detailmapelguru`
--

CREATE TABLE IF NOT EXISTS `detailmapelguru` (
`id_detail` int(11) NOT NULL,
  `id_guru` int(11) NOT NULL,
  `kode_mapel` varchar(6) NOT NULL,
  `status` varchar(12) NOT NULL DEFAULT 'Aktif'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `detailmapelkelas`
--

CREATE TABLE IF NOT EXISTS `detailmapelkelas` (
`id_detail` int(11) NOT NULL,
  `kode_kelas` int(11) NOT NULL,
  `kode_mapel` varchar(6) NOT NULL,
  `id_guru` int(11) DEFAULT NULL,
  `status` varchar(12) NOT NULL DEFAULT 'Aktif'
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `detailmapelkelas`
--

INSERT INTO `detailmapelkelas` (`id_detail`, `kode_kelas`, `kode_mapel`, `id_guru`, `status`) VALUES
(24, 43, 'BIND', 75681, 'Aktif'),
(25, 43, 'MTKA', 51025, 'Aktif'),
(26, 43, 'PRA', 42484, 'Aktif'),
(27, 43, 'MTKC', 87240, 'Aktif'),
(28, 43, 'BIND', 51025, 'Aktif'),
(29, 51, 'BIND', 75681, 'Aktif');

-- --------------------------------------------------------

--
-- Table structure for table `ekstrakurikuler`
--

CREATE TABLE IF NOT EXISTS `ekstrakurikuler` (
  `kode_eskul` varchar(8) NOT NULL,
  `nama_eskul` varchar(50) NOT NULL,
  `keterangan` varchar(12) NOT NULL DEFAULT 'Aktif'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `ekstrakurikuler`
--

INSERT INTO `ekstrakurikuler` (`kode_eskul`, `nama_eskul`, `keterangan`) VALUES
('AS', 'Bola Sepak Bola', 'Aktif'),
('DAS', 'Sepak Wanita', 'Aktif');

-- --------------------------------------------------------

--
-- Table structure for table `guru`
--

CREATE TABLE IF NOT EXISTS `guru` (
  `id_guru` int(11) NOT NULL,
  `nip` varchar(25) DEFAULT '',
  `nuptk` varchar(25) DEFAULT '',
  `nama_guru` varchar(50) NOT NULL,
  `status_guru` varchar(13) NOT NULL DEFAULT 'Aktif',
  `keterangan` text
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `guru`
--

INSERT INTO `guru` (`id_guru`, `nip`, `nuptk`, `nama_guru`, `status_guru`, `keterangan`) VALUES
(988, '196708081994121002', '9140745647200053', 'Drs. Suherlan', 'Aktif', 'Wali Kls 11 MIPA 1, Pembina  Ekskul English Club'),
(20562, '196410141988032007', '8346742645300003', 'Beti Rohaeti, S.Pd.', 'Aktif', 'Staf. Wk.Urs. Kurikulum'),
(22231, '19620205 198603 1 012', '0834 7406 4220 0082', 'Drs. Sahrudin', 'Tidak Aktif', ''),
(22513, '196911051993011001', '7843747650200032', 'Iyep Budiman, S.Pd, M.Mpd.', 'Aktif', ''),
(28072, '196407111987031014', '4262742643200013', 'Dudin Syehabudin, S.Pd.,Bio', 'Aktif', 'Wk. Urusan Sarana'),
(42484, '196510241989031002', '2356743646200033', 'Mumuh Muslihat, S.Pd.', 'Aktif', 'Staf. Wk.Urs. Kesiswaan'),
(48232, '196306221989031006', '5954741646200002', 'H. Muhamad Syafrudin, S.Pd.', 'Aktif', 'Koordinator Laboratorium'),
(51025, '196710091991011002', '4242745648200053', 'Ee Darmawan, S.Pd., M.Si.', 'Aktif', ''),
(75316, '196202051986031012', '0834740642200082', 'Drs. Sahrudin', 'Aktif', 'Koordinator Keagamaan'),
(75681, '196111221980111001', '2454739639200003', 'Drs. Deden Zenal Muttaqin, M.Mpd.', 'Aktif', 'Wali Kls 10 IPS 1, Pembina  Ekskul Kerohanian'),
(77331, '196409011988032005', '4441742645300002', 'Erni Nurilah, S.Pd., M.Mpd.', 'Aktif', 'Wk. Urusan Humas'),
(87240, '195908011983031016', '3440737639200042', 'Edi Yama, S.Pd., M.M.Pd.', 'Aktif', 'Kepala Sekolah');

-- --------------------------------------------------------

--
-- Table structure for table `kelas`
--

CREATE TABLE IF NOT EXISTS `kelas` (
`kode_kelas` int(11) NOT NULL,
  `nama_kelas` varchar(15) NOT NULL,
  `tahun_ajaran` varchar(15) NOT NULL,
  `jumlah_siswa` int(5) DEFAULT '0',
  `id_guru` int(11) NOT NULL,
  `status_kelas` varchar(12) NOT NULL DEFAULT 'Aktif'
) ENGINE=InnoDB AUTO_INCREMENT=53 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `kelas`
--

INSERT INTO `kelas` (`kode_kelas`, `nama_kelas`, `tahun_ajaran`, `jumlah_siswa`, `id_guru`, `status_kelas`) VALUES
(41, 'X MIPA 1', '2015/2016', 2, 75681, 'Aktif'),
(42, 'X MIPA 2', '2015/2016', 1, 28072, 'Aktif'),
(43, 'X IIS 1', '2015/2016', 3, 77331, 'Aktif'),
(44, 'XII MIPA 7', '2015/2016', 1, 75681, 'Aktif'),
(45, 'XI MIPA 2', '2015/2016', 0, 20562, 'Aktif'),
(46, 'X MIPA 3', '2015/2016', 0, 988, 'Aktif'),
(47, 'X MIPA 4', '2015/2016', 0, 51025, 'Aktif'),
(48, 'X MIPA 5', '2015/2016', 0, 42484, 'Aktif'),
(49, 'X IIS 2', '2015/2016', 0, 87240, 'Aktif'),
(50, 'X IIS 3', '2015/2016', 0, 22513, 'Aktif'),
(51, 'X IIS 4', '2015/2016', 0, 22513, 'Aktif'),
(52, 'X IIS 5', '2015/2016', 0, 20562, 'Aktif');

-- --------------------------------------------------------

--
-- Table structure for table `kompetensi`
--

CREATE TABLE IF NOT EXISTS `kompetensi` (
  `id_kompetensi` int(11) NOT NULL,
  `nis_siswa` varchar(13) NOT NULL,
  `kode_kelas` int(11) NOT NULL,
  `kode_mapel` varchar(6) NOT NULL,
  `kode_semester` varchar(6) NOT NULL,
  `id_guru` int(11) NOT NULL,
  `p_ang` int(11) NOT NULL,
  `p_pred` varchar(3) NOT NULL,
  `p_desk` longtext NOT NULL,
  `k_ang` int(11) NOT NULL,
  `k_pred` varchar(3) NOT NULL,
  `k_desk` longtext NOT NULL,
  `s_ang` int(11) NOT NULL,
  `s_pred` varchar(3) NOT NULL,
  `s_desk` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `mapel`
--

CREATE TABLE IF NOT EXISTS `mapel` (
  `kode_mapel` varchar(6) NOT NULL,
  `mata_pelajaran` varchar(50) NOT NULL,
  `kategori_mapel` varchar(11) NOT NULL,
  `jam_pelajaran` int(5) DEFAULT '0',
  `jumlah_jp` int(5) DEFAULT '0',
  `status_mapel` varchar(12) NOT NULL DEFAULT 'Aktif'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `mapel`
--

INSERT INTO `mapel` (`kode_mapel`, `mata_pelajaran`, `kategori_mapel`, `jam_pelajaran`, `jumlah_jp`, `status_mapel`) VALUES
('BIND', 'Bahasa Indonesia', 'Kelompok A', 2, 0, 'Aktif'),
('MTKA', 'Matematika', 'Kelompok A', 3, 0, 'Aktif'),
('MTKC', 'Matematika', 'Kelompok C', 2, 0, 'Aktif'),
('PRA', 'Prakarya', 'Kelompok B', 1, 0, 'Aktif');

-- --------------------------------------------------------

--
-- Table structure for table `nilai`
--

CREATE TABLE IF NOT EXISTS `nilai` (
  `id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `nilai_raport`
--

CREATE TABLE IF NOT EXISTS `nilai_raport` (
`kode` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

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
-- Dumping data for table `orangtua`
--

INSERT INTO `orangtua` (`id_ortu`, `nis_siswa`, `nama_ayah`, `nama_ibu`, `alamat_ortu`, `no_telp`, `pekerjaan_ayah`, `pekerjaan_ibu`, `nama_wali`, `alamat_wali`, `pekerjaan_wali`) VALUES
(3, '23000', '12', '12', '12', '', '12', '12', '', '', ''),
(4, '1001', '99101', '99', '99', '', '99', '99', '', '', ''),
(5, '100000', '100000', '1', '1', '', '1', '1', '', '', ''),
(6, '1111', '1111', '1111', '1111', '', '1111', '1111', '', '', ''),
(7, '000', '000', 'V000', '000', '', '000', '000', '', '', ''),
(8, '9999', '9999', '9999', '9999', '', '9999', '9999', '', '', ''),
(9, '2222', '2222', '2222', '2222', '', '2222', '2222', '', '', '');

-- --------------------------------------------------------

--
-- Table structure for table `profil_sekolah`
--

CREATE TABLE IF NOT EXISTS `profil_sekolah` (
  `npsn` varchar(10) NOT NULL,
  `nss` varchar(14) NOT NULL,
  `nama_sekolah` varchar(30) NOT NULL,
  `alamat_sekolah` varchar(30) NOT NULL,
  `kode_pos` int(5) NOT NULL,
  `no_telp` varchar(15) NOT NULL,
  `kelurahan` varchar(15) NOT NULL,
  `kecamatan` varchar(15) NOT NULL,
  `kota` varchar(15) NOT NULL,
  `provinsi` varchar(15) NOT NULL,
  `website` varchar(30) DEFAULT NULL,
  `email` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `profil_sekolah`
--

INSERT INTO `profil_sekolah` (`npsn`, `nss`, `nama_sekolah`, `alamat_sekolah`, `kode_pos`, `no_telp`, `kelurahan`, `kecamatan`, `kota`, `provinsi`, `website`, `email`) VALUES
('20202263', '301020633005', 'SMA Negeri 1 Jampangkulon', 'Jl. Warungtagog', 43179, '(0266) 490147', 'Nagraksari', 'Jampangkulon', 'Sukabumi', 'Jawa Barat', 'www.smanjampangkulon.sch.id', 'smanjampangkulon@yahoo.co.id');

-- --------------------------------------------------------

--
-- Table structure for table `siswa`
--

CREATE TABLE IF NOT EXISTS `siswa` (
  `nis_siswa` varchar(13) NOT NULL,
  `nama_siswa` varchar(50) NOT NULL,
  `nisn_siswa` varchar(12) DEFAULT NULL,
  `tempat_lahir` varchar(25) NOT NULL,
  `tanggal_lahir` varchar(20) NOT NULL,
  `jenis_kelamin` varchar(10) NOT NULL,
  `agama` varchar(8) NOT NULL,
  `status_keluarga` varchar(15) NOT NULL,
  `anak_ke` int(2) NOT NULL,
  `alamat` text NOT NULL,
  `no_telp` varchar(20) DEFAULT NULL,
  `asal_sekolah` varchar(25) NOT NULL,
  `tanggal_masuk` varchar(20) NOT NULL,
  `status_siswa` varchar(13) DEFAULT 'Aktif'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `siswa`
--

INSERT INTO `siswa` (`nis_siswa`, `nama_siswa`, `nisn_siswa`, `tempat_lahir`, `tanggal_lahir`, `jenis_kelamin`, `agama`, `status_keluarga`, `anak_ke`, `alamat`, `no_telp`, `asal_sekolah`, `tanggal_masuk`, `status_siswa`) VALUES
('000', '000', '000', '000', '08/02/1999', 'Laki-Laki', 'Islam', 'Anak Kandung', 1, '000', '000', '000', '28/09/2015', 'Aktif'),
('100000', 'Saya Adalah ', '11', '1', '12/09/2015', 'Laki-Laki', 'Islam', 'Anak Kandung', 1, '1', '1', '1', '12/09/2015', 'Aktif'),
('1001', 'Kamu Adalah', '99', '99', '30/01/2015', 'Laki-Laki', 'Islam', 'Anak Angkat', 2, '99', '99', 'ddd', '01/09/2015', 'Aktif'),
('1111', '1111', '111', '1111', '10/09/2015', 'Laki-Laki', 'Kristen', 'Anak Angkat', 9, '1111', '1111', '1111', '17/09/2015', 'Aktif'),
('2222', '2222', '2222', '2222', '01/09/2015', 'Laki-Laki', 'Islam', 'Anak Kandung', 1, '2222', '', '2222', '28/09/2016', 'Aktif'),
('23000', '12', '121', '12', '09/01/2015', 'Laki-Laki', 'Islam', 'Anak Kandung', 3, '12', '12ccc', '12', '09/11/2015', 'Aktif'),
('9999', '9999', '9999', '9999', '27/09/2015', 'Laki-Laki', 'Islam', 'Anak Kandung', 1, '9999', '', '9999', '28/09/2015', 'Aktif');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE IF NOT EXISTS `user` (
  `username` varchar(15) NOT NULL,
  `password` varchar(25) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `level` int(11) DEFAULT '2'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`username`, `password`, `nama`, `level`) VALUES
('admin', 'admin', 'administrator', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `detailkelassiswa`
--
ALTER TABLE `detailkelassiswa`
 ADD PRIMARY KEY (`id_detail`), ADD KEY `kode_kelas` (`kode_kelas`), ADD KEY `nis_siswa` (`nis_siswa`);

--
-- Indexes for table `detailmapelguru`
--
ALTER TABLE `detailmapelguru`
 ADD PRIMARY KEY (`id_detail`);

--
-- Indexes for table `detailmapelkelas`
--
ALTER TABLE `detailmapelkelas`
 ADD PRIMARY KEY (`id_detail`), ADD KEY `kode_kelas` (`kode_kelas`), ADD KEY `kode_mapel` (`kode_mapel`), ADD KEY `id_guru` (`id_guru`);

--
-- Indexes for table `ekstrakurikuler`
--
ALTER TABLE `ekstrakurikuler`
 ADD PRIMARY KEY (`kode_eskul`);

--
-- Indexes for table `guru`
--
ALTER TABLE `guru`
 ADD PRIMARY KEY (`id_guru`);

--
-- Indexes for table `kelas`
--
ALTER TABLE `kelas`
 ADD PRIMARY KEY (`kode_kelas`), ADD KEY `id_guru` (`id_guru`);

--
-- Indexes for table `mapel`
--
ALTER TABLE `mapel`
 ADD PRIMARY KEY (`kode_mapel`);

--
-- Indexes for table `nilai_raport`
--
ALTER TABLE `nilai_raport`
 ADD PRIMARY KEY (`kode`);

--
-- Indexes for table `orangtua`
--
ALTER TABLE `orangtua`
 ADD PRIMARY KEY (`id_ortu`), ADD KEY `nis_siswa` (`nis_siswa`);

--
-- Indexes for table `profil_sekolah`
--
ALTER TABLE `profil_sekolah`
 ADD PRIMARY KEY (`npsn`);

--
-- Indexes for table `siswa`
--
ALTER TABLE `siswa`
 ADD PRIMARY KEY (`nis_siswa`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
 ADD PRIMARY KEY (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `detailkelassiswa`
--
ALTER TABLE `detailkelassiswa`
MODIFY `id_detail` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=21;
--
-- AUTO_INCREMENT for table `detailmapelguru`
--
ALTER TABLE `detailmapelguru`
MODIFY `id_detail` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `detailmapelkelas`
--
ALTER TABLE `detailmapelkelas`
MODIFY `id_detail` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=30;
--
-- AUTO_INCREMENT for table `kelas`
--
ALTER TABLE `kelas`
MODIFY `kode_kelas` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=53;
--
-- AUTO_INCREMENT for table `nilai_raport`
--
ALTER TABLE `nilai_raport`
MODIFY `kode` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `orangtua`
--
ALTER TABLE `orangtua`
MODIFY `id_ortu` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=10;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `detailkelassiswa`
--
ALTER TABLE `detailkelassiswa`
ADD CONSTRAINT `detailkelassiswa_ibfk_1` FOREIGN KEY (`kode_kelas`) REFERENCES `kelas` (`kode_kelas`) ON DELETE CASCADE ON UPDATE CASCADE,
ADD CONSTRAINT `detailkelassiswa_ibfk_2` FOREIGN KEY (`nis_siswa`) REFERENCES `siswa` (`nis_siswa`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `detailmapelkelas`
--
ALTER TABLE `detailmapelkelas`
ADD CONSTRAINT `detailmapelkelas_ibfk_1` FOREIGN KEY (`kode_kelas`) REFERENCES `kelas` (`kode_kelas`) ON DELETE CASCADE ON UPDATE CASCADE,
ADD CONSTRAINT `detailmapelkelas_ibfk_2` FOREIGN KEY (`kode_mapel`) REFERENCES `mapel` (`kode_mapel`) ON DELETE CASCADE ON UPDATE CASCADE,
ADD CONSTRAINT `detailmapelkelas_ibfk_3` FOREIGN KEY (`id_guru`) REFERENCES `guru` (`id_guru`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `kelas`
--
ALTER TABLE `kelas`
ADD CONSTRAINT `kelas_ibfk_1` FOREIGN KEY (`id_guru`) REFERENCES `guru` (`id_guru`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `orangtua`
--
ALTER TABLE `orangtua`
ADD CONSTRAINT `orangtua_ibfk_1` FOREIGN KEY (`nis_siswa`) REFERENCES `siswa` (`nis_siswa`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
