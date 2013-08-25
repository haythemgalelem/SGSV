USE [SGSV_DEV]
GO
/****** Object:  StoredProcedure [dbo_sgsv].[P_B_Producto]    Script Date: 08/24/2013 19:29:20 ******/
DROP PROCEDURE [dbo_sgsv].[P_B_Producto]

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Pablo Boalio>
-- Create date: <24/08/2013>
-- Description:	<Baja de productos>
-- =============================================
CREATE Procedure [dbo_sgsv].[P_B_Producto]    
 @idProducto int
 
 AS
	    UPDATE  [dbo_sgsv].Producto
		SET		inhabilitado = '1'
		WHERE	idProducto = @idProducto

