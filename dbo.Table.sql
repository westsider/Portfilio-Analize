CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [tradeNum] INT NULL, 
    [dateEntry] NVARCHAR(50) NULL, 
    [dateExit] NVARCHAR(50) NULL, 
    [ticker] NCHAR(10) NULL, 
    [profit] DECIMAL NULL
)
