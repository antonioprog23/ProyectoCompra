Use EasyShop
IF OBJECT_ID ('ConsultarFactura','P') IS NOT NULL
	DROP PROCEDURE ConsultarFactura;
	PRINT 'Procedimiento almacenado borrado.'
GO
	PRINT 'Procedimiento almacenado creado.'
GO
CREATE PROCEDURE ConsultarFactura
@Id_Usuario INT
AS
BEGIN
	SET NOCOUNT ON
	SELECT * FROM Factura f
	INNER JOIN Pedido p ON (f.Id_Pedido = p.Id_Pedido)
	INNER JOIN Linea_Pedido lp ON (p.Id_Pedido = lp.Id_Pedido)
	INNER JOIN Producto pro ON (pro.Id_Producto = lp.Id_Producto)
	INNER JOIN Cliente c ON (c.Id_Cliente = p.Id_Cliente)
	INNER JOIN Usuario u ON (u.Id_Cliente = c.Id_Cliente)
	INNER JOIN Direccion d ON (d.Id_Cliente = c.Id_Cliente)
END