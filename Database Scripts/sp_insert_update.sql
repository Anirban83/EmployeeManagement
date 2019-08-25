USE [MyDatabase]
GO
/****** Object:  StoredProcedure [dbo].[sp_insert_or_update_employee]    Script Date: 25-08-2019 20:15:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[sp_insert_or_update_employee]
	-- Add the parameters for the stored procedure here
	@employeeId int,
	@firstname nvarchar(50),
	@lastname nvarchar(50),
	@salary int,
	@bonus int,
	@deptId int,
	@managerId int,
	@phoneNumber nvarchar(50),
	@address nvarchar(50),
	@mail nvarchar(50),
	@gender char(1),
	@countryID int,
	@createdBy nvarchar(50),
	@updatedBy nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
    -- Insert statements for procedure here
	declare @id as int
	IF ((SELECT COUNT(*) FROM dbo.EMP_EMPLOYEE WHERE employee_id=@employeeId)=0)
		BEGIN
			INSERT INTO dbo.EMP_EMPLOYEE(first_name,last_name,salary,bonus,department_id,manager_id,created_by,updated_by)
			VALUES(@firstname,@lastname,@salary,@bonus,@deptId,@managerId,@createdBy,@updatedBy);
			set @id=(SELECT IDENT_CURRENT('EMP_EMPLOYEE'));
			INSERT INTO 
			dbo.EMD_EMPLOYEE_DETAILS(employee_id,phone_number,address,mail_id,gender,country_id,created_by,updated_by)
			VALUES(@id,@phoneNumber,@address,@mail,@gender,@countryID,@createdBy,@updatedBy)
			IF @@ERROR!=0
				BEGIN
					delete from dbo.EMP_EMPLOYEE where employee_id=@id
				END
		END
	ELSE
		BEGIN
			UPDATE dbo.EMP_EMPLOYEE
			SET
			first_name=@firstname,
			last_name=@lastname,
			salary=@salary,
			bonus=@bonus,
			department_id=@deptId,
			manager_id=@managerId,
			created_by=@createdBy,
			updated_by=@updatedBy
			WHERE
			employee_id=@employeeId

			UPDATE dbo.EMD_EMPLOYEE_DETAILS
			SET
			phone_number=@phoneNumber,
			address=@address,
			mail_id=@mail,
			gender=@gender,
			country_id=@countryID,
			created_by=@createdBy,
			updated_by=@updatedBy
			WHERE
			employee_id=@employeeId
			SET IDENTITY_INSERT dbo.EMD_EMPLOYEE_DETAILS OFF
		END
END