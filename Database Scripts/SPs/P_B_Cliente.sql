GO
/****** Object:  StoredProcedure [dbo_sgsv].[P_B_Cliente]    Script Date: 08/24/2013 19:29:20 ******/
DROP PROCEDURE [dbo_sgsv].[P_B_Cliente]

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Pablo Boalio>
-- Create date: <24/08/2013>
-- Description:	<Baja de Clientes>
-- =============================================
CREATE Procedure [dbo_sgsv].[P_B_Cliente]    
 @idCliente int
 
 AS
	    UPDATE  [dbo_sgsv].Cliente
		SET		habilitado = '0'
		WHERE	idCliente = @idCliente

