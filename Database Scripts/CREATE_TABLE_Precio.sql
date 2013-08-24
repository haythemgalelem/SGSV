GO

/****** Object:  Table [dbo].[Precio]    Script Date: 24/08/2013 05:59:38 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Precio](
	[idProducto] [int] NOT NULL,
	[idSucursal] [int] NOT NULL,
	[fechaDesde] [date] NOT NULL,
	[fechaHasta] [date] NULL,
	[monto] [int] NOT NULL
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Precio]  WITH CHECK ADD  CONSTRAINT [FK_Precio_Producto] FOREIGN KEY([idProducto])
REFERENCES [dbo].[Producto] ([idProducto])
GO

ALTER TABLE [dbo].[Precio] CHECK CONSTRAINT [FK_Precio_Producto]
GO

ALTER TABLE [dbo].[Precio]  WITH CHECK ADD  CONSTRAINT [FK_Precio_Sucursal] FOREIGN KEY([idSucursal])
REFERENCES [dbo].[Sucursal] ([idSucursal])
GO

ALTER TABLE [dbo].[Precio] CHECK CONSTRAINT [FK_Precio_Sucursal]
GO


