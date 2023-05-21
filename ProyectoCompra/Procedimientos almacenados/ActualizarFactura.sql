Use EasyShop
IF OBJECT_ID ('ActualizarFactura','P') IS NOT NULL
	DROP PROCEDURE ActualizarFactura
	PRINT 'Procedimiento almacenado borrado.'
GO
	PRINT 'Procedimiento almacenado creado.'
GO
CREATE PROCEDURE ActualizarFactura
@Id_Usuario INT,
@Id_Pedido INT,
@MetodoPagoElegido INT
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Id_Factura INT
	SET @Id_Factura = (SELECT COALESCE(MAX(Id_Factura + 1),1) FROM Factura)
	INSERT INTO Factura VALUES (@Id_Factura,@Id_Usuario,@Id_Pedido,@MetodoPagoElegido,CONVERT(date, GETDATE()))
END