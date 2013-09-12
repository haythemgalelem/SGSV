GO
/****** Object:  StoredProcedure [dbo_sgsv].[P_IU_Localidad]    Script Date: 08/24/2013 19:29:20 ******/
DROP PROCEDURE [dbo_sgsv].[P_IU_Sucursal]

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Pablo Boalio>
-- Create date: <24/08/2013>
-- Description:	<Alta y Modificación de Sucursal>
-- =============================================
CREATE Procedure [dbo_sgsv].[P_IU_Sucursal]    
 @idSucursal int,
 @nombre varchar(100),
 @direccion varchar(100),
 @idLocalidad int,
 @telefono nvarchar(30),
 @email varchar(50),
 @codigoPostal varchar(15)

 AS

-- Si idSucursal es 0 y no existe una sucursal con el mismo nombre,
-- lo tomamos como una sucursal nueva y le damos de alta.

IF @idSucursal = 0
	AND NOT EXISTS(	SELECT	nombre
					FROM	dbo_sgsv.Sucursal
					WHERE	nombre = @nombre)
BEGIN
	INSERT INTO dbo_sgsv.Sucursal
	(nombre, direccion, idLocalidad, telefono, email, codigoPostal)
	VALUES(@nombre, @direccion, @idLocalidad, @telefono, @email, @codigoPostal)
END

ELSE
-- Caso contrario, si manda un idSucursal distinta de 0, entonces
-- sabemos que se trata de una modificación a los datos de la misma
BEGIN
	IF @idSucursal <> 0 
	BEGIN
		UPDATE  dbo_sgsv.Sucursal
		SET		nombre = @nombre,
				direccion = @direccion,
				idLocalidad = @idLocalidad,
		        telefono = @telefono,
		        email    = @email,
		        codigoPostal = @codigoPostal
		        
		WHERE	idSucursal = @idSucursal
	END
END
