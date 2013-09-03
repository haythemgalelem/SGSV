GO
/****** Object:  StoredProcedure [dbo_sgsv].[P_B_Sucursal]    Script Date: 08/24/2013 19:29:20 ******/
DROP PROCEDURE [dbo_sgsv].[P_B_Sucursal]

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Pablo Boalio>
-- Create date: <24/08/2013>
-- Description:	<Baja de sucursales>
-- =============================================
CREATE Procedure [dbo_sgsv].[P_B_Sucursal]    
 @idSucursal int
 
 AS
	    UPDATE  dbo_sgsv.Sucursal
		SET		habilitado = '0'
		WHERE	idSucursal = @idSucursal

