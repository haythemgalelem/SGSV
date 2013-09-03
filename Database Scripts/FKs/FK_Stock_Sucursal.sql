GO

ALTER TABLE [dbo_sgsv].[Stock] DROP CONSTRAINT [FK_Stock_Sucursal]
GO

ALTER TABLE [dbo_sgsv].[Stock]  WITH CHECK ADD  CONSTRAINT [FK_Stock_Sucursal] FOREIGN KEY([idSucursal])
REFERENCES [dbo_sgsv].[Sucursal] ([idSucursal])
GO

ALTER TABLE [dbo_sgsv].[Stock] CHECK CONSTRAINT [FK_Stock_Sucursal]
GO


