USE EasyShop
IF OBJECT_ID ('EliminarProductoCarrito','P') IS NOT NULL
	DROP PROCEDURE EliminarProductoCarrito
	PRINT 'Procedimiento almacenado EliminarProductoCarrito borrado.'
GO
	PRINT 'Procedimiento almacenado EliminarProductoCarrito creado.'
GO
CREATE PROCEDURE EliminarProductoCarrito
	@Id_Usuario INT,
	@Id_Producto INT,
	@Vaciar_Todo BIT
AS
BEGIN
	IF(@Vaciar_Todo = 1)
		BEGIN 
			DELETE FROM carrito WHERE id_usuario = @Id_Usuario
		END
	ELSE
		BEGIN 
			DELETE FROM carrito WHERE id_usuario = @Id_Usuario AND id_producto = @Id_Producto
		END
END