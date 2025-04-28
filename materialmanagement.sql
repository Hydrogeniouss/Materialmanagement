-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 24, 2025 at 06:22 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `materialmanagement`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `user_id` int(11) NOT NULL,
  `password` varchar(16) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`user_id`, `password`) VALUES
(5, '&)(GZO'),
(1, 'eS57drt7gz\"'),
(2, 'ITFFOZ9/'),
(4, 'TIVUOBIPUO97'),
(3, 'ZIT)/(');

-- --------------------------------------------------------

--
-- Table structure for table `brand`
--

CREATE TABLE `brand` (
  `brand_id` int(11) NOT NULL,
  `brand` varchar(64) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `brand`
--

INSERT INTO `brand` (`brand_id`, `brand`) VALUES
(1, 'Black Diamond'),
(2, 'CAMP'),
(3, 'Edelrid'),
(4, 'Petzl'),
(5, 'Wild Country');

-- --------------------------------------------------------

--
-- Table structure for table `material`
--

CREATE TABLE `material` (
  `material_id` int(11) NOT NULL,
  `material` varchar(128) NOT NULL,
  `description` text NOT NULL,
  `amount_total` int(11) NOT NULL,
  `amount_available` int(11) DEFAULT NULL,
  `img_filepath` varchar(64) DEFAULT NULL,
  `brand_id` int(11) NOT NULL,
  `type_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `material`
--

INSERT INTO `material` (`material_id`, `material`, `description`, `amount_total`, `amount_available`, `img_filepath`, `brand_id`, `type_id`) VALUES
(1, 'Swift Protect Pro Dry Rope - 8.9mm', 'The first dynamic single rope with a sheath that includes aramid, for markedly increased cut resistance. Thanks to a special processing method, the Swift Protect Pro Dry remains dynamic. Despite reinforcement with aramid and the overall higher sheath content, the impact force remains within the required standard. These characteristics make the Swift Protect Pro Dry the ideal lead climbing rope and the perfect companion for alpine climbing and mountaineering.\r\n\r\n \r\n\r\n** This rope includes a middle marker.  When ordering by the foot, your order may include a middle marker that is not centered or other variations we\'re unable to control.  ', 100, 30, '../Images/Edelrid/SPPDR9_9mm.png', 3, 1),
(2, 'Offset Zero Friend', '\r\n    Narrow Head\r\n    High-Friction Machined Cam Faces\r\n    Stem Protection With Spring\r\n    Armoured Metal Plates\r\n    Effective Flexible Stem\r\n    Ergonomic Floating Trigger Design\r\n    Strong Lightweight Design\r\n    Ergonomic Thumb Loop\r\n    10 Mm Dyneema Extendable Sling\r\n', 3, 0, '../Images/Wild_Country/Offset_Zero_Friend.png', 5, 2),
(3, 'Pro Nut Set', '• Curved design provides secure placements and easy removal\r\n• Grooves help with setting and extraction in hard stone\r\n• Color-coded heads for faster selection\r\n \r\nA set of Pro Nuts covering the essential range of nuts for the modern trad rack. ', 999, 888, '../CAMP/Pro_Nut_Set.png', 2, 3),
(4, 'ATC Guide', 'Black Diamond\'s most versatile belay/rappel device, the Black Diamond ATC-Guide is now 10% lighter and features improved handling in guide mode. With an oval-ized anchor-hole, the device now feeds rope and allows you to pull rope more easily. Multiple friction modes provide the optimal amount of stopping power when lowering or rappelling, and the device\'s guide mode lets you belay one or two seconding climbers off an anchor.\r\n\r\n    Multiple friction modes for belay and rappel\r\n    Updated construction makes the device 10% lighter with improved rope handling.\r\n    Auto-block release hole accepts small carabiners\r\n    Versatile design accepts ropes from 8.1 to 11 mm\r\n    Durable cable holds its shape and resists getting caught up\r\n', 2, 1, '../Black_Diamond/ATC_Guide.png', 1, 4),
(5, 'Sm\'D Twist-Lock', 'Highly versatile, lightweight, compact, D-shaped locking carabiner\r\n\r\nThe Sm\'D is a compact asymmetrical aluminum locking carabiner that is lightweight and compact and can be used in numerous situations; it is easy to manipulate, even when wearing gloves.', 24, 12, '../Petzl/SmD_Twist-Lock.png', 4, 5);

-- --------------------------------------------------------

--
-- Table structure for table `member`
--

CREATE TABLE `member` (
  `user_id` int(11) NOT NULL,
  `pin` varchar(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `member`
--

INSERT INTO `member` (`user_id`, `pin`) VALUES
(10, '2349'),
(8, '3974'),
(6, '6787'),
(9, '9740'),
(7, '9876');

-- --------------------------------------------------------

--
-- Table structure for table `member_has_rented_material`
--

CREATE TABLE `member_has_rented_material` (
  `user_id` int(11) NOT NULL,
  `material_id` int(11) NOT NULL,
  `quantity` int(11) NOT NULL,
  `date_of_aquisition` datetime NOT NULL,
  `date_of_returnal` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `member_has_rented_material`
--

INSERT INTO `member_has_rented_material` (`user_id`, `material_id`, `quantity`, `date_of_aquisition`, `date_of_returnal`) VALUES
(10, 1, 70, '2025-04-24 18:20:28', '2025-04-30 18:20:28'),
(8, 2, 3, '2025-04-24 18:20:28', NULL),
(6, 3, 111, '2025-04-24 18:20:28', '2025-04-27 18:21:04'),
(9, 4, 1, '2025-04-24 18:20:28', '2025-04-25 18:21:04'),
(6, 5, 12, '2025-04-24 18:20:28', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `type`
--

CREATE TABLE `type` (
  `type_id` int(11) NOT NULL,
  `type` varchar(64) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `type`
--

INSERT INTO `type` (`type_id`, `type`) VALUES
(1, 'Rope'),
(2, 'Camp'),
(3, 'Nut'),
(4, 'Belay Device'),
(5, 'Carabiner');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `user_id` int(11) NOT NULL,
  `first_name` varchar(64) NOT NULL,
  `last_name` varchar(64) NOT NULL,
  `email` varchar(255) NOT NULL,
  `phone` varchar(27) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`user_id`, `first_name`, `last_name`, `email`, `phone`) VALUES
(1, 'Sandra', 'Amsel', 'SandraAmsel@rhyta.com', '0680 273 19 81'),
(2, 'Daniel', 'Lemann', 'DanielLemann@teleworm.us ', '0660 534 51 20'),
(3, 'Marina', 'Würfel', 'MarinaWuerfel@teleworm.us ', '0681 204 12 77'),
(4, 'Ursula', 'Würfel', 'UrsulaWuerfel@dayrep.com', '0699 563 75 14'),
(5, 'Jessica', 'Schiffer', 'JessicaSchiffer@rhyta.com', '0680 408 60 08'),
(6, 'Jana', 'Gerste', 'JanaGerste@jourrapide.com', '0664 590 04 55'),
(7, 'Klaudia', 'Schmitt', 'KlaudiaSchmitt@dayrep.com', '0660 715 97 57'),
(8, 'Tim', 'Kortig', 'TimKortig@teleworm.us', '0699 992 31 93'),
(9, 'Anne', 'Schuster', 'AnneShuster@jourrapide.com', '0688 687 48 59'),
(10, 'Julia', 'Küfer', 'JuliaKuefer@teleworm.us ', '0681 819 90 66');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`user_id`),
  ADD UNIQUE KEY `password_UNIQUE` (`password`),
  ADD KEY `fk_admin_user_idx` (`user_id`);

--
-- Indexes for table `brand`
--
ALTER TABLE `brand`
  ADD PRIMARY KEY (`brand_id`);

--
-- Indexes for table `material`
--
ALTER TABLE `material`
  ADD PRIMARY KEY (`material_id`),
  ADD KEY `fk_material_brand1_idx` (`brand_id`),
  ADD KEY `fk_material_type1_idx` (`type_id`);

--
-- Indexes for table `member`
--
ALTER TABLE `member`
  ADD PRIMARY KEY (`user_id`),
  ADD UNIQUE KEY `password_UNIQUE` (`pin`),
  ADD KEY `fk_admin_user_idx` (`user_id`);

--
-- Indexes for table `member_has_rented_material`
--
ALTER TABLE `member_has_rented_material`
  ADD KEY `fk_material_has_member_member1_idx` (`user_id`),
  ADD KEY `fk_material_has_member_material1_idx` (`material_id`);

--
-- Indexes for table `type`
--
ALTER TABLE `type`
  ADD PRIMARY KEY (`type_id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`user_id`),
  ADD UNIQUE KEY `user_id_UNIQUE` (`user_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `brand`
--
ALTER TABLE `brand`
  MODIFY `brand_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `material`
--
ALTER TABLE `material`
  MODIFY `material_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `admin`
--
ALTER TABLE `admin`
  ADD CONSTRAINT `fk_admin_user` FOREIGN KEY (`user_id`) REFERENCES `user` (`user_id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `material`
--
ALTER TABLE `material`
  ADD CONSTRAINT `fk_material_brand1` FOREIGN KEY (`brand_id`) REFERENCES `brand` (`brand_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_material_type1` FOREIGN KEY (`type_id`) REFERENCES `type` (`type_id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `member`
--
ALTER TABLE `member`
  ADD CONSTRAINT `fk_admin_user0` FOREIGN KEY (`user_id`) REFERENCES `user` (`user_id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `member_has_rented_material`
--
ALTER TABLE `member_has_rented_material`
  ADD CONSTRAINT `fk_material_has_member_material1` FOREIGN KEY (`material_id`) REFERENCES `material` (`material_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_material_has_member_member1` FOREIGN KEY (`user_id`) REFERENCES `member` (`user_id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
