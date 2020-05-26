CREATE TRIGGER TR_Document_ChangeLog
ON Document
AFTER UPDATE
AS
BEGIN
SET XACT_ABORT OFF;

	IF UPDATE (DataEmissao)
	BEGIN
		INSERT ChangeLog (TableName, PrimaryKeyName, PrimaryKeyValue, ColumnName, AlteredColumnValue)
		VALUES('Document', 'DocumentId', (SELECT DocumentId FROM inserted) ,'DataEmissao', (SELECT  CAST(DataEmissao as varchar(4000)) FROM inserted))
	END

END


INSERT Document (Nome, CotacaoId)
VALUES ('teste', 1)

select * from Document
select * from changelog

update document set DataEmissao = getdate()


DROP TRIGGER TR_Document_ChangeLog

