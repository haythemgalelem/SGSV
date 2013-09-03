GO

ALTER TABLE [dbo_sgsv].[PosicionOperacion] DROP CONSTRAINT [FK_PosicionOperacion_Operacion]
GO

ALTER TABLE [dbo_sgsv].[PosicionOperacion]  WITH CHECK ADD  CONSTRAINT [FK_PosicionOperacion_Operacion] FOREIGN KEY([idOperacion])
REFERENCES [dbo_sgsv].[Operacion] ([idOperacion])
GO

ALTER TABLE [dbo_sgsv].[PosicionOperacion] CHECK CONSTRAINT [FK_PosicionOperacion_Operacion]
GO


