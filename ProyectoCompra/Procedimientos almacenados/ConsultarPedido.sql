USE EasyShop
IF OBJECT_ID ('ConsultarPedido','P') IS NOT NULL
	DROP PROCEDURE ConsultarPedido
	PRINT 'Procedimiento almacenado ConsultarPedido borrado.'
GO
	PRINT 'Procedimiento almacenado ConsultarPedido creado.'
GO
CREATE PROCEDURE ConsultarPedido
	@Id_Usuario INT
AS
BEGIN
	SET NOCOUNT ON
	SELECT d.Nombre_Direccion,d.Direccion,d.Pais,d.Provincia,d.Ciudad,d.Codigo_Postal,d.Telefono,
	c.Nombre,c.Apellido,
	i.Codigo_Imagen,
	pro.Id_Producto,pro.Id_Subcategoria,pro.Nombre as 'Nombre_Producto',pro.Descripcion,pro.Precio,pro.Fabricante,
	lp.Id_Linea_Pedido,lp.Id_Pedido,lp.Cantidad,lp.Subtotal,
	p.Id_Pedido,p.Id_Estado_Pedido,p.Fecha,
	f.Id_Factura,f.Id_Estado_Factura,f.Fecha_Factura
	FROM Factura f
	INNER JOIN Pedido p ON (f.Id_Pedido = p.Id_Pedido)
	INNER JOIN Linea_Pedido lp ON (lp.Id_Pedido = p.Id_Pedido)
	INNER JOIN Usuario u ON (u.Id_Usuario = p.Id_Usuario)
	INNER JOIN Cliente c ON (c.Id_Cliente = u.Id_Cliente)
	INNER JOIN Direccion d ON (d.Id_Cliente = c.Id_Cliente)
	INNER JOIN Producto pro ON (pro.Id_Producto = lp.Id_Producto)
	INNER JOIN Imagen i ON (i.Id_Producto = pro.Id_Producto)
	WHERE p.Id_Usuario = @Id_Usuario
	ORDER BY p.Id_Pedido DESC
END
