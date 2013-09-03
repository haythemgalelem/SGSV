GO

/****** Object:  StoredProcedure [dbo_sgsv].[P_IU_Localidad]    Script Date: 19/08/2013 01:00:23 p.m. ******/
DROP PROCEDURE [dbo_sgsv].[P_IU_Localidad]
GO

/****** Object:  StoredProcedure [dbo_sgsv].[P_IU_Localidad]    Script Date: 19/08/2013 01:00:23 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Martín Tissier>
-- Create date: <19/08/2013>
-- Description:	<Alta y Modificación de Localidad>
-- =============================================
CREATE Procedure [dbo_sgsv].[P_IU_Localidad]    
 @idLocalidad int,
 @nombre varchar(100)

 AS

--Si idLocalidad es 0 y no existe una localidad con el mismo nombre inserto una
--nueva Localidad
IF @idLocalidad = 0
	AND NOT EXISTS(	SELECT	nombre
					FROM	dbo_sgsv.Localidad
					WHERE	nombre = @nombre)
BEGIN
	INSERT INTO dbo_sgsv.Localidad
	(nombre)
	VALUES(@nombre)
END

ELSE
--Caso contrario, si no existe una Localidad con el mismo nombre, modifico
--la Localidad deseada
BEGIN
	IF NOT EXISTS(	SELECT	nombre
					FROM	dbo_sgsv.Localidad
					WHERE	nombre = @nombre)
	BEGIN
		UPDATE	dbo_sgsv.Localidad
		SET		nombre = @nombre
		WHERE	idLocalidad = @idLocalidad
	END
END

GO


