USE Compras
IF OBJECT_ID ('ConsultarProductos','P') IS NOT NULL
	DROP PROCEDURE ConsultarProductos
	PRINT 'Procedimiento almacenado borrado.'
GO
CREATE PROCEDURE ConsultarProductos
@Id_SubCategoria INT
AS
BEGIN
	SELECT p.* FROM producto p
	INNER JOIN subcategoria s ON (s.id_subcategoria = p.id_subcategoria)
	WHERE s.id_subcategoria = @Id_SubCategoria
END