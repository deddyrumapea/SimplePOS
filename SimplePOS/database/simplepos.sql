-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 23, 2021 at 09:30 AM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `simplepos`
--

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE `product` (
  `id` int(11) NOT NULL,
  `name` varchar(63) NOT NULL,
  `price` int(11) NOT NULL,
  `stock` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`id`, `name`, `price`, `stock`) VALUES
(1, 'Monde Butter Cookies', 49000, 12),
(2, 'Vixal Pembersih Toilet 350ml', 12000, 17),
(3, 'Malkist Crackers 90g', 5200, 28),
(4, 'Nora Kerak Keling', 7000, 12),
(5, 'ABC Kecap Manis', 3000, 87),
(6, 'Superpell 50ml', 4500, 78),
(7, 'Bear Brand 120ml', 8000, 19),
(8, 'Chocolatos 50g', 1000, 90),
(9, 'Chitato Sapi Panggang 500g', 8900, 34),
(10, 'Pulpy Orange 360ml', 6500, 41),
(11, 'Combatrin Obat Cacing 500ml', 32000, 21),
(12, 'Wipol Pembersih Lantai 750ml', 29800, 43),
(13, 'Leo Kripik Kentang 14gr', 1600, 32),
(14, 'Kerupuk Kemplang 300gr', 34000, 33),
(15, 'Terasi Udang Mamasuka 120g', 1200, 25),
(16, 'Indomie Mie Soto Lamongan', 2500, 31),
(17, 'Sunsilk Hijabisa Sachet', 500, 90),
(18, 'Walls Feast', 4500, 31),
(19, 'Malkist Abon 65g', 500, 12),
(20, 'Lays Rumput Laut 100g', 4300, 23),
(21, 'Snowman Boardmarker', 4800, 20);

-- --------------------------------------------------------

--
-- Table structure for table `transaction`
--

CREATE TABLE `transaction` (
  `id` int(11) NOT NULL,
  `date` date NOT NULL,
  `total` int(11) NOT NULL,
  `cash` int(11) NOT NULL,
  `change` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `transaction`
--

INSERT INTO `transaction` (`id`, `date`, `total`, `cash`, `change`) VALUES
(1, '2021-05-22', 154000, 200000, 46000),
(2, '2021-05-22', 26000, 30000, 4000),
(3, '2021-05-22', 38200, 40000, 1800),
(4, '2021-05-22', 42200, 50000, 7800),
(5, '2021-05-22', 24000, 25000, 1000),
(6, '2021-05-22', 13500, 15000, 1500),
(7, '2021-05-22', 21000, 30000, 9000),
(8, '2021-05-22', 12900, 13000, 100),
(9, '2021-05-22', 9000, 9000, 0),
(10, '2021-05-22', 36400, 40000, 3600),
(11, '2021-05-22', 4500, 5000, 500),
(12, '2021-05-22', 15600, 20000, 4400),
(13, '2021-05-22', 64500, 70000, 5500),
(14, '2021-05-22', 73000, 75000, 2000),
(15, '2021-05-22', 20000, 20000, 0),
(16, '2021-05-22', 3000, 5000, 2000),
(17, '2021-05-22', 27200, 30000, 2800),
(18, '2021-05-22', 49000, 50000, 1000),
(19, '2021-05-22', 31200, 40000, 8800),
(20, '2021-05-22', 178100, 200000, 21900),
(21, '2021-05-22', 49000, 50000, 1000),
(22, '2021-05-22', 60000, 60000, 0),
(23, '2021-05-22', 98000, 100000, 2000),
(24, '2021-05-22', 60000, 60000, 0),
(25, '2021-05-22', 245000, 300000, 55000),
(26, '2021-05-22', 49000, 50000, 1000),
(27, '2021-05-22', 36000, 40000, 4000),
(28, '2021-05-22', 98000, 100000, 2000);

-- --------------------------------------------------------

--
-- Table structure for table `transaction_product`
--

CREATE TABLE `transaction_product` (
  `id_transaction` int(11) NOT NULL,
  `id_product` int(11) NOT NULL,
  `quantity` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `transaction_product`
--

INSERT INTO `transaction_product` (`id_transaction`, `id_product`, `quantity`) VALUES
(1, 1, 2),
(1, 7, 1),
(1, 2, 4),
(2, 10, 4),
(3, 13, 2),
(3, 2, 2),
(3, 7, 1),
(3, 5, 1),
(4, 17, 10),
(4, 11, 1),
(4, 3, 1),
(5, 2, 2),
(6, 6, 3),
(7, 4, 3),
(8, 20, 3),
(9, 5, 3),
(10, 3, 7),
(11, 6, 1),
(12, 3, 3),
(13, 6, 1),
(13, 2, 5),
(14, 2, 2),
(14, 1, 1),
(15, 7, 1),
(15, 2, 1),
(16, 5, 1),
(17, 15, 1),
(17, 3, 5),
(18, 1, 1),
(19, 3, 6),
(20, 1, 1),
(20, 3, 3),
(20, 5, 2),
(20, 6, 1),
(20, 7, 5),
(20, 9, 2),
(20, 13, 7),
(20, 14, 1),
(21, 1, 1),
(22, 2, 5),
(23, 1, 2),
(24, 2, 5),
(25, 1, 5),
(26, 1, 1),
(27, 2, 3),
(28, 1, 2);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `transaction`
--
ALTER TABLE `transaction`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `product`
--
ALTER TABLE `product`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT for table `transaction`
--
ALTER TABLE `transaction`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
