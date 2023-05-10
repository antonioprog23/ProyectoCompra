USE EasyShop
IF OBJECT_ID ('EliminarTarjetaCredito','P') IS NOT NULL
	DROP PROCEDURE EliminarTarjetaCredito
	PRINT 'Procedimiento almacenado borrado.'
GO
CREATE PROCEDURE EliminarTarjetaCredito
	@Id_Usuario INT
AS
BEGIN
	DELETE FROM Tarjeta_Credito
	WHERE Id_Usuario = @Id_Usuario
END