USE EasyShop
IF OBJECT_ID ('ConsultarDireccion','P') IS NOT NULL
	DROP PROCEDURE ConsultarDireccion
	PRINT 'Procedimiento almacenado borrado.'
GO
CREATE PROCEDURE ConsultarDireccion
@Id_Usuario INT
AS
BEGIN
	SELECT d.* FROM Direccion d
	INNER JOIN Usuario u ON (u.Id_Cliente = d.Id_Cliente)
	WHERE u.Id_Usuario = @Id_Usuario
END
