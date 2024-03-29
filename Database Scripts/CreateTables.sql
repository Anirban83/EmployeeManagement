--Select the database where we need to run this script

--USE [MyDatabase]
USE [AnirbanDB]
GO

--Creating table for Countries
CREATE TABLE dbo.COU_COUNTRY
( 
	country_id INT IDENTITY(1,1) PRIMARY KEY,
	country_code NVARCHAR(3) NOT NULL UNIQUE,
	country_name NVARCHAR(50) NOT NULL UNIQUE,
	created_by NVARCHAR(50) NOT NULL,
    created_on DATETIME NULL,
    updated_by NVARCHAR(50) NOT NULL,
    updated_on DATETIME NULL
)
GO

--Script to create department table
CREATE TABLE dbo.DEP_DEPARTMENT
(
	department_id INT IDENTITY(1,1) NOT NULL,
	department_name NVARCHAR(50) NOT NULL,
	created_by NVARCHAR(50) NOT NULL,
    created_on DATETIME NULL,
    updated_by NVARCHAR(50) NOT NULL,
    updated_on DATETIME NULL,
CONSTRAINT PK_DEP_DEPARTMENT 
	PRIMARY KEY (department_id),
CONSTRAINT UK_DEP_DEPARTMENT_department_name 
	UNIQUE (department_name)
)
GO


--created employee table
CREATE TABLE dbo.EMP_EMPLOYEE
( 
	employee_id INT IDENTITY(1,1) PRIMARY KEY,
	first_name VARCHAR(50) NOT NULL,
	last_name VARCHAR(50) NOT NULL,
	salary INT NOT NULL,  
	bonus INT,
	department_id INT NOT NULL,
	manager_id INT,
	created_by NVARCHAR(50) NOT NULL,
	created_on DATETIME NULL,
    updated_by NVARCHAR(50) NOT NULL,
    updated_on DATETIME NULL,
CONSTRAINT UK_EMP_EMPLOYEE_first_name_last_name 
	UNIQUE (first_name,last_name),
CONSTRAINT FK_DEP_DEPARTMENT_EMP_EMPLOYEE
    FOREIGN KEY (department_id)
    REFERENCES dbo.DEP_DEPARTMENT(department_id)
	ON DELETE CASCADE,
CONSTRAINT FK_EMP_EMPLOYEE_employee_id_manager_id 
    FOREIGN KEY (manager_id) 
	REFERENCES dbo.EMP_EMPLOYEE(employee_id)
	ON DELETE NO ACTION
)
GO

--created employee details table
CREATE TABLE dbo.EMD_EMPLOYEE_DETAILS
( 
	employee_details_id INT IDENTITY(1,1) PRIMARY KEY,
	employee_id INT NOT NULL,
	phone_number NVARCHAR(50) NOT NULL UNIQUE,
	address NVARCHAR(50) NOT NULL,
	mail_id NVARCHAR(50) NOT NULL UNIQUE,
	gender CHAR(1) NOT NULL,
	country_id INT NOT NULL,
	created_by NVARCHAR(50) NOT NULL,
    created_on DATETIME NULL,
    updated_by NVARCHAR(50) NOT NULL,
    updated_on DATETIME NULL,
CONSTRAINT FK_COU_COUNTRY_EMD_EMPLOYEE_DETAILS 
	FOREIGN KEY (country_id) 
	REFERENCES dbo.COU_COUNTRY(country_id) 
	ON DELETE CASCADE,
CONSTRAINT FK_EMP_EMPLOYEE_EMD_EMPLOYEE_DETAILS
    FOREIGN KEY (employee_id)
	REFERENCES dbo.EMP_EMPLOYEE(employee_id)
	ON DELETE CASCADE
)
GO
