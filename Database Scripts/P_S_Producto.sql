GO

/****** Object:  StoredProcedure [dbo].[P_S_Producto]    Script Date: 24/08/2013 03:27:07 p.m. ******/
DROP PROCEDURE [dbo].[P_S_Producto]
GO

/****** Object:  StoredProcedure [dbo].[P_S_Producto]    Script Date: 24/08/2013 03:27:07 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




-- =============================================
-- Author:		<Martín Tissier>
-- Create date: <23/08/2013>
-- Description:	<Lectura de Productos>
-- =============================================
CREATE Procedure [dbo].[P_S_Producto]
 @idProducto int = null,
 @idMarca int = null,
 @idTipoProducto int = null,
 @nombre varchar(100) = null
 AS

--Selecciono todos los productos que coincidan con los filtros ordenados por nombre
SELECT		idProducto,
			idMarca,
			idTipoProducto,
			nombre,
			observaciones
FROM		dbo.Producto
WHERE		idProducto = ISNULL(@idProducto, idProducto)
	AND		idMarca = ISNULL(@idMarca, idMarca)
	AND		idTipoProducto = ISNULL(@idTipoProducto, idTipoProducto)
	AND		nombre LIKE '%' + ISNULL(@nombre, '') + '%'
ORDER BY	nombre



GO


