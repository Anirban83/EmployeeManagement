USE [AnirbanDB]
GO
/****** Object:  StoredProcedure [dbo].[sp_register_user]    Script Date: 10/21/2019 7:47:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Create Store Procedure to save user registration details
CREATE PROCEDURE [dbo].[sp_register_user] 
@userName nvarchar(50)
, @password nvarchar(50)
, @mailId nvarchar(50)
AS
BEGIN
  DECLARE @count int
  DECLARE @returnCode int

  SELECT
    @count = COUNT(usr.user_name)
  FROM dbo.USR_USER usr
  WHERE usr.user_name = @userName

  IF @count > 0
  BEGIN
    SET @returnCode = -1
  END
  ELSE
  BEGIN
    SET @returnCode = 1

    INSERT INTO dbo.USR_USER(user_name,password,mail_id,created_by,updated_by)
    VALUES (@userName, @password, @mailId, @userName, @userName)
  END

  SELECT
    @returnCode AS ReturnValue
END

