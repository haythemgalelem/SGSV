GO

ALTER TABLE [dbo_sgsv].[Precio] DROP CONSTRAINT [FK_Precio_Sucursal]
GO

ALTER TABLE [dbo_sgsv].[Precio]  WITH CHECK ADD  CONSTRAINT [FK_Precio_Sucursal] FOREIGN KEY([idSucursal])
REFERENCES [dbo_sgsv].[Sucursal] ([idSucursal])
GO

ALTER TABLE [dbo_sgsv].[Precio] CHECK CONSTRAINT [FK_Precio_Sucursal]
GO


