GO

ALTER TABLE [dbo_sgsv].[Empleado] DROP CONSTRAINT [FK_Empleado_TipoEmpleado]
GO

ALTER TABLE [dbo_sgsv].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_Empleado_TipoEmpleado] FOREIGN KEY([idTipoEmpleado])
REFERENCES [dbo_sgsv].[TipoEmpleado] ([idTipoEmpleado])
GO

ALTER TABLE [dbo_sgsv].[Empleado] CHECK CONSTRAINT [FK_Empleado_TipoEmpleado]
GO


