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