USE EasyShop
IF OBJECT_ID ('EditarUsuarioFechaAcceso','P') IS NOT NULL
	DROP PROCEDURE EditarUsuarioFechaAcceso
	PRINT 'Procedimiento almacenadoEditarUsuarioFechaAcceso borrado.'
GO
	PRINT 'Procedimiento almacenadoEditarUsuarioFechaAcceso creado.'
GO
CREATE PROCEDURE EditarUsuarioFechaAcceso
@id_usuario INT
AS
BEGIN
	UPDATE usuario_login SET fecha_ultimo_acceso = CAST(GETDATE() AS date)
	WHERE id_usuario = @id_usuario
END