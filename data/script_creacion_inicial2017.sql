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

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.ITEM_FACTURA') AND OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE GDDIANOS.ITEM_FACTURA

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.FACTURA') AND OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE GDDIANOS.FACTURA

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.VIAJE') AND OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE GDDIANOS.VIAJE

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.TURNO') AND OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE GDDIANOS.TURNO


IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.USUARIO') AND OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE GDDIANOS.USUARIO

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.PERSONA') AND OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE GDDIANOS.PERSONA

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.MODELO') AND OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE GDDIANOS.MODELO

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.MARCA') AND OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE GDDIANOS.MARCA

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.TURNO') AND OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE GDDIANOS.TURNO

/*Drops procedures*/

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.GET_ROLES_USUARIO'))
DROP PROCEDURE GDDIANOS.GET_ROLES_USUARIO

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.GET_FUNCIONALIDADES_POR_ROL'))
DROP PROCEDURE GDDIANOS.GET_FUNCIONALIDADES_POR_ROL

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.EXISTE_USUARIO'))
DROP PROCEDURE GDDIANOS.EXISTE_USUARIO

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.PASSWORD_CORRECTA'))
DROP PROCEDURE GDDIANOS.PASSWORD_CORRECTA

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.GET_FUNCIONALIDADES_ROL'))
DROP PROCEDURE GDDIANOS.GET_FUNCIONALIDADES_ROL

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.FIND_PERSONA'))
DROP PROCEDURE GDDIANOS.FIND_PERSONA

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.GET_PERSONA'))
DROP PROCEDURE GDDIANOS.GET_PERSONA

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.GET_TELEFONO'))
DROP PROCEDURE GDDIANOS.GET_TELEFONO

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.MODIFICAR_PERSONA'))
DROP PROCEDURE GDDIANOS.MODIFICAR_PERSONA

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.BAJA_PERSONA'))
DROP PROCEDURE GDDIANOS.BAJA_PERSONA

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.GET_ROLES_USUARIO_POR_ID'))
DROP PROCEDURE GDDIANOS.GET_ROLES_USUARIO_POR_ID

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.GET_TIPO_POR_DNI'))
DROP PROCEDURE GDDIANOS.GET_TIPO_POR_DNI

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.ALTA_PERSONA'))
DROP PROCEDURE GDDIANOS.ALTA_PERSONA

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.ACTUALIZAR_PERSONA'))
DROP PROCEDURE GDDIANOS.ACTUALIZAR_PERSONA

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.GET_PERSONA_POR_DNI'))
DROP PROCEDURE GDDIANOS.GET_PERSONA_POR_DNI

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.GET_MODELOS'))
DROP PROCEDURE GDDIANOS.GET_MODELOS

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.GET_MARCAS'))
DROP PROCEDURE GDDIANOS.GET_MARCAS

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.GET_PATENTES'))
DROP PROCEDURE GDDIANOS.GET_PATENTES

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.GET_ESTADO_CHOFER'))
DROP PROCEDURE GDDIANOS.GET_ESTADO_CHOFER

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.FIND_ROL'))
DROP PROCEDURE GDDIANOS.FIND_ROL

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.GET_ROLES'))
DROP PROCEDURE GDDIANOS.GET_ROLES

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.BAJA_ROL'))
DROP PROCEDURE GDDIANOS.BAJA_ROL

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.MODIFICAR_AUTOMOVIL_POR_PATENTE'))
DROP PROCEDURE GDDIANOS.MODIFICAR_AUTOMOVIL_POR_PATENTE

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.ALTA_AUTOMOVIL'))
DROP PROCEDURE GDDIANOS.ALTA_AUTOMOVIL

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.GET_AUTOMOVIL_POR_PATENTE'))
DROP PROCEDURE GDDIANOS.GET_AUTOMOVIL_POR_PATENTE

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.BAJA_AUTOMOVIL_POR_PATENTE'))
DROP PROCEDURE GDDIANOS.BAJA_AUTOMOVIL_POR_PATENTE

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.GET_DETALLE'))
DROP PROCEDURE GDDIANOS.GET_DETALLE

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.GET_HORA_INICIO'))
DROP PROCEDURE GDDIANOS.GET_HORA_INICIO

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.GET_HORA_FIN'))
DROP PROCEDURE GDDIANOS.GET_HORA_FIN

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.BAJA_TURNO'))
DROP PROCEDURE GDDIANOS.BAJA_TURNO

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.FIND_TURNO_ID'))
DROP PROCEDURE GDDIANOS.FIND_TURNO_ID

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.FIND_TURNO_DESCRIPCION'))
DROP PROCEDURE GDDIANOS.FIND_TURNO_DESCRIPCION

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.ALTA_TURNO'))
DROP PROCEDURE GDDIANOS.ALTA_TURNO

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.MODIFICAR_TURNO'))
DROP PROCEDURE GDDIANOS.MODIFICAR_TURNO

/*Drops TRIGGERS*/

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.TRIG_ALTA_USUARIO'))
DROP TRIGGER GDDIANOS.TRIG_ALTA_USUARIO

/*Drops FUNCTIONS*/
IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.PASSWORD_HASH'))
DROP FUNCTION GDDIANOS.PASSWORD_HASH

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.GETIDPERSONAPORDNI'))
DROP FUNCTION GDDIANOS.GETIDPERSONAPORDNI

IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('GDDIANOS.GET_ID_TURNO_POR_HORAS'))
DROP FUNCTION GDDIANOS.GET_ID_TURNO_POR_HORAS

/**************/
/* SECUENCIAS */
/**************/

/**********/
/* TABLAS */
/**********/

CREATE TABLE GDDIANOS.PERSONA
(
		PERS_ID INT IDENTITY(1,1) PRIMARY KEY,
		PERS_TELEFONO NUMERIC (18,0) UNIQUE NOT NULL,
		PERS_NOMBRE VARCHAR(255) NOT NULL,
		PERS_APELLIDO VARCHAR(255) NOT NULL,
		PERS_DNI NUMERIC(18,0) NOT NULL,
		PERS_DIRECCION VARCHAR(255) NOT NULL UNIQUE,
		PERS_FECHA_NACIM DATETIME NULL,
		PERS_ESTADO BIT NOT NULL DEFAULT 1,
		PERS_MAIL VARCHAR(255) DEFAULT 'SIN EMAIL',
		PERS_TIPO INT NOT NULL, /*1: AMBOS/ADMIN, 2: CHOFER , 3: CLIENTE*/
		PERS_COD_POSTAL VARCHAR(8) DEFAULT '1'
		
);


CREATE TABLE GDDIANOS.USUARIO
(
		USUA_USERNAME VARCHAR(50) NOT NULL PRIMARY KEY,
		USUA_PASSWORD VARBINARY(32) NOT NULL,
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
	ROL_ROL_ESTADO BIT NOT NULL DEFAULT 1
	
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



CREATE TABLE GDDIANOS.TURNO
(
	TURNO_ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	TURNO_HORA_INICIO NUMERIC(18,0) NOT NULL,
	TURNO_HORA_FIN NUMERIC(18,0) NOT NULL,
	TURNO_DESCRIPCION VARCHAR(255) NOT NULL,
	TURNO_VALOR_KM NUMERIC(18,2) NOT NULL,
	TURNO_PRECIO_BASE NUMERIC(18,2) NOT NULL,
	TURNO_ESTADO BIT NOT NULL DEFAULT 1
	
	
);


CREATE TABLE GDDIANOS.MARCA
(
	MARCA_NOMBRE VARCHAR(32) PRIMARY KEY NOT NULL
);

CREATE TABLE GDDIANOS.MODELO
(
	MODE_CODIGO VARCHAR(255) PRIMARY KEY, 
	MODE_MARCA VARCHAR(32) NOT NULL,
	
	CONSTRAINT FK_MODE_MARCA FOREIGN KEY (MODE_MARCA) REFERENCES GDDIANOS.MARCA(MARCA_NOMBRE),

);

CREATE TABLE GDDIANOS.COCHE
(
	COCHE_PATENTE VARCHAR(10) NOT NULL PRIMARY KEY,
	COCHE_LICENCIA VARCHAR(26) NOT NULL,
	COCHE_ESTADO BIT NOT NULL DEFAULT 1,
	COCHE_MARCA_NOMBRE VARCHAR(32) NOT NULL,
	COCHE_MODELO_CODIGO VARCHAR(255) NOT NULL,
	COCHE_RODADO VARCHAR(10),
	
	CONSTRAINT FK_COCHE_MARCA_ID FOREIGN KEY (COCHE_MARCA_NOMBRE) REFERENCES GDDIANOS.MARCA(MARCA_NOMBRE),
	CONSTRAINT FK_COCHE_MODELO_CODIGO FOREIGN KEY (COCHE_MODELO_CODIGO) REFERENCES GDDIANOS.MODELO(MODE_CODIGO),
	);


CREATE TABLE GDDIANOS.VIAJE
(
	VIAJE_ID INT IDENTITY(1,1) PRIMARY KEY,
	VIAJE_TURNO_ID INT NOT NULL,
	VIAJE_FECHA_INICIO DATETIME NOT NULL,
	VIAJE_FECHA_FIN DATETIME NOT NULL,
	VIAJE_CANTIDAD_KM FLOAT NOT NULL,
	VIAJE_CHOF_PERS_ID INT NOT NULL,
	VIAJE_CLIENTE_PERS_ID INT NOT NULL,
	
	CONSTRAINT FK_VIAJE_TURNO FOREIGN KEY (VIAJE_TURNO_ID) REFERENCES GDDIANOS.TURNO(TURNO_ID),
	CONSTRAINT FK_VIAJE_PERSONA_CHOFER FOREIGN KEY (VIAJE_CHOF_PERS_ID) REFERENCES GDDIANOS.PERSONA(PERS_ID),
	CONSTRAINT FK_VIAJE_PERSONA_CLIENTE FOREIGN KEY (VIAJE_CLIENTE_PERS_ID) REFERENCES GDDIANOS.PERSONA(PERS_ID)
);

CREATE TABLE GDDIANOS.FACTURA
(
	FACT_ID INT IDENTITY(1,1) PRIMARY KEY,
	FACT_NRO NUMERIC(18,0) NOT NULL, 
	FACT_FECHA_GENERADA DATETIME NOT NULL,
	FACT_FECHA_INICIO DATETIME NOT NULL,
	FACT_FECHA_FIN DATETIME NOT NULL,
	FACT_IMPORTA_TOTAL FLOAT NOT NULL,
	
);

CREATE TABLE GDDIANOS.ITEM_FACTURA
(
	ITEM_FACT_ID INT NOT NULL,
	ITEM_VIAJE_ID INT NOT NULL

	CONSTRAINT FK_ITEM_FACT_ID FOREIGN KEY (ITEM_FACT_ID) REFERENCES GDDIANOS.FACTURA(FACT_ID),
	CONSTRAINT FK_ITEM_VIAJE_ID FOREIGN KEY (ITEM_VIAJE_ID) REFERENCES GDDIANOS.VIAJE(VIAJE_ID),
	CONSTRAINT PK_ITEM_FACTURA PRIMARY KEY(ITEM_FACT_ID,ITEM_VIAJE_ID),
);

CREATE TABLE GDDIANOS.PAGO
(
	PAGO_FECHA DATETIME NOT NULL,
	PAGO_PERS_ID INT NOT NULL,
	PAGO_TURNO_ID INT NOT NULL,
	PAGO_IMPORTE_TOTAL FLOAT NOT NULL,
	
	CONSTRAINT FK_PAGO_PERSONA FOREIGN KEY (PAGO_PERS_ID) REFERENCES GDDIANOS.PERSONA(PERS_ID)
);




go

/**************/
/* PROCEDURES */
/**************/

CREATE PROCEDURE GDDIANOS.GET_ROLES_USUARIO(@USUARIO VARCHAR(255)) AS
BEGIN
	SELECT R.ROL_NOMBRE,R.ROL_ID FROM GDDIANOS.ROL R
	INNER JOIN GDDIANOS.ROL_POR_USUARIO RU ON RU.ROL_ROL_ID=R.ROL_ID
	INNER JOIN GDDIANOS.USUARIO U ON U.USUA_USERNAME=RU.ROL_USUA_USERNAME
	WHERE U.USUA_ESTADO=1 AND R.ROL_ESTADO=1 AND U.USUA_USERNAME=@USUARIO
	return 1
END;

GO
CREATE PROCEDURE GDDIANOS.EXISTE_USUARIO(@USUARIO VARCHAR(255)) AS
BEGIN
	DECLARE @CANTIDAD INT
	
	SELECT @CANTIDAD = COUNT(USUA_USERNAME) FROM GDDIANOS.USUARIO
	WHERE USUA_USERNAME = @USUARIO AND
		  USUA_ESTADO = 1
	
	RETURN @CANTIDAD
END;

GO
CREATE PROCEDURE GDDIANOS.GET_ROLES_USUARIO_POR_ID(@ID INT, @TIPO INT)
AS
BEGIN

	SELECT ROL_USUA_USERNAME, ROL_ROL_ID, ROL_ROL_ESTADO
	FROM GDDIANOS.ROL_POR_USUARIO JOIN GDDIANOS.USUARIO ON USUA_USERNAME = ROL_USUA_USERNAME
	JOIN GDDIANOS.PERSONA ON PERS_ID = USUA_PERS_ID
	WHERE PERS_ID = @ID AND ROL_ROL_ID = @TIPO
	
	
END;

GO
CREATE PROCEDURE GDDIANOS.PASSWORD_CORRECTA(@USUARIO VARCHAR(255),@PASSWORD VARCHAR(64)) AS
BEGIN
	DECLARE @HASH_PASS VARBINARY(32), @CANTIDAD INT
	SET @HASH_PASS = CONVERT(VARBINARY(32), @PASSWORD, 2)

	SELECT @CANTIDAD = COUNT(USUA_USERNAME) FROM GDDIANOS.USUARIO
	WHERE USUA_ESTADO = 1 AND
		  USUA_USERNAME = @USUARIO AND
		  USUA_PASSWORD = @HASH_PASS

	RETURN @CANTIDAD
END

GO
CREATE PROCEDURE GDDIANOS.GET_FUNCIONALIDADES_ROL(@ROL_ID INT) AS
BEGIN
	SELECT FUNCIONALIDAD_ID, DESCRIPCION AS Funcionalidad FROM GDDIANOS.FUNCIONALIDAD_POR_ROL, GDDIANOS.FUNCIONALIDAD
	WHERE FUNC_ROL_ID = @ROL_ID AND
		  FUNC_ID = FUNCIONALIDAD_ID
END

GO
create procedure GDDIANOS.GET_FUNCIONALIDADES_POR_ROL (@ID int)
AS
BEGIN
RETURN (
	SELECT FUNCIONALIDAD_ID
	FROM  GDDIANOS.FUNCIONALIDAD JOIN  GDDIANOS.FUNCIONALIDAD_POR_ROL ON (FUNCIONALIDAD_ID = FUNC_ID)
	JOIN  GDDIANOS.ROL ON (FUNC_ROL_ID = ROL_ID)
	WHERE ROL_ID = @ID)
END;

GO
CREATE PROCEDURE GDDIANOS.FIND_PERSONA(@NOMBRE VARCHAR(255) = NULL,@APELLIDO VARCHAR(255) = NULL, 
	@DOC VARCHAR(18) = NULL, @TIPO INT, @TIPOAMBOS INT) AS
BEGIN
	SELECT PERS_ID AS ID, PERS_TIPO AS Tipo, PERS_DNI AS Numero, 
	PERS_NOMBRE AS Nombre, PERS_APELLIDO AS Apellido, PERS_FECHA_NACIM AS 'Fecha Nacimiento'
	FROM GDDIANOS.PERSONA 
	WHERE (@NOMBRE IS NULL OR PERS_NOMBRE LIKE '%' + @NOMBRE + '%') AND
		  (@APELLIDO IS NULL OR PERS_APELLIDO LIKE '%' + @APELLIDO + '%') AND
		  (@DOC IS NULL OR PERS_DNI LIKE '%' + @DOC + '%') AND
		  (@TIPO IS NULL OR PERS_TIPO= @TIPO or PERS_TIPO=@TIPOAMBOS)		  
		  
END;

GO 
CREATE PROCEDURE GDDIANOS.BAJA_PERSONA (@ID INT, @TIPO INT)
AS 
BEGIN
	
	DECLARE @ROLES INT, @USER VARCHAR(50)
	DECLARE @TIPOA INT , @PERS INT 

	SELECT @USER = USUA_USERNAME, @PERS = PERS_ID, @TIPOA = PERS_TIPO
	FROM GDDIANOS.USUARIO JOIN GDDIANOS.PERSONA ON (PERS_ID = USUA_PERS_ID)
	WHERE PERS_ID = @ID

	IF (@TIPO = 2)
	BEGIN
		UPDATE GDDIANOS.ROL_POR_USUARIO SET ROL_ROL_ESTADO = 0 WHERE (ROL_USUA_USERNAME = @USER AND ROL_ROL_ID = 2)
		IF (@TIPOA = 3)
		UPDATE GDDIANOS.PERSONA SET PERS_TIPO = 1 WHERE (@PERS = PERS_ID)
		
	END
	ELSE
	BEGIN
		UPDATE GDDIANOS.ROL_POR_USUARIO SET ROL_ROL_ESTADO = 0 WHERE (ROL_USUA_USERNAME = @USER AND ROL_ROL_ID = 1)
		IF (@TIPOA = 3)
		UPDATE GDDIANOS.PERSONA SET PERS_TIPO = 2 WHERE (@PERS = PERS_ID)
	END
	
END

GO
CREATE PROCEDURE GDDIANOS.MODIFICAR_PERSONA (@ID INT,@TELEFONO INT, @NOMBRE VARCHAR(255),
@APELLIDO VARCHAR(255),@DNI NUMERIC(18,0), @DIRECCION VARCHAR(255), @FECHA DATETIME,
@MAIL VARCHAR(255), @ESTADO INT, @COD VARCHAR(8), @TIPO INT)
AS
BEGIN
	
	DECLARE @USER VARCHAR(50)

	SET DATEFORMAT DMY

	UPDATE GDDIANOS.PERSONA
	SET PERS_TELEFONO = @TELEFONO, PERS_NOMBRE = @NOMBRE, PERS_APELLIDO = @APELLIDO,
	PERS_DNI = @DNI, PERS_DIRECCION = @DIRECCION, PERS_FECHA_NACIM = @FECHA,
	PERS_ESTADO = PERS_ESTADO, PERS_MAIL = @MAIL, PERS_TIPO = PERS_TIPO, PERS_COD_POSTAL = @COD
	WHERE (PERS_ID = @ID)

	SELECT @USER = USUA_USERNAME, @ID = PERS_ID
	FROM GDDIANOS.USUARIO JOIN GDDIANOS.PERSONA ON (PERS_ID = USUA_PERS_ID)
	WHERE PERS_ID = @ID

	UPDATE GDDIANOS.ROL_POR_USUARIO
	SET ROL_ROL_ESTADO = @ESTADO
	WHERE (ROL_USUA_USERNAME = @USER AND ROL_ROL_ID = @TIPO)
	
END

GO
CREATE PROCEDURE GDDIANOS.GET_TELEFONO(@TELEFONO INT, @ID INT) AS
BEGIN
	RETURN (SELECT COUNT(*)
	FROM GDDIANOS.PERSONA PERSONAS
	WHERE PERSONAS.PERS_TELEFONO = @TELEFONO AND PERSONAS.PERS_ID != @ID)
END

GO
CREATE PROCEDURE GDDIANOS.GET_PERSONA(@ID INT) AS
BEGIN
	SELECT * FROM GDDIANOS.PERSONA PERSONAS, GDDIANOS.USUARIO USUARIOS
	WHERE PERSONAS.PERS_ID = @ID AND USUARIOS.USUA_PERS_ID = PERSONAS.PERS_ID
END

GO
CREATE PROCEDURE GDDIANOS.GET_TIPO_POR_DNI(@DNI INT) AS
BEGIN

	SELECT PERS_TIPO
	FROM GDDIANOS.PERSONA PERSONAS
	WHERE PERSONAS.PERS_DNI = @DNI

END

GO
CREATE PROCEDURE GDDIANOS.ACTUALIZAR_PERSONA(@DNI NUMERIC (18,0), @TIPO INT,
													@COD VARCHAR(8),@ROL INT)
AS
BEGIN
	DECLARE @USUA VARCHAR(50)
	SELECT @USUA = USUA_USERNAME 
	FROM GDDIANOS.PERSONA JOIN GDDIANOS.USUARIO ON (PERS_ID = USUA_PERS_ID)
	WHERE PERS_DNI = @DNI
	UPDATE GDDIANOS.PERSONA SET PERS_TIPO  = @TIPO, PERS_COD_POSTAL = @COD WHERE(PERS_DNI = @DNI);
	INSERT GDDIANOS.ROL_POR_USUARIO VALUES (@USUA, @ROL, 1);
END;

GO
CREATE PROCEDURE GDDIANOS.ALTA_PERSONA (@TELEFONO NUMERIC(18,0), @NOMBRE VARCHAR(255),
@APELLIDO VARCHAR(255),@DNI NUMERIC(18,0),@FECHA DATETIME,@DIRECCION VARCHAR(255),
@MAIL VARCHAR(255),@COD VARCHAR(8), @TIPO INT)
AS
BEGIN
	
	DECLARE @USUA VARCHAR(50)
	INSERT GDDIANOS.PERSONA VALUES (@TELEFONO,@NOMBRE,@APELLIDO,@DNI,@DIRECCION,@FECHA,1,@MAIL,@TIPO,@COD)
	
	SELECT @USUA = USUA_USERNAME 
	FROM GDDIANOS.PERSONA JOIN GDDIANOS.USUARIO ON (PERS_ID = USUA_PERS_ID)
	WHERE PERS_DNI = @DNI
END

GO
CREATE PROCEDURE GDDIANOS.GET_PERSONA_POR_DNI(@DNI INT) AS
BEGIN
	SELECT PERS_ID
	FROM GDDIANOS.PERSONA PERSONAS
	WHERE PERSONAS.PERS_DNI = @DNI
END

GO
CREATE PROCEDURE GDDIANOS.GET_MODELOS (@MARCA VARCHAR(32))
AS
BEGIN
	SELECT COCHE_MODELO_CODIGO
	FROM GDDIANOS.COCHE
	WHERE COCHE_MARCA_NOMBRE = @MARCA
	RETURN 1
END

GO
CREATE PROCEDURE GDDIANOS.GET_PATENTES (@MODELO VARCHAR(255))
AS
BEGIN
	SELECT COCHE_PATENTE
	FROM GDDIANOS.COCHE
	WHERE COCHE_MODELO_CODIGO = @MODELO
	RETURN 1
END

GO
CREATE PROCEDURE GDDIANOS.GET_MARCAS
AS
BEGIN
	SELECT MARCA_NOMBRE
	FROM GDDIANOS.MARCA
	RETURN 1
END

GO
CREATE PROCEDURE GDDIANOS.GET_ESTADO_CHOFER (@PATENTE VARCHAR(10))
AS
BEGIN
	SELECT COCHE_ESTADO --, COCHE_CHOFER
	FROM GDDIANOS.COCHE
	WHERE COCHE_PATENTE = @PATENTE
END

GO
CREATE PROCEDURE GDDIANOS.FIND_ROL(@NOMBRE VARCHAR(255) = NULL) AS
BEGIN
	SELECT ROL_NOMBRE
	FROM GDDIANOS.ROL
	WHERE (@NOMBRE IS NULL OR ROL_NOMBRE LIKE @NOMBRE) 
		  
END;

GO
CREATE PROCEDURE GDDIANOS.GET_ROLES AS
BEGIN
 SELECT DISTINCT ROL_NOMBRE,ROL_ID, ROL_ESTADO FROM GDDIANOS.ROL 
 return 1
END;

GO
CREATE PROCEDURE GDDIANOS.BAJA_ROL(@NOMBRE VARCHAR(50)) 
AS 
BEGIN
	SELECT ROL_NOMBRE, ROL_ID --QUE PASA SI HAY DOS ROLES CON EL MISMO NOMBRE¿? AUNQUE EN TEORIA NO TE LO DEJA CARGAR
	FROM GDDIANOS.ROL 
	WHERE ROL_NOMBRE = @NOMBRE
BEGIN
	UPDATE GDDIANOS.ROL SET ROL_ESTADO = 0 WHERE ROL_NOMBRE = @NOMBRE
END
END

GO
CREATE PROCEDURE GDDIANOS.MODIFICAR_AUTOMOVIL_POR_PATENTE (@PATENTE VARCHAR(10), @ESTADO INT/*, @CHOFER INT*/)
AS
BEGIN
	UPDATE GDDIANOS.COCHE SET COCHE_ESTADO = @ESTADO/*, COCHE_CHOFER = @CHOFER*/ WHERE COCHE_PATENTE = @PATENTE
END

GO
CREATE PROCEDURE GDDIANOS.ALTA_AUTOMOVIL (@MARCA VARCHAR(32), @MODELO VARCHAR(255), @PATENTE VARCHAR(10)/*, @CHOFER INT, @ESTADO BIT*/)
AS
BEGIN
	IF ((SELECT COUNT(*) FROM GDDIANOS.MARCA WHERE MARCA_NOMBRE = @MARCA) = 0)
	BEGIN
	INSERT GDDIANOS.MARCA VALUES (@MARCA)
	END

	INSERT GDDIANOS.MODELO VALUES (@MODELO, @MARCA);
	INSERT GDDIANOS.COCHE VALUES (@PATENTE,'ALGOALPEDO',1,@MARCA,@MODELO/*,@CHOFER*/,'MASALPEDO');
END

GO
CREATE PROCEDURE GDDIANOS.GET_AUTOMOVIL_POR_PATENTE (@PATENTE VARCHAR(10))
AS
BEGIN
SELECT COCHE_PATENTE
FROM GDDIANOS.COCHE
WHERE COCHE_PATENTE = @PATENTE
END

GO
CREATE PROCEDURE GDDIANOS.BAJA_AUTOMOVIL_POR_PATENTE (@PATENTE VARCHAR(10))
AS
BEGIN
	UPDATE GDDIANOS.COCHE SET COCHE_ESTADO = 0 WHERE COCHE_PATENTE = @PATENTE
END

GO
CREATE PROCEDURE GDDIANOS.ALTA_TURNO (@DESCRIPCION VARCHAR(255), @HI NUMERIC(18,0), @HF NUMERIC(18,0), @VALOR NUMERIC(18,2), @PRECIO NUMERIC(18,2))
AS
BEGIN
	DECLARE @CANT INT
	
	SELECT @CANT = COUNT(*) FROM GDDIANOS.TURNO 
	WHERE (TURNO_ESTADO = 1) AND ((@HI BETWEEN TURNO_HORA_INICIO AND TURNO_HORA_FIN) OR (@HF BETWEEN TURNO_HORA_INICIO AND TURNO_HORA_FIN))

	IF (@CANT = 0)
	BEGIN
		INSERT GDDIANOS.TURNO VALUES (@HI,@HF,@DESCRIPCION,@VALOR,@PRECIO,1)
		RETURN 1
	END
	ELSE
	BEGIN
		RETURN 0
	END
END

GO
CREATE PROCEDURE GDDIANOS.GET_DETALLE
AS
BEGIN
	SELECT TURNO_DESCRIPCION FROM GDDIANOS.TURNO WHERE TURNO_ESTADO = 1
	RETURN 1
END

GO
CREATE PROCEDURE GDDIANOS.GET_HORA_INICIO (@DESCRIPCION VARCHAR(255))
AS
BEGIN
	SELECT TURNO_HORA_INICIO FROM GDDIANOS.TURNO WHERE TURNO_DESCRIPCION = @DESCRIPCION 
	RETURN 1
END

GO
CREATE PROCEDURE GDDIANOS.GET_HORA_FIN (@DESCRIPCION VARCHAR(255))
AS
BEGIN
	SELECT TURNO_HORA_FIN FROM GDDIANOS.TURNO WHERE TURNO_DESCRIPCION = @DESCRIPCION 
	RETURN 1
END

GO
CREATE PROCEDURE GDDIANOS.BAJA_TURNO (@DESCRIPCION VARCHAR(255), @HI NUMERIC(18,0), @HF NUMERIC(18,0))
AS
BEGIN
	UPDATE GDDIANOS.TURNO SET TURNO_ESTADO = 0 WHERE (@DESCRIPCION = TURNO_DESCRIPCION AND @HI = TURNO_HORA_INICIO AND @HF = TURNO_HORA_FIN)
END

GO
CREATE PROCEDURE GDDIANOS.FIND_TURNO_ID (@ID INT)
AS
BEGIN
	SELECT *
	FROM GDDIANOS.TURNO
	WHERE TURNO_ID = @ID
END

GO
CREATE PROCEDURE GDDIANOS.FIND_TURNO_DESCRIPCION (@DESCRIPCION VARCHAR(255))
AS
BEGIN
	
	IF(@DESCRIPCION != '')
		BEGIN
		SELECT *
		FROM GDDIANOS.TURNO
		WHERE TURNO_DESCRIPCION = @DESCRIPCION
		END
	ELSE
		BEGIN
		SELECT *
		FROM GDDIANOS.TURNO
		END
END

GO
CREATE PROCEDURE GDDIANOS.MODIFICAR_TURNO (@ID INT, @HS NUMERIC(18,0), @HF NUMERIC(18,0), @DESCRIPCION VARCHAR(255), @VALOR NUMERIC(18,2), @PRECIO NUMERIC(18,2), @ESTADO BIT)
AS
BEGIN
	DECLARE @CANT INT
	
	SELECT @CANT = COUNT(*) FROM GDDIANOS.TURNO 
	WHERE (TURNO_ESTADO = 1) AND ((@HI BETWEEN TURNO_HORA_INICIO AND TURNO_HORA_FIN) OR (@HF BETWEEN TURNO_HORA_INICIO AND TURNO_HORA_FIN))

	IF (@CANT = 0)
	BEGIN
		UPDATE GDDIANOS.TURNO SET TURNO_HORA_INICIO = @HI, TURNO_HORA_FIN = @HF, TURNO_DESCRIPCION =@DESCRIPCION, TURNO_VALOR_KM =@VALOR,
	TURNO_PRECIO_BASE = @PRECIO, TURNO_ESTADO = @ESTADO WHERE TURNO_ID = @ID
		RETURN 1
	END
	ELSE
	BEGIN
		RETURN 0
	END
END

/*FUNCIONES*/
GO

CREATE FUNCTION GDDIANOS.PASSWORD_HASH(@PASSWORD NUMERIC(18,0))
	RETURNS VARBINARY(32)
	BEGIN
		RETURN CONVERT(VARBINARY(32),HASHBYTES('SHA2_256',CONVERT(VARCHAR(32),@PASSWORD)))
	END;

GO
CREATE FUNCTION GDDIANOS.GETIDPERSONAPORDNI(@DNI_CHOF NUMERIC(18,0))--Existe chofer
RETURNS INT
BEGIN
	DECLARE @CHOFER INT
	SELECT  @CHOFER = PERS_ID  FROM GDDIANOS.PERSONA WHERE (PERSONA.PERS_TIPO=2 OR PERSONA.PERS_TIPO=3) AND  PERSONA.PERS_DNI=@DNI_CHOF 
	RETURN @CHOFER
END;
GO

CREATE FUNCTION GDDIANOS.GET_ID_TURNO_POR_HORAS(@INICIO DATETIME,@FIN DATETIME)
RETURNS INT
BEGIN	
	DECLARE @ID INT
	SELECT @ID=TURNO_ID FROM GDDIANOS.TURNO WHERE TURNO_HORA_INICIO>=DATEPART(HOUR, @INICIO) AND TURNO_HORA_FIN>DATEPART(HOUR, @FIN)
	RETURN @ID
END;

/*TRIGGERS*/
GO

/*SE GENERA EL ADMIN ANTES DE CREAR EL TRIGGER DE PERSONA, PARA PODER DEJAR LA CONTRASENIA POR DEFECTO DEL TP Y EL NOMBRE. EN EL PROGRAMA
AL INSERTAR UNA PERSONA SE INSERTA AUTOMATICAMENTE UN USUARIO CON USERNAME Y PASSWORD COMO EL DNI*/
INSERT INTO GDDIANOS.ROL (ROL_ID,ROL_NOMBRE,ROL_ESTADO) VALUES(1,'ADMIN',1);
INSERT INTO GDDIANOS.ROL (ROL_ID,ROL_NOMBRE,ROL_ESTADO) VALUES(2,'CHOFER',1);
INSERT INTO GDDIANOS.ROL (ROL_ID,ROL_NOMBRE,ROL_ESTADO) VALUES(3,'CLIENTE',1);	
		
INSERT INTO GDDIANOS.PERSONA VALUES ( 123455, 'ADMIN', 'ADMIN', 38457835, 'UBERFRBA', 25/10/1994,1,'',1,'1');

INSERT INTO GDDIANOS.USUARIO VALUES ('ADMIN', CONVERT(VARBINARY(32),'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7',2),0,1,1);
INSERT INTO GDDIANOS.ROL_POR_USUARIO (ROL_USUA_USERNAME,ROL_ROL_ID,ROL_ROL_ESTADO) VALUES('ADMIN',1,0);
INSERT INTO GDDIANOS.ROL_POR_USUARIO (ROL_USUA_USERNAME,ROL_ROL_ID,ROL_ROL_ESTADO) VALUES('ADMIN',2,0);
INSERT INTO GDDIANOS.ROL_POR_USUARIO (ROL_USUA_USERNAME,ROL_ROL_ID,ROL_ROL_ESTADO) VALUES('ADMIN',3,0);


GO

CREATE TRIGGER GDDIANOS.TRIG_ALTA_USUARIO ON GDDIANOS.PERSONA FOR INSERT
AS
BEGIN
	DECLARE @PERS_TIPO_USUA INT;
	DECLARE @PERS_DNI NUMERIC(18,0);

	INSERT INTO GDDIANOS.USUARIO
	(USUA_USERNAME,USUA_PASSWORD,USUA_CANTIDAD_INTENTOS,USUA_ESTADO,USUA_PERS_ID)
	SELECT PERS_DNI,CONVERT(VARBINARY(32),GDDIANOS.PASSWORD_HASH(PERS_DNI),2),0,1,PERS_ID FROM INSERTED;

	SELECT @PERS_TIPO_USUA = PERS_TIPO,@PERS_DNI=PERS_DNI FROM INSERTED;
	IF(@PERS_TIPO_USUA=1)
	BEGIN
	  INSERT INTO GDDIANOS.ROL_POR_USUARIO (ROL_USUA_USERNAME,ROL_ROL_ID) VALUES(@PERS_DNI,3)
	  INSERT INTO GDDIANOS.ROL_POR_USUARIO (ROL_USUA_USERNAME,ROL_ROL_ID) VALUES(@PERS_DNI,2)
	  INSERT INTO GDDIANOS.ROL_POR_USUARIO (ROL_USUA_USERNAME,ROL_ROL_ID) VALUES(@PERS_DNI,1)
	END ELSE
	BEGIN
	INSERT INTO GDDIANOS.ROL_POR_USUARIO (ROL_USUA_USERNAME,ROL_ROL_ID) VALUES(@PERS_DNI,@PERS_TIPO_USUA)
	END;

END;
GO


GO

INSERT INTO GDDIANOS.FUNCIONALIDAD
(FUNCIONALIDAD_ID,DESCRIPCION)
VALUES(1,'altaAutomovil');

INSERT INTO GDDIANOS.FUNCIONALIDAD
(FUNCIONALIDAD_ID,DESCRIPCION)
VALUES(2,'bajaAutomovil');

INSERT INTO GDDIANOS.FUNCIONALIDAD
(FUNCIONALIDAD_ID,DESCRIPCION)
VALUES(3,'modificacionAutomovil');

INSERT INTO GDDIANOS.FUNCIONALIDAD
(FUNCIONALIDAD_ID,DESCRIPCION)
VALUES(4,'altaChofer');

INSERT INTO GDDIANOS.FUNCIONALIDAD
(FUNCIONALIDAD_ID,DESCRIPCION)
VALUES(5,'bajaChofer');

INSERT INTO GDDIANOS.FUNCIONALIDAD
(FUNCIONALIDAD_ID,DESCRIPCION)
VALUES(6,'modificacionChofer');

INSERT INTO GDDIANOS.FUNCIONALIDAD
(FUNCIONALIDAD_ID,DESCRIPCION)
VALUES(7,'altaCliente');

INSERT INTO GDDIANOS.FUNCIONALIDAD
(FUNCIONALIDAD_ID,DESCRIPCION)
VALUES(8,'bajaCliente');

INSERT INTO GDDIANOS.FUNCIONALIDAD
(FUNCIONALIDAD_ID,DESCRIPCION)
VALUES(9,'modificacionCliente');

INSERT INTO GDDIANOS.FUNCIONALIDAD
(FUNCIONALIDAD_ID,DESCRIPCION)
VALUES(10,'facturacion');

INSERT INTO GDDIANOS.FUNCIONALIDAD
(FUNCIONALIDAD_ID,DESCRIPCION)
VALUES(11,'listadoEstadistico');

INSERT INTO GDDIANOS.FUNCIONALIDAD
(FUNCIONALIDAD_ID,DESCRIPCION)
VALUES(12,'registroDeViajes');

INSERT INTO GDDIANOS.FUNCIONALIDAD
(FUNCIONALIDAD_ID,DESCRIPCION)
VALUES(13,'rendicionDeViajes');


INSERT INTO GDDIANOS.FUNCIONALIDAD
(FUNCIONALIDAD_ID,DESCRIPCION)
VALUES(14,'altaRol');


INSERT INTO GDDIANOS.FUNCIONALIDAD
(FUNCIONALIDAD_ID,DESCRIPCION)
VALUES(15,'bajaRol');

INSERT INTO GDDIANOS.FUNCIONALIDAD
(FUNCIONALIDAD_ID,DESCRIPCION)
VALUES(16,'modificacionRol');

INSERT INTO GDDIANOS.FUNCIONALIDAD
(FUNCIONALIDAD_ID,DESCRIPCION)
VALUES(17,'altaTurno');

INSERT INTO GDDIANOS.FUNCIONALIDAD
(FUNCIONALIDAD_ID,DESCRIPCION)
VALUES(18,'bajaTurno');

INSERT INTO GDDIANOS.FUNCIONALIDAD
(FUNCIONALIDAD_ID,DESCRIPCION)
VALUES(19,'modificacionTurno');




INSERT INTO GDDIANOS.FUNCIONALIDAD_POR_ROL 
(FUNC_ROL_ID,FUNC_ID) 
VALUES(1,1);

INSERT INTO GDDIANOS.FUNCIONALIDAD_POR_ROL
(FUNC_ROL_ID,FUNC_ID)
VALUES(1,2);

INSERT INTO GDDIANOS.FUNCIONALIDAD_POR_ROL
(FUNC_ROL_ID,FUNC_ID)
VALUES(1,3);

INSERT INTO GDDIANOS.FUNCIONALIDAD_POR_ROL
(FUNC_ROL_ID,FUNC_ID)
VALUES(1,4);

INSERT INTO GDDIANOS.FUNCIONALIDAD_POR_ROL
(FUNC_ROL_ID,FUNC_ID)
VALUES(1,5);

INSERT INTO GDDIANOS.FUNCIONALIDAD_POR_ROL
(FUNC_ROL_ID,FUNC_ID)
VALUES(1,6);

INSERT INTO GDDIANOS.FUNCIONALIDAD_POR_ROL
(FUNC_ROL_ID,FUNC_ID)
VALUES(1,7);

INSERT INTO GDDIANOS.FUNCIONALIDAD_POR_ROL
(FUNC_ROL_ID,FUNC_ID)
VALUES(1,8);

INSERT INTO GDDIANOS.FUNCIONALIDAD_POR_ROL
(FUNC_ROL_ID,FUNC_ID)
VALUES(1,9);

INSERT INTO GDDIANOS.FUNCIONALIDAD_POR_ROL
(FUNC_ROL_ID,FUNC_ID)
VALUES(1,10);

INSERT INTO GDDIANOS.FUNCIONALIDAD_POR_ROL
(FUNC_ROL_ID,FUNC_ID)
VALUES(1,11);

INSERT INTO GDDIANOS.FUNCIONALIDAD_POR_ROL
(FUNC_ROL_ID,FUNC_ID)
VALUES(1,12);

INSERT INTO GDDIANOS.FUNCIONALIDAD_POR_ROL
(FUNC_ROL_ID,FUNC_ID)
VALUES(1,13);

INSERT INTO GDDIANOS.FUNCIONALIDAD_POR_ROL
(FUNC_ROL_ID,FUNC_ID)
VALUES(1,14);

INSERT INTO GDDIANOS.FUNCIONALIDAD_POR_ROL
(FUNC_ROL_ID,FUNC_ID)
VALUES(1,15);

INSERT INTO GDDIANOS.FUNCIONALIDAD_POR_ROL
(FUNC_ROL_ID,FUNC_ID)
VALUES(1,16);

INSERT INTO GDDIANOS.FUNCIONALIDAD_POR_ROL
(FUNC_ROL_ID,FUNC_ID)
VALUES(1,17);

INSERT INTO GDDIANOS.FUNCIONALIDAD_POR_ROL
(FUNC_ROL_ID,FUNC_ID)
VALUES(1,18);

INSERT INTO GDDIANOS.FUNCIONALIDAD_POR_ROL
(FUNC_ROL_ID,FUNC_ID)
VALUES(1,19);
--Migracion choferes
INSERT INTO gddianos.PERSONA 
 SELECT DISTINCT
       [Chofer_Telefono]
	  ,[Chofer_Nombre]
      ,[Chofer_Apellido]
      ,[Chofer_Dni]
      ,[Chofer_Direccion]
      ,[Chofer_Fecha_Nac]
	  ,1
      ,[Chofer_Mail]
	  ,2   --tipo persona 2=chofer
	  ,'' 
  FROM [GD1C2017].[gd_esquema].[Maestra]
;
--Migracion clientes
INSERT INTO GDDIANOS.PERSONA
	   SELECT DISTINCT
	   [Cliente_Telefono]
	  ,[Cliente_Nombre]
      ,[Cliente_Apellido]
      ,[Cliente_Dni]
      ,[Cliente_Direccion]
      ,[Cliente_Fecha_Nac]
	  ,1 
	  ,[Cliente_Mail]
	  ,3
      ,''
 FROM [GD1C2017].[gd_esquema].[Maestra]
;
 --Migracion Turno
 insert into GDDIANOS.TURNO
      ([TURNO_HORA_INICIO]
      ,[TURNO_HORA_FIN]
      ,[TURNO_DESCRIPCION]
      ,[TURNO_VALOR_KM]
      ,[TURNO_PRECIO_BASE]
      ,[TURNO_ESTADO])
SELECT distinct 
       [Turno_Hora_Inicio]
      ,[Turno_Hora_Fin]
      ,[Turno_Descripcion]
      ,[Turno_Valor_Kilometro]
      ,[Turno_Precio_Base]
	  ,1
  FROM [GD1C2017].[gd_esquema].[Maestra]
;
  --Migracion marcas
INSERT INTO GDDIANOS.MARCA
	([MARCA_NOMBRE])
	SELECT DISTINCT [AUTO_MARCA] FROM 	[GD1C2017].[gd_esquema].[Maestra]
	;

--Migracion modelos
INSERT INTO GDDIANOS.MODELO
	([MODE_CODIGO]
	,[MODE_MARCA])
	SELECT distinct 
      [Auto_Modelo]
	  ,[Auto_Marca]
  FROM [GD1C2017].[gd_esquema].[Maestra]

--Migracion coches
INSERT INTO GDDIANOS.COCHE 
	(  [COCHE_PATENTE]
      ,[COCHE_LICENCIA]
      ,[COCHE_ESTADO]
      ,[COCHE_MARCA_NOMBRE]
      ,[COCHE_MODELO_CODIGO]
      ,[COCHE_RODADO])
	  SELECT DISTINCT 
	    [Auto_PATENTE]
	   ,[Auto_Licencia]
	   ,1
	   ,[AUTO_MARCA] 
       ,[Auto_Modelo]
	   ,[Auto_Rodado]
	  FROM [GD1C2017].[gd_esquema].[Maestra]
;

INSERT INTO GDDIANOS.FACTURA
	(  [FACT_NRO]
      ,[FACT_FECHA_GENERADA]
      ,[FACT_FECHA_INICIO]
      ,[FACT_FECHA_FIN]
      ,[FACT_IMPORTA_TOTAL])

	  SELECT DISTINCT 
       [Factura_Nro]
      ,CONVERT(DATETIME,[Factura_Fecha],121) 
	  ,CONVERT(DATETIME,[Factura_Fecha_Inicio],121) 
	  ,CONVERT(DATETIME,[Factura_Fecha_Fin],121)
	  ,isnull((SELECT isnull(SUM(([Turno_Valor_Kilometro]*[Viaje_Cant_Kilometros])+[Turno_Precio_Base]),0) FROM [GD1C2017].[gd_esquema].[Maestra] E WHERE E.[FACTURA_NRO]=F.[FACTURA_NRO] ),0) as suma  
  FROM [GD1C2017].[gd_esquema].[Maestra] F
  WHERE FACTURA_FECHA IS NOT NULL
  ORDER BY Factura_Nro
  ;

  INSERT INTO GDDIANOS.VIAJE 
  (    [VIAJE_TURNO_ID]
      ,[VIAJE_FECHA_INICIO]
      ,[VIAJE_FECHA_FIN]
      ,[VIAJE_CANTIDAD_KM]
      ,[VIAJE_CHOF_PERS_ID]
      ,[VIAJE_CLIENTE_PERS_ID])
  SELECT DISTINCT 1,CONVERT(DATETIME,[VIAJE_FECHA],121),CONVERT(DATETIME,[VIAJE_FECHA],121),[Viaje_Cant_Kilometros] ,GDDIANOS.GETIDPERSONAPORDNI([CHOFER_DNI]),GDDIANOS.GETIDPERSONAPORDNI([CLIENTE_DNI])  
  FROM  [GD1C2017].[gd_esquema].[Maestra] F


