USE Compras
IF OBJECT_ID ('ConsultarUsuarioName','P') IS NOT NULL
	DROP PROCEDURE ConsultarUsuarioName
	PRINT 'Procedimiento almacenado borrado.'
GO
CREATE PROCEDURE ConsultarUsuarioName
@Usuario_name NVARCHAR(30)
AS
BEGIN
	SELECT id_usuario FROM usuario
	WHERE usuario_name = @Usuario_name
END
