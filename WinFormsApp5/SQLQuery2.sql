CREATE DATABASE Aula

USE [Aula]
CREATE TABLE Clientes
(
   IdCliente        INT    NOT NULL   PRIMARY KEY identity(1,1),
   Nome      [NVARCHAR](50)  NOT NULL,
   Telefone  [NVARCHAR](20)
);

INSERT INTO Clientes
   ([Nome], [Telefone])
VALUES
   (N'Fernando', N'(43)3333-3333');

SELECT * FROM Clientes;