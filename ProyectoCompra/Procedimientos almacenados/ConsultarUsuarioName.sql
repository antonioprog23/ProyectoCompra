USE Compras
IF OBJECT_ID ('ConsultarUsuarioName','P') IS NOT NULL
	DROP PROCEDURE ConsultarUsuarioName
	PRINT 'Procedimiento almacenado borrado.'
GO
CREATE PROCEDURE ConsultarUsuarioName
@Usuario_name NVARCHAR(30),
@Correo_Electronico NVARCHAR(60) = NULL
AS
BEGIN
	IF(@Correo_Electronico IS NOT NULL)
		BEGIN
			SELECT id_usuario FROM usuario
			WHERE correo_electronico = @Correo_Electronico
		END
	ELSE
		SELECT id_usuario FROM usuario
		WHERE usuario_name = @Usuario_name
END
