USE EasyShop
IF OBJECT_ID ('InsertarProductoCarrito','P') IS NOT NULL
	DROP PROCEDURE InsertarProductoCarrito
	PRINT 'Procedimiento almacenado InsertarProductoCarrito borrado.'
GO
	PRINT 'Procedimiento almacenado InsertarProductoCarrito creado.'
GO
CREATE PROCEDURE InsertarProductoCarrito
	@Id_Usuario INT,
	@Id_Producto INT,
	@Cantidad INT,
	@Aumentar BIT
AS
BEGIN
	IF EXISTS(SELECT 1 FROM carrito WHERE id_usuario = @Id_Usuario AND id_producto = @Id_Producto)
		BEGIN
			IF(@Aumentar = 1)
				BEGIN 
					UPDATE carrito SET cantidad += @Cantidad WHERE id_usuario = @Id_Usuario AND id_producto = @Id_Producto
				END
			ELSE
				UPDATE carrito SET cantidad = @Cantidad WHERE id_usuario = @Id_Usuario AND id_producto = @Id_Producto
		END
	ELSE
		INSERT INTO carrito (id_usuario,id_producto,cantidad) VALUES (@Id_usuario,@Id_producto,@Cantidad)
END