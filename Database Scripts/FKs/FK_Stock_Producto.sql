GO

ALTER TABLE [dbo_sgsv].[Stock] DROP CONSTRAINT [FK_Stock_Producto]
GO

ALTER TABLE [dbo_sgsv].[Stock]  WITH CHECK ADD  CONSTRAINT [FK_Stock_Producto] FOREIGN KEY([idProducto])
REFERENCES [dbo_sgsv].[Producto] ([idProducto])
GO

ALTER TABLE [dbo_sgsv].[Stock] CHECK CONSTRAINT [FK_Stock_Producto]
GO


