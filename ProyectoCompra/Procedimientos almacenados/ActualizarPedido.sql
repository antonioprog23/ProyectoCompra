USE EasyShop
IF OBJECT_ID ('ActualizarPedido','P') IS NOT NULL
	DROP PROCEDURE ActualizarPedido
	PRINT 'Procedimiento almacenado borrado.'
GO
	PRINT 'Procedimiento almacenado creado.'
GO
CREATE PROCEDURE ActualizarPedido
	@Id_Usuario INT
AS
BEGIN
	SET NOCOUNT ON

	DECLARE @Id_Pedido INT
	DECLARE @Total DECIMAL(5,2)

	SET @Id_Pedido = (SELECT COALESCE(MAX(Id_Pedido+ 1),1) FROM Pedido)
	SET @Total = (SELECT Subtotal * 1.03 FROM Linea_Pedido WHERE Id_Pedido = @Id_Pedido)

	IF EXISTS (SELECT 1 FROM Pedido 
				WHERE Id_Pedido = (SELECT MAX(Id_Pedido) FROM Pedido
									WHERE Id_Usuario = @Id_Usuario))
		BEGIN 
			UPDATE Pedido SET Total = @Total WHERE Id_Pedido = (SELECT MAX(Id_Pedido) FROM Pedido WHERE Id_Usuario = @Id_Usuario)
		END
	ELSE
		INSERT INTO Pedido VALUES (@Id_Pedido,@Id_Usuario,3,@Total,CONVERT(date, GETDATE()))
END
