USE EasyShop
IF OBJECT_ID ('EliminarTarjetaCredito','P') IS NOT NULL
	DROP PROCEDURE EliminarTarjetaCredito
	PRINT 'Procedimiento almacenado EliminarTarjetaCredito borrado.'
GO
	PRINT 'Procedimiento almacenado EliminarTarjetaCredito creado.'
GO
CREATE PROCEDURE EliminarTarjetaCredito
	@Id_Usuario INT
AS
BEGIN
	DELETE FROM Tarjeta_Credito
	WHERE Id_Usuario = @Id_Usuario
END