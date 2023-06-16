USE EasyShop
IF OBJECT_ID ('ConsultarTarjetaCredito','P') IS NOT NULL
	DROP PROCEDURE ConsultarTarjetaCredito
	PRINT 'Procedimiento almacenado ConsultarTarjetaCredito borrado.'
GO
	PRINT 'Procedimiento almacenado ConsultarTarjetaCredito creado.'
GO
CREATE PROCEDURE ConsultarTarjetaCredito
@Id_Usuario INT
AS
BEGIN
	SELECT titular,numero_tarjeta,mes_vencimiento,anio_vencimiento,cvv FROM Tarjeta_Credito
	WHERE id_usuario = @Id_Usuario
END