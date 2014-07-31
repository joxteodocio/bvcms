CREATE NONCLUSTERED INDEX [IX_EmailQueueToFail_2] ON [dbo].[EmailQueueToFail] ([timestamp])
GO
IF @@ERROR<>0 AND @@TRANCOUNT>0 ROLLBACK TRANSACTION
GO
IF @@TRANCOUNT=0 BEGIN INSERT INTO #tmpErrors (Error) SELECT 1 BEGIN TRANSACTION END
GO