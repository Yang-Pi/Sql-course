USE UpdtSession
GO
Create table Directions (
	Id int PRIMARY KEY,
	Title varchar(30) NOT NULL,
	Quantity int);
GO
Create Table Groups (
	Id varchar(10) PRIMARY KEY,
	Dir int NOT NULL FOREIGN KEY REFERENCES Directions,
	Quantity int);
GO
Create table Students (
	Id int IDENTITY PRIMARY KEY,
	FIO varchar(255) NOT NULL, 
	Gr varchar(10) FOREIGN KEY REFERENCES Groups);
 GO
Create table Disciplines (
	Id int IDENTITY PRIMARY KEY, 
	Name varchar(30) NOT NULL);
GO
Create table Uplans (
	Id int IDENTITY PRIMARY KEY, 
	Dir int FOREIGN KEY REFERENCES Directions,
	Disc int FOREIGN KEY REFERENCES Disciplines,
	Semestr smallint);
GO
Create table Balls (
	Id int IDENTITY(1,1) PRIMARY KEY, 
	Uplan int NOT NULL FOREIGN KEY REFERENCES Uplans, 
	St int NOT NULL FOREIGN KEY REFERENCES Students,
	Ball smallint, 
	DateEx date);