GO
/****** Object:  StoredProcedure [dbo_sgsv].[P_S_Producto]    Script Date: 08/24/2013 19:26:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




-- =============================================
-- Author:		<Martín Tissier>
-- Create date: <23/08/2013>
-- Description:	<Lectura de Productos>
-- =============================================
CREATE Procedure [dbo_sgsv].[P_S_Producto]
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
FROM		dbo_sgsv.Producto
WHERE		idProducto = ISNULL(@idProducto, idProducto)
	AND		idMarca = ISNULL(@idMarca, idMarca)
	AND		idTipoProducto = ISNULL(@idTipoProducto, idTipoProducto)
	AND		nombre LIKE '%' + ISNULL(@nombre, '') + '%'
ORDER BY	nombre



