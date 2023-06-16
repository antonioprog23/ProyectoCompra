USE EasyShop
IF OBJECT_ID ('EliminarDireccion','P') IS NOT NULL
	DROP PROCEDURE EliminarDireccion
	PRINT 'Procedimiento almacenado EliminarDireccion borrado.'
GO
	PRINT 'Procedimiento almacenado EliminarDireccion creado.'
GO
CREATE PROCEDURE EliminarDireccion
@Id_Direccion INT
AS
BEGIN
		DELETE FROM Direccion
		WHERE Id_Direccion = @Id_Direccion
END