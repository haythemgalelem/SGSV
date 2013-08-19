GO

/****** Object:  StoredProcedure [dbo].[P_IU_Producto]    Script Date: 19/08/2013 01:07:25 p.m. ******/
DROP PROCEDURE [dbo].[P_IU_Producto]
GO

/****** Object:  StoredProcedure [dbo].[P_IU_Producto]    Script Date: 19/08/2013 01:07:25 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




-- =============================================
-- Author:		<Martín Tissier>
-- Create date: <19/08/2013>
-- Description:	<Alta y Modificación de Producto>
-- =============================================
CREATE Procedure [dbo].[P_IU_Producto] 
 @id_producto int,
 @id_marca int,
 @id_tipo_producto int,
 @nombre varchar(100),
 @observaciones varchar(250)

 AS

--Si id_producto es 0 inserto un nuevo Producto
IF @id_producto = 0
BEGIN
	INSERT INTO dbo.Producto
	(id_marca, id_tipo_producto, nombre, observaciones)
	VALUES(@id_marca, @id_tipo_producto, @nombre, @observaciones)
END

ELSE
--Caso contrario modifico el Producto deseado
BEGIN
	UPDATE	dbo.Producto
	SET		id_marca = @id_marca,
			id_tipo_producto = @id_tipo_producto,
			nombre = @nombre,
			observaciones = @observaciones
	WHERE	id_producto = @id_producto
END



GO


