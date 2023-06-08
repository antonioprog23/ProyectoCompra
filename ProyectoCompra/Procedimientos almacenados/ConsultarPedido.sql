USE EasyShop
IF OBJECT_ID ('ConsultarPedido','P') IS NOT NULL
	DROP PROCEDURE ConsultarPedido
	PRINT 'Procedimiento almacenado ConsultarPedido borrado.'
GO
	PRINT 'Procedimiento almacenado ConsultarPedido creado.'
GO
CREATE PROCEDURE ConsultarPedido
	@Id_Usuario INT,
	@Fecha_Desde DATE = NULL,
	@Fecha_Hasta DATE = NULL
AS
BEGIN
	SET NOCOUNT ON

	SELECT 
	f.Id_Factura,f.Id_Estado_Factura,f.Fecha_Factura,
	p.Id_Pedido,p.Id_Estado_Pedido,p.Fecha,p.Id_Metodo_Pago,
	lp.Id_Linea_Pedido,lp.Id_Pedido,lp.Cantidad,lp.Subtotal,
	c.Nombre,c.Apellido,
	d.Nombre_Direccion,d.Direccion,d.Pais,d.Provincia,d.Ciudad,d.Codigo_Postal,d.Telefono,
	pro.Id_Producto,pro.Id_Subcategoria,pro.Nombre as 'Nombre_Producto',pro.Descripcion,pro.Precio,pro.Fabricante,
	i.Codigo_Imagen
		FROM Pedido p
    INNER JOIN Usuario u ON (u.Id_Usuario = p.Id_Usuario)
    INNER JOIN Cliente c ON (c.Id_Cliente = u.Id_Cliente)
    INNER JOIN Direccion d ON (d.Id_Cliente = c.Id_Cliente)
    INNER JOIN Linea_Pedido lp ON (lp.Id_Pedido = p.Id_Pedido)
    INNER JOIN Producto pro ON (pro.Id_Producto = lp.Id_Producto)
    INNER JOIN Factura f ON (f.Id_Pedido = p.Id_Pedido)
    INNER JOIN Imagen i ON (i.Id_Producto = pro.Id_Producto)
    WHERE p.Id_Usuario = @Id_Usuario
        AND (@Fecha_Desde IS NULL OR p.Fecha >= @Fecha_Desde)
        AND (@Fecha_Hasta IS NULL OR p.Fecha <= @Fecha_Hasta)
    ORDER BY p.Id_Pedido DESC
END
