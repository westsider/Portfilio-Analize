CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [tradeNum] INT NULL, 
    [dateEntry] NCHAR(10) NULL, 
    [dateExit] NCHAR(10) NULL, 
    [ticker] NCHAR(10) NULL, 
    [profit] SMALLMONEY NULL, 
    [cumProfit] SMALLMONEY NULL, 
    [exitName] NCHAR(10) NULL, 
    [profitFactor] DECIMAL NULL, 
    [winPct] DECIMAL NULL, 
    [consecutiveLosers] SMALLMONEY NULL, 
    [largestLoser] SMALLMONEY NULL, 
    [largestWinner] SMALLMONEY NULL, 
    [profitPerMonth] SMALLMONEY NULL
)
