USE master;
GO
CREATE DATABASE Nicks_Database
GO

USE Nicks_Database;
GO
CREATE TABLE Products(
ProductID int IDENTITY (1,1) NOT NULL,
PRIMARY KEY(ProductID),
--FOREIGN KEY REFERENCES Orders(OrderID),
name VARCHAR(MAX) NOT NULL,
PRICE float NOT NULL
);
GO

CREATE TABLE  Orders(
OrderID int IDENTITY(1,1)NOT NULL,
PRIMARY KEY(OrderID),
--FOREIGN KEY()
ProductID int,
CustomerID int
);
GO

CREATE TABLE Customers(
CustomerID int IDENTITY (1,1) NOT NULL,
PRIMARY KEY (CustomerID),
first_name VARCHAR(MAX) NOT NULL,
last_name VARCHAR(MAX) not null,
cardnum int
);

GO



