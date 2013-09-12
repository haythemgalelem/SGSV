IF NOT EXISTS(SELECT * FROM dbo_sgsv.TipoOperacion WHERE idTipoOperacion = 1)
BEGIN
	INSERT INTO dbo_sgsv.TipoOperacion
				(nombre)
	VALUES		('Reposición de Stock')
END