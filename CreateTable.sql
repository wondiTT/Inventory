USE [Inventory]
GO

/****** Object:  Table [dbo].[Products]    Script Date: 04.06.2022 14:41:17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Products](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](50) NULL,
	[Category] [nchar](30) NULL,
	[Color] [nchar](15) NULL,
	[UnitPrice] [decimal](18, 0) NULL,
	[AvailableQuantity] [int] NULL
) ON [PRIMARY]
GO
