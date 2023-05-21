USE EasyShop
IF OBJECT_ID ('ActualizarLineaPedido','P') IS NOT NULL
	DROP PROCEDURE ActualizarLineaPedido
	PRINT 'Procedimiento almacenado borrado.'
GO
	PRINT 'Procedimiento almacenado creado.'
GO
CREATE PROCEDURE ActualizarLineaPedido
	@Id_Usuario INT,
	@Id_Producto INT,
	@Cantidad INT
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Id_Pedido INT
	DECLARE @PrecioUnidad DECIMAL (5,2)
	DECLARE @Subtotal DECIMAL (5,2)

	SET @Id_Pedido = (SELECT MAX(Id_Pedido) FROM Pedido WHERE Id_Usuario = @Id_Usuario)
	SET @PrecioUnidad = (SELECT Precio FROM Producto WHERE Id_Producto = @Id_Producto)
	SET @Subtotal = (@PrecioUnidad * @Cantidad)

	IF EXISTS(SELECT 1 FROM Linea_Pedido WHERE Id_Pedido = (SELECT MAX(Id_Pedido) FROM Pedido WHERE Id_Usuario = @Id_Usuario))
		BEGIN
			UPDATE Linea_Pedido SET Id_Producto = @Id_Producto,Cantidad = @Cantidad,Subtotal= @Subtotal
			WHERE Id_Pedido = (SELECT MAX(Id_Pedido) FROM Pedido WHERE Id_Usuario = @Id_Usuario)
		END
	ELSE
		INSERT INTO Linea_Pedido (Id_Pedido,Id_Producto,Cantidad,Subtotal) VALUES (@Id_Pedido,@Id_Producto,@Cantidad,@Subtotal)
END

