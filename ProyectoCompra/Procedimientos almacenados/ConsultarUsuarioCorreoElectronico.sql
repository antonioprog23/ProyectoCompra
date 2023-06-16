USE EasyShop
IF OBJECT_ID ('ConsultarUsuarioCorreoElectronico','P') IS NOT NULL
	DROP PROCEDURE ConsultarUsuarioCorreoElectronico
	PRINT 'Procedimiento almacenado ConsultarUsuarioCorreoElectronico borrado.'
GO
	PRINT 'Procedimiento almacenado ConsultarUsuarioCorreoElectronico creado.'
GO
CREATE PROCEDURE ConsultarUsuarioCorreoElectronico
@Correo_Electronico NVARCHAR(100)
AS
BEGIN
		SELECT id_usuario FROM usuario 
		WHERE correo_electronico = @Correo_Electronico
END
