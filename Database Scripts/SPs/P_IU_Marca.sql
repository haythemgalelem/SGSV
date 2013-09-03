GO

/****** Object:  StoredProcedure [dbo].[P_IU_Marca]    Script Date: 19/08/2013 01:00:56 p.m. ******/
DROP PROCEDURE [dbo_sgsv].[P_IU_Marca]
GO

/****** Object:  StoredProcedure [dbo].[P_IU_Marca]    Script Date: 19/08/2013 01:00:56 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



-- =============================================
-- Author:		<Martín Tissier>
-- Create date: <19/08/2013>
-- Description:	<Alta y Modificación de Marca>
-- =============================================
CREATE Procedure [dbo_sgsv].[P_IU_Marca]    
 @idMarca int,
 @nombre varchar(100)

 AS

--Si idMarca es 0 y no existe una marca con el mismo nombre inserto una
--nueva Marca
IF @idMarca = 0
	AND NOT EXISTS(	SELECT	nombre
					FROM	dbo_sgsv.Marca
					WHERE	nombre = @nombre)
BEGIN
	INSERT INTO dbo_sgsv.Marca
	(nombre)
	VALUES(@nombre)
END

ELSE
--Caso contrario, si no existe una Marca con el mismo nombre, modifico
--la Marca deseada
BEGIN
	IF NOT EXISTS(	SELECT	nombre
					FROM	dbo_sgsv.Marca
					WHERE	nombre = @nombre)
	BEGIN
		UPDATE	dbo_sgsv.Marca
		SET		nombre = @nombre
		WHERE	idMarca = @idMarca
	END
END


GO


