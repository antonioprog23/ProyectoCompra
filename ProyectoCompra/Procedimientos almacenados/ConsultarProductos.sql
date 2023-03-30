USE Compras
IF OBJECT_ID ('ConsultarProductos','P') IS NOT NULL
	DROP PROCEDURE ConsultarProductos
	PRINT 'Procedimiento almacenado borrado.'
GO
CREATE PROCEDURE ConsultarProductos
AS
BEGIN
	SELECT * FROM producto
END