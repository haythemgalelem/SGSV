GO

ALTER TABLE [dbo_sgsv].[Cliente] DROP CONSTRAINT [FK_Cliente_Localidad]
GO

ALTER TABLE [dbo_sgsv].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_Localidad] FOREIGN KEY([idLocalidad])
REFERENCES [dbo_sgsv].[Localidad] ([idLocalidad])
GO

ALTER TABLE [dbo_sgsv].[Cliente] CHECK CONSTRAINT [FK_Cliente_Localidad]
GO


