CREATE DATABASE Attendance_Management_System;

CREATE TABLE Student_Table
(
	Stu_ID INT IDENTITY(1,1),
	Stu_Name VARCHAR(150) UNIQUE,
	Stu_Pass VARCHAR(150),
	Stu_Email VARCHAR(150),
	CONSTRAINT Student_Table_PK PRIMARY KEY (Stu_ID)
);

INSERT INTO Student_Table VALUES
	('Nameone', '12345', 'nameone@mail.com' ),
	('Nametwo', '23456', 'nametwo@mail.com' ),
	('Namethree', '23456', 'namethree@mail.com' ),
	('Namefour', '23456', 'namefour@mail.com' );