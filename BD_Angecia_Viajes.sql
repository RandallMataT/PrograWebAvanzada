-- Creación de la base de datos
CREATE DATABASE AgenciaViajes;
GO

USE AgenciaViajes;
GO

-- Creación de las tablas

CREATE TABLE Clientes (
    ID INT PRIMARY KEY NOT NULL,
    Nombre VARCHAR(50) NOT NULL,
    Apellido VARCHAR(50) NOT NULL,
    Email VARCHAR(100) NOT NULL,
    Telefono VARCHAR(20),
	CONTRASENNA	VARCHAR(50) NOT NULL, 
);
GO
CREATE TABLE Usuario_Role(
	IdRole	INT IDENTITY CONSTRAINT PK_Usuario_Role PRIMARY KEY, 
	NombreRole	VARCHAR(50), 
	DescripcionPermisos VARCHAR(100)
); 
GO

CREATE TABLE Destinos (
    ID INT IDENTITY CONSTRAINT PK_Destinos PRIMARY KEY,
    Nombre VARCHAR(100),
    Descripcion VARCHAR(500),
    Precio DECIMAL(10, 2)
);
GO


CREATE TABLE CategoriasDestinos (
    ID INT IDENTITY CONSTRAINT PK_CategoriasDestinos PRIMARY KEY,
    Nombre VARCHAR(100)
);
GO


CREATE TABLE Reservaciones (
    ID INT IDENTITY CONSTRAINT PK_Reservaciones PRIMARY KEY,
    IdCliente INT,
    IdDestino INT,
    FechaInicio DATE,
    FechaFin DATE,
    CONSTRAINT FK_Reservaciones_Cliente FOREIGN KEY (IdCliente) REFERENCES Clientes(ID),
    CONSTRAINT FK_Reservaciones_Destino FOREIGN KEY (IdDestino) REFERENCES Destinos(ID)
);
GO


CREATE TABLE Hoteles (
    ID INT IDENTITY CONSTRAINT PK_Hoteles PRIMARY KEY,
    Nombre VARCHAR(100),
    Direccion VARCHAR(200),
    Ciudad VARCHAR(100),
    Pais VARCHAR(100),
    Precio DECIMAL(10, 2)
);
GO


CREATE TABLE CategoriasHoteles (
    ID INT IDENTITY CONSTRAINT PK_CategoriasHoteles PRIMARY KEY,
    NombreCategoria VARCHAR(100)
);
GO



CREATE TABLE ComentariosDestinos (
    ID INT IDENTITY CONSTRAINT PK_ComentariosDestinos PRIMARY KEY,
    IdDestino INT,
    Descripcion VARCHAR(100),
    CONSTRAINT FK_ComentariosDestinos FOREIGN KEY (IdDestino) REFERENCES Destinos(ID)
);
GO