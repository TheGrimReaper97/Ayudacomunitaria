CREATE DATABASE Ayuda_Comunitaria
GO
USE Ayuda_Comunitaria 

CREATE TABLE Personas
(Nombres VARCHAR(30) NOT NULL,
Apellidos VARCHAR(30) NOT NULL,
N_Casa INT NOT NULL,
ID_Persona VARCHAR(6) NOT NULL,
Integrantes INT NOT NULL,
Fecha_Registro VARCHAR(20) NOT NULL)
GO

CREATE TABLE Productos
(Nombre_Producto VARCHAR(20) NOT NULL,
ID_Producto VARCHAR(10) NOT NULL,
Cantidad_Producto INT NOT NULL)
GO

create table Usuarios
(
Id_usuario INT NOT NULL PRIMARY KEY IDENTITY(1,1),
Nombre Varchar (50) NULL,
Usuario Varchar(50) NULL,
Password VARCHAR(50) NULL,
Tipo_usuario VARCHAR(50) NULL
)

 GO




ALTER TABLE Personas 
ADD CONSTRAINT pk_idpersona
PRIMARY KEY (ID_Persona) 

ALTER TABLE Productos
ADD CONSTRAINT pk_idproducto
PRIMARY KEY (ID_Producto)


select * from Usuarios
insert into Usuarios values ('Gerson Lopez', 'Ger02', '123', 'Admin'),
                            ('Carlos Perez', 'Carlos','321','Usuario');