--DLL
CREATE DATABASE RpgOnline
GO
USE RpgOnline
GO

CREATE TABLE Usuarios(
	UsuarioId INT PRIMARY KEY IDENTITY,
	Email VARCHAR(100) UNIQUE NOT NULL,	
	Senha VARCHAR(50) NOT NULL
)
GO

CREATE TABLE Classes(
	ClasseId INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(50) UNIQUE NOT NULL,
	Descricao VARCHAR(255) 
)
GO

CREATE TABLE Personagens(
	PersonagemId INT PRIMARY KEY IDENTITY,
	NomePersonagem VARCHAR(30) UNIQUE NOT NULL,
	UsuarioId INT UNIQUE FOREIGN KEY REFERENCES Usuarios(UsuarioId),
	ClasseId INT FOREIGN KEY REFERENCES Classes(ClasseId)
)	
GO

CREATE TABLE Habilidades(
	HabilidadeId INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(50) UNIQUE NOT NULL,
)
GO

CREATE TABLE ClasseHabilidade(
	ClasseId INT FOREIGN KEY REFERENCES Classes(ClasseId),
	HabilidadeId INT FOREIGN KEY REFERENCES Habilidades(HabilidadeId)
)
GO 

--DML

INSERT INTO Usuarios VALUES('email@email.com','123456')
INSERT INTO Classes VALUES('Bárbaro','Descrição do bárbaro')
INSERT INTO Habilidades VALUES('Lança Mortal'), ('Escudo Supremo')
INSERT INTO Personagens (NomePersonagem,UsuarioId, ClasseId) VALUES ('DeuBug',1,1)
INSERT INTO ClasseHabilidade (ClasseId,HabilidadeId) Values (1,1),(1,2)

INSERT INTO Usuarios VALUES('email2@email.com','123456')
INSERT INTO Classes VALUES('Monge','Descrição do Monge')
INSERT INTO Habilidades VALUES('Recuperar Vida')
INSERT INTO Personagens (NomePersonagem,UsuarioId, ClasseId) VALUES ('BitBug',2,2)
INSERT INTO ClasseHabilidade (ClasseId,HabilidadeId) Values (2,2),(2,3)

UPDATE Usuarios
SET Senha = '123456'
WHERE UsuarioId = 1
 
 --DQL
SELECT * FROM Habilidades

SELECT P.NomePersonagem, C.Nome 'Nome da Classe',C.Descricao FROM Personagens P JOIN Classes C
ON P.ClasseId = C.ClasseId
--Exemplo de JOIN

CREATE DATABASE ExemploJoin
GO

USE ExemploJoin
GO

--DDL
CREATE TABLE TabelaA(
	Nome varchar(50) NOT NULL
)

GO

CREATE TABLE TabelaB(
	Nome varchar(50) NOT NULL
)
GO

--DML

INSERT INTO TabelaA VALUES('Fernanda')
INSERT INTO TabelaA VALUES('Josefa')
INSERT INTO TabelaA VALUES('Luiz')
INSERT INTO TabelaA VALUES('Fernando')

INSERT INTO TabelaB VALUES ('Carlos'),('Manoel'),('Luiz'),('Fernando')

SELECT TabelaA.Nome, TabelaB.Nome  FROM TabelaA INNER JOIN TabelaB
ON TabelaA.Nome = TabelaB.Nome

SELECT TabelaA.Nome, TabelaB.Nome  FROM TabelaA LEFT JOIN TabelaB
ON TabelaA.Nome = TabelaB.Nome

SELECT TabelaA.Nome, TabelaB.Nome  FROM TabelaA RIGHT JOIN TabelaB
ON TabelaA.Nome = TabelaB.Nome

SELECT TabelaA.Nome, TabelaB.Nome  FROM TabelaA FULL OUTER JOIN TabelaB
ON TabelaA.Nome = TabelaB.Nome

SELECT TabelaA.Nome, TabelaB.Nome  FROM TabelaA FULL OUTER JOIN TabelaB
ON TabelaA.Nome = TabelaB.Nome
Where TabelaA.Nome IS NULL

SELECT TabelaA.Nome, TabelaB.Nome  FROM TabelaA FULL OUTER JOIN TabelaB
ON TabelaA.Nome = TabelaB.Nome
Where TabelaB.Nome IS NULL OR TabelaA.Nome IS NULL