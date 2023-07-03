create database FidelitasComunica

use FidelitasComunica

drop table Usuarios
create table Usuario(
usuario varchar(10) not null,
contrasena varchar(10) not null);

insert into Usuario(usuario,contrasena)
values('admin','pass');

select * from Usuario;