create database FidelitasComunica

use FidelitasComunica

drop table Usuario
create table Usuario(
ID int primary key IDENTITY(1,1) not null,
usuario varchar(10) not null,
contrasena varchar(10) not null);

insert into Usuario(usuario,contrasena)
values('admin','pass');

select * from Usuario;
 
/*paquetes_Viaje*/
CREATE TABLE Paquete (
    ID INT IDENTITY (1,1) PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    destino VARCHAR(100) NOT NULL,
    duracion_dias INT NOT NULL,
    precio DECIMAL(10, 2)NOT NULL,
    fecha_inicio DATE NOT NULL,
    fecha_fin DATE NOT NULL,
    descripcion VARCHAR(500) NOT NULL,
    cantidad_personas INT NOT NULL
);

INSERT INTO Paquete (nombre, destino, duracion_dias, precio, fecha_inicio, fecha_fin, descripcion, cantidad_personas)
VALUES ('Paquete A', 'Destino A', 7, 1500.00, CONVERT(DATE, '01-08-2023', 105), CONVERT(DATE, '07-08-2023', 105), 'Descripci�n del paquete A', 2);

select * from paquetes_Viaje;

DROP TABLE paquetes_Viaje


/*Destino Turistico*/
CREATE TABLE Destino (
    ID INT IDENTITY(1, 1) PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    pais VARCHAR(100) NOT NULL,
    ciudad VARCHAR(100) NOT NULL,
    descripcion VARCHAR(500) NOT NULL,
    clima VARCHAR(50) NOT NULL,
    atracciones VARCHAR(500) NOT NULL,
    idioma_principal VARCHAR(50) NOT NULL,
    moneda VARCHAR(50) NOT NULL
);

INSERT INTO Destino (nombre, pais, ciudad, descripcion, clima, atracciones, idioma_principal, moneda)
VALUES
    ('Playa del Carmen', 'M�xico', 'Quintana Roo', 'Playa del Carmen es un famoso destino tur�stico en la Riviera Maya, conocido por sus hermosas playas de arena blanca y aguas cristalinas.', 'Tropical', 'Playas de arena blanca, Parque tem�tico Xcaret, Ruinas mayas de Tulum', 'Espa�ol', 'Peso mexicano'),
    ('Tokio', 'Jap�n', 'Tokio', 'Tokio es una metr�polis vibrante que combina la modernidad con la tradici�n japonesa. Es famoso por su tecnolog�a de vanguardia y su cultura �nica.', 'Templado', 'Torre Tokyo Skytree, Templo Senso-ji, Barrio de Shibuya', 'Japon�s', 'Yen japon�s'),
    ('Par�s', 'Francia', 'Par�s', 'Par�s es la ciudad del amor y la luz, famosa por sus ic�nicos monumentos, su arte y su gastronom�a.', 'Templado', 'Torre Eiffel, Museo del Louvre, Catedral de Notre-Dame', 'Franc�s', 'Euro'),
    ('S�dney', 'Australia', 'S�dney', 'S�dney es una ciudad costera llena de vida, conocida por su ic�nica �pera de S�dney y sus playas impresionantes.', 'Templado', '�pera de S�dney, Bondi Beach, Puente de la Bah�a de S�dney', 'Ingl�s', 'D�lar australiano');

Select * from Destino;