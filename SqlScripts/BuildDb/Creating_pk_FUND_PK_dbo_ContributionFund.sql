ALTER TABLE [dbo].[ContributionFund] ADD CONSTRAINT [FUND_PK] PRIMARY KEY NONCLUSTERED  ([FundId])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
