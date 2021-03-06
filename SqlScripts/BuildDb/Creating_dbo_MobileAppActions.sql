CREATE TABLE [dbo].[MobileAppActions]
(
[id] [int] NOT NULL IDENTITY(1, 1),
[type] [int] NOT NULL CONSTRAINT [DF_MobileAppActions_type] DEFAULT ((0)),
[title] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL CONSTRAINT [DF_MobileAppActions_title] DEFAULT (''),
[option] [int] NOT NULL CONSTRAINT [DF_MobileAppActions_option] DEFAULT ((0)),
[data] [nvarchar] (max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL CONSTRAINT [DF_MobileAppActions_url] DEFAULT (''),
[order] [int] NOT NULL CONSTRAINT [DF_MobileAppActions_order] DEFAULT ((0)),
[loginType] [int] NOT NULL CONSTRAINT [DF_MobileAppActions_loginType] DEFAULT ((0)),
[enabled] [bit] NOT NULL CONSTRAINT [DF_MobileAppActions_enabled] DEFAULT ((1)),
[roles] [nvarchar] (max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL CONSTRAINT [DF_MobileAppActions_roles] DEFAULT (''),
[api] [int] NOT NULL CONSTRAINT [DF_MobileAppActions_api] DEFAULT ((0))
)
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
