USE EasyShop
IF OBJECT_ID ('ActualizarDireccion','P') IS NOT NULL
	DROP PROCEDURE ActualizarDireccion
	PRINT 'Procedimiento almacenado borrado.'
GO
CREATE PROCEDURE ActualizarDireccion
@Id_Direccion INT,
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
	IF EXISTS (SELECT 1 FROM Direccion
				WHERE Id_Direccion = @Id_Direccion AND
				Id_Cliente = (SELECT Id_Cliente FROM Usuario
							  WHERE Id_Usuario = @Id_Usuario AND
							  Id_Direccion = @Id_Direccion))
		BEGIN
			UPDATE Direccion SET Nombre_Direccion = @Nombre_Direccion,
								 Direccion = @Direccion,
								 Pais = @Pais,
								 Provincia = @Provincia,
								 Ciudad = @Ciudad,
								 Codigo_Postal = @Codigo_Postal,
								 Telefono = @Telefono
			WHERE Id_Direccion = @Id_Direccion AND
			Id_Cliente = (SELECT Id_Cliente FROM Usuario
							  WHERE Id_Usuario = @Id_Usuario)
							  return
		END
	ELSE
		DECLARE @Id_Direccion_New INT
		SET @Id_Direccion_New = (SELECT COALESCE(MAX(Id_Direccion + 1),1) FROM Direccion)

		DECLARE @Id_Cliente INT 
		SET @Id_Cliente = (SELECT Id_Cliente FROM Usuario
						   WHERE Id_Usuario = @Id_Usuario)
		INSERT INTO Direccion 
		VALUES (@Id_Direccion_New,@Id_Cliente,@Nombre_Direccion,@Direccion,@Pais,@Provincia,@Ciudad,@Codigo_Postal,@Telefono)
END