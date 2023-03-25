USE Compras
IF OBJECT_ID ('EditarUsuario','P') IS NOT NULL
	DROP PROCEDURE EditarUsuario
	PRINT 'Procedimiento almacenado borrado.'
GO
CREATE PROCEDURE EditarUsuario
@id_usuario INT
AS
BEGIN
	UPDATE detalle_usuario SET fecha_ultimo_acceso = CAST(GETDATE() AS date)
	WHERE id_usuario = @id_usuario
END