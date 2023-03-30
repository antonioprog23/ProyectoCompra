USE Compras

-- SENTENCES DROP
-- DROP TABLE cliente
-- DROP TABLE usuario
-- DROP TABLE detalle_usuario
-- DROP TABLE usuario_login
-- DROP TABLE usuario_invitado
-- DROP TABLE producto
-- DROP TABLE categoria
-- DROP TABLE linea_pedido
-- DROP TABLE pedido
-- DROP TABLE estado_pedido
-- DROP TABLE factura

-- TABLES

-- CLIENTE
CREATE TABLE cliente
(
	id_cliente int PRIMARY KEY,
	nombre NVARCHAR(30) NOT NULL,
	apellido NVARCHAR(30) NOT NULL,
	edad INT NOT NULL,
	fecha_nacimiento DATE NOT NULL,
	sexo NVARCHAR(15) NOT NULL,
	direccion NVARCHAR(30) NOT NULL,
)

-- USUARIO
CREATE TABLE usuario
(
	id_usuario int PRIMARY KEY,
	id_cliente int NOT NULL,
	usuario_name NVARCHAR(30) NOT NULL,
	contrasenia NVARCHAR(30) NOT NULL,
	correo_electronico NVARCHAR(30) NOT NULL
	CONSTRAINT constraint_id_cliente_fk FOREIGN KEY (id_cliente) REFERENCES cliente (id_cliente) ON DELETE CASCADE
)

-- DETALLE USUARIO
CREATE TABLE detalle_usuario
(
	id_usuario int NOT NULL PRIMARY KEY,
	fecha_alta DATETIME NOT NULL,
	fecha_ultima_modificacion DATETIME,
	CONSTRAINT constraint_id_usuario_fk FOREIGN KEY (id_usuario) REFERENCES usuario (id_usuario) ON DELETE CASCADE
)

-- USUARIO LOGIN
CREATE TABLE usuario_login
(
	id_usuario INT NOT NULL PRIMARY KEY,
	fecha_ultimo_acceso DATETIME NOT NULL,
	CONSTRAINT constraint_id_usuario_login_fk FOREIGN KEY (id_usuario) REFERENCES usuario (id_usuario) ON DELETE CASCADE
)

-- USUARIO INVITADO

CREATE TABLE usuario_invitado (
    id_usuario INT NOT NULL PRIMARY KEY,
    fecha_expiracion DATETIME,
    CONSTRAINT constraint_id_usuario_invitado_fk FOREIGN KEY (id_usuario) REFERENCES usuario(id_usuario) ON DELETE CASCADE
)

-- CATEGORIA
CREATE TABLE categoria
(
	id_categoria INT IDENTITY PRIMARY KEY,
	descripcion NVARCHAR(50) NOT NULL
)

-- PRODUCTO
CREATE TABLE producto
(
	id_producto INT PRIMARY KEY,
	id_categoria INT NOT NULL,
	nombre NVARCHAR(30) NOT NULL,
	descripcion NVARCHAR(30) NOT NULL,
	precio DECIMAL(5,2) NOT NULL,
	fabricante NVARCHAR(30) NOT NULL,
	CONSTRAINT constraint_id_categoria_fk FOREIGN KEY (id_categoria) REFERENCES categoria (id_categoria)
)

-- ESTADO
CREATE TABLE estado_pedido
(
	id_estado_pedido INT IDENTITY PRIMARY KEY,
	descripcion NVARCHAR(30)
)

-- PEDIDO
CREATE TABLE pedido
(
	id_pedido INT PRIMARY KEY,
	id_cliente INT NOT NULL,
	id_estado_pedido int NOT NULL,
	total DECIMAL(5,2) NOT NULL,
	fecha DATETIME NOT NULL,
	CONSTRAINT constraint_id_cliente_pedido_fk FOREIGN KEY (id_cliente) REFERENCES cliente (id_cliente),
	CONSTRAINT constraint_id_estado_pedido FOREIGN KEY (id_estado_pedido) REFERENCES estado_pedido (id_estado_pedido)
)

-- LINEA_PEDIDO
CREATE TABLE linea_pedido
(
	id_linea_pedido INT PRIMARY KEY,
	id_pedido INT NOT NULL,
	id_producto INT NOT NULL,
	cantidad INT NOT NULL,
	subtotal DECIMAL(5,2) NOT NULL,
	iva DECIMAL(5,2) NOT NULL,
	CONSTRAINT constraint_id_pedido_fk FOREIGN KEY (id_pedido) REFERENCES pedido (id_pedido) ON DELETE CASCADE,
	CONSTRAINT constraint_id_producto_fk FOREIGN KEY (id_producto) REFERENCES producto (id_producto)
)

-- FACTURA
CREATE TABLE Factura (
    id_factura INT PRIMARY KEY,
    id_pedido INT NOT NULL,
    fecha_factura DATETIME,
    CONSTRAINT constraint_id_pedido_factura_fk FOREIGN KEY (id_pedido) REFERENCES pedido (id_pedido) ON DELETE CASCADE
)