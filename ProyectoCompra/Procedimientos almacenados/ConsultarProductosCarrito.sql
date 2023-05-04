USE EasyShop
IF OBJECT_ID ('ConsultarProductoCarrito','P') IS NOT NULL
	DROP PROCEDURE ConsultarProductoCarrito
	PRINT 'Procedimiento almacenado borrado.'
GO
CREATE PROCEDURE ConsultarProductoCarrito
	@Id_Usuario INT
AS
BEGIN
	SELECT p.id_producto,p.nombre,p.descripcion,p.precio,p.fabricante,c.cantidad,c.imagen FROM carrito c
	INNER JOIN producto p ON (c.id_producto = p.id_producto)
	WHERE c.id_usuario = @Id_Usuario
END