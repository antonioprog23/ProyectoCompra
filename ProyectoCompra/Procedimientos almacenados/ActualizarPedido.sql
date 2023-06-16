USE EasyShop
IF OBJECT_ID ('ActualizarPedido','P') IS NOT NULL
	DROP PROCEDURE ActualizarPedido
	PRINT 'Procedimiento almacenado ActualizarPedido borrado.'
GO
	PRINT 'Procedimiento almacenado ActualizarPedido creado.'
GO
CREATE PROCEDURE ActualizarPedido
	@Id_Usuario INT,
	@Id_Metodo_Pago INT
AS
BEGIN
	SET NOCOUNT ON
	-- VARIABLES
	DECLARE @Id_Pedido INT
	DECLARE @Id_Factura INT

	-- SE CALCULA LOS ID DISPONIBLES EN LAS TABLAS CORRESPONDIENTES
	SET @Id_Pedido = (SELECT COALESCE(MAX(Id_Pedido+ 1),1) FROM Pedido)
	SET @Id_Factura = (SELECT COALESCE(MAX(Id_Factura+ 1),1) FROM Factura)

	-- PEDIDO
	INSERT INTO Pedido (Id_Pedido,Id_Usuario,Id_Direccion,Id_Estado_Pedido,Fecha,Id_Metodo_Pago) 
	SELECT @Id_Pedido,@Id_Usuario,MIN(Id_Direccion),3,CONVERT(date, GETDATE()),@Id_Metodo_Pago FROM Direccion 
	WHERE Id_Cliente = (SELECT Id_Cliente FROM Usuario WHERE Id_Usuario = @Id_Usuario)

	-- LINEA PEDIDO
	INSERT INTO Linea_Pedido (Id_Pedido,Id_Producto,Cantidad,Subtotal) 
	SELECT @Id_Pedido,c.Id_Producto, c.Cantidad, (p.Precio * c.Cantidad) FROM Carrito c
	INNER JOIN Producto p ON (c.Id_Producto = p.Id_Producto)
	WHERE Id_Usuario = @Id_Usuario
	
	-- FACTURA (1 = Efectivo, 2 = Tarjeta)
	IF (@Id_Metodo_Pago = 1)
		BEGIN
			INSERT INTO Factura VALUES (@Id_Factura,@Id_Pedido,1,CONVERT(date,GETDATE()))
		END
	ELSE
			INSERT INTO Factura VALUES (@Id_Factura,@Id_Pedido,2,CONVERT(date,GETDATE()))
	
	-- POR ÚLTIMO, EL CARRITO DEL USUARIO SE VACIA
	DELETE FROM Carrito WHERE Id_Usuario = @Id_Usuario
END
