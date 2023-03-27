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
	UPDATE usuario 
	SET contrasenia = CASE 
							WHEN @Contrasenia IS NOT NULL AND @Contrasenia != ''
								THEN @Contrasenia
							ELSE contrasenia
					  END,
	correo_electronico = CASE 
								WHEN @Correo_Electronico IS NOT NULL AND @Correo_Electronico != ''
									THEN @Correo_Electronico
								ELSE correo_electronico
						 END
	WHERE usuario_name = @Usuario_Name
							
	UPDATE cliente
	SET direccion = CASE
							WHEN @Direccion IS NOT NULL AND @Direccion != ''
								THEN @Direccion
							ELSE direccion
					END
	WHERE id_cliente = (SELECT id_cliente
										 FROM usuario 
													WHERE usuario_name = @Usuario_Name)
END