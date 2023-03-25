USE Compras
IF OBJECT_ID ('InsertarDatosLogin','P') IS NOT NULL
	DROP PROCEDURE InsertarDatosLogin;
	PRINT 'Procedimiento almacenado borrado.'
GO
CREATE PROCEDURE InsertarDatosLogin
@Id_Usuario INT NOT NULL,
@Usuario_Name NVARCHAR(30) NOT NULL
AS

BEGIN
	SET NOCOUNT ON
	DECLARE @Id_Cliente INT
	SELECT id_usuario FROM dbo.usuario
END