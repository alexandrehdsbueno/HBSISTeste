USE [Livraria]
GO
/****** Object:  Table [dbo].[Livro]    Script Date: 17/05/2018 03:07:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Livro](
	[LivroId] [uniqueidentifier] NOT NULL,
	[Titulo] [varchar](150) NOT NULL,
	[Autor] [varchar](150) NOT NULL,
	[DataPublicacao] [datetime] NOT NULL,
	[DataCadastro] [datetime] NOT NULL,
	[Ativo] [bit] NOT NULL,
 CONSTRAINT [PK_Livro] PRIMARY KEY CLUSTERED 
(
	[LivroId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
