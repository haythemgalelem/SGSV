GO

ALTER TABLE [dbo_sgsv].[Operacion] DROP CONSTRAINT [FK_Operacion_Sucursal]
GO

ALTER TABLE [dbo_sgsv].[Operacion]  WITH CHECK ADD  CONSTRAINT [FK_Operacion_Sucursal] FOREIGN KEY([idSucursal])
REFERENCES [dbo_sgsv].[Sucursal] ([idSucursal])
GO

ALTER TABLE [dbo_sgsv].[Operacion] CHECK CONSTRAINT [FK_Operacion_Sucursal]
GO


