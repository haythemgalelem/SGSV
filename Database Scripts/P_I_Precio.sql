USE [SGSV_DEV]
GO
/****** Object:  StoredProcedure [dbo_sgsv].[P_I_Precio]    Script Date: 08/24/2013 19:29:20 ******/
DROP PROCEDURE [dbo_sgsv].[P_I_Precio]

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Pablo Boalio>
-- Create date: <24/08/2013>
-- Description:	<Alta de Precios>
-- =============================================
CREATE Procedure [dbo_sgsv].[P_I_Precio]    
 @idProducto int,
 @idSucursal int,
 @fechaDesde date,
 @monto numeric(10,2)
 
 AS

IF @idProducto != 0
	AND @idSucursal != 0
BEGIN

-- Para hacer el alta de precio, primero le voy a dar de baja al precio anterior.
-- Para eso, ejecutamos primero el SP de baja de precios.
	
EXEC [dbo_sgsv].[P_B_Precio] @idProducto, @idSucursal, @FechaDesde

-- Una vez hecha la baja (si corresponde que se haga), se procede a dar el alta
-- al nuevo precio

	INSERT INTO dbo_sgsv.Precio
	(idProducto, idSucursal, fechaDesde, monto)
	VALUES(@idProducto, @idSucursal, @fechaDesde, @monto)
END
