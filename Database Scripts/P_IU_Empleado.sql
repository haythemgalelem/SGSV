USE [SGSV_DEV]
GO
/****** Object:  StoredProcedure [dbo_sgsv].[P_IU_Empleado] */
DROP PROCEDURE [dbo_sgsv].[P_IU_Empleado]

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Pablo Boalio>
-- Create date: <24/08/2013>
-- Description:	<Alta y Modificación de Empleado>
-- =============================================
CREATE Procedure [dbo_sgsv].[P_IU_Empleado]    
 @idEmpleado int,
 @idTipoEmpleado int, 
 @idSucursal int,
 @nombre varchar(100),
 @apellido varchar(100),
 @telefono nvarchar(30),
 @email varchar(50),
 @dni numeric(8,0)

 AS

-- Si idEmpleado es 0 y no existe otro empleado con el mismo dni
-- lo tomamos como un empleado nuevo y le damos de alta.

IF @idEmpleado = 0 
   AND
   NOT EXISTS (SELECT dni
               FROM dbo_sgsv.Empleado
               WHERE dni = @dni)
BEGIN
	INSERT INTO dbo_sgsv.Empleado
	(idTipoEmpleado, idSucursal, nombre, 
	 apellido, telefono, email, dni)
	VALUES(@idTipoEmpleado, @idSucursal, @nombre, @apellido,
	       @telefono, @email, @dni)
END

ELSE
-- Caso contrario, si manda un idEmpleado distinta de 0, entonces
-- sabemos que se trata de una modificación a los datos de la misma.
-- NO PUEDE MODIFICAR LOS CAMPOS NOMBRE, APELLIDO Y DNI PARA ESE EMPLEADO
BEGIN
	IF @idEmpleado != 0
					 
	BEGIN
		UPDATE  [dbo_sgsv].Empleado
		SET		idTipoEmpleado = @idTipoEmpleado,
				idSucursal = @idSucursal,
		        telefono = @telefono,
		        email    = @email
		WHERE	idEmpleado = @idEmpleado
	END
END
