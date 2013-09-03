GO

ALTER TABLE [dbo_sgsv].[Empleado] DROP CONSTRAINT [FK_Empleado_Sucursal]
GO

ALTER TABLE [dbo_sgsv].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_Empleado_Sucursal] FOREIGN KEY([idSucursal])
REFERENCES [dbo_sgsv].[Sucursal] ([idSucursal])
GO

ALTER TABLE [dbo_sgsv].[Empleado] CHECK CONSTRAINT [FK_Empleado_Sucursal]
GO


