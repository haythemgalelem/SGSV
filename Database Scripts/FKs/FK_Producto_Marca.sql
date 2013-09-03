GO

ALTER TABLE [dbo_sgsv].[Producto] DROP CONSTRAINT [FK_Producto_Marca]
GO

ALTER TABLE [dbo_sgsv].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Marca] FOREIGN KEY([idMarca])
REFERENCES [dbo_sgsv].[Marca] ([idMarca])
GO

ALTER TABLE [dbo_sgsv].[Producto] CHECK CONSTRAINT [FK_Producto_Marca]
GO


