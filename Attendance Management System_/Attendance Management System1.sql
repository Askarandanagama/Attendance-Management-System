CREATE DATABASE Attendance_Management_System1;

CREATE TABLE User_Table
(
	User_ID INT IDENTITY(1,1),
	User_Name VARCHAR(150) UNIQUE,
	User_Pass Varchar(150),
	User_Email VARCHAR(150),
	CONSTRAINT User_Table_PK PRIMARY KEY (User_ID)

);

INSERT INTO User_Table VALUES
	('Nameone', '12345', 'nameone@mail.com'),
	('Nametwo', '23456', 'nametwo@mail.com');