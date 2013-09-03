GO

ALTER TABLE [dbo_sgsv].[Operacion] DROP CONSTRAINT [FK_Operacion_Empleado]
GO

ALTER TABLE [dbo_sgsv].[Operacion]  WITH CHECK ADD  CONSTRAINT [FK_Operacion_Empleado] FOREIGN KEY([idEmpleado])
REFERENCES [dbo_sgsv].[Empleado] ([idEmpleado])
GO

ALTER TABLE [dbo_sgsv].[Operacion] CHECK CONSTRAINT [FK_Operacion_Empleado]
GO


