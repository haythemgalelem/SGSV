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
	[inhabilitado] [char] default '0' check (inhabilitado = '0' OR inhabilitado = '1')
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[idProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo_sgsv].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Marca] FOREIGN KEY([idMarca])
REFERENCES [dbo_sgsv].[Marca] ([idMarca])
GO

ALTER TABLE [dbo_sgsv].[Producto] CHECK CONSTRAINT [FK_Producto_Marca]
GO

ALTER TABLE [dbo_sgsv].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Tipo_Producto] FOREIGN KEY([idTipoProducto])
REFERENCES [dbo_sgsv].[TipoProducto] ([idTipoProducto])
GO

ALTER TABLE [dbo_sgsv].[Producto] CHECK CONSTRAINT [FK_Producto_Tipo_Producto]
GO


