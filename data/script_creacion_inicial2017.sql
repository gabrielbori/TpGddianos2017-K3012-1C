/*BASE DE DATOS*/
USE GD1C2017;
-- CREANDO ESQUEMA
BEGIN TRANSACTION

IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = N'GDDIANOS')
EXEC sys.sp_executesql N'CREATE SCHEMA [GDDIANOS] AUTHORIZATION [gd]'
COMMIT;

-- DROP DE TABLAS
IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.ROL_POR_USUARIO') AND OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE GDDIANOS.ROL_POR_USUARIO

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.FUNCIONALIDAD_POR_ROL') AND OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE GDDIANOS.FUNCIONALIDAD_POR_ROL

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.FUNCIONALIDAD') AND OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE GDDIANOS.FUNCIONALIDAD


IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.ROL') AND OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE GDDIANOS.ROL


IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.COCHE') AND OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE GDDIANOS.COCHE


IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.PAGO') AND OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE GDDIANOS.PAGO


IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.FACTURA') AND OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE GDDIANOS.FACTURA

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.VIAJE') AND OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE GDDIANOS.VIAJE

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.CHOFER') AND OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE GDDIANOS.CHOFER


IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.TURNO') AND OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE GDDIANOS.TURNO


IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.CLIENTE') AND OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE GDDIANOS.CLIENTE

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.USUARIO') AND OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE GDDIANOS.USUARIO

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.PERSONA') AND OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE GDDIANOS.PERSONA


/*Drops procedures*/

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.GET_ROLES_USUARIO'))
DROP PROCEDURE GDDIANOS.GET_ROLES_USUARIO



/**************/
/* SECUENCIAS */
/**************/

/**********/
/* TABLAS */
/**********/

CREATE TABLE GDDIANOS.PERSONA
(
		PERS_ID INT NOT NULL PRIMARY KEY,
		PERS_TELEFONO NUMERIC (18,0) NOT NULL,
		PERS_NOMBRE VARCHAR(255) NOT NULL,
		PERS_APELLIDO VARCHAR(255) NOT NULL,
		PERS_DNI NUMERIC(18,0) NOT NULL,
		PERS_DIRECCION VARCHAR(255) NOT NULL,
		PERS_FECHA_NACIM DATETIME NULL,
		PERS_ESTADO BIT NOT NULL DEFAULT 1,
		PERS_MAIL VARCHAR(255) NOT NULL DEFAULT 'SIN EMAIL' 
);
CREATE TABLE GDDIANOS.USUARIO
(
		USUA_USERNAME VARCHAR(50) NOT NULL PRIMARY KEY,
		USUA_PASSWORD VARCHAR(10) NOT NULL,
		USUA_CANTIDAD_INTENTOS INT NOT NULL DEFAULT 0,
		USUA_ESTADO BIT NOT NULL DEFAULT 1,
		USUA_PERS_ID INT,
		
		CONSTRAINT FK_USUARIO_PERSONA FOREIGN KEY(USUA_PERS_ID) REFERENCES  GDDIANOS.PERSONA(PERS_ID)
);

CREATE TABLE GDDIANOS.ROL
(	
	ROL_ID INT NOT NULL PRIMARY KEY,
	ROL_NOMBRE VARCHAR(15) NOT NULL,
	ROL_ESTADO BIT NOT NULL DEFAULT 1
);

CREATE TABLE GDDIANOS.ROL_POR_USUARIO
(
	ROL_USUA_USERNAME VARCHAR(50) NOT NULL,
	ROL_ROL_ID INT NOT NULL, 
	
	CONSTRAINT PK_ROL_POR_USUARIO PRIMARY KEY (ROL_USUA_USERNAME,ROL_ROL_ID),
	CONSTRAINT FK_USUARIO_ROL_USUARIO FOREIGN KEY (ROL_USUA_USERNAME) REFERENCES GDDIANOS.USUARIO(USUA_USERNAME),
	CONSTRAINT FK_USUARIO_ROL_ROL FOREIGN KEY (ROL_ROL_ID) REFERENCES GDDIANOS.ROL(ROL_ID)

);

CREATE TABLE GDDIANOS.FUNCIONALIDAD
(
	FUNCIONALIDAD_ID INT NOT NULL PRIMARY KEY,
	DESCRIPCION VARCHAR(255) NOT NULL
);

CREATE TABLE GDDIANOS.FUNCIONALIDAD_POR_ROL
(
	FUNC_ROL_ID INT NOT NULL,
	FUNC_ID INT NOT NULL,
	
	CONSTRAINT PK_FUNCIONALIDAD_POR_ROL_ROL PRIMARY KEY (FUNC_ROL_ID,FUNC_ID),
	CONSTRAINT FK_FUNCIONALIDAD_POR_ROL_ROL FOREIGN KEY (FUNC_ROL_ID) REFERENCES GDDIANOS.ROL(ROL_ID),
	CONSTRAINT FK_FUNCIONALIDAD_POR_ROL_FUNCIONALIDAD FOREIGN KEY (FUNC_ID) REFERENCES GDDIANOS.FUNCIONALIDAD(FUNCIONALIDAD_ID)
);

CREATE TABLE GDDIANOS.CHOFER
(
	CHOF_ID INT NOT NULL PRIMARY KEY,
	CHOF_PERS_ID INT NOT NULL,
	
	CONSTRAINT FK_CHOFER_PERSONA FOREIGN KEY (CHOF_PERS_ID) REFERENCES GDDIANOS.PERSONA(PERS_ID)
);

CREATE TABLE GDDIANOS.COCHE
(
	COCHE_PATENTE CHAR(10) NOT NULL PRIMARY KEY,
	COCHE_ESTADO BIT NOT NULL DEFAULT 1,
	COCHE_MARCA VARCHAR(20) NOT NULL,
	COCHE_MODELO VARCHAR(20) NOT NULL,
	COCHE_CHOF_ID INT NOT NULL,
	
	CONSTRAINT FK_COCHE_CHOFER FOREIGN KEY (COCHE_CHOF_ID) REFERENCES GDDIANOS.CHOFER(CHOF_ID)
);

CREATE TABLE GDDIANOS.CLIENTE
(
	CLIE_ID INT NOT NULL PRIMARY KEY,
	CLIE_COD_POSTAL INT NOT NULL,
	CLIE_PERSO_ID INT NOT NULL,
	
	CONSTRAINT FK_CLIENTE_PERSONA FOREIGN KEY (CLIE_PERSO_ID) REFERENCES GDDIANOS.PERSONA(PERS_ID)

);

CREATE TABLE GDDIANOS.TURNO
(
	TURNO_ID INT NOT NULL PRIMARY KEY,
	TURNO_HORA_INICIO DATETIME NOT NULL,
	TURNO_HORA_FIN DATETIME NOT NULL,
	TURNO_DESCRIPCION VARCHAR(50) NOT NULL,
	TURNO_VALOR_KM FLOAT NOT NULL,
	TURNO_PRECIO_BASE FLOAT NOT NULL,
	TURNO_ESTADO BIT NOT NULL DEFAULT 1
	
	
);

CREATE TABLE GDDIANOS.VIAJE
(
	VIAJE_ID INT NOT NULL PRIMARY KEY,
	VIAJE_TURNO_ID INT NOT NULL,
	VIAJE_FECHA_INICIO DATETIME NOT NULL,
	VIAJE_FECHA_FIN DATETIME NOT NULL,
	VIAJE_CANTIDAD_KM FLOAT NOT NULL,
	VIAJE_CHOF_ID INT NOT NULL,
	VIAJE_CLIENTE_ID INT NOT NULL,
	
	CONSTRAINT FK_VIAJE_TURNO FOREIGN KEY (VIAJE_TURNO_ID) REFERENCES GDDIANOS.TURNO(TURNO_ID),
	CONSTRAINT FK_VIAJE_CHOFER FOREIGN KEY (VIAJE_CHOF_ID) REFERENCES GDDIANOS.CHOFER(CHOF_ID),
	CONSTRAINT FK_VIAJE_CLIENTE FOREIGN KEY (VIAJE_CLIENTE_ID) REFERENCES GDDIANOS.CLIENTE(CLIE_ID)
);

CREATE TABLE GDDIANOS.FACTURA
(
	FACT_ID INT NOT NULL PRIMARY KEY,
	FACT_VIAJE_ID INT NOT NULL,
	FACT_FECHA_GENERADA DATETIME NOT NULL,
	FACT_FECHA_INICIO DATETIME NOT NULL,
	FACT_FECHA_FIN DATETIME NOT NULL,
	FACT_IMPORTA_TOTAL FLOAT NOT NULL,
	
	CONSTRAINT FK_FACTURA_VIAJE FOREIGN KEY (FACT_VIAJE_ID) REFERENCES GDDIANOS.VIAJE(VIAJE_ID)
);

CREATE TABLE GDDIANOS.PAGO
(
	PAGO_FECHA DATETIME NOT NULL,
	PAGO_CHOF_ID INT NOT NULL,
	PAGO_TURNO_ID INT NOT NULL,
	PAGO_IMPORTE_TOTAL FLOAT NOT NULL,
	
	CONSTRAINT FK_PAGO_CHOFER FOREIGN KEY (PAGO_CHOF_ID) REFERENCES GDDIANOS.CHOFER(CHOF_ID)
);

go

<<<<<<< HEAD
=======

>>>>>>> 2d914057a584a96da11e2b6ef960e8164e1297bb
CREATE PROCEDURE GDDIANOS.GET_ROLES_USUARIO(@USUARIO VARCHAR(255)) AS
BEGIN
	SELECT R.ROL_NOMBRE,R.ROL_ID FROM GDDIANOS.ROL R
	INNER JOIN GDDIANOS.ROL_POR_USUARIO RU ON RU.ROL_ROL_ID=R.ROL_ID
	INNER JOIN GDDIANOS.USUARIO U ON U.USUA_USERNAME=RU.ROL_USUA_USERNAME
	WHERE U.USUA_ESTADO=1 AND R.ROL_ESTADO=1 AND U.USUA_USERNAME=@USUARIO
	return 1
END;

GO
INSERT INTO GDDIANOS.PERSONA VALUES (1, 46415743, 'Alex', 'Falcon', 38457835, 'Cosquin 295', 25/10/1994,1,'alex.falcon.25@hotmail.com');
INSERT INTO GDDIANOS.USUARIO VALUES ('afalcon', 'Qwerty1234',0,1,1);

INSERT INTO GDDIANOS.PERSONA VALUES (2, 46415743, 'Rojelio', 'Falcon', 38457834, 'Cosquin 295', 25/10/1994,1,'rojelio.falcon.25@hotmail.com');
INSERT INTO GDDIANOS.USUARIO VALUES ('rfalcon', 'Qwerty1234',0,1,2);

INSERT INTO GDDIANOS.PERSONA VALUES (3, 46415743, 'Jorge', 'Falcon', 38457833, 'Cosquin 295', 25/10/1994,1,'jorge.falcon.25@hotmail.com');
INSERT INTO GDDIANOS.USUARIO VALUES ('jfalcon', 'Qwerty1234',0,1,3);

INSERT INTO GDDIANOS.PERSONA VALUES (4, 123455, 'ADMIN', 'ADMIN', 38457835, 'UBERFRBA', 25/10/1994,1,'');
INSERT INTO GDDIANOS.USUARIO VALUES ('ADMIN', 'ADMIN',0,1,4);

INSERT INTO GDDIANOS.ROL (ROL_ID,ROL_NOMBRE,ROL_ESTADO) VALUES(1,'ADMIN',1);
INSERT INTO GDDIANOS.ROL (ROL_ID,ROL_NOMBRE,ROL_ESTADO) VALUES(2,'CHOFER',1);
INSERT INTO GDDIANOS.ROL (ROL_ID,ROL_NOMBRE,ROL_ESTADO) VALUES(3,'CLIENTE',1);	

INSERT INTO GDDIANOS.ROL_POR_USUARIO (ROL_USUA_USERNAME,ROL_ROL_ID) VALUES('ADMIN',1);
INSERT INTO GDDIANOS.ROL_POR_USUARIO (ROL_USUA_USERNAME,ROL_ROL_ID) VALUES('ADMIN',2);
INSERT INTO GDDIANOS.ROL_POR_USUARIO (ROL_USUA_USERNAME,ROL_ROL_ID) VALUES('ADMIN',3);
