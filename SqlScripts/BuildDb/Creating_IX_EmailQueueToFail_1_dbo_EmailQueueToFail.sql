CREATE NONCLUSTERED INDEX [IX_EmailQueueToFail_1] ON [dbo].[EmailQueueToFail] ([Id], [PeopleId])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
