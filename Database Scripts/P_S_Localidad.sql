GO

/****** Object:  StoredProcedure [dbo].[P_S_Localidad]    Script Date: 24/08/2013 02:32:18 p.m. ******/
DROP PROCEDURE [dbo].[P_S_Localidad]
GO

/****** Object:  StoredProcedure [dbo].[P_S_Localidad]    Script Date: 24/08/2013 02:32:18 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



-- =============================================
-- Author:		<Martín Tissier>
-- Create date: <23/08/2013>
-- Description:	<Lectura de Localidades>
-- =============================================
CREATE Procedure [dbo].[P_S_Localidad]

 AS

--Selecciono todas las localidades ordenadas por nombre
SELECT		idLocalidad,
			nombre
FROM		dbo.Localidad
ORDER BY	nombre


GO


