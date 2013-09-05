GO
/****** Object:  StoredProcedure [dbo_sgsv].[P_S_Sucursal]    Script Date: 03/09/2013 07:45:33 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Pablo Boaglio>
-- Create date: <04/09/2013>
-- Description:	<Lectura de Sucursales>
-- =============================================
CREATE Procedure [dbo_sgsv].[P_S_Sucursal]
 @idSucursal int = NULL,
 @nombre varchar(100) = NULL,
 @idLocalidad int = NULL,
 @codigo_postal varchar(15) = NULL,
 @inhabilitado char(1) = NULL
 AS

--Selecciono todas las sucursales ordenadas por nombre

SELECT		Sucursal.idSucursal as idSucursal,
			Sucursal.idLocalidad as idLocalidad,
			Sucursal.nombre as nombreSucursal,
			Sucursal.direccion as direccion,
			Localidad.nombre as nombreLocalidad,
			Sucursal.telefono as telefono,
			Sucursal.codigo_postal as codigoPostal,
			Sucursal.email as email,
			Sucursal.inhabilitado as inhabilitado
FROM		dbo_sgsv.Sucursal Sucursal, dbo_sgsv.Localidad Localidad
WHERE		Sucursal.idSucursal = ISNULL(@idSucursal,Sucursal.idSucursal)
  AND    	Sucursal.idLocalidad = ISNULL(@idLocalidad, Sucursal.idLocalidad)
  AND		Sucursal.idLocalidad = Localidad.idLocalidad
  AND		Sucursal.nombre LIKE ISNULL(@nombre, Sucursal.nombre) + '%'
  AND		Sucursal.codigo_postal LIKE ISNULL(@codigo_postal,Sucursal.codigo_postal) + '%'
  AND		Sucursal.inhabilitado = ISNULL(@inhabilitado, inhabilitado)
ORDER BY	Sucursal.nombre


