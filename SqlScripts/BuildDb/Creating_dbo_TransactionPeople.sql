CREATE TABLE [dbo].[TransactionPeople]
(
[Id] [int] NOT NULL,
[PeopleId] [int] NOT NULL,
[Amt] [money] NULL,
[OrgId] [int] NULL,
[Donor] [bit] NULL
)
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
