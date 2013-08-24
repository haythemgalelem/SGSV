GO

/****** Object:  StoredProcedure [dbo].[P_IU_Tipo_Producto]    Script Date: 19/08/2013 01:00:44 p.m. ******/
DROP PROCEDURE [dbo].[P_IU_Tipo_Producto]
GO

/****** Object:  StoredProcedure [dbo].[P_IU_Tipo_Producto]    Script Date: 19/08/2013 01:00:44 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



-- =============================================
-- Author:		<Martín Tissier>
-- Create date: <19/08/2013>
-- Description:	<Alta y Modificación de Tipo_Producto>
-- =============================================
CREATE Procedure [dbo].[P_IU_Tipo_Producto]    
 @idTipoProducto int,
 @nombre varchar(100)

 AS

--Si idTipoProducto es 0 y no existe un tipo_producto con el mismo nombre inserto un
--nuevo Tipo_Producto
IF @idTipoProducto = 0
	AND NOT EXISTS(	SELECT	nombre
					FROM	dbo.Tipo_Producto
					WHERE	nombre = @nombre)
BEGIN
	INSERT INTO dbo.Tipo_Producto
	(nombre)
	VALUES(@nombre)
END

ELSE
--Caso contrario, si no existe un Tipo_Producto con el mismo nombre, modifico
--el Tipo_Producto deseado
BEGIN
	IF NOT EXISTS(	SELECT	nombre
					FROM	dbo.Tipo_Producto
					WHERE	nombre = @nombre)
	BEGIN
		UPDATE	dbo.Tipo_Producto
		SET		nombre = @nombre
		WHERE	idTipoProducto = @idTipoProducto
	END
END


GO


