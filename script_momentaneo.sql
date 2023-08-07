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
VALUES ('Paquete A', 'Destino A', 7, 1500.00, CONVERT(DATE, '01-08-2023', 105), CONVERT(DATE, '07-08-2023', 105), 'Descripción del paquete A', 2);

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
    moneda VARCHAR(50) NOT NULL,
	imagen VARCHAR(200) NOT NULL
);

INSERT INTO Destino (nombre, pais, ciudad, descripcion, clima, atracciones, idioma_principal, moneda, imagen)
VALUES
    ('Playa del Carmen', 'México', 'Quintana Roo', 'Playa del Carmen es un famoso destino turístico en la Riviera Maya, conocido por sus hermosas playas de arena blanca y aguas cristalinas.', 'Tropical', 'Playas de arena blanca, Parque temático Xcaret, Ruinas mayas de Tulum', 'Español', 'Peso mexicano', 'https://assets.simpleviewinc.com/simpleview/image/upload/c_fill,h_700,q_75,w_1200/v1/clients/quintanaroo/RIVIERA_MAYA_PLAYA_MAROMA_675f6ce8-8cfa-43f7-89d0-7f86945f2f08.jpg'),
    ('Tokio', 'Japón', 'Tokio', 'Tokio es una metrópolis vibrante que combina la modernidad con la tradición japonesa. Es famoso por su tecnología de vanguardia y su cultura única.', 'Templado', 'Torre Tokyo Skytree, Templo Senso-ji, Barrio de Shibuya', 'Japonés', 'Yen japonés', 'https://media.admagazine.com/photos/618a5ef1be961b98e9f09804/master/w_1600%2Cc_limit/91686.jpg'),
    ('París', 'Francia', 'París', 'París es la ciudad del amor y la luz, famosa por sus icónicos monumentos, su arte y su gastronomía.', 'Templado', 'Torre Eiffel, Museo del Louvre, Catedral de Notre-Dame', 'Francés', 'Euro', 'https://viajes.nationalgeographic.com.es/medio/2022/07/13/paris_37bc088a_1280x720.jpg'),
    ('Sídney', 'Australia', 'Sídney', 'Sídney es una ciudad costera llena de vida, conocida por su icónica Ópera de Sídney y sus playas impresionantes.', 'Templado', 'Ópera de Sídney, Bondi Beach, Puente de la Bahía de Sídney', 'Inglés', 'Dólar australiano', 'https://fotografias.lasexta.com/clipping/cmsimages01/2021/07/13/AAAC5987-6C8D-48D1-9D24-F601EF1B89FA/98.jpg?crop=1920,1080,x0,y102&width=1900&height=1069&optimize=high&format=webply');

Select * from Destino;

/*Destino Turistico*/
CREATE TABLE ResrvacionDestino (
    ID INT IDENTITY(1, 1) PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    apellidos VARCHAR(100) NOT NULL,
    correo VARCHAR(100) NOT NULL,
	ID_DESTINO int null,
	nombre_destino VARCHAR(100) NULL
);