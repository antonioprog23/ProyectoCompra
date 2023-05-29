USE EasyShop
IF OBJECT_ID ('ConsultarProductoCarrito','P') IS NOT NULL
	DROP PROCEDURE ConsultarProductoCarrito
	PRINT 'Procedimiento almacenado borrado.'
GO
CREATE PROCEDURE ConsultarProductoCarrito
	@Id_Usuario INT
AS
BEGIN
	SET NOCOUNT ON
	SELECT p.id_producto,p.nombre,p.descripcion,p.precio,p.fabricante,c.cantidad,i.Codigo_Imagen FROM carrito c
	INNER JOIN producto p ON (c.id_producto = p.id_producto)
	INNER JOIN Imagen i ON (i.Id_Producto = c.Id_Producto)
	WHERE c.id_usuario = @Id_Usuario
END