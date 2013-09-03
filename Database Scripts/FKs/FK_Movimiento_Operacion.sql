GO

ALTER TABLE [dbo_sgsv].[Movimiento] DROP CONSTRAINT [FK_Movimiento_Operacion]
GO

ALTER TABLE [dbo_sgsv].[Movimiento]  WITH CHECK ADD  CONSTRAINT [FK_Movimiento_Operacion] FOREIGN KEY([idOperacion])
REFERENCES [dbo_sgsv].[Operacion] ([idOperacion])
GO

ALTER TABLE [dbo_sgsv].[Movimiento] CHECK CONSTRAINT [FK_Movimiento_Operacion]
GO


