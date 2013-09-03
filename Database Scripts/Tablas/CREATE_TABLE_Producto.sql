GO

/****** Object:  Table [dbo].[Producto]    Script Date: 24/08/2013 05:59:55 p.m. ******/
IF  EXISTS (SELECT * 
			FROM sys.objects 
			WHERE object_id = OBJECT_ID(N'dbo_sgsv.Producto') 
				AND type in (N'U')) 
DROP TABLE [dbo_sgsv].[Producto]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo_sgsv].[Producto](
	[idProducto] [int] IDENTITY(1,1) NOT NULL,
	[idMarca] [int] NOT NULL,
	[idTipoProducto] [int] NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[observaciones] [varchar](250) NOT NULL,
	[habilitado] [char] default '1' check (habilitado = '0' OR habilitado = '1')
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[idProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


