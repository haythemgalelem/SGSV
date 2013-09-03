GO
/****** Object:  StoredProcedure [dbo_sgsv].[P_IU_Localidad]    Script Date: 08/24/2013 19:29:20 ******/
DROP PROCEDURE [dbo_sgsv].[P_I_TipoEmpleado]

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Pablo Boalio>
-- Create date: <24/08/2013>
-- Description:	<Alta de Tipo de Empleado>
-- =============================================
CREATE Procedure [dbo_sgsv].[P_I_TipoEmpleado]    
@nombre varchar(100)
 AS

-- Si idTipoEmpleado es 0 y no existe otro tipo de empleado con el mismo nombre,
-- lo tomamos como un tipo de empleado nuevo y le damos de alta.

IF NOT EXISTS(	SELECT	nombre
				FROM	dbo_sgsv.TipoEmpleado
				WHERE	nombre = @nombre)
BEGIN
	INSERT INTO dbo_sgsv.TipoEmpleado
			   (nombre)
	VALUES	   (@nombre)
END

