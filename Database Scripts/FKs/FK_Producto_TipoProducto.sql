GO

ALTER TABLE [dbo_sgsv].[Producto] DROP CONSTRAINT [FK_Producto_TipoProducto]
GO

ALTER TABLE [dbo_sgsv].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_TipoProducto] FOREIGN KEY([idTipoProducto])
REFERENCES [dbo_sgsv].[TipoProducto] ([idTipoProducto])
GO

ALTER TABLE [dbo_sgsv].[Producto] CHECK CONSTRAINT [FK_Producto_TipoProducto]
GO


