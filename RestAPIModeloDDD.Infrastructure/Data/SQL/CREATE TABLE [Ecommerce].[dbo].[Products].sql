CREATE TABLE [dbo].[Products] (
	[Id] [INT] IDENTITY (1,1) NOT NULL,
	[Name] [VARCHAR] (30) NULL,
	[Value] [DECIMAL] (18, 2) NULL,
	[IsAvailable] [BIT] NOT NULL DEFAULT 1
PRIMARY KEY CLUSTERED
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO