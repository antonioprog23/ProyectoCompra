USE EasyShop
IF OBJECT_ID ('ConsultarUsuarioName','P') IS NOT NULL
	DROP PROCEDURE ConsultarUsuarioName
	PRINT 'Procedimiento almacenado ConsultarUsuarioName borrado.'
GO
	PRINT 'Procedimiento almacenado ConsultarUsuarioName creado.'
GO
CREATE PROCEDURE ConsultarUsuarioName
@Usuario_name NVARCHAR(100)
AS
BEGIN
		SELECT id_usuario FROM usuario 
		WHERE usuario_name = @Usuario_name
END
