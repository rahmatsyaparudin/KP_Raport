-- phpMyAdmin SQL Dump
-- version 4.2.11
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Dec 18, 2015 at 09:26 PM
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
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `deskripsi`
--

INSERT INTO `deskripsi` (`id_deskripsi`, `kode_kelas`, `kode_mapel`, `kode_semester`, `p_atas`, `p_tengah`, `p_bawah`, `k_atas`, `k_tengah`, `k_bawah`, `s_atas`, `s_tengah`, `s_bawah`) VALUES
(2, 3, 'BIND', 'SMT1', 'Sudah memiliki kompetensi memahami, membandingkan, menganalisis dan mengevaluasi teks cerita pendek, teks pantun, dan teks cerita ulang baik melalui lisan maupun tulisan', 'Sudah memiliki kompetensi memahami, membandingkan, menganalisis dan mengevaluasi teks cerita pendek, teks pantun, dan teks cerita ulang baik melalui lisan maupun tulisan tetapi masih memerlukan banyak latihan untuk konsep teks cerita pendek', 'Sudah memiliki kompetensi memahami, membandingkan, menganalisis dan mengevaluasi teks cerita pendek, teks pantun, dan teks cerita ulang baik melalui lisan maupun tulisan tetapi masih memerlukan banyak latihan untuk konsep teks cerita pendek dan teks pantun', 'Sudah mampu menginterpretasi, memproduksi, menyunting dan mengonvensi teks cerita pendek, teks pantun, teks cerita ulang baik secara lisan maupun tulisan', 'Sudah mampu menginterpretasi, memproduksi, menyunting dan mengonvensi teks cerita pendek, teks pantun, teks cerita ulang baik secara lisan maupun tulisan tetapi masih memerlukan tulisan untuk teks cerita pendek', 'Sudah mampu menginterpretasi, memproduksi, menyunting dan mengonvensi teks cerita pendek, teks pantun, teks cerita ulang baik secara lisan maupun tulisan tetapi  memerlukan latihan untuk konsep teks cerita pendek dan teks pantun', 'Sudah menghayati dan mengamalkan ajaran agama yang dianutnya. Menunjukan sikap bertanggung jawab, responsif, santun, jujur dalam menggunakan bahasa Indonesia', 'Sudah menghayati dan mengamalkan ajaran agama yang dianutnya. Menunjukan sikap bertanggung jawab, responsif, santun, jujur dalam menggunakan bahasa Indonesia tetapi masih harus membudayakan sikap santun.', 'Sudah menghayati dan mengamalkan ajaran agama yang dianutnya. Menunjukan sikap bertanggung jawab, responsif, santun, jujur dalam menggunakan bahasa Indonesia tetapi masih harus membudayakan sikap santun, jujur, dan tanggung jawab.'),
(3, 3, 'BING', 'SMT1', 'Sudah mampu menganalisis struktur teks, unsur kebahasaan dan ungkapan pendapat, doa, teks undangan, teks surat pribadi, dan teks prosedur', 'Sudah mampu menganalisis sebagian struktur teks, unsur kebahasaan dan ungkapan pendapat, doa teks undangan , teks surat pribadi, dan teks prosedur', 'Belum mampu menganalisis sebagian struktur teks, unsur kebahasaan dan ungkapan pendapat, doa teks undangan , teks surat pribadi, dan teks prosedur dengan sempurna', 'Sudah mampu menyusun teks lisan dan tulis dengan saran, tawaran, ungkapan pendapat, harapan dan doa dengan struktur dan unsur kebahasaan', 'Sudah mampu menyusun teks lisan dan tulis dengan saran, tawaran, ungkapan pendapat, harapan dan doa dengan struktur dan unsur kebahasaan dengan sempurna', 'Belum mampu menyusun teks lisan dan tulis dengan saran, tawaran, ungkapan pendapat, harapan dan doa dengan struktur dan unsur kebahasaan dengan sempurna', 'Sudah mampu menunjukan prilaku santun, jujur, disiplin,percaya diri, peduli, kerja sama dan cinta damai', 'Sudah mampu menunjukan sebagian prilaku santun, jujur, disiplin,percaya diri, peduli, kerja sama dan cinta damai', 'Belum mampu menunjukan prilaku santun, jujur, disiplin,percaya diri, peduli, kerja sama dan cinta damai'),
(4, 3, 'BIO', 'SMT1', 'Memiliki Kompetensi sel, jaringan, organ hewan, tumbuhan dan hewan serta sistem sirkulasi', 'Memiliki Kompetensi sel, jaringan, organ hewan, tumbuhan dan hewan serta sistem sirkulasi tetapi untuk sistem gerak perlu pendalaman lebih lanjut', 'Memiliki Kompetensi sel, jaringan, organ hewan, tumbuhan, tetapi sistem sirkulasi dan sistem gerak perlu pendalaman lanjut', 'Sudah berprilaku ilmiah, teliti, tekun, berpendapat secara ilmiah, kritis dalam mengamati sel, jaringan, organ hewan dan tumbuhan serta sistem gerak dan sistem sirkulasi', 'Sudah berprilaku ilmiah, teliti, tekun, berpendapat secara ilmiah, kritis dalam mengamati tetapi belum responsip dan proaktif dalam mengamati sel, jaringan, organ hewan dan tumbuhan serta sistem gerak dan sistem sirkulasi', 'Sudah berprilaku ilmiah, teliti, tekun, tetapi  berpendapat secara ilmiah, kritis dalam mengamati tetapi belum responsip dan proaktif dalam mengamati sel, jaringan, organ hewan dan tumbuhan serta sistem gerak dan sistem sirkulasi', 'Sudah menghayati dan mengamalkan ajaran agama yang dianutnya memiliki inovasi internal jujur, disiplin, tanggung jawab, peduli, (gotong royong, kerja sama, toleran damai) santun responsip dan proaktif menunjukan sikap sebagai bagian dari solusi atas berbagai permasalahan dalam berinteraksi secara efektif dengan lingkungan sosial dan alam serta dalam menempatkan diri sebagai cerminan bangsa dalam pergaulan dunia.', 'Sudah menghayati dan mengamalkan ajaran agama yang dianutnya memiliki inovasi internal jujur, disiplin, tanggung jawab, peduli, (gotong royong, kerja sama, toleran damai) santun responsip dan proaktif namun perlu peningkatan sikap sebagai bagian dari solusi atas berbagai permasalahan dalam berinteraksi secara efektif dengan lingkungan sosial dan alam serta dalam menempatkan diri sebagai cerminan bangsa dalam pergaulan dunia.', 'Sudah menghayati dan mengamalkan ajaran agama yang dianutnya memiliki inovasi internal jujur, disiplin, tanggung jawab, peduli, (gotong royong, kerja sama, toleran damai) santun  namun perlu peningkatan sikap responsif dan proaktif sebagai bagian dari solusi atas berbagai permasalahan dalam berinteraksi secara efektif dengan lingkungan sosial dan alam serta dalam menempatkan diri sebagai cerminan bangsa dalam pergaulan dunia.'),
(5, 3, 'BSND', 'SMT1', '', '', '', '', '', '', '', '', ''),
(6, 3, 'EKO', 'SMT1', '', '', '', '', '', '', '', '', ''),
(7, 3, 'FIS', 'SMT1', '', '', '', '', '', '', '', '', ''),
(8, 3, 'KIM', 'SMT1', '', '', '', '', '', '', '', '', ''),
(9, 3, 'MATA', 'SMT1', '', '', '', '', '', '', '', '', ''),
(10, 3, 'MATC', 'SMT1', '', '', '', '', '', '', '', '', ''),
(11, 3, 'OR', 'SMT1', '', '', '', '', '', '', '', '', ''),
(12, 3, 'PAI', 'SMT1', '', '', '', '', '', '', '', '', ''),
(13, 3, 'PK', 'SMT1', '', '', '', '', '', '', '', '', ''),
(14, 3, 'PKN', 'SMT1', '', '', '', '', '', '', '', '', ''),
(15, 3, 'SB', 'SMT1', '', '', '', '', '', '', '', '', ''),
(16, 3, 'SEJA', 'SMT1', '', '', '', '', '', '', '', '', '');

-- --------------------------------------------------------

--
-- Table structure for table `deskripsieskul`
--

CREATE TABLE IF NOT EXISTS `deskripsieskul` (
`id_deskripsieskul` int(11) NOT NULL,
  `kode_eskul` varchar(8) NOT NULL,
  `nis_siswa` varchar(13) NOT NULL,
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
) ENGINE=InnoDB AUTO_INCREMENT=338 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `detailkelassiswa`
--

INSERT INTO `detailkelassiswa` (`id_detail`, `kode_kelas`, `nis_siswa`, `keterangan`) VALUES
(204, 3, '1314.10.006', 'Data Siswa'),
(205, 3, '1314.10.020', 'Data Siswa'),
(206, 3, '1314.10.026', 'Data Siswa'),
(207, 3, '1314.10.044', 'Data Siswa'),
(208, 3, '1314.10.050', 'Data Siswa'),
(209, 3, '1314.10.057', 'Data Siswa'),
(210, 3, '1314.10.072', 'Data Siswa'),
(211, 3, '1314.10.076', 'Data Siswa'),
(212, 3, '1314.10.099', 'Data Siswa'),
(213, 3, '1314.10.102', 'Data Siswa'),
(214, 3, '1314.10.121', 'Data Siswa'),
(215, 3, '1314.10.128', 'Data Siswa'),
(216, 3, '1314.10.136', 'Data Siswa'),
(217, 3, '1314.10.150', 'Data Siswa'),
(218, 3, '1314.10.153', 'Data Siswa'),
(219, 3, '1314.10.168', 'Data Siswa'),
(220, 3, '1314.10.171', 'Data Siswa'),
(221, 3, '1314.10.190', 'Data Siswa'),
(222, 3, '1314.10.202', 'Data Siswa'),
(223, 3, '1314.10.203', 'Data Siswa'),
(224, 3, '1314.10.210', 'Data Siswa'),
(225, 3, '1314.10.224', 'Data Siswa'),
(226, 3, '1314.10.235', 'Data Siswa'),
(227, 3, '1314.10.241', 'Data Siswa'),
(228, 3, '1314.10.258', 'Data Siswa'),
(229, 3, '1314.10.262', 'Data Siswa'),
(230, 3, '1314.10.271', 'Data Siswa'),
(231, 3, '1314.10.279', 'Data Siswa'),
(232, 3, '1314.10.293', 'Data Siswa'),
(233, 3, '1314.10.294', 'Data Siswa'),
(234, 3, '1314.10.314', 'Data Siswa'),
(235, 3, '1314.10.322', 'Data Siswa'),
(236, 3, '1314.10.324', 'Data Siswa'),
(237, 3, '1314.10.344', 'Data Siswa'),
(238, 3, '1314.10.352', 'Data Siswa'),
(239, 3, '1314.10.364', 'Data Siswa'),
(240, 3, '1314.10.381', 'Data Siswa'),
(241, 3, '1314.10.392', 'Data Siswa'),
(242, 3, '1314.10.396', 'Data Siswa'),
(243, 3, '1314.10.405', 'Data Siswa'),
(287, 10, '1314.10.026', 'Data Kelas'),
(288, 10, '1314.10.044', 'Data Kelas'),
(289, 10, '1314.10.050', 'Data Kelas'),
(290, 10, '1314.10.057', 'Data Kelas'),
(291, 10, '1314.10.072', 'Data Kelas'),
(292, 10, '1314.10.076', 'Data Kelas'),
(293, 10, '1314.10.099', 'Data Kelas'),
(294, 10, '1314.10.102', 'Data Kelas'),
(295, 10, '1314.10.121', 'Data Kelas'),
(296, 10, '1314.10.128', 'Data Kelas'),
(297, 10, '1314.10.136', 'Data Kelas'),
(298, 10, '1314.10.150', 'Data Kelas'),
(299, 10, '1314.10.153', 'Data Kelas'),
(300, 10, '1314.10.168', 'Data Kelas'),
(301, 10, '1314.10.171', 'Data Kelas'),
(302, 10, '1314.10.190', 'Data Kelas'),
(303, 10, '1314.10.202', 'Data Kelas'),
(304, 10, '1314.10.203', 'Data Kelas'),
(305, 10, '1314.10.210', 'Data Kelas'),
(306, 10, '1314.10.224', 'Data Kelas'),
(307, 10, '1314.10.235', 'Data Kelas'),
(308, 10, '1314.10.241', 'Data Kelas'),
(309, 10, '1314.10.258', 'Data Kelas'),
(310, 10, '1314.10.262', 'Data Kelas'),
(311, 10, '1314.10.271', 'Data Kelas'),
(312, 10, '1314.10.279', 'Data Kelas'),
(313, 10, '1314.10.293', 'Data Kelas'),
(314, 10, '1314.10.294', 'Data Kelas'),
(315, 10, '1314.10.314', 'Data Kelas'),
(316, 10, '1314.10.322', 'Data Kelas'),
(317, 10, '1314.10.324', 'Data Kelas'),
(318, 10, '1314.10.344', 'Data Kelas'),
(319, 10, '1314.10.352', 'Data Kelas'),
(320, 10, '1314.10.364', 'Data Kelas'),
(321, 10, '1314.10.381', 'Data Kelas'),
(322, 10, '1314.10.392', 'Data Kelas'),
(323, 10, '1314.10.396', 'Data Kelas'),
(324, 10, '1314.10.405', 'Data Kelas'),
(336, 10, '1314.10.006', 'Data Kelas'),
(337, 10, '1314.10.020', 'Data Kelas');

-- --------------------------------------------------------

--
-- Table structure for table `detailmapelguru`
--

CREATE TABLE IF NOT EXISTS `detailmapelguru` (
`id_detail` int(11) NOT NULL,
  `id_guru` int(11) NOT NULL,
  `kode_mapel` varchar(6) NOT NULL,
  `tahun_ajaran` varchar(15) NOT NULL,
  `status` varchar(12) NOT NULL DEFAULT 'Aktif'
) ENGINE=InnoDB AUTO_INCREMENT=47 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `detailmapelguru`
--

INSERT INTO `detailmapelguru` (`id_detail`, `id_guru`, `kode_mapel`, `tahun_ajaran`, `status`) VALUES
(29, 51452, 'PAI', '2015/2016', 'Aktif'),
(30, 22833, 'PKN', '2015/2016', 'Aktif'),
(31, 71975, 'BIND', '2015/2016', 'Aktif'),
(32, 27674, 'MATA', '2015/2016', 'Aktif'),
(33, 27674, 'MATC', '2015/2016', 'Aktif'),
(34, 28584, 'SEJA', '2015/2016', 'Aktif'),
(35, 90844, 'BING', '2015/2016', 'Aktif'),
(36, 94933, 'SB', '2015/2016', 'Aktif'),
(37, 6762, 'OR', '2015/2016', 'Aktif'),
(38, 68207, 'PK', '2015/2016', 'Aktif'),
(39, 35393, 'BSND', '2015/2016', 'Aktif'),
(40, 42882, 'BIO', '2015/2016', 'Aktif'),
(41, 2019, 'FIS', '2015/2016', 'Aktif'),
(42, 66870, 'KIM', '2015/2016', 'Aktif'),
(43, 41263, 'EKO', '2015/2016', 'Aktif'),
(44, 27674, 'MATA', '2016/2017', 'Aktif'),
(45, 27674, 'PAI', '2016/2017', 'Aktif'),
(46, 27674, 'PKN', '2016/2017', 'Aktif');

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
) ENGINE=InnoDB AUTO_INCREMENT=112 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `detailmapelkelas`
--

INSERT INTO `detailmapelkelas` (`id_detail`, `kode_kelas`, `id_guru`, `kode_mapel`, `status`) VALUES
(97, 3, 27674, 'MATA', 'Aktif'),
(98, 3, 51452, 'PAI', 'Aktif'),
(99, 3, 22833, 'PKN', 'Aktif'),
(100, 3, 28584, 'SEJA', 'Aktif'),
(101, 3, 90844, 'BING', 'Aktif'),
(102, 3, 71975, 'BIND', 'Aktif'),
(103, 3, 94933, 'SB', 'Aktif'),
(104, 3, 68207, 'PK', 'Aktif'),
(105, 3, 35393, 'BSND', 'Aktif'),
(106, 3, 6762, 'OR', 'Aktif'),
(107, 3, 27674, 'MATC', 'Aktif'),
(108, 3, 66870, 'KIM', 'Aktif'),
(109, 3, 42882, 'BIO', 'Aktif'),
(110, 3, 41263, 'EKO', 'Aktif'),
(111, 3, 2019, 'FIS', 'Aktif');

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
(27674, '', '', 'Ahmad Saropudin Asalim, S.Pd.', 'Aktif', ''),
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
(51452, '196202051986031012', '0834740642200082', 'Drs. Sahrudin', 'Aktif', 'Koordinator Keagamaan'),
(51677, '', '0842758660300082', 'Rani Sri Nurbayanti', 'Aktif', 'Wali Kelas 11 MIPA 5, Pembina Ekskul Pramuka'),
(51703, '196409011988032005', '4441742645300002', 'Erni Nurilah, S,Pd., M.M.Pd.', 'Aktif', 'Wk. Urusan Humas'),
(54159, '195908011983031016', '3440737639200042', 'Edi Yama, S.Pd., M.M.Pd.', 'Aktif', 'Kepala Sekolah'),
(63760, '197308142003122002', '7146751654300013', 'Ina Rahmawati, S.Pd.', 'Aktif', 'Staf. Wk. Urs. Kesiswaan'),
(66870, '196306221989031006', '5954741646200002', 'H. Muhammad Syafrudin, S.Pd.', 'Aktif', 'Koordinator Laboratorium'),
(68207, '', '', 'Deliar Rahman Firdaus, S.Pd.', 'Aktif', 'Wali Kelas 11 IIS 5'),
(71940, '197106272007012004', '2938751650300002', 'N. Inawati Islamiah, S.Pd.', 'Aktif', 'Wali Kelas 12 MIPA 1'),
(71975, '', '1747761662300092', 'Rima Nurkomala, S.S.', 'Aktif', 'Wali Kelas 11 IIS 1, Pembina Ekskul Paskibra'),
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
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `kelas`
--

INSERT INTO `kelas` (`kode_kelas`, `nama_kelas`, `tahun_ajaran`, `jumlah_siswa`, `id_guru`, `status_kelas`) VALUES
(1, 'X MIPA 1', '2015/2016', 0, 43390, 'Aktif'),
(2, 'X MIPA 2', '2015/2016', 0, 91585, 'Aktif'),
(3, 'XI MIPA 3', '2015/2016', 40, 51452, 'Aktif'),
(4, 'XI MIPA 1', '2015/2016', 0, 6762, 'Aktif'),
(5, 'XI MIPA 2', '2015/2016', 1, 22397, 'Aktif'),
(6, 'X IIS 1', '2015/2016', 0, 68207, 'Aktif'),
(7, 'X IIS 2 ', '2015/2016', 0, 48736, 'Aktif'),
(8, 'XII IIS 1', '2015/2016', 0, 2105, 'Aktif'),
(9, 'XII IIS 2', '2015/2016', 0, 84155, 'Aktif'),
(10, 'XII MIPA 3', '2016/2017', 40, 34549, 'Aktif'),
(11, 'XII MIPA 1', '2016/2017', 1, 34549, 'Aktif'),
(12, 'XI MIPA 3', '2016/2017', 1, 22397, 'Aktif');

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
  `p_pred` varchar(4) NOT NULL DEFAULT '',
  `p_desk` longtext NOT NULL,
  `k_skala` int(11) NOT NULL DEFAULT '0',
  `k_ang` float NOT NULL DEFAULT '0',
  `k_pred` varchar(4) NOT NULL DEFAULT '',
  `k_desk` longtext NOT NULL,
  `s_skala` int(11) NOT NULL DEFAULT '0',
  `s_sikap` varchar(4) NOT NULL DEFAULT '',
  `s_desk` longtext NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=1324 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `nilai`
--

INSERT INTO `nilai` (`id_nilai`, `nis_siswa`, `kode_kelas`, `kode_mapel`, `kode_semester`, `p_skala`, `p_ang`, `p_pred`, `p_desk`, `k_skala`, `k_ang`, `k_pred`, `k_desk`, `s_skala`, `s_sikap`, `s_desk`) VALUES
(684, '1314.10.006', 3, 'BIND', 'SMT1', 79, 3.16, 'B', 'T', 80, 3.2, 'B+', 'A', 67, 'B', 'T'),
(686, '1314.10.026', 3, 'BIND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(687, '1314.10.044', 3, 'BIND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(688, '1314.10.050', 3, 'BIND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(689, '1314.10.057', 3, 'BIND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(690, '1314.10.072', 3, 'BIND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(691, '1314.10.076', 3, 'BIND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(692, '1314.10.099', 3, 'BIND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(693, '1314.10.102', 3, 'BIND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(694, '1314.10.121', 3, 'BIND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(695, '1314.10.128', 3, 'BIND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(696, '1314.10.136', 3, 'BIND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(697, '1314.10.150', 3, 'BIND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(698, '1314.10.153', 3, 'BIND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(699, '1314.10.168', 3, 'BIND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(700, '1314.10.171', 3, 'BIND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(701, '1314.10.190', 3, 'BIND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(702, '1314.10.202', 3, 'BIND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(703, '1314.10.203', 3, 'BIND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(704, '1314.10.210', 3, 'BIND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(705, '1314.10.224', 3, 'BIND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(706, '1314.10.235', 3, 'BIND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(707, '1314.10.241', 3, 'BIND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(708, '1314.10.258', 3, 'BIND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(709, '1314.10.262', 3, 'BIND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(710, '1314.10.271', 3, 'BIND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(711, '1314.10.279', 3, 'BIND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(712, '1314.10.293', 3, 'BIND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(713, '1314.10.294', 3, 'BIND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(714, '1314.10.314', 3, 'BIND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(715, '1314.10.322', 3, 'BIND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(716, '1314.10.324', 3, 'BIND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(717, '1314.10.344', 3, 'BIND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(718, '1314.10.352', 3, 'BIND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(719, '1314.10.364', 3, 'BIND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(720, '1314.10.381', 3, 'BIND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(721, '1314.10.392', 3, 'BIND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(722, '1314.10.396', 3, 'BIND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(723, '1314.10.405', 3, 'BIND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(724, '1314.10.006', 3, 'BING', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(726, '1314.10.026', 3, 'BING', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(727, '1314.10.044', 3, 'BING', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(728, '1314.10.050', 3, 'BING', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(729, '1314.10.057', 3, 'BING', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(730, '1314.10.072', 3, 'BING', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(731, '1314.10.076', 3, 'BING', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(732, '1314.10.099', 3, 'BING', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(733, '1314.10.102', 3, 'BING', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(734, '1314.10.121', 3, 'BING', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(735, '1314.10.128', 3, 'BING', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(736, '1314.10.136', 3, 'BING', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(737, '1314.10.150', 3, 'BING', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(738, '1314.10.153', 3, 'BING', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(739, '1314.10.168', 3, 'BING', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(740, '1314.10.171', 3, 'BING', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(741, '1314.10.190', 3, 'BING', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(742, '1314.10.202', 3, 'BING', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(743, '1314.10.203', 3, 'BING', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(744, '1314.10.210', 3, 'BING', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(745, '1314.10.224', 3, 'BING', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(746, '1314.10.235', 3, 'BING', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(747, '1314.10.241', 3, 'BING', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(748, '1314.10.258', 3, 'BING', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(749, '1314.10.262', 3, 'BING', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(750, '1314.10.271', 3, 'BING', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(751, '1314.10.279', 3, 'BING', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(752, '1314.10.293', 3, 'BING', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(753, '1314.10.294', 3, 'BING', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(754, '1314.10.314', 3, 'BING', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(755, '1314.10.322', 3, 'BING', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(756, '1314.10.324', 3, 'BING', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(757, '1314.10.344', 3, 'BING', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(758, '1314.10.352', 3, 'BING', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(759, '1314.10.364', 3, 'BING', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(760, '1314.10.381', 3, 'BING', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(761, '1314.10.392', 3, 'BING', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(762, '1314.10.396', 3, 'BING', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(763, '1314.10.405', 3, 'BING', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(764, '1314.10.006', 3, 'BIO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(766, '1314.10.026', 3, 'BIO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(767, '1314.10.044', 3, 'BIO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(768, '1314.10.050', 3, 'BIO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(769, '1314.10.057', 3, 'BIO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(770, '1314.10.072', 3, 'BIO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(771, '1314.10.076', 3, 'BIO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(772, '1314.10.099', 3, 'BIO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(773, '1314.10.102', 3, 'BIO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(774, '1314.10.121', 3, 'BIO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(775, '1314.10.128', 3, 'BIO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(776, '1314.10.136', 3, 'BIO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(777, '1314.10.150', 3, 'BIO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(778, '1314.10.153', 3, 'BIO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(779, '1314.10.168', 3, 'BIO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(780, '1314.10.171', 3, 'BIO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(781, '1314.10.190', 3, 'BIO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(782, '1314.10.202', 3, 'BIO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(783, '1314.10.203', 3, 'BIO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(784, '1314.10.210', 3, 'BIO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(785, '1314.10.224', 3, 'BIO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(786, '1314.10.235', 3, 'BIO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(787, '1314.10.241', 3, 'BIO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(788, '1314.10.258', 3, 'BIO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(789, '1314.10.262', 3, 'BIO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(790, '1314.10.271', 3, 'BIO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(791, '1314.10.279', 3, 'BIO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(792, '1314.10.293', 3, 'BIO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(793, '1314.10.294', 3, 'BIO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(794, '1314.10.314', 3, 'BIO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(795, '1314.10.322', 3, 'BIO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(796, '1314.10.324', 3, 'BIO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(797, '1314.10.344', 3, 'BIO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(798, '1314.10.352', 3, 'BIO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(799, '1314.10.364', 3, 'BIO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(800, '1314.10.381', 3, 'BIO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(801, '1314.10.392', 3, 'BIO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(802, '1314.10.396', 3, 'BIO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(803, '1314.10.405', 3, 'BIO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(804, '1314.10.006', 3, 'BSND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(806, '1314.10.026', 3, 'BSND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(807, '1314.10.044', 3, 'BSND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(808, '1314.10.050', 3, 'BSND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(809, '1314.10.057', 3, 'BSND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(810, '1314.10.072', 3, 'BSND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(811, '1314.10.076', 3, 'BSND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(812, '1314.10.099', 3, 'BSND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(813, '1314.10.102', 3, 'BSND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(814, '1314.10.121', 3, 'BSND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(815, '1314.10.128', 3, 'BSND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(816, '1314.10.136', 3, 'BSND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(817, '1314.10.150', 3, 'BSND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(818, '1314.10.153', 3, 'BSND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(819, '1314.10.168', 3, 'BSND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(820, '1314.10.171', 3, 'BSND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(821, '1314.10.190', 3, 'BSND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(822, '1314.10.202', 3, 'BSND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(823, '1314.10.203', 3, 'BSND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(824, '1314.10.210', 3, 'BSND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(825, '1314.10.224', 3, 'BSND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(826, '1314.10.235', 3, 'BSND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(827, '1314.10.241', 3, 'BSND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(828, '1314.10.258', 3, 'BSND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(829, '1314.10.262', 3, 'BSND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(830, '1314.10.271', 3, 'BSND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(831, '1314.10.279', 3, 'BSND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(832, '1314.10.293', 3, 'BSND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(833, '1314.10.294', 3, 'BSND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(834, '1314.10.314', 3, 'BSND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(835, '1314.10.322', 3, 'BSND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(836, '1314.10.324', 3, 'BSND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(837, '1314.10.344', 3, 'BSND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(838, '1314.10.352', 3, 'BSND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(839, '1314.10.364', 3, 'BSND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(840, '1314.10.381', 3, 'BSND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(841, '1314.10.392', 3, 'BSND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(842, '1314.10.396', 3, 'BSND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(843, '1314.10.405', 3, 'BSND', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(844, '1314.10.006', 3, 'EKO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(846, '1314.10.026', 3, 'EKO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(847, '1314.10.044', 3, 'EKO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(848, '1314.10.050', 3, 'EKO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(849, '1314.10.057', 3, 'EKO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(850, '1314.10.072', 3, 'EKO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(851, '1314.10.076', 3, 'EKO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(852, '1314.10.099', 3, 'EKO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(853, '1314.10.102', 3, 'EKO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(854, '1314.10.121', 3, 'EKO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(855, '1314.10.128', 3, 'EKO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(856, '1314.10.136', 3, 'EKO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(857, '1314.10.150', 3, 'EKO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(858, '1314.10.153', 3, 'EKO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(859, '1314.10.168', 3, 'EKO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(860, '1314.10.171', 3, 'EKO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(861, '1314.10.190', 3, 'EKO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(862, '1314.10.202', 3, 'EKO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(863, '1314.10.203', 3, 'EKO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(864, '1314.10.210', 3, 'EKO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(865, '1314.10.224', 3, 'EKO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(866, '1314.10.235', 3, 'EKO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(867, '1314.10.241', 3, 'EKO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(868, '1314.10.258', 3, 'EKO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(869, '1314.10.262', 3, 'EKO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(870, '1314.10.271', 3, 'EKO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(871, '1314.10.279', 3, 'EKO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(872, '1314.10.293', 3, 'EKO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(873, '1314.10.294', 3, 'EKO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(874, '1314.10.314', 3, 'EKO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(875, '1314.10.322', 3, 'EKO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(876, '1314.10.324', 3, 'EKO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(877, '1314.10.344', 3, 'EKO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(878, '1314.10.352', 3, 'EKO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(879, '1314.10.364', 3, 'EKO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(880, '1314.10.381', 3, 'EKO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(881, '1314.10.392', 3, 'EKO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(882, '1314.10.396', 3, 'EKO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(883, '1314.10.405', 3, 'EKO', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(884, '1314.10.006', 3, 'FIS', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(886, '1314.10.026', 3, 'FIS', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(887, '1314.10.044', 3, 'FIS', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(888, '1314.10.050', 3, 'FIS', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(889, '1314.10.057', 3, 'FIS', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(890, '1314.10.072', 3, 'FIS', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(891, '1314.10.076', 3, 'FIS', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(892, '1314.10.099', 3, 'FIS', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(893, '1314.10.102', 3, 'FIS', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(894, '1314.10.121', 3, 'FIS', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(895, '1314.10.128', 3, 'FIS', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(896, '1314.10.136', 3, 'FIS', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(897, '1314.10.150', 3, 'FIS', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(898, '1314.10.153', 3, 'FIS', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(899, '1314.10.168', 3, 'FIS', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(900, '1314.10.171', 3, 'FIS', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(901, '1314.10.190', 3, 'FIS', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(902, '1314.10.202', 3, 'FIS', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(903, '1314.10.203', 3, 'FIS', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(904, '1314.10.210', 3, 'FIS', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(905, '1314.10.224', 3, 'FIS', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(906, '1314.10.235', 3, 'FIS', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(907, '1314.10.241', 3, 'FIS', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(908, '1314.10.258', 3, 'FIS', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(909, '1314.10.262', 3, 'FIS', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(910, '1314.10.271', 3, 'FIS', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(911, '1314.10.279', 3, 'FIS', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(912, '1314.10.293', 3, 'FIS', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(913, '1314.10.294', 3, 'FIS', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(914, '1314.10.314', 3, 'FIS', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(915, '1314.10.322', 3, 'FIS', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(916, '1314.10.324', 3, 'FIS', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(917, '1314.10.344', 3, 'FIS', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(918, '1314.10.352', 3, 'FIS', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(919, '1314.10.364', 3, 'FIS', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(920, '1314.10.381', 3, 'FIS', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(921, '1314.10.392', 3, 'FIS', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(922, '1314.10.396', 3, 'FIS', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(923, '1314.10.405', 3, 'FIS', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(924, '1314.10.006', 3, 'KIM', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(926, '1314.10.026', 3, 'KIM', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(927, '1314.10.044', 3, 'KIM', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(928, '1314.10.050', 3, 'KIM', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(929, '1314.10.057', 3, 'KIM', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(930, '1314.10.072', 3, 'KIM', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(931, '1314.10.076', 3, 'KIM', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(932, '1314.10.099', 3, 'KIM', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(933, '1314.10.102', 3, 'KIM', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(934, '1314.10.121', 3, 'KIM', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(935, '1314.10.128', 3, 'KIM', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(936, '1314.10.136', 3, 'KIM', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(937, '1314.10.150', 3, 'KIM', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(938, '1314.10.153', 3, 'KIM', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(939, '1314.10.168', 3, 'KIM', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(940, '1314.10.171', 3, 'KIM', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(941, '1314.10.190', 3, 'KIM', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(942, '1314.10.202', 3, 'KIM', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(943, '1314.10.203', 3, 'KIM', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(944, '1314.10.210', 3, 'KIM', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(945, '1314.10.224', 3, 'KIM', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(946, '1314.10.235', 3, 'KIM', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(947, '1314.10.241', 3, 'KIM', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(948, '1314.10.258', 3, 'KIM', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(949, '1314.10.262', 3, 'KIM', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(950, '1314.10.271', 3, 'KIM', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(951, '1314.10.279', 3, 'KIM', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(952, '1314.10.293', 3, 'KIM', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(953, '1314.10.294', 3, 'KIM', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(954, '1314.10.314', 3, 'KIM', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(955, '1314.10.322', 3, 'KIM', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(956, '1314.10.324', 3, 'KIM', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(957, '1314.10.344', 3, 'KIM', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(958, '1314.10.352', 3, 'KIM', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(959, '1314.10.364', 3, 'KIM', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(960, '1314.10.381', 3, 'KIM', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(961, '1314.10.392', 3, 'KIM', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(962, '1314.10.396', 3, 'KIM', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(963, '1314.10.405', 3, 'KIM', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(964, '1314.10.006', 3, 'MATA', 'SMT1', 79, 3.16, 'B', 'T', 87, 3.48, 'B+', 'T', 73, 'B', 'T'),
(966, '1314.10.026', 3, 'MATA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(967, '1314.10.044', 3, 'MATA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(968, '1314.10.050', 3, 'MATA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(969, '1314.10.057', 3, 'MATA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(970, '1314.10.072', 3, 'MATA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(971, '1314.10.076', 3, 'MATA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(972, '1314.10.099', 3, 'MATA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(973, '1314.10.102', 3, 'MATA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(974, '1314.10.121', 3, 'MATA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(975, '1314.10.128', 3, 'MATA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(976, '1314.10.136', 3, 'MATA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(977, '1314.10.150', 3, 'MATA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(978, '1314.10.153', 3, 'MATA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(979, '1314.10.168', 3, 'MATA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(980, '1314.10.171', 3, 'MATA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(981, '1314.10.190', 3, 'MATA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(982, '1314.10.202', 3, 'MATA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(983, '1314.10.203', 3, 'MATA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(984, '1314.10.210', 3, 'MATA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(985, '1314.10.224', 3, 'MATA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(986, '1314.10.235', 3, 'MATA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(987, '1314.10.241', 3, 'MATA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(988, '1314.10.258', 3, 'MATA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(989, '1314.10.262', 3, 'MATA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(990, '1314.10.271', 3, 'MATA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(991, '1314.10.279', 3, 'MATA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(992, '1314.10.293', 3, 'MATA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(993, '1314.10.294', 3, 'MATA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(994, '1314.10.314', 3, 'MATA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(995, '1314.10.322', 3, 'MATA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(996, '1314.10.324', 3, 'MATA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(997, '1314.10.344', 3, 'MATA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(998, '1314.10.352', 3, 'MATA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(999, '1314.10.364', 3, 'MATA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1000, '1314.10.381', 3, 'MATA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1001, '1314.10.392', 3, 'MATA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1002, '1314.10.396', 3, 'MATA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1003, '1314.10.405', 3, 'MATA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1004, '1314.10.006', 3, 'MATC', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1006, '1314.10.026', 3, 'MATC', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1007, '1314.10.044', 3, 'MATC', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1008, '1314.10.050', 3, 'MATC', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1009, '1314.10.057', 3, 'MATC', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1010, '1314.10.072', 3, 'MATC', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1011, '1314.10.076', 3, 'MATC', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1012, '1314.10.099', 3, 'MATC', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1013, '1314.10.102', 3, 'MATC', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1014, '1314.10.121', 3, 'MATC', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1015, '1314.10.128', 3, 'MATC', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1016, '1314.10.136', 3, 'MATC', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1017, '1314.10.150', 3, 'MATC', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1018, '1314.10.153', 3, 'MATC', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1019, '1314.10.168', 3, 'MATC', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1020, '1314.10.171', 3, 'MATC', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1021, '1314.10.190', 3, 'MATC', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1022, '1314.10.202', 3, 'MATC', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1023, '1314.10.203', 3, 'MATC', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1024, '1314.10.210', 3, 'MATC', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1025, '1314.10.224', 3, 'MATC', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1026, '1314.10.235', 3, 'MATC', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1027, '1314.10.241', 3, 'MATC', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1028, '1314.10.258', 3, 'MATC', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1029, '1314.10.262', 3, 'MATC', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1030, '1314.10.271', 3, 'MATC', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1031, '1314.10.279', 3, 'MATC', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1032, '1314.10.293', 3, 'MATC', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1033, '1314.10.294', 3, 'MATC', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1034, '1314.10.314', 3, 'MATC', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1035, '1314.10.322', 3, 'MATC', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1036, '1314.10.324', 3, 'MATC', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1037, '1314.10.344', 3, 'MATC', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1038, '1314.10.352', 3, 'MATC', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1039, '1314.10.364', 3, 'MATC', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1040, '1314.10.381', 3, 'MATC', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1041, '1314.10.392', 3, 'MATC', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1042, '1314.10.396', 3, 'MATC', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1043, '1314.10.405', 3, 'MATC', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1044, '1314.10.006', 3, 'OR', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1046, '1314.10.026', 3, 'OR', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1047, '1314.10.044', 3, 'OR', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1048, '1314.10.050', 3, 'OR', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1049, '1314.10.057', 3, 'OR', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1050, '1314.10.072', 3, 'OR', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1051, '1314.10.076', 3, 'OR', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1052, '1314.10.099', 3, 'OR', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1053, '1314.10.102', 3, 'OR', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1054, '1314.10.121', 3, 'OR', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1055, '1314.10.128', 3, 'OR', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1056, '1314.10.136', 3, 'OR', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1057, '1314.10.150', 3, 'OR', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1058, '1314.10.153', 3, 'OR', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1059, '1314.10.168', 3, 'OR', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1060, '1314.10.171', 3, 'OR', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1061, '1314.10.190', 3, 'OR', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1062, '1314.10.202', 3, 'OR', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1063, '1314.10.203', 3, 'OR', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1064, '1314.10.210', 3, 'OR', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1065, '1314.10.224', 3, 'OR', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1066, '1314.10.235', 3, 'OR', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1067, '1314.10.241', 3, 'OR', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1068, '1314.10.258', 3, 'OR', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1069, '1314.10.262', 3, 'OR', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1070, '1314.10.271', 3, 'OR', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1071, '1314.10.279', 3, 'OR', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1072, '1314.10.293', 3, 'OR', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1073, '1314.10.294', 3, 'OR', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1074, '1314.10.314', 3, 'OR', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1075, '1314.10.322', 3, 'OR', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1076, '1314.10.324', 3, 'OR', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1077, '1314.10.344', 3, 'OR', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1078, '1314.10.352', 3, 'OR', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1079, '1314.10.364', 3, 'OR', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1080, '1314.10.381', 3, 'OR', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1081, '1314.10.392', 3, 'OR', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1082, '1314.10.396', 3, 'OR', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1083, '1314.10.405', 3, 'OR', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1084, '1314.10.006', 3, 'PAI', 'SMT1', 79, 3.16, 'B', 'T', 79, 3.16, 'B', 'T', 73, 'B', 'T'),
(1086, '1314.10.026', 3, 'PAI', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1087, '1314.10.044', 3, 'PAI', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1088, '1314.10.050', 3, 'PAI', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1089, '1314.10.057', 3, 'PAI', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1090, '1314.10.072', 3, 'PAI', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1091, '1314.10.076', 3, 'PAI', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1092, '1314.10.099', 3, 'PAI', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1093, '1314.10.102', 3, 'PAI', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1094, '1314.10.121', 3, 'PAI', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1095, '1314.10.128', 3, 'PAI', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1096, '1314.10.136', 3, 'PAI', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1097, '1314.10.150', 3, 'PAI', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1098, '1314.10.153', 3, 'PAI', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1099, '1314.10.168', 3, 'PAI', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1100, '1314.10.171', 3, 'PAI', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1101, '1314.10.190', 3, 'PAI', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1102, '1314.10.202', 3, 'PAI', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1103, '1314.10.203', 3, 'PAI', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1104, '1314.10.210', 3, 'PAI', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1105, '1314.10.224', 3, 'PAI', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1106, '1314.10.235', 3, 'PAI', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1107, '1314.10.241', 3, 'PAI', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1108, '1314.10.258', 3, 'PAI', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1109, '1314.10.262', 3, 'PAI', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1110, '1314.10.271', 3, 'PAI', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1111, '1314.10.279', 3, 'PAI', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1112, '1314.10.293', 3, 'PAI', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1113, '1314.10.294', 3, 'PAI', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1114, '1314.10.314', 3, 'PAI', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1115, '1314.10.322', 3, 'PAI', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1116, '1314.10.324', 3, 'PAI', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1117, '1314.10.344', 3, 'PAI', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1118, '1314.10.352', 3, 'PAI', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1119, '1314.10.364', 3, 'PAI', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1120, '1314.10.381', 3, 'PAI', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1121, '1314.10.392', 3, 'PAI', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1122, '1314.10.396', 3, 'PAI', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1123, '1314.10.405', 3, 'PAI', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1124, '1314.10.006', 3, 'PK', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1126, '1314.10.026', 3, 'PK', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1127, '1314.10.044', 3, 'PK', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1128, '1314.10.050', 3, 'PK', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1129, '1314.10.057', 3, 'PK', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1130, '1314.10.072', 3, 'PK', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1131, '1314.10.076', 3, 'PK', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1132, '1314.10.099', 3, 'PK', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1133, '1314.10.102', 3, 'PK', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1134, '1314.10.121', 3, 'PK', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1135, '1314.10.128', 3, 'PK', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1136, '1314.10.136', 3, 'PK', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1137, '1314.10.150', 3, 'PK', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1138, '1314.10.153', 3, 'PK', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1139, '1314.10.168', 3, 'PK', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1140, '1314.10.171', 3, 'PK', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1141, '1314.10.190', 3, 'PK', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1142, '1314.10.202', 3, 'PK', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1143, '1314.10.203', 3, 'PK', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1144, '1314.10.210', 3, 'PK', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1145, '1314.10.224', 3, 'PK', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1146, '1314.10.235', 3, 'PK', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1147, '1314.10.241', 3, 'PK', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1148, '1314.10.258', 3, 'PK', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1149, '1314.10.262', 3, 'PK', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1150, '1314.10.271', 3, 'PK', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1151, '1314.10.279', 3, 'PK', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1152, '1314.10.293', 3, 'PK', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1153, '1314.10.294', 3, 'PK', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1154, '1314.10.314', 3, 'PK', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1155, '1314.10.322', 3, 'PK', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1156, '1314.10.324', 3, 'PK', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1157, '1314.10.344', 3, 'PK', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1158, '1314.10.352', 3, 'PK', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1159, '1314.10.364', 3, 'PK', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1160, '1314.10.381', 3, 'PK', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1161, '1314.10.392', 3, 'PK', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1162, '1314.10.396', 3, 'PK', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1163, '1314.10.405', 3, 'PK', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1164, '1314.10.006', 3, 'PKN', 'SMT1', 88, 3.52, 'A-', 'A', 88, 3.52, 'A-', 'A', 73, 'B', 'T'),
(1166, '1314.10.026', 3, 'PKN', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1167, '1314.10.044', 3, 'PKN', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1168, '1314.10.050', 3, 'PKN', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1169, '1314.10.057', 3, 'PKN', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1170, '1314.10.072', 3, 'PKN', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1171, '1314.10.076', 3, 'PKN', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1172, '1314.10.099', 3, 'PKN', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1173, '1314.10.102', 3, 'PKN', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1174, '1314.10.121', 3, 'PKN', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1175, '1314.10.128', 3, 'PKN', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1176, '1314.10.136', 3, 'PKN', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1177, '1314.10.150', 3, 'PKN', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1178, '1314.10.153', 3, 'PKN', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1179, '1314.10.168', 3, 'PKN', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1180, '1314.10.171', 3, 'PKN', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1181, '1314.10.190', 3, 'PKN', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1182, '1314.10.202', 3, 'PKN', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1183, '1314.10.203', 3, 'PKN', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1184, '1314.10.210', 3, 'PKN', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1185, '1314.10.224', 3, 'PKN', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1186, '1314.10.235', 3, 'PKN', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1187, '1314.10.241', 3, 'PKN', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1188, '1314.10.258', 3, 'PKN', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1189, '1314.10.262', 3, 'PKN', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1190, '1314.10.271', 3, 'PKN', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1191, '1314.10.279', 3, 'PKN', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1192, '1314.10.293', 3, 'PKN', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1193, '1314.10.294', 3, 'PKN', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1194, '1314.10.314', 3, 'PKN', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1195, '1314.10.322', 3, 'PKN', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1196, '1314.10.324', 3, 'PKN', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1197, '1314.10.344', 3, 'PKN', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1198, '1314.10.352', 3, 'PKN', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1199, '1314.10.364', 3, 'PKN', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1200, '1314.10.381', 3, 'PKN', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1201, '1314.10.392', 3, 'PKN', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1202, '1314.10.396', 3, 'PKN', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1203, '1314.10.405', 3, 'PKN', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1204, '1314.10.006', 3, 'SB', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1206, '1314.10.026', 3, 'SB', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1207, '1314.10.044', 3, 'SB', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1208, '1314.10.050', 3, 'SB', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1209, '1314.10.057', 3, 'SB', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1210, '1314.10.072', 3, 'SB', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1211, '1314.10.076', 3, 'SB', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1212, '1314.10.099', 3, 'SB', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1213, '1314.10.102', 3, 'SB', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1214, '1314.10.121', 3, 'SB', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1215, '1314.10.128', 3, 'SB', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1216, '1314.10.136', 3, 'SB', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1217, '1314.10.150', 3, 'SB', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1218, '1314.10.153', 3, 'SB', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1219, '1314.10.168', 3, 'SB', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1220, '1314.10.171', 3, 'SB', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1221, '1314.10.190', 3, 'SB', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1222, '1314.10.202', 3, 'SB', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1223, '1314.10.203', 3, 'SB', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1224, '1314.10.210', 3, 'SB', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1225, '1314.10.224', 3, 'SB', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1226, '1314.10.235', 3, 'SB', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1227, '1314.10.241', 3, 'SB', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1228, '1314.10.258', 3, 'SB', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1229, '1314.10.262', 3, 'SB', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1230, '1314.10.271', 3, 'SB', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1231, '1314.10.279', 3, 'SB', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1232, '1314.10.293', 3, 'SB', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1233, '1314.10.294', 3, 'SB', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1234, '1314.10.314', 3, 'SB', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1235, '1314.10.322', 3, 'SB', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1236, '1314.10.324', 3, 'SB', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1237, '1314.10.344', 3, 'SB', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1238, '1314.10.352', 3, 'SB', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1239, '1314.10.364', 3, 'SB', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1240, '1314.10.381', 3, 'SB', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1241, '1314.10.392', 3, 'SB', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1242, '1314.10.396', 3, 'SB', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1243, '1314.10.405', 3, 'SB', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1244, '1314.10.006', 3, 'SEJA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1246, '1314.10.026', 3, 'SEJA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1247, '1314.10.044', 3, 'SEJA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1248, '1314.10.050', 3, 'SEJA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1249, '1314.10.057', 3, 'SEJA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1250, '1314.10.072', 3, 'SEJA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1251, '1314.10.076', 3, 'SEJA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1252, '1314.10.099', 3, 'SEJA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1253, '1314.10.102', 3, 'SEJA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1254, '1314.10.121', 3, 'SEJA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1255, '1314.10.128', 3, 'SEJA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1256, '1314.10.136', 3, 'SEJA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1257, '1314.10.150', 3, 'SEJA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1258, '1314.10.153', 3, 'SEJA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1259, '1314.10.168', 3, 'SEJA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1260, '1314.10.171', 3, 'SEJA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1261, '1314.10.190', 3, 'SEJA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1262, '1314.10.202', 3, 'SEJA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1263, '1314.10.203', 3, 'SEJA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1264, '1314.10.210', 3, 'SEJA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1265, '1314.10.224', 3, 'SEJA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1266, '1314.10.235', 3, 'SEJA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1267, '1314.10.241', 3, 'SEJA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1268, '1314.10.258', 3, 'SEJA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1269, '1314.10.262', 3, 'SEJA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1270, '1314.10.271', 3, 'SEJA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1271, '1314.10.279', 3, 'SEJA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1272, '1314.10.293', 3, 'SEJA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1273, '1314.10.294', 3, 'SEJA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1274, '1314.10.314', 3, 'SEJA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1275, '1314.10.322', 3, 'SEJA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1276, '1314.10.324', 3, 'SEJA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1277, '1314.10.344', 3, 'SEJA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1278, '1314.10.352', 3, 'SEJA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1279, '1314.10.364', 3, 'SEJA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1280, '1314.10.381', 3, 'SEJA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1281, '1314.10.392', 3, 'SEJA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1282, '1314.10.396', 3, 'SEJA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1283, '1314.10.405', 3, 'SEJA', 'SMT1', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1284, '1314.10.006', 3, 'BIND', 'SMT2', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1286, '1314.10.026', 3, 'BIND', 'SMT2', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1287, '1314.10.044', 3, 'BIND', 'SMT2', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1288, '1314.10.050', 3, 'BIND', 'SMT2', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1289, '1314.10.057', 3, 'BIND', 'SMT2', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1290, '1314.10.072', 3, 'BIND', 'SMT2', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1291, '1314.10.076', 3, 'BIND', 'SMT2', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1292, '1314.10.099', 3, 'BIND', 'SMT2', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1293, '1314.10.102', 3, 'BIND', 'SMT2', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1294, '1314.10.121', 3, 'BIND', 'SMT2', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1295, '1314.10.128', 3, 'BIND', 'SMT2', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1296, '1314.10.136', 3, 'BIND', 'SMT2', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1297, '1314.10.150', 3, 'BIND', 'SMT2', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1298, '1314.10.153', 3, 'BIND', 'SMT2', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1299, '1314.10.168', 3, 'BIND', 'SMT2', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1300, '1314.10.171', 3, 'BIND', 'SMT2', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1301, '1314.10.190', 3, 'BIND', 'SMT2', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1302, '1314.10.202', 3, 'BIND', 'SMT2', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1303, '1314.10.203', 3, 'BIND', 'SMT2', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1304, '1314.10.210', 3, 'BIND', 'SMT2', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1305, '1314.10.224', 3, 'BIND', 'SMT2', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1306, '1314.10.235', 3, 'BIND', 'SMT2', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1307, '1314.10.241', 3, 'BIND', 'SMT2', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1308, '1314.10.258', 3, 'BIND', 'SMT2', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1309, '1314.10.262', 3, 'BIND', 'SMT2', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1310, '1314.10.271', 3, 'BIND', 'SMT2', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1311, '1314.10.279', 3, 'BIND', 'SMT2', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1312, '1314.10.293', 3, 'BIND', 'SMT2', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1313, '1314.10.294', 3, 'BIND', 'SMT2', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1314, '1314.10.314', 3, 'BIND', 'SMT2', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1315, '1314.10.322', 3, 'BIND', 'SMT2', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1316, '1314.10.324', 3, 'BIND', 'SMT2', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1317, '1314.10.344', 3, 'BIND', 'SMT2', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1318, '1314.10.352', 3, 'BIND', 'SMT2', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1319, '1314.10.364', 3, 'BIND', 'SMT2', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1320, '1314.10.381', 3, 'BIND', 'SMT2', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1321, '1314.10.392', 3, 'BIND', 'SMT2', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1322, '1314.10.396', 3, 'BIND', 'SMT2', 0, 0, '', '', 0, 0, '', '', 0, '', ''),
(1323, '1314.10.405', 3, 'BIND', 'SMT2', 0, 0, '', '', 0, 0, '', '', 0, '', '');

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
  `pekerjaan_ayah` varchar(30) NOT NULL,
  `pekerjaan_ibu` varchar(30) NOT NULL,
  `nama_wali` varchar(30) DEFAULT '',
  `alamat_wali` text,
  `pekerjaan_wali` varchar(30) DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=50 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `orangtua`
--

INSERT INTO `orangtua` (`id_ortu`, `nis_siswa`, `nama_ayah`, `nama_ibu`, `alamat_ortu`, `no_telp`, `pekerjaan_ayah`, `pekerjaan_ibu`, `nama_wali`, `alamat_wali`, `pekerjaan_wali`) VALUES
(10, '1314.10.006', 'E. Kusnadi', 'Masriah', 'Kp. Cimahi Rt. 17/06 Ds. Cibodas Kec. Cibitung', '', 'Sopir Truk', 'Ibu Rumah Tangga', '', '', ''),
(11, '1314.10.020', 'Dedi Supriadi', 'Yeti Yustiani', 'Kp. Bojonggenteng Rt. 01/01 Ds. Bojonggenteng Kec. Jampangkulon', '', 'Buruh Bangunan', 'Ibu Rumah Tangga', '', '', ''),
(12, '1314.10.026', 'Oyan', 'Khodijah', 'Kp. Ciparay Rt. 04/05 Ds. Ciparay Kec. Jampangkulon', '', 'Buruh', 'Ibu Rumah Tangga', '', '', ''),
(13, '1314.10.044', 'Acun', 'Simah', 'Kp. Puncak Malanding Rt. 02/02 Ds. Sumberjaya Kec. Tegalbuleud', '', 'Petani', 'Ibu Rumah Tangga', '', '', ''),
(14, '1314.10.050', 'Dedi Sutaryat', 'Dewi', 'Kp. Leuwimunding Rt. 04/08 Ds. Nagraksari Kec. Jampangkulon', '', 'Wiraswasta (T. Ojek)', 'Ibu Rumah Tangga', '', '', ''),
(15, '1314.10.057', 'Dadam', 'Ulah', 'Kp. Warujajar I Rt.05/04 Ds. Mekarjaya Kec. Jampangkulon', '', 'Petani', 'Ibu Rumah Tangga', '', '', ''),
(16, '1314.10.072', 'Ade Pahrudin', 'Rosmiati', 'Kp. Warungtagog Rt. 01/01 Ds. Nagraksari Kec. Jampangkulon', '', 'Pengusaha', 'Ibu Rumah Tangga', '', '', ''),
(17, '1314.10.076', 'Dedem Supriatna', 'Teni Nuraeni', 'Kp. Ciletuh Rt. 35/08 Ds. Kertajaya Kec. Simpenan', '', 'Kontraktor', 'Ibu Rumah Tangga', '', '', ''),
(18, '1314.10.099', 'Asep Suherlan', 'Siti Saadah', 'Kp. Pasir Cabe Rt. 08/09 Ds. Nagraksari Kec. Jampangkulon', '', 'Wiraswasta (T. Ojek)', 'Ibu Rumah Tangga', '', '', ''),
(19, '1314.10.102', 'Sahidin', 'Empat', 'Kp. Cigaronggong Rt. 04/08 Ds. Bojongsari Kec. Jampangkulon', '', 'Petani', 'Ibu Rumah Tangga', '', '', ''),
(20, '1314.10.121', 'Ipin', 'Ani', 'Kp. Pasirulis Rt. 02/02 Ds. Cikarang Kec. Jampangkulon', '', 'Buruh Bangunan', 'Ibu Rumah Tangga', '', '', ''),
(21, '1314.10.128', 'Jaji', 'Anisa', 'Kp. Cipancur Rt. 16/06 Ds. Cibodas Kec. Cibitung', '', 'Guru Honorer', 'Ibu Rumah Tangga', '', '', ''),
(22, '1314.10.136', 'Bama', 'Winarsih', 'Kp. Cimanggis Ds. Mangunjaya Kec. Waluran', '', 'Wiraswasta', 'Ibu Rumah Tangga', '', '', ''),
(23, '1314.10.150', 'Endang', 'Popon', 'Kp. Cimanggis Rt. 09/02 Ds. Mangunjaya Kec. Waluran', '', 'Buruh Tani', 'Ibu Rumah Tangga', 'Uci', 'Kp. Cimanggis', 'Petani'),
(24, '1314.10.153', 'Yayan', 'Olis', 'Kp. Cipanali Rt. 02/02 Ds. Karangmekar Kec. Cimanggu', '', 'Buruh Bangunan', 'Ibu Rumah Tangga', '', '', ''),
(25, '1314.10.168', 'Pranoto', 'Beti Eli Herlina', 'Kp. Bojonggenteng Rt. 03/01 Ds. Bojonggenteng Kec. Jampangkulon', '', 'Wiraswasta', 'Pedagang', '', '', ''),
(26, '1314.10.171', 'Sarip Rahman', 'Elit', 'Kp. Ciledeug Rt. 03/05 Ds. Mekarjaya Kec. Jampangkulon', '', 'Petani', 'Ibu Rumah Tangga', '', '', ''),
(27, '1314.10.190', 'Nanda Juanda', 'Neneng Mintarsih', 'Kp. Mandala Rt. 07/04 Ds. Tanjung Kec. Jampangkulon', '', 'Pedagang', 'PNS ', '', '', ''),
(28, '1314.10.202', 'Asep Ubaedilah', 'Nurhayati', 'Kp. Puncakbatu Rt. 04/01 Ds. Sumberjaya Kec. Tegalbuleud', '', 'Toko Onderdil', 'Toko Kelontongan ', '', '', ''),
(29, '1314.10.203', 'Usaman Ma''mur', 'Rosidah', 'Kp. Sindanglaya Rt. 05/02 Ds. Bojonggenteng Kec. Jampangkulon', '', 'Buruh Bangunan', 'Ibu Rumah Tangga', '', '', ''),
(30, '1314.10.210', 'Mulyadi', 'Yayah', 'Kp. Salagedang Rt. 05/03 Ds. Bojongsari Kec. Jampangkulon', '', 'Petani', 'Ibu Rumah Tangga', '', '', ''),
(31, '1314.10.224', 'Suhenda', 'Beti', 'Kp. Simpang Karet Rt. 10/01 Ds. Citanglar Kec. Surade', '', 'Wiraswasta', 'Ibu Rumah Tangga', '', '', ''),
(32, '1314.10.235', 'Owo (Alm)', 'Elis Suryani', 'Kp. Warungtagog Rt. 01/01 Ds. Nagraksari Kec. Jampangkulon', '', '', 'Ibu Rumah Tangga', '', '', ''),
(33, '1314.10.241', 'H. Aneng', 'Hj. Rusmiati', 'Kp. Cigaok Rt. 03/01 Ds. Cibodas kec. Cibitung', '', 'Petani', 'Ibu Rumah Tangga', '', '', ''),
(34, '1314.10.258', 'Pupu S', 'Supenti', 'Kp. Ciranji I Rt. 01/03 Ds. Mekarjaya Kec. Jampangkulon', '', 'Perangkat Desa', 'Ibu Rumah Tangga', '', '', ''),
(35, '1314.10.262', ' Pudin', 'Ai Lisnawati', 'Kp. Kalapanunggal Rt. 04/03 Ds. Cikarang Kec. Jampangkulon', '', 'Pengusaha', 'Ibu Rumah Tangga', '', '', ''),
(36, '1314.10.271', 'Mujib', 'Rani', 'Kp. Curughilir Rt. 05/02 Ds. Mekarjaya Kec. Jampangkulon', '', 'Petani', 'Ibu Rumah Tangga', '', '', ''),
(37, '1314.10.279', 'Badru', 'Halimah', 'Kp.Cigaok Rt. 02/01 Ds. Cibodas  Kec. Cibitung', '', 'Pengusaha', 'Ibu Rumah Tangga', '', '', ''),
(38, '1314.10.293', 'Sirojudin', 'Eha Julaeha', 'Kp. Cikujang Rt. 01/01 Ds. Gunungsungging Kec.Surade', '', 'Buruh Bangunan', 'Ibu Rumah Tangga', '', '', ''),
(39, '1314.10.294', 'Wahyudin', 'Dian Haerani', 'Kp. Selagedang Rt. 12/04 Ds. Cibodas Kec. Cibitung', '', 'Kepala Desa', 'Ibu Rumah Tangga', '', '', ''),
(40, '1314.10.314', 'Eris', 'Wiwin', 'Kp. Neglasari Rt. 01/05 Ds. Tanjung Kec. Jampangkulon', '', 'Buruh Bangunan', 'Ibu Rumah Tangga', '', '', ''),
(41, '1314.10.322', 'Pahrudin', 'Ida Rosidah', 'Kp. Batumeungpeuk Rt. 09/01 Ds. Ciparay Kec. Jampangkulon ', '', 'Petani Milik Sendiri', 'Ibu Rumah Tangga', '', '', ''),
(42, '1314.10.324', 'Dedi', 'Enih', 'Kp. Gunungbatu Rt. 20/03 Ds. Talagamurni Kec. Cibitung', '', 'Pedagang', 'Ibu Rumah Tangga', '', '', ''),
(43, '1314.10.344', 'Suwardi', 'Ade Mintarsih', 'Kp. Bojonggenteng Rt. 08/03 Ds. Bojonggenteng Kec. Jampangkulon', '', 'Wiraswasta', 'Ibu Rumah Tangga', '', '', ''),
(44, '1314.10.352', 'Ahmad Mubaroji', 'Upin', 'Kp. Lembursawah Rt. 06/08 Ds. Bojongsari Kec. Jampangkulon', '', 'Petani', 'Ibu Rumah Tangga', '', '', ''),
(45, '1314.10.364', 'Yogi', 'Rohayati', 'Kp. Naringgul Rt. 07/09 Ds. Jagamukti Kec. Surade', '', 'Wiraswasta', 'Ibu Rumah Tangga', '', '', ''),
(46, '1314.10.381', 'Ahmad (Alm)', 'Epon', 'Kp. Cilempung Rt. 10/01 Ds. Ciparay Kec. Jampangkulon', '', 'Sopir', 'Ibu Rumah Tangga', '', '', ''),
(47, '1314.10.392', 'Dadan', 'Tati Rasmiati', 'Kp. Cilubang Rt. 05/02 Ds. Jampangkulon Kec. Jampangkulon', '', 'Pedagang', 'Pedagang', '', '', ''),
(48, '1314.10.396', 'Nanang Darma Nugraha', 'Nani Sumarni', 'Kp. Cilubang Rt. 04/02 Ds. Jampangkulon Kec. Jampangkulon', '', 'POLRI', 'PNS ', '', '', ''),
(49, '1314.10.405', 'Subandi', 'Ema Mahaerani S', 'Kp. Negla Mekar Rt. 07/05 Ds. Tanjung Kec. Jampangkulon', '', 'POLRI', 'Ibu Rumah Tangga', '', '', '');

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
('1314.10.006', 'Adi Ruswandi', '9984019177', 'Sukabumi', '08/09/1996', 'Laki-laki', 'Islam', 'Anak Kandung', 3, 'Kp. Cimahi Rt. 17/06 Ds. Cibodas Kec. Cibitung', '', 'SMPN 1 Cibitung', '22/06/2013', 'Aktif'),
('1314.10.020', 'Aldiansyah', '9971320907', 'Sukabumi', '30/10/1997', 'Laki-laki', 'Islam', 'Anak Kandung', 1, 'Kp. Bojonggenteng Rt. 01/01 Ds. Bojonggenteng Kec. Jampangkulon', '', 'SMPN 1 Jampangkulon', '22/06/2013', 'Aktif'),
('1314.10.026', 'Amelia Nurpitrianah', '9981143284', 'Sukabumi', '02/04/1998', 'Perempuan', 'Islam', 'Anak Kandung', 2, 'Kp. Ciparay Rt. 04/05 Ds. Ciparay Kec. Jampangkulon', '', 'SMPN 1 Surade', '22/06/2013', 'Aktif'),
('1314.10.044', 'Aris Saputra', '9970944245', 'Sukabumi', '30/05/1997', 'Laki-laki', 'Islam', 'Anak Kandung', 1, 'Kp. Puncak Malanding Rt. 02/02 Ds. Sumberjaya Kec. Tegalbuleud', '', 'SMPN 1 Tegal Buleud', '22/06/2013', 'Aktif'),
('1314.10.050', 'Ayu Widia', '9994097929', 'Sukabumi', '29/01/1999', 'Perempuan', 'Islam', 'Anak Kandung', 1, 'Kp. Leuwimunding Rt. 04/08 Ds. Nagraksari Kec. Jampangkulon', '', 'SMPN 2 Jampangkulon', '22/06/2013', 'Aktif'),
('1314.10.057', 'Candra Wijaya S', '9971321047', 'Sukabumi', '30/09/1997', 'Laki-laki', 'Islam', 'Anak Kandung', 2, 'Kp. Warujajar I Rt.05/04 Ds. Mekarjaya Kec. Jampangkulon', '', 'SMPN 2 Jampangkulon', '22/06/2013', 'Aktif'),
('1314.10.072', 'Dela Febrianti', '9981143382', 'Sukabumi', '30/01/1998', 'Perempuan', 'Islam', 'Anak Kandung', 1, 'Kp. Warungtagog Rt. 01/01 Ds. Nagraksari Kec. Jampangkulon', '', 'SMPN 1 Jampangkulon', '22/06/2013', 'Aktif'),
('1314.10.076', 'Denis Aji Muhammad Jabar', '', 'Sukabumi', '21/05/1998', 'Laki-laki', 'Islam', 'Anak Kandung', 1, 'Kp. Ciletuh Rt. 35/08 Ds. Kertajaya Kec. Simpenan', '', 'SMPN 1 Lengkong', '22/06/2013', 'Aktif'),
('1314.10.099', 'Elsa Marliani', '9994098077', 'Sukabumi', '17/03/1999', 'Perempuan', 'Islam', 'Anak Kandung', 1, 'Kp. Pasir Cabe Rt. 08/09 Ds. Nagraksari Kec. Jampangkulon', '', 'SMPN 1 Jampangkulon', '22/06/2013', 'Aktif'),
('1314.10.102', 'Erwan Susanto', '9974097969', 'Sukabumi', '11/03/1997', 'Laki-laki', 'Islam', 'Anak Kandung', 1, 'Kp. Cigaronggong Rt. 04/08 Ds. Bojongsari Kec. Jampangkulon', '', 'SMPN 3 Jampangkulon', '22/06/2013', 'Aktif'),
('1314.10.121', 'Hardika Eka Putra', '', 'Sukabumi', '27/07/1997', 'Laki-laki', 'Islam', 'Anak Kandung', 1, 'Kp. Pasirulis Rt. 02/02 Ds. Cikarang Kec. Jampangkulon', '', 'SMPT Darul Amal', '22/06/2013', 'Aktif'),
('1314.10.128', 'Hesti Pujiawati', '9983851700', 'Sukabumi', '02/02/1998', 'Perempuan', 'Islam', 'Anak Kandung', 1, 'Kp. Cipancur Rt. 16/06 Ds. Cibodas Kec. Cibitung', '', 'SMPN 3 Jampangkulon', '22/06/2013', 'Aktif'),
('1314.10.136', 'Ilham', '', 'Sukabumi', '22/12/1997', 'Laki-laki', 'Islam', 'Anak Kandung', 4, 'Kp. Cimanggis Ds. Mangunjaya Kec. Waluran', '', 'MTsN Waluran ', '22/06/2013', 'Aktif'),
('1314.10.150', 'Intan', '9975777272', 'Sukabumi', '10/01/1997', 'Perempuan', 'Islam', 'Anak Kandung', 1, 'Kp. Cimanggis Rt. 09/02 Ds. Mangunjaya Kec. Waluran', '', 'SMPN 1 Jampangkulon', '22/06/2013', 'Aktif'),
('1314.10.153', 'Iqbal Sulung Nugraha', '9983970845', 'Sukabumi', '16/10/1998', 'Laki-laki', 'Islam', 'Anak Kandung', 1, 'Kp. Cipanali Rt. 02/02 Ds. Karangmekar Kec. Cimanggu', '', 'SMPN 1 Cimanggu', '22/06/2013', 'Aktif'),
('1314.10.168', 'Krisna Benoto', '9981143176', 'Sukabumi', '12/05/1998', 'Laki-laki', 'Islam', 'Anak Kandung', 1, 'Kp. Bojonggenteng Rt. 03/01 Ds. Bojonggenteng Kec. Jampangkulon', '', 'SMPN 1 Jampangkulon', '22/06/2013', 'Aktif'),
('1314.10.171', 'Linda Lestari', '9982780283', 'Sukabumi', '24/10/1997', 'Perempuan', 'Islam', 'Anak Kandung', 1, 'Kp. Ciledeug Rt. 03/05 Ds. Mekarjaya Kec. Jampangkulon', '', 'SMPN 2 Jampangkulon', '22/06/2013', 'Aktif'),
('1314.10.190', 'Meilita Nur Aisyah', '9994097776', 'Bogor', '15/05/1999', 'Perempuan', 'Islam', 'Anak Kandung', 2, 'Kp. Mandala Rt. 07/04 Ds. Tanjung Kec. Jampangkulon', '', 'SMPN 1 Jampangkulon', '22/06/2013', 'Aktif'),
('1314.10.202', 'Muhamad Falah Samsul Bahri', '9985671507', 'Sukabumi', '18/05/1998', 'Laki-laki', 'Islam', 'Anak Kandung', 1, 'Kp. Puncakbatu Rt. 04/01 Ds. Sumberjaya Kec. Tegalbuleud', '', 'SMPN 1 Tegal Buleud', '22/06/2013', 'Aktif'),
('1314.10.203', 'Muhamad Gunawan', '9974291053', 'Bekasi', '23/07/1997', 'Laki-laki', 'Islam', 'Anak Kandung', 1, 'Kp. Sindanglaya Rt. 05/02 Ds. Bojonggenteng Kec. Jampangkulon', '', 'MTs Al-Fakhriyah', '22/06/2013', 'Aktif'),
('1314.10.210', 'Mulya Fajar', '9974098421', 'Sukabumi', '05/09/1997', 'Laki-laki', 'Islam', 'Anak Kandung', 1, 'Kp. Salagedang Rt. 05/03 Ds. Bojongsari Kec. Jampangkulon', '', 'SMPN 3 Jampangkulon', '22/06/2013', 'Aktif'),
('1314.10.224', 'Neng Lisda', '9986492599', 'Sukabumi', '06/03/1998', 'Perempuan', 'Islam', 'Anak Kandung', 4, 'Kp. Simpang Karet Rt. 10/01 Ds. Citanglar Kec. Surade', '', 'SMPN 2 Cibitung', '22/06/2013', 'Aktif'),
('1314.10.235', 'Novi Nurharum Sari', '9971321118', 'Sukabumi', '20/05/1998', 'Perempuan', 'Islam', 'Anak Kandung', 2, 'Kp. Warungtagog Rt. 01/01 Ds. Nagraksari Kec. Jampangkulon', '', 'SMPN 1 Jampangkulon', '22/06/2013', 'Aktif'),
('1314.10.241', 'Nurlatifah', '', 'Sukabumi', '06/06/1998', 'Perempuan', 'Islam', 'Anak Kandung', 1, 'Kp. Cigaok Rt. 03/01 Ds. Cibodas kec. Cibitung', '', 'SMPN 1 Cibitung', '22/06/2013', 'Aktif'),
('1314.10.258', 'Puspita Meilasari', '9981143330', 'Sukabumi', '08/05/1998', 'Perempuan', 'Islam', 'Anak Kandung', 1, 'Kp. Ciranji I Rt. 01/03 Ds. Mekarjaya Kec. Jampangkulon', '', 'SMPN 2 Jampangkulon', '22/06/2013', 'Aktif'),
('1314.10.262', 'Rahmat Taufik Hidayat', '9974098057', 'Sukabumi', '17/05/1997', 'Laki-laki', 'Islam', 'Anak Kandung', 1, 'Kp. Kalapanunggal Rt. 04/03 Ds. Cikarang Kec. Jampangkulon', '', 'SMPN 1 Jampangkulon', '22/06/2013', 'Aktif'),
('1314.10.271', 'Renti Sukmawati', '9981143331', 'Sukabumi', '02/04/1998', 'Perempuan', 'Islam', 'Anak Kandung', 2, 'Kp. Curughilir Rt. 05/02 Ds. Mekarjaya Kec. Jampangkulon', '', 'SMPN 2 Jampangkulon', '22/06/2013', 'Aktif'),
('1314.10.279', 'Rian Badru', '', 'Sukabumi', '03/03/1997', 'Laki-laki', 'Islam', 'Anak Kandung', 1, 'Kp.Cigaok Rt. 02/01 Ds. Cibodas  Kec. Cibitung', '', 'SMPN 1 Cibitung', '22/06/2013', 'Aktif'),
('1314.10.293', 'Ringga Dwi Raju', '9976613650', 'Sukabumi', '23/07/1997', 'Laki-laki', 'Islam', 'Anak Kandung', 2, 'Kp. Cikujang Rt. 01/01 Ds. Gunungsungging Kec.Surade', '', 'SMPN 1 Surade', '22/06/2013', 'Aktif'),
('1314.10.294', 'Rini Herlina', '', 'Cimahi', '25/11/1997', 'Perempuan', 'Islam', 'Anak Kandung', 1, 'Kp. Selagedang Rt. 12/04 Ds. Cibodas Kec. Cibitung', '', 'SMPN 1 Cibitung', '22/06/2013', 'Aktif'),
('1314.10.314', 'Robi Erwin', '9984108568', 'Sukabumi', '14/01/1998', 'Laki-laki', 'Islam', 'Anak Kandung', 1, 'Kp. Neglasari Rt. 01/05 Ds. Tanjung Kec. Jampangkulon', '', 'SMPN 1 Jampangkulon', '22/06/2013', 'Aktif'),
('1314.10.322', 'Sahrial Jayani', '9974098095', 'Sukabumi', '07/10/1997', 'Laki-laki', 'Islam', 'Anak Kandung', 1, 'Kp. Batumeungpeuk Rt. 09/01 Ds. Ciparay Kec. Jampangkulon ', '', 'SMPN 1 Jampangkulon', '22/06/2013', 'Aktif'),
('1314.10.324', 'Sania Puput Putri', '9973918986', 'Sukabumi', '23/08/1997', 'Perempuan', 'Islam', 'Anak Kandung', 1, 'Kp. Gunungbatu Rt. 20/03 Ds. Talagamurni Kec. Cibitung', '', 'SMPN 2 Cibitung', '22/06/2013', 'Aktif'),
('1314.10.344', 'Siska Nahla Padila', '9981143179', 'Sukabumi', '30/06/1998', 'Perempuan', 'Islam', 'Anak Kandung', 4, 'Kp. Bojonggenteng Rt. 08/03 Ds. Bojonggenteng Kec. Jampangkulon', '', 'SMPN 1 Jampangkulon', '22/06/2013', 'Aktif'),
('1314.10.352', 'Siti Nurjanah', '9984018293', 'Sukabumi', '03/04/1998', 'Perempuan', 'Islam', 'Anak Kandung', 1, 'Kp. Lembursawah Rt. 06/08 Ds. Bojongsari Kec. Jampangkulon', '', 'SMPN 2 Jampangkulon', '22/06/2013', 'Aktif'),
('1314.10.364', 'Suciyana Rahayu', '9986492396', 'Sukabumi', '01/01/1998', 'Perempuan', 'Islam', 'Anak Kandung', 1, 'Kp. Naringgul Rt. 07/09 Ds. Jagamukti Kec. Surade', '', 'SMPN 1 Surade', '22/06/2013', 'Aktif'),
('1314.10.381', 'Vina Nurfitriyani', '9984018412', 'Sukabumi', '04/05/1998', 'Perempuan', 'Islam', 'Anak Kandung', 2, 'Kp. Cilempung Rt. 10/01 Ds. Ciparay Kec. Jampangkulon', '', 'SMPN 1 Jampangkulon', '22/06/2013', 'Aktif'),
('1314.10.392', 'Wulan Sari', '9974098139', 'Sukabumi', '20/09/1997', 'Perempuan', 'Islam', 'Anak Kandung', 2, 'Kp. Cilubang Rt. 05/02 Ds. Jampangkulon Kec. Jampangkulon', '', 'SMPN 1 Jampangkulon', '22/06/2013', 'Aktif'),
('1314.10.396', 'Yoga Dwi Ramdani', '9981143350', 'Sukabumi', '20/01/1998', 'Laki-laki', 'Islam', 'Anak Kandung', 2, 'Kp. Cilubang Rt. 04/02 Ds. Jampangkulon Kec. Jampangkulon', '', 'SMPN 1 Jampangkulon', '22/06/2013', 'Aktif'),
('1314.10.405', 'Yuditya Kharisma Herlambang', '9984018572', 'Sukabumi', '07/11/1998', 'Laki-laki', 'Islam', 'Anak Kandung', 3, 'Kp. Negla Mekar Rt. 07/05 Ds. Tanjung Kec. Jampangkulon', '', 'SMPN 1 Jampangkulon', '22/06/2013', 'Aktif');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE IF NOT EXISTS `user` (
  `username` varchar(15) NOT NULL,
  `password` text NOT NULL,
  `nama` varchar(50) NOT NULL,
  `level` int(2) DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`username`, `password`, `nama`, `level`) VALUES
('admin', 'YLr7l9DCoeHtEG3I7U+TSw==', 'Drs. Sahrudin', 1),
('administrasi', 'px/5Z9IuDgBmpXLesMt+mkG0iyy7IZpBOK600l40S9E=', 'Iyep Budiman, S.Pd, M.Mpd.', 0),
('kamu', 'ub+ioxsINXjlfOPGRHzMdw==', 'Drs. Deden Zenal Muttaqin, M.Mpd.', 0);

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
 ADD PRIMARY KEY (`id_deskripsieskul`), ADD KEY `kode_eskul` (`kode_eskul`), ADD KEY `nis_siswa` (`nis_siswa`);

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
-- AUTO_INCREMENT for table `deskripsi`
--
ALTER TABLE `deskripsi`
MODIFY `id_deskripsi` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=17;
--
-- AUTO_INCREMENT for table `deskripsieskul`
--
ALTER TABLE `deskripsieskul`
MODIFY `id_deskripsieskul` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `detailkelassiswa`
--
ALTER TABLE `detailkelassiswa`
MODIFY `id_detail` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=338;
--
-- AUTO_INCREMENT for table `detailmapelguru`
--
ALTER TABLE `detailmapelguru`
MODIFY `id_detail` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=47;
--
-- AUTO_INCREMENT for table `detailmapelkelas`
--
ALTER TABLE `detailmapelkelas`
MODIFY `id_detail` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=112;
--
-- AUTO_INCREMENT for table `kelas`
--
ALTER TABLE `kelas`
MODIFY `kode_kelas` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=13;
--
-- AUTO_INCREMENT for table `nilai`
--
ALTER TABLE `nilai`
MODIFY `id_nilai` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=1324;
--
-- AUTO_INCREMENT for table `orangtua`
--
ALTER TABLE `orangtua`
MODIFY `id_ortu` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=50;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `deskripsi`
--
ALTER TABLE `deskripsi`
ADD CONSTRAINT `deskripsi_ibfk_1` FOREIGN KEY (`kode_kelas`) REFERENCES `kelas` (`kode_kelas`) ON DELETE CASCADE ON UPDATE CASCADE,
ADD CONSTRAINT `deskripsi_ibfk_2` FOREIGN KEY (`kode_mapel`) REFERENCES `mapel` (`kode_mapel`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `deskripsieskul`
--
ALTER TABLE `deskripsieskul`
ADD CONSTRAINT `deskripsieskul_ibfk_1` FOREIGN KEY (`kode_eskul`) REFERENCES `ekstrakurikuler` (`kode_eskul`) ON DELETE CASCADE ON UPDATE CASCADE,
ADD CONSTRAINT `deskripsieskul_ibfk_2` FOREIGN KEY (`nis_siswa`) REFERENCES `siswa` (`nis_siswa`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `detailkelassiswa`
--
ALTER TABLE `detailkelassiswa`
ADD CONSTRAINT `detailkelassiswa_ibfk_1` FOREIGN KEY (`kode_kelas`) REFERENCES `kelas` (`kode_kelas`) ON DELETE CASCADE ON UPDATE CASCADE,
ADD CONSTRAINT `detailkelassiswa_ibfk_2` FOREIGN KEY (`nis_siswa`) REFERENCES `siswa` (`nis_siswa`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `detailmapelguru`
--
ALTER TABLE `detailmapelguru`
ADD CONSTRAINT `detailmapelguru_ibfk_1` FOREIGN KEY (`id_guru`) REFERENCES `guru` (`id_guru`) ON DELETE CASCADE ON UPDATE CASCADE,
ADD CONSTRAINT `detailmapelguru_ibfk_2` FOREIGN KEY (`kode_mapel`) REFERENCES `mapel` (`kode_mapel`);

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
-- Constraints for table `nilai`
--
ALTER TABLE `nilai`
ADD CONSTRAINT `nilai_ibfk_1` FOREIGN KEY (`nis_siswa`) REFERENCES `siswa` (`nis_siswa`) ON DELETE CASCADE ON UPDATE CASCADE,
ADD CONSTRAINT `nilai_ibfk_2` FOREIGN KEY (`kode_kelas`) REFERENCES `kelas` (`kode_kelas`) ON DELETE CASCADE ON UPDATE CASCADE,
ADD CONSTRAINT `nilai_ibfk_3` FOREIGN KEY (`kode_mapel`) REFERENCES `mapel` (`kode_mapel`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `orangtua`
--
ALTER TABLE `orangtua`
ADD CONSTRAINT `orangtua_ibfk_1` FOREIGN KEY (`nis_siswa`) REFERENCES `siswa` (`nis_siswa`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
