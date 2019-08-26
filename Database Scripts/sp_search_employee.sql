USE [AnirbanDB]
GO
/****** Object:  StoredProcedure [dbo].[sp_search_employee]    Script Date: 8/26/2019 9:18:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Create Store Procedure for search employee by first name ,last name or employee id
CREATE PROCEDURE [dbo].[sp_search_employee]
	@searchText NVARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT emp.*, emd.*
	FROM dbo.EMP_EMPLOYEE emp,
	     dbo.EMD_EMPLOYEE_DETAILS emd
	WHERE 1 = 1	
	AND emp.employee_id = emd.employee_id
	AND ((emp.first_name + ' ' + emp.last_name) LIKE '%' + @searchText + '%'
	OR emp.employee_id = TRY_CONVERT(INT,@searchText))
	
END
