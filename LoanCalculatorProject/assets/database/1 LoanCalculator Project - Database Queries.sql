-- Project Name: LoanCalculatorProject
-- Author: Kevin Stephen Biswas
----------------------------------------------

--Drop Queries(if needed)
---------------------------------
-- DROP TABLE tblUser;
-- DROP DATABASE LoanCalculatorProject;


-- Creating Database LoanCalculatorProject.
CREATE DATABASE LoanCalculatorProject;


-- Selecting the LoanCalculatorProject Database.
USE LoanCalculatorProject;


-- Creating tblUser.
CREATE TABLE tblUser
(
	userId int IDENTITY(1,1) not null,
	userName varchar(50) not null,
	balance numeric(18,5) not null,
	firstName varchar(50) not null,
	lastName varchar(50) not null,
	password varchar(50) not null,
	CONSTRAINT PK_tblUser PRIMARY KEY (userId),
	CONSTRAINT UQ_tblUser_userName UNIQUE (userName)
);


-- Inserting Dummy Datas.
INSERT INTO tblUser(userName,balance,firstName,lastName,password) 
VALUES
('aljack',15000,'alice','jackson','alice123'),
('bobli',25000,'bob','lilon','bob123'),
('jahil',33000,'james','hilton','james123'),
('ppane',45500,'pitter','pane','pitter123'),
('bruceali',34400,'bruce','ality','bruce123');


-- Show the tblUser Datas
SELECT * 
FROM tblUser;



