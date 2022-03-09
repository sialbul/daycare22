USE master
GO

IF DB_ID('daycare22') IS NOT NULL
BEGIN
	ALTER DATABASE daycare22 SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
	DROP DATABASE daycare22;
END

CREATE DATABASE daycare22
GO

USE daycare22
GO

BEGIN TRANSACTION

create table student (
	student_id int IDENTITY(1,1)  NOT NULL, 
	img_url varchar(256)  NULL, 
	student_name varchar(64) NOT NULL, 
	birth_date date NOT NULL,
	address_id int NOT NULL,
	phoneNumber varchar (20) NOT NULL,

	CONSTRAINT PK_student_id PRIMARY KEY (student_id),
	CONSTRAINT FK_student_address FOREIGN KEY (address_id) REFERENCES address(address_id),
)

create table address(
address_id int IDENTITY(1000,1) NOT NULL,
streetAddress varchar (256) NOT NULL,
city varchar (80) NOT NULL,
state varchar (80) NOT NULL,
zip int NOT NULL
CONSTRAINT PK_address_id PRIMARY KEY (address_id),
)
create table owner(
	owner_id int IDENTITY(100,1)  NOT NULL, 
	img_url varchar(256) NULL, 
	owner_name varchar(64)  NULL, 
	birth_date date  NULL,
	address_id int  NULL,
	phoneNumber varchar (20)  NULL,
	emailAddress varchar(64)  NULL, 

	CONSTRAINT PK_owner_id PRIMARY KEY (owner_id),
	CONSTRAINT FK_owner_address FOREIGN KEY (owner_id) REFERENCES address(address_id),

)
create table manager (
	manager_id int IDENTITY(100,1)  NOT NULL, 
	img_url varchar(256) NULL, 
	manager_name varchar(64) NOT NULL, 
	birth_date date NOT NULL,
	address_id int NOT NULL,
	phoneNumber varchar (20) NOT NULL,
	emailAddress varchar(64) NOT NULL,

	CONSTRAINT PK_manager_id PRIMARY KEY (manager_id),
	CONSTRAINT FK_manager_address FOREIGN KEY (manager_id) REFERENCES address(address_id),
)
create table teacher (
	teacher_id int IDENTITY(100,1)  NOT NULL, 
	img_url varchar(256) NULL, 
	teacher_name varchar(64) NOT NULL, 
	birth_date date NOT NULL,
	address_id int NOT NULL,
	phoneNumber varchar (20) NOT NULL,
	emailAddress varchar(64) NOT NULL, 

	CONSTRAINT PK_teacher_id PRIMARY KEY (teacher_id),
	CONSTRAINT FK_teacher_address FOREIGN KEY (address_id) REFERENCES address(address_id),
)

create table classes (
classes_id  int IDENTITY(1,1)  NOT NULL, 
class_name varchar(64) NOT NULL, 
class_teacher_id  INT NOT NULL,
class_student_id  INT NOT NULL,
class_manager_id INT NULL,
	CONSTRAINT PK_classes_id PRIMARY KEY (classes_id),
	CONSTRAINT FK_class_teacher_id FOREIGN KEY (class_teacher_id) REFERENCES teacher(teacher_id),
	CONSTRAINT FK_class_student_id FOREIGN KEY (class_student_id) REFERENCES student(student_id),
 CONSTRAINT FK_class_manager_id FOREIGN KEY (class_manager_id) REFERENCES manager(manager_id)

)

create table attendance(
attendance_id int IDENTITY(1,1)  NOT NULL, 
hours_attendance int NULL,
day_attendance int NULL,
week_attendance int NULL,
student_id  int not null,
teacher_id int not null,
manager_id int null,

CONSTRAINT PK_attendance_id PRIMARY KEY (attendance_id),
CONSTRAINT FK_attendance_teacher_id FOREIGN KEY (teacher_id) REFERENCES teacher(teacher_id),
CONSTRAINT FK_attendance_student_id FOREIGN KEY (student_id) REFERENCES student(student_id),
CONSTRAINT FK_attendance_manager_id FOREIGN KEY (manager_id) REFERENCES manager(manager_id)

)

create table emergencyContact(
	emergencyContact_id int IDENTITY(100,1)  NOT NULL, 
	emergencyContact_name varchar(64) NOT NULL, 
	address_id int  NULL,
	phoneNumber varchar (20) NOT NULL,
	emailAddress varchar(64)  NULL, 
	student_id  int not null,

	CONSTRAINT PK_emergencyContact_id PRIMARY KEY (emergencyContact_id),
    CONSTRAINT FK_emergencyContact_student_id FOREIGN KEY (student_id) REFERENCES student(student_id),
)

COMMIT TRANSACTION


--ALTER TABLE student ALTER COLUMN img_url varchar(256) NULL

INSERT INTO student(student_name,birth_date, address_id,phoneNumber)
VALUES  ('Test Test1','2020-01-01',1000,'2123456789'),('Test Test2','2020-01-01',1001,'2123456789'),('Test Test3','2020-01-01',1002,'2123456789');

INSERT INTO address(streetAddress,city,state,zip)
VALUES ('123 Street', 'TestCity','OH',32134),('1234 Street', 'TestCity','OH',32134),('12345 Street', 'TestCity','OH',32134);


Select * From student;
Select * FROM address;