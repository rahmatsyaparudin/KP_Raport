-- phpMyAdmin SQL Dump
-- version 4.2.11
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Dec 13, 2015 at 05:08 PM
-- Server version: 5.6.21
-- PHP Version: 5.6.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `db_smanjakfinal`
--

-- --------------------------------------------------------

--
-- Table structure for table `deskripsi`
--

CREATE TABLE IF NOT EXISTS `deskripsi` (
`id_deskripsi` int(11) NOT NULL,
  `kode_kelas` int(11) NOT NULL,
  `kode_mapel` varchar(6) NOT NULL,
  `kode_semester` varchar(6) NOT NULL,
  `p_atas` longtext NOT NULL,
  `p_tengah` longtext NOT NULL,
  `p_bawah` longtext NOT NULL,
  `k_atas` longtext NOT NULL,
  `k_tengah` longtext NOT NULL,
  `k_bawah` longtext NOT NULL,
  `s_atas` longtext NOT NULL,
  `s_tengah` longtext NOT NULL,
  `s_bawah` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `deskripsieskul`
--

CREATE TABLE IF NOT EXISTS `deskripsieskul` (
`id_deskripsieskul` int(11) NOT NULL,
  `kode_eskul` varchar(8) NOT NULL,
  `deskripsi` mediumtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `detailkelassiswa`
--

CREATE TABLE IF NOT EXISTS `detailkelassiswa` (
`id_detail` int(11) NOT NULL,
  `kode_kelas` int(11) NOT NULL,
  `nis_siswa` varchar(13) NOT NULL,
  `keterangan` varchar(25) NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

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
  `id_guru` int(11) DEFAULT NULL,
  `kode_mapel` varchar(6) NOT NULL,
  `status` varchar(12) NOT NULL DEFAULT 'Aktif'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

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
('BB', 'Bola Basket', 'Aktif'),
('BT', 'Bulu Tangkis', 'Aktif'),
('ESC', 'English Club', 'Aktif'),
('IT', 'Informasi Teknologi', 'Aktif'),
('JNT', 'Jurnalistik', 'Aktif'),
('KER', 'Kerohanian', 'Aktif'),
('KIR', 'KIR', 'Aktif'),
('OSN', 'OSN', 'Aktif'),
('PKB', 'Paskibra', 'Aktif'),
('PMK', 'Pramuka', 'Aktif'),
('PMR', 'Palang Merah Remaja', 'Aktif'),
('SB', 'Sepak Bola', 'Aktif'),
('SM', 'Seni Musik', 'Aktif'),
('ST', 'Seni Tari', 'Aktif'),
('TABU', 'Tata Busana', 'Aktif'),
('TM', 'Tenis Meja', 'Aktif'),
('VOLI', 'Bola Voli', 'Aktif');

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
(2019, '', '', 'Beni Wijaya, S.Pd.', 'Aktif', 'Wali Kelas 11 MIPA 3, Pembina Ekskul OSN'),
(2105, '', '1052759664200003', 'Budi Wisandi, S.Kom.', 'Aktif', 'Wali Kelas 11 MIPA 2, Pembina Ekskul IT'),
(2659, '', '8856760662200012', 'Ujang Sucipta, S.Pd.', 'Aktif', ''),
(6485, '', '', 'Tyta Gleis Dwiranti, S.Pd.', 'Aktif', ''),
(6762, '', '4447764665210142', 'Neng Sri Lidiawati, S.Pd.', 'Aktif', 'Wali Kelas 12 MIPA 7, Pembina Ekskul Tenis Meja / Bulu Tangkis'),
(9633, '196407111987031014', '4262742643200013', 'Dudin Syehabudin, S.Pd.,Bio', 'Aktif', 'Wk. Urusan Sarana'),
(14160, '', '3034761663300043', 'Rusmiati, S.Pd.', 'Aktif', 'Wali Kelas 10 MIPA 4'),
(14395, '', '8543758660300063', 'Novika Muhsinah, S.Pd.', 'Aktif', 'Wali Kelas 11 IIS 2'),
(16501, '198701102009022004', '9442765665300022', 'Eva Puspita Dewi, S.Pd.', 'Aktif', 'Wali Kelas 12 MIPA 3'),
(19033, '196510241989031002', '2356743646200033', 'Mumuh Muslihat, S.Pd.', 'Aktif', 'Staf. Wk. Urs. Kesiswaan'),
(19643, '196911051993011001', '7843747650200032', 'Iyep Budiman, S.Pd., M.M.Pd.', 'Aktif', 'Wk. Urusan Kurikulum'),
(21246, '197704152014101001', '0747755657200032', 'Iman Hilman, S.Pd.', 'Aktif', 'Wali Kelas 12 MIPA 5, Pembina Ekskul PMR'),
(21918, '197204102014101001', '3336750652200023', 'Asep Mulyadi, S.Psi', 'Aktif', 'Wali Kelas 12 IIS 3'),
(22397, '', '5458762665200003', 'Adendi Supriadi, S.Pd.', 'Aktif', 'Pembina Ekskul Bola Voli'),
(22708, '196111221980111001', '2454739639200003', 'Drs. Deden Zaenal Muttaqin, M.M.Pd.', 'Aktif', 'Wali Kelas 10 IIS 1, Pembina Ekskul Kerohanian'),
(22833, '', '0842760661300112', 'Nina, S.Pd.', 'Aktif', 'Wali Kelas 10 MIPA 1'),
(23510, '', '5453760661300062', 'Nurilah Farihah, S.Si.', 'Aktif', 'Wali Kelas 10 MIPA 5, Pembina Ekskul Kerohanian'),
(23902, '', '0640760661200032', 'Riana Indra Saputra, S.Pd.', 'Aktif', 'Wali Kelas 10 MIPA 3, Pembina Ekskul Bola Basket'),
(23997, '196710091991011002', '4242745648200053', 'Ee Darmawan, S.Pd. M.Si', 'Aktif', ''),
(26630, '', '1397626642000033', 'Pian Maulana, S.Sn.', 'Aktif', 'Pembina Ekskul Seni Musik'),
(27563, '', '', 'Asep Hilman, S.Pd.', 'Aktif', ''),
(27611, '', '', 'Andi Ruswandi, S.Pd.', 'Aktif', 'Pembina Ekskul Pramuka'),
(28584, '', '', 'Gita Warieni, S.Pd.', 'Aktif', 'Wali Kelas 10 IIS 5'),
(31711, '196710142006041003', '6346745648200013', 'Deden Mulyadi, S.Pd.', 'Aktif', 'Koordinator Perpustakaan'),
(34549, '198108052008012005', '5840759660300092', 'Ade Irnayanti, S.Pd.', 'Aktif', 'Wali Kelas 12 IIS 2'),
(35393, '', '4448758660200033', 'Gusniawan Sastrawiguna, S.Pd.', 'Aktif', 'Wali Kelas 12 IIS 3, Pembina Ekskul Jurnalistik'),
(37500, '', '', 'Muhammad Sodik Solihin, S.Pd.', 'Aktif', 'Wali Kelas 10 IIS 2, Pembina Ekskul Sepak Bola'),
(41263, '', '5661760661300062', 'Mifa Marfiani, S.Pd.', 'Aktif', 'Wali Kelas Wali Kelas 11 IIS 4'),
(42882, '197505032007011009', '7637753655200022', 'Hardika, S.Pd', 'Aktif', 'Wk. Urusan Kesiswaan'),
(43390, '196304102006042002', '8336741642300033', 'Dra. Trinita Laksminingtan', 'Aktif', 'Wali Kelas 12 MIPA 2'),
(47331, '196712221997021001', '5544745647200063', 'Hermawan Karyani, S.Pd.', 'Aktif', 'Wali Kelas 12 MIPA 6'),
(48408, '', '', 'Indri Rindiana, S.Pd.', 'Aktif', ''),
(48736, '', '', 'Dian Suprianti, S.Pd.', 'Aktif', 'Wali Kelas 11 MIPA 4'),
(49774, '', '6547761661300012', 'Laesaria, S.Pd.', 'Aktif', 'Wali Kelas 10 IIS 4'),
(51452, '196202051986031012', '0834740642200082', 'Drs. Syahrudin', 'Aktif', 'Koordinator Keagamaan'),
(51677, '', '0842758660300082', 'Rani Sri Nurbayanti', 'Aktif', 'Wali Kelas 11 MIPA 5, Pembina Ekskul Pramuka'),
(51703, '196409011988032005', '4441742645300002', 'Erni Nurilah, S,Pd., M.M.Pd.', 'Aktif', 'Wk. Urusan Humas'),
(54159, '195908011983031016', '3440737639200042', 'Edi Yama, S.Pd., M.M.Pd.', 'Aktif', 'Kepala Sekolah'),
(63760, '197308142003122002', '7146751654300013', 'Ina Rahmawati, S.Pd.', 'Aktif', 'Staf. Wk. Urs. Kesiswaan'),
(66870, '196306221989031006', '5954741646200002', 'H. Muhammad Syafrudin, S.Pd.', 'Aktif', 'Koordinator Laboratorium'),
(68207, '', '', 'Deliar Rahman Firdaus, S.Pd.', 'Aktif', 'Wali Kelas 11 IIS 5'),
(71940, '197106272007012004', '2938751650300002', 'N. Inawati Islamiah, S.Pd.', 'Aktif', 'Wali Kelas 12 MIPA 1'),
(71975, '', '1747761662300092', 'Rina Nurkomala, S.S.', 'Aktif', 'Wali Kelas 11 IIS 1, Pembina Ekskul Paskibra'),
(75738, '196911102014112002', '3343747649300063', 'Rina Herlina', 'Aktif', 'Wali Kelas 10 MIPA 2, Pembina Ekskul Tata Busana'),
(80748, '', '', 'Sigit Ratulangi, S.Pd.', 'Aktif', 'Wali Kelas 10 IIS 3, Pembina Ekskul KIR'),
(81213, '', '', 'Pramesti Agustina, S.Pd.', 'Aktif', ''),
(84155, '196410141988032007', '8346742645300003', 'Beti Rohaeti, S.Pd', 'Aktif', 'Staf. Wk. Urs. Kurikulum'),
(84807, '198205032008011003', '5637760661200022', 'Dede Ginanjar, S.Pd.', 'Aktif', 'Staf. Wk. Urs. Kesiswaan'),
(85506, '197805192008012004', '8851756657300042', 'Mia Mayawati, S.Pd.I.', 'Aktif', 'Wali Kelas 12 IIS 1'),
(87804, '', '', 'Yopa Galih Triani, S.Pd.', 'Aktif', ''),
(88839, '196808161997022002', '6548746648300052', 'Tuti Kurniawati, S.Pd.', 'Aktif', 'Koordinator Bimbingan'),
(90844, '196708081994121002', '9140745647200053', 'Drs. Suherlan', 'Aktif', 'Wali Kelas 11 MIPA 1, Pembicara Ekskul English Club'),
(91339, '', '', 'Ihsan Darmawan, S.Hut.', 'Aktif', ''),
(91585, '197206071999031006', '2038750649200003', 'Deni Tardi Mawardi, S.Pd.', 'Aktif', 'Staf. Wk. Urs. Kurikulum'),
(94933, '198503202009021001', '4652763664110042', 'Fahrizal Awaludin, S.Pd.', 'Aktif', 'Wali Kelas 12 MIPA 4, Pembina Ekskul Seni Tari');

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
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `kelas`
--

INSERT INTO `kelas` (`kode_kelas`, `nama_kelas`, `tahun_ajaran`, `jumlah_siswa`, `id_guru`, `status_kelas`) VALUES
(1, 'X MIPA 1', '2015/2016', 0, 84155, 'Aktif'),
(2, 'X MIPA 2', '2015/2016', 0, 84155, 'Aktif'),
(3, 'X MIPA 3', '2015/2016', 0, 84155, 'Aktif'),
(4, 'XI MIPA 1', '2015/2016', 0, 84155, 'Aktif'),
(5, 'XI MIPA 2', '2015/2016', 0, 84155, 'Aktif'),
(6, 'X IIS 1', '2015/2016', 0, 84155, 'Aktif'),
(7, 'X IIS 2 ', '2015/2016', 0, 84155, 'Aktif'),
(8, 'XII IIS 1', '2015/2016', 0, 84155, 'Aktif'),
(9, 'XII IIS 2', '2015/2016', 0, 84155, 'Aktif');

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
('ANT', 'Antropologi', 'Kelompok C', 4, 0, 'Aktif'),
('BASN', 'Bahasa Asing Lain', 'Kelompok C', 3, 0, 'Aktif'),
('BIND', 'Bahasa Indonesia', 'Kelompok A', 4, 0, 'Aktif'),
('BING', 'Bahasa Inggris', 'Kelompok A', 2, 0, 'Aktif'),
('BIO', 'Biologi', 'Kelompok C', 4, 0, 'Aktif'),
('BK', 'Bimbingan Konseling', 'Kelompok C', 4, 0, 'Aktif'),
('BSARB', 'Bahasa dan Sastra Arab', 'Kelompok C', 4, 0, 'Aktif'),
('BSIND', 'Bhasa dan Sastra Indonesia', 'Kelompok C', 3, 0, 'Aktif'),
('BSING', 'Bahasa dan Sastra Inggris', 'Kelompok C', 3, 0, 'Aktif'),
('BSND', 'Bahasa Sunda', 'Kelompok B', 2, 0, 'Aktif'),
('EKO', 'Ekonomi', 'Kelompok C', 4, 0, 'Aktif'),
('FIS', 'Fisika', 'Kelompok C', 4, 0, 'Aktif'),
('GEO', 'Geografi', 'Kelompok C', 4, 0, 'Aktif'),
('KIM', 'Kimia', 'Kelompok C', 4, 0, 'Aktif'),
('MATA', 'Matematika', 'Kelompok A', 4, 0, 'Aktif'),
('MATC', 'Matematika', 'Kelompok C', 4, 0, 'Aktif'),
('OR', 'Pendidikan Jasmani, Olahraga, dan Kesehatan', 'Kelompok B', 3, 0, 'Aktif'),
('PAI', 'Pendidikan Agama dan Budi Pekerti', 'Kelompok A', 3, 0, 'Aktif'),
('PK', 'Prakarya dan Kewirausahaan', 'Kelompok B', 2, 0, 'Aktif'),
('PKN', 'Pendidikan Pancasila dan Kewarganegaraan', 'Kelompok A', 2, 0, 'Aktif'),
('SB', 'Seni Budaya', 'Kelompok B', 2, 0, 'Aktif'),
('SEJA', 'Sejarah Indonesia', 'Kelompok A', 3, 0, 'Aktif'),
('SEJC', 'Sejarah', 'Kelompok C', 4, 0, 'Aktif'),
('SOS', 'Sosiologi', 'Kelompok C', 4, 0, 'Aktif');

-- --------------------------------------------------------

--
-- Table structure for table `nilai`
--

CREATE TABLE IF NOT EXISTS `nilai` (
`id_nilai` int(11) NOT NULL,
  `nis_siswa` varchar(13) NOT NULL,
  `kode_kelas` int(11) NOT NULL,
  `kode_mapel` varchar(6) NOT NULL,
  `kode_semester` varchar(6) NOT NULL,
  `p_skala` int(11) NOT NULL DEFAULT '0',
  `p_ang` float NOT NULL DEFAULT '0',
  `p_pred` varchar(3) NOT NULL DEFAULT '',
  `p_desk` longtext NOT NULL,
  `k_skala` int(11) NOT NULL DEFAULT '0',
  `k_ang` float NOT NULL DEFAULT '0',
  `k_pred` varchar(3) NOT NULL DEFAULT '',
  `k_desk` longtext NOT NULL,
  `s_skala` int(11) NOT NULL DEFAULT '0',
  `s_sikap` varchar(3) NOT NULL DEFAULT '',
  `s_desk` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

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

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE IF NOT EXISTS `user` (
  `username` varchar(15) NOT NULL,
  `password` text NOT NULL,
  `nama` varchar(50) NOT NULL,
  `level` int(11) DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`username`, `password`, `nama`, `level`) VALUES
('administrasi', 'px/5Z9IuDgBmpXLesMt+mkG0iyy7IZpBOK600l40S9E=', 'Administrasi Master', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `deskripsi`
--
ALTER TABLE `deskripsi`
 ADD PRIMARY KEY (`id_deskripsi`), ADD KEY `kode_kelas` (`kode_kelas`), ADD KEY `kode_mapel` (`kode_mapel`), ADD KEY `kode_semester` (`kode_semester`);

--
-- Indexes for table `deskripsieskul`
--
ALTER TABLE `deskripsieskul`
 ADD PRIMARY KEY (`id_deskripsieskul`), ADD KEY `kode_eskul` (`kode_eskul`);

--
-- Indexes for table `detailkelassiswa`
--
ALTER TABLE `detailkelassiswa`
 ADD PRIMARY KEY (`id_detail`), ADD KEY `kode_kelas` (`kode_kelas`), ADD KEY `nis_siswa` (`nis_siswa`), ADD KEY `kode_kelas_2` (`kode_kelas`), ADD KEY `nis_siswa_2` (`nis_siswa`), ADD KEY `kode_kelas_3` (`kode_kelas`), ADD KEY `nis_siswa_3` (`nis_siswa`);

--
-- Indexes for table `detailmapelguru`
--
ALTER TABLE `detailmapelguru`
 ADD PRIMARY KEY (`id_detail`), ADD KEY `id_guru` (`id_guru`), ADD KEY `kode_mapel` (`kode_mapel`);

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
-- Indexes for table `nilai`
--
ALTER TABLE `nilai`
 ADD PRIMARY KEY (`id_nilai`), ADD KEY `nis_siswa` (`nis_siswa`), ADD KEY `nis_siswa_2` (`nis_siswa`), ADD KEY `kode_kelas_2` (`kode_kelas`), ADD KEY `kode_mapel_2` (`kode_mapel`), ADD KEY `kode_kelas` (`kode_kelas`), ADD KEY `kode_mapel` (`kode_mapel`);

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
-- AUTO_INCREMENT for table `deskripsi`
--
ALTER TABLE `deskripsi`
MODIFY `id_deskripsi` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `deskripsieskul`
--
ALTER TABLE `deskripsieskul`
MODIFY `id_deskripsieskul` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `detailkelassiswa`
--
ALTER TABLE `detailkelassiswa`
MODIFY `id_detail` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `detailmapelguru`
--
ALTER TABLE `detailmapelguru`
MODIFY `id_detail` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `detailmapelkelas`
--
ALTER TABLE `detailmapelkelas`
MODIFY `id_detail` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `kelas`
--
ALTER TABLE `kelas`
MODIFY `kode_kelas` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=10;
--
-- AUTO_INCREMENT for table `nilai`
--
ALTER TABLE `nilai`
MODIFY `id_nilai` int(11) NOT NULL AUTO_INCREMENT;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
