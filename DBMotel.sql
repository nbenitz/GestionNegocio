-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         5.1.56-community - MySQL Community Server (GPL)
-- SO del servidor:              Win32
-- HeidiSQL Versión:             9.5.0.5196
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Volcando estructura de base de datos para controlstock
CREATE DATABASE IF NOT EXISTS `controlstock` /*!40100 DEFAULT CHARACTER SET utf8 COLLATE utf8_spanish_ci */;
USE `controlstock`;

-- Volcando estructura para tabla controlstock.altaprod
CREATE TABLE IF NOT EXISTS `altaprod` (
  `idAlta` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `idProductoFK` bigint(20) unsigned NOT NULL,
  `Fecha` datetime NOT NULL,
  `Cantidad` double unsigned NOT NULL,
  `Motivo` smallint(5) unsigned NOT NULL,
  PRIMARY KEY (`idAlta`),
  KEY `FK_altaprod_producto` (`idProductoFK`),
  KEY `FK_altaprod_altaprodmotivo` (`Motivo`),
  CONSTRAINT `FK_altaprod_altaprodmotivo` FOREIGN KEY (`Motivo`) REFERENCES `altaprodmotivo` (`idMotivo`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `FK_altaprod_producto` FOREIGN KEY (`idProductoFK`) REFERENCES `producto` (`idProducto`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- Volcando datos para la tabla controlstock.altaprod: ~1 rows (aproximadamente)
/*!40000 ALTER TABLE `altaprod` DISABLE KEYS */;
INSERT INTO `altaprod` (`idAlta`, `idProductoFK`, `Fecha`, `Cantidad`, `Motivo`) VALUES
	(1, 1, '2018-04-01 08:56:54', 5, 3);
/*!40000 ALTER TABLE `altaprod` ENABLE KEYS */;

-- Volcando estructura para tabla controlstock.altaprodmotivo
CREATE TABLE IF NOT EXISTS `altaprodmotivo` (
  `idMotivo` smallint(5) unsigned NOT NULL AUTO_INCREMENT,
  `Motivo` varchar(50) CHARACTER SET latin1 NOT NULL,
  PRIMARY KEY (`idMotivo`),
  UNIQUE KEY `Motivo` (`Motivo`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- Volcando datos para la tabla controlstock.altaprodmotivo: ~1 rows (aproximadamente)
/*!40000 ALTER TABLE `altaprodmotivo` DISABLE KEYS */;
INSERT INTO `altaprodmotivo` (`idMotivo`, `Motivo`) VALUES
	(3, 'Producción Local');
/*!40000 ALTER TABLE `altaprodmotivo` ENABLE KEYS */;

-- Volcando estructura para tabla controlstock.bajaprod
CREATE TABLE IF NOT EXISTS `bajaprod` (
  `idBaja` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `idProductoFK` bigint(20) unsigned NOT NULL,
  `Fecha` datetime NOT NULL,
  `Cantidad` double unsigned NOT NULL,
  `Motivo` smallint(5) unsigned NOT NULL,
  PRIMARY KEY (`idBaja`),
  KEY `FK_bajaprod_producto` (`idProductoFK`),
  KEY `FK_bajaprod_motivobajaprod` (`Motivo`),
  CONSTRAINT `FK_bajaprod_motivobajaprod` FOREIGN KEY (`Motivo`) REFERENCES `bajaprodmotivo` (`idMotivo`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `FK_bajaprod_producto` FOREIGN KEY (`idProductoFK`) REFERENCES `producto` (`idProducto`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla controlstock.bajaprod: ~2 rows (aproximadamente)
/*!40000 ALTER TABLE `bajaprod` DISABLE KEYS */;
INSERT INTO `bajaprod` (`idBaja`, `idProductoFK`, `Fecha`, `Cantidad`, `Motivo`) VALUES
	(1, 3, '2018-01-11 08:49:26', 1.5, 1),
	(2, 2, '2018-04-01 08:46:19', 2, 2);
/*!40000 ALTER TABLE `bajaprod` ENABLE KEYS */;

-- Volcando estructura para tabla controlstock.bajaprodmotivo
CREATE TABLE IF NOT EXISTS `bajaprodmotivo` (
  `idMotivo` smallint(5) unsigned NOT NULL AUTO_INCREMENT,
  `Motivo` varchar(50) NOT NULL,
  PRIMARY KEY (`idMotivo`),
  UNIQUE KEY `Motivo` (`Motivo`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla controlstock.bajaprodmotivo: ~2 rows (aproximadamente)
/*!40000 ALTER TABLE `bajaprodmotivo` DISABLE KEYS */;
INSERT INTO `bajaprodmotivo` (`idMotivo`, `Motivo`) VALUES
	(1, 'Auto consumo'),
	(2, 'Vencido');
/*!40000 ALTER TABLE `bajaprodmotivo` ENABLE KEYS */;

-- Volcando estructura para tabla controlstock.categoria
CREATE TABLE IF NOT EXISTS `categoria` (
  `idCategoria` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(20) COLLATE utf8_spanish_ci NOT NULL,
  PRIMARY KEY (`idCategoria`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- Volcando datos para la tabla controlstock.categoria: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `categoria` DISABLE KEYS */;
/*!40000 ALTER TABLE `categoria` ENABLE KEYS */;

-- Volcando estructura para tabla controlstock.cliente
CREATE TABLE IF NOT EXISTS `cliente` (
  `CI` char(15) CHARACTER SET latin1 NOT NULL,
  `Nombre` varchar(30) CHARACTER SET latin1 NOT NULL,
  `Telefono` varchar(15) CHARACTER SET latin1 DEFAULT NULL,
  `Direccion` varchar(60) CHARACTER SET latin1 DEFAULT NULL,
  PRIMARY KEY (`CI`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- Volcando datos para la tabla controlstock.cliente: ~2 rows (aproximadamente)
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` (`CI`, `Nombre`, `Telefono`, `Direccion`) VALUES
	('1', 'Cliente Ocacional', '', ''),
	('4346326-6', 'Nestor Benitez', '0994234853', 'Yasyreta e/ Lionel Stanley y Humaita');
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;

-- Volcando estructura para tabla controlstock.comisionpagada
CREATE TABLE IF NOT EXISTS `comisionpagada` (
  `Fecha` date NOT NULL,
  `IdEmpleado` int(10) unsigned NOT NULL,
  `Periodo` char(25) NOT NULL,
  `Monto` int(10) NOT NULL,
  PRIMARY KEY (`Fecha`,`IdEmpleado`),
  KEY `FK_ComisionPagada_empleado` (`IdEmpleado`),
  CONSTRAINT `FK_ComisionPagada_empleado` FOREIGN KEY (`IdEmpleado`) REFERENCES `empleado` (`CI`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla controlstock.comisionpagada: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `comisionpagada` DISABLE KEYS */;
/*!40000 ALTER TABLE `comisionpagada` ENABLE KEYS */;

-- Volcando estructura para tabla controlstock.compra
CREATE TABLE IF NOT EXISTS `compra` (
  `idCompra` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `idProveedorFK` bigint(20) unsigned NOT NULL,
  `Fecha` datetime NOT NULL,
  `Cancelado` enum('Si','No') NOT NULL,
  `Entregado` int(10) unsigned DEFAULT NULL,
  `Vto` date DEFAULT NULL,
  PRIMARY KEY (`idCompra`),
  KEY `FK_compra_proveedor` (`idProveedorFK`),
  CONSTRAINT `FK_compra_proveedor` FOREIGN KEY (`idProveedorFK`) REFERENCES `proveedor` (`RUC`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla controlstock.compra: ~2 rows (aproximadamente)
/*!40000 ALTER TABLE `compra` DISABLE KEYS */;
INSERT INTO `compra` (`idCompra`, `idProveedorFK`, `Fecha`, `Cancelado`, `Entregado`, `Vto`) VALUES
	(1, 1, '2018-01-10 23:57:37', 'Si', 0, '2018-01-10'),
	(2, 1, '2018-03-31 18:30:31', 'Si', 0, '2018-03-31');
/*!40000 ALTER TABLE `compra` ENABLE KEYS */;

-- Volcando estructura para tabla controlstock.detallecompra
CREATE TABLE IF NOT EXISTS `detallecompra` (
  `idCompraFK` int(10) unsigned NOT NULL,
  `idProductoFK` bigint(20) unsigned NOT NULL,
  `Cantidad` double unsigned NOT NULL,
  `Unidades` int(10) unsigned NOT NULL DEFAULT '1',
  `Precio` int(10) unsigned NOT NULL,
  `Obs` enum('','(Paquete)') NOT NULL,
  PRIMARY KEY (`idCompraFK`,`idProductoFK`),
  KEY `FK_detallecompra_venta` (`idProductoFK`),
  CONSTRAINT `FK_detallecompra_compra` FOREIGN KEY (`idCompraFK`) REFERENCES `compra` (`idCompra`),
  CONSTRAINT `FK_detallecompra_producto` FOREIGN KEY (`idProductoFK`) REFERENCES `producto` (`idProducto`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla controlstock.detallecompra: ~3 rows (aproximadamente)
/*!40000 ALTER TABLE `detallecompra` DISABLE KEYS */;
INSERT INTO `detallecompra` (`idCompraFK`, `idProductoFK`, `Cantidad`, `Unidades`, `Precio`, `Obs`) VALUES
	(1, 1, 13, 1, 1000, ''),
	(1, 2, 13, 1, 1000, ''),
	(2, 3, 10, 1, 1000, '');
/*!40000 ALTER TABLE `detallecompra` ENABLE KEYS */;

-- Volcando estructura para tabla controlstock.detalleocupacion
CREATE TABLE IF NOT EXISTS `detalleocupacion` (
  `idVentaFK` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `idHabFK` tinyint(3) unsigned NOT NULL,
  `idServHabFk` tinyint(3) unsigned NOT NULL,
  `Tiempo` smallint(5) unsigned NOT NULL,
  `Precio` int(10) unsigned NOT NULL,
  `SubTotal` int(10) unsigned NOT NULL,
  PRIMARY KEY (`idVentaFK`,`idHabFK`,`idServHabFk`),
  KEY `FK_detalleocupacion_habitacion` (`idHabFK`),
  KEY `FK_detalleocupacion_habitacion_2` (`idServHabFk`),
  CONSTRAINT `FK_detalleocupacion_habitacion` FOREIGN KEY (`idHabFK`) REFERENCES `habitacion2` (`NroHabitacion`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `FK_detalleocupacion_habitacion_2` FOREIGN KEY (`idServHabFk`) REFERENCES `serviciohabitacion` (`idServHab`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `FK_detalleocupacion_venta` FOREIGN KEY (`idVentaFK`) REFERENCES `venta` (`idVenta`)
) ENGINE=InnoDB AUTO_INCREMENT=66 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- Volcando datos para la tabla controlstock.detalleocupacion: ~69 rows (aproximadamente)
/*!40000 ALTER TABLE `detalleocupacion` DISABLE KEYS */;
INSERT INTO `detalleocupacion` (`idVentaFK`, `idHabFK`, `idServHabFk`, `Tiempo`, `Precio`, `SubTotal`) VALUES
	(15, 1, 1, 13, 12, 123),
	(16, 4, 3, 1, 150000, 150000),
	(17, 1, 1, 1, 30000, 30000),
	(18, 7, 1, 2, 30000, 30000),
	(18, 7, 2, 28, 15000, 210000),
	(19, 6, 1, 2, 30000, 30000),
	(19, 6, 2, 31, 15000, 240000),
	(20, 2, 1, 2, 30000, 30000),
	(20, 2, 2, 31, 15000, 240000),
	(21, 8, 1, 60, 30000, 30000),
	(21, 8, 2, 623, 15000, 315000),
	(22, 5, 1, 60, 30000, 30000),
	(22, 5, 2, 623, 15000, 315000),
	(23, 9, 1, 60, 50000, 50000),
	(23, 9, 2, 623, 25000, 525000),
	(24, 7, 3, 1, 150000, 150000),
	(25, 3, 1, 60, 30000, 30000),
	(25, 3, 2, 15, 15000, 15000),
	(26, 2, 1, 60, 30000, 30000),
	(26, 2, 2, 15, 15000, 15000),
	(27, 4, 1, 60, 30000, 30000),
	(27, 4, 2, 16, 15000, 15000),
	(28, 5, 1, 60, 30000, 30000),
	(28, 5, 2, 16, 15000, 15000),
	(29, 6, 1, 60, 30000, 30000),
	(29, 6, 2, 20, 15000, 15000),
	(30, 7, 1, 60, 30000, 30000),
	(30, 7, 2, 16, 15000, 15000),
	(31, 8, 1, 60, 30000, 30000),
	(31, 8, 2, 16, 15000, 15000),
	(32, 9, 1, 60, 50000, 50000),
	(32, 9, 2, 30, 25000, 25000),
	(33, 10, 1, 60, 50000, 50000),
	(33, 10, 2, 16, 25000, 25000),
	(34, 9, 1, 5, 50000, 50000),
	(35, 4, 1, 15, 30000, 30000),
	(36, 3, 1, 60, 30000, 30000),
	(36, 3, 2, 98, 15000, 60000),
	(37, 5, 1, 60, 30000, 30000),
	(37, 5, 2, 105, 15000, 60000),
	(38, 7, 1, 60, 30000, 30000),
	(38, 7, 2, 105, 15000, 60000),
	(39, 9, 1, 60, 50000, 50000),
	(39, 9, 2, 106, 25000, 100000),
	(40, 1, 1, 15, 30000, 30000),
	(41, 1, 1, 60, 30000, 30000),
	(41, 1, 2, 1110, 15000, 555000),
	(42, 2, 1, 6, 30000, 30000),
	(43, 10, 1, 30, 50000, 50000),
	(44, 5, 1, 30, 30000, 30000),
	(45, 9, 1, 30, 50000, 50000),
	(46, 1, 1, 34, 30000, 30000),
	(48, 6, 1, 60, 30000, 30000),
	(48, 6, 2, 499, 15000, 255000),
	(49, 8, 1, 60, 30000, 30000),
	(49, 8, 2, 499, 15000, 255000),
	(50, 6, 1, 3, 30000, 30000),
	(51, 6, 1, 1, 30000, 30000),
	(52, 1, 1, 1, 30000, 30000),
	(56, 1, 1, 39, 30000, 30000),
	(57, 5, 1, 50, 30000, 30000),
	(58, 4, 1, 12, 30000, 30000),
	(59, 2, 1, 30, 30000, 30000),
	(60, 10, 1, 11, 50000, 50000),
	(61, 1, 1, 1, 30000, 30000),
	(62, 1, 1, 2, 30000, 30000),
	(63, 10, 1, 2, 50000, 50000),
	(64, 8, 1, 6, 30000, 30000),
	(65, 1, 1, 9, 30000, 30000);
/*!40000 ALTER TABLE `detalleocupacion` ENABLE KEYS */;

-- Volcando estructura para tabla controlstock.detalleventa
CREATE TABLE IF NOT EXISTS `detalleventa` (
  `idVentaFK` int(10) unsigned NOT NULL,
  `idProductoFK` bigint(20) unsigned NOT NULL,
  `Cantidad` double unsigned NOT NULL,
  `Unidades` int(10) unsigned NOT NULL DEFAULT '1',
  `Precio` int(10) unsigned DEFAULT NULL,
  `Obs` enum('','(Paquete)') NOT NULL,
  `Descuento` tinyint(10) unsigned DEFAULT NULL,
  PRIMARY KEY (`idVentaFK`,`idProductoFK`),
  KEY `FK_detalleventa_producto` (`idProductoFK`),
  CONSTRAINT `FK_detalleventa_producto` FOREIGN KEY (`idProductoFK`) REFERENCES `producto` (`idProducto`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `FK_detalleventa_venta` FOREIGN KEY (`idVentaFK`) REFERENCES `venta` (`idVenta`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla controlstock.detalleventa: ~24 rows (aproximadamente)
/*!40000 ALTER TABLE `detalleventa` DISABLE KEYS */;
INSERT INTO `detalleventa` (`idVentaFK`, `idProductoFK`, `Cantidad`, `Unidades`, `Precio`, `Obs`, `Descuento`) VALUES
	(1, 1, 3, 1, 1100, '', 0),
	(1, 2, 1, 1, 1100, '', 0),
	(2, 1, 1, 1, 1100, '', 0),
	(3, 2, 1, 1, 1100, '', 0),
	(4, 3, 7.5, 1, 1500, '', 0),
	(5, 1, 1, 1, 1100, '', 0),
	(5, 4, 1, 10, 12000, '(Paquete)', 0),
	(6, 4, 1, 1, 1300, '', 0),
	(8, 6, 1, 1, 1, '', 0),
	(10, 1, 1, 1, 1100, '', 0),
	(11, 2, 1, 1, 1100, '', 0),
	(12, 3, 1, 1, 1500, '', 0),
	(13, 3, 1, 1, 1500, '', 0),
	(14, 2, 1, 1, 1100, '', 0),
	(15, 1, 1, 1, 1100, '', 0),
	(16, 2, 3, 1, 1100, '', 0),
	(17, 2, 1, 1, 1100, '', 0),
	(47, 1, 10, 1, 1100, '', 0),
	(53, 1, 3, 1, 1100, '', 0),
	(54, 2, 1, 1, 1100, '', 0),
	(54, 3, 2, 1, 1500, '', 0),
	(55, 1, 2, 1, 1100, '', 0),
	(66, 1, 5, 1, 1100, '', 0),
	(66, 4, 5, 1, 1300, '', 0);
/*!40000 ALTER TABLE `detalleventa` ENABLE KEYS */;

-- Volcando estructura para tabla controlstock.detnotaccompra
CREATE TABLE IF NOT EXISTS `detnotaccompra` (
  `idNotaFK` int(10) unsigned NOT NULL,
  `idCompraFK` int(10) unsigned NOT NULL,
  `idProductoFK` bigint(20) unsigned NOT NULL,
  `Cantidad` double unsigned NOT NULL,
  `Unidades` int(10) unsigned NOT NULL,
  PRIMARY KEY (`idNotaFK`,`idCompraFK`,`idProductoFK`),
  KEY `FK_detnotaccompra_detallecompra` (`idCompraFK`,`idProductoFK`),
  CONSTRAINT `FK_detnotaccompra_detallecompra` FOREIGN KEY (`idCompraFK`, `idProductoFK`) REFERENCES `detallecompra` (`idCompraFK`, `idProductoFK`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `FK_detnotaccompra_notaccompra` FOREIGN KEY (`idNotaFK`) REFERENCES `notaccompra` (`idNota`),
  CONSTRAINT `FK_detnotaccompra_notaccompra_2` FOREIGN KEY (`idCompraFK`) REFERENCES `notaccompra` (`idCompraFK`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla controlstock.detnotaccompra: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `detnotaccompra` DISABLE KEYS */;
/*!40000 ALTER TABLE `detnotaccompra` ENABLE KEYS */;

-- Volcando estructura para tabla controlstock.detnotacventa
CREATE TABLE IF NOT EXISTS `detnotacventa` (
  `idNotaFK` int(10) unsigned NOT NULL,
  `idVentaFK` int(10) unsigned NOT NULL,
  `idProductoFK` bigint(20) unsigned NOT NULL,
  `Cantidad` double unsigned NOT NULL,
  `Unidades` int(10) DEFAULT NULL,
  PRIMARY KEY (`idNotaFK`,`idVentaFK`,`idProductoFK`),
  KEY `FK_detnotacventa_detalleventa` (`idVentaFK`,`idProductoFK`),
  CONSTRAINT `FK_detnotacventa_detalleventa` FOREIGN KEY (`idVentaFK`, `idProductoFK`) REFERENCES `detalleventa` (`idVentaFK`, `idProductoFK`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `FK_detnotacventa_notacventa` FOREIGN KEY (`idNotaFK`) REFERENCES `notacventa` (`idNota`),
  CONSTRAINT `FK_detnotacventa_notacventa_2` FOREIGN KEY (`idVentaFK`) REFERENCES `notacventa` (`idVentaFK`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla controlstock.detnotacventa: ~2 rows (aproximadamente)
/*!40000 ALTER TABLE `detnotacventa` DISABLE KEYS */;
INSERT INTO `detnotacventa` (`idNotaFK`, `idVentaFK`, `idProductoFK`, `Cantidad`, `Unidades`) VALUES
	(1, 5, 1, 1, 1),
	(2, 16, 2, 1, 1);
/*!40000 ALTER TABLE `detnotacventa` ENABLE KEYS */;

-- Volcando estructura para tabla controlstock.empleado
CREATE TABLE IF NOT EXISTS `empleado` (
  `CI` int(10) unsigned NOT NULL,
  `Nombre` char(20) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `Apellido` char(20) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `Telefono` char(15) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `Direccion` char(30) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `Comision` tinyint(3) unsigned DEFAULT NULL,
  `Estado` enum('Activo','Inactivo') CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL DEFAULT 'Activo',
  PRIMARY KEY (`CI`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- Volcando datos para la tabla controlstock.empleado: ~3 rows (aproximadamente)
/*!40000 ALTER TABLE `empleado` DISABLE KEYS */;
INSERT INTO `empleado` (`CI`, `Nombre`, `Apellido`, `Telefono`, `Direccion`, `Comision`, `Estado`) VALUES
	(112233, 'David', 'Benitez', '', '', 0, 'Activo'),
	(4346322, 'Toribio', 'Mendoza', '0994234852', '', 0, 'Activo'),
	(4346326, 'Nestor', 'Benitez', '0994234853', '', 3, 'Activo');
/*!40000 ALTER TABLE `empleado` ENABLE KEYS */;

-- Volcando estructura para tabla controlstock.gasto
CREATE TABLE IF NOT EXISTS `gasto` (
  `idGasto` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Descripcion` int(10) unsigned NOT NULL,
  `Fecha` datetime NOT NULL,
  `Importe` int(10) unsigned NOT NULL,
  PRIMARY KEY (`idGasto`),
  KEY `FK_gastos_listagastos` (`Descripcion`),
  CONSTRAINT `FK_gastos_listagastos` FOREIGN KEY (`Descripcion`) REFERENCES `listagasto` (`IdGasto`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla controlstock.gasto: ~4 rows (aproximadamente)
/*!40000 ALTER TABLE `gasto` DISABLE KEYS */;
INSERT INTO `gasto` (`idGasto`, `Descripcion`, `Fecha`, `Importe`) VALUES
	(1, 1, '2018-01-11 00:04:14', 300000),
	(2, 1, '2018-01-30 17:28:14', 200000),
	(3, 1, '2018-03-31 15:56:11', 200000),
	(4, 2, '2018-04-01 09:39:48', 1000000);
/*!40000 ALTER TABLE `gasto` ENABLE KEYS */;

-- Volcando estructura para tabla controlstock.habitacion
CREATE TABLE IF NOT EXISTS `habitacion` (
  `idHabitacion` tinyint(3) unsigned NOT NULL AUTO_INCREMENT,
  `idServHabFK` tinyint(3) unsigned NOT NULL,
  `Descripcion` char(35) COLLATE utf8_spanish_ci NOT NULL,
  `Precio` mediumint(8) unsigned NOT NULL,
  PRIMARY KEY (`idHabitacion`,`idServHabFK`),
  KEY `FK_habitacion_serviciohabitacion` (`idServHabFK`),
  CONSTRAINT `FK_habitacion_serviciohabitacion` FOREIGN KEY (`idServHabFK`) REFERENCES `serviciohabitacion` (`idServHab`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- Volcando datos para la tabla controlstock.habitacion: ~6 rows (aproximadamente)
/*!40000 ALTER TABLE `habitacion` DISABLE KEYS */;
INSERT INTO `habitacion` (`idHabitacion`, `idServHabFK`, `Descripcion`, `Precio`) VALUES
	(1, 1, 'Habitacion1 x 1 hora', 30000),
	(1, 2, 'Habitacion1 adicional + 30min', 15000),
	(1, 3, 'Habitacion1 x Noche', 150000),
	(2, 1, 'Habitacion2 x 1 hora', 30000),
	(2, 2, 'Habitacion2 adicional + 30min', 15000),
	(2, 3, 'Habitacion2 x Noche', 150000);
/*!40000 ALTER TABLE `habitacion` ENABLE KEYS */;

-- Volcando estructura para tabla controlstock.habitacion2
CREATE TABLE IF NOT EXISTS `habitacion2` (
  `NroHabitacion` tinyint(3) unsigned NOT NULL AUTO_INCREMENT,
  `Precio1` mediumint(8) unsigned NOT NULL,
  `Precio2` mediumint(8) unsigned NOT NULL,
  `Precio3` mediumint(8) unsigned NOT NULL,
  PRIMARY KEY (`NroHabitacion`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- Volcando datos para la tabla controlstock.habitacion2: ~10 rows (aproximadamente)
/*!40000 ALTER TABLE `habitacion2` DISABLE KEYS */;
INSERT INTO `habitacion2` (`NroHabitacion`, `Precio1`, `Precio2`, `Precio3`) VALUES
	(1, 30000, 15000, 150000),
	(2, 30000, 15000, 150000),
	(3, 30000, 15000, 150000),
	(4, 30000, 15000, 150000),
	(5, 30000, 15000, 150000),
	(6, 30000, 15000, 150000),
	(7, 30000, 15000, 150000),
	(8, 30000, 15000, 150000),
	(9, 50000, 25000, 200000),
	(10, 50000, 25000, 200000);
/*!40000 ALTER TABLE `habitacion2` ENABLE KEYS */;

-- Volcando estructura para tabla controlstock.habitacionajustes
CREATE TABLE IF NOT EXISTS `habitacionajustes` (
  `IdAjuste` tinyint(3) unsigned NOT NULL AUTO_INCREMENT,
  `MargerEntrada` smallint(5) unsigned NOT NULL,
  `MargenSalida` smallint(5) unsigned NOT NULL,
  `Tolerancia` smallint(5) unsigned NOT NULL,
  PRIMARY KEY (`IdAjuste`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- Volcando datos para la tabla controlstock.habitacionajustes: ~1 rows (aproximadamente)
/*!40000 ALTER TABLE `habitacionajustes` DISABLE KEYS */;
INSERT INTO `habitacionajustes` (`IdAjuste`, `MargerEntrada`, `MargenSalida`, `Tolerancia`) VALUES
	(1, 5, 5, 5);
/*!40000 ALTER TABLE `habitacionajustes` ENABLE KEYS */;

-- Volcando estructura para tabla controlstock.listagasto
CREATE TABLE IF NOT EXISTS `listagasto` (
  `IdGasto` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(30) NOT NULL DEFAULT ' ',
  PRIMARY KEY (`IdGasto`),
  UNIQUE KEY `Descripcion` (`Descripcion`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla controlstock.listagasto: ~2 rows (aproximadamente)
/*!40000 ALTER TABLE `listagasto` DISABLE KEYS */;
INSERT INTO `listagasto` (`IdGasto`, `Descripcion`) VALUES
	(2, 'Alquiler'),
	(1, 'Luz');
/*!40000 ALTER TABLE `listagasto` ENABLE KEYS */;

-- Volcando estructura para tabla controlstock.marca
CREATE TABLE IF NOT EXISTS `marca` (
  `idMarca` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(20) COLLATE utf8_spanish_ci NOT NULL,
  PRIMARY KEY (`idMarca`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- Volcando datos para la tabla controlstock.marca: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `marca` DISABLE KEYS */;
/*!40000 ALTER TABLE `marca` ENABLE KEYS */;

-- Volcando estructura para tabla controlstock.modelo
CREATE TABLE IF NOT EXISTS `modelo` (
  `idModelo` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(20) COLLATE utf8_spanish_ci NOT NULL,
  `MarcaFK` int(10) unsigned NOT NULL,
  PRIMARY KEY (`idModelo`),
  KEY `modeloFK_marca` (`MarcaFK`),
  CONSTRAINT `modeloFK_marca` FOREIGN KEY (`MarcaFK`) REFERENCES `marca` (`idMarca`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- Volcando datos para la tabla controlstock.modelo: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `modelo` DISABLE KEYS */;
/*!40000 ALTER TABLE `modelo` ENABLE KEYS */;

-- Volcando estructura para tabla controlstock.notaccompra
CREATE TABLE IF NOT EXISTS `notaccompra` (
  `idNota` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `idCompraFK` int(10) unsigned NOT NULL,
  `Fecha` datetime NOT NULL,
  PRIMARY KEY (`idNota`),
  KEY `FK_NotaCredCompra_compra` (`idCompraFK`),
  CONSTRAINT `FK_NotaCredCompra_compra` FOREIGN KEY (`idCompraFK`) REFERENCES `compra` (`idCompra`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla controlstock.notaccompra: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `notaccompra` DISABLE KEYS */;
/*!40000 ALTER TABLE `notaccompra` ENABLE KEYS */;

-- Volcando estructura para tabla controlstock.notacventa
CREATE TABLE IF NOT EXISTS `notacventa` (
  `idNota` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `idVentaFK` int(10) unsigned NOT NULL,
  `Fecha` datetime NOT NULL,
  PRIMARY KEY (`idNota`),
  KEY `FK_notacventa_venta` (`idVentaFK`),
  CONSTRAINT `FK_notacventa_venta` FOREIGN KEY (`idVentaFK`) REFERENCES `venta` (`idVenta`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla controlstock.notacventa: ~2 rows (aproximadamente)
/*!40000 ALTER TABLE `notacventa` DISABLE KEYS */;
INSERT INTO `notacventa` (`idNota`, `idVentaFK`, `Fecha`) VALUES
	(1, 5, '2018-01-31 15:53:30'),
	(2, 16, '2018-01-31 17:07:50');
/*!40000 ALTER TABLE `notacventa` ENABLE KEYS */;

-- Volcando estructura para tabla controlstock.ocupacionmanual
CREATE TABLE IF NOT EXISTS `ocupacionmanual` (
  `idOcupacion` int(20) unsigned NOT NULL AUTO_INCREMENT,
  `NroHab` tinyint(3) unsigned NOT NULL,
  `HraEntrada` datetime NOT NULL,
  `HraSalida` datetime DEFAULT NULL,
  `idVentaFK` int(20) unsigned DEFAULT NULL,
  PRIMARY KEY (`idOcupacion`),
  KEY `FK_ocupacionmanual_habitacion2` (`NroHab`),
  KEY `FK_ocupacionmanual_venta` (`idVentaFK`),
  CONSTRAINT `FK_ocupacionmanual_habitacion2` FOREIGN KEY (`NroHab`) REFERENCES `habitacion2` (`NroHabitacion`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `FK_ocupacionmanual_venta` FOREIGN KEY (`idVentaFK`) REFERENCES `venta` (`idVenta`)
) ENGINE=InnoDB AUTO_INCREMENT=103 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- Volcando datos para la tabla controlstock.ocupacionmanual: ~56 rows (aproximadamente)
/*!40000 ALTER TABLE `ocupacionmanual` DISABLE KEYS */;
INSERT INTO `ocupacionmanual` (`idOcupacion`, `NroHab`, `HraEntrada`, `HraSalida`, `idVentaFK`) VALUES
	(1, 1, '2018-01-20 08:02:00', '2018-01-20 09:07:29', 10),
	(3, 3, '2018-01-20 19:56:52', '2018-01-20 20:52:00', 9),
	(4, 7, '2018-01-20 19:56:52', '2018-01-20 20:52:00', 9),
	(5, 10, '2018-01-20 19:56:52', '2018-01-20 20:52:00', 9),
	(6, 1, '2018-01-20 21:12:24', '2018-01-20 23:13:36', 10),
	(7, 1, '2018-01-20 23:41:30', '2018-01-21 00:42:23', 12),
	(8, 2, '2018-01-20 23:45:03', '2018-01-21 00:45:59', 15),
	(9, 6, '2018-01-20 23:45:05', '2018-01-21 00:45:39', 13),
	(10, 7, '2018-01-20 23:45:07', '2018-01-21 00:45:50', 14),
	(29, 1, '2018-01-21 21:37:24', '2018-01-21 21:39:03', 17),
	(30, 2, '2018-01-21 21:40:38', '2018-01-21 22:14:45', 20),
	(31, 6, '2018-01-21 21:40:39', '2018-01-21 22:14:41', 19),
	(32, 7, '2018-01-21 21:40:41', '2018-01-21 22:11:04', 18),
	(34, 5, '2018-01-21 23:53:17', '2018-01-22 11:18:59', 22),
	(35, 9, '2018-01-21 23:53:19', '2018-01-22 11:19:04', 23),
	(36, 7, '2018-01-21 23:53:22', '2018-01-22 11:19:08', 24),
	(37, 8, '2018-01-21 23:53:32', '2018-01-22 11:18:53', 21),
	(52, 9, '2018-01-25 22:43:28', '2018-01-26 00:14:01', 32),
	(53, 6, '2018-01-25 22:53:41', '2018-01-26 00:13:51', 29),
	(54, 10, '2018-01-25 22:57:22', '2018-01-26 00:14:05', 33),
	(55, 8, '2018-01-25 22:57:25', '2018-01-26 00:13:58', 31),
	(56, 7, '2018-01-25 22:57:27', '2018-01-26 00:13:54', 30),
	(57, 4, '2018-01-25 22:57:30', '2018-01-26 00:13:43', 27),
	(58, 5, '2018-01-25 22:57:33', '2018-01-26 00:13:47', 28),
	(59, 2, '2018-01-25 22:57:35', '2018-01-26 00:13:37', 26),
	(60, 3, '2018-01-25 22:57:38', '2018-01-26 00:13:17', 25),
	(65, 9, '2018-01-30 17:30:42', '2018-01-30 17:35:48', 34),
	(66, 1, '2018-01-31 17:29:26', '2018-03-01 17:44:28', 40),
	(67, 5, '2018-01-31 17:29:27', '2018-01-31 20:15:23', 37),
	(68, 9, '2018-01-31 17:29:28', '2018-01-31 20:16:01', 39),
	(69, 7, '2018-01-31 17:30:20', '2018-01-31 20:15:28', 38),
	(70, 3, '2018-01-31 17:37:01', '2018-01-31 20:15:15', 36),
	(71, 4, '2018-01-31 19:59:50', '2018-01-31 20:15:10', 35),
	(72, 1, '2018-02-28 23:55:27', '2018-03-01 19:27:54', 41),
	(78, 2, '2018-03-01 19:48:44', '2018-03-01 19:55:34', 42),
	(80, 4, '2018-03-01 19:59:24', '2018-03-01 19:59:49', NULL),
	(81, 1, '2018-03-01 20:03:48', '2018-03-01 20:38:47', 46),
	(82, 5, '2018-03-01 20:03:49', '2018-03-01 20:35:36', 44),
	(83, 9, '2018-03-01 20:03:51', '2018-03-01 20:35:41', 45),
	(84, 10, '2018-03-01 20:03:53', '2018-03-01 20:35:32', 43),
	(86, 8, '2018-03-04 00:46:55', '2018-03-04 10:06:43', 49),
	(87, 6, '2018-03-04 00:46:56', '2018-03-04 10:06:34', 48),
	(89, 6, '2018-03-04 10:06:52', '2018-03-04 10:10:44', 50),
	(90, 1, '2018-03-05 12:04:19', '2018-03-05 12:05:54', 52),
	(91, 6, '2018-03-05 12:04:21', '2018-03-05 12:05:43', 51),
	(92, 1, '2018-04-01 11:32:26', '2018-04-01 12:11:50', 56),
	(93, 5, '2018-04-01 11:34:37', '2018-04-01 12:24:51', 57),
	(94, 4, '2018-04-01 13:08:03', '2018-04-01 13:20:05', 58),
	(95, 10, '2018-04-01 13:24:22', '2018-04-01 13:48:31', 60),
	(96, 2, '2018-04-01 13:01:50', '2018-04-01 13:32:32', 59),
	(97, 1, '2018-04-03 02:41:10', '2018-04-03 02:42:53', 61),
	(98, 1, '2018-04-03 02:50:03', '2018-04-03 02:52:12', 62),
	(99, 1, '2018-04-03 02:53:44', '2018-04-03 03:03:02', 65),
	(100, 5, '2018-04-03 02:53:51', '2018-04-03 02:55:35', NULL),
	(101, 8, '2018-04-03 02:55:52', '2018-04-03 03:02:50', 64),
	(102, 10, '2018-04-03 02:59:49', '2018-04-03 03:02:34', 63);
/*!40000 ALTER TABLE `ocupacionmanual` ENABLE KEYS */;

-- Volcando estructura para tabla controlstock.ocupacionsensor
CREATE TABLE IF NOT EXISTS `ocupacionsensor` (
  `idOcupacion` int(20) unsigned NOT NULL AUTO_INCREMENT,
  `NroHabitacion` tinyint(3) unsigned NOT NULL,
  `HraEntrada` datetime NOT NULL,
  `HraSalida` datetime DEFAULT NULL,
  PRIMARY KEY (`idOcupacion`),
  KEY `FK_ocupacionsensor_habitacion2` (`NroHabitacion`),
  CONSTRAINT `FK_ocupacionsensor_habitacion2` FOREIGN KEY (`NroHabitacion`) REFERENCES `habitacion2` (`NroHabitacion`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=125 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- Volcando datos para la tabla controlstock.ocupacionsensor: ~36 rows (aproximadamente)
/*!40000 ALTER TABLE `ocupacionsensor` DISABLE KEYS */;
INSERT INTO `ocupacionsensor` (`idOcupacion`, `NroHabitacion`, `HraEntrada`, `HraSalida`) VALUES
	(1, 1, '2018-01-20 07:59:00', '2018-01-20 09:11:29'),
	(3, 3, '2018-01-20 19:52:52', '2018-01-20 20:53:00'),
	(4, 7, '2018-01-20 19:52:52', '2018-01-20 20:57:00'),
	(5, 10, '2018-01-20 19:49:52', '2018-01-20 20:57:00'),
	(6, 1, '2018-01-20 21:07:24', '2018-01-20 23:18:36'),
	(7, 1, '2018-01-20 23:34:30', '2018-01-21 00:44:23'),
	(8, 2, '2018-01-20 23:43:03', '2018-01-21 00:46:59'),
	(9, 6, '2018-01-20 23:38:05', '2018-01-21 00:49:39'),
	(10, 7, '2018-01-20 23:40:07', '2018-01-21 00:47:50'),
	(29, 1, '2018-01-21 21:29:24', '2018-01-21 21:44:03'),
	(30, 2, '2018-01-21 21:38:38', '2018-01-21 22:18:45'),
	(31, 6, '2018-01-21 21:38:39', '2018-01-21 22:17:41'),
	(32, 7, '2018-01-21 21:39:41', '2018-01-21 22:14:04'),
	(34, 5, '2018-01-21 23:50:17', '2018-01-22 11:23:59'),
	(35, 9, '2018-01-21 23:50:19', '2018-01-22 11:21:04'),
	(36, 7, '2018-01-21 23:52:22', '2018-01-22 11:21:08'),
	(37, 8, '2018-01-21 23:50:32', '2018-01-22 11:20:53'),
	(48, 3, '2018-01-24 20:18:57', '2018-01-24 21:26:12'),
	(49, 5, '2018-01-20 21:14:56', '2018-01-20 21:17:59'),
	(50, 5, '2018-01-25 21:58:16', NULL),
	(78, 2, '2018-01-26 23:11:09', '2018-01-26 23:11:27'),
	(80, 2, '2018-01-27 00:04:41', '2018-01-27 00:04:48'),
	(81, 2, '2018-01-27 13:04:19', '2018-01-27 13:04:26'),
	(82, 1, '2018-04-01 11:31:33', '2018-04-01 12:12:38'),
	(83, 5, '2018-04-01 11:33:37', '2018-04-01 12:26:55'),
	(84, 9, '2018-04-01 11:35:05', '2018-04-01 12:31:21'),
	(85, 8, '2018-04-01 12:48:00', '2018-04-01 13:22:47'),
	(86, 4, '2018-04-01 13:07:20', '2018-04-01 13:21:24'),
	(87, 2, '2018-04-01 12:59:48', '2018-04-01 13:33:39'),
	(88, 1, '2018-04-03 00:07:57', '2018-04-03 00:18:46'),
	(90, 2, '2018-04-03 00:41:49', '2018-04-03 00:42:03'),
	(120, 1, '2018-04-03 02:39:24', '2018-04-03 02:40:42'),
	(121, 1, '2018-04-03 02:48:51', '2018-04-03 02:49:18'),
	(122, 1, '2018-04-03 02:49:47', '2018-04-03 02:52:41'),
	(123, 1, '2018-04-03 02:53:38', '2018-04-03 02:53:43'),
	(124, 1, '2018-04-03 02:55:17', '2018-04-03 03:01:42');
/*!40000 ALTER TABLE `ocupacionsensor` ENABLE KEYS */;

-- Volcando estructura para tabla controlstock.pedidoc
CREATE TABLE IF NOT EXISTS `pedidoc` (
  `idPedido` int(20) unsigned NOT NULL AUTO_INCREMENT,
  `idProveedor` bigint(10) unsigned NOT NULL,
  `Fecha` date NOT NULL,
  `FechaRecibo` date NOT NULL,
  `Estado` enum('Abierto','Cerrado') NOT NULL,
  PRIMARY KEY (`idPedido`),
  KEY `FK_pedidoc_proveedor` (`idProveedor`),
  CONSTRAINT `FK_pedidoc_proveedor` FOREIGN KEY (`idProveedor`) REFERENCES `proveedor` (`RUC`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla controlstock.pedidoc: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `pedidoc` DISABLE KEYS */;
/*!40000 ALTER TABLE `pedidoc` ENABLE KEYS */;

-- Volcando estructura para tabla controlstock.privilegio
CREATE TABLE IF NOT EXISTS `privilegio` (
  `idPrivilegio` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Rol` varchar(20) COLLATE utf8_spanish_ci NOT NULL,
  `ProdConsult` bit(1) NOT NULL,
  `ProdReg` bit(1) NOT NULL,
  `ProdActualiz` bit(1) NOT NULL,
  `ProdEliminar` bit(1) NOT NULL,
  `VentasConsult` bit(1) NOT NULL,
  `VentasReg` bit(1) NOT NULL,
  `ComprasConsult` bit(1) NOT NULL,
  `ComprasReg` bit(1) NOT NULL,
  `ProvConsult` bit(1) NOT NULL,
  `ProvReg` bit(1) NOT NULL,
  `ProvActualiz` bit(1) NOT NULL,
  `ProvEliminar` bit(1) NOT NULL,
  `EmpleAdmin` bit(1) NOT NULL,
  `UsuAdmin` bit(1) NOT NULL,
  `FinanzasAdmin` bit(1) NOT NULL,
  `HabAdmin` bit(1) NOT NULL,
  `CuentasAdmin` bit(1) NOT NULL,
  `DevolAutoriCli` bit(1) NOT NULL,
  `DevolAutoriProv` bit(1) NOT NULL,
  PRIMARY KEY (`idPrivilegio`),
  UNIQUE KEY `Nombre` (`Rol`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- Volcando datos para la tabla controlstock.privilegio: ~2 rows (aproximadamente)
/*!40000 ALTER TABLE `privilegio` DISABLE KEYS */;
INSERT INTO `privilegio` (`idPrivilegio`, `Rol`, `ProdConsult`, `ProdReg`, `ProdActualiz`, `ProdEliminar`, `VentasConsult`, `VentasReg`, `ComprasConsult`, `ComprasReg`, `ProvConsult`, `ProvReg`, `ProvActualiz`, `ProvEliminar`, `EmpleAdmin`, `UsuAdmin`, `FinanzasAdmin`, `HabAdmin`, `CuentasAdmin`, `DevolAutoriCli`, `DevolAutoriProv`) VALUES
	(1, 'Admin', b'1', b'1', b'1', b'1', b'1', b'1', b'1', b'1', b'1', b'1', b'1', b'1', b'1', b'1', b'1', b'1', b'1', b'1', b'1'),
	(2, 'Vendedor', b'1', b'0', b'0', b'0', b'1', b'1', b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'1', b'1');
/*!40000 ALTER TABLE `privilegio` ENABLE KEYS */;

-- Volcando estructura para tabla controlstock.producto
CREATE TABLE IF NOT EXISTS `producto` (
  `idProducto` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `idProveedorFK` bigint(20) unsigned NOT NULL DEFAULT '0',
  `Descripcion` char(35) CHARACTER SET latin1 NOT NULL,
  `Costo` int(10) unsigned NOT NULL,
  `Precio1` int(10) unsigned NOT NULL,
  `Precio2` int(10) unsigned NOT NULL,
  `Precio3` int(10) unsigned NOT NULL,
  `PrecioPack` int(10) unsigned DEFAULT NULL,
  `Stock` double NOT NULL,
  `UnidXpack` int(10) unsigned DEFAULT NULL,
  `PorPack` enum('Si','No','Kilo','Tiempo') CHARACTER SET latin1 DEFAULT NULL,
  `Foto` longblob,
  `Iva` tinyint(3) unsigned DEFAULT NULL,
  PRIMARY KEY (`idProducto`),
  KEY `FK_producto_proveedor` (`idProveedorFK`),
  CONSTRAINT `FK_producto_proveedor` FOREIGN KEY (`idProveedorFK`) REFERENCES `proveedor` (`RUC`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- Volcando datos para la tabla controlstock.producto: ~5 rows (aproximadamente)
/*!40000 ALTER TABLE `producto` DISABLE KEYS */;
INSERT INTO `producto` (`idProducto`, `idProveedorFK`, `Descripcion`, `Costo`, `Precio1`, `Precio2`, `Precio3`, `PrecioPack`, `Stock`, `UnidXpack`, `PorPack`, `Foto`, `Iva`) VALUES
	(1, 1, 'Mi Producto', 1000, 1100, 1200, 1300, NULL, 5, NULL, 'No', _binary 0xFFD8FFE000104A46494600010101006000600000FFDB004300080606070605080707070909080A0C140D0C0B0B0C1912130F141D1A1F1E1D1A1C1C20242E2720222C231C1C2837292C30313434341F27393D38323C2E333432FFDB0043010909090C0B0C180D0D1832211C213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232FFC00011080090009003012200021101031101FFC4001F0000010501010101010100000000000000000102030405060708090A0BFFC400B5100002010303020403050504040000017D01020300041105122131410613516107227114328191A1082342B1C11552D1F02433627282090A161718191A25262728292A3435363738393A434445464748494A535455565758595A636465666768696A737475767778797A838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE1E2E3E4E5E6E7E8E9EAF1F2F3F4F5F6F7F8F9FAFFC4001F0100030101010101010101010000000000000102030405060708090A0BFFC400B51100020102040403040705040400010277000102031104052131061241510761711322328108144291A1B1C109233352F0156272D10A162434E125F11718191A262728292A35363738393A434445464748494A535455565758595A636465666768696A737475767778797A82838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE2E3E4E5E6E7E8E9EAF2F3F4F5F6F7F8F9FAFFDA000C03010002110311003F00F7FA28A2800A28A2800A28A2800A2933413400B4530C8ABD58520914F2186281D992514D079A5CD02168A28A0028A28A0028A28A0028A28A002928A692413D702801327354F51D56CF4CB633DE4E90C63A9635CCF8B7C736BE1E88DBC1B66BE6FBA99E17DD8D78DEABACDF6AD76F717972D2B31FBB9F957E83B573D5C4461A2DCF6F2DC92B62FDF97BB1FCFD0F48D5FE2C448CD16976C65C7FCB59381F9571D7FE3CF10DF3B62FDA053FC310DBFAD735BCFAD5EB2D1B53D488FB1D8DC4C3D4271F9F4AE275AACDE87D552CAF01848DE697AB124D635494E65D4AED8F5CB4AC6963D635388E63D4AED4FF00B3330ADB87E1DF8A27E7EC6B129E81E55FE94B3FC39F13423FE3D2293D9241FD714B96B76657D672DF86F12B58F8E7C41A791B75092541D565F9F3F89AEC749F8B19223D52CCAF6F322EDEF8AF3DBED0756D3722EF4F9E203B95E3F319ACF249E734D56AB07A8AAE5980C5C6F14BD57FC03E94D3359B1D5E0596CAE5651DC03C8FAD6829393C57CCBA76A97BA4DCADC595C3C5229CF0783F515EC5E10F1F5BEB5B2D2F9960BE0381FC327B8AECA3888CF47B9F2D99647570979D3F7A3F8A3BCA29A1B232334EAE93C20A28A2800A28A4271400C3C1AE2FC77E2E8FC3D61E4DBB6EBF954EC5FEE0EED5D46ABA843A5E9D35ECEDB63854B135F39EB3AACFABEAB3DEDC396691B81E8BD8573E22AF246CB73DBC932DFADD5E79FC31FC7C8AB3DC4B75334D3BB3C8E72598F269228FCD9913705DEC06E6E833DE911249B3B159F68CB1519DA3D4D3091C63F5AF377D59F7CAC97240F68F0C7C3DD26DE18AE6EC2DECC40619E507D2BBA8A28225DB1A2A81C00A315E31E04F1C49A2CCB61A84ACF62E70AEDC98CFF857B3DBCC9344B244EAE8C32AC0E41FC6BD4A12838FBA7E779BD2C552AEFDB36EFB3E84F8A5C53437AE052EE07A104FD6B63CA219218E552B246AEA7A82335C6EBFF0E34BD515E5B5416B7279DC83E527DC576FED8A30315328464ACCDA8622AD0973539347CD7AD6877FA1DD9B7BC88AF242B81F2BFD2B3A291E191648D8ABA9CAB03C835F486B7A2596BBA74969771865232ADDD4F620D780EBFA25CE81AA4B6770A4A83F2498E187635E757A1ECDDD6C7DC6559BC71B1F65555A5F99EAFF000FBC60359B53617B2017D08E33FF002D17D6BBBCF278AF9874EBEB8D33508AFA07D924443291DC7A1AFA2F41D5E2D7346B7BE848C48BF30F43DC57561EAF3AB3DCF9FCF32D585ABED29FC32FC19AF45203914B5D2782148696909E2803CAFE2DEB0D1DBDB6931BE0CA77C807A0E95E50DEB5D2F8F3516BFF00185E9DD9485FC94F6DBC1FD6B2343B1FED3D6ACAC89E279829E3B77FD335E5566E756C7E8796528E1300A7E5767ACFC3BF0C456BA0FDAEE620D2DD2E4861D17B0AC9D67E16C235296E60BE8AD6C5FE62243F70FA7D2BD4EDE258208E35000450A00AF14FDA2EEA68F49D1ED924610C92BB3A03C1200C67F3AF43D8C1C545A3E35E67888D795584ACD927FC203A4671FF00093598C75F9C56D5C6B30F807C07A8CD1EB305FDC27FC7BA06076678000FD6BE58C8F7F7AB7A7D85E6A97D159D8C0D3DC4876A220CE4D38D2841DD19E231F5F111E5AB2BA3D8F43D0B5FF1669ABAC6A3E3D5B196E09710F9DD07D3B54BAB785B5BD034F9754D3FE20ADD4D6C37888CDF7B1FCEB9183E1EE9162DE4EB9AEC8F7C002D67A65B99DD3D99BA034F9BE1FE8376DE5693AEDCDB5E37FABB7D5AD4C3E61F40DD3F4AD0E23DD7E1F78FED3C43E13B7BCD4AF2DE1BD4263995DC2E48EF4EB9F89369078CA1F0F8B65749577ADD89D3CBDB8E4F5FD2BE4FD5349BDD175096CB5081A1B889B0CAC38FA8F515D268BA6F8167D2125D5B5BD4ADEFC83BA28A15283D3A8A00FAFE0B982EE3F32DE54950F4646C8FD2B95F883E1E1AD684D2C4B9BAB71BE323BFB5799FECF372FF00DA9AFD9C5348F66AAAF186E9F788CE3B1C57BDC918923656E8460D4CA2A4ACCD6856951AB1A91DD1F2C73B30DD4678FE95E9BF09357293DCE94EFF002B7CF183EBDEB89F15E9E74CF156A168061164DC9C7623229DE13BF7D3FC51A7CCA7199D55FF00DD3C1AF329DE154FD031F08E3300E5DD5D1F490A5ED4D5FBB4EAF54FCE829927DC6A7D31F942281ADCF98F5993CDD6F50739CB5CC87F3635BBF0E2DD6E3C716471FEA95DFF00F1DC7F5AE7F584316B7A846DD52E6407FEFA35D17C36B810F8DAD0646648DD07D719FE95E543F8BF33F43C4BFF0084D7CBFCA7BF03915E11FB497FC79E87FEFCBFC857BBAFDD15E11FB497FC7A687FEFCBFC857AA7E767CF63935EABF0FF004E9AC3C371DDD9FC9AB6BB786C2CE43D6285403238F7E48FC2BCA47BF4AF63F05EA70C5E17F0AEA8CA4C5A16AD3417407F76600AB9F419E3F0A00F7CF0E78574DF0DD825B59409E663324CCB9791BD49A9B5CF0E697E22B292D750B68E456180FB7E653EA0F635A714A92C6B246E1A365DCAC0E4114F660AA4938006493401F32F8EF45967F0E6A96D784BEA7E1A99024E7969ED643819FF0074E39AF1FC609E7F2AF77F1C6AF05C58F8D75B8C8F22E7C9D32D8F6958365C8FA0CD7838EB401EE9FB36F3AAEB9FF5C63FFD08D7D155F3AFECD7FF00216D73FEB847FF00A11AFA2A803C23E2B43E5F8CBCC031E65B213EE72C2B8EB572B796EC382AE0FEB5D87C579F7F8C84608C476A99FC59AB8EB6064BC857D5C01F9D79957F8AEC7E8997FF00C8B9737F29F50DBB6EB78D8F56507F4A9EA0B752B6B129EA140FD2A7AF4CFCF25F1316931C52D1408F9D3C7761FD9FE31BE4DA42CAFE6AFBEEE6B3340BFF00ECCD7B4FBC1C795302C7DBA1FE75E89F17B4B256D75445E84C52103A7A66BCA777CDEC463E95E6555C952E7E8396D58E2B02A2FB599F54C52AC9123AF2AC01045786FED25FF1E7A19EDBE4FE42BBCF869E201ABE82B6933E6EAD46C6C9E4AF635A1E35F03E9DE38D363B5BE79227858BC5347F794D7A309292BA3E131146546ACA9CBA1F1783820D749E12F1437872F2649A0175A75DA797776CC7EFAFA8F461DABDA3FE19BF49279D72F7FEF95FF0A51FB37691DF5BBEFF00BE53FC2A8C487C2DE27BEB4B358FC29E20D3750B0EB1D8EAB37933C03FBB93C11EF9AB1E21F14EB1716853C45AFE91A3E9E54F9B0E9F71F68B8987A2EDE0669BFF000CE1A567E5D72F87FC053FC297FE19C74A27E6D76FBDBE55FF000A00F1DF17F8A535C36F65616E6D348B2045BC04E4B13D5DFF00DA35C98524D7D1173FB3CE876903CF3EBF7A91A0CB3154E3F4ACA1F07BC17D478B65E3FDCFF0A4DA5BB2E14E73F85361FB37F1AAEB99EF0C7FCCD7D08CCB1A963C01D6BCA3C243C1BF0E41B7B3BF7BAB8BD70B2CE79C01D338E839AEA3C73E27834AF0D492C132B4D70BB212A7D7BD4BA91B377368612B4A71838B5CC79078C3521AA78BB50B91F32193629F6518A6785ACCDFF8A34EB60A594CEA5BE80E4D63139049CE5B924F73D6BD2FE11E90D3DFDCEAB22FC910F2E3247F177AF3A9A752A1F758C9C7098071ECACBF23D917EE8A5A4A5ED5EA1F9E0521A5A28032B5AD2E1D6749B8B19D72B2A9038E87B57CDBAAE9D3E91A9CF6170A5658988C63A8EC6BEA3C7BD709F10FC1BFDB969F6FB2451A8423FEFE2FA1AE7C452E7575B9EDE4B98FD56AF24FE197E0CF1FF0FEBB75E1FD5A2BFB6CE54E244CF0EBDC57D0DA0EBB65AFE9B1DDD9CA19587CCBFC48DDC115F33C91BC3234722957538653D41AD4D07C43A8787EF96E2C66C024799113F2B8F7AE5A359D3D1EC7BD9AE571C5C7DAD3F8BF33E9BA5AE27C39F1174AD6B645348B6D747AC6E7827D8D7668EAE372B0607B839AF4232525747C5D6A1528CB96A2B324A28A2A8C8AF3C69344D1C88191861948C822BC47C77E027D1657D4B4E8CBD83925E35E4C47FC2BDC5D82A92C4002B8FF001478DF44D26092099D2E66652BE427CDF9D655A3194753D1CB6B57A5597B257BEEBB9E0200C70303DEA796F2E6E228E29A6778E2188D5CE428F414B7734571792CD142B123B1658C74407B542AA5D82A82589C002BCCDB447E83EE38A94959AFC096CECE7D46F20B4823DF2CCC1100F7AFA3FC33A247A068B6F6318C145CB9FEF377AE47E1CF828E9710D5B518C7DB245FDD21EB1AFF0089AF47C7CC79AEFC3D2E5577B9F159DE62B113F674DFBABF164945145749E1051451400531813C0EF4FA2803CF7C69F0F20D755EF74FDB06A0393FDD93EBEF5E2F7DA65E69576D6D7F0C90489C6D71C1F7CF7AFA99B39EB597ACE81A6EBB6E60BFB649411C1C723E86B9EAD053D56E7B797E75530C953A9EF47F147CC99EE3007AF5AD9D3FC5BAF6948059EA9308C7F039DC07E75DBEAFF08664676D22E83275114A791ED9AE2AFBC21E20D39CACFA5DC151FC68A587E95CAE9D4833E9618DC0E2E366D3F266EC3F167C4A8A038B2900EED0B027FF001EA74DF16BC4AFF2C696480F711B13FF00A15712F693A36D6B7955875CA114A2D6E1B8582427D02134BDAD5EE2FA8E5FBDA26C6A3E32D7F54CADCEA52E3BAC7F2AFE82B0B96CF39E724F73F9D6B58F8535ED4085B7D2EE9831FBCC8547E66BB6D23E0FDD4E55B57BA5893AF971727F3A153A937A8E78CC0E163EEB4BC97FC03CEAD2CEE751B8105AC0F34CDD111735EC1E08F8711E9263D4B560B2DE632B08E5633FD4D75FA278674CF0FC022B1B75423197232C7EA6B679C1E6BAA961D45DDEE7CE6639DD4C4274E9E91FC58E029D4515D27841451450014514500145145001486968A004A368F4A5A2802168227E5A246FAA8348B0440E562407D428A9E8A562B998CDA3F2A76334B4532428A28A0028A28A0028A28A00FFD9, 10),
	(2, 1, 'Otro Producto', 1000, 1100, 1200, 1300, NULL, 20, NULL, 'No', _binary 0xFFD8FFE000104A46494600010101006000600000FFDB004300080606070605080707070909080A0C140D0C0B0B0C1912130F141D1A1F1E1D1A1C1C20242E2720222C231C1C2837292C30313434341F27393D38323C2E333432FFDB0043010909090C0B0C180D0D1832211C213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232FFC00011080090009003012200021101031101FFC4001F0000010501010101010100000000000000000102030405060708090A0BFFC400B5100002010303020403050504040000017D01020300041105122131410613516107227114328191A1082342B1C11552D1F02433627282090A161718191A25262728292A3435363738393A434445464748494A535455565758595A636465666768696A737475767778797A838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE1E2E3E4E5E6E7E8E9EAF1F2F3F4F5F6F7F8F9FAFFC4001F0100030101010101010101010000000000000102030405060708090A0BFFC400B51100020102040403040705040400010277000102031104052131061241510761711322328108144291A1B1C109233352F0156272D10A162434E125F11718191A262728292A35363738393A434445464748494A535455565758595A636465666768696A737475767778797A82838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE2E3E4E5E6E7E8E9EAF2F3F4F5F6F7F8F9FAFFDA000C03010002110311003F00F7FA28A2800A28A2800A28A2800A2933413400B4530BAAF561481C1E4118A02C4945341E6973400B451450014514500145145001451450014945349209EB8140064E6A9EA3AAD9E996C67BCB848631D4B1AE67C5DE39B5F0F446DE0DB35F37DD4CF0BEEC6BC6B55D66FB57BB7B8BCB969598FDDCFCABF41DAB9EAE2230D16E7B796E495B17EFCBDD8FE7E87A4EAFF16624668B4BB632E3FE5AC9C0FCAB8EBFF1EF88AF9DB17ED029FE1886DFD6B99DE7D6AF5968DA9EA447D8EC6E261EA138FCFA5713AD566F43EAE965580C246F34BD58926B1AA4A732EA576C7AE5A5634B1EB1A9C4731EA576A7FD999856E43F0EBC513F3F635894F40F2AFF004A27F871E26847FC7A4527B2483FAE297256ECCAFAD65BF0F344AF63E3AF10E9E46DD42495075597E7CFE26BB1D27E2CE488F54B32BDBCC8BB7BE2BCF2FB41D5B4DC8BBD3E7880EE578FCC66B3C9279CD355AAC1EA2AB96603171BC52F55FF0000FA574CD66C7578165B2B95947700F23EB5A0A4E4F15F3269DAA5EE9372B716570F148A73C1E0FD457B1F83FC7D6FADECB4BE6582F80E07F0C9EE2BB28E2233D1EE7CAE659155C25E74FDE8FE28EEE8A686C8C8CD3ABA4F0828A28A0028A2909C50034F06B8BF1DF8BE3F0ED87936EDBAFE553B17FB83BB5751AAEA10E97A74D7B3B6D8E152C4D7CE5ACEAB3EB1AACF7B70E59A46E07A2F615CF88ABC91B2DCF6F24CB7EB7579E7F0C7F1F22ACF712DD4CD34EECF239C9663C9A48A3F36644DC177B01B9BA0CF7A444926CEC567DA32C546768F534C24718FD6BCCDF567DFAB25C903DA7C31F0F349B6862B9BB0B7B3101867941F4AEEE28A18936C68AA070028C578B7813C73268B32D86A12B3D8B9C2BB72633FE15ED104C9344B244EAE8C32AC0E41FC6BD5A12838FBA7E759BD2C552AEFDBB6EFB3E84D8A5C53437AE052EE07A104FD6B63CA229218E552B222BA9EA08CD71BE20F871A5EAAAF2DAC62D6E4F3B907CA4FB8AEDFDB146062A6508C9599B50C455A12E6A7268F9AB5AD0AFF0042BB36F79115E485703E57FA5674523C322C91B1575395607906BE91D6F43B2D774E92D2EE30CA4655BBA9EC41AF00F1068973E1FD565B3B852541F924C70C3B1AF3ABD0F66EEB63EE729CDE38D8FB2AAAD2FCCF58F87DE301AD5A9B0BD900BE84719FF968BEB5DDE7AF15F3069D7D71A66A115F40FB248886523B8F435F46683ABC5AE68D6F7D0918917E61E87B8AEAC3D5E7567B9F3D9E65AB0B57DA53F865F8335A8A4072296BA4F04290D2D213C5007967C5CD61A3B6B6D2637C194EF900F41D2BC9DBD6BA5F1EEA2D7FE31BD3BB290BF929EDB783FAD6468763FDA7AD595913C4F3053C76EFFA66BCAACDCEAD8FD132BA51C26014DF6BB3D6FE1D78622B4D03ED77310696ED72430E8BD85646B3F0B611A94B7305F456B62FF31121FB87D3E95EA7044B0431C6A0008A14015E27FB465D4D1E93A3DB248C21925767407824018CFE75E87B1838A8B47C63CD3131AF2AB0959B25FF00840348CE3FE127B318EBF38ADAB8D6A1F00F80B51963D6A0BFB84FF8F740C0ECCF0001FAD7CAF91EFEF56B4FB0BCD52FA2B3B181A7B890ED44419C9A71A5083BA33C466188C44796ACAE8F64D0F42D7FC59A6AEB1A8F8F56C65B825C43E7741F4ED52EADE16D6F40D3E5D534FF00882B7535B0DE22337DEC7F3AE460F879A458B793AE6BB23DF000B59E996E6774F666E80D3E6F87FA0DDB795A4EBB736D78DFEAEDF56B530F987D0374FD2B4388F75F87DE3FB4F10F84EDEF352BCB786F5098E65770B923BD3AE7E255A41E3287C3E2D95D255DEB76274F2F6E393D7F4AF93F54D26F745D425B2D420686E226C32B0E3EA3D45747A2E9BE05B8D2125D5B5BD4ADEFC83BA28A15283D3A8A00FB060BA82EE3F32DE54950F4646C8FD2B95F883E1D1AD682F2C4B9BAB71BE323BFB57997ECF172FF00DA9AFD9C5348F66AAAF186E9F788CE3B1C57BE491891195BA11835328A92B335A15A546AC6A47747CAFCECC37519E3FA57A6FC24D5CA4F73A53BFCADF3C60FAF7AE27C57A79D33C55A85A01845937271D88C8A7784AFDF4FF14E9D329C667557FF0074F06BCCA778553F41C7C238CC039775747D24297B522FDDA5AF54FCE4298FF71A9F4C7E5714023E63D664F375BD41CE72D7321FCD8D6F7C37B75B8F1CD91C7FAA577FFC771FD6B9ED610C5ADEA11B754B9901FF00BE8D745F0D6E043E37B41919923741F5C67FA57950FE2FCCFD1714FF00E135F2FF0029EFC0E457847ED25FF1E7A1FF00BF2FF215EEEBF7457847ED25FF001E9A1FFBF2FF00215EA9F9D1F3D8E4D7AAFC3FD3A6B0F0DC77767F26ADAEDE1B0B390F58A1500C8E3DF923F0AF291EFD2BD8FC15A9C31785FC2BAA32931685AB4D05D01FDD9802AE7D0678FC2803DF3C39E15D37C376096D65027998CC9332E5E46F526A7D73C39A5F88ACA4B5D42DA39158603EDF994FA83D8D69C52A4B1AC91B868D9772B03904539982A924E001924D007CCBE3BD1659FC39AA5B5E12FA9F86A640939E5A7B590E067FDD38E6BC7F18279FCABDDFC71ABC17163E35D6E323C8B9F274CB63DA560D9723E8335E0E3AD007BA7ECDBCEABAE7FD718FFF004235F4557CEBFB35FF00C85B5CFF00AE11FF00E846BE8AA00F09F8AF0F97E32F300C7996A84FB9CB0AE36D5CADE5BB0E0AB83FAD763F1627DFE3258C1188ED533F8B3571B6C0C9790AFAB803F3AF2EAFF15D8FD172FF00F9172E6FE53EA2B76DD6F1B1EACA0FE9535436EA56D6253D4281FA54D5EA1F9DCBE262D2638A5A2811F3A78F2C3FB3FC657E9B48595FCD5F7DDCD666817FFD99AF69F7838F2A6058FB743FCEBD17E2FE944ADAEA88BD098A42074F4CD7946EF9BD88C7D2BCCAAB92A5CFD0B2DAB1C560545F6B33EAA8A55922475E5580208AF0CFDA4BFE3CF433DB7C9FC8577BF0D3C42357D012D267CDD5A8D8D93C95EC6AFF008DBC0FA778E74C8ED6F9E489E162F14D1FDE535E8C24A4AE8F83C451951AB2A72E87C5E0E0835D1F84BC52DE1CBC9926805D69D769E5DDDB31FBEBEA3D1876AF69FF00866FD249E75CBDFF00BE57FC2947ECDDA477D6EFBFEF94FF000AA3121F0B789EFAD2CD63F0A78834DD42C3AC763AACDE4CF00FEEE4F047BE6AC788BC53AC5C5A14F116BFA468FA7953E6C3A7DC7DA2E261E8BB7819A6FF00C3386959F975CBE1FF00014FF0A5FF008670D289F9B5DBEF6F957FC2803C73C5FE294D74DBD9585B9B4D22C8116F01392C4F577FF68D72814935F445CFECF1A1DA40F3CFAFDEA46832CC5538FD2B287C1DF05F51E2E978FF0073FC293696ECB8539CFE14D87ECDDC6ABAE67BC31FF335F42B32A2963C01D6BC9FC243C19F0E01B7B3BF7BAB8BD70B2CE79C01D338E839AEA7C73E278349F0CC92C132B4D72BB212A7D7BD4BA91B377368612B4A71838B5CC78FF8C3521AA78BB50B91F32193629F6518A67856CCDFF8A74EB60A594CEA5BE80E4D63139049CE5B924F73D6BD2FE11690D3DFDCEAB22FC910F2E3247F177AF3A9A752A1F778C9C7098071ECACBF23D907DD14B494BDABD43F3B0A434B450065EB5A5C3ACE9371633AE56552071D0F6AF9B355D3A7D23539EC2E14ACB13118C751D8D7D498F7AE13E21F833FB76D3EDF648A350847FDFC5F435CF88A5CEAEB73DBC9731FAAD5E49FC32FC19E3DE1FD76EBC3FAB457F6D9CA9C4899E1D7B8AFA1F41D76CB5FD363BCB39432B0F997F891BB822BE66923786468E452AEA70CA7A835A9A0F88750F0F5F2DC58CD8048F32227E571EF5CB46B3A7A3D8F7F35CAE38C8FB5A7F17E67D374B5C57873E22E93AD048A6916DAE8F58DCF04FB1AEC91D5C6E560C0F70735E8464A4AE8F8AAD42A51972D45664945145519104F1A4D1347220646186523208AF10F1DF805F4595F52D3A32F60E4978D79311FF0AF72760AA4B1000AE43C51E38D0F48B792099D2EA6652BE427CDF9D655A3194753D1CB2BD7A5597B257BEEBB9F3F8031C0C0F7A9E5BCB9B88A38A699DE38862357390A3D052DDCD15C5E4B3450AC48EC59631D101ED50AA9760AA09627000AF336D11FA17BB28A94959AFC096CECE7D46F20B4823DF2CCC1100F7AFA43C33A247A068B6F6318C145CB9FEF377AE47E1C7828E9710D5B518C7DB245FDD21EB1AFF89AF47EE79AEFC3D2E5577B9F139DE62B133F674DFBABF163E8A28AE93C20A28A2800A6302781DE9F450079F78D7E1E41AEABDEE9FB60D40727FBB27D7DEBC5AFB4CBCD2AEDADAFE19209138DAE383EF9EF5F539CE7AD65EB3A069BAEDB982FED925047071C8FA1AE7AB414F55B9EDE5F9D54C3254EA7BD1FC51F31E7B8C01EBD6B674FF16EBDA520167AA4C231FC0E7701F9D76FABFC219919DB48BA0C9D44529E47B66B8ABEF07F8834E72B3E9770547F1A2961FA572BA7520CFA6863B038B8D9B4FC99BD07C5AF12A280EB65201DDA1604FF00E3D4E9BE2DF895FE58E3B18C1EE23627FF0042AE21ED2746DAD6F2AB0EB9422945ADC370B0484FA042697B5ABDC5F50CBF7B44D8D47C65AFEA995B9D4A5C7758FE55FD056172D9E73CE49EE7F3AD6B1F09EBDA810B6FA5DD3063F7990A8FCCD76DA47C1FBA9CAB6AF74B1275F2E2E4FE742A7526F51CF1981C247DD69792FF008079D5A59DCEA37020B581E699BA222E6BD87C11F0E23D24C7A96AC165BCC65611CAC67FA9AEBF44F0CE97E1F8045636EA84632E4658FD4D6CF383CD7552C3A8BBBDCF9BCC73BA9884E9D3D23F8B140A75145749E10514514005145140051451400521A5A280128DA2968A0089A089F968918FBA8348B0440E562407D428A9A8A2C3E663368FCA9D8CD2D140828A28A0028A28A0028A28A00FFFD9, 10),
	(3, 1, 'Galleta', 1000, 1500, 1300, 1200, NULL, 17, NULL, 'Kilo', _binary 0xFFD8FFE000104A46494600010101006000600000FFDB004300080606070605080707070909080A0C140D0C0B0B0C1912130F141D1A1F1E1D1A1C1C20242E2720222C231C1C2837292C30313434341F27393D38323C2E333432FFDB0043010909090C0B0C180D0D1832211C213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232FFC00011080090009003012200021101031101FFC4001F0000010501010101010100000000000000000102030405060708090A0BFFC400B5100002010303020403050504040000017D01020300041105122131410613516107227114328191A1082342B1C11552D1F02433627282090A161718191A25262728292A3435363738393A434445464748494A535455565758595A636465666768696A737475767778797A838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE1E2E3E4E5E6E7E8E9EAF1F2F3F4F5F6F7F8F9FAFFC4001F0100030101010101010101010000000000000102030405060708090A0BFFC400B51100020102040403040705040400010277000102031104052131061241510761711322328108144291A1B1C109233352F0156272D10A162434E125F11718191A262728292A35363738393A434445464748494A535455565758595A636465666768696A737475767778797A82838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE2E3E4E5E6E7E8E9EAF2F3F4F5F6F7F8F9FAFFDA000C03010002110311003F00F7FA28A2800A28A2800A28A2800A2933413400B4530C8ABD58520914F2186281D992514D079A5CD02168A28A0028A28A0028A28A0028A28A002928A692413D702801327354F51D56CF4CB633DE4E90C63A9635CCF8B7C736BE1E88DBC1B66BE6FBA99E17DD8D78DEABACDF6AD76F717972D2B31FBB9F957E83B573D5C4461A2DCF6F2DC92B62FDF97BB1FCFD0F48D5FE2C448CD16976C65C7FCB59381F9571D7FE3CF10DF3B62FDA053FC310DBFAD735BCFAD5EB2D1B53D488FB1D8DC4C3D4271F9F4AE275AACDE87D552CAF01848DE697AB124D635494E65D4AED8F5CB4AC6963D635388E63D4AED4FF00B3330ADB87E1DF8A27E7EC6B129E81E55FE94B3FC39F13423FE3D2293D9241FD714B96B76657D672DF86F12B58F8E7C41A791B75092541D565F9F3F89AEC749F8B19223D52CCAF6F322EDEF8AF3DBED0756D3722EF4F9E203B95E3F319ACF249E734D56AB07A8AAE5980C5C6F14BD57FC03E94D3359B1D5E0596CAE5651DC03C8FAD6829393C57CCBA76A97BA4DCADC595C3C5229CF0783F515EC5E10F1F5BEB5B2D2F9960BE0381FC327B8AECA3888CF47B9F2D99647570979D3F7A3F8A3BCA29A1B232334EAE93C20A28A2800A28A4271400C3C1AE2FC77E2E8FC3D61E4DBB6EBF954EC5FEE0EED5D46ABA843A5E9D35ECEDB63854B135F39EB3AACFABEAB3DEDC396691B81E8BD8573E22AF246CB73DBC932DFADD5E79FC31FC7C8AB3DC4B75334D3BB3C8E72598F269228FCD9913705DEC06E6E833DE911249B3B159F68CB1519DA3D4D3091C63F5AF377D59F7CAC97240F68F0C7C3DD26DE18AE6EC2DECC40619E507D2BBA8A28225DB1A2A81C00A315E31E04F1C49A2CCB61A84ACF62E70AEDC98CFF857B3DBCC9344B244EAE8C32AC0E41FC6BD4A12838FBA7E779BD2C552AEFDB36EFB3E84F8A5C53437AE052EE07A104FD6B63CA219218E552B246AEA7A82335C6EBFF0E34BD515E5B5416B7279DC83E527DC576FED8A30315328464ACCDA8622AD0973539347CD7AD6877FA1DD9B7BC88AF242B81F2BFD2B3A291E191648D8ABA9CAB03C835F486B7A2596BBA74969771865232ADDD4F620D780EBFA25CE81AA4B6770A4A83F2498E187635E757A1ECDDD6C7DC6559BC71B1F65555A5F99EAFF000FBC60359B53617B2017D08E33FF002D17D6BBBCF278AF9874EBEB8D33508AFA07D924443291DC7A1AFA2F41D5E2D7346B7BE848C48BF30F43DC57561EAF3AB3DCF9FCF32D585ABED29FC32FC19AF45203914B5D2782148696909E2803CAFE2DEB0D1DBDB6931BE0CA77C807A0E95E50DEB5D2F8F3516BFF00185E9DD9485FC94F6DBC1FD6B2343B1FED3D6ACAC89E279829E3B77FD335E5566E756C7E8796528E1300A7E5767ACFC3BF0C456BA0FDAEE620D2DD2E4861D17B0AC9D67E16C235296E60BE8AD6C5FE62243F70FA7D2BD4EDE258208E35000450A00AF14FDA2EEA68F49D1ED924610C92BB3A03C1200C67F3AF43D8C1C545A3E35E67888D795584ACD927FC203A4671FF00093598C75F9C56D5C6B30F807C07A8CD1EB305FDC27FC7BA06076678000FD6BE58C8F7F7AB7A7D85E6A97D159D8C0D3DC4876A220CE4D38D2841DD19E231F5F111E5AB2BA3D8F43D0B5FF1669ABAC6A3E3D5B196E09710F9DD07D3B54BAB785B5BD034F9754D3FE20ADD4D6C37888CDF7B1FCEB9183E1EE9162DE4EB9AEC8F7C002D67A65B99DD3D99BA034F9BE1FE8376DE5693AEDCDB5E37FABB7D5AD4C3E61F40DD3F4AD0E23DD7E1F78FED3C43E13B7BCD4AF2DE1BD4263995DC2E48EF4EB9F89369078CA1F0F8B65749577ADD89D3CBDB8E4F5FD2BE4FD5349BDD175096CB5081A1B889B0CAC38FA8F515D268BA6F8167D2125D5B5BD4ADEFC83BA28A15283D3A8A00FAFE0B982EE3F32DE54950F4646C8FD2B95F883E1E1AD684D2C4B9BAB71BE323BFB5799FECF372FF00DA9AFD9C5348F66AAAF186E9F788CE3B1C57BDC918923656E8460D4CA2A4ACCD6856951AB1A91DD1F2C73B30DD4678FE95E9BF09357293DCE94EFF002B7CF183EBDEB89F15E9E74CF156A168061164DC9C7623229DE13BF7D3FC51A7CCA7199D55FF00DD3C1AF329DE154FD031F08E3300E5DD5D1F490A5ED4D5FBB4EAF54FCE829927DC6A7D31F942281ADCF98F5993CDD6F50739CB5CC87F3635BBF0E2DD6E3C716471FEA95DFF00F1DC7F5AE7F584316B7A846DD52E6407FEFA35D17C36B810F8DAD0646648DD07D719FE95E543F8BF33F43C4BFF0084D7CBFCA7BF03915E11FB497FC79E87FEFCBFC857BBAFDD15E11FB497FC7A687FEFCBFC857AA7E767CF63935EABF0FF004E9AC3C371DDD9FC9AB6BB786C2CE43D6285403238F7E48FC2BCA47BF4AF63F05EA70C5E17F0AEA8CA4C5A16AD3417407F76600AB9F419E3F0A00F7CF0E78574DF0DD825B59409E663324CCB9791BD49A9B5CF0E697E22B292D750B68E456180FB7E653EA0F635A714A92C6B246E1A365DCAC0E4114F660AA4938006493401F32F8EF45967F0E6A96D784BEA7E1A99024E7969ED643819FF0074E39AF1FC609E7F2AF77F1C6AF05C58F8D75B8C8F22E7C9D32D8F6958365C8FA0CD7838EB401EE9FB36F3AAEB9FF5C63FFD08D7D155F3AFECD7FF00216D73FEB847FF00A11AFA2A803C23E2B43E5F8CBCC031E65B213EE72C2B8EB572B796EC382AE0FEB5D87C579F7F8C84608C476A99FC59AB8EB6064BC857D5C01F9D79957F8AEC7E8997FF00C8B9737F29F50DBB6EB78D8F56507F4A9EA0B752B6B129EA140FD2A7AF4CFCF25F1316931C52D1408F9D3C7761FD9FE31BE4DA42CAFE6AFBEEE6B3340BFF00ECCD7B4FBC1C795302C7DBA1FE75E89F17B4B256D75445E84C52103A7A66BCA777CDEC463E95E6555C952E7E8396D58E2B02A2FB599F54C52AC9123AF2AC01045786FED25FF1E7A19EDBE4FE42BBCF869E201ABE82B6933E6EAD46C6C9E4AF635A1E35F03E9DE38D363B5BE79227858BC5347F794D7A309292BA3E131146546ACA9CBA1F1783820D749E12F1437872F2649A0175A75DA797776CC7EFAFA8F461DABDA3FE19BF49279D72F7FEF95FF0A51FB37691DF5BBEFF00BE53FC2A8C487C2DE27BEB4B358FC29E20D3750B0EB1D8EAB37933C03FBB93C11EF9AB1E21F14EB1716853C45AFE91A3E9E54F9B0E9F71F68B8987A2EDE0669BFF000CE1A567E5D72F87FC053FC297FE19C74A27E6D76FBDBE55FF000A00F1DF17F8A535C36F65616E6D348B2045BC04E4B13D5DFF00DA35C98524D7D1173FB3CE876903CF3EBF7A91A0CB3154E3F4ACA1F07BC17D478B65E3FDCFF0A4DA5BB2E14E73F85361FB37F1AAEB99EF0C7FCCD7D08CCB1A963C01D6BCA3C243C1BF0E41B7B3BF7BAB8BD70B2CE79C01D338E839AEA3C73E27834AF0D492C132B4D70BB212A7D7BD4BA91B377368612B4A71838B5CC79078C3521AA78BB50B91F32193629F6518A6785ACCDFF8A34EB60A594CEA5BE80E4D63139049CE5B924F73D6BD2FE11E90D3DFDCEAB22FC910F2E3247F177AF3A9A752A1F758C9C7098071ECACBF23D917EE8A5A4A5ED5EA1F9E0521A5A28032B5AD2E1D6749B8B19D72B2A9038E87B57CDBAAE9D3E91A9CF6170A5658988C63A8EC6BEA3C7BD709F10FC1BFDB969F6FB2451A8423FEFE2FA1AE7C452E7575B9EDE4B98FD56AF24FE197E0CF1FF0FEBB75E1FD5A2BFB6CE54E244CF0EBDC57D0DA0EBB65AFE9B1DDD9CA19587CCBFC48DDC115F33C91BC3234722957538653D41AD4D07C43A8787EF96E2C66C024799113F2B8F7AE5A359D3D1EC7BD9AE571C5C7DAD3F8BF33E9BA5AE27C39F1174AD6B645348B6D747AC6E7827D8D7668EAE372B0607B839AF4232525747C5D6A1528CB96A2B324A28A2A8C8AF3C69344D1C88191861948C822BC47C77E027D1657D4B4E8CBD83925E35E4C47FC2BDC5D82A92C4002B8FF001478DF44D26092099D2E66652BE427CDF9D655A3194753D1CB6B57A5597B257BEEBB9E0200C70303DEA796F2E6E228E29A6778E2188D5CE428F414B7734571792CD142B123B1658C74407B542AA5D82A82589C002BCCDB447E83EE38A94959AFC096CECE7D46F20B4823DF2CCC1100F7AFA3FC33A247A068B6F6318C145CB9FEF377AE47E1CF828E9710D5B518C7DB245FDD21EB1AFF0089AF47C7CC79AEFC3D2E5577B9F159DE62B113F674DFBABF164945145749E1051451400531813C0EF4FA2803CF7C69F0F20D755EF74FDB06A0393FDD93EBEF5E2F7DA65E69576D6D7F0C90489C6D71C1F7CF7AFA99B39EB597ACE81A6EBB6E60BFB649411C1C723E86B9EAD053D56E7B797E75530C953A9EF47F147CC99EE3007AF5AD9D3FC5BAF6948059EA9308C7F039DC07E75DBEAFF08664676D22E83275114A791ED9AE2AFBC21E20D39CACFA5DC151FC68A587E95CAE9D4833E9618DC0E2E366D3F266EC3F167C4A8A038B2900EED0B027FF001EA74DF16BC4AFF2C696480F711B13FF00A15712F693A36D6B7955875CA114A2D6E1B8582427D02134BDAD5EE2FA8E5FBDA26C6A3E32D7F54CADCEA52E3BAC7F2AFE82B0B96CF39E724F73F9D6B58F8535ED4085B7D2EE9831FBCC8547E66BB6D23E0FDD4E55B57BA5893AF971727F3A153A937A8E78CC0E163EEB4BC97FC03CEAD2CEE751B8105AC0F34CDD111735EC1E08F8711E9263D4B560B2DE632B08E5633FD4D75FA278674CF0FC022B1B75423197232C7EA6B679C1E6BAA961D45DDEE7CE6639DD4C4274E9E91FC58E029D4515D27841451450014514500145145001486968A004A368F4A5A2802168227E5A246FAA8348B0440E562407D428A9E8A562B998CDA3F2A76334B4532428A28A0028A28A0028A28A00FFD9, 10),
	(4, 2, 'Paquetito', 10000, 1300, 0, 0, 12000, 14, 10, 'Si', _binary 0xFFD8FFE000104A46494600010101006000600000FFDB004300080606070605080707070909080A0C140D0C0B0B0C1912130F141D1A1F1E1D1A1C1C20242E2720222C231C1C2837292C30313434341F27393D38323C2E333432FFDB0043010909090C0B0C180D0D1832211C213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232FFC00011080090009003012200021101031101FFC4001F0000010501010101010100000000000000000102030405060708090A0BFFC400B5100002010303020403050504040000017D01020300041105122131410613516107227114328191A1082342B1C11552D1F02433627282090A161718191A25262728292A3435363738393A434445464748494A535455565758595A636465666768696A737475767778797A838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE1E2E3E4E5E6E7E8E9EAF1F2F3F4F5F6F7F8F9FAFFC4001F0100030101010101010101010000000000000102030405060708090A0BFFC400B51100020102040403040705040400010277000102031104052131061241510761711322328108144291A1B1C109233352F0156272D10A162434E125F11718191A262728292A35363738393A434445464748494A535455565758595A636465666768696A737475767778797A82838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE2E3E4E5E6E7E8E9EAF2F3F4F5F6F7F8F9FAFFDA000C03010002110311003F00F7FA28A2800A28A2800A28A2800A2933413400B4530BAAF561481C1E4118A02C4945341E6973400B451450014514500145145001451450014945349209EB8140064E6A9EA3AAD9E996C67BCB848631D4B1AE67C5DE39B5F0F446DE0DB35F37DD4CF0BEEC6BC6B55D66FB57BB7B8BCB969598FDDCFCABF41DAB9EAE2230D16E7B796E495B17EFCBDD8FE7E87A4EAFF16624668B4BB632E3FE5AC9C0FCAB8EBFF1EF88AF9DB17ED029FE1886DFD6B99DE7D6AF5968DA9EA447D8EC6E261EA138FCFA5713AD566F43EAE965580C246F34BD58926B1AA4A732EA576C7AE5A5634B1EB1A9C4731EA576A7FD999856E43F0EBC513F3F635894F40F2AFF004A27F871E26847FC7A4527B2483FAE297256ECCAFAD65BF0F344AF63E3AF10E9E46DD42495075597E7CFE26BB1D27E2CE488F54B32BDBCC8BB7BE2BCF2FB41D5B4DC8BBD3E7880EE578FCC66B3C9279CD355AAC1EA2AB96603171BC52F55FF0000FA574CD66C7578165B2B95947700F23EB5A0A4E4F15F3269DAA5EE9372B716570F148A73C1E0FD457B1F83FC7D6FADECB4BE6582F80E07F0C9EE2BB28E2233D1EE7CAE659155C25E74FDE8FE28EEE8A686C8C8CD3ABA4F0828A28A0028A2909C50034F06B8BF1DF8BE3F0ED87936EDBAFE553B17FB83BB5751AAEA10E97A74D7B3B6D8E152C4D7CE5ACEAB3EB1AACF7B70E59A46E07A2F615CF88ABC91B2DCF6F24CB7EB7579E7F0C7F1F22ACF712DD4CD34EECF239C9663C9A48A3F36644DC177B01B9BA0CF7A444926CEC567DA32C546768F534C24718FD6BCCDF567DFAB25C903DA7C31F0F349B6862B9BB0B7B3101867941F4AEEE28A18936C68AA070028C578B7813C73268B32D86A12B3D8B9C2BB72633FE15ED104C9344B244EAE8C32AC0E41FC6BD5A12838FBA7E759BD2C552AEFDBB6EFB3E84D8A5C53437AE052EE07A104FD6B63CA229218E552B222BA9EA08CD71BE20F871A5EAAAF2DAC62D6E4F3B907CA4FB8AEDFDB146062A6508C9599B50C455A12E6A7268F9AB5AD0AFF0042BB36F79115E485703E57FA5674523C322C91B1575395607906BE91D6F43B2D774E92D2EE30CA4655BBA9EC41AF00F1068973E1FD565B3B852541F924C70C3B1AF3ABD0F66EEB63EE729CDE38D8FB2AAAD2FCCF58F87DE301AD5A9B0BD900BE84719FF968BEB5DDE7AF15F3069D7D71A66A115F40FB248886523B8F435F46683ABC5AE68D6F7D0918917E61E87B8AEAC3D5E7567B9F3D9E65AB0B57DA53F865F8335A8A4072296BA4F04290D2D213C5007967C5CD61A3B6B6D2637C194EF900F41D2BC9DBD6BA5F1EEA2D7FE31BD3BB290BF929EDB783FAD6468763FDA7AD595913C4F3053C76EFFA66BCAACDCEAD8FD132BA51C26014DF6BB3D6FE1D78622B4D03ED77310696ED72430E8BD85646B3F0B611A94B7305F456B62FF31121FB87D3E95EA7044B0431C6A0008A14015E27FB465D4D1E93A3DB248C21925767407824018CFE75E87B1838A8B47C63CD3131AF2AB0959B25FF00840348CE3FE127B318EBF38ADAB8D6A1F00F80B51963D6A0BFB84FF8F740C0ECCF0001FAD7CAF91EFEF56B4FB0BCD52FA2B3B181A7B890ED44419C9A71A5083BA33C466188C44796ACAE8F64D0F42D7FC59A6AEB1A8F8F56C65B825C43E7741F4ED52EADE16D6F40D3E5D534FF00882B7535B0DE22337DEC7F3AE460F879A458B793AE6BB23DF000B59E996E6774F666E80D3E6F87FA0DDB795A4EBB736D78DFEAEDF56B530F987D0374FD2B4388F75F87DE3FB4F10F84EDEF352BCB786F5098E65770B923BD3AE7E255A41E3287C3E2D95D255DEB76274F2F6E393D7F4AF93F54D26F745D425B2D420686E226C32B0E3EA3D45747A2E9BE05B8D2125D5B5BD4ADEFC83BA28A15283D3A8A00FB060BA82EE3F32DE54950F4646C8FD2B95F883E1D1AD682F2C4B9BAB71BE323BFB57997ECF172FF00DA9AFD9C5348F66AAAF186E9F788CE3B1C57BE491891195BA11835328A92B335A15A546AC6A47747CAFCECC37519E3FA57A6FC24D5CA4F73A53BFCADF3C60FAF7AE27C57A79D33C55A85A01845937271D88C8A7784AFDF4FF14E9D329C667557FF0074F06BCCA778553F41C7C238CC039775747D24297B522FDDA5AF54FCE4298FF71A9F4C7E5714023E63D664F375BD41CE72D7321FCD8D6F7C37B75B8F1CD91C7FAA577FFC771FD6B9ED610C5ADEA11B754B9901FF00BE8D745F0D6E043E37B41919923741F5C67FA57950FE2FCCFD1714FF00E135F2FF0029EFC0E457847ED25FF1E7A1FF00BF2FF215EEEBF7457847ED25FF001E9A1FFBF2FF00215EA9F9D1F3D8E4D7AAFC3FD3A6B0F0DC77767F26ADAEDE1B0B390F58A1500C8E3DF923F0AF291EFD2BD8FC15A9C31785FC2BAA32931685AB4D05D01FDD9802AE7D0678FC2803DF3C39E15D37C376096D65027998CC9332E5E46F526A7D73C39A5F88ACA4B5D42DA39158603EDF994FA83D8D69C52A4B1AC91B868D9772B03904539982A924E001924D007CCBE3BD1659FC39AA5B5E12FA9F86A640939E5A7B590E067FDD38E6BC7F18279FCABDDFC71ABC17163E35D6E323C8B9F274CB63DA560D9723E8335E0E3AD007BA7ECDBCEABAE7FD718FFF004235F4557CEBFB35FF00C85B5CFF00AE11FF00E846BE8AA00F09F8AF0F97E32F300C7996A84FB9CB0AE36D5CADE5BB0E0AB83FAD763F1627DFE3258C1188ED533F8B3571B6C0C9790AFAB803F3AF2EAFF15D8FD172FF00F9172E6FE53EA2B76DD6F1B1EACA0FE9535436EA56D6253D4281FA54D5EA1F9DCBE262D2638A5A2811F3A78F2C3FB3FC657E9B48595FCD5F7DDCD666817FFD99AF69F7838F2A6058FB743FCEBD17E2FE944ADAEA88BD098A42074F4CD7946EF9BD88C7D2BCCAAB92A5CFD0B2DAB1C560545F6B33EAA8A55922475E5580208AF0CFDA4BFE3CF433DB7C9FC8577BF0D3C42357D012D267CDD5A8D8D93C95EC6AFF008DBC0FA778E74C8ED6F9E489E162F14D1FDE535E8C24A4AE8F83C451951AB2A72E87C5E0E0835D1F84BC52DE1CBC9926805D69D769E5DDDB31FBEBEA3D1876AF69FF00866FD249E75CBDFF00BE57FC2947ECDDA477D6EFBFEF94FF000AA3121F0B789EFAD2CD63F0A78834DD42C3AC763AACDE4CF00FEEE4F047BE6AC788BC53AC5C5A14F116BFA468FA7953E6C3A7DC7DA2E261E8BB7819A6FF00C3386959F975CBE1FF00014FF0A5FF008670D289F9B5DBEF6F957FC2803C73C5FE294D74DBD9585B9B4D22C8116F01392C4F577FF68D72814935F445CFECF1A1DA40F3CFAFDEA46832CC5538FD2B287C1DF05F51E2E978FF0073FC293696ECB8539CFE14D87ECDDC6ABAE67BC31FF335F42B32A2963C01D6BC9FC243C19F0E01B7B3BF7BAB8BD70B2CE79C01D338E839AEA7C73E278349F0CC92C132B4D72BB212A7D7BD4BA91B377368612B4A71838B5CC78FF8C3521AA78BB50B91F32193629F6518A67856CCDFF8A74EB60A594CEA5BE80E4D63139049CE5B924F73D6BD2FE11690D3DFDCEAB22FC910F2E3247F177AF3A9A752A1F778C9C7098071ECACBF23D907DD14B494BDABD43F3B0A434B450065EB5A5C3ACE9371633AE56552071D0F6AF9B355D3A7D23539EC2E14ACB13118C751D8D7D498F7AE13E21F833FB76D3EDF648A350847FDFC5F435CF88A5CEAEB73DBC9731FAAD5E49FC32FC19E3DE1FD76EBC3FAB457F6D9CA9C4899E1D7B8AFA1F41D76CB5FD363BCB39432B0F997F891BB822BE66923786468E452AEA70CA7A835A9A0F88750F0F5F2DC58CD8048F32227E571EF5CB46B3A7A3D8F7F35CAE38C8FB5A7F17E67D374B5C57873E22E93AD048A6916DAE8F58DCF04FB1AEC91D5C6E560C0F70735E8464A4AE8F8AAD42A51972D45664945145519104F1A4D1347220646186523208AF10F1DF805F4595F52D3A32F60E4978D79311FF0AF72760AA4B1000AE43C51E38D0F48B792099D2EA6652BE427CDF9D655A3194753D1CB2BD7A5597B257BEEBB9F3F8031C0C0F7A9E5BCB9B88A38A699DE38862357390A3D052DDCD15C5E4B3450AC48EC59631D101ED50AA9760AA09627000AF336D11FA17BB28A94959AFC096CECE7D46F20B4823DF2CCC1100F7AFA43C33A247A068B6F6318C145CB9FEF377AE47E1C7828E9710D5B518C7DB245FDD21EB1AFF89AF47EE79AEFC3D2E5577B9F139DE62B133F674DFBABF163E8A28AE93C20A28A2800A6302781DE9F450079F78D7E1E41AEABDEE9FB60D40727FBB27D7DEBC5AFB4CBCD2AEDADAFE19209138DAE383EF9EF5F539CE7AD65EB3A069BAEDB982FED925047071C8FA1AE7AB414F55B9EDE5F9D54C3254EA7BD1FC51F31E7B8C01EBD6B674FF16EBDA520167AA4C231FC0E7701F9D76FABFC219919DB48BA0C9D44529E47B66B8ABEF07F8834E72B3E9770547F1A2961FA572BA7520CFA6863B038B8D9B4FC99BD07C5AF12A280EB65201DDA1604FF00E3D4E9BE2DF895FE58E3B18C1EE23627FF0042AE21ED2746DAD6F2AB0EB9422945ADC370B0484FA042697B5ABDC5F50CBF7B44D8D47C65AFEA995B9D4A5C7758FE55FD056172D9E73CE49EE7F3AD6B1F09EBDA810B6FA5DD3063F7990A8FCCD76DA47C1FBA9CAB6AF74B1275F2E2E4FE742A7526F51CF1981C247DD69792FF008079D5A59DCEA37020B581E699BA222E6BD87C11F0E23D24C7A96AC165BCC65611CAC67FA9AEBF44F0CE97E1F8045636EA84632E4658FD4D6CF383CD7552C3A8BBBDCF9BCC73BA9884E9D3D23F8B140A75145749E10514514005145140051451400521A5A280128DA2968A0089A089F968918FBA8348B0440E562407D428A9A8A2C3E663368FCA9D8CD2D140828A28A0028A28A0028A28A00FFFD9, 10),
	(5, 555, 'Prueba con IVA', 1000, 1200, 1300, 1400, NULL, 100, NULL, 'No', _binary 0xFFD8FFE000104A46494600010101006000600000FFDB004300080606070605080707070909080A0C140D0C0B0B0C1912130F141D1A1F1E1D1A1C1C20242E2720222C231C1C2837292C30313434341F27393D38323C2E333432FFDB0043010909090C0B0C180D0D1832211C213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232FFC00011080090009003012200021101031101FFC4001F0000010501010101010100000000000000000102030405060708090A0BFFC400B5100002010303020403050504040000017D01020300041105122131410613516107227114328191A1082342B1C11552D1F02433627282090A161718191A25262728292A3435363738393A434445464748494A535455565758595A636465666768696A737475767778797A838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE1E2E3E4E5E6E7E8E9EAF1F2F3F4F5F6F7F8F9FAFFC4001F0100030101010101010101010000000000000102030405060708090A0BFFC400B51100020102040403040705040400010277000102031104052131061241510761711322328108144291A1B1C109233352F0156272D10A162434E125F11718191A262728292A35363738393A434445464748494A535455565758595A636465666768696A737475767778797A82838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE2E3E4E5E6E7E8E9EAF2F3F4F5F6F7F8F9FAFFDA000C03010002110311003F00F7FA28A2800A28A2800A28A2800A2933413400B4530BAAF561481C1E4118A02C4945341E6973400B451450014514500145145001451450014945349209EB8140064E6A9EA3AAD9E996C67BCB848631D4B1AE67C5DE39B5F0F446DE0DB35F37DD4CF0BEEC6BC6B55D66FB57BB7B8BCB969598FDDCFCABF41DAB9EAE2230D16E7B796E495B17EFCBDD8FE7E87A4EAFF16624668B4BB632E3FE5AC9C0FCAB8EBFF1EF88AF9DB17ED029FE1886DFD6B99DE7D6AF5968DA9EA447D8EC6E261EA138FCFA5713AD566F43EAE965580C246F34BD58926B1AA4A732EA576C7AE5A5634B1EB1A9C4731EA576A7FD999856E43F0EBC513F3F635894F40F2AFF004A27F871E26847FC7A4527B2483FAE297256ECCAFAD65BF0F344AF63E3AF10E9E46DD42495075597E7CFE26BB1D27E2CE488F54B32BDBCC8BB7BE2BCF2FB41D5B4DC8BBD3E7880EE578FCC66B3C9279CD355AAC1EA2AB96603171BC52F55FF0000FA574CD66C7578165B2B95947700F23EB5A0A4E4F15F3269DAA5EE9372B716570F148A73C1E0FD457B1F83FC7D6FADECB4BE6582F80E07F0C9EE2BB28E2233D1EE7CAE659155C25E74FDE8FE28EEE8A686C8C8CD3ABA4F0828A28A0028A2909C50034F06B8BF1DF8BE3F0ED87936EDBAFE553B17FB83BB5751AAEA10E97A74D7B3B6D8E152C4D7CE5ACEAB3EB1AACF7B70E59A46E07A2F615CF88ABC91B2DCF6F24CB7EB7579E7F0C7F1F22ACF712DD4CD34EECF239C9663C9A48A3F36644DC177B01B9BA0CF7A444926CEC567DA32C546768F534C24718FD6BCCDF567DFAB25C903DA7C31F0F349B6862B9BB0B7B3101867941F4AEEE28A18936C68AA070028C578B7813C73268B32D86A12B3D8B9C2BB72633FE15ED104C9344B244EAE8C32AC0E41FC6BD5A12838FBA7E759BD2C552AEFDBB6EFB3E84D8A5C53437AE052EE07A104FD6B63CA229218E552B222BA9EA08CD71BE20F871A5EAAAF2DAC62D6E4F3B907CA4FB8AEDFDB146062A6508C9599B50C455A12E6A7268F9AB5AD0AFF0042BB36F79115E485703E57FA5674523C322C91B1575395607906BE91D6F43B2D774E92D2EE30CA4655BBA9EC41AF00F1068973E1FD565B3B852541F924C70C3B1AF3ABD0F66EEB63EE729CDE38D8FB2AAAD2FCCF58F87DE301AD5A9B0BD900BE84719FF968BEB5DDE7AF15F3069D7D71A66A115F40FB248886523B8F435F46683ABC5AE68D6F7D0918917E61E87B8AEAC3D5E7567B9F3D9E65AB0B57DA53F865F8335A8A4072296BA4F04290D2D213C5007967C5CD61A3B6B6D2637C194EF900F41D2BC9DBD6BA5F1EEA2D7FE31BD3BB290BF929EDB783FAD6468763FDA7AD595913C4F3053C76EFFA66BCAACDCEAD8FD132BA51C26014DF6BB3D6FE1D78622B4D03ED77310696ED72430E8BD85646B3F0B611A94B7305F456B62FF31121FB87D3E95EA7044B0431C6A0008A14015E27FB465D4D1E93A3DB248C21925767407824018CFE75E87B1838A8B47C63CD3131AF2AB0959B25FF00840348CE3FE127B318EBF38ADAB8D6A1F00F80B51963D6A0BFB84FF8F740C0ECCF0001FAD7CAF91EFEF56B4FB0BCD52FA2B3B181A7B890ED44419C9A71A5083BA33C466188C44796ACAE8F64D0F42D7FC59A6AEB1A8F8F56C65B825C43E7741F4ED52EADE16D6F40D3E5D534FF00882B7535B0DE22337DEC7F3AE460F879A458B793AE6BB23DF000B59E996E6774F666E80D3E6F87FA0DDB795A4EBB736D78DFEAEDF56B530F987D0374FD2B4388F75F87DE3FB4F10F84EDEF352BCB786F5098E65770B923BD3AE7E255A41E3287C3E2D95D255DEB76274F2F6E393D7F4AF93F54D26F745D425B2D420686E226C32B0E3EA3D45747A2E9BE05B8D2125D5B5BD4ADEFC83BA28A15283D3A8A00FB060BA82EE3F32DE54950F4646C8FD2B95F883E1D1AD682F2C4B9BAB71BE323BFB57997ECF172FF00DA9AFD9C5348F66AAAF186E9F788CE3B1C57BE491891195BA11835328A92B335A15A546AC6A47747CAFCECC37519E3FA57A6FC24D5CA4F73A53BFCADF3C60FAF7AE27C57A79D33C55A85A01845937271D88C8A7784AFDF4FF14E9D329C667557FF0074F06BCCA778553F41C7C238CC039775747D24297B522FDDA5AF54FCE4298FF71A9F4C7E5714023E63D664F375BD41CE72D7321FCD8D6F7C37B75B8F1CD91C7FAA577FFC771FD6B9ED610C5ADEA11B754B9901FF00BE8D745F0D6E043E37B41919923741F5C67FA57950FE2FCCFD1714FF00E135F2FF0029EFC0E457847ED25FF1E7A1FF00BF2FF215EEEBF7457847ED25FF001E9A1FFBF2FF00215EA9F9D1F3D8E4D7AAFC3FD3A6B0F0DC77767F26ADAEDE1B0B390F58A1500C8E3DF923F0AF291EFD2BD8FC15A9C31785FC2BAA32931685AB4D05D01FDD9802AE7D0678FC2803DF3C39E15D37C376096D65027998CC9332E5E46F526A7D73C39A5F88ACA4B5D42DA39158603EDF994FA83D8D69C52A4B1AC91B868D9772B03904539982A924E001924D007CCBE3BD1659FC39AA5B5E12FA9F86A640939E5A7B590E067FDD38E6BC7F18279FCABDDFC71ABC17163E35D6E323C8B9F274CB63DA560D9723E8335E0E3AD007BA7ECDBCEABAE7FD718FFF004235F4557CEBFB35FF00C85B5CFF00AE11FF00E846BE8AA00F09F8AF0F97E32F300C7996A84FB9CB0AE36D5CADE5BB0E0AB83FAD763F1627DFE3258C1188ED533F8B3571B6C0C9790AFAB803F3AF2EAFF15D8FD172FF00F9172E6FE53EA2B76DD6F1B1EACA0FE9535436EA56D6253D4281FA54D5EA1F9DCBE262D2638A5A2811F3A78F2C3FB3FC657E9B48595FCD5F7DDCD666817FFD99AF69F7838F2A6058FB743FCEBD17E2FE944ADAEA88BD098A42074F4CD7946EF9BD88C7D2BCCAAB92A5CFD0B2DAB1C560545F6B33EAA8A55922475E5580208AF0CFDA4BFE3CF433DB7C9FC8577BF0D3C42357D012D267CDD5A8D8D93C95EC6AFF008DBC0FA778E74C8ED6F9E489E162F14D1FDE535E8C24A4AE8F83C451951AB2A72E87C5E0E0835D1F84BC52DE1CBC9926805D69D769E5DDDB31FBEBEA3D1876AF69FF00866FD249E75CBDFF00BE57FC2947ECDDA477D6EFBFEF94FF000AA3121F0B789EFAD2CD63F0A78834DD42C3AC763AACDE4CF00FEEE4F047BE6AC788BC53AC5C5A14F116BFA468FA7953E6C3A7DC7DA2E261E8BB7819A6FF00C3386959F975CBE1FF00014FF0A5FF008670D289F9B5DBEF6F957FC2803C73C5FE294D74DBD9585B9B4D22C8116F01392C4F577FF68D72814935F445CFECF1A1DA40F3CFAFDEA46832CC5538FD2B287C1DF05F51E2E978FF0073FC293696ECB8539CFE14D87ECDDC6ABAE67BC31FF335F42B32A2963C01D6BC9FC243C19F0E01B7B3BF7BAB8BD70B2CE79C01D338E839AEA7C73E278349F0CC92C132B4D72BB212A7D7BD4BA91B377368612B4A71838B5CC78FF8C3521AA78BB50B91F32193629F6518A67856CCDFF8A74EB60A594CEA5BE80E4D63139049CE5B924F73D6BD2FE11690D3DFDCEAB22FC910F2E3247F177AF3A9A752A1F778C9C7098071ECACBF23D907DD14B494BDABD43F3B0A434B450065EB5A5C3ACE9371633AE56552071D0F6AF9B355D3A7D23539EC2E14ACB13118C751D8D7D498F7AE13E21F833FB76D3EDF648A350847FDFC5F435CF88A5CEAEB73DBC9731FAAD5E49FC32FC19E3DE1FD76EBC3FAB457F6D9CA9C4899E1D7B8AFA1F41D76CB5FD363BCB39432B0F997F891BB822BE66923786468E452AEA70CA7A835A9A0F88750F0F5F2DC58CD8048F32227E571EF5CB46B3A7A3D8F7F35CAE38C8FB5A7F17E67D374B5C57873E22E93AD048A6916DAE8F58DCF04FB1AEC91D5C6E560C0F70735E8464A4AE8F8AAD42A51972D45664945145519104F1A4D1347220646186523208AF10F1DF805F4595F52D3A32F60E4978D79311FF0AF72760AA4B1000AE43C51E38D0F48B792099D2EA6652BE427CDF9D655A3194753D1CB2BD7A5597B257BEEBB9F3F8031C0C0F7A9E5BCB9B88A38A699DE38862357390A3D052DDCD15C5E4B3450AC48EC59631D101ED50AA9760AA09627000AF336D11FA17BB28A94959AFC096CECE7D46F20B4823DF2CCC1100F7AFA43C33A247A068B6F6318C145CB9FEF377AE47E1C7828E9710D5B518C7DB245FDD21EB1AFF89AF47EE79AEFC3D2E5577B9F139DE62B133F674DFBABF163E8A28AE93C20A28A2800A6302781DE9F450079F78D7E1E41AEABDEE9FB60D40727FBB27D7DEBC5AFB4CBCD2AEDADAFE19209138DAE383EF9EF5F539CE7AD65EB3A069BAEDB982FED925047071C8FA1AE7AB414F55B9EDE5F9D54C3254EA7BD1FC51F31E7B8C01EBD6B674FF16EBDA520167AA4C231FC0E7701F9D76FABFC219919DB48BA0C9D44529E47B66B8ABEF07F8834E72B3E9770547F1A2961FA572BA7520CFA6863B038B8D9B4FC99BD07C5AF12A280EB65201DDA1604FF00E3D4E9BE2DF895FE58E3B18C1EE23627FF0042AE21ED2746DAD6F2AB0EB9422945ADC370B0484FA042697B5ABDC5F50CBF7B44D8D47C65AFEA995B9D4A5C7758FE55FD056172D9E73CE49EE7F3AD6B1F09EBDA810B6FA5DD3063F7990A8FCCD76DA47C1FBA9CAB6AF74B1275F2E2E4FE742A7526F51CF1981C247DD69792FF008079D5A59DCEA37020B581E699BA222E6BD87C11F0E23D24C7A96AC165BCC65611CAC67FA9AEBF44F0CE97E1F8045636EA84632E4658FD4D6CF383CD7552C3A8BBBDCF9BCC73BA9884E9D3D23F8B140A75145749E10514514005145140051451400521A5A280128DA2968A0089A089F968918FBA8348B0440E562407D428A9A8A2C3E663368FCA9D8CD2D140828A28A0028A28A0028A28A00FFFD9, 10),
	(6, 2, 'aa', 1, 1, 1, 1, NULL, 0, NULL, 'No', _binary 0xFFD8FFE000104A46494600010101006000600000FFDB004300080606070605080707070909080A0C140D0C0B0B0C1912130F141D1A1F1E1D1A1C1C20242E2720222C231C1C2837292C30313434341F27393D38323C2E333432FFDB0043010909090C0B0C180D0D1832211C213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232FFC00011080090009003012200021101031101FFC4001F0000010501010101010100000000000000000102030405060708090A0BFFC400B5100002010303020403050504040000017D01020300041105122131410613516107227114328191A1082342B1C11552D1F02433627282090A161718191A25262728292A3435363738393A434445464748494A535455565758595A636465666768696A737475767778797A838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE1E2E3E4E5E6E7E8E9EAF1F2F3F4F5F6F7F8F9FAFFC4001F0100030101010101010101010000000000000102030405060708090A0BFFC400B51100020102040403040705040400010277000102031104052131061241510761711322328108144291A1B1C109233352F0156272D10A162434E125F11718191A262728292A35363738393A434445464748494A535455565758595A636465666768696A737475767778797A82838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE2E3E4E5E6E7E8E9EAF2F3F4F5F6F7F8F9FAFFDA000C03010002110311003F00F7FA28A2800A28A2800A28A2800A2933413400B4530C8ABD58520914F2186281D992514D079A5CD02168A28A0028A28A0028A28A0028A28A002928A692413D702801327354F51D56CF4CB633DE4E90C63A9635CCF8B7C736BE1E88DBC1B66BE6FBA99E17DD8D78DEABACDF6AD76F717972D2B31FBB9F957E83B573D5C4461A2DCF6F2DC92B62FDF97BB1FCFD0F48D5FE2C448CD16976C65C7FCB59381F9571D7FE3CF10DF3B62FDA053FC310DBFAD735BCFAD5EB2D1B53D488FB1D8DC4C3D4271F9F4AE275AACDE87D552CAF01848DE697AB124D635494E65D4AED8F5CB4AC6963D635388E63D4AED4FF00B3330ADB87E1DF8A27E7EC6B129E81E55FE94B3FC39F13423FE3D2293D9241FD714B96B76657D672DF86F12B58F8E7C41A791B75092541D565F9F3F89AEC749F8B19223D52CCAF6F322EDEF8AF3DBED0756D3722EF4F9E203B95E3F319ACF249E734D56AB07A8AAE5980C5C6F14BD57FC03E94D3359B1D5E0596CAE5651DC03C8FAD6829393C57CCBA76A97BA4DCADC595C3C5229CF0783F515EC5E10F1F5BEB5B2D2F9960BE0381FC327B8AECA3888CF47B9F2D99647570979D3F7A3F8A3BCA29A1B232334EAE93C20A28A2800A28A4271400C3C1AE2FC77E2E8FC3D61E4DBB6EBF954EC5FEE0EED5D46ABA843A5E9D35ECEDB63854B135F39EB3AACFABEAB3DEDC396691B81E8BD8573E22AF246CB73DBC932DFADD5E79FC31FC7C8AB3DC4B75334D3BB3C8E72598F269228FCD9913705DEC06E6E833DE911249B3B159F68CB1519DA3D4D3091C63F5AF377D59F7CAC97240F68F0C7C3DD26DE18AE6EC2DECC40619E507D2BBA8A28225DB1A2A81C00A315E31E04F1C49A2CCB61A84ACF62E70AEDC98CFF857B3DBCC9344B244EAE8C32AC0E41FC6BD4A12838FBA7E779BD2C552AEFDB36EFB3E84F8A5C53437AE052EE07A104FD6B63CA219218E552B246AEA7A82335C6EBFF0E34BD515E5B5416B7279DC83E527DC576FED8A30315328464ACCDA8622AD0973539347CD7AD6877FA1DD9B7BC88AF242B81F2BFD2B3A291E191648D8ABA9CAB03C835F486B7A2596BBA74969771865232ADDD4F620D780EBFA25CE81AA4B6770A4A83F2498E187635E757A1ECDDD6C7DC6559BC71B1F65555A5F99EAFF000FBC60359B53617B2017D08E33FF002D17D6BBBCF278AF9874EBEB8D33508AFA07D924443291DC7A1AFA2F41D5E2D7346B7BE848C48BF30F43DC57561EAF3AB3DCF9FCF32D585ABED29FC32FC19AF45203914B5D2782148696909E2803CAFE2DEB0D1DBDB6931BE0CA77C807A0E95E50DEB5D2F8F3516BFF00185E9DD9485FC94F6DBC1FD6B2343B1FED3D6ACAC89E279829E3B77FD335E5566E756C7E8796528E1300A7E5767ACFC3BF0C456BA0FDAEE620D2DD2E4861D17B0AC9D67E16C235296E60BE8AD6C5FE62243F70FA7D2BD4EDE258208E35000450A00AF14FDA2EEA68F49D1ED924610C92BB3A03C1200C67F3AF43D8C1C545A3E35E67888D795584ACD927FC203A4671FF00093598C75F9C56D5C6B30F807C07A8CD1EB305FDC27FC7BA06076678000FD6BE58C8F7F7AB7A7D85E6A97D159D8C0D3DC4876A220CE4D38D2841DD19E231F5F111E5AB2BA3D8F43D0B5FF1669ABAC6A3E3D5B196E09710F9DD07D3B54BAB785B5BD034F9754D3FE20ADD4D6C37888CDF7B1FCEB9183E1EE9162DE4EB9AEC8F7C002D67A65B99DD3D99BA034F9BE1FE8376DE5693AEDCDB5E37FABB7D5AD4C3E61F40DD3F4AD0E23DD7E1F78FED3C43E13B7BCD4AF2DE1BD4263995DC2E48EF4EB9F89369078CA1F0F8B65749577ADD89D3CBDB8E4F5FD2BE4FD5349BDD175096CB5081A1B889B0CAC38FA8F515D268BA6F8167D2125D5B5BD4ADEFC83BA28A15283D3A8A00FAFE0B982EE3F32DE54950F4646C8FD2B95F883E1E1AD684D2C4B9BAB71BE323BFB5799FECF372FF00DA9AFD9C5348F66AAAF186E9F788CE3B1C57BDC918923656E8460D4CA2A4ACCD6856951AB1A91DD1F2C73B30DD4678FE95E9BF09357293DCE94EFF002B7CF183EBDEB89F15E9E74CF156A168061164DC9C7623229DE13BF7D3FC51A7CCA7199D55FF00DD3C1AF329DE154FD031F08E3300E5DD5D1F490A5ED4D5FBB4EAF54FCE829927DC6A7D31F942281ADCF98F5993CDD6F50739CB5CC87F3635BBF0E2DD6E3C716471FEA95DFF00F1DC7F5AE7F584316B7A846DD52E6407FEFA35D17C36B810F8DAD0646648DD07D719FE95E543F8BF33F43C4BFF0084D7CBFCA7BF03915E11FB497FC79E87FEFCBFC857BBAFDD15E11FB497FC7A687FEFCBFC857AA7E767CF63935EABF0FF004E9AC3C371DDD9FC9AB6BB786C2CE43D6285403238F7E48FC2BCA47BF4AF63F05EA70C5E17F0AEA8CA4C5A16AD3417407F76600AB9F419E3F0A00F7CF0E78574DF0DD825B59409E663324CCB9791BD49A9B5CF0E697E22B292D750B68E456180FB7E653EA0F635A714A92C6B246E1A365DCAC0E4114F660AA4938006493401F32F8EF45967F0E6A96D784BEA7E1A99024E7969ED643819FF0074E39AF1FC609E7F2AF77F1C6AF05C58F8D75B8C8F22E7C9D32D8F6958365C8FA0CD7838EB401EE9FB36F3AAEB9FF5C63FFD08D7D155F3AFECD7FF00216D73FEB847FF00A11AFA2A803C23E2B43E5F8CBCC031E65B213EE72C2B8EB572B796EC382AE0FEB5D87C579F7F8C84608C476A99FC59AB8EB6064BC857D5C01F9D79957F8AEC7E8997FF00C8B9737F29F50DBB6EB78D8F56507F4A9EA0B752B6B129EA140FD2A7AF4CFCF25F1316931C52D1408F9D3C7761FD9FE31BE4DA42CAFE6AFBEEE6B3340BFF00ECCD7B4FBC1C795302C7DBA1FE75E89F17B4B256D75445E84C52103A7A66BCA777CDEC463E95E6555C952E7E8396D58E2B02A2FB599F54C52AC9123AF2AC01045786FED25FF1E7A19EDBE4FE42BBCF869E201ABE82B6933E6EAD46C6C9E4AF635A1E35F03E9DE38D363B5BE79227858BC5347F794D7A309292BA3E131146546ACA9CBA1F1783820D749E12F1437872F2649A0175A75DA797776CC7EFAFA8F461DABDA3FE19BF49279D72F7FEF95FF0A51FB37691DF5BBEFF00BE53FC2A8C487C2DE27BEB4B358FC29E20D3750B0EB1D8EAB37933C03FBB93C11EF9AB1E21F14EB1716853C45AFE91A3E9E54F9B0E9F71F68B8987A2EDE0669BFF000CE1A567E5D72F87FC053FC297FE19C74A27E6D76FBDBE55FF000A00F1DF17F8A535C36F65616E6D348B2045BC04E4B13D5DFF00DA35C98524D7D1173FB3CE876903CF3EBF7A91A0CB3154E3F4ACA1F07BC17D478B65E3FDCFF0A4DA5BB2E14E73F85361FB37F1AAEB99EF0C7FCCD7D08CCB1A963C01D6BCA3C243C1BF0E41B7B3BF7BAB8BD70B2CE79C01D338E839AEA3C73E27834AF0D492C132B4D70BB212A7D7BD4BA91B377368612B4A71838B5CC79078C3521AA78BB50B91F32193629F6518A6785ACCDFF8A34EB60A594CEA5BE80E4D63139049CE5B924F73D6BD2FE11E90D3DFDCEAB22FC910F2E3247F177AF3A9A752A1F758C9C7098071ECACBF23D917EE8A5A4A5ED5EA1F9E0521A5A28032B5AD2E1D6749B8B19D72B2A9038E87B57CDBAAE9D3E91A9CF6170A5658988C63A8EC6BEA3C7BD709F10FC1BFDB969F6FB2451A8423FEFE2FA1AE7C452E7575B9EDE4B98FD56AF24FE197E0CF1FF0FEBB75E1FD5A2BFB6CE54E244CF0EBDC57D0DA0EBB65AFE9B1DDD9CA19587CCBFC48DDC115F33C91BC3234722957538653D41AD4D07C43A8787EF96E2C66C024799113F2B8F7AE5A359D3D1EC7BD9AE571C5C7DAD3F8BF33E9BA5AE27C39F1174AD6B645348B6D747AC6E7827D8D7668EAE372B0607B839AF4232525747C5D6A1528CB96A2B324A28A2A8C8AF3C69344D1C88191861948C822BC47C77E027D1657D4B4E8CBD83925E35E4C47FC2BDC5D82A92C4002B8FF001478DF44D26092099D2E66652BE427CDF9D655A3194753D1CB6B57A5597B257BEEBB9E0200C70303DEA796F2E6E228E29A6778E2188D5CE428F414B7734571792CD142B123B1658C74407B542AA5D82A82589C002BCCDB447E83EE38A94959AFC096CECE7D46F20B4823DF2CCC1100F7AFA3FC33A247A068B6F6318C145CB9FEF377AE47E1CF828E9710D5B518C7DB245FDD21EB1AFF0089AF47C7CC79AEFC3D2E5577B9F159DE62B113F674DFBABF164945145749E1051451400531813C0EF4FA2803CF7C69F0F20D755EF74FDB06A0393FDD93EBEF5E2F7DA65E69576D6D7F0C90489C6D71C1F7CF7AFA99B39EB597ACE81A6EBB6E60BFB649411C1C723E86B9EAD053D56E7B797E75530C953A9EF47F147CC99EE3007AF5AD9D3FC5BAF6948059EA9308C7F039DC07E75DBEAFF08664676D22E83275114A791ED9AE2AFBC21E20D39CACFA5DC151FC68A587E95CAE9D4833E9618DC0E2E366D3F266EC3F167C4A8A038B2900EED0B027FF001EA74DF16BC4AFF2C696480F711B13FF00A15712F693A36D6B7955875CA114A2D6E1B8582427D02134BDAD5EE2FA8E5FBDA26C6A3E32D7F54CADCEA52E3BAC7F2AFE82B0B96CF39E724F73F9D6B58F8535ED4085B7D2EE9831FBCC8547E66BB6D23E0FDD4E55B57BA5893AF971727F3A153A937A8E78CC0E163EEB4BC97FC03CEAD2CEE751B8105AC0F34CDD111735EC1E08F8711E9263D4B560B2DE632B08E5633FD4D75FA278674CF0FC022B1B75423197232C7EA6B679C1E6BAA961D45DDEE7CE6639DD4C4274E9E91FC58E029D4515D27841451450014514500145145001486968A004A368F4A5A2802168227E5A246FAA8348B0440E562407D428A9E8A562B998CDA3F2A76334B4532428A28A0028A28A0028A28A00FFD9, 10);
/*!40000 ALTER TABLE `producto` ENABLE KEYS */;

-- Volcando estructura para tabla controlstock.proveedor
CREATE TABLE IF NOT EXISTS `proveedor` (
  `RUC` bigint(20) unsigned NOT NULL,
  `Nombre` char(20) CHARACTER SET latin1 NOT NULL,
  `Telefono` char(15) CHARACTER SET latin1 DEFAULT NULL,
  `Direccion` char(20) CHARACTER SET latin1 DEFAULT NULL,
  PRIMARY KEY (`RUC`),
  UNIQUE KEY `Nombre` (`Nombre`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- Volcando datos para la tabla controlstock.proveedor: ~3 rows (aproximadamente)
/*!40000 ALTER TABLE `proveedor` DISABLE KEYS */;
INSERT INTO `proveedor` (`RUC`, `Nombre`, `Telefono`, `Direccion`) VALUES
	(1, 'Mi Proveedor', '', ''),
	(2, 'Otro Proveedor', '', ''),
	(555, 'Prov', '', '');
/*!40000 ALTER TABLE `proveedor` ENABLE KEYS */;

-- Volcando estructura para tabla controlstock.recibocobrocuenta
CREATE TABLE IF NOT EXISTS `recibocobrocuenta` (
  `idRecibo` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `idVentaFK` int(10) unsigned NOT NULL,
  `Fecha` datetime NOT NULL,
  `Importe` int(10) unsigned NOT NULL,
  PRIMARY KEY (`idRecibo`),
  KEY `FK_recibocobrocuenta_venta` (`idVentaFK`),
  CONSTRAINT `FK_recibocobrocuenta_venta` FOREIGN KEY (`idVentaFK`) REFERENCES `venta` (`idVenta`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla controlstock.recibocobrocuenta: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `recibocobrocuenta` DISABLE KEYS */;
/*!40000 ALTER TABLE `recibocobrocuenta` ENABLE KEYS */;

-- Volcando estructura para tabla controlstock.recibopagocuenta
CREATE TABLE IF NOT EXISTS `recibopagocuenta` (
  `idRecibo` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `idCompraFk` int(10) unsigned NOT NULL,
  `Fecha` datetime NOT NULL,
  `Importe` int(10) unsigned NOT NULL,
  PRIMARY KEY (`idRecibo`),
  KEY `FK_recibopagocuenta_compra` (`idCompraFk`),
  CONSTRAINT `FK_recibopagocuenta_compra` FOREIGN KEY (`idCompraFk`) REFERENCES `compra` (`idCompra`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla controlstock.recibopagocuenta: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `recibopagocuenta` DISABLE KEYS */;
/*!40000 ALTER TABLE `recibopagocuenta` ENABLE KEYS */;

-- Volcando estructura para tabla controlstock.serviciohabitacion
CREATE TABLE IF NOT EXISTS `serviciohabitacion` (
  `idServHab` tinyint(3) unsigned NOT NULL AUTO_INCREMENT,
  `Descripcion` char(30) COLLATE utf8_spanish_ci NOT NULL,
  `Tiempo` smallint(4) DEFAULT NULL,
  `HraEntrada` time DEFAULT NULL,
  `HraSalida` time DEFAULT NULL,
  PRIMARY KEY (`idServHab`),
  UNIQUE KEY `Descripcion` (`Descripcion`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- Volcando datos para la tabla controlstock.serviciohabitacion: ~3 rows (aproximadamente)
/*!40000 ALTER TABLE `serviciohabitacion` DISABLE KEYS */;
INSERT INTO `serviciohabitacion` (`idServHab`, `Descripcion`, `Tiempo`, `HraEntrada`, `HraSalida`) VALUES
	(1, 'x 1 Hora', 60, NULL, NULL),
	(2, 'Adicional c/ 30min', 30, NULL, NULL),
	(3, 'x Noche', NULL, '23:00:00', '09:00:00');
/*!40000 ALTER TABLE `serviciohabitacion` ENABLE KEYS */;

-- Volcando estructura para tabla controlstock.usuario
CREATE TABLE IF NOT EXISTS `usuario` (
  `idUsuario` int(10) NOT NULL AUTO_INCREMENT,
  `Usuario` char(20) COLLATE utf8_spanish_ci NOT NULL,
  `Pass` char(20) COLLATE utf8_spanish_ci NOT NULL,
  `idPrivilegioFK` int(10) unsigned NOT NULL,
  `idEmpleadoFK` int(10) unsigned NOT NULL,
  PRIMARY KEY (`idUsuario`),
  UNIQUE KEY `Usuario` (`Usuario`),
  UNIQUE KEY `idEmpleadoFK` (`idEmpleadoFK`),
  KEY `FK_usuario_privilegio` (`idPrivilegioFK`),
  KEY `FK_usuario_empleado` (`idEmpleadoFK`),
  CONSTRAINT `FK_usuario_empleado` FOREIGN KEY (`idEmpleadoFK`) REFERENCES `empleado` (`CI`) ON UPDATE CASCADE,
  CONSTRAINT `FK_usuario_privilegio` FOREIGN KEY (`idPrivilegioFK`) REFERENCES `privilegio` (`idPrivilegio`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=2019 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- Volcando datos para la tabla controlstock.usuario: ~3 rows (aproximadamente)
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` (`idUsuario`, `Usuario`, `Pass`, `idPrivilegioFK`, `idEmpleadoFK`) VALUES
	(1, 'admin', '12233445', 1, 4346326),
	(6, 'David', '1223', 2, 112233),
	(2018, 'Tori', '123', 1, 4346322);
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;

-- Volcando estructura para tabla controlstock.venta
CREATE TABLE IF NOT EXISTS `venta` (
  `idVenta` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `idEmpleadoFK` int(10) unsigned NOT NULL,
  `idClienteFK` char(15) NOT NULL DEFAULT '1',
  `Fecha` datetime NOT NULL,
  `Cancelado` enum('Si','No') NOT NULL,
  `Entregado` int(10) unsigned DEFAULT NULL,
  `Vto` date DEFAULT NULL,
  `PagoComision` enum('Si','No') NOT NULL DEFAULT 'No',
  PRIMARY KEY (`idVenta`),
  KEY `FK_venta_empleado` (`idEmpleadoFK`),
  KEY `FK_venta_cliente` (`idClienteFK`),
  KEY `Cancelado` (`Cancelado`),
  CONSTRAINT `FK_venta_cliente` FOREIGN KEY (`idClienteFK`) REFERENCES `cliente` (`CI`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `FK_venta_empleado` FOREIGN KEY (`idEmpleadoFK`) REFERENCES `empleado` (`CI`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=67 DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla controlstock.venta: ~65 rows (aproximadamente)
/*!40000 ALTER TABLE `venta` DISABLE KEYS */;
INSERT INTO `venta` (`idVenta`, `idEmpleadoFK`, `idClienteFK`, `Fecha`, `Cancelado`, `Entregado`, `Vto`, `PagoComision`) VALUES
	(1, 4346326, '1', '2018-01-10 23:56:55', 'Si', 0, '2018-01-10', 'No'),
	(2, 4346326, '1', '2018-01-11 08:31:46', 'Si', 0, '2018-01-11', 'No'),
	(3, 4346326, '1', '2018-01-11 08:32:07', 'Si', 0, '2018-01-11', 'No'),
	(4, 4346326, '1', '2018-01-11 09:58:35', 'Si', 0, '2018-01-11', 'No'),
	(5, 4346326, '1', '2018-01-11 11:13:38', 'Si', 0, '2018-01-11', 'No'),
	(6, 4346326, '1', '2018-01-11 11:13:49', 'Si', 0, '2018-01-11', 'No'),
	(8, 4346326, '1', '2018-01-12 23:10:19', 'Si', 0, '2018-01-12', 'No'),
	(9, 4346326, '1', '2018-01-20 19:46:18', 'Si', 0, '2018-01-20', 'No'),
	(10, 4346326, '1', '2018-01-20 23:01:28', 'Si', 0, '2018-01-20', 'No'),
	(11, 4346326, '1', '2018-01-20 23:13:23', 'Si', 0, '2018-01-20', 'No'),
	(12, 4346326, '1', '2018-01-21 00:42:22', 'Si', 0, '2018-01-21', 'No'),
	(13, 4346326, '1', '2018-01-21 00:45:38', 'Si', 0, '2018-01-21', 'No'),
	(14, 4346326, '1', '2018-01-21 00:45:48', 'Si', 0, '2018-01-21', 'No'),
	(15, 4346326, '1', '2018-01-21 00:45:58', 'Si', 0, '2018-01-21', 'No'),
	(16, 4346326, '1', '2018-01-21 19:34:19', 'Si', 0, '2018-01-21', 'No'),
	(17, 4346326, '1', '2018-01-21 21:38:36', 'Si', 0, '2018-01-21', 'No'),
	(18, 4346326, '1', '2018-01-21 22:10:52', 'Si', 0, '2018-01-21', 'No'),
	(19, 4346326, '1', '2018-01-21 22:14:40', 'Si', 0, '2018-01-21', 'No'),
	(20, 4346326, '1', '2018-01-21 22:14:44', 'Si', 0, '2018-01-21', 'No'),
	(21, 4346326, '1', '2018-01-22 11:18:51', 'Si', 0, '2018-01-21', 'No'),
	(22, 4346326, '1', '2018-01-22 11:18:57', 'Si', 0, '2018-01-21', 'No'),
	(23, 4346326, '1', '2018-01-22 11:19:03', 'Si', 0, '2018-01-21', 'No'),
	(24, 4346326, '1', '2018-01-22 11:19:07', 'Si', 0, '2018-01-21', 'No'),
	(25, 4346326, '1', '2018-01-26 00:13:16', 'Si', 0, '2018-01-25', 'No'),
	(26, 4346326, '1', '2018-01-26 00:13:35', 'Si', 0, '2018-01-25', 'No'),
	(27, 4346326, '1', '2018-01-26 00:13:41', 'Si', 0, '2018-01-25', 'No'),
	(28, 4346326, '1', '2018-01-26 00:13:46', 'Si', 0, '2018-01-25', 'No'),
	(29, 4346326, '1', '2018-01-26 00:13:50', 'Si', 0, '2018-01-25', 'No'),
	(30, 4346326, '1', '2018-01-26 00:13:53', 'Si', 0, '2018-01-25', 'No'),
	(31, 4346326, '1', '2018-01-26 00:13:57', 'Si', 0, '2018-01-25', 'No'),
	(32, 4346326, '1', '2018-01-26 00:14:00', 'Si', 0, '2018-01-25', 'No'),
	(33, 4346326, '1', '2018-01-26 00:14:03', 'Si', 0, '2018-01-25', 'No'),
	(34, 4346326, '1', '2018-01-30 17:35:47', 'Si', 0, '2018-01-30', 'No'),
	(35, 4346326, '1', '2018-01-31 20:15:08', 'Si', 0, '2018-01-31', 'No'),
	(36, 4346326, '1', '2018-01-31 20:15:14', 'Si', 0, '2018-01-31', 'No'),
	(37, 4346326, '1', '2018-01-31 20:15:21', 'Si', 0, '2018-01-31', 'No'),
	(38, 4346326, '1', '2018-01-31 20:15:26', 'Si', 0, '2018-01-31', 'No'),
	(39, 4346326, '1', '2018-01-31 20:15:46', 'Si', 0, '2018-01-31', 'No'),
	(40, 4346326, '1', '2018-03-01 17:44:26', 'Si', 0, '2018-03-01', 'No'),
	(41, 4346326, '1', '2018-03-01 19:27:52', 'Si', 0, '2018-03-01', 'No'),
	(42, 4346326, '1', '2018-03-01 19:55:22', 'Si', 0, '2018-03-01', 'No'),
	(43, 4346326, '1', '2018-03-01 20:35:31', 'Si', 0, '2018-03-01', 'No'),
	(44, 4346326, '1', '2018-03-01 20:35:35', 'Si', 0, '2018-03-01', 'No'),
	(45, 4346326, '1', '2018-03-01 20:35:39', 'Si', 0, '2018-03-01', 'No'),
	(46, 4346326, '1', '2018-03-01 20:38:32', 'Si', 0, '2018-03-01', 'No'),
	(47, 4346326, '1', '2018-03-04 00:10:16', 'Si', 0, '2018-03-04', 'No'),
	(48, 4346326, '1', '2018-03-04 10:06:18', 'Si', 0, '2018-03-04', 'No'),
	(49, 4346326, '1', '2018-03-04 10:06:38', 'Si', 0, '2018-03-04', 'No'),
	(50, 4346326, '1', '2018-03-04 10:10:41', 'Si', 0, '2018-03-04', 'No'),
	(51, 4346326, '1', '2018-03-05 12:05:41', 'Si', 0, '2018-03-05', 'No'),
	(52, 4346326, '1', '2018-03-05 12:05:53', 'Si', 0, '2018-03-05', 'No'),
	(53, 4346326, '1', '2018-03-31 16:49:18', 'Si', 0, '2018-03-31', 'No'),
	(54, 4346326, '1', '2018-03-31 17:01:31', 'Si', 0, '2018-03-31', 'No'),
	(55, 4346326, '1', '2018-03-31 18:24:38', 'Si', 0, '2018-03-31', 'No'),
	(56, 4346326, '1', '2018-04-01 12:11:46', 'Si', 0, '2018-04-01', 'No'),
	(57, 4346326, '1', '2018-04-01 12:24:46', 'Si', 0, '2018-04-01', 'No'),
	(58, 4346326, '1', '2018-04-01 13:20:03', 'Si', 0, '2018-04-01', 'No'),
	(59, 4346326, '1', '2018-04-01 13:32:30', 'Si', 0, '2018-04-01', 'No'),
	(60, 4346326, '1', '2018-04-01 13:48:30', 'Si', 0, '2018-04-01', 'No'),
	(61, 4346326, '1', '2018-04-03 02:42:51', 'Si', 0, '2018-04-03', 'No'),
	(62, 4346326, '1', '2018-04-03 02:52:08', 'Si', 0, '2018-04-03', 'No'),
	(63, 4346326, '1', '2018-04-03 03:02:31', 'Si', 0, '2018-04-03', 'No'),
	(64, 4346326, '1', '2018-04-03 03:02:44', 'Si', 0, '2018-04-03', 'No'),
	(65, 4346326, '1', '2018-04-03 03:03:00', 'Si', 0, '2018-04-03', 'No'),
	(66, 4346326, '1', '2018-04-10 11:48:57', 'Si', 0, '2018-04-10', 'No');
/*!40000 ALTER TABLE `venta` ENABLE KEYS */;

-- Volcando estructura para vista controlstock.viewaltaprod
-- Creando tabla temporal para superar errores de dependencia de VIEW
CREATE TABLE `viewaltaprod` (
	`idAlta` INT(10) UNSIGNED NOT NULL,
	`Fecha` DATETIME NOT NULL,
	`idProductoFK` BIGINT(20) UNSIGNED NOT NULL,
	`Descripcion` CHAR(35) NOT NULL COLLATE 'latin1_swedish_ci',
	`Motivo` VARCHAR(50) NOT NULL COLLATE 'latin1_swedish_ci',
	`Cantidad` DOUBLE NOT NULL
) ENGINE=MyISAM;

-- Volcando estructura para vista controlstock.viewbajaprod
-- Creando tabla temporal para superar errores de dependencia de VIEW
CREATE TABLE `viewbajaprod` (
	`idBaja` INT(10) UNSIGNED NOT NULL,
	`Fecha` DATETIME NOT NULL,
	`idProductoFK` BIGINT(20) UNSIGNED NOT NULL,
	`Descripcion` CHAR(35) NOT NULL COLLATE 'latin1_swedish_ci',
	`Motivo` VARCHAR(50) NOT NULL COLLATE 'latin1_swedish_ci',
	`Cantidad` DOUBLE NOT NULL
) ENGINE=MyISAM;

-- Volcando estructura para vista controlstock.viewcomision
-- Creando tabla temporal para superar errores de dependencia de VIEW
CREATE TABLE `viewcomision` (
	`CI` INT(10) UNSIGNED NOT NULL,
	`Fecha` DATETIME NOT NULL,
	`Vendedor` VARCHAR(41) NOT NULL COLLATE 'utf8_spanish_ci',
	`Total` DOUBLE NULL,
	`Comision` BIGINT(23) NULL
) ENGINE=MyISAM;

-- Volcando estructura para vista controlstock.viewcompra
-- Creando tabla temporal para superar errores de dependencia de VIEW
CREATE TABLE `viewcompra` (
	`idCompra` INT(10) UNSIGNED NOT NULL,
	`Fecha` DATETIME NOT NULL,
	`RUC` BIGINT(20) UNSIGNED NOT NULL,
	`Proveed` CHAR(20) NOT NULL COLLATE 'latin1_swedish_ci',
	`Total` DOUBLE NULL,
	`Cancelado` ENUM('Si','No') NOT NULL COLLATE 'latin1_swedish_ci',
	`Entregado` INT(10) UNSIGNED NULL,
	`Vto` DATE NULL
) ENGINE=MyISAM;

-- Volcando estructura para vista controlstock.viewdetcompra
-- Creando tabla temporal para superar errores de dependencia de VIEW
CREATE TABLE `viewdetcompra` (
	`idCompraFK` INT(10) UNSIGNED NOT NULL,
	`idProducto` BIGINT(20) UNSIGNED NOT NULL,
	`Descripcion` VARCHAR(45) NOT NULL COLLATE 'latin1_swedish_ci',
	`Cantidad` DOUBLE NOT NULL,
	`Unidades` INT(10) UNSIGNED NOT NULL,
	`Precio` INT(10) UNSIGNED NOT NULL,
	`Importe` DOUBLE NOT NULL
) ENGINE=MyISAM;

-- Volcando estructura para vista controlstock.viewdetnotaccompra
-- Creando tabla temporal para superar errores de dependencia de VIEW
CREATE TABLE `viewdetnotaccompra` (
	`idNotaFK` INT(10) UNSIGNED NOT NULL,
	`idCompraFK` INT(10) UNSIGNED NOT NULL,
	`idProducto` BIGINT(20) UNSIGNED NOT NULL,
	`Descripcion` VARCHAR(45) NOT NULL COLLATE 'latin1_swedish_ci',
	`Cantidad` DOUBLE NOT NULL,
	`Precio` INT(10) UNSIGNED NOT NULL,
	`Importe` DOUBLE NOT NULL
) ENGINE=MyISAM;

-- Volcando estructura para vista controlstock.viewdetnotacventa
-- Creando tabla temporal para superar errores de dependencia de VIEW
CREATE TABLE `viewdetnotacventa` (
	`idNotaFK` INT(10) UNSIGNED NOT NULL,
	`idVentaFK` INT(10) UNSIGNED NOT NULL,
	`idProducto` BIGINT(20) UNSIGNED NOT NULL,
	`Descripcion` VARCHAR(45) NOT NULL COLLATE 'latin1_swedish_ci',
	`Cantidad` DOUBLE NOT NULL,
	`Precio` INT(10) UNSIGNED NULL,
	`Importe` DOUBLE NULL
) ENGINE=MyISAM;

-- Volcando estructura para vista controlstock.viewdetocupacion
-- Creando tabla temporal para superar errores de dependencia de VIEW
CREATE TABLE `viewdetocupacion` (
	`idVentaFK` INT(10) UNSIGNED NOT NULL,
	`idHabFK` TINYINT(3) UNSIGNED NOT NULL,
	`idServHabFk` TINYINT(3) UNSIGNED NOT NULL,
	`Descripcion` VARCHAR(45) NOT NULL COLLATE 'utf8_bin',
	`Tiempo` SMALLINT(5) UNSIGNED NOT NULL,
	`Precio` INT(10) UNSIGNED NOT NULL,
	`SubTotal` INT(10) UNSIGNED NOT NULL
) ENGINE=MyISAM;

-- Volcando estructura para vista controlstock.viewdetventa
-- Creando tabla temporal para superar errores de dependencia de VIEW
CREATE TABLE `viewdetventa` (
	`idVentaFK` INT(10) UNSIGNED NOT NULL,
	`idProducto` BIGINT(20) UNSIGNED NOT NULL,
	`Descripcion` VARCHAR(45) NOT NULL COLLATE 'latin1_swedish_ci',
	`Cantidad` DOUBLE NOT NULL,
	`Unidades` INT(10) UNSIGNED NOT NULL,
	`Precio` INT(10) UNSIGNED NULL,
	`Importe` DOUBLE NULL,
	`Descuento` TINYINT(10) UNSIGNED NULL
) ENGINE=MyISAM;

-- Volcando estructura para vista controlstock.viewgasto
-- Creando tabla temporal para superar errores de dependencia de VIEW
CREATE TABLE `viewgasto` (
	`idGasto` INT(10) UNSIGNED NOT NULL,
	`Descripcion` VARCHAR(30) NOT NULL COLLATE 'latin1_swedish_ci',
	`Fecha` DATETIME NOT NULL,
	`Importe` INT(10) UNSIGNED NOT NULL
) ENGINE=MyISAM;

-- Volcando estructura para vista controlstock.viewnotaccompra
-- Creando tabla temporal para superar errores de dependencia de VIEW
CREATE TABLE `viewnotaccompra` (
	`idNota` INT(10) UNSIGNED NOT NULL,
	`idCompraFK` INT(10) UNSIGNED NOT NULL,
	`Fecha` DATETIME NOT NULL,
	`RUC` BIGINT(20) UNSIGNED NOT NULL,
	`proveed` CHAR(20) NOT NULL COLLATE 'latin1_swedish_ci',
	`Total` DOUBLE NULL
) ENGINE=MyISAM;

-- Volcando estructura para vista controlstock.viewnotacventa
-- Creando tabla temporal para superar errores de dependencia de VIEW
CREATE TABLE `viewnotacventa` (
	`idNota` INT(10) UNSIGNED NOT NULL,
	`idVentaFK` INT(10) UNSIGNED NOT NULL,
	`Fecha` DATETIME NOT NULL,
	`CI` INT(10) UNSIGNED NOT NULL,
	`Vendedor` VARCHAR(41) NOT NULL COLLATE 'utf8_spanish_ci',
	`Total` DOUBLE NULL,
	`Clien` VARCHAR(30) NOT NULL COLLATE 'latin1_swedish_ci'
) ENGINE=MyISAM;

-- Volcando estructura para vista controlstock.viewproducto
-- Creando tabla temporal para superar errores de dependencia de VIEW
CREATE TABLE `viewproducto` (
	`idProducto` BIGINT(20) UNSIGNED NOT NULL,
	`ProveedorFK` CHAR(20) NOT NULL COLLATE 'latin1_swedish_ci',
	`Descripcion` CHAR(35) NOT NULL COLLATE 'latin1_swedish_ci',
	`Costo` INT(10) UNSIGNED NOT NULL,
	`Precio1` INT(10) UNSIGNED NOT NULL,
	`Precio2` INT(10) UNSIGNED NOT NULL,
	`Stock` DOUBLE NOT NULL
) ENGINE=MyISAM;

-- Volcando estructura para vista controlstock.viewusuario
-- Creando tabla temporal para superar errores de dependencia de VIEW
CREATE TABLE `viewusuario` (
	`idUsuario` INT(10) NOT NULL,
	`Usuario` CHAR(20) NOT NULL COLLATE 'utf8_spanish_ci',
	`Pass` CHAR(20) NOT NULL COLLATE 'utf8_spanish_ci',
	`PrivilegioFK` VARCHAR(20) NOT NULL COLLATE 'utf8_spanish_ci',
	`idEmpleadoFK` INT(10) UNSIGNED NOT NULL
) ENGINE=MyISAM;

-- Volcando estructura para vista controlstock.viewventa
-- Creando tabla temporal para superar errores de dependencia de VIEW
CREATE TABLE `viewventa` (
	`idVenta` INT(10) UNSIGNED NOT NULL,
	`Fecha` DATETIME NOT NULL,
	`CI` INT(10) UNSIGNED NOT NULL,
	`Vendedor` VARCHAR(41) NOT NULL COLLATE 'utf8_spanish_ci',
	`Clien` VARCHAR(30) NOT NULL COLLATE 'latin1_swedish_ci',
	`Total` DOUBLE NULL,
	`Cancelado` ENUM('Si','No') NOT NULL COLLATE 'latin1_swedish_ci',
	`Entregado` INT(10) UNSIGNED NULL,
	`Vto` DATE NULL,
	`PagoComision` ENUM('Si','No') NOT NULL COLLATE 'latin1_swedish_ci'
) ENGINE=MyISAM;

-- Volcando estructura para procedimiento controlstock.zcomprasxmes
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zcomprasxmes`(IN `Anho` INT)
BEGIN
	SELECT CASE WHEN MONTH(fecha) = 1 THEN "Enero"
					WHEN MONTH(fecha) = 2 THEN "Febrero"
					WHEN MONTH(fecha) = 3 THEN "Marzo"
					WHEN MONTH(fecha) = 4 THEN "Abril"
					WHEN MONTH(fecha) = 5 THEN "Mayo"
					WHEN MONTH(fecha) = 6 THEN "Junio"
					WHEN MONTH(fecha) = 7 THEN "Julio"
					WHEN MONTH(fecha) = 8 THEN "Agosto"
					WHEN MONTH(fecha) = 9 THEN "Septiembre"
					WHEN MONTH(fecha) = 10 THEN "Octubre"
					WHEN MONTH(fecha) = 11 THEN "Noviembre"
					WHEN MONTH(fecha) = 12 THEN "Diciembre"
					ELSE "esto no es un mes" END AS MES, 
				SUM(Total) AS Ingreso 
	FROM `viewcompra`
	WHERE YEAR(Fecha) = Anho
			AND Cancelado = 'Si' 
			AND Entregado = 0
	GROUP BY YEAR(Fecha) ASC, MONTH(Fecha) ASC;
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zdetalleocup_insert
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zdetalleocup_insert`(IN `idVenta` INT, IN `idHab` TINYINT, IN `idServHab` TINYINT, IN `Tiemp` SMALLINT, IN `Prec` INT, IN `SubT` INT)
BEGIN
	INSERT INTO `detalleocupacion` 
	VALUES (idVenta, idHab, idServHab, Tiemp, Prec, SubT);
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zgastoxmes
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zgastoxmes`(IN `Anho` YEAR)
BEGIN
	SELECT CASE WHEN MONTH(fecha) = 1 THEN "Enero"
					WHEN MONTH(fecha) = 2 THEN "Febrero"
					WHEN MONTH(fecha) = 3 THEN "Marzo"
					WHEN MONTH(fecha) = 4 THEN "Abril"
					WHEN MONTH(fecha) = 5 THEN "Mayo"
					WHEN MONTH(fecha) = 6 THEN "Junio"
					WHEN MONTH(fecha) = 7 THEN "Julio"
					WHEN MONTH(fecha) = 8 THEN "Agosto"
					WHEN MONTH(fecha) = 9 THEN "Septiembre"
					WHEN MONTH(fecha) = 10 THEN "Octubre"
					WHEN MONTH(fecha) = 11 THEN "Noviembre"
					WHEN MONTH(fecha) = 12 THEN "Diciembre"
					ELSE "esto no es un mes" END AS MES, 
				SUM(Importe) AS Ingreso 
	FROM `gasto`
	WHERE YEAR(Fecha) = Anho
	GROUP BY YEAR(Fecha) ASC, MONTH(Fecha) ASC;
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zhabitacion_buscar
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zhabitacion_buscar`(IN `idHab` TINYINT, IN `idServHab` TINYINT)
BEGIN
	SELECT *
	FROM habitacion
	WHERE idHabitacion = idHab AND idServHabFK = idServHab;
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zhabitacion_buscar2
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zhabitacion_buscar2`(IN `nroHab` TINYINT)
BEGIN
	SELECT *
	FROM habitacion2 h
	WHERE h.NroHabitacion = nroHab;
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zhabitacion_update
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zhabitacion_update`(IN `idHab` TINYINT, IN `idServHab` TINYINT, IN `Descrip` CHAR(35), IN `Prec` MEDIUMINT)
BEGIN
	UPDATE Habitacion
	SET Descripcion = Descrip, Precio = Prec
	WHERE idHabitacion = idHab AND idServHabFK = idServHab;
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zhabitacion_update2
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zhabitacion_update2`(IN `idHab` TINYINT, IN `Prec1` MEDIUMINT, IN `Prec2` MEDIUMINT, IN `Prec3` MEDIUMINT)
BEGIN
	UPDATE Habitacion2
	SET Precio1 = Prec1, Precio2 = Prec2, Precio3 = Prec3
	WHERE NroHabitacion = idHab;
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zhabitacion_viewall
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zhabitacion_viewall`()
BEGIN
	SELECT h.`idHabitacion`, h.`Descripcion`, h.`Precio`, s.`Descripcion` as "Tarifa"
	FROM habitacion h, serviciohabitacion s
	WHERE h.`idServHabFK` = s.`idServHab` 
	ORDER BY s.idServHab, h.idHabitacion;
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zhabitacion_viewall2
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zhabitacion_viewall2`()
BEGIN
	SELECT h.NroHabitacion, h.Precio1, h.Precio2, h.Precio3
	FROM habitacion2 h
	ORDER BY h.NroHabitacion;
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zhabit_ajustes
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zhabit_ajustes`(IN `MEntrada` SMALLINT, IN `MSalida` SMALLINT, IN `Toleranc` SMALLINT)
BEGIN
	UPDATE `habitacionajustes` 
	SET `MargerEntrada`=MEntrada, `MargenSalida`=MSalida, `Tolerancia`=Toleranc 
	WHERE  `IdAjuste`=1;
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zhabit_ajustes_view
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zhabit_ajustes_view`()
BEGIN
	SELECT *
	FROM habitacionajustes;
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.znotacxmes
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `znotacxmes`(IN `Anho` INT)
BEGIN
	SELECT CASE WHEN MONTH(fecha) = 1 THEN "Enero"
					WHEN MONTH(fecha) = 2 THEN "Febrero"
					WHEN MONTH(fecha) = 3 THEN "Marzo"
					WHEN MONTH(fecha) = 4 THEN "Abril"
					WHEN MONTH(fecha) = 5 THEN "Mayo"
					WHEN MONTH(fecha) = 6 THEN "Junio"
					WHEN MONTH(fecha) = 7 THEN "Julio"
					WHEN MONTH(fecha) = 8 THEN "Agosto"
					WHEN MONTH(fecha) = 9 THEN "Septiembre"
					WHEN MONTH(fecha) = 10 THEN "Octubre"
					WHEN MONTH(fecha) = 11 THEN "Noviembre"
					WHEN MONTH(fecha) = 12 THEN "Diciembre"
					ELSE "esto no es un mes" END AS MES, 
				SUM(Total) AS Ingreso 
	FROM `viewnotaccompra`
	WHERE YEAR(Fecha) = Anho
	GROUP BY YEAR(Fecha) ASC, MONTH(Fecha) ASC;
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.znotavxmes
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `znotavxmes`(IN `Anho` INT)
BEGIN
	SELECT CASE WHEN MONTH(fecha) = 1 THEN "Enero"
					WHEN MONTH(fecha) = 2 THEN "Febrero"
					WHEN MONTH(fecha) = 3 THEN "Marzo"
					WHEN MONTH(fecha) = 4 THEN "Abril"
					WHEN MONTH(fecha) = 5 THEN "Mayo"
					WHEN MONTH(fecha) = 6 THEN "Junio"
					WHEN MONTH(fecha) = 7 THEN "Julio"
					WHEN MONTH(fecha) = 8 THEN "Agosto"
					WHEN MONTH(fecha) = 9 THEN "Septiembre"
					WHEN MONTH(fecha) = 10 THEN "Octubre"
					WHEN MONTH(fecha) = 11 THEN "Noviembre"
					WHEN MONTH(fecha) = 12 THEN "Diciembre"
					ELSE "esto no es un mes" END AS MES, 
				SUM(Total) AS Ingreso 
	FROM `viewnotacventa`
	WHERE YEAR(Fecha) = Anho
	GROUP BY YEAR(Fecha) ASC, MONTH(Fecha) ASC;
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zocupmanual_buscar
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zocupmanual_buscar`(IN `HoraE` DATETIME, IN `HoraS` DATETIME, IN `NroHabit` TINYINT)
BEGIN
	SELECT * 
	FROM ocupacionmanual
	WHERE NroHab = NroHabit AND
			HraEntrada > HoraE AND 
			HraSalida < HoraS;
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zocupmanual_ins_in
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zocupmanual_ins_in`(IN `nroHabit` TINYINT)
BEGIN
	INSERT INTO `ocupacionmanual` (`NroHab`, `HraEntrada`) 
	VALUES (nroHabit, NOW());	
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zocupmanual_ins_out
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zocupmanual_ins_out`(IN `nroHabit` TINYINT, IN `idVenta` INT)
BEGIN
	UPDATE ocupacionmanual o
	SET o.HraSalida = NOW(), o.idVentaFK = idVenta
	WHERE idOcupacion = (SELECT maxId 
								FROM(
									SELECT DISTINCT MAX(idOcupacion) AS maxId 
									FROM ocupacionmanual 
									WHERE NroHab = nroHabit) AS c
								);
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zocupmanual_ins_out2
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zocupmanual_ins_out2`(IN `nroHabit` TINYINT)
BEGIN
	UPDATE ocupacionmanual o
	SET o.HraSalida = NOW()
	WHERE idOcupacion = (SELECT maxId 
								FROM(
									SELECT DISTINCT MAX(idOcupacion) AS maxId 
									FROM ocupacionmanual 
									WHERE NroHab = nroHabit) AS c
								);
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zocupmanual_sinsalida
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zocupmanual_sinsalida`(IN `NroHabit` TINYINT)
    COMMENT 'si no se regitro una salida'
BEGIN
	SELECT TIME(o.HraEntrada), DATE(o.HraEntrada)					  
	FROM ocupacionmanual o
	WHERE o.idOcupacion = (SELECT maxId 
								FROM(
									SELECT DISTINCT MAX(idOcupacion) AS maxId 
									FROM ocupacionmanual 
									WHERE NroHab = NroHabit) AS c
								) 
			AND ISNULL(o.HraSalida) = TRUE;
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zocupmanual_view
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zocupmanual_view`(IN `Fecha` DATE)
BEGIN
	SELECT * 
	FROM ocupacionmanual
	WHERE HraEntrada > Fecha AND 
			HraEntrada < ADDDATE(Fecha, INTERVAL 1 DAY);
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zocupsensor_buscar
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zocupsensor_buscar`(IN `HoraE` DATETIME, IN `HoraS` DATETIME, IN `NroHabit` TINYINT)
BEGIN
	SELECT * 
	FROM ocupacionsensor
	WHERE NroHabitacion = NroHabit AND
			HraEntrada < HoraE AND 
			HraSalida > HoraS;
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zocupsensor_ins_in
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zocupsensor_ins_in`(IN `NroHabit` TINYINT)
BEGIN
	INSERT INTO `ocupacionsensor` (`NroHabitacion`, `HraEntrada`) 
	VALUES (NroHabit, NOW());
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zocupsensor_ins_out
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zocupsensor_ins_out`(IN `nroHabit` TINYINT)
BEGIN
	UPDATE ocupacionsensor o
	SET o.HraSalida = NOW()
	WHERE o.idOcupacion = (SELECT maxId 
								  FROM(
									   SELECT DISTINCT MAX(idOcupacion) AS maxId 
									   FROM ocupacionsensor 
									   WHERE NroHabitacion = nroHabit) AS c
								  );
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zocupsensor_view
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zocupsensor_view`(IN `Fecha` DATE)
BEGIN
	SELECT *
	FROM ocupacionsensor
	WHERE HraEntrada > Fecha AND 
			HraEntrada < ADDDATE(Fecha, INTERVAL 1 DAY);
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zprivilegio_delete
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zprivilegio_delete`(IN `idPriv` INT)
BEGIN
	DELETE FROM `privilegio` 
	WHERE  `idPrivilegio`= idPriv 
	LIMIT 1;
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zprivilegio_insert
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zprivilegio_insert`(IN `Rol_` VARCHAR(20), IN `ProdConsult_` BIT, IN `ProdReg_` BIT, IN `ProdActualiz_` BIT, IN `ProdEliminar_` BIT, IN `VentasConsult_` BIT, IN `VentasReg_` BIT, IN `ComprasConsult_` BIT, IN `ComprasReg_` BIT, IN `ProvConsult_` BIT, IN `ProvReg_` BIT, IN `ProvActualiz_` BIT, IN `ProvEliminar_` BIT, IN `EmpleAdmin_` BIT, IN `UsuAdmin_` BIT, IN `FinanzasAdmin_` BIT, IN `HabAdmin_` BIT, IN `CuentasAdmin_` BIT, IN `DevolAutoriCli_` BIT, IN `DevolAutoriProv_` BIT)
BEGIN
	INSERT INTO `privilegio` (`Rol`, `ProdConsult`, `ProdReg`, `ProdActualiz`, `ProdEliminar`, `VentasConsult`, `VentasReg`, `ComprasConsult`, `ComprasReg`, `ProvConsult`, `ProvReg`, `ProvActualiz`, `ProvEliminar`, `EmpleAdmin`, `UsuAdmin`, `FinanzasAdmin`, `HabAdmin`, `CuentasAdmin`, `DevolAutoriCli`, `DevolAutoriProv`) 
	VALUES (Rol_, ProdConsult_, ProdReg_, ProdActualiz_, ProdEliminar_, VentasConsult_, VentasReg_, ComprasConsult_, ComprasReg_, ProvConsult_, ProvReg_, ProvActualiz_, ProvEliminar_, EmpleAdmin_, UsuAdmin_, FinanzasAdmin_, HabAdmin_, CuentasAdmin_, DevolAutoriCli_, DevolAutoriProv_);
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zprivilegio_listar
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zprivilegio_listar`()
BEGIN
	SELECT * FROM privilegio
	Order By Rol;
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zprivilegio_update
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zprivilegio_update`(IN `Rol_` VARCHAR(20), IN `ProdConsult_` BIT, IN `ProdReg_` BIT, IN `ProdActualiz_` BIT, IN `ProdEliminar_` BIT, IN `VentasConsult_` BIT, IN `VentasReg_` BIT, IN `ComprasConsult_` BIT, IN `ComprasReg_` BIT, IN `ProvConsult_` BIT, IN `ProvReg_` BIT, IN `ProvActualiz_` BIT, IN `ProvEliminar_` BIT, IN `EmpleAdmin_` BIT, IN `UsuAdmin_` BIT, IN `FinanzasAdmin_` BIT, IN `HabAdmin_` BIT, IN `CuentasAdmin_` BIT, IN `DevolAutoriCli_` BIT, IN `DevolAutoriProv_` BIT, IN `idPrivilegio_` INT)
BEGIN
	UPDATE `privilegio` 
	SET `Rol`= Rol_, `ProdConsult`= ProdConsult_, `ProdReg`= ProdReg_, `ProdActualiz`= ProdActualiz_, `ProdEliminar`= ProdEliminar_, `VentasConsult`= VentasConsult_, `VentasReg`= VentasReg_, `ComprasConsult`= ComprasConsult_, `ComprasReg`= ComprasReg_, `ProvConsult`= ProvConsult_, `ProvReg`= ProvReg_, `ProvActualiz`= ProvActualiz_, `ProvEliminar`= ProvEliminar_, `EmpleAdmin`= EmpleAdmin_, `UsuAdmin`= UsuAdmin_, `FinanzasAdmin`= FinanzasAdmin_, `HabAdmin`= HabAdmin_, `CuentasAdmin`= CuentasAdmin_, `DevolAutoriCli`= DevolAutoriCli_, `DevolAutoriProv`= DevolAutoriProv_ 
	WHERE  `idPrivilegio`= idPrivilegio_
	LIMIT 1; 
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zproducto_insert
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zproducto_insert`(IN `idprod` BIGINT, IN `idprov` BIGINT, IN `descrip` CHAR(50), IN `costo` INT, IN `precio1` INT, IN `precio2` INT, IN `precio3` INT, IN `preciopack` INT, IN `stock` DOUBLE, IN `unidxpack` INT, IN `porpack` ENUM('Si','No','Kilo','Tiempo'), IN `foto` LONGBLOB, IN `iva` TINYINT)
BEGIN
INSERT INTO Producto 
VALUES(idprod, idprov, descrip, costo, precio1, precio2, precio3, preciopack, stock, unidxpack, porpack, foto, iva);
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zproducto_update
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zproducto_update`(IN `idprod` BIGINT, IN `idprov` BIGINT, IN `descrip` CHAR(50), IN `Cost` INT, IN `Prec1` INT, IN `Prec2` INT, IN `Prec3` INT, IN `PrecPack` INT, IN `cantunit` DOUBLE, IN `unidxpak` INT, IN `porpak` ENUM('Si','No','Kilo','Tiempo'), IN `foti` LONGBLOB, IN `Iva_` TINYINT, IN `oldidProd` BIGINT)
BEGIN
	UPDATE Producto
	SET idProducto = idprod, idProveedorFK = idprov, Descripcion = descrip, 
		Costo = Cost, Precio1 = Prec1, Precio2 = Prec2, Precio3 = Prec3, 
		PrecioPack = PrecPack, Stock = cantunit, UnidXpack = unidxpak, 
		PorPack = porpak, Foto = foti, Iva = Iva_
	WHERE idProducto = oldidProd;
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zrecibocobroxmes
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zrecibocobroxmes`(IN `Anho` INT)
BEGIN
	SELECT CASE WHEN MONTH(fecha) = 1 THEN "Enero"
					WHEN MONTH(fecha) = 2 THEN "Febrero"
					WHEN MONTH(fecha) = 3 THEN "Marzo"
					WHEN MONTH(fecha) = 4 THEN "Abril"
					WHEN MONTH(fecha) = 5 THEN "Mayo"
					WHEN MONTH(fecha) = 6 THEN "Junio"
					WHEN MONTH(fecha) = 7 THEN "Julio"
					WHEN MONTH(fecha) = 8 THEN "Agosto"
					WHEN MONTH(fecha) = 9 THEN "Septiembre"
					WHEN MONTH(fecha) = 10 THEN "Octubre"
					WHEN MONTH(fecha) = 11 THEN "Noviembre"
					WHEN MONTH(fecha) = 12 THEN "Diciembre"
					ELSE "esto no es un mes" END AS MES, 
				SUM(Importe) AS Ingreso 
	FROM `recibocobrocuenta`
	WHERE YEAR(Fecha) = Anho
	GROUP BY YEAR(Fecha) ASC, MONTH(Fecha) ASC;
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zrecibopagoxmes
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zrecibopagoxmes`(IN `Anho` INT)
BEGIN
	SELECT CASE WHEN MONTH(fecha) = 1 THEN "Enero"
					WHEN MONTH(fecha) = 2 THEN "Febrero"
					WHEN MONTH(fecha) = 3 THEN "Marzo"
					WHEN MONTH(fecha) = 4 THEN "Abril"
					WHEN MONTH(fecha) = 5 THEN "Mayo"
					WHEN MONTH(fecha) = 6 THEN "Junio"
					WHEN MONTH(fecha) = 7 THEN "Julio"
					WHEN MONTH(fecha) = 8 THEN "Agosto"
					WHEN MONTH(fecha) = 9 THEN "Septiembre"
					WHEN MONTH(fecha) = 10 THEN "Octubre"
					WHEN MONTH(fecha) = 11 THEN "Noviembre"
					WHEN MONTH(fecha) = 12 THEN "Diciembre"
					ELSE "esto no es un mes" END AS MES, 
				SUM(Importe) AS Ingreso 
	FROM `recibopagocuenta`
	WHERE YEAR(Fecha) = Anho
	GROUP BY YEAR(Fecha) ASC, MONTH(Fecha) ASC;
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zservhab_buscar
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zservhab_buscar`(IN `idServHabit` TINYINT)
BEGIN
	SELECT *
	FROM serviciohabitacion
	WHERE idServHab = idServHabit;
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zservhab_getdescrip
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zservhab_getdescrip`(IN `idServHabit` TINYINT)
BEGIN
	SELECT s.Descripcion
	FROM serviciohabitacion s
	WHERE idServHab = idServHabit;
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zservhab_gethrae
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zservhab_gethrae`()
BEGIN
	SELECT s.HraEntrada
	FROM serviciohabitacion s
	WHERE idServHab = 3;
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zservhab_gethras
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zservhab_gethras`()
BEGIN
	SELECT s.HraSalida
	FROM serviciohabitacion s
	WHERE idServHab = 3;
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zservhab_getid
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zservhab_getid`(IN `Descrip` CHAR(30))
BEGIN
	SELECT idServHab
	FROM serviciohabitacion 
	WHERE Descripcion = Descrip;
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zservhab_gettiempo
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zservhab_gettiempo`(IN `idServHabit` TINYINT)
BEGIN
	SELECT s.Tiempo
	FROM serviciohabitacion s
	WHERE idServHab = idServHabit;
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zservhab_update
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zservhab_update`(IN `Descrip1` CHAR(30), IN `Descrip2` CHAR(30), IN `Descrip3` CHAR(30), IN `Tiempo1` SMALLINT, IN `Tiempo2` SMALLINT, IN `HoraE` TIME, IN `HoraS` TIME)
BEGIN
	UPDATE serviciohabitacion 
	SET `Descripcion`=Descrip1, `Tiempo`=Tiempo1
	WHERE  `IdServHab`=1;
	
	UPDATE serviciohabitacion 
	SET `Descripcion`=Descrip2, `Tiempo`=Tiempo2
	WHERE  `IdServHab`=2;
	
	UPDATE serviciohabitacion 
	SET `Descripcion`=Descrip3, `HraEntrada`=HoraE, `HraSalida`=HoraS
	WHERE  `IdServHab`=3;
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zusuario_buscarxci
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zusuario_buscarxci`(IN `CI` INT)
BEGIN
	SELECT * FROM viewusuario
	WHERE `idEmpleadoFK` = CI;
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zusuario_buscarxusu
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zusuario_buscarxusu`(IN `Usu` CHAR(20))
BEGIN
	SELECT * FROM viewusuario
	WHERE `Usuario` LIKE CONCAT('%', Usu, '%');
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zusuario_ins
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zusuario_ins`(IN `Usu` CHAR(20), IN `Pass` CHAR(20), IN `Priv` INT, IN `Emple` INT)
BEGIN
	INSERT INTO Usuario(`Usuario`, Pass, idPrivilegioFK, idEmpleadoFK) 
	VALUES(Usu, Pass, Priv, Emple);
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zusuario_update
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zusuario_update`(IN `idUsu` INT, IN `Usu` Char(30), IN `Pas` Char(30), IN `idPriv` INT, IN `idEmple` INT)
BEGIN
	UPDATE Usuario 
	SET `Usuario` = Usu, Pass = Pas, idPrivilegioFK = idPriv, idEmpleadoFK = idEmple
	WHERE IdUsuario = idUsu;
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zventasxdia
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zventasxdia`(IN `Anho` INT, IN `Mes` INT)
BEGIN
	SELECT DATE(Fecha), SUM(Total) AS Ingreso 
	FROM `viewventa`
	WHERE YEAR(Fecha) = Anho AND MONTH(Fecha) = Mes
	GROUP BY MONTH(Fecha) ASC, DAY(Fecha) ASC;
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zventasxmes
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zventasxmes`(IN `Anho` INT)
BEGIN
	SELECT CASE WHEN MONTH(fecha) = 1 THEN "Enero"
					WHEN MONTH(fecha) = 2 THEN "Febrero"
					WHEN MONTH(fecha) = 3 THEN "Marzo"
					WHEN MONTH(fecha) = 4 THEN "Abril"
					WHEN MONTH(fecha) = 5 THEN "Mayo"
					WHEN MONTH(fecha) = 6 THEN "Junio"
					WHEN MONTH(fecha) = 7 THEN "Julio"
					WHEN MONTH(fecha) = 8 THEN "Agosto"
					WHEN MONTH(fecha) = 9 THEN "Septiembre"
					WHEN MONTH(fecha) = 10 THEN "Octubre"
					WHEN MONTH(fecha) = 11 THEN "Noviembre"
					WHEN MONTH(fecha) = 12 THEN "Diciembre"
					ELSE "esto no es un mes" END AS MES, 
				SUM(Total) AS Ingreso 
	FROM `viewventa`
	WHERE YEAR(Fecha) = Anho
			AND Cancelado = 'Si' 
			AND Entregado = 0
	GROUP BY YEAR(Fecha) ASC, MONTH(Fecha) ASC;
END//
DELIMITER ;

-- Volcando estructura para vista controlstock.viewaltaprod
-- Eliminando tabla temporal y crear estructura final de VIEW
DROP TABLE IF EXISTS `viewaltaprod`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewaltaprod` AS select a.idAlta, a.Fecha, a.idProductoFK, p.Descripcion, m.Motivo, a.Cantidad
from altaprod a, producto p, altaprodmotivo m
where a.idProductoFK = p.idProducto and a.Motivo = m.idMotivo ;

-- Volcando estructura para vista controlstock.viewbajaprod
-- Eliminando tabla temporal y crear estructura final de VIEW
DROP TABLE IF EXISTS `viewbajaprod`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewbajaprod` AS select b.idBaja, b.Fecha, b.idProductoFK, p.Descripcion, m.Motivo, b.Cantidad
from bajaprod b, producto p, bajaprodmotivo m
where b.idProductoFK = p.idProducto and b.Motivo = m.idMotivo ;

-- Volcando estructura para vista controlstock.viewcomision
-- Eliminando tabla temporal y crear estructura final de VIEW
DROP TABLE IF EXISTS `viewcomision`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewcomision` AS select v.CI, v.Fecha, v.Vendedor, sum(v.total) as Total, (sum(v.Total) * e.Comision div 100) as Comision
from viewventa v, empleado e ;

-- Volcando estructura para vista controlstock.viewcompra
-- Eliminando tabla temporal y crear estructura final de VIEW
DROP TABLE IF EXISTS `viewcompra`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewcompra` AS select c.idCompra, c.Fecha, p.RUC, p.Nombre as Proveed, (select sum(viewdetcompra.importe) from viewdetcompra where viewdetcompra.idCompraFK = c.idCompra) as Total, c.Cancelado, c.Entregado, c.Vto  
from compra c, proveedor p
where c.idProveedorFK = p.RUC ;

-- Volcando estructura para vista controlstock.viewdetcompra
-- Eliminando tabla temporal y crear estructura final de VIEW
DROP TABLE IF EXISTS `viewdetcompra`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewdetcompra` AS SELECT d.idCompraFK, p.idProducto, concat(p.Descripcion,' ',d.Obs) as Descripcion, d.Cantidad, d.Unidades, d.Precio, (d.Cantidad * d.Precio) as Importe
FROM detallecompra d, producto p
WHERE d.idProductoFK = p.idProducto ;

-- Volcando estructura para vista controlstock.viewdetnotaccompra
-- Eliminando tabla temporal y crear estructura final de VIEW
DROP TABLE IF EXISTS `viewdetnotaccompra`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewdetnotaccompra` AS SELECT n.idNotaFK, d.idCompraFK , d.idProducto, d.Descripcion, n.Cantidad, d.Precio, (n.Cantidad * d.Precio) as Importe
FROM viewdetcompra d, detnotaccompra n
WHERE d.idCompraFK = n.idCompraFK and d.idProducto = n.idProductoFK ;

-- Volcando estructura para vista controlstock.viewdetnotacventa
-- Eliminando tabla temporal y crear estructura final de VIEW
DROP TABLE IF EXISTS `viewdetnotacventa`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewdetnotacventa` AS SELECT n.idNotaFK, d.idVentaFK , d.idProducto, d.Descripcion, n.Cantidad, d.Precio, (n.Cantidad * d.Precio) as Importe
FROM viewdetventa d, detnotacventa n
WHERE d.idVentaFK = n.idVentaFK and d.idProducto = n.idProductoFK ;

-- Volcando estructura para vista controlstock.viewdetocupacion
-- Eliminando tabla temporal y crear estructura final de VIEW
DROP TABLE IF EXISTS `viewdetocupacion`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewdetocupacion` AS SELECT d.idVentaFK, 
		 d.idHabFK, 
		 d.idServHabFk,
		 		 concat('HabitaciÃ³n', CAST(d.idHabFK AS CHAR), ' ', s.Descripcion) as Descripcion, 
		 d.Tiempo, 
		 d.Precio, 
		 d.SubTotal
FROM detalleocupacion d, serviciohabitacion s
WHERE d.idServHabFk = s.idServHab 
ORDER BY d.idVentaFK ASC ;

-- Volcando estructura para vista controlstock.viewdetventa
-- Eliminando tabla temporal y crear estructura final de VIEW
DROP TABLE IF EXISTS `viewdetventa`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewdetventa` AS SELECT d.idVentaFK, 
		 p.idProducto, 
		 concat(p.Descripcion,' ',d.Obs) as Descripcion, 
		 d.Cantidad, 
		 d.Unidades, 
		 d.Precio, 
		 (d.Cantidad * d.Precio) as Importe, 
		 d.Descuento 
FROM detalleventa d, producto p
WHERE d.idProductoFK = p.idProducto ;

-- Volcando estructura para vista controlstock.viewgasto
-- Eliminando tabla temporal y crear estructura final de VIEW
DROP TABLE IF EXISTS `viewgasto`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewgasto` AS SELECT g.idGasto, l.Descripcion, g.Fecha, g.Importe 
FROM gasto g, listagasto l
WHERE g.Descripcion = l.IdGasto ;

-- Volcando estructura para vista controlstock.viewnotaccompra
-- Eliminando tabla temporal y crear estructura final de VIEW
DROP TABLE IF EXISTS `viewnotaccompra`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewnotaccompra` AS select n.idNota, n.idCompraFK, n.Fecha, c.RUC, c.proveed, (select sum(viewdetnotaccompra.importe) from viewdetnotaccompra where viewdetnotaccompra.idNotaFK = n.idNota) as Total 
from notaccompra n,  viewcompra c
where n.idcomprafk = c.idCompra ;

-- Volcando estructura para vista controlstock.viewnotacventa
-- Eliminando tabla temporal y crear estructura final de VIEW
DROP TABLE IF EXISTS `viewnotacventa`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewnotacventa` AS select n.idNota, n.idVentaFK, n.Fecha, v.CI, v.Vendedor, (select sum(viewdetnotacventa.importe) from viewdetnotacventa where viewdetnotacventa.idNotaFK = n.idNota) as Total, v.Clien 
from notacventa n,  viewventa v
where n.idVentafk = v.idVenta ;

-- Volcando estructura para vista controlstock.viewproducto
-- Eliminando tabla temporal y crear estructura final de VIEW
DROP TABLE IF EXISTS `viewproducto`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewproducto` AS SELECT p.idProducto, v.Nombre as ProveedorFK, p.Descripcion, p.Costo, p.Precio1, p.Precio2, p.Stock
from producto p, proveedor v
where p.idProveedorFK = v.RUC ;

-- Volcando estructura para vista controlstock.viewusuario
-- Eliminando tabla temporal y crear estructura final de VIEW
DROP TABLE IF EXISTS `viewusuario`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewusuario` AS SELECT u.idUsuario, u.Usuario, u.Pass, p.Rol as PrivilegioFK, u.idEmpleadoFK 
FROM usuario u, privilegio p
WHERE u.idPrivilegioFK = p.idPrivilegio ;

-- Volcando estructura para vista controlstock.viewventa
-- Eliminando tabla temporal y crear estructura final de VIEW
DROP TABLE IF EXISTS `viewventa`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewventa` AS SELECT v.idVenta, 
		 v.Fecha, 
		 e.CI, 
		 concat(e.Nombre,' ',e.Apellido) AS Vendedor, 
		 c.Nombre AS Clien,
		 (SELECT IF(ISNULL(SUM(dv.Importe)), 0, SUM(dv.Importe)) 
		 			FROM viewdetventa dv 
					WHERE dv.idVentaFK = v.idVenta) +
		 (SELECT IF(ISNULL(SUM(do.SubTotal)), 0, SUM(do.SubTotal)) 
		 			FROM detalleocupacion do 
					WHERE do.idVentaFK = v.idVenta) as Total, 
		 v.Cancelado, 
		 v.Entregado, 
		 v.Vto, 
		 v.PagoComision

FROM venta v, empleado e, cliente c
WHERE v.idEmpleadoFK = e.CI AND v.idClienteFK = c.CI ;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
