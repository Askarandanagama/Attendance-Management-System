CREATE DATABASE Attendance_Management_System2;

CREATE TABLE User_Table
(
	User_ID INT IDENTITY(1,1),
	User_Name VARCHAR(150) UNIQUE,
	User_Pass Varchar(150),
	User_Pho VARCHAR(15),
	User_CNIC VARCHAR(15) UNIQUE,
	User_DOB VARCHAR(10),
	User_Gender VARCHAR(6),
	User_Email VARCHAR(30),
	User_Role VARCHAR(5),
	User_Add VARCHAR(150),
	CONSTRAINT User_Table_PK PRIMARY KEY (User_ID)

);

INSERT INTO User_Table VALUES
	('Nameone', '12345', '+11 23456787' ,'2001829393399', '1/2/2000' ,'Male', 'nameone@mail.com', 'user','colombo'),
	('Nametwo', '23456','+11224364342', '200128939333','01/12/2000','Male', 'nametwo@mail.com', 'user','colombo');


CREATE TABLE Class_Table
(
	Class_ID INT IDENTITY(1, 1),
	Class_Name VARCHAR(150) UNIQUE,
	Class_Total INT,
	Class_Male INT,
	Class_Female INT,
	CONSTRAINT Class_Table_PK PRIMARY KEY(Class_ID)
);