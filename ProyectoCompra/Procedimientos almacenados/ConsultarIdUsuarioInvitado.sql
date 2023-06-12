Use EasyShop
IF OBJECT_ID('ConsultarIdUsuarioInvitado','P') IS NOT NULL
	DROP PROCEDURE ConsultarIdUsuarioInvitado
	PRINT 'Procedimiento almacenado ConsultarIdUsuarioInvitado borrado.'
GO
	PRINT 'Procedimiento almacenado ConsultarIdUsuarioInvitado creado.'
GO
CREATE PROCEDURE ConsultarIdUsuarioInvitado
AS
BEGIN
	SELECT COALESCE(MAX(Id_Usuario + 1),1) FROM Usuario
END
