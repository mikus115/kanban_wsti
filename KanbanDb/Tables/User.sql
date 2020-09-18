﻿CREATE TABLE [dbo].[User]
(
	[UserId] BIGINT IDENTITY(1, 1) NOT NULL,
	[Login] NVARCHAR(50) NOT NULL,
	[Password] NVARCHAR(50) NOT NULL, 
	[Firstname] NVARCHAR(50) NULL, 
    [Lastname] NVARCHAR(50) NULL, 
	[Email] NVARCHAR(50) NOT NULL,
    [ts] ROWVERSION NOT NULL,
	CONSTRAINT [PK_User] PRIMARY KEY ([UserId])
)