USE [MyDatabase]
GO
/****** Object:  Trigger [dbo].[trg_audit_columns]    Script Date: 22-08-2019 21:32:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER [dbo].[trg_audit_columns] 
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
