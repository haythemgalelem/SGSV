GO

/****** Object:  StoredProcedure [dbo].[P_IU_Producto]    Script Date: 19/08/2013 01:07:25 p.m. ******/
DROP PROCEDURE [dbo_sgsv].[P_IU_Producto]
GO

/****** Object:  StoredProcedure [dbo].[P_IU_Producto]    Script Date: 19/08/2013 01:07:25 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




-- =============================================
-- Author:		<Martín Tissier>
-- Create date: <19/08/2013>
-- Description:	<Alta y Modificación de Producto>
-- =============================================
CREATE Procedure [dbo_sgsv].[P_IU_Producto] 
 @idProducto int,
 @idMarca int,
 @idTipoProducto int,
 @nombre varchar(100),
 @observaciones varchar(250)

 AS

--Si idProducto es 0 inserto un nuevo Producto
IF @idProducto = 0
BEGIN
	INSERT INTO dbo_sgsv.Producto
	(idMarca, idTipoProducto, nombre, observaciones)
	VALUES(@idMarca, @idTipoProducto, @nombre, @observaciones)
END

ELSE
--Caso contrario modifico el Producto deseado
BEGIN
	UPDATE	dbo_sgsv.Producto
	SET		idMarca = @idMarca,
			idTipoProducto = @idTipoProducto,
			nombre = @nombre,
			observaciones = @observaciones
	WHERE	idProducto = @idProducto
END



GO


