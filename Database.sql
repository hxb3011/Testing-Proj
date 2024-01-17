-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               8.0.35 - MySQL Community Server - GPL
-- Server OS:                    Win64
-- HeidiSQL Version:             12.6.0.6765
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumping database structure for qlks
CREATE DATABASE IF NOT EXISTS `qlks` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `qlks`;
-- Dumping structure for table qlks.permission_group
CREATE TABLE IF NOT EXISTS `permission_group` (
  `ID` varchar(50) NOT NULL,
  `Name` varchar(50) DEFAULT NULL,
  `Permissions` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Dumping data for table qlks.permission_group: ~4 rows (approximately)
INSERT INTO `permission_group` (`ID`, `Name`, `Permissions`) VALUES
	('01', 'StaffManagement', 'rYAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA'),
	('02', 'ServiceManagement', 'AHAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA'),
	('03', 'AllBusiness', 'AUQXQAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA'),
	('04', 'AllPermissions', '////wAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA');

-- Dumping structure for table qlks.account
CREATE TABLE IF NOT EXISTS `account` (
  `UID` varchar(50) NOT NULL,
  `UserName` varchar(50) DEFAULT NULL,
  `Password` varchar(50) DEFAULT NULL,
  `Permissions` varchar(50) DEFAULT NULL,
  `Status` int DEFAULT NULL,
  PRIMARY KEY (`UID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Dumping data for table qlks.account: ~4 rows (approximately)
INSERT INTO `account` (`UID`, `UserName`, `Password`, `Permissions`, `Status`) VALUES
	('000', 'root99', 'Hello|11', '///4AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA', 0),
	('001', 'phong0', 'Phong!!1', 'AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA', 1),
	('002', 'en0123', 'ABcd!@34', 'AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA', 2),
	('003', 'binz126', 'Binz||16', 'AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA', 1);
-- Dumping structure for table qlks.role
CREATE TABLE IF NOT EXISTS `role` (
  `ID` varchar(50) NOT NULL,
  `Name` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Dumping data for table qlks.role: ~2 rows (approximately)
INSERT INTO `role` (`ID`, `Name`) VALUES
	('RO01', 'Manage'),
	('RO02', 'Staff');
-- Dumping structure for table qlks.convinience
CREATE TABLE IF NOT EXISTS `convinience` (
  `ID` varchar(50) NOT NULL,
  `Name` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
-- Dumping structure for table qlks.room_type
CREATE TABLE IF NOT EXISTS `room_type` (
  `ID` varchar(50) NOT NULL,
  `Name` varchar(50) DEFAULT NULL,
  `UnitPrice` double DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
-- Dumping structure for table qlks.staff
CREATE TABLE IF NOT EXISTS `staff` (
  `ID` varchar(50) NOT NULL,
  `FullName` varchar(50) DEFAULT NULL,
  `Gender` varchar(50) DEFAULT NULL,
  `Birthday` date DEFAULT NULL,
  `Address` varchar(50) DEFAULT NULL,
  `CitizenID` varchar(50) DEFAULT NULL,
  `PhoneNumber` varchar(50) DEFAULT NULL,
  `Salary` double DEFAULT NULL,
  `Status` int DEFAULT NULL,
  `ImageLink` varchar(300) DEFAULT NULL,
  `PermissionGroupID` varchar(50) DEFAULT NULL,
  `RoleID` varchar(50) DEFAULT NULL,
  `UID` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK1_permission` (`PermissionGroupID`),
  KEY `FK2_uid` (`UID`),
  KEY `FK3_role` (`RoleID`),
  CONSTRAINT `FK1_permission` FOREIGN KEY (`PermissionGroupID`) REFERENCES `permission_group` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK2_uid` FOREIGN KEY (`UID`) REFERENCES `account` (`UID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK3_role` FOREIGN KEY (`RoleID`) REFERENCES `role` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Dumping data for table qlks.staff: ~0 rows (approximately)
INSERT INTO `staff` (`ID`, `FullName`, `Gender`, `Birthday`, `Address`, `CitizenID`, `PhoneNumber`, `Salary`, `Status`, `ImageLink`, `PermissionGroupID`, `RoleID`, `UID`) VALUES
	('SA003', 'Nguyễn Thị E', 'Female', '1998-03-19', 'Đà Nẵng', '123456789', '0987654321', 4000000, 1, NULL, NULL, 'RO01', '002'),
	('SA005', 'Binz', '0', '1990-01-03', 'TP HỒ CHÍ MINH', '369875412', '0369874512', 1000000, 0, NULL, '02', 'RO02', '003');
-- Dumping data for table qlks.room_type: ~6 rows (approximately)
INSERT INTO `room_type` (`ID`, `Name`, `UnitPrice`) VALUES
	('RT01', 'Thông thường', 150000),
	('RT02', 'Đơn', 200000),
	('RT03', 'Cao cấp', 250000),
	('RT04', 'Gia đình', 300000),
	('RT05', 'Sang trọng ', 400000),
	('RT06', 'Đôi', 500000),
	('RT07', 'view đẹp', 1000000),
	('RT08', 'Phòng Cách Âm', 6000000);
-- Dumping data for table qlks.convinience: ~4 rows (approximately)
INSERT INTO `convinience` (`ID`, `Name`) VALUES
	('CO01', 'Giường'),
	('CO02', 'Ti vi'),
	('CO03', 'Bồn tắm'),
	('CO04', 'Máy lạnh'),
	('CO05', 'Wifi'),
	('CO06', 'máy nấu nước');

-- Dumping structure for table qlks.convinience_room_type
CREATE TABLE IF NOT EXISTS `convinience_room_type` (
  `ConvinienceID` varchar(50) DEFAULT NULL,
  `RoomTypeID` varchar(50) DEFAULT NULL,
  `Quantity` int DEFAULT NULL,
  KEY `FK1_typeid` (`RoomTypeID`),
  KEY `FK2_convinience` (`ConvinienceID`),
  CONSTRAINT `FK1_typeid` FOREIGN KEY (`RoomTypeID`) REFERENCES `room_type` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK2_convinience` FOREIGN KEY (`ConvinienceID`) REFERENCES `convinience` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Dumping data for table qlks.convinience_room_type: ~5 rows (approximately)
INSERT INTO `convinience_room_type` (`ConvinienceID`, `RoomTypeID`, `Quantity`) VALUES
	('CO03', 'RT01', 2),
	('CO04', 'RT01', 1),
	('CO03', 'RT06', 3),
	('CO02', 'RT04', 1),
	('CO04', 'RT06', 2);

-- Dumping structure for table qlks.customer
CREATE TABLE IF NOT EXISTS `customer` (
  `ID` varchar(50) NOT NULL,
  `Fullname` varchar(50) DEFAULT NULL,
  `Gender` varchar(10) DEFAULT NULL,
  `Birthday` date DEFAULT NULL,
  `Address` varchar(50) DEFAULT NULL,
  `CitizenID` varchar(50) DEFAULT NULL,
  `PhoneNumber` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Dumping data for table qlks.customer: ~10 rows (approximately)
INSERT INTO `customer` (`ID`, `Fullname`, `Gender`, `Birthday`, `Address`, `CitizenID`, `PhoneNumber`) VALUES
	('CU001', 'Trần Bình Trọng Update', '0', '2002-10-31', 'TP HCM', '534982534', '087593682'),
	('CU002', 'Lê Hữu Phước', '1', '2003-08-21', 'An giang', '678342987', '078532941'),
	('CU003', 'Lê Thị Hồng', '0', '1998-03-15', 'Bình Phước', '798324143', '097538542'),
	('CU004', 'Cao Thị Lan', '0', '1990-07-07', 'Hà Nội', '897953427', '097432941'),
	('CU005', 'Nguyễn Thành Tiến', '1', '2002-05-17', 'Quảng Ninh', '879543598', '019348295'),
	('CU006', 'Nguyen Van A', '1', '2023-11-11', 'tuy phuoc binh dinh', '23422222', '43233232432'),
	('CU007', 'Nguyen Thi C', '0', '2023-11-11', 'Tuy phước', '1', '23333333333'),
	('CU008', 'Nguyen Thi Binh', '0', '2023-11-15', 'Tuy Phuoc Binh Dinh', '35534345', '0987654321'),
	('CU009', 'Nguyen Minh Lam', '1', '2023-11-29', 'Sai Gon Quan 8', '1234567890', '0987654321'),
	('CU010', 'Huynh Xuan Duy', '0', '2023-12-03', 'Bien Hoa Dong Nai', '5874963512', '0978654321');
-- Dumping structure for table qlks.reservation
CREATE TABLE IF NOT EXISTS `reservation` (
  `ID` varchar(50) NOT NULL,
  `CreatedAt` datetime NOT NULL,
  `CustomerID` varchar(50) DEFAULT NULL,
  `StaffID` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK1_customerid` (`CustomerID`),
  KEY `FK2_staff` (`StaffID`),
  CONSTRAINT `FK1_customerid` FOREIGN KEY (`CustomerID`) REFERENCES `customer` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK2_staff` FOREIGN KEY (`StaffID`) REFERENCES `staff` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Dumping data for table qlks.reservation: ~2 rows (approximately)
INSERT INTO `reservation` (`ID`, `CreatedAt`, `CustomerID`, `StaffID`) VALUES
	('RE00001', '2023-11-29 14:59:57', 'CU009', 'SA003'),
	('RE00002', '2023-11-29 15:00:38', 'CU008', 'SA005');
  -- Dumping structure for table qlks.invoice
CREATE TABLE IF NOT EXISTS `invoice` (
  `ID` varchar(50) NOT NULL,
  `StaffID` varchar(50) DEFAULT NULL,
  `CustomerID` varchar(50) DEFAULT NULL,
  `ReservationID` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK1_customer` (`CustomerID`),
  KEY `FK2_staffid` (`StaffID`),
  KEY `fk_invoice_reservation` (`ReservationID`),
  CONSTRAINT `FK1_customer` FOREIGN KEY (`CustomerID`) REFERENCES `customer` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK2_staffid` FOREIGN KEY (`StaffID`) REFERENCES `staff` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_invoice_reservation` FOREIGN KEY (`ReservationID`) REFERENCES `reservation` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Dumping data for table qlks.invoice: ~0 rows (approximately)

-- Dumping structure for table qlks.room
CREATE TABLE IF NOT EXISTS `room` (
  `ID` varchar(50) NOT NULL,
  `Status` int DEFAULT NULL,
  `RoomTypeID` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK1_type` (`RoomTypeID`),
  CONSTRAINT `FK1_type` FOREIGN KEY (`RoomTypeID`) REFERENCES `room_type` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Dumping data for table qlks.room: ~11 rows (approximately)
INSERT INTO `room` (`ID`, `Status`, `RoomTypeID`) VALUES
	('A101', 0, 'RT01'),
	('A102', 1, 'RT03'),
	('A103', 2, 'RT03'),
	('A201', 1, 'RT02'),
	('A202', 2, 'RT06'),
	('B101', 0, 'RT06'),
	('B102', 1, 'RT06'),
	('B201', 2, 'RT05'),
	('B202', 0, 'RT05'),
	('C101', 1, 'RT02'),
	('C102', 2, 'RT01');

-- Dumping structure for table qlks.room_reservation
CREATE TABLE IF NOT EXISTS `room_reservation` (
  `ID` varchar(50) NOT NULL,
  `StartTime` varchar(50) DEFAULT NULL,
  `EndTime` varchar(50) DEFAULT NULL,
  `Status` int DEFAULT NULL,
  `ReservationID` varchar(50) DEFAULT NULL,
  `RoomID` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `fk_room_reservation_ReservationID` (`ReservationID`),
  KEY `fk_room_reservation_RoomID` (`RoomID`),
  CONSTRAINT `fk_room_reservation_ReservationID` FOREIGN KEY (`ReservationID`) REFERENCES `reservation` (`ID`),
  CONSTRAINT `fk_room_reservation_RoomID` FOREIGN KEY (`RoomID`) REFERENCES `room` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Dumping data for table qlks.room_reservation: ~0 rows (approximately)
-- Dumping structure for table qlks.service_type
CREATE TABLE IF NOT EXISTS `service_type` (
  `ID` varchar(50) NOT NULL,
  `Name` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Dumping data for table qlks.service_type: ~6 rows (approximately)
INSERT INTO `service_type` (`ID`, `Name`) VALUES
	('ST02', 'Đồ ăn'),
	('ST03', 'Đưa đón'),
	('ST04', 'Nước uống'),
	('ST05', 'Bơi lội'),
	('ST06', 'Ca hát '),
	('ST07', 'Thư giãn'),
	('ST08', 'Sắc đẹp');
-- Dumping structure for table qlks.service
CREATE TABLE IF NOT EXISTS `service` (
  `ID` varchar(50) NOT NULL,
  `Name` varchar(50) DEFAULT NULL,
  `UnitPrice` double DEFAULT NULL,
  `Unit` varchar(50) DEFAULT NULL,
  `ServiceTypeID` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK1_serviectype` (`ServiceTypeID`),
  CONSTRAINT `FK1_serviectype` FOREIGN KEY (`ServiceTypeID`) REFERENCES `service_type` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Dumping data for table qlks.service: ~0 rows (approximately)
INSERT INTO `service` (`ID`, `Name`, `UnitPrice`, `Unit`, `ServiceTypeID`) VALUES
	('SE001', 'Sting Vàng', 10000, 'Chai', 'ST04'),
	('SE002', 'Bò nướng muối ớt', 300000, 'Dĩa ', 'ST02'),
	('SE003', 'Xe khách', 100000, 'Chuyến', 'ST03'),
	('SE004', 'Xông hơi', 1000000, 'Lượt', 'ST05'),
	('SE005', 'Hớt tóc', 50000, 'dong', 'ST08');


-- Dumping structure for table qlks.rent_room_detail
CREATE TABLE IF NOT EXISTS `rent_room_detail` (
  `ID` varchar(50) NOT NULL,
  `AddedTime` datetime DEFAULT NULL,
  `PaidTime` datetime DEFAULT NULL,
  `StartTime` datetime DEFAULT NULL,
  `EndTime` datetime DEFAULT NULL,
  `RoomID` varchar(50) DEFAULT NULL,
  `StaffID` varchar(50) DEFAULT NULL,
  `InvoiceID` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK1_invoiceid` (`InvoiceID`),
  KEY `FK2_staffi` (`StaffID`),
  KEY `fk_rent_room_detail_room` (`RoomID`),
  CONSTRAINT `FK1_invoiceid` FOREIGN KEY (`InvoiceID`) REFERENCES `invoice` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK2_staffi` FOREIGN KEY (`StaffID`) REFERENCES `staff` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_rent_room_detail_room` FOREIGN KEY (`RoomID`) REFERENCES `room` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Dumping data for table qlks.rent_room_detail: ~0 rows (approximately)


-- Dumping structure for table qlks.use_service_detail
CREATE TABLE IF NOT EXISTS `use_service_detail` (
  `ID` varchar(50) NOT NULL,
  `Quantity` int DEFAULT NULL,
  `ServiceID` varchar(50) DEFAULT NULL,
  `RentRoomID` varchar(50) DEFAULT NULL,
  `StaffID` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK2_st` (`StaffID`),
  KEY `FK3_serviceid` (`ServiceID`),
  KEY `fk_use_service_detail_rent_room` (`RentRoomID`),
  CONSTRAINT `FK2_st` FOREIGN KEY (`StaffID`) REFERENCES `staff` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK3_serviceid` FOREIGN KEY (`ServiceID`) REFERENCES `service` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_use_service_detail_rent_room` FOREIGN KEY (`RentRoomID`) REFERENCES `rent_room_detail` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Dumping data for table qlks.use_service_detail: ~0 rows (approximately)

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
