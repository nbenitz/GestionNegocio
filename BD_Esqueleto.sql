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
  `idProductoFK` char(20) COLLATE utf8_spanish_ci NOT NULL,
  `Fecha` datetime NOT NULL,
  `Cantidad` double unsigned NOT NULL,
  `Motivo` smallint(5) unsigned NOT NULL,
  PRIMARY KEY (`idAlta`),
  KEY `FK_altaprod_producto` (`idProductoFK`),
  KEY `FK_altaprod_altaprodmotivo` (`Motivo`),
  CONSTRAINT `FK_altaprod_altaprodmotivo` FOREIGN KEY (`Motivo`) REFERENCES `altaprodmotivo` (`idMotivo`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `FK_altaprod_producto` FOREIGN KEY (`idProductoFK`) REFERENCES `producto` (`idProducto`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=127 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla controlstock.altaprodmotivo
CREATE TABLE IF NOT EXISTS `altaprodmotivo` (
  `idMotivo` smallint(5) unsigned NOT NULL AUTO_INCREMENT,
  `Motivo` varchar(50) COLLATE utf8_spanish_ci NOT NULL,
  PRIMARY KEY (`idMotivo`),
  UNIQUE KEY `Motivo` (`Motivo`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla controlstock.bajaprod
CREATE TABLE IF NOT EXISTS `bajaprod` (
  `idBaja` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `idProductoFK` char(20) COLLATE utf8_spanish_ci NOT NULL,
  `Fecha` datetime NOT NULL,
  `Cantidad` double unsigned NOT NULL,
  `Motivo` smallint(5) unsigned NOT NULL,
  PRIMARY KEY (`idBaja`),
  KEY `FK_bajaprod_producto` (`idProductoFK`),
  KEY `FK_bajaprod_motivobajaprod` (`Motivo`),
  CONSTRAINT `FK_bajaprod_motivobajaprod` FOREIGN KEY (`Motivo`) REFERENCES `bajaprodmotivo` (`idMotivo`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `FK_bajaprod_producto` FOREIGN KEY (`idProductoFK`) REFERENCES `producto` (`idProducto`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=41 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla controlstock.bajaprodmotivo
CREATE TABLE IF NOT EXISTS `bajaprodmotivo` (
  `idMotivo` smallint(5) unsigned NOT NULL AUTO_INCREMENT,
  `Motivo` varchar(50) COLLATE utf8_spanish_ci NOT NULL,
  PRIMARY KEY (`idMotivo`),
  UNIQUE KEY `Motivo` (`Motivo`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla controlstock.cajamostrador
CREATE TABLE IF NOT EXISTS `cajamostrador` (
  `idCaja` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `NroCaja` tinyint(3) unsigned NOT NULL DEFAULT '1',
  `idEmpleadoFK` int(10) unsigned NOT NULL,
  `FechaApertura` datetime NOT NULL,
  `FechaCierre` datetime DEFAULT NULL,
  `MontoInicial` int(11) unsigned NOT NULL,
  `MontoFinal` int(11) DEFAULT NULL,
  PRIMARY KEY (`idCaja`),
  KEY `FK_cajamostrador_empleado` (`idEmpleadoFK`),
  CONSTRAINT `FK_cajamostrador_empleado` FOREIGN KEY (`idEmpleadoFK`) REFERENCES `empleado` (`CI`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla controlstock.categoria_prod
CREATE TABLE IF NOT EXISTS `categoria_prod` (
  `id_categoria` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `descripcion` char(30) COLLATE utf8_spanish_ci NOT NULL,
  PRIMARY KEY (`id_categoria`),
  UNIQUE KEY `descripcion` (`descripcion`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla controlstock.cliente
CREATE TABLE IF NOT EXISTS `cliente` (
  `CI` char(15) COLLATE utf8_spanish_ci NOT NULL,
  `Nombre` varchar(50) COLLATE utf8_spanish_ci NOT NULL,
  `Telefono` varchar(15) COLLATE utf8_spanish_ci DEFAULT NULL,
  `Direccion` varchar(100) COLLATE utf8_spanish_ci DEFAULT NULL,
  `Propietario` char(50) COLLATE utf8_spanish_ci DEFAULT '',
  PRIMARY KEY (`CI`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla controlstock.comisionpagada
CREATE TABLE IF NOT EXISTS `comisionpagada` (
  `Fecha` date NOT NULL,
  `IdEmpleado` int(10) unsigned NOT NULL,
  `Periodo` char(25) COLLATE utf8_spanish_ci NOT NULL,
  `Monto` int(10) NOT NULL,
  PRIMARY KEY (`Fecha`,`IdEmpleado`),
  KEY `FK_ComisionPagada_empleado` (`IdEmpleado`),
  CONSTRAINT `FK_ComisionPagada_empleado` FOREIGN KEY (`IdEmpleado`) REFERENCES `empleado` (`CI`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla controlstock.compra
CREATE TABLE IF NOT EXISTS `compra` (
  `idCompra` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `idProveedorFK` char(15) COLLATE utf8_spanish_ci NOT NULL,
  `Fecha` datetime NOT NULL,
  `Cancelado` enum('Si','No') COLLATE utf8_spanish_ci NOT NULL,
  `Entregado` int(10) unsigned DEFAULT NULL,
  `Vto` date DEFAULT NULL,
  PRIMARY KEY (`idCompra`),
  KEY `FK_compra_proveedor` (`idProveedorFK`),
  CONSTRAINT `FK_compra_proveedor` FOREIGN KEY (`idProveedorFK`) REFERENCES `proveedor` (`RUC`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla controlstock.detallecompra
CREATE TABLE IF NOT EXISTS `detallecompra` (
  `idCompraFK` int(10) unsigned NOT NULL,
  `idProductoFK` char(20) COLLATE utf8_spanish_ci NOT NULL,
  `Cantidad` double unsigned NOT NULL,
  `Unidades` int(10) unsigned NOT NULL DEFAULT '1',
  `Precio` int(10) unsigned NOT NULL,
  `Obs` enum('','(Paquete)','(Caja)') COLLATE utf8_spanish_ci NOT NULL,
  PRIMARY KEY (`idCompraFK`,`idProductoFK`),
  KEY `FK_detallecompra_venta` (`idProductoFK`),
  CONSTRAINT `FK_detallecompra_compra` FOREIGN KEY (`idCompraFK`) REFERENCES `compra` (`idCompra`),
  CONSTRAINT `FK_detallecompra_producto` FOREIGN KEY (`idProductoFK`) REFERENCES `producto` (`idProducto`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- La exportación de datos fue deseleccionada.
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
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla controlstock.detalleventa
CREATE TABLE IF NOT EXISTS `detalleventa` (
  `idVentaFK` int(10) unsigned NOT NULL,
  `idProductoFK` char(20) COLLATE utf8_spanish_ci NOT NULL,
  `Cantidad` double unsigned NOT NULL,
  `Unidades` double unsigned NOT NULL DEFAULT '1',
  `Precio` int(10) unsigned DEFAULT NULL,
  `Obs` enum('','(Paquete)','(Caja)','(metros)','(Entero)','(Unidades)') COLLATE utf8_spanish_ci NOT NULL,
  `Descuento` tinyint(10) unsigned DEFAULT NULL,
  PRIMARY KEY (`idVentaFK`,`idProductoFK`),
  KEY `FK_detalleventa_producto` (`idProductoFK`),
  CONSTRAINT `FK_detalleventa_producto` FOREIGN KEY (`idProductoFK`) REFERENCES `producto` (`idProducto`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `FK_detalleventa_venta` FOREIGN KEY (`idVentaFK`) REFERENCES `venta` (`idVenta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla controlstock.detnotaccompra
CREATE TABLE IF NOT EXISTS `detnotaccompra` (
  `idNotaFK` int(10) unsigned NOT NULL,
  `idCompraFK` int(10) unsigned NOT NULL,
  `idProductoFK` char(20) COLLATE utf8_spanish_ci NOT NULL,
  `Cantidad` double unsigned NOT NULL,
  `Unidades` int(10) unsigned NOT NULL,
  PRIMARY KEY (`idNotaFK`,`idCompraFK`,`idProductoFK`),
  KEY `FK_detnotaccompra_detallecompra` (`idCompraFK`,`idProductoFK`),
  CONSTRAINT `FK_detnotaccompra_detallecompra` FOREIGN KEY (`idCompraFK`, `idProductoFK`) REFERENCES `detallecompra` (`idCompraFK`, `idProductoFK`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `FK_detnotaccompra_notaccompra` FOREIGN KEY (`idNotaFK`) REFERENCES `notaccompra` (`idNota`),
  CONSTRAINT `FK_detnotaccompra_notaccompra_2` FOREIGN KEY (`idCompraFK`) REFERENCES `notaccompra` (`idCompraFK`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla controlstock.detnotacventa
CREATE TABLE IF NOT EXISTS `detnotacventa` (
  `idNotaFK` int(10) unsigned NOT NULL,
  `idVentaFK` int(10) unsigned NOT NULL,
  `idProductoFK` char(20) COLLATE utf8_spanish_ci NOT NULL,
  `Cantidad` double unsigned NOT NULL,
  `Unidades` int(10) DEFAULT NULL,
  PRIMARY KEY (`idNotaFK`,`idVentaFK`,`idProductoFK`),
  KEY `FK_detnotacventa_detalleventa` (`idVentaFK`,`idProductoFK`),
  CONSTRAINT `FK_detnotacventa_detalleventa` FOREIGN KEY (`idVentaFK`, `idProductoFK`) REFERENCES `detalleventa` (`idVentaFK`, `idProductoFK`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `FK_detnotacventa_notacventa` FOREIGN KEY (`idNotaFK`) REFERENCES `notacventa` (`idNota`),
  CONSTRAINT `FK_detnotacventa_notacventa_2` FOREIGN KEY (`idVentaFK`) REFERENCES `notacventa` (`idVentaFK`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla controlstock.empleado
CREATE TABLE IF NOT EXISTS `empleado` (
  `CI` int(10) unsigned NOT NULL,
  `Nombre` char(50) COLLATE utf8_spanish_ci NOT NULL,
  `Apellido` char(50) COLLATE utf8_spanish_ci NOT NULL,
  `Telefono` char(15) COLLATE utf8_spanish_ci DEFAULT NULL,
  `Direccion` char(100) COLLATE utf8_spanish_ci DEFAULT NULL,
  `Comision` tinyint(3) unsigned DEFAULT NULL,
  `Estado` enum('Activo','Inactivo') COLLATE utf8_spanish_ci NOT NULL DEFAULT 'Activo',
  PRIMARY KEY (`CI`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla controlstock.gasto
CREATE TABLE IF NOT EXISTS `gasto` (
  `idGasto` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Descripcion` int(10) unsigned NOT NULL,
  `Fecha` datetime NOT NULL,
  `Importe` int(10) unsigned NOT NULL,
  PRIMARY KEY (`idGasto`),
  KEY `FK_gastos_listagastos` (`Descripcion`),
  CONSTRAINT `FK_gastos_listagastos` FOREIGN KEY (`Descripcion`) REFERENCES `listagasto` (`IdGasto`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla controlstock.habitacion
CREATE TABLE IF NOT EXISTS `habitacion` (
  `idHabitacion` tinyint(3) unsigned NOT NULL AUTO_INCREMENT,
  `idServHabFK` tinyint(3) unsigned NOT NULL,
  `Descripcion` char(50) COLLATE utf8_spanish_ci NOT NULL,
  `Precio` mediumint(8) unsigned NOT NULL,
  PRIMARY KEY (`idHabitacion`,`idServHabFK`),
  KEY `FK_habitacion_serviciohabitacion` (`idServHabFK`),
  CONSTRAINT `FK_habitacion_serviciohabitacion` FOREIGN KEY (`idServHabFK`) REFERENCES `serviciohabitacion` (`idServHab`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla controlstock.habitacion2
CREATE TABLE IF NOT EXISTS `habitacion2` (
  `NroHabitacion` tinyint(3) unsigned NOT NULL AUTO_INCREMENT,
  `Precio1` mediumint(8) unsigned NOT NULL,
  `Precio2` mediumint(8) unsigned NOT NULL,
  `Precio3` mediumint(8) unsigned NOT NULL,
  PRIMARY KEY (`NroHabitacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla controlstock.habitacionajustes
CREATE TABLE IF NOT EXISTS `habitacionajustes` (
  `IdAjuste` tinyint(3) unsigned NOT NULL AUTO_INCREMENT,
  `MargerEntrada` smallint(5) unsigned NOT NULL,
  `MargenSalida` smallint(5) unsigned NOT NULL,
  `Tolerancia` smallint(5) unsigned NOT NULL,
  PRIMARY KEY (`IdAjuste`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla controlstock.listagasto
CREATE TABLE IF NOT EXISTS `listagasto` (
  `IdGasto` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(100) COLLATE utf8_spanish_ci NOT NULL DEFAULT ' ',
  PRIMARY KEY (`IdGasto`),
  UNIQUE KEY `Descripcion` (`Descripcion`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla controlstock.marca
CREATE TABLE IF NOT EXISTS `marca` (
  `idMarca` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(20) COLLATE utf8_spanish_ci NOT NULL,
  PRIMARY KEY (`idMarca`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla controlstock.modelo
CREATE TABLE IF NOT EXISTS `modelo` (
  `idModelo` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(20) COLLATE utf8_spanish_ci NOT NULL,
  `MarcaFK` int(10) unsigned NOT NULL,
  PRIMARY KEY (`idModelo`),
  KEY `modeloFK_marca` (`MarcaFK`),
  CONSTRAINT `modeloFK_marca` FOREIGN KEY (`MarcaFK`) REFERENCES `marca` (`idMarca`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla controlstock.notaccompra
CREATE TABLE IF NOT EXISTS `notaccompra` (
  `idNota` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `idCompraFK` int(10) unsigned NOT NULL,
  `Fecha` datetime NOT NULL,
  PRIMARY KEY (`idNota`),
  KEY `FK_NotaCredCompra_compra` (`idCompraFK`),
  CONSTRAINT `FK_NotaCredCompra_compra` FOREIGN KEY (`idCompraFK`) REFERENCES `compra` (`idCompra`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla controlstock.notacventa
CREATE TABLE IF NOT EXISTS `notacventa` (
  `idNota` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `idVentaFK` int(10) unsigned NOT NULL,
  `Fecha` datetime NOT NULL,
  PRIMARY KEY (`idNota`),
  KEY `FK_notacventa_venta` (`idVentaFK`),
  CONSTRAINT `FK_notacventa_venta` FOREIGN KEY (`idVentaFK`) REFERENCES `venta` (`idVenta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- La exportación de datos fue deseleccionada.
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
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla controlstock.ocupacionsensor
CREATE TABLE IF NOT EXISTS `ocupacionsensor` (
  `idOcupacion` int(20) unsigned NOT NULL AUTO_INCREMENT,
  `NroHabitacion` tinyint(3) unsigned NOT NULL,
  `HraEntrada` datetime NOT NULL,
  `HraSalida` datetime DEFAULT NULL,
  PRIMARY KEY (`idOcupacion`),
  KEY `FK_ocupacionsensor_habitacion2` (`NroHabitacion`),
  CONSTRAINT `FK_ocupacionsensor_habitacion2` FOREIGN KEY (`NroHabitacion`) REFERENCES `habitacion2` (`NroHabitacion`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla controlstock.pedidoc
CREATE TABLE IF NOT EXISTS `pedidoc` (
  `idPedido` int(20) unsigned NOT NULL AUTO_INCREMENT,
  `idProveedor` char(15) COLLATE utf8_spanish_ci NOT NULL,
  `Fecha` date NOT NULL,
  `FechaRecibo` date NOT NULL,
  `Estado` enum('Abierto','Cerrado') COLLATE utf8_spanish_ci NOT NULL,
  PRIMARY KEY (`idPedido`),
  KEY `FK_pedidoc_proveedor` (`idProveedor`),
  CONSTRAINT `FK_pedidoc_proveedor` FOREIGN KEY (`idProveedor`) REFERENCES `proveedor` (`RUC`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- La exportación de datos fue deseleccionada.
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
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla controlstock.producto
CREATE TABLE IF NOT EXISTS `producto` (
  `idProducto` char(20) COLLATE utf8_spanish_ci NOT NULL,
  `idProveedorFK` char(15) COLLATE utf8_spanish_ci NOT NULL,
  `idCategoriaFk` int(10) unsigned NOT NULL DEFAULT '1',
  `Descripcion` char(50) COLLATE utf8_spanish_ci NOT NULL,
  `Costo` int(10) unsigned NOT NULL,
  `Precio1` int(10) unsigned NOT NULL,
  `Precio2` int(10) unsigned NOT NULL,
  `Precio3` int(10) unsigned NOT NULL,
  `PrecioPack` int(10) unsigned DEFAULT NULL,
  `Stock` double unsigned NOT NULL,
  `UnidXpack` double unsigned DEFAULT NULL,
  `PorPack` enum('Si','No','Kilo','Tiempo','SiCaja','SiMetro','Piso') COLLATE utf8_spanish_ci DEFAULT NULL,
  `Foto` longblob,
  `Iva` tinyint(4) unsigned NOT NULL DEFAULT '10',
  `Lado1` double unsigned DEFAULT NULL,
  `Lado2` double unsigned DEFAULT NULL,
  `MxCaja` double unsigned DEFAULT NULL,
  PRIMARY KEY (`idProducto`),
  KEY `FK_producto_proveedor` (`idProveedorFK`),
  KEY `FK_producto_categoria_prod` (`idCategoriaFk`),
  CONSTRAINT `FK_producto_categoria_prod` FOREIGN KEY (`idCategoriaFk`) REFERENCES `categoria_prod` (`id_categoria`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `FK_producto_proveedor` FOREIGN KEY (`idProveedorFK`) REFERENCES `proveedor` (`RUC`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla controlstock.proveedor
CREATE TABLE IF NOT EXISTS `proveedor` (
  `RUC` char(15) COLLATE utf8_spanish_ci NOT NULL,
  `Nombre` char(50) COLLATE utf8_spanish_ci NOT NULL,
  `Telefono` char(15) COLLATE utf8_spanish_ci DEFAULT NULL,
  `Direccion` char(100) COLLATE utf8_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`RUC`),
  UNIQUE KEY `Nombre` (`Nombre`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla controlstock.recibocobrocuenta
CREATE TABLE IF NOT EXISTS `recibocobrocuenta` (
  `idRecibo` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `idVentaFK` int(10) unsigned NOT NULL,
  `Fecha` datetime NOT NULL,
  `Importe` int(10) unsigned NOT NULL,
  PRIMARY KEY (`idRecibo`),
  KEY `FK_recibocobrocuenta_venta` (`idVentaFK`),
  CONSTRAINT `FK_recibocobrocuenta_venta` FOREIGN KEY (`idVentaFK`) REFERENCES `venta` (`idVenta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla controlstock.recibopagocuenta
CREATE TABLE IF NOT EXISTS `recibopagocuenta` (
  `idRecibo` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `idCompraFk` int(10) unsigned NOT NULL,
  `Fecha` datetime NOT NULL,
  `Importe` int(10) unsigned NOT NULL,
  PRIMARY KEY (`idRecibo`),
  KEY `FK_recibopagocuenta_compra` (`idCompraFk`),
  CONSTRAINT `FK_recibopagocuenta_compra` FOREIGN KEY (`idCompraFk`) REFERENCES `compra` (`idCompra`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla controlstock.serviciohabitacion
CREATE TABLE IF NOT EXISTS `serviciohabitacion` (
  `idServHab` tinyint(3) unsigned NOT NULL AUTO_INCREMENT,
  `Descripcion` char(30) COLLATE utf8_spanish_ci NOT NULL,
  `Tiempo` smallint(4) DEFAULT NULL,
  `HraEntrada` time DEFAULT NULL,
  `HraSalida` time DEFAULT NULL,
  PRIMARY KEY (`idServHab`),
  UNIQUE KEY `Descripcion` (`Descripcion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla controlstock.usuario
CREATE TABLE IF NOT EXISTS `usuario` (
  `idUsuario` int(10) NOT NULL AUTO_INCREMENT,
  `Usuario` char(50) COLLATE utf8_spanish_ci NOT NULL,
  `Pass` char(50) COLLATE utf8_spanish_ci NOT NULL,
  `idPrivilegioFK` int(10) unsigned NOT NULL,
  `idEmpleadoFK` int(10) unsigned NOT NULL,
  PRIMARY KEY (`idUsuario`),
  UNIQUE KEY `Usuario` (`Usuario`),
  UNIQUE KEY `idEmpleadoFK` (`idEmpleadoFK`),
  KEY `FK_usuario_privilegio` (`idPrivilegioFK`),
  KEY `FK_usuario_empleado` (`idEmpleadoFK`),
  CONSTRAINT `FK_usuario_empleado` FOREIGN KEY (`idEmpleadoFK`) REFERENCES `empleado` (`CI`) ON UPDATE CASCADE,
  CONSTRAINT `FK_usuario_privilegio` FOREIGN KEY (`idPrivilegioFK`) REFERENCES `privilegio` (`idPrivilegio`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla controlstock.venta
CREATE TABLE IF NOT EXISTS `venta` (
  `idVenta` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `idEmpleadoFK` int(10) unsigned NOT NULL,
  `idClienteFK` char(15) COLLATE utf8_spanish_ci NOT NULL DEFAULT '1',
  `Fecha` datetime NOT NULL,
  `Cancelado` enum('Si','No') COLLATE utf8_spanish_ci NOT NULL,
  `Entregado` int(10) unsigned DEFAULT NULL,
  `Vto` date DEFAULT NULL,
  `PagoComision` enum('Si','No') COLLATE utf8_spanish_ci NOT NULL DEFAULT 'No',
  PRIMARY KEY (`idVenta`),
  KEY `FK_venta_empleado` (`idEmpleadoFK`),
  KEY `FK_venta_cliente` (`idClienteFK`),
  KEY `Cancelado` (`Cancelado`),
  CONSTRAINT `FK_venta_cliente` FOREIGN KEY (`idClienteFK`) REFERENCES `cliente` (`CI`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `FK_venta_empleado` FOREIGN KEY (`idEmpleadoFK`) REFERENCES `empleado` (`CI`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para vista controlstock.viewaltaprod
-- Creando tabla temporal para superar errores de dependencia de VIEW
CREATE TABLE `viewaltaprod` (
	`idAlta` INT(10) UNSIGNED NOT NULL,
	`Fecha` DATETIME NOT NULL,
	`idProductoFK` CHAR(20) NOT NULL COLLATE 'utf8_spanish_ci',
	`Descripcion` CHAR(50) NOT NULL COLLATE 'utf8_spanish_ci',
	`Motivo` VARCHAR(50) NOT NULL COLLATE 'utf8_spanish_ci',
	`Cantidad` DOUBLE NOT NULL
) ENGINE=MyISAM;

-- Volcando estructura para vista controlstock.viewbajaprod
-- Creando tabla temporal para superar errores de dependencia de VIEW
CREATE TABLE `viewbajaprod` (
	`idBaja` INT(10) UNSIGNED NOT NULL,
	`Fecha` DATETIME NOT NULL,
	`idProductoFK` CHAR(20) NOT NULL COLLATE 'utf8_spanish_ci',
	`Descripcion` CHAR(50) NOT NULL COLLATE 'utf8_spanish_ci',
	`Motivo` VARCHAR(50) NOT NULL COLLATE 'utf8_spanish_ci',
	`Cantidad` DOUBLE NOT NULL
) ENGINE=MyISAM;

-- Volcando estructura para vista controlstock.viewcajamostrador
-- Creando tabla temporal para superar errores de dependencia de VIEW
CREATE TABLE `viewcajamostrador` (
	`Empleado` VARCHAR(101) NOT NULL COLLATE 'utf8_spanish_ci',
	`NroCaja` TINYINT(3) UNSIGNED NOT NULL,
	`FechaIni` DATE NULL,
	`HoraIni` TIME NULL,
	`MontoInicial` INT(11) UNSIGNED NOT NULL,
	`FechaFin` DATE NULL,
	`HoraFin` TIME NULL,
	`MontoFinal` INT(11) NULL
) ENGINE=MyISAM;

-- Volcando estructura para vista controlstock.viewcomision
-- Creando tabla temporal para superar errores de dependencia de VIEW
CREATE TABLE `viewcomision` (
	`CI` INT(10) UNSIGNED NOT NULL,
	`Fecha` DATETIME NOT NULL,
	`Vendedor` VARCHAR(101) NOT NULL COLLATE 'utf8_spanish_ci',
	`Total` DOUBLE NULL,
	`Comision` BIGINT(23) NULL
) ENGINE=MyISAM;

-- Volcando estructura para vista controlstock.viewcompra
-- Creando tabla temporal para superar errores de dependencia de VIEW
CREATE TABLE `viewcompra` (
	`idCompra` INT(10) UNSIGNED NOT NULL,
	`Fecha` DATETIME NOT NULL,
	`RUC` CHAR(15) NOT NULL COLLATE 'utf8_spanish_ci',
	`Proveed` CHAR(50) NOT NULL COLLATE 'utf8_spanish_ci',
	`Total` DOUBLE NULL,
	`Cancelado` ENUM('Si','No') NOT NULL COLLATE 'utf8_spanish_ci',
	`Entregado` INT(10) UNSIGNED NULL,
	`Vto` DATE NULL
) ENGINE=MyISAM;

-- Volcando estructura para vista controlstock.viewdetalleingreso
-- Creando tabla temporal para superar errores de dependencia de VIEW
CREATE TABLE `viewdetalleingreso` (
	`Comprobante` INT(11) UNSIGNED NOT NULL,
	`Cliente` VARCHAR(50) NOT NULL COLLATE 'utf8_spanish_ci',
	`Descripcion` VARCHAR(27) NOT NULL COLLATE 'utf8_general_ci',
	`MedioPago` VARCHAR(8) NOT NULL COLLATE 'utf8_general_ci',
	`Monto` DOUBLE NULL,
	`Fecha` DATETIME NOT NULL
) ENGINE=MyISAM;

-- Volcando estructura para vista controlstock.viewdetcompra
-- Creando tabla temporal para superar errores de dependencia de VIEW
CREATE TABLE `viewdetcompra` (
	`idCompraFK` INT(10) UNSIGNED NOT NULL,
	`idProducto` CHAR(20) NOT NULL COLLATE 'utf8_spanish_ci',
	`Descripcion` VARCHAR(60) NOT NULL COLLATE 'utf8_spanish_ci',
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
	`idProducto` CHAR(20) NOT NULL COLLATE 'utf8_spanish_ci',
	`Descripcion` VARCHAR(60) NOT NULL COLLATE 'utf8_spanish_ci',
	`Cantidad` DOUBLE NOT NULL,
	`Precio` INT(10) UNSIGNED NOT NULL,
	`Importe` DOUBLE NOT NULL
) ENGINE=MyISAM;

-- Volcando estructura para vista controlstock.viewdetnotacventa
-- Creando tabla temporal para superar errores de dependencia de VIEW
CREATE TABLE `viewdetnotacventa` (
	`idNotaFK` INT(10) UNSIGNED NOT NULL,
	`idVentaFK` INT(10) UNSIGNED NOT NULL,
	`idProducto` CHAR(20) NOT NULL COLLATE 'utf8_spanish_ci',
	`Descripcion` VARCHAR(61) NOT NULL COLLATE 'utf8_spanish_ci',
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
	`Descripcion` VARCHAR(139) NOT NULL COLLATE 'utf8_bin',
	`Tiempo` SMALLINT(5) UNSIGNED NOT NULL,
	`Precio` INT(10) UNSIGNED NOT NULL,
	`SubTotal` INT(10) UNSIGNED NOT NULL
) ENGINE=MyISAM;

-- Volcando estructura para vista controlstock.viewdetventa
-- Creando tabla temporal para superar errores de dependencia de VIEW
CREATE TABLE `viewdetventa` (
	`idVentaFK` INT(10) UNSIGNED NOT NULL,
	`idProducto` CHAR(20) NOT NULL COLLATE 'utf8_spanish_ci',
	`Descripcion` VARCHAR(61) NOT NULL COLLATE 'utf8_spanish_ci',
	`Cantidad` DOUBLE NOT NULL,
	`Unidades` DOUBLE NOT NULL,
	`Precio` INT(10) UNSIGNED NULL,
	`Importe` DOUBLE NULL,
	`Descuento` TINYINT(10) UNSIGNED NULL
) ENGINE=MyISAM;

-- Volcando estructura para vista controlstock.viewgasto
-- Creando tabla temporal para superar errores de dependencia de VIEW
CREATE TABLE `viewgasto` (
	`idGasto` INT(10) UNSIGNED NOT NULL,
	`Descripcion` VARCHAR(100) NOT NULL COLLATE 'utf8_spanish_ci',
	`Fecha` DATETIME NOT NULL,
	`Importe` INT(10) UNSIGNED NOT NULL
) ENGINE=MyISAM;

-- Volcando estructura para vista controlstock.viewnotaccompra
-- Creando tabla temporal para superar errores de dependencia de VIEW
CREATE TABLE `viewnotaccompra` (
	`idNota` INT(10) UNSIGNED NOT NULL,
	`idCompraFK` INT(10) UNSIGNED NOT NULL,
	`Fecha` DATETIME NOT NULL,
	`RUC` CHAR(15) NOT NULL COLLATE 'utf8_spanish_ci',
	`proveed` CHAR(50) NOT NULL COLLATE 'utf8_spanish_ci',
	`Total` DOUBLE NULL
) ENGINE=MyISAM;

-- Volcando estructura para vista controlstock.viewnotacventa
-- Creando tabla temporal para superar errores de dependencia de VIEW
CREATE TABLE `viewnotacventa` (
	`idNota` INT(10) UNSIGNED NOT NULL,
	`idVentaFK` INT(10) UNSIGNED NOT NULL,
	`Fecha` DATETIME NOT NULL,
	`CI` INT(10) UNSIGNED NOT NULL,
	`Vendedor` VARCHAR(101) NOT NULL COLLATE 'utf8_spanish_ci',
	`Total` DOUBLE NULL,
	`Clien` VARCHAR(50) NOT NULL COLLATE 'utf8_spanish_ci'
) ENGINE=MyISAM;

-- Volcando estructura para vista controlstock.viewproducto
-- Creando tabla temporal para superar errores de dependencia de VIEW
CREATE TABLE `viewproducto` (
	`idProducto` CHAR(20) NOT NULL COLLATE 'utf8_spanish_ci',
	`ProveedorFK` CHAR(50) NOT NULL COLLATE 'utf8_spanish_ci',
	`Descripcion` CHAR(50) NOT NULL COLLATE 'utf8_spanish_ci',
	`Costo` INT(10) UNSIGNED NOT NULL,
	`Precio1` INT(10) UNSIGNED NOT NULL,
	`Precio2` INT(10) UNSIGNED NOT NULL,
	`Stock` DOUBLE NOT NULL,
	`PorPack` ENUM('Si','No','Kilo','Tiempo','SiCaja','SiMetro','Piso') NULL COLLATE 'utf8_spanish_ci',
	`PrecioPack` INT(10) UNSIGNED NULL,
	`Categoria` CHAR(30) NOT NULL COLLATE 'utf8_spanish_ci'
) ENGINE=MyISAM;

-- Volcando estructura para vista controlstock.viewusuario
-- Creando tabla temporal para superar errores de dependencia de VIEW
CREATE TABLE `viewusuario` (
	`idUsuario` INT(10) NOT NULL,
	`Usuario` CHAR(50) NOT NULL COLLATE 'utf8_spanish_ci',
	`Pass` CHAR(50) NOT NULL COLLATE 'utf8_spanish_ci',
	`PrivilegioFK` VARCHAR(20) NOT NULL COLLATE 'utf8_spanish_ci',
	`idEmpleadoFK` INT(10) UNSIGNED NOT NULL
) ENGINE=MyISAM;

-- Volcando estructura para vista controlstock.viewventa
-- Creando tabla temporal para superar errores de dependencia de VIEW
CREATE TABLE `viewventa` (
	`idVenta` INT(10) UNSIGNED NOT NULL,
	`Fecha` DATETIME NOT NULL,
	`CI` INT(10) UNSIGNED NOT NULL,
	`Vendedor` VARCHAR(101) NOT NULL COLLATE 'utf8_spanish_ci',
	`Clien` VARCHAR(50) NOT NULL COLLATE 'utf8_spanish_ci',
	`Total` DOUBLE NULL,
	`Cancelado` ENUM('Si','No') NOT NULL COLLATE 'utf8_spanish_ci',
	`Entregado` INT(10) UNSIGNED NULL,
	`Vto` DATE NULL,
	`PagoComision` ENUM('Si','No') NOT NULL COLLATE 'utf8_spanish_ci'
) ENGINE=MyISAM;

-- Volcando estructura para procedimiento controlstock.zcajam_abrir
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zcajam_abrir`(
	IN `NumCaja` TINYINT,
	IN `idEmple` INT,
	IN `MontoIni` INT


)
BEGIN
	INSERT INTO `cajamostrador` (`NroCaja`, `idEmpleadoFK`, `MontoInicial`, `FechaApertura`) 
	VALUES (NumCaja, idEmple, MontoIni, NOW());
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zcajam_buscar
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zcajam_buscar`(
	IN `Fecha` DATE
)
BEGIN
SELECT *		
FROM viewcajamostrador C
WHERE DATE(C.FechaIni) = Fecha;
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zcajam_buscar2
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zcajam_buscar2`(
	IN `Fecha` DATE,
	IN `Hora` TIME
)
BEGIN
	SELECT *
	FROM viewcajamostrador VC
	WHERE VC.FechaIni = Fecha
		AND VC.HoraIni = Hora
	LIMIT 1;
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zcajam_calc_montofin
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zcajam_calc_montofin`(
	IN `NumCaja` TINYINT,
	OUT `MontoFin` INT










)
BEGIN
	/* Fondo Inicial + Ventas al Contado + Cobro s/ Ventas a Crédito - Deboluciones */

	DECLARE MontoRec INT;
	DECLARE MontoDevol INT;
	DECLARE FechaIni DATETIME;
	DECLARE MontoIni INT;
	CALL `zcajam_get_fechaini`(NumCaja, FechaIni);
	CALL `zcalc_rec_venta`(FechaIni, NOW(), MontoRec);
	CALL `zcalc_devol_venta`(FechaIni, NOW(), MontoDevol);
	CALL `zcajam_get_montoini`(NumCaja, MontoIni);
	
	SELECT (IF(ISNULL(SUM(V.Total)), 0, SUM(V.Total)) +	MontoRec - MontoDevol + MontoIni) INTO MontoFin
	FROM viewventa V
	WHERE V.Fecha > FechaIni
		AND V.Fecha < NOW()
		AND V.Cancelado = 'Si'
		AND v.Entregado = 0;
		
	SELECT MontoFin;
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zcajam_cerrar
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zcajam_cerrar`(
	IN `NumCaja` TINYINT










)
BEGIN
	DECLARE MontoFin INT;
	CALL `zcajam_calc_montofin`(NumCaja, MontoFin);	

	UPDATE cajamostrador c
	SET c.FechaCierre = NOW(), c.MontoFinal = MontoFin
	WHERE idCaja = (SELECT maxId 
								FROM(
									SELECT DISTINCT MAX(idCaja) AS maxId	/*busca el id máximo para una caja específica*/
									FROM cajamostrador 
									WHERE NroCaja = NumCaja
										AND isnull(FechaCierre)) AS d			/*y que la fecha sea nula*/
								);
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zcajam_get_fechafin
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zcajam_get_fechafin`(
	IN `NumCaja` TINYINT,
	IN `Fecha` DATETIME
)
BEGIN
	SELECT C.FechaCierre INTO Fecha
	FROM cajamostrador C
	WHERE C.NroCaja = NumCaja
		AND C.idCaja = (SELECT MAX(idCaja) FROM cajamostrador);
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zcajam_get_fechaini
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zcajam_get_fechaini`(
	IN `NumCaja` TINYINT,
	OUT `Fecha` DATETIME


)
BEGIN
	/*Obtiene la fecha de apertura de la ultima caja abierta para una caja especifica*/
	SELECT C.FechaApertura INTO Fecha
	FROM cajamostrador C
	WHERE C.NroCaja = NumCaja
		AND ISNULL(C.FechaCierre);
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zcajam_get_montoini
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zcajam_get_montoini`(
	IN `NumCaja` TINYINT
,
	OUT `MontoIni` INT

)
BEGIN
	SELECT C.MontoInicial INTO MontoIni
	FROM cajamostrador C
	WHERE C.NroCaja = NumCaja
		AND ISNULL(C.FechaCierre);
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zcajam_verificar
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zcajam_verificar`(
	IN `NumCaja` INT
)
    COMMENT 'Devuelve un valor mayor a 0 si una caja no ha sido cerrada'
BEGIN
	SELECT count(c.idCaja)
	FROM cajamostrador c	
	WHERE c.NroCaja = NumCaja
		AND isnull(c.FechaCierre);	
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zcalc_devol_venta
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zcalc_devol_venta`(
	IN `Fecha1` DATETIME,
	IN `Fecha2` DATETIME
,
	OUT `Monto` INT
)
BEGIN
SELECT IF(ISNULL(SUM(N.Total)), 0, SUM(N.Total)) INTO Monto
			 FROM viewnotacventa N 
			 WHERE N.Fecha > Fecha1
			 AND N.Fecha < Fecha2;
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zcalc_rec_venta
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zcalc_rec_venta`(
	IN `Fecha1` DATETIME,
	IN `Fecha2` DATETIME
,
	OUT `Monto` INT
)
BEGIN
	SELECT IF(ISNULL(SUM(R.Importe)), 0, SUM(R.Importe)) INTO Monto
			 FROM recibocobrocuenta R 
			 WHERE R.Fecha > Fecha1
			 AND R.Fecha < Fecha2;
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zcalc_ventacontado
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zcalc_ventacontado`(
	IN `Fecha1` DATETIME,
	IN `Fecha2` DATETIME

)
BEGIN
SELECT IF(ISNULL(SUM(V.Total)), 0, SUM(V.Total)) 
FROM viewventa V
WHERE V.Fecha > Fecha1
	AND V.Fecha < Fecha2
	AND V.Cancelado = 'Si'
	AND v.Entregado = 0;
END//
DELIMITER ;

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

-- Volcando estructura para procedimiento controlstock.zingreso_busc_detalle
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zingreso_busc_detalle`(
	IN `FechaIni` DATETIME,
	IN `FechaFin` DATETIME


)
BEGIN
	SELECT *
	FROM viewdetalleingreso R
	WHERE R.Fecha > FechaIni
		AND R.Fecha < FechaFin;
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zingreso_busc_resum
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zingreso_busc_resum`(
	IN `FechaIni` DATETIME,
	IN `FechaFin` DATETIME
)
BEGIN
	SELECT R.MedioPago, SUM(R.Monto) AS Monto
	FROM viewdetalleingreso R
	WHERE R.Fecha > FechaIni
		AND R.Fecha < FechaFin
	GROUP BY R.MedioPago;
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zingreso_busc_totales
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zingreso_busc_totales`(
	IN `FechaIni` DATETIME,
	IN `FechaFin` DATETIME

)
BEGIN
	SELECT R.Descripcion, SUM(R.Monto) AS Monto
	FROM viewdetalleingreso R
	WHERE R.Fecha > FechaIni
		AND R.Fecha < FechaFin
	GROUP BY R.Descripcion
	ORDER BY R.Descripcion DESC;
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
CREATE DEFINER=`root`@`localhost` PROCEDURE `zproducto_insert`(
	IN `idprod` CHAR(20),
	IN `idprov` CHAR(15),
	IN `idcateg` INT,
	IN `descrip` CHAR(50),
	IN `costo` INT,
	IN `precio1` INT,
	IN `precio2` INT,
	IN `precio3` INT,
	IN `preciopack` INT,
	IN `stock` DOUBLE,
	IN `unidxpack` DOUBLE,
	IN `porpack` ENUM('Si','No','Kilo','Tiempo','SiCaja','SiMetro','Piso'),
	IN `foto` LONGBLOB,
	IN `iva` TINYINT


,
	IN `lado1` DOUBLE,
	IN `lado2` DOUBLE
,
	IN `mxcaja` DOUBLE


)
BEGIN
INSERT INTO Producto 
VALUES(idprod, idprov, idcateg, descrip, costo, precio1, precio2, precio3, preciopack, stock, unidxpack, porpack, foto, iva, lado1, lado2, mxcaja);
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zproducto_update
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zproducto_update`(
	IN `idprod` CHAR(20),
	IN `idprov` CHAR(15),
	IN `idcateg` INT,
	IN `descrip` CHAR(50),
	IN `Cost` INT,
	IN `Prec1` INT,
	IN `Prec2` INT,
	IN `Prec3` INT,
	IN `PrecPack` INT,
	IN `cantunit` DOUBLE,
	IN `unidxpak` DOUBLE,
	IN `porpak` ENUM('Si','No','Kilo','Tiempo','SiCaja','SiMetro','Piso'),
	IN `foti` LONGBLOB,
	IN `oldidProd` CHAR(20),
	IN `Iva_` TINYINT



,
	IN `lado1_` DOUBLE,
	IN `lado2_` DOUBLE

,
	IN `mxcaja_` DOUBLE
)
BEGIN
	UPDATE Producto
	SET idProducto = idprod, idProveedorFK = idprov, idCategoriaFK = idcateg, 
		Descripcion = descrip, Costo = Cost, Precio1 = Prec1, Precio2 = Prec2, 
		Precio3 = Prec3, PrecioPack = PrecPack, Stock = cantunit, 
		UnidXpack = unidxpak, PorPack = porpak, Foto = foti, Iva = iva_, 
		Lado1 = lado1_, Lado2 = lado2_, MxCaja = mxcaja_
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
CREATE DEFINER=`root`@`localhost` PROCEDURE `zusuario_buscarxusu`(
	IN `Usu` CHAR(50)
)
BEGIN
	SELECT * FROM viewusuario
	WHERE `Usuario` LIKE CONCAT('%', Usu, '%');
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zusuario_ins
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zusuario_ins`(
	IN `Usu` CHAR(50),
	IN `Pass` CHAR(50),
	IN `Priv` INT,
	IN `Emple` INT
)
BEGIN
	INSERT INTO Usuario(`Usuario`, Pass, idPrivilegioFK, idEmpleadoFK) 
	VALUES(Usu, Pass, Priv, Emple);
END//
DELIMITER ;

-- Volcando estructura para procedimiento controlstock.zusuario_update
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `zusuario_update`(
	IN `idUsu` INT,
	IN `Usu` CHAR(50),
	IN `Pas` CHAR(50),
	IN `idPriv` INT,
	IN `idEmple` INT
)
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

-- Volcando estructura para vista controlstock.viewcajamostrador
-- Eliminando tabla temporal y crear estructura final de VIEW
DROP TABLE IF EXISTS `viewcajamostrador`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewcajamostrador` AS SELECT CONCAT(E.Nombre,' ',E.Apellido) AS Empleado,
			C.NroCaja,
			DATE(C.FechaApertura) AS FechaIni,
			TIME(C.FechaApertura) AS HoraIni,
			C.MontoInicial,
			DATE(C.FechaCierre) AS FechaFin,
			TIME(C.FechaCierre) AS HoraFin,
			C.MontoFinal			
			
FROM cajamostrador C, empleado E
WHERE C.idEmpleadoFK = E.CI ;

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

-- Volcando estructura para vista controlstock.viewdetalleingreso
-- Eliminando tabla temporal y crear estructura final de VIEW
DROP TABLE IF EXISTS `viewdetalleingreso`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY INVOKER VIEW `viewdetalleingreso` AS SELECT V.idVenta AS Comprobante, V.Clien As Cliente, "Venta Contado" As Descripcion, "Efectivo" AS MedioPago, V.Total AS Monto, V.Fecha
FROM viewVenta V
WHERE Cancelado = 'Si' 
AND Entregado = 0
UNION
SELECT R.idRecibo AS Comprobante, VV.Clien As Cliente, "Recibo de Dinero" As Descripcion, "Efectivo" AS MedioPago, R.Importe AS Monto, R.Fecha
FROM recibocobrocuenta R, viewventa VV
WHERE R.idVentaFK = VV.idVenta
UNION
SELECT VN.idNota AS Comprobante, VN.Clien As Cliente, "DevoluciÃƒÆ’Ã†â€™Ãƒâ€ Ã¢â‚¬â„¢ÃƒÆ’Ã¢â‚¬Å¡Ãƒâ€šÃ‚Â³n" As Descripcion, "Efectivo" AS MedioPago, (VN.Total * -1) AS Monto, VN.Fecha
FROM viewnotacventa VN
ORDER BY Fecha ASC ;

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
		 		 concat('HabitaciÃƒÆ’Ã†â€™Ãƒâ€ Ã¢â‚¬â„¢ÃƒÆ’Ã¢â‚¬Â ÃƒÂ¢Ã¢â€šÂ¬Ã¢â€žÂ¢ÃƒÆ’Ã†â€™ÃƒÂ¢Ã¢â€šÂ¬Ã‚Â ÃƒÆ’Ã‚Â¢ÃƒÂ¢Ã¢â‚¬Å¡Ã‚Â¬ÃƒÂ¢Ã¢â‚¬Å¾Ã‚Â¢ÃƒÆ’Ã†â€™Ãƒâ€ Ã¢â‚¬â„¢ÃƒÆ’Ã‚Â¢ÃƒÂ¢Ã¢â‚¬Å¡Ã‚Â¬Ãƒâ€¦Ã‚Â¡ÃƒÆ’Ã†â€™ÃƒÂ¢Ã¢â€šÂ¬Ã…Â¡ÃƒÆ’Ã¢â‚¬Å¡Ãƒâ€šÃ‚Â³n', CAST(d.idHabFK AS CHAR), ' ', s.Descripcion) as Descripcion, 
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
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewproducto` AS SELECT p.idProducto, v.Nombre AS ProveedorFK, p.Descripcion, p.Costo, p.Precio1, p.Precio2, p.Stock, p.PorPack, p.PrecioPack, c.descripcion AS Categoria
from producto p, proveedor v, categoria_prod c
where p.idProveedorFK = v.RUC AND p.idProducto <> "0" AND p.idCategoriaFk = c.id_categoria ;

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
		 (SELECT IF(ISNULL(SUM(doc.SubTotal)), 0, SUM(doc.SubTotal)) 
		 			FROM detalleocupacion doc 
					WHERE doc.idVentaFK = v.idVenta) as Total, 
		 v.Cancelado, 
		 v.Entregado, 
		 v.Vto, 
		 v.PagoComision

FROM venta v, empleado e, cliente c
WHERE v.idEmpleadoFK = e.CI AND v.idClienteFK = c.CI ;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
