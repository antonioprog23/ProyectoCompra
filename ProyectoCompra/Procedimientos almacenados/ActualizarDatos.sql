USE Compras
IF OBJECT_ID ('ActualizarDatos','P') IS NOT NULL
	DROP PROCEDURE ActualizarDatos;
	PRINT 'Procedimiento almacenado borrado.'
GO
CREATE PROCEDURE ActualizarDatos
@Direccion NVARCHAR(50),
@Usuario_name NVARCHAR(30),
@Contrasenia NVARCHAR(30),
@CorreoElectronico NVARCHAR(50)
AS

BEGIN
	SET NOCOUNT ON
	UPDATE cliente SET direccion = @Direccion 
	WHERE id_cliente = (SELECT id_cliente FROM usuario
						WHERE usuario_name = @Usuario_name)
	UPDATE usuario SET contrasenia = @Contrasenia, correo_electronico = @CorreoElectronico
	WHERE usuario_name = @Usuario_name
END