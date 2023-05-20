USE EasyShop
IF OBJECT_ID ('EditarTarjetaCredito','P') IS NOT NULL
	DROP PROCEDURE EditarTarjetaCredito
	PRINT 'Procedimiento almacenado borrado.'
GO
CREATE PROCEDURE EditarTarjetaCredito
@Id_Usuario INT,
@Titular NVARCHAR(100),
@Numero_Tarjeta NVARCHAR(16),
@Mes_Vencimiento TINYINT,
@Anio_Vencimiento SMALLINT,
@CVV SMALLINT,
@Eliminar_Tarjeta BIT = 0
AS
BEGIN
	IF (@Eliminar_Tarjeta = 1)
		BEGIN 
			DELETE FROM Tarjeta_Credito
			WHERE id_usuario = @Id_Usuario
			RETURN
		END

	IF EXISTS (SELECT 1 FROM Tarjeta_Credito WHERE id_usuario = @Id_Usuario)
		BEGIN
			UPDATE Tarjeta_Credito
			SET titular = @Titular, numero_tarjeta = @Numero_Tarjeta, mes_vencimiento = @Mes_Vencimiento, anio_vencimiento = @Anio_Vencimiento, cvv = @CVV
			WHERE id_usuario = @Id_Usuario
		END
	ELSE
		INSERT INTO Tarjeta_Credito VALUES (@Id_Usuario,@Titular,@Numero_Tarjeta,@Mes_Vencimiento,@Anio_Vencimiento,@CVV)
END