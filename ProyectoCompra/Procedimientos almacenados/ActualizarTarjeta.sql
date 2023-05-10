USE EasyShop
IF OBJECT_ID ('ActualizarTarjeta','P') IS NOT NULL
	DROP PROCEDURE ActualizarTarjeta
	PRINT 'Procedimiento almacenado borrado.'
GO
CREATE PROCEDURE ActualizarTarjeta
	@Id_Usuario INT,
	@Titular NVARCHAR(100),
	@Numero_Tarjeta NVARCHAR(16),
	@Mes_Vencimiento NVARCHAR(4),
	@Anio_Vencimiento NVARCHAR(4),
	@CVV NVARCHAR(3)
AS
BEGIN
	IF EXISTS (SELECT 1 FROM Tarjeta_Credito
			   WHERE Id_Usuario = @Id_Usuario)
		BEGIN
			UPDATE Tarjeta_Credito SET 
									  Titular = @Titular, Numero_Tarjeta = @Numero_Tarjeta, Mes_Vencimiento = @Mes_Vencimiento, Anio_Vencimiento = Anio_Vencimiento,CVV = @CVV
			WHERE Id_Usuario = @Id_Usuario
			RETURN
		END
	ELSE
		INSERT INTO Tarjeta_Credito (Id_Usuario,Titular,Numero_Tarjeta,Mes_Vencimiento,Anio_Vencimiento,CVV)
		VALUES (@Id_Usuario,@Titular,@Numero_Tarjeta,@Mes_Vencimiento,@Anio_Vencimiento,@CVV)
END