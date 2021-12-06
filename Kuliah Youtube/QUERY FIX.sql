/*
SQLyog Ultimate v12.5.1 (32 bit)
MySQL - 10.4.20-MariaDB : Database - kasir_penjualan
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`kasir_penjualan` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;

USE `kasir_penjualan`;

/*Table structure for table `detail_transaksi` */

DROP TABLE IF EXISTS `detail_transaksi`;

CREATE TABLE `detail_transaksi` (
  `id_transaksi` varchar(5) NOT NULL,
  `tgl_transaksi` date DEFAULT NULL,
  `uang_total` int(11) NOT NULL,
  `dibayar` int(11) NOT NULL,
  `kembalian` int(11) NOT NULL,
  PRIMARY KEY (`id_transaksi`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `detail_transaksi` */

insert  into `detail_transaksi`(`id_transaksi`,`tgl_transaksi`,`uang_total`,`dibayar`,`kembalian`) values 
('T001','2021-11-04',5000,20000,0);

/*Table structure for table `tabel_barang` */

DROP TABLE IF EXISTS `tabel_barang`;

CREATE TABLE `tabel_barang` (
  `kode_barang` varchar(6) NOT NULL,
  `nama_barang` varchar(6) DEFAULT NULL,
  `jenis_barang` varchar(25) DEFAULT NULL,
  `satuan_barang` varchar(25) DEFAULT NULL,
  `harga_beli` int(11) DEFAULT NULL,
  `harga_jual` int(11) DEFAULT NULL,
  `stok` int(11) DEFAULT NULL,
  PRIMARY KEY (`kode_barang`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tabel_barang` */

insert  into `tabel_barang`(`kode_barang`,`nama_barang`,`jenis_barang`,`satuan_barang`,`harga_beli`,`harga_jual`,`stok`) values 
('B001','Pena','ATK','biji',10000,12000,60),
('B002','sodiki','ATL','Biji',100004,120006,14),
('B003','Pena','ATK','Biji',20000,16000,12),
('B004','Pengga','ATK',NULL,NULL,NULL,NULL);

/*Table structure for table `tabel_user` */

DROP TABLE IF EXISTS `tabel_user`;

CREATE TABLE `tabel_user` (
  `kode_user` varchar(10) NOT NULL,
  `username` varchar(25) NOT NULL,
  `password` varchar(25) NOT NULL,
  PRIMARY KEY (`kode_user`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tabel_user` */

/*Table structure for table `transaksi` */

DROP TABLE IF EXISTS `transaksi`;

CREATE TABLE `transaksi` (
  `id_transaksi` varbinary(5) NOT NULL,
  `id_penjualan` varchar(5) DEFAULT NULL,
  `kode_barang` varchar(6) DEFAULT NULL,
  `total` int(6) DEFAULT NULL,
  `total_harga` int(11) NOT NULL,
  PRIMARY KEY (`id_transaksi`),
  KEY `transaksi_fk0` (`id_transaksi`),
  KEY `transaksi_fk1` (`kode_barang`),
  KEY `id_penjualan` (`id_penjualan`),
  CONSTRAINT `transaksi_fk0` FOREIGN KEY (`id_penjualan`) REFERENCES `detail_transaksi` (`id_transaksi`),
  CONSTRAINT `transaksi_fk1` FOREIGN KEY (`kode_barang`) REFERENCES `tabel_barang` (`kode_barang`),
  CONSTRAINT `transaksi_ibfk_1` FOREIGN KEY (`id_penjualan`) REFERENCES `detail_transaksi` (`id_transaksi`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `transaksi` */

/* Trigger structure for table `transaksi` */

DELIMITER $$

/*!50003 DROP TRIGGER*//*!50032 IF EXISTS */ /*!50003 `t_keluar` */$$

/*!50003 CREATE */ /*!50017 DEFINER = 'root'@'localhost' */ /*!50003 TRIGGER `t_keluar` AFTER INSERT ON `transaksi` FOR EACH ROW BEGIN
	UPDATE `tabel_barang` SET `stok` = `stok` - NEW.`total`
	WHERE `kode_barang` = NEW.`kode_barang`;

    END */$$


DELIMITER ;

/* Trigger structure for table `transaksi` */

DELIMITER $$

/*!50003 DROP TRIGGER*//*!50032 IF EXISTS */ /*!50003 `delet_masuk` */$$

/*!50003 CREATE */ /*!50017 DEFINER = 'root'@'localhost' */ /*!50003 TRIGGER `delet_masuk` AFTER DELETE ON `transaksi` FOR EACH ROW BEGIN
	UPDATE `tabel_barang` SET `stok` = `stok` + OLD.`total`
	WHERE `kode_barang` = OLD.`kode_barang`;
    END */$$


DELIMITER ;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
