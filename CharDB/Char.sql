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
	,Name				varchar(30)		/*NOT NULL*/
	,alighnment				varchar(30)		NOT NULL
	,jobclass			varchar(30)		NOT NULL
	,race				varchar(30)		NOT NULL
	,Strength			smallint		NOT NULL
	,Dexterity			smallint		NOT NULL
	,Constitution		smallint		NOT NULL
	,Intelligence		smallint		NOT NULL
	,Wisdom				smallint		NOT NULL
	,Charisma			smallint		NOT NULL
	,Strengthbonus			smallint		NOT NULL
	,Dexteritybonus			smallint		NOT NULL
	,Constitutionbonus		smallint		NOT NULL
	,Intelligencebonus		smallint		NOT NULL
	,Wisdombonus		smallint		NOT NULL
	,Charismabonus			smallint		NOT NULL
	,appraise			smallint		NOT NULL ,
     balance			smallint		NOT NULL ,
              bluff smallint NOT NULL ,
              climb smallint NOT NULL ,
              concentrate smallint NOT NULL ,
              craft1 smallint NOT NULL ,
              craft2 smallint NOT NULL ,
              craft3 smallint NOT NULL ,
              deciferScript smallint NOT NULL ,
              diplomacy smallint NOT NULL ,
              disableDevice smallint NOT NULL ,
              disguise smallint NOT NULL ,
              escapeArtist smallint NOT NULL ,
              forgery smallint NOT NULL ,
              gatherInformation smallint NOT NULL ,
              handleanimal smallint NOT NULL ,
              heal smallint NOT NULL ,
              intimidate smallint NOT NULL ,
              jump smallint NOT NULL ,
              arcana smallint NOT NULL ,
              Architecture smallint NOT NULL ,
              dungeonereing smallint NOT NULL ,
              geography smallint NOT NULL ,
              history smallint NOT NULL ,
              local smallint NOT NULL ,
              nature smallint NOT NULL ,
              noble smallint NOT NULL ,
              religion smallint NOT NULL ,
              planes smallint NOT NULL ,
              listen smallint NOT NULL ,
              moveSilently smallint NOT NULL ,
              openLock smallint NOT NULL ,
              preform1 smallint NOT NULL ,
              preform2 smallint NOT NULL ,
              preform3 smallint NOT NULL ,
              preform4 smallint NOT NULL ,
              preform5 smallint NOT NULL ,
              profession smallint NOT NULL ,
              ride smallint NOT NULL ,
              search smallint NOT NULL ,
              senseMotive smallint NOT NULL ,
              sleightOfHand smallint NOT NULL ,
              speakLanguage smallint NOT NULL ,
              spellcraft smallint NOT NULL ,
              spot smallint NOT NULL ,
              survival smallint NOT NULL ,
              swim smallint NOT NULL ,
              tumble smallint NOT NULL ,
              useMagicDevice smallint NOT NULL ,
              useRope smallint NOT NULL ,
              autohypnosis smallint NOT NULL ,
              psionics smallint NOT NULL ,
              psicraft smallint NOT NULL ,
              usePsi smallint NOT NULL
)
GO
select * from Character