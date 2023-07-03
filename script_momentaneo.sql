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
CREATE TABLE paquetes_Viaje (
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

INSERT INTO paquetes_Viaje (nombre, destino, duracion_dias, precio, fecha_inicio, fecha_fin, descripcion, cantidad_personas)
VALUES ('Paquete A', 'Destino A', 7, 1500.00, CONVERT(DATE, '01-08-2023', 105), CONVERT(DATE, '07-08-2023', 105), 'Descripción del paquete A', 2);

select * from paquetes_Viaje;
