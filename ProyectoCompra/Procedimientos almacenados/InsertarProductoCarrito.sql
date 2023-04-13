USE Compras
IF OBJECT_ID ('InsertarProductoCarrito','P') IS NOT NULL
	DROP PROCEDURE InsertarProductoCarrito
	PRINT 'Procedimiento almacenado borrado.'
GO
CREATE PROCEDURE InsertarProductoCarrito
	@Id_Usuario INT,
	@Id_Producto INT,
	@Cantidad INT
AS
BEGIN
	IF EXISTS(SELECT 1 FROM carrito WHERE id_usuario = @Id_Usuario)
		BEGIN
			UPDATE carrito SET cantidad += @Cantidad WHERE id_usuario = @Id_Usuario
		END
	ELSE
		INSERT INTO carrito (id_usuario,id_producto,cantidad) VALUES (@Id_usuario,@Id_producto,@Cantidad)
END