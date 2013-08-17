GO

/****** Object:  StoredProcedure [dbo].[P_I_Localidad]    Script Date: 17/08/2013 06:09:58 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Martín Tissier>
-- Create date: <17/08/2013>
-- Description:	<Alta de Localidad>
-- =============================================
CREATE Procedure [dbo].[P_I_Localidad]    
 @nombre varchar(100)

 AS

 IF NOT EXISTS(SELECT id_localidad FROM dbo.Localidad WHERE nombre = @nombre)
 INSERT INTO dbo.Localidad
 (nombre)
 VALUES(@nombre)
GO


