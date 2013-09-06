GO

/****** Object:  StoredProcedure [dbo_sgsv].[P_S_TipoProducto]    Script Date: 05/09/2013 10:49:30 p.m. ******/
DROP PROCEDURE [dbo_sgsv].[P_S_TipoProducto]
GO

/****** Object:  StoredProcedure [dbo_sgsv].[P_S_TipoProducto]    Script Date: 05/09/2013 10:49:30 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




-- =============================================
-- Author:		<Martín Tissier>
-- Create date: <05/09/2013>
-- Description:	<Lectura de Tipo Productos>
-- =============================================
CREATE Procedure [dbo_sgsv].[P_S_TipoProducto] 
 @idTipoProducto int = NULL,
 @nombre varchar(100) = NULL
 AS

--Selecciono todas los tipos de producto ordenados por nombre
SELECT		idTipoProducto,
			nombre
FROM		dbo_sgsv.TipoProducto
WHERE		idTipoProducto = ISNULL(@idTipoProducto, idTipoProducto)
	AND		nombre LIKE ISNULL(@nombre, nombre) + '%'
ORDER BY	nombre



GO


