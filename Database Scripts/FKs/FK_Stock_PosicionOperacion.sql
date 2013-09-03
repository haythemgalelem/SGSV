GO

ALTER TABLE [dbo_sgsv].[Stock] DROP CONSTRAINT [FK_Stock_PosicionOperacion]
GO

ALTER TABLE [dbo_sgsv].[Stock]  WITH CHECK ADD  CONSTRAINT [FK_Stock_PosicionOperacion] FOREIGN KEY([idPosicionOperacion])
REFERENCES [dbo_sgsv].[PosicionOperacion] ([idPosicionOperacion])
GO

ALTER TABLE [dbo_sgsv].[Stock] CHECK CONSTRAINT [FK_Stock_PosicionOperacion]
GO


