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
	
	SELECT *FROM EMP_EMPLOYEE 
	WHERE (first_name+' '+last_name) LIKE '%'+@searchItem+'%' 
	OR employee_id = TRY_CONVERT(INT, @searchItem)
	
END
