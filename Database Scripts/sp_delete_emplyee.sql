USE [MyDB]
GO
/****** Object:  StoredProcedure [dbo].[sp_delete_emplyee]    Script Date: 8/24/2019 4:18:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_delete_emplyee] 
	-- Add the parameters for the stored procedure here
	@employeeID INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM EMP_EMPLOYEE WHERE employee_id =@employeeID
END
