USE [SGSV_DEV]
GO
/****** Object:  StoredProcedure [dbo_sgsv].[P_B_Precio]    Script Date: 08/24/2013 19:29:20 ******/
DROP PROCEDURE [dbo_sgsv].[P_B_Precio]

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Pablo Boalio>
-- Create date: <24/08/2013>
-- Description:	<Baja de Precios>
-- =============================================
CREATE Procedure [dbo_sgsv].[P_B_Precio]    
 @idProducto int,
 @idSucursal int,
 @fechaHasta date
 
 AS

-- Para hacer la baja de precio, debo primero verificar que haya
-- un precio para un producto y sucursal que este vigente.
-- SIEMPRE va a haber un UNICO precio habilitado
-- para el par (Producto, Sucursal)

IF EXISTS(	SELECT	*
			FROM  dbo_sgsv.Precio
			WHERE idProducto = @idProducto	
			  AND idSucursal = @idSucursal
			  AND fechaHasta IS NULL)
BEGIN
	    UPDATE  [dbo_sgsv].Precio
		SET		fechaHasta = @fechaHasta
		WHERE	idProducto = @idProducto
		  AND   idSucursal = @idSucursal
		  AND  fechaHasta IS NULL
END

