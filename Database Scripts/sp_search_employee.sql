USE [MyDB]
GO
/****** Object:  StoredProcedure [dbo].[sp_search_employee]    Script Date: 8/24/2019 3:48:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Create Store Procedure for search employee by first name ,last name or employee id
ALTER PROCEDURE [dbo].[sp_search_employee]
	@searchItem NVARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT EMP_EMPLOYEE.employee_id,first_name,last_name,salary,bonus,department_id,manager_id,phone_number,address,mail_id,gender,country_id 
	FROM EMP_EMPLOYEE JOIN  EMD_EMPLOYEE_DETAILS ON EMD_EMPLOYEE_DETAILS.employee_id = EMP_EMPLOYEE.employee_id
	WHERE (first_name+' '+last_name) LIKE '%'+@searchItem+'%' 
	OR EMP_EMPLOYEE.employee_id = TRY_CONVERT(INT, @searchItem)
	
END
