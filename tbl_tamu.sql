-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 09, 2022 at 11:55 AM
-- Server version: 10.4.21-MariaDB
-- PHP Version: 8.0.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `data_kunjungan_perpus`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_tamu`
--

CREATE TABLE `tbl_tamu` (
  `No` varchar(20) NOT NULL,
  `Nama` varchar(50) NOT NULL,
  `JenisKelamin` varchar(50) NOT NULL,
  `DurasiKunjungan` varchar(50) NOT NULL,
  `BukuBacaan` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_tamu`
--

INSERT INTO `tbl_tamu` (`No`, `Nama`, `JenisKelamin`, `DurasiKunjungan`, `BukuBacaan`) VALUES
('001', 'Puan Abidah', 'Wanita', '1 Jam', 'Harry Potter and The Wizard'),
('002', 'Hwang Renjun', 'Pria', '2 Jam', 'Ketika Rindu, Kamulah Yang Kupikirkan'),
('003', 'Emma Watson', 'Wanita', '4 Jam', 'Feminist Bukan Hal Negatif'),
('004', 'Kim Jay', 'Pria', 'Dibawah 1 Jam', 'Boys Can Be Soft Too'),
('005', 'Yuki Priyandi', 'Pria', '2 Jam', 'Ketika Cinta Bertasbih'),
('006', 'Antonia Carlo', 'Pria', '5 Jam', 'Akibat Insomnia'),
('007', 'Priyanka Chopra', 'Wanita', '2 Jam', 'Jika Kita Tak Pernah Jadi Apa-Apa'),
('008', 'Lee Je Hoon', 'Pria', '2 Jam', 'I Love U, But I Hate U');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_tamu`
--
ALTER TABLE `tbl_tamu`
  ADD PRIMARY KEY (`No`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
