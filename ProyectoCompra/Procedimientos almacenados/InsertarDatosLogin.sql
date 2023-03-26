USE Compras
IF OBJECT_ID ('InsertarDatosLogin','P') IS NOT NULL
	DROP PROCEDURE InsertarDatosLogin;
	PRINT 'Procedimiento almacenado borrado.'
GO
CREATE PROCEDURE InsertarDatosLogin
@Id_Usuario INT,
@Usuario_Name NVARCHAR(30)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Id_Cliente INT
	SET @Id_Cliente = (SELECT id_cliente FROM usuario WHERE usuario_name = @Usuario_Name)
	INSERT INTO usuario_login VALUES (@Id_Usuario, CAST(GETDATE() AS DATE))
END