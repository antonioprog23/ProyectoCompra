USE EasyShop
IF OBJECT_ID ('ActualizarDireccion','P') IS NOT NULL
	DROP PROCEDURE ActualizarDireccion
	PRINT 'Procedimiento almacenado borrado.'
GO
CREATE PROCEDURE ActualizarDireccion
@Id_Usuario INT,
@Nombre_Direccion NVARCHAR(150),
@Direccion NVARCHAR(150),
@Pais NVARCHAR(15),
@Provincia NVARCHAR(100),
@Ciudad NVARCHAR(150),
@Codigo_Postal NVARCHAR(5),
@Telefono NVARCHAR(9)
AS
BEGIN
	SET NOCOUNT ON

	DECLARE @Id_Cliente INT 
	SET @Id_Cliente = (SELECT Id_Cliente FROM Usuario
					   WHERE Id_Usuario = @Id_Usuario)

	IF EXISTS (SELECT 1 FROM Direccion
				WHERE Nombre_Direccion = @Nombre_Direccion AND 
					  Direccion = @Direccion AND 
					  Pais = @Pais AND
					  Provincia = @Provincia AND
					  Ciudad = @Ciudad AND
					  Codigo_Postal = @Codigo_Postal AND
					  Telefono = @Telefono AND
					  Id_Cliente = @Id_Cliente)
		BEGIN
			UPDATE Direccion SET Nombre_Direccion = @Nombre_Direccion,
								 Direccion = @Direccion,
								 Pais = @Pais,
								 Provincia = @Provincia,
								 Ciudad = @Ciudad,
								 Codigo_Postal = @Codigo_Postal,
								 Telefono = @Telefono
			WHERE Id_Cliente = @Id_Cliente
		END
	ELSE
		DECLARE @Id_Direccion INT
		SET @Id_Direccion = (SELECT COALESCE(MAX(Id_Direccion + 1),1) FROM Direccion)

		INSERT INTO Direccion 
		VALUES (@Id_Direccion,@Id_Cliente,@Nombre_Direccion,@Direccion,@Pais,@Provincia,@Ciudad,@Codigo_Postal,@Telefono)
END