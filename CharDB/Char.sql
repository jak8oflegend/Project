USE master
GO

IF DB_ID('CharDB') IS NOT NULL
BEGIN
	DROP DATABASE CharDB
END
GO

CREATE DATABASE CharDB
GO

USE CharDB
GO

CREATE TABLE Character
(
	CharID				smallint		PRIMARY KEY IDENTITY
	,Name				varchar(30)		NOT NULL
	,Strength			smallint		NOT NULL
	,Dexterity			smallint		NOT NULL
	,Constitution		smallint		NOT NULL
	,Intelligence		smallint		NOT NULL
	,Wisdom				smallint		NOT NULL
	,Charisma			smallint		NOT NULL
	,StrBonus			smallint		NOT NULL
	,DexBonus			smallint		NOT NULL
	,ConBonus			smallint		NOT NULL
	,IntBonus			smallint		NOT NULL
	,WisBonus			smallint		NOT NULL
	,ChaBonus			smallint		NOT NULL
)
GO