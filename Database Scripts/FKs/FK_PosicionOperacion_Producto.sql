GO

ALTER TABLE [dbo_sgsv].[PosicionOperacion] DROP CONSTRAINT [FK_PosicionOperacion_Producto]
GO

ALTER TABLE [dbo_sgsv].[PosicionOperacion]  WITH CHECK ADD  CONSTRAINT [FK_PosicionOperacion_Producto] FOREIGN KEY([idProducto])
REFERENCES [dbo_sgsv].[Producto] ([idProducto])
GO

ALTER TABLE [dbo_sgsv].[PosicionOperacion] CHECK CONSTRAINT [FK_PosicionOperacion_Producto]
GO


