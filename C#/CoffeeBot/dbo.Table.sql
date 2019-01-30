CREATE TABLE [dbo].[Accounts]
(
	[accID] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [accUserName] NCHAR(25) NOT NULL, 
    [accPassword] NCHAR(40) NOT NULL,
)
