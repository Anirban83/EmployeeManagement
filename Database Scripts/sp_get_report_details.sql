USE [AnirbanDB]
GO
/****** Object:  StoredProcedure [dbo].[sp_get_report_details]    Script Date: 9/13/2019 9:08:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_get_report_details]
	-- Add the parameters for the stored procedure here
	@reportType		nvarchar(10)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF @reportType = 'CR'
		BEGIN
			SELECT
			  cou.country_code AS CountryCode,
			  cou.country_name AS CountryName,
			  dep.department_name AS DepartmentName,
			  COUNT(emp.employee_id) AS TotalEmployee,
			  SUM(emp.salary) AS TotalSalary
			FROM dbo.COU_COUNTRY cou
			LEFT OUTER JOIN dbo.EMD_EMPLOYEE_DETAILS emd
			  ON cou.country_id = emd.country_id
			LEFT OUTER JOIN dbo.EMP_EMPLOYEE emp
			  ON emd.employee_id = emp.employee_id
			LEFT OUTER JOIN dbo.DEP_DEPARTMENT dep
			  ON emp.department_id = dep.department_id
			GROUP BY cou.country_code,
					 cou.country_name,
					 dep.department_name
			ORDER BY 1, 2, 3, 4 DESC, 5 DESC
		END
	ELSE IF @reportType = 'GR'
		BEGIN
			SELECT
			  CASE emd.gender 
				WHEN 'M' THEN 'Male'
				WHEN 'F' THEN 'Female'
				ELSE 'Other'
				END AS Gender,
			  COUNT(emp.employee_id) AS TotalEmployee,
			  SUM(emp.salary) AS TotalSalary
			FROM dbo.EMP_EMPLOYEE emp
			JOIN dbo.EMD_EMPLOYEE_DETAILS emd
			  ON emd.employee_id = emp.employee_id			
			GROUP BY Gender
			ORDER BY 1, 2 DESC, 3 DESC
		END
END
