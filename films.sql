-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 12, 2024 at 02:28 PM
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

--
-- Dumping data for table `films`
--

INSERT INTO `films` (`id`, `judul`, `sinopsis`, `tahun`, `durasi`, `kelompoks_id`, `bahasa`, `is_sub_indo`, `cover_image`, `diskon_nominal`) VALUES
(1, 'SPIDER-MAN: ACROSS THE SPIDER VERSE', 'After reuniting with Gwen Stacy, Brooklyn\'s full-time, friendly neighborhood Spider-Man is catapulted across the Multiverse, where he encounters a team of Spider-People charged with protecting its very existence. However, when the heroes clash on how to handle a new threat, Miles finds himself pitted against the other Spiders. He must soon redefine what it means to be a hero so he can save the people he loves most.', 2023, 140, 2, 'EN', 1, 'p4', 0),
(2, 'WONKA', 'With dreams of opening a shop in a city renowned for its chocolate, a young and poor Willy Wonka discovers that the industry is run by a cartel of greedy chocolatiers.', 2023, 116, 1, 'EN', 1, 'p2', 0),
(3, 'THE BEEKEPER', 'One man\'s brutal campaign for vengeance takes on national stakes after it\'s revealed he\'s a former operative of a powerful and clandestine organization known as Beekeepers.', 2024, 105, 4, 'EN', 1, 'p3', 0),
(4, 'SPIDER-MAN: ACROSS THE SPIDER VERSE', 'After reuniting with Gwen Stacy, Brooklyn\'s full-time, friendly neighborhood Spider-Man is catapulted across the Multiverse, where he encounters a team of Spider-People charged with protecting its very existence. However, when the heroes clash on how to handle a new threat, Miles finds himself pitted against the other Spiders. He must soon redefine what it means to be a hero so he can save the people he loves most.', 2023, 140, 2, 'EN', 1, 'p4', 0),
(5, 'TRANSFORMER: RISE OF THE BEAST', 'Optimus Prime and the Autobots team up with a down on his luck young man, an aspiring historian and with a powerful faction of Transformers known as the Maximals to combat a sinister force from outer space that threatens the Earth and all of mankind.\r\n', 2023, 127, 2, 'EN', 1, 'p5', 0),
(6, 'NIGHT SWIM', 'Forced into early retirement by a degenerative illness, former baseball player Ray Waller moves into a new house with his wife and two children. He hopes that the backyard swimming pool will be fun for the kids and provide physical therapy for himself. However, a dark secret from the home\'s past soon unleashes a malevolent force that drags the family into the depths of inescapable terror.\r\n', 2024, 98, 4, 'EN', 1, 'p6', 0),
(7, 'THE BOOK OF CLARENCE', 'A down-on-his-luck man struggles to find a better life for his family while fighting to free himself of debt. Captivated by the power and glory of the rising Messiah, he risks everything to carve his own path to a divine life, ultimately discovering that the redemptive power of belief may be his only way out.', 2023, 129, 3, 'EN', 1, 'p7', 0),
(8, 'THE PAINTER', 'An ex-CIA operative is tracked down by a young woman and they become entangled in an unauthorised black ops programme.', 2024, 100, 4, 'EN', 1, 'p8', 0),
(9, 'DARKGAME', 'A determined detective races against time to stop a twisted game show on the dark web, where captives are forced to compete for their lives.', 2024, 90, 4, 'EN', 1, 'p9', 0),
(10, 'WANTED MAN', 'Follows a police officer who must retrieve an eyewitness and escort her after a cartel shooting leaves several DEA agents dead, but then he must decide who to trust when they discover that the attack was executed by American forces.', 2024, 85, 4, 'EN', 1, 'p10', 0),
(11, 'INSIDE OUT 2', 'Joy, Sadness, Anger, Fear and Disgust have been running a successful operation by all accounts. However, when Anxiety shows up, they aren\'t sure how to feel.', 2024, 120, 1, 'EN', 1, 'p11', 0),
(12, 'GODZILLA VS KONG', 'Kong and his protectors undertake a perilous journey to find his true home. Along for the ride is Jia, an orphaned girl who has a unique and powerful bond with the mighty beast. However, they soon find themselves in the path of an enraged Godzilla as he cuts a swath of destruction across the globe. The initial confrontation between the two titans -- instigated by unseen forces -- is only the beginning of the mystery that lies deep within the core of the planet.\r\n', 2024, 117, 3, 'EN', 1, 'p12', 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `films`
--
ALTER TABLE `films`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_films_kelompoks1_idx` (`kelompoks_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `films`
--
ALTER TABLE `films`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `films`
--
ALTER TABLE `films`
  ADD CONSTRAINT `fk_films_kelompoks1` FOREIGN KEY (`kelompoks_id`) REFERENCES `kelompoks` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
