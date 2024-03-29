USE [AnirbanDB]
GO
/****** Object:  StoredProcedure [dbo].[sp_insert_or_update_employee]    Script Date: 8/25/2019 8:27:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_insert_or_update_employee]
	-- Add the parameters for the stored procedure here
	@employeeId int,
	@firstName nvarchar(50),
	@lastName nvarchar(50),
	@salary int,
	@bonus int,
	@departmentId int,
	@managerId int,
	@phoneNumber nvarchar(50),
	@address nvarchar(50),
	@mailId nvarchar(50),
	@gender char(1),
	@countryId int,
	@createdBy nvarchar(50),
	@updatedBy nvarchar(50)
AS
DECLARE @employee_id_identity INT;
BEGIN TRY
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	BEGIN TRANSACTION;
    -- Insert statements for procedure here
	IF ((SELECT COUNT(*) FROM dbo.EMP_EMPLOYEE WHERE employee_id = @employeeId) = 0)
		BEGIN 
			PRINT 'Inserting into EMP table';
			INSERT INTO 
			dbo.EMP_EMPLOYEE(first_name,last_name,salary,bonus,department_id,manager_id,created_by,updated_by)
			VALUES (@firstname,@lastname,@salary,@bonus,@departmentId,@managerId,@createdBy,@updatedBy);
			
			SET @employee_id_identity = SCOPE_IDENTITY();
			PRINT 'Inserting into EMD table'; 
			INSERT INTO 
			dbo.EMD_EMPLOYEE_DETAILS(employee_id,phone_number,address,mail_id,gender,country_id,created_by,updated_by)
			VALUES(@employee_id_identity,@phoneNumber,@address,@mailId,@gender,@countryId,@createdBy,@updatedBy);
			PRINT 'Insert Complete';			
		END
	ELSE
		BEGIN
			PRINT 'Updating EMP table';
			UPDATE dbo.EMP_EMPLOYEE
			SET
				first_name=@firstname,
				last_name=@lastname,
				salary=@salary,
				bonus=@bonus,
				department_id=@departmentId,
				manager_id=@managerId,
				created_by=@createdBy,
				updated_by=@updatedBy
			WHERE
				employee_id=@employeeId;

			PRINT 'Updating EMD table';
			UPDATE dbo.EMD_EMPLOYEE_DETAILS
			SET
				phone_number=@phoneNumber,
				address=@address,
				mail_id=@mailId,
				gender=@gender,
				country_id=@countryId,
				created_by=@createdBy,
				updated_by=@updatedBy
			WHERE
				employee_id=@employeeId;
		END
	COMMIT TRANSACTION;
END TRY
BEGIN CATCH
    PRINT 'Error Occured. Rolling back.';
	--PRINT 'ERROR_MESSAGE: ' + ERROR_MESSAGE() 
	--	+ ', ERROR_SEVERITY: ' + ERROR_SEVERITY() 
	--	+ ', ERROR_STATE' + ERROR_STATE()
	SELECT ERROR_MESSAGE();
	ROLLBACK TRANSACTION;
END CATCH