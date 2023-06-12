USE EasyShop
IF OBJECT_ID ('InsertarDatosInvitado','P') IS NOT NULL
	DROP PROCEDURE InsertarDatosInvitado
	PRINT 'Procedimiento almacenado InsertarDatosInvitado borrado.'
GO
	PRINT 'Procedimiento almacenado InsertarDatosInvitado creado.'
GO
	IF NOT EXISTS (SELECT 1 FROM sys.types WHERE name LIKE 'CarritoProvisional' AND is_table_type = 1)
		CREATE TYPE dbo.CarritoProvisional AS TABLE
		(
			Id_Producto INT,
			Cantidad INT
		)
GO
CREATE PROCEDURE InsertarDatosInvitado
@Nombre NVARCHAR(30),
@Invitado INT,
@Id_Usuario INT,
@Nombre_Direccion NVARCHAR(150),
@Direccion NVARCHAR(150),
@Pais NVARCHAR(15),
@Provincia NVARCHAR(100),
@Ciudad NVARCHAR(150),
@Codigo_Postal NVARCHAR(5),
@Telefono NVARCHAR(9),
@Productos dbo.CarritoProvisional READONLY,
@Id_Metodo_Pago INT
AS
BEGIN
	SET NOCOUNT ON

	DECLARE @Id_Cliente INT
	DECLARE @Fecha_Alta DATE
	DECLARE @Fecha_Expiracion DATE
	DECLARE @Id_Direccion_New INT
	DECLARE @Id_Pedido INT
	DECLARE @Id_Factura INT

	SET @Id_Direccion_New = (SELECT COALESCE(MAX(Id_Direccion + 1),1) FROM Direccion)
	SET @Fecha_alta = (SELECT CAST(GETDATE() AS date))
	SET @Id_Cliente = (SELECT COALESCE(MAX(id_cliente + 1),1) FROM cliente)
	SET @Fecha_Expiracion= (DATEADD(DAY,15,@Fecha_Alta))
	SET @Id_Pedido = (SELECT COALESCE(MAX(Id_Pedido + 1),1) FROM Pedido)
	SET @Id_Factura = (SELECT COALESCE(MAX(Id_Factura + 1),1) FROM Factura)

	-- CLIENTE
	INSERT INTO Cliente (Id_Cliente,Nombre) VALUES (@Id_Cliente,@Nombre)

	-- USUARIO
	INSERT INTO Usuario (Id_Usuario,Id_Cliente, Invitado) VALUES (@Id_Usuario,@Id_Cliente,@Invitado)

	-- DETALLE_USUARIO
	INSERT INTO Detalle_Usuario(Id_Usuario,Fecha_Alta,Fecha_Ultima_Modificacion) VALUES (@Id_Usuario,@Fecha_Alta,@Fecha_Expiracion)

	-- DIRECCION
	INSERT INTO Direccion VALUES (@Id_Direccion_New,@Id_Cliente,@Nombre_Direccion,@Direccion,@Pais,@Provincia,@Ciudad,@Codigo_Postal,@Telefono)
	
	-- TARJETA CREDITO

	-- PEDIDO
	INSERT INTO Pedido VALUES (@Id_Pedido,@Id_Usuario,@Id_Direccion_New,1,GETDATE(),@Id_Metodo_Pago)
	
	--LINEA PEDIDO
	INSERT INTO Linea_Pedido SELECT @Id_Pedido,pro.Id_Producto,pro.Cantidad, (Cantidad * (SELECT p.Precio FROM Producto p WHERE p.Id_Producto = pro.Id_Producto)) FROM @Productos pro
	
	-- FACTURA (1 = Efectivo, 2 = Tarjeta)
	IF (@Id_Metodo_Pago = 1)
		BEGIN
			INSERT INTO Factura VALUES (@Id_Factura,@Id_Pedido,1,CONVERT(date,GETDATE()))
		END
	ELSE
			INSERT INTO Factura VALUES (@Id_Factura,@Id_Pedido,2,CONVERT(date,GETDATE()))
	
END