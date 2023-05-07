USE EasyShop
IF OBJECT_ID ('InsertarDatos','P') IS NOT NULL
	DROP PROCEDURE InsertarDatos;
	PRINT 'Procedimiento almacenado borrado.'
GO
CREATE PROCEDURE InsertarDatos
@Nombre NVARCHAR(30),
@Apellido NVARCHAR(30),
@Edad INT,
@Fecha_Nacimiento DATE,
@Sexo NVARCHAR(15),
@Usuario_Name NVARCHAR(30),
@Contrasenia NVARCHAR(30),
@CorreoElectronico NVARCHAR(50)
AS

BEGIN
	SET NOCOUNT ON
	DECLARE @Id_Cliente INT

	SET @Id_Cliente = (SELECT COALESCE(MAX(id_cliente + 1),1) FROM cliente)
	
	INSERT INTO cliente (Id_Cliente,Nombre,Apellido,Edad,Fecha_Nacimiento,Sexo) VALUES
						(@Id_Cliente,@Nombre,@Apellido,@Edad,@Fecha_Nacimiento,@Sexo)

	DECLARE @Id_Usuario INT
	DECLARE @Fecha_Alta DATE

	SET @Id_Usuario = (SELECT COALESCE(MAX(id_usuario + 1),1) FROM usuario)
	SET @Fecha_alta = (SELECT CAST(GETDATE() AS date))

	INSERT INTO usuario (Id_Usuario,Id_Cliente,Usuario_name, Contrasenia, Correo_Electronico) VALUES
						(@Id_Usuario,@Id_Cliente,@Usuario_name, @Contrasenia, @CorreoElectronico)

	INSERT INTO detalle_usuario (id_usuario,fecha_alta,fecha_ultima_modificacion) VALUES
				(@id_usuario,@fecha_alta,@fecha_alta);
END