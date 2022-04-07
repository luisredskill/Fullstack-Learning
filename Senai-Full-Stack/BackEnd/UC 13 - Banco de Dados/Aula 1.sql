CREATE DATABASE TesteSegurança
GO

USE TesteSegurança
GO

CREATE TABLE Usuarios
(
	Id INT PRIMARY KEY IDENTITY,
	Email VARCHAR(100) UNIQUE NOT NULL,
	Senha VARCHAR(50) NOT NULL
)

INSERT INTO Usuarios VALUES ('email@email.com', 1234) 

SELECT * FROM Usuarios

SELECT Email, HASHBYTES('MD2', Senha) AS 'Senha MD2' FROM Usuarios  Usuarios WHERE Id = 1 
SELECT Email, HASHBYTES('MD4', Senha) AS 'Senha MD4' FROM Usuarios  Usuarios WHERE Id = 1 
SELECT Email, HASHBYTES('MD5', Senha) AS 'Senha MD5' FROM Usuarios  Usuarios WHERE Id = 1 
SELECT Email, HASHBYTES('SHA', Senha) AS 'Senha SHA' FROM Usuarios  Usuarios WHERE Id = 1 
SELECT Email, HASHBYTES('SHA1', Senha) AS 'Senha SHA1' FROM Usuarios  Usuarios WHERE Id = 1 
SELECT Email, HASHBYTES('SHA2_256', Senha) AS 'Senha SHA2_256' FROM Usuarios  Usuarios WHERE Id = 1 
SELECT Email, HASHBYTES('SHA2_512', Senha) AS 'Senha SHA2_512' FROM Usuarios  Usuarios WHERE Id = 1 