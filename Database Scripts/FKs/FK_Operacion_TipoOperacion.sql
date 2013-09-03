GO

ALTER TABLE [dbo_sgsv].[Operacion] DROP CONSTRAINT [FK_Operacion_TipoOperacion]
GO

ALTER TABLE [dbo_sgsv].[Operacion]  WITH CHECK ADD  CONSTRAINT [FK_Operacion_TipoOperacion] FOREIGN KEY([idTipoOperacion])
REFERENCES [dbo_sgsv].[TipoOperacion] ([idTipoOperacion])
GO

ALTER TABLE [dbo_sgsv].[Operacion] CHECK CONSTRAINT [FK_Operacion_TipoOperacion]
GO


