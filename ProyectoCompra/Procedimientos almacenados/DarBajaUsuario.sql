USE Compras
IF OBJECT_ID ('DarBajaUsuario','P') IS NOT NULL
	DROP PROCEDURE DarBajaUsuario
	PRINT 'Procedimiento almacenado borrado.'
GO
CREATE PROCEDURE DarBajaUsuario
@Usuario_name NVARCHAR(50),
@Contrasenia NVARCHAR(50),
@Correo_Electronico NVARCHAR(50)
AS
BEGIN
	IF (@Usuario_name IS NOT NULL AND @Contrasenia IS NOT NULL)
		BEGIN
			DELETE FROM cliente
			WHERE id_cliente = (SELECT id_cliente FROM usuario
								WHERE usuario_name = @Usuario_name AND contrasenia = @Contrasenia)
		END
	ELSE
		DELETE FROM cliente
			WHERE id_cliente = (SELECT id_cliente FROM usuario
								WHERE correo_electronico = @Correo_Electronico)
END