USE Compras
IF OBJECT_ID ('ActualizarDatos','P') IS NOT NULL
	DROP PROCEDURE ActualizarDatos;
	PRINT 'Procedimiento almacenado borrado.'
GO
CREATE PROCEDURE ActualizarDatos
@Direccion NVARCHAR(50),
@Usuario_Name NVARCHAR(30),
@Contrasenia NVARCHAR(30),
@Correo_Electronico NVARCHAR(50)
AS

BEGIN
	SET NOCOUNT ON
	IF (@Direccion IS NOT NULL)
		UPDATE cliente SET direccion = @Direccion 
		WHERE id_cliente = (SELECT id_cliente FROM usuario
							WHERE usuario_name = @Usuario_Name)
	IF (@Contrasenia IS NOT NULL)
		UPDATE usuario SET contrasenia = @Contrasenia
		WHERE usuario_name = @Usuario_name

	IF (@Correo_Electronico IS NOT NULL)
		UPDATE usuario SET correo_electronico = @Correo_Electronico
		WHERE usuario_name = @Usuario_name
END