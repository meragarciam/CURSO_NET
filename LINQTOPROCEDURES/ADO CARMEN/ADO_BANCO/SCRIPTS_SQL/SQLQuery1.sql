USE [ADO]
GO

/****** Object:  Table [dbo].[CLIENTE]    Script Date: 09/03/2021 9:00:57 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CLIENTE](
	[IDCLIENTE] [varchar](5) NOT NULL,
	[APELLIDOS] [varchar](30) NULL,
	[NOMBRES] [varchar](30) NULL,
 CONSTRAINT [PK_CLIENTE] PRIMARY KEY CLUSTERED 
(
	[IDCLIENTE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

