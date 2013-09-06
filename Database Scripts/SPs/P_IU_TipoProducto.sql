GO

/****** Object:  StoredProcedure [dbo_sgsv].[P_IU_TipoProducto]    Script Date: 05/09/2013 11:07:46 p.m. ******/
DROP PROCEDURE [dbo_sgsv].[P_IU_TipoProducto]
GO

/****** Object:  StoredProcedure [dbo_sgsv].[P_IU_TipoProducto]    Script Date: 05/09/2013 11:07:46 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




-- =============================================
-- Author:		<Martín Tissier>
-- Create date: <19/08/2013>
-- Description:	<Alta y Modificación de TipoProducto>
-- =============================================
CREATE Procedure [dbo_sgsv].[P_IU_TipoProducto]    
 @idTipoProducto int,
 @nombre varchar(100)

 AS

--Si idTipoProducto es 0 y no existe un tipo producto con el mismo nombre inserto un
--nuevo Tipo Producto
IF @idTipoProducto = 0
	AND NOT EXISTS(	SELECT	nombre
					FROM	dbo_sgsv.TipoProducto
					WHERE	nombre = @nombre)
BEGIN
	INSERT INTO dbo_sgsv.TipoProducto
	(nombre)
	VALUES(@nombre)
END

ELSE
--Caso contrario, si no existe un Tipo Producto con el mismo nombre, modifico
--el Tipo Producto deseado
BEGIN
	IF NOT EXISTS(	SELECT	nombre
					FROM	dbo_sgsv.TipoProducto
					WHERE	nombre = @nombre)
	BEGIN
		UPDATE	dbo_sgsv.TipoProducto
		SET		nombre = @nombre
		WHERE	idTipoProducto = @idTipoProducto
	END
END



GO


