GO

/****** Object:  StoredProcedure [dbo_sgsv].[P_S_Sucursal]    Script Date: 11/09/2013 12:12:32 a.m. ******/
DROP PROCEDURE [dbo_sgsv].[P_S_Sucursal]
GO

/****** Object:  StoredProcedure [dbo_sgsv].[P_S_Sucursal]    Script Date: 11/09/2013 12:12:32 a.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO







-- =============================================
-- Author:		<Martín Tissier>
-- Create date: <10/09/2013>
-- Description:	<Lectura de Sucursals>
-- =============================================
CREATE Procedure [dbo_sgsv].[P_S_Sucursal]
 @idSucursal int = null,
 @idLocalidad int = null,
 @nombre varchar(100) = null,
 @direccion varchar(100) = null,
 @telefono varchar(30) = null,
 @email varchar(50) = null,
 @codigoPostal varchar(15) = null,
 @habilitado varchar(30) = null
 AS

--Selecciono todos los productos que coincidan con los filtros ordenados por direccion
SELECT		idSucursal,
			idLocalidad,
			nombre,
			direccion,
			telefono,
			email,
			codigoPostal
FROM		dbo_sgsv.Sucursal
WHERE		idSucursal = ISNULL(@idSucursal, idSucursal)
	AND		idLocalidad = ISNULL(@idLocalidad, idLocalidad)
	AND		nombre LIKE '%' + ISNULL(@nombre, '') + '%'
	AND		direccion LIKE '%' + ISNULL(@direccion, '') + '%'
	AND		telefono LIKE '%' + ISNULL(@telefono, '') + '%'
	AND		email LIKE '%' + ISNULL(@email, '') + '%'
	AND		codigoPostal LIKE '%' + ISNULL(@codigoPostal, '') + '%'
	AND		habilitado >= ISNULL(@habilitado, habilitado)
ORDER BY	direccion






GO


