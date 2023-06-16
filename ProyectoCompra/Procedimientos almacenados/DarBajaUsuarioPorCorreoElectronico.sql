USE EasyShop
IF OBJECT_ID ('DarBajaUsuarioPorCorreoElectronico','P') IS NOT NULL
	DROP PROCEDURE DarBajaUsuarioPorCorreoElectronico
	PRINT 'Procedimiento almacenado DarBajaUsuarioPorCorreoElectronico borrado.'
GO
	PRINT 'Procedimiento almacenado DarBajaUsuarioPorCorreoElectronico creado.'
GO
CREATE PROCEDURE DarBajaUsuarioPorCorreoElectronico
@Correo_Electronico NVARCHAR(60)
AS
BEGIN
		DELETE FROM cliente
		WHERE id_cliente = (SELECT id_cliente FROM usuario
							WHERE correo_electronico = @Correo_Electronico)
END