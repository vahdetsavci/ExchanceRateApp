CREATE DATABASE ExchangeRateDb
GO
USE ExchangeRateDb
GO
CREATE TABLE Currency
(
	 ID UNIQUEIDENTIFIER PRIMARY KEY
	,Code VARCHAR(8)
	,Definition NVARCHAR(70)
	,WarningLimit DECIMAL
)
GO

INSERT INTO Currency VALUES (NEWID(), 'USD', 'ABD Dolarý', 0)
INSERT INTO Currency VALUES (NEWID(), 'EUR', 'Euro', 0)
INSERT INTO Currency VALUES (NEWID(), 'GBP', 'Ýngiliz Sterlini', 0)

CREATE TABLE ExchangeRate
(
	 ID UNIQUEIDENTIFIER PRIMARY KEY
	,CurrencyID UNIQUEIDENTIFIER
	,Buying DECIMAL(18, 4)
	,Selling DECIMAL(18, 4)
	,Date DATETIME
)
GO

CREATE TABLE ExchangeRateHistory
(
	 ID UNIQUEIDENTIFIER PRIMARY KEY
	,ExchangeRateID UNIQUEIDENTIFIER
	,CurrencyID UNIQUEIDENTIFIER
	,Buying DECIMAL(18, 4)
	,Selling DECIMAL(18, 4)
	,Date DATETIME
)
GO

CREATE PROC GetCurrencies
AS
SELECT * FROM Currency
GO

CREATE PROC GetExchangeRates
AS
SELECT * FROM ExchangeRate
GO

CREATE PROC GetExchangeRateByCurrencyID
(
	@CurrencyID UNIQUEIDENTIFIER
)
AS
SELECT * FROM ExchangeRate WHERE CurrencyID = @CurrencyID
GO

CREATE PROC GetExchangeRateHistory
AS
SELECT * FROM ExchangeRateHistory ORDER BY Date
GO

CREATE PROC GetExchangeRateHistoryByCurrencyID
(
	@CurrencyID UNIQUEIDENTIFIER
)
AS
SELECT * FROM ExchangeRateHistory WHERE CurrencyID = @CurrencyID ORDER BY Date
GO

EXEC ListExchangeRate

SELECT * FROM Currency

CREATE PROC InsertExchangeRate
(
	 @ID UNIQUEIDENTIFIER
	,@CurrencyID UNIQUEIDENTIFIER
	,@Buying DECIMAL(18, 4)
	,@Selling DECIMAL(18, 4)
	,@Date DATETIME
)
AS
BEGIN
	IF((SELECT COUNT(*) FROM ExchangeRate WHERE CurrencyID = @CurrencyID) > 0)
		BEGIN
			INSERT INTO ExchangeRateHistory (ID, ExchangeRateID, CurrencyID, Buying, Selling, Date) SELECT NEWID(), ID, CurrencyID, Buying, Selling, Date FROM ExchangeRate WHERE CurrencyID = @CurrencyID

			UPDATE ExchangeRate
				SET  Buying = @Buying
					,Selling = @Selling
					,Date = @Date
				WHERE
					CurrencyID = @CurrencyID
		END

	ELSE
		BEGIN
			INSERT INTO ExchangeRate (ID, CurrencyID, Buying, Selling, Date) VALUES (@ID, @CurrencyID, @Buying, @Selling, @Date)
		END
END

