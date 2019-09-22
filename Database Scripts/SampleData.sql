USE [AnirbanDB]
GO

INSERT INTO [dbo].[COU_COUNTRY]
           ([country_code]
           ,[country_name]
           ,[created_by]
           ,[updated_by])
     VALUES
           ('ARG'
           ,'Argentina'
           ,SYSTEM_USER 
           ,SYSTEM_USER);

INSERT INTO [dbo].[COU_COUNTRY]
           ([country_code]
           ,[country_name]
           ,[created_by]
           ,[updated_by])
     VALUES
           ('IND'
           ,'India'
           ,SYSTEM_USER 
           ,SYSTEM_USER);


INSERT INTO [dbo].[COU_COUNTRY]
           ([country_code]
           ,[country_name]
           ,[created_by]
           ,[updated_by])
     VALUES
           ('AUS'
           ,'Australia'
           ,SYSTEM_USER 
           ,SYSTEM_USER);


INSERT INTO [dbo].[COU_COUNTRY]
           ([country_code]
           ,[country_name]
           ,[created_by]
           ,[updated_by])
     VALUES
           ('FRA'
           ,'France'
           ,SYSTEM_USER 
           ,SYSTEM_USER);


INSERT INTO [dbo].[COU_COUNTRY]
           ([country_code]
           ,[country_name]
           ,[created_by]
           ,[updated_by])
     VALUES
           ('USA'
           ,'United States'
           ,SYSTEM_USER 
           ,SYSTEM_USER);

GO

INSERT INTO [dbo].[DEP_DEPARTMENT]
           ([department_name]
           ,[created_by]
           ,[updated_by])
     VALUES
           ('Accounting'
           ,SYSTEM_USER
           ,SYSTEM_USER);

INSERT INTO [dbo].[DEP_DEPARTMENT]
           ([department_name]
           ,[created_by]
           ,[updated_by])
     VALUES
           ('Sales'
           ,SYSTEM_USER
           ,SYSTEM_USER);

INSERT INTO [dbo].[DEP_DEPARTMENT]
           ([department_name]
           ,[created_by]
           ,[updated_by])
     VALUES
           ('Information Technology'
           ,SYSTEM_USER
           ,SYSTEM_USER);

INSERT INTO [dbo].[DEP_DEPARTMENT]
           ([department_name]
           ,[created_by]
           ,[updated_by])
     VALUES
           ('Operations'
           ,SYSTEM_USER
           ,SYSTEM_USER);
GO


