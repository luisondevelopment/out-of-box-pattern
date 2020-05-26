--That prevents the backend to going back to database and lookup for what have changed
--The point here is to, whenever the backend find some unnprocessed row,
--just emit "hey that line changed and thats his new value"
--Example:
-- Exchange: "Document"
--{
--  "Identifier": "5",
--	"DataEmissao": "2019-01-01"
--}
CREATE TABLE ChangeLog
(
	Id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	TableName VARCHAR(100) NOT NULL,
	PrimaryKeyName VARCHAR(20) NOT NULL,
	PrimaryKeyValue INTEGER NOT NULL,
	ColumnName VARCHAR(50) NOT NULL,
	AlteredColumnValue VARCHAR(4000) NOT NULL,
	Processed BIT NOT NULL CONSTRAINT DF_ChangeLog_Processed DEFAULT 0,
	ProcessedAt DATETIME NULL
)

CREATE TABLE Document
(
	DocumentId INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	Nome VARCHAR(100) NOT NULL,
	CotacaoId INT NOT NULL,
	DataEmissao DATETIME NULL
)

CREATE TABLE Cotacao
(
	CotacaoId INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	Nome VARCHAR(100) NOT NULL,
	DataCotacao DATETIME NULL
)

