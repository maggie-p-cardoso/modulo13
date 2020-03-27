CREATE DATABASE BDtest
GO

USE [BDtest]
GO

/****** Object:  Table [dbo].[Utilizadores]    Script Date: 27/03/2020 18:00:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Utilizadores](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [nvarchar](100) NOT NULL,
	[e-mail] [nvarchar](50) NOT NULL,
	[data_nasc] [date] NULL,
	[login] [nvarchar](50) NOT NULL,
	[pass] [nvarchar](50) NOT NULL,
	[nivel] [int] NOT NULL,
	[departamento] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Utilizadores] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


