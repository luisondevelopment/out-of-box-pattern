CREATE TRIGGER TR_Document_ChangeLog
ON Document
AFTER UPDATE
AS
BEGIN

BEGIN TRY
    PRINT '@@TRANCOUNT = ' + CONVERT(VARCHAR(10), @@TRANCOUNT); -- for debug only
    SAVE TRANSACTION InsertSaveHere;
	COMMIT TRANSACTION

    --Simulating error situation
        RAISERROR (N'This is message %s %d.', -- Message text.
          11, -- Severity,
          1, -- State,
          N'number', -- First argument.
          5); -- Second argument.

   --Insert into Archive select * from Inserted;
END TRY
BEGIN CATCH
	PRINT '@@TRANCOUNT before commit = ' + CONVERT(VARCHAR(10), @@TRANCOUNT); -- for debug only
    --COMMIT TRANSACTION InsertSaveHere;
	PRINT '@@TRANCOUNT catch = ' + CONVERT(VARCHAR(10), @@TRANCOUNT); -- for debug only
END CATCH;
PRINT '@@TRANCOUNT = end ' + CONVERT(VARCHAR(10), @@TRANCOUNT); -- for debug only

	--IF UPDATE (DataEmissao)
	--BEGIN
	--	INSERT ChangeLog (TableName, PrimaryKeyName, ColumnName, AlteredColumnValue)
	--	VALUES('Document', 'DocumentId', 'DataEmissao', (SELECT  CAST(DataEmissao as varchar(4000)) FROM inserted))
	--END

END
