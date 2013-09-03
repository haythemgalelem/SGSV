GO

ALTER TABLE [dbo_sgsv].[Sucursal] DROP CONSTRAINT [FK_Sucursal_Localidad]
GO

ALTER TABLE [dbo_sgsv].[Sucursal]  WITH CHECK ADD  CONSTRAINT [FK_Sucursal_Localidad] FOREIGN KEY([idLocalidad])
REFERENCES [dbo_sgsv].[Localidad] ([idLocalidad])
GO

ALTER TABLE [dbo_sgsv].[Sucursal] CHECK CONSTRAINT [FK_Sucursal_Localidad]
GO


