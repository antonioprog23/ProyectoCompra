Use EasyShop
IF OBJECT_ID ('ConsultarFactura','P') IS NOT NULL
	DROP PROCEDURE ConsultarFactura;
	PRINT 'Procedimiento almacenado ConsultarFactura borrado.'
GO
	PRINT 'Procedimiento almacenado ConsultarFactura creado.'
GO
CREATE PROCEDURE ConsultarFactura
@Id_Usuario INT,
@Id_Pedido INT
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Total_Compra DECIMAL(5,2)
	DECLARE @Subtotal_Compra DECIMAL(5,2)

	IF (@Id_Pedido = 0)
		SET @Id_Pedido = (SELECT MAX(Id_Pedido) FROM Pedido WHERE Id_Usuario = @Id_Usuario)						

	SET @Total_Compra = (SELECT ROUND((SUM((lp.Cantidad * pro.Precio)) * 1.03)+3.99,2) FROM Factura f
						INNER JOIN Pedido p ON (f.Id_Pedido = p.Id_Pedido)
						INNER JOIN Linea_Pedido lp ON (p.Id_Pedido = lp.Id_Pedido)
						INNER JOIN Producto pro ON (pro.Id_Producto = lp.Id_Producto)
						INNER JOIN Usuario u ON (u.Id_Usuario = p.Id_Usuario)
						WHERE u.Id_Usuario = @Id_Usuario AND
						p.Id_Pedido = @Id_Pedido
						GROUP BY f.Id_Factura)

	SET @Subtotal_Compra = (SELECT ROUND((SUM((lp.Subtotal))),2) FROM Factura f
						INNER JOIN Pedido p ON (f.Id_Pedido = p.Id_Pedido)
						INNER JOIN Linea_Pedido lp ON (p.Id_Pedido = lp.Id_Pedido)
						INNER JOIN Producto pro ON (pro.Id_Producto = lp.Id_Producto)
						INNER JOIN Usuario u ON (u.Id_Usuario = p.Id_Usuario)
						WHERE u.Id_Usuario = @Id_Usuario AND
						p.Id_Pedido = @Id_Pedido
						GROUP BY f.Id_Factura)

	SELECT *,@Total_Compra AS Total_Compra,@Subtotal_Compra AS Subtotal_Compra FROM Factura f
	INNER JOIN Pedido p ON (f.Id_Pedido = p.Id_Pedido)
	INNER JOIN Linea_Pedido lp ON (p.Id_Pedido = lp.Id_Pedido)
	INNER JOIN Producto pro ON (pro.Id_Producto = lp.Id_Producto)
	INNER JOIN Usuario u ON (u.Id_Usuario = p.Id_Usuario)
	INNER JOIN Cliente c ON (c.Id_Cliente = u.Id_Cliente)
	INNER JOIN Direccion d ON (d.Id_Cliente = c.Id_Cliente)
	WHERE u.Id_Usuario = @Id_Usuario AND
	p.Id_Pedido = @Id_Pedido
END