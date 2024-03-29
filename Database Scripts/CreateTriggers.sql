--USE [MyDatabase]
--USE [MyDB]
USE [AnirbanDB]

GO
/****** Object:  Trigger [dbo].[trg_DEP_DEPARTMENT_audit_columns]    Script Date: 22-08-2019 21:32:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER [dbo].[trg_DEP_DEPARTMENT_audit_columns] 
   ON  [dbo].[DEP_DEPARTMENT]
   AFTER INSERT,UPDATE
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for trigger here
	UPDATE dbo.DEP_DEPARTMENT
	SET created_on=GETDATE(),
		updated_on=GETDATE()
		FROM dbo.DEP_DEPARTMENT
		JOIN inserted I ON DEP_DEPARTMENT.department_id=I.department_id

END
GO

--Create Trigger for COU_COUNTRY table
/****** Object:  Trigger [dbo].[trg_COU_COUNTRY_audit_columns]    Script Date: 8/24/2019 2:47:12 AM ******/
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER [dbo].[trg_COU_COUNTRY_audit_columns] 
   ON  [dbo].[COU_COUNTRY]
   AFTER INSERT,UPDATE
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for trigger here
	UPDATE dbo.COU_COUNTRY
	SET created_on=GETDATE(),
		updated_on=GETDATE()
	FROM dbo.COU_COUNTRY
	JOIN inserted I ON COU_COUNTRY.country_id=I.country_id

END
GO

--Create Trigger for EMP_EMPLOYEE table
/****** Object:  Trigger [dbo].[trg_EMP_EMPLOYEE_audit_columns]   Script Date: 8/24/2019 2:47:12 AM ******/
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER [dbo].[trg_EMP_EMPLOYEE_audit_columns] 
   ON  [dbo].[EMP_EMPLOYEE]
   AFTER INSERT,UPDATE
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for trigger here
	UPDATE dbo.EMP_EMPLOYEE
	SET created_on=GETDATE(),
		updated_on=GETDATE()
	FROM dbo.EMP_EMPLOYEE
	JOIN inserted I ON EMP_EMPLOYEE.employee_id=I.employee_id

END
GO

--Create Trigger for EMP_EMPLOYEE_DETAILS table
/****** Object:  Trigger [dbo].[trg_EMD_EMPLOYEE_DETAILS_audit_columns]    Script Date: 8/24/2019 2:47:12 AM ******/
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER [dbo].[trg_EMD_EMPLOYEE_DETAILS_audit_columns] 
   ON  [dbo].[EMD_EMPLOYEE_DETAILS]
   AFTER INSERT,UPDATE
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for trigger here
	UPDATE dbo.EMD_EMPLOYEE_DETAILS
	SET created_on=GETDATE(),
		updated_on=GETDATE()
	FROM dbo.EMD_EMPLOYEE_DETAILS
	JOIN inserted I ON EMD_EMPLOYEE_DETAILS.employee_details_id=I.employee_details_id

END
GO