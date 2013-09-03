GO
/****** Object:  StoredProcedure [dbo_sgsv].[P_IU_Localidad]    Script Date: 08/24/2013 19:29:20 ******/
DROP PROCEDURE [dbo_sgsv].[P_IU_Cliente]

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Pablo Boalio>
-- Create date: <24/08/2013>
-- Description:	<Alta y Modificación de Cliente>
-- =============================================
CREATE Procedure [dbo_sgsv].[P_IU_Cliente]    
 @idCliente int,
 @nombre varchar(100),
 @apellido varchar(100),
 @telefono nvarchar(30),
 @email varchar(50),
 @direccion varchar(100),
 @idLocalidad int

 AS

-- Si idCliente es 0 y no existe un cliente con el mismo nombre, apellido
-- y telefono, lo tomamos como un cliente nuevo y le damos de alta.

IF @idCliente = 0
	AND NOT EXISTS(	SELECT	nombre
					FROM	dbo_sgsv.Cliente
					WHERE	nombre = @nombre
					  AND   apellido = @apellido
					  AND   telefono = @telefono)
BEGIN
	INSERT INTO dbo_sgsv.Cliente
			   (nombre,
				apellido,
				telefono,
				email,
				direccion,
				idLocalidad)
	VALUES	   (@nombre,
				@apellido,
				@telefono,
				@email,
				@direccion,
				@idLocalidad)
END

ELSE
-- Caso contrario, si manda un idCliente distinto de 0, entonces
-- sabemos que se trata de una modificación a los datos del mismo
BEGIN
	IF @idCliente <> 0 
	BEGIN
		UPDATE  dbo_sgsv.Cliente
		SET		nombre = @nombre,
		        apellido = @apellido,
		        telefono = @telefono,
		        email    = @email,
		        direccion = @direccion,
		        idLocalidad = @idLocalidad
		WHERE	idCliente = @idCliente
	END
END
