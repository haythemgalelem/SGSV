GO
/****** Object:  StoredProcedure [dbo_sgsv].[P_B_Empleado]    Script Date: 08/24/2013 19:29:20 ******/
DROP PROCEDURE [dbo_sgsv].[P_B_Empleado]

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Pablo Boalio>
-- Create date: <24/08/2013>
-- Description:	<Baja de empleados>
-- =============================================
CREATE Procedure [dbo_sgsv].[P_B_Empleado]    
 @idEmpleado int
 
 AS
	    UPDATE  dbo_sgsv.Empleado
		SET		habilitado = '0'
		WHERE	idEmpleado = @idEmpleado

