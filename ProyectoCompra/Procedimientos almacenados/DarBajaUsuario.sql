USE EasyShop
IF OBJECT_ID ('DarBajaUsuarioPorUsuario','P') IS NOT NULL
	DROP PROCEDURE DarBajaUsuarioPorUsuario
	PRINT 'Procedimiento almacenado DarBajaUsuarioPorUsuario borrado.'
GO
	PRINT 'Procedimiento almacenado DarBajaUsuarioPorUsuario creado.'
GO
CREATE PROCEDURE DarBajaUsuarioPorUsuario
@Usuario_name NVARCHAR(50),
@Contrasenia NVARCHAR(50)
AS
BEGIN
		DELETE FROM cliente
		WHERE id_cliente = (SELECT id_cliente FROM usuario
							WHERE usuario_name = @Usuario_name AND contrasenia = @Contrasenia)
END