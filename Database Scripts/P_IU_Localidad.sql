GO

/****** Object:  StoredProcedure [dbo].[P_IU_Localidad]    Script Date: 19/08/2013 01:00:23 p.m. ******/
DROP PROCEDURE [dbo].[P_IU_Localidad]
GO

/****** Object:  StoredProcedure [dbo].[P_IU_Localidad]    Script Date: 19/08/2013 01:00:23 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Mart�n Tissier>
-- Create date: <19/08/2013>
-- Description:	<Alta y Modificaci�n de Localidad>
-- =============================================
CREATE Procedure [dbo].[P_IU_Localidad]    
 @id_localidad int,
 @nombre varchar(100)

 AS

--Si id_localidad es 0 y no existe una localidad con el mismo nombre inserto una
--nueva Localidad
IF @id_localidad = 0
	AND NOT EXISTS(	SELECT	nombre
					FROM	dbo.Localidad
					WHERE	nombre = @nombre)
BEGIN
	INSERT INTO dbo.Localidad
	(nombre)
	VALUES(@nombre)
END

ELSE
--Caso contrario, si no existe una Localidad con el mismo nombre, modifico
--la Localidad deseada
BEGIN
	IF NOT EXISTS(	SELECT	nombre
					FROM	dbo.Localidad
					WHERE	nombre = @nombre)
	BEGIN
		UPDATE	dbo.Localidad
		SET		nombre = @nombre
		WHERE	id_localidad = @id_localidad
	END
END

GO

