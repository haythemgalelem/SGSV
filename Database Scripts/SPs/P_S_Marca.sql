GO

/****** Object:  StoredProcedure [dbo_sgsv].[P_S_Marca]    Script Date: 05/09/2013 10:49:30 p.m. ******/
DROP PROCEDURE [dbo_sgsv].[P_S_Marca]
GO

/****** Object:  StoredProcedure [dbo_sgsv].[P_S_Marca]    Script Date: 05/09/2013 10:49:30 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




-- =============================================
-- Author:		<Martín Tissier>
-- Create date: <05/09/2013>
-- Description:	<Lectura de Marcas>
-- =============================================
CREATE Procedure [dbo_sgsv].[P_S_Marca] 
 @idMarca int = NULL,
 @nombre varchar(100) = NULL
 AS

--Selecciono todas las marcas ordenadas por nombre
SELECT		idMarca,
			nombre
FROM		dbo_sgsv.Marca
WHERE		idMarca = ISNULL(@idMarca, idMarca)
	AND		nombre LIKE ISNULL(@nombre, nombre) + '%'
ORDER BY	nombre



GO


