GO

/****** Object:  Table [dbo].[Precio]    Script Date: 24/08/2013 05:59:38 p.m. ******/
IF  EXISTS (SELECT * 
			FROM sys.objects 
			WHERE object_id = OBJECT_ID(N'dbo_sgsv.Precio') 
				AND type in (N'U')) 
DROP TABLE [dbo_sgsv].[Precio]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo_sgsv].[Precio](
	[idProducto] [int] NOT NULL,
	[idSucursal] [int] NOT NULL,
	[fechaDesde] [date] NOT NULL,
	[fechaHasta] [date] NULL,
	[monto] [numeric](10,2) NOT NULL,
	[inhabilitado] [char] default '0' check (inhabilitado = '0' OR inhabilitado = '1')
) ON [PRIMARY]

GO

ALTER TABLE [dbo_sgsv].[Precio]  WITH CHECK ADD  CONSTRAINT [FK_Precio_Producto] FOREIGN KEY([idProducto])
REFERENCES [dbo_sgsv].[Producto] ([idProducto])
GO

ALTER TABLE [dbo_sgsv].[Precio] CHECK CONSTRAINT [FK_Precio_Producto]
GO

ALTER TABLE [dbo_sgsv].[Precio]  WITH CHECK ADD  CONSTRAINT [FK_Precio_Sucursal] FOREIGN KEY([idSucursal])
REFERENCES [dbo_sgsv].[Sucursal] ([idSucursal])
GO

ALTER TABLE [dbo_sgsv].[Precio] CHECK CONSTRAINT [FK_Precio_Sucursal]
GO


