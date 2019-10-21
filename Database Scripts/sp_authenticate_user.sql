USE [AnirbanDB]
GO
/****** Object:  StoredProcedure [dbo].[sp_register_user]    Script Date: 10/21/2019 7:43:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Create Store Procedure for authenticating users on login
CREATE PROCEDURE [dbo].[sp_authenticate_user] 
  @userName nvarchar(50)
, @password nvarchar(500)
AS
BEGIN
  DECLARE @count int
  DECLARE @returnCode int

  SELECT
    @count = COUNT(usr.user_name)
  FROM dbo.USR_USER usr
  WHERE usr.user_name = @userName
  and usr.password = @password

  IF @count = 1
	BEGIN
		SET @returnCode = 1
	END
  ELSE
	BEGIN
		SET @returnCode = -1
	END

  SELECT
    @returnCode AS ReturnValue
END

