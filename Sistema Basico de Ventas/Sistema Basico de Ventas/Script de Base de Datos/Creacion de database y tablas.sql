use master
go
create database garay_ventas


create table Usuarios(
Usuario varchar(50),
contraseña varchar(50)
)


create table clientes(
codcliente varchar (50),
nombres varchar (79),
pedido varchar (100)
)

create table productos(
codproducto varchar(50),
nombreproducto varchar(100),
precio varchar(100)
)