USE [AnirbanDB]
GO
/****** Object:  StoredProcedure [dbo].[sp_delete_emplyee]    Script Date: 8/25/2019 7:56:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_delete_employee] 
	-- Add the parameters for the stored procedure here
	@employeeId INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	--Set manager id to null for all child employees
	UPDATE  EMP_EMPLOYEE
	SET manager_id = NULL
	WHERE manager_id = @employeeId
	
    -- Insert statements for procedure here
	DELETE FROM EMP_EMPLOYEE 
	WHERE employee_id = @employeeId
END
