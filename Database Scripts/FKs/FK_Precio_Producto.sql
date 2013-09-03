GO

ALTER TABLE [dbo_sgsv].[Precio] DROP CONSTRAINT [FK_Precio_Producto]
GO

ALTER TABLE [dbo_sgsv].[Precio]  WITH CHECK ADD  CONSTRAINT [FK_Precio_Producto] FOREIGN KEY([idProducto])
REFERENCES [dbo_sgsv].[Producto] ([idProducto])
GO

ALTER TABLE [dbo_sgsv].[Precio] CHECK CONSTRAINT [FK_Precio_Producto]
GO


