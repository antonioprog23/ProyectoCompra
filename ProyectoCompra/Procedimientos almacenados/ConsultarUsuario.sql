USE EasyShop
IF OBJECT_ID ('ConsultarUsuario','P') IS NOT NULL
	DROP PROCEDURE ConsultarUsuario
	PRINT 'Procedimiento almacenado borrado.'
GO
CREATE PROCEDURE ConsultarUsuario
@Id_Usuario INT,
@Usuario_name NVARCHAR(30),
@Contrasenia NVARCHAR(30)
AS
BEGIN
	IF (@Id_Usuario = 0)
		BEGIN
			SELECT u.id_usuario,c.id_cliente,u.usuario_name,u.contrasenia,du.fecha_alta,du.fecha_ultima_modificacion,c.nombre,c.apellido,c.edad,c.fecha_nacimiento,c.sexo,u.correo_electronico FROM usuario u
			INNER  JOIN detalle_usuario du ON (u.id_usuario = du.id_usuario)
			INNER JOIN cliente c ON (c.id_cliente = u.id_cliente)
			WHERE u.usuario_name = @Usuario_name AND u.contrasenia = @Contrasenia
		END
	ELSE
		SELECT u.id_usuario,c.id_cliente,u.usuario_name,u.contrasenia,du.fecha_alta,du.fecha_ultima_modificacion,c.nombre,c.apellido,c.edad,c.fecha_nacimiento,c.sexo,u.correo_electronico FROM usuario u
			INNER  JOIN detalle_usuario du ON (u.id_usuario = du.id_usuario)
			INNER JOIN cliente c ON (c.id_cliente = u.id_cliente)
			WHERE u.id_usuario = @Id_Usuario
END