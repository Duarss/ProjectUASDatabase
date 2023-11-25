-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 24, 2023 at 12:55 PM
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
-- Database: `celikoor_tixycket_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `aktors`
--

CREATE TABLE `aktors` (
  `id` int(11) NOT NULL,
  `nama` varchar(45) NOT NULL,
  `tgl_lahir` date NOT NULL,
  `gender` enum('L','P') NOT NULL,
  `negara_asal` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `aktors`
--

INSERT INTO `aktors` (`id`, `nama`, `tgl_lahir`, `gender`, `negara_asal`) VALUES
(1, 'Dwayne \"The Rock\" Johnson', '2023-11-01', 'L', 'Amerika Serikat'),
(2, 'Shah Rukh Khan', '2023-11-14', 'L', 'India'),
(3, 'Leonardo DiCaprio', '2023-11-15', 'L', 'Amerika Serikat'),
(4, 'James Edward', '2023-11-01', 'L', 'India'),
(5, 'Jackie Chan', '2023-11-14', 'L', 'Hong Kong');

-- --------------------------------------------------------

--
-- Table structure for table `aktor_film`
--

CREATE TABLE `aktor_film` (
  `aktors_id` int(11) NOT NULL,
  `films_id` int(11) NOT NULL,
  `peran` enum('UTAMA','PEMBANTU','FIGURAN') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `cinemas`
--

CREATE TABLE `cinemas` (
  `id` int(11) NOT NULL,
  `nama_cabang` varchar(45) NOT NULL,
  `alamat` varchar(45) NOT NULL,
  `tgl_dibuka` date NOT NULL,
  `kota` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `cinemas`
--

INSERT INTO `cinemas` (`id`, `nama_cabang`, `alamat`, `tgl_dibuka`, `kota`) VALUES
(1, 'celikoor1', 'vdsvsvf', '2023-11-01', 'surabaya'),
(2, 'celikoor2', 'scvdc', '2023-11-08', 'sidoarjo'),
(3, 'celikoor3', 'cas csac', '2023-11-17', 'surakarta'),
(4, 'celikoor4', 'ascefsdf', '2023-11-25', 'lampung'),
(5, 'celikoor5', 'waddaddaw', '2023-11-16', 'purwodadi');

-- --------------------------------------------------------

--
-- Table structure for table `films`
--

CREATE TABLE `films` (
  `id` int(11) NOT NULL,
  `judul` varchar(45) NOT NULL,
  `sinopsis` text NOT NULL,
  `tahun` int(11) NOT NULL,
  `durasi` smallint(6) NOT NULL,
  `kelompoks_id` int(11) NOT NULL,
  `bahasa` enum('EN','ID','CHN','KOR','JPN','OTH') NOT NULL DEFAULT 'EN',
  `is_sub_indo` tinyint(4) NOT NULL DEFAULT 1,
  `cover_image` varchar(45) DEFAULT NULL,
  `diskon_nominal` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `film_studio`
--

CREATE TABLE `film_studio` (
  `studios_id` int(11) NOT NULL,
  `films_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `genres`
--

CREATE TABLE `genres` (
  `id` int(11) NOT NULL,
  `nama` varchar(45) NOT NULL,
  `deskripsi` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `genres`
--

INSERT INTO `genres` (`id`, `nama`, `deskripsi`) VALUES
(1, 'Horror', 'Adegan menakutkan'),
(2, 'Thriller', 'Adegan kekerasan atau keterlibatan darah'),
(3, 'Romance', 'Adegan asmara dan percintaan'),
(4, 'Action', 'Adegan seru dan menegangkan'),
(5, 'Comedy', 'Adegan lucu dan menyenangkan');

-- --------------------------------------------------------

--
-- Table structure for table `genre_film`
--

CREATE TABLE `genre_film` (
  `films_id` int(11) NOT NULL,
  `genres_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `invoices`
--

CREATE TABLE `invoices` (
  `id` int(11) NOT NULL,
  `tanggal` datetime NOT NULL,
  `grand_total` double NOT NULL,
  `diskon_nominal` double DEFAULT NULL,
  `konsumens_id` int(11) NOT NULL,
  `kasir_id` int(11) DEFAULT NULL,
  `status` enum('PENDING','VALIDASI','TERBAYAR') NOT NULL DEFAULT 'PENDING'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `jadwal_films`
--

CREATE TABLE `jadwal_films` (
  `id` int(11) NOT NULL,
  `tanggal` date NOT NULL,
  `jam_pemutaran` enum('I','II','III','IV') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `jenis_studios`
--

CREATE TABLE `jenis_studios` (
  `id` int(11) NOT NULL,
  `nama` varchar(45) NOT NULL,
  `deskripsi` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `jenis_studios`
--

INSERT INTO `jenis_studios` (`id`, `nama`, `deskripsi`) VALUES
(1, 'Reguler', 'cinema reguler'),
(2, 'Premier', 'bisa sambil berbaring'),
(3, 'IMAX', 'layar besar'),
(4, 'Reguler 3D', 'cinema reguler dengan 3d experience'),
(5, 'IMAX 3D', 'IMAX dengan 3d experience');

-- --------------------------------------------------------

--
-- Table structure for table `kelompoks`
--

CREATE TABLE `kelompoks` (
  `id` int(11) NOT NULL,
  `nama` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `kelompoks`
--

INSERT INTO `kelompoks` (`id`, `nama`) VALUES
(1, 'all age'),
(2, '13+'),
(3, '17+'),
(4, '21+'),
(5, 'Rated R');

-- --------------------------------------------------------

--
-- Table structure for table `konsumens`
--

CREATE TABLE `konsumens` (
  `id` int(11) NOT NULL,
  `nama` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `no_hp` varchar(45) NOT NULL,
  `gender` enum('L','P') NOT NULL,
  `tgl_lahir` date NOT NULL,
  `saldo` double DEFAULT 0,
  `username` varchar(45) NOT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `konsumens`
--

INSERT INTO `konsumens` (`id`, `nama`, `email`, `no_hp`, `gender`, `tgl_lahir`, `saldo`, `username`, `password`) VALUES
(1, 'darius', 'd', '123', 'L', '2023-11-08', 100000, 'darius', '1'),
(2, 'budi', 'wda', '013483279847234', 'P', '2023-11-09', 30000, 'budies', '2'),
(3, 'febri', 'cas', '23432432424234', 'L', '2023-11-01', 50000, '3ed', '3'),
(4, 'oakle', 'wcve', '3243424', 'P', '2023-11-17', 10000000000, 'ooo', '4'),
(5, 'stnk', 'wdaswwd', '23143234324', 'P', '2023-11-19', 24000, 'dwedq', '5');

-- --------------------------------------------------------

--
-- Table structure for table `pegawais`
--

CREATE TABLE `pegawais` (
  `id` int(11) NOT NULL,
  `nama` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `username` varchar(45) NOT NULL,
  `password` varchar(255) NOT NULL,
  `roles` enum('ADMIN','KASIR','OPERATOR') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `pegawais`
--

INSERT INTO `pegawais` (`id`, `nama`, `email`, `username`, `password`, `roles`) VALUES
(1, 'willy', 'w', 'willy', '1', 'ADMIN'),
(2, 'stenli', 's', 'stenli', '2', 'KASIR'),
(3, 'james', 'wda', 'axdw', '3', 'OPERATOR'),
(4, 'blek', 'cda', 'wdaxd', '4', 'KASIR'),
(5, 'dogie', 'fd', 'asd', '5', 'OPERATOR');

-- --------------------------------------------------------

--
-- Table structure for table `sesi_films`
--

CREATE TABLE `sesi_films` (
  `jadwal_film_id` int(11) NOT NULL,
  `studios_id` int(11) NOT NULL,
  `films_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `studios`
--

CREATE TABLE `studios` (
  `id` int(11) NOT NULL,
  `nama` varchar(45) NOT NULL,
  `kapasitas` int(11) NOT NULL,
  `jenis_studios_id` int(11) NOT NULL,
  `cinemas_id` int(11) NOT NULL,
  `harga_weekday` int(11) NOT NULL,
  `harga_weekend` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tikets`
--

CREATE TABLE `tikets` (
  `invoices_id` int(11) NOT NULL,
  `nomor_kursi` varchar(3) NOT NULL,
  `status_hadir` tinyint(4) DEFAULT NULL,
  `operator_id` int(11) NOT NULL,
  `harga` double NOT NULL,
  `jadwal_film_id` int(11) NOT NULL,
  `studios_id` int(11) NOT NULL,
  `films_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `aktors`
--
ALTER TABLE `aktors`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `aktor_film`
--
ALTER TABLE `aktor_film`
  ADD PRIMARY KEY (`aktors_id`,`films_id`),
  ADD KEY `fk_aktors_has_films_films1_idx` (`films_id`),
  ADD KEY `fk_aktors_has_films_aktors1_idx` (`aktors_id`);

--
-- Indexes for table `cinemas`
--
ALTER TABLE `cinemas`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `films`
--
ALTER TABLE `films`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_films_kelompoks1_idx` (`kelompoks_id`);

--
-- Indexes for table `film_studio`
--
ALTER TABLE `film_studio`
  ADD PRIMARY KEY (`studios_id`,`films_id`),
  ADD KEY `fk_studios_has_films_films1_idx` (`films_id`),
  ADD KEY `fk_studios_has_films_studios1_idx` (`studios_id`);

--
-- Indexes for table `genres`
--
ALTER TABLE `genres`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `genre_film`
--
ALTER TABLE `genre_film`
  ADD PRIMARY KEY (`films_id`,`genres_id`),
  ADD KEY `fk_films_has_genres_genres1_idx` (`genres_id`),
  ADD KEY `fk_films_has_genres_films1_idx` (`films_id`);

--
-- Indexes for table `invoices`
--
ALTER TABLE `invoices`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_invoices_konsumens1_idx` (`konsumens_id`),
  ADD KEY `fk_invoices_pegawais1_idx` (`kasir_id`);

--
-- Indexes for table `jadwal_films`
--
ALTER TABLE `jadwal_films`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `jenis_studios`
--
ALTER TABLE `jenis_studios`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `kelompoks`
--
ALTER TABLE `kelompoks`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `konsumens`
--
ALTER TABLE `konsumens`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `pegawais`
--
ALTER TABLE `pegawais`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `sesi_films`
--
ALTER TABLE `sesi_films`
  ADD PRIMARY KEY (`jadwal_film_id`,`studios_id`,`films_id`),
  ADD KEY `fk_jadwal_film_has_film_studio_film_studio1_idx` (`studios_id`,`films_id`),
  ADD KEY `fk_jadwal_film_has_film_studio_jadwal_film1_idx` (`jadwal_film_id`);

--
-- Indexes for table `studios`
--
ALTER TABLE `studios`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_studios_jenis_studios_idx` (`jenis_studios_id`),
  ADD KEY `fk_studios_cinemas1_idx` (`cinemas_id`);

--
-- Indexes for table `tikets`
--
ALTER TABLE `tikets`
  ADD PRIMARY KEY (`invoices_id`,`nomor_kursi`),
  ADD KEY `fk_film_studio_has_invoices_invoices1_idx` (`invoices_id`),
  ADD KEY `fk_film_studio_has_invoices_pegawais1_idx` (`operator_id`),
  ADD KEY `fk_tikets_sesi_films1_idx` (`jadwal_film_id`,`studios_id`,`films_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `aktors`
--
ALTER TABLE `aktors`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `cinemas`
--
ALTER TABLE `cinemas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `films`
--
ALTER TABLE `films`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `genres`
--
ALTER TABLE `genres`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `invoices`
--
ALTER TABLE `invoices`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `jadwal_films`
--
ALTER TABLE `jadwal_films`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `jenis_studios`
--
ALTER TABLE `jenis_studios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `kelompoks`
--
ALTER TABLE `kelompoks`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `konsumens`
--
ALTER TABLE `konsumens`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `pegawais`
--
ALTER TABLE `pegawais`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `studios`
--
ALTER TABLE `studios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `aktor_film`
--
ALTER TABLE `aktor_film`
  ADD CONSTRAINT `fk_aktors_has_films_aktors1` FOREIGN KEY (`aktors_id`) REFERENCES `aktors` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_aktors_has_films_films1` FOREIGN KEY (`films_id`) REFERENCES `films` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `films`
--
ALTER TABLE `films`
  ADD CONSTRAINT `fk_films_kelompoks1` FOREIGN KEY (`kelompoks_id`) REFERENCES `kelompoks` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `film_studio`
--
ALTER TABLE `film_studio`
  ADD CONSTRAINT `fk_studios_has_films_films1` FOREIGN KEY (`films_id`) REFERENCES `films` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_studios_has_films_studios1` FOREIGN KEY (`studios_id`) REFERENCES `studios` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `genre_film`
--
ALTER TABLE `genre_film`
  ADD CONSTRAINT `fk_films_has_genres_films1` FOREIGN KEY (`films_id`) REFERENCES `films` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_films_has_genres_genres1` FOREIGN KEY (`genres_id`) REFERENCES `genres` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `invoices`
--
ALTER TABLE `invoices`
  ADD CONSTRAINT `fk_invoices_konsumens1` FOREIGN KEY (`konsumens_id`) REFERENCES `konsumens` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_invoices_pegawais1` FOREIGN KEY (`kasir_id`) REFERENCES `pegawais` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `sesi_films`
--
ALTER TABLE `sesi_films`
  ADD CONSTRAINT `fk_jadwal_film_has_film_studio_film_studio1` FOREIGN KEY (`studios_id`,`films_id`) REFERENCES `film_studio` (`studios_id`, `films_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_jadwal_film_has_film_studio_jadwal_film1` FOREIGN KEY (`jadwal_film_id`) REFERENCES `jadwal_films` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `studios`
--
ALTER TABLE `studios`
  ADD CONSTRAINT `fk_studios_cinemas1` FOREIGN KEY (`cinemas_id`) REFERENCES `cinemas` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_studios_jenis_studios` FOREIGN KEY (`jenis_studios_id`) REFERENCES `jenis_studios` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `tikets`
--
ALTER TABLE `tikets`
  ADD CONSTRAINT `fk_film_studio_has_invoices_invoices1` FOREIGN KEY (`invoices_id`) REFERENCES `invoices` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_film_studio_has_invoices_pegawais1` FOREIGN KEY (`operator_id`) REFERENCES `pegawais` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_tikets_sesi_films1` FOREIGN KEY (`jadwal_film_id`,`studios_id`,`films_id`) REFERENCES `sesi_films` (`jadwal_film_id`, `studios_id`, `films_id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
