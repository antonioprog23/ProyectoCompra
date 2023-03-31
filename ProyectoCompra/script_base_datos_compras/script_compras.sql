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
	nombre NVARCHAR(50) NOT NULL,
	apellido NVARCHAR(50) NOT NULL,
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
	usuario_name NVARCHAR(50) NOT NULL,
	contrasenia NVARCHAR(50) NOT NULL,
	correo_electronico NVARCHAR(50) NOT NULL
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

-- SUBCATEGORIA
CREATE TABLE subcategoria
(
	id_subcategoria INT IDENTITY PRIMARY KEY,
	id_categoria INT NOT NULL,
	descripcion NVARCHAR(50) NOT NULL,
	CONSTRAINT constraint_id_categoria_fk2 FOREIGN KEY (id_categoria) REFERENCES categoria (id_categoria)
)

-- PRODUCTO
CREATE TABLE producto
(
	id_producto INT IDENTITY PRIMARY KEY,
	id_subcategoria INT NOT NULL,
	nombre NVARCHAR(50) NOT NULL,
	descripcion NVARCHAR(50) NOT NULL,
	precio DECIMAL(5,2) NOT NULL,
	fabricante NVARCHAR(50) NOT NULL,
	CONSTRAINT constraint_id_subcategoria_fk FOREIGN KEY (id_subcategoria) REFERENCES subcategoria (id_subcategoria)
)

-- ESTADO
CREATE TABLE estado_pedido
(
	id_estado_pedido INT IDENTITY PRIMARY KEY,
	descripcion NVARCHAR(50)
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

-- INSERT INTO

-- CATEGORIA
INSERT INTO categoria (descripcion) VALUES ('Alimentación')
INSERT INTO categoria (descripcion) VALUES ('Frescos')
INSERT INTO categoria (descripcion) VALUES ('Fríos y congelados')
INSERT INTO categoria (descripcion) VALUES ('Bebidas')
INSERT INTO categoria (descripcion) VALUES ('Droguería')
INSERT INTO categoria (descripcion) VALUES ('Cuidado personal')
INSERT INTO categoria (descripcion) VALUES ('Electrodomésticos')
INSERT INTO categoria (descripcion) VALUES ('Tecnología')
INSERT INTO categoria (descripcion) VALUES ('Hogar')

-- SUBCATEGORIA
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (1,'Lácteos y huevos') 
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (1,'Aceites, vinagres y salsas')
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (1,'Desayuno y merienda') 
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (1,'Conservas') 
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (1,'Comidas internacionales') 
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (1,'Nutrición deportiva')
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (2,'Verduras y hortalizas') 
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (2,'Quesos') 
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (2,'Carne') 
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (2,'Charcutería') 
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (2,'Pescados, mariscos y moluscos') 
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (2,'Sushi')
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (3,'Congelados') 
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (3,'Postres') 
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (3,'Pasteles') 
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (3,'Mantequillas, margarinas y nata') 
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (3,'Plato calentar y listo') 
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (3,'Masas, bases, pasta fresca') 
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (4,'Zumos de frutas')
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (4,'Agua, soda y gaseos')
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (4,'Bebidas con alcohol')
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (4,'Champagne cavas y sidra')
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (4,'Bebidas ecológicas')
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (4,'Bebidas sin alcohol')
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (5,'Lavado de ropa')
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (5,'Limpieza Hogar')
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (5,'Lavavajillas')
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (5,'Lejías y amoníacos')
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (5,'Insecticidas')
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (5,'Limpieza calzado')
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (6,'Perfumería')
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (6,'Higiene bucal')
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (6,'Botiquín')
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (6,'Cuidado personal')
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (6,'Cuidado cabello')
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (6,'Loción solar')
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (7,'Lavadoras')
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (7,'Frigoríficos')
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (7,'Secadoras')
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (7,'Hornos, placas y campanas')
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (7,'Cafeteras')
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (7,'Climatización')
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (8,'Televisores')
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (8,'Telefonía')
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (8,'Fotografía')
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (8,'Informática')
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (8,'Tablets')
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (8,'Audio')
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (9,'Jardín y aire libre')
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (9,'Bricolaje')
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (9,'Mascotas')
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (9,'Casa y decoración')
INSERT INTO subcategoria (id_categoria,descripcion) VALUES (9,'Textil hogar')

-- PRODUCTO
-- SUBCATEGORIA 1
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (1, 'Leche entera', 'Leche fresca de vaca', 1.99, 'Lácteos S.A.')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (1, 'Queso cheddar', 'Queso de vaca de sabor fuerte', 3.99, 'Lácteos S.A.')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (1, 'Yogur natural', 'Yogur hecho con leche fresca', 0.99, 'Lácteos S.A.')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (1, 'Mantequilla sin sal', 'Mantequilla de vaca sin sal añadida', 2.49, 'Lácteos S.A.')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (1, 'Huevo fresco', 'Huevo de gallina fresco', 0.25, 'Granja Avícola S.A.')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (1, 'Huevo de codorniz', 'Huevo pequeño de codorniz', 0.50, 'Granja Avícola S.A.')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (1, 'Huevo orgánico', 'Huevo de gallina criada orgánicamente', 0.75, 'Granja Orgánica S.A.')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (1, 'Queso brie', 'Queso suave de vaca con corteza blanca', 5.99, 'Lácteos S.A.')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (1, 'Leche desnatada', 'Leche fresca de vaca sin grasa', 1.49, 'Lácteos S.A.')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (1, 'Huevo de pato', 'Huevo grande de pato', 1.00, 'Granja Avícola S.A.')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (1, 'Leche entera 1L', 'Leche entera pasteurizada de alta calidad', 1.50, 'Granja La Pradera')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (1, 'Leche semi-desnatada 1L', 'Leche semi-desnatada pasteurizada de alta calidad', 1.30, 'Granja El Roble')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (1, 'Leche desnatada 1L', 'Leche desnatada pasteurizada de alta calidad', 1.20, 'Granja La Alhambra');
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (1, 'Huevos camperos 6 unidades', 'Huevos camperos de gallinas criadas en libertad', 2.50, 'Granja El Paraíso')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (1, 'Huevos de corral 6 unidades', 'Huevos de gallinas criadas en corrales amplios', 2.00, 'Granja La Montaña')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (1, 'Huevos ecológicos 6 unidades', 'Huevos de gallinas criadas en granjas ecológicas', 3.00, 'Granja El Bosque')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (1, 'Leche de almendras 1L', 'Leche de almendras sin lactosa y baja en calorías', 2.50, 'Marca Almendra');
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (1, 'Leche de soja 1L', 'Leche de soja sin lactosa y rica en proteínas', 2.00, 'Marca Soja');
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (1, 'Leche de avena 1L', 'Leche de avena sin lactosa y rica en fibra', 2.20, 'Marca Avena');
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (1, 'Huevos orgánicos 6 unidades', 'Huevos de gallinas criadas en granjas orgánicas', 3.50, 'Granja La Huerta')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (1, 'Huevos blancos 12 unidades', 'Huevos blancos de gallinas de raza seleccionada', 2.50, 'Granja El Pinar')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (1, 'Leche entera', 'Leche fresca de vaca, en botella de 1 litro', 1.20, 'Central Lechera Asturiana')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (1, 'Leche semidesnatada', 'Leche fresca de vaca, en botella de 1 litro', 1.10, 'Pascual')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (1, 'Leche desnatada', 'Leche fresca de vaca, en botella de 1 litro', 1.00, 'El Corte Inglés')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (1, 'Queso manchego', 'Queso de oveja, curado en bodega', 12.50, 'Artesanos Queseros Manchegos')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (1, 'Queso de cabra', 'Queso de cabra, semicurado en aceite de oliva', 6.80, 'La Antigua')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (1, 'Huevos XL', 'Huevos frescos de gallina, tamaño XL, en pack de 6 unidades', 2.30, 'Campofrío')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (1, 'Huevos M', 'Huevos frescos de gallina, tamaño M, en pack de 12 unidades', 1.50, 'El Granero')
-- SUBCATEGORIA 2
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (2, 'Aceite de oliva extra virgen', 'Aceite de oliva obtenido de aceitunasnarbequina', 10.50, 'Aceitunas S.A.')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (2, 'Vinagre de vino tinto', 'Vinagre elaborado a partir de vino tinto', 3.20, 'Bodega El Palomar')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (2, 'Salsa de soja', 'Salsa oriental elaborada a partir de soja y trigo', 2.50, 'Soya Ltda.')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (2, 'Aceite de girasol', 'Aceite de semillas de girasol prensado en frío', 5.80, 'Girasol S.A.')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (2, 'Vinagre balsámico de Módena', 'Vinagre balsámico de la región italiana de Módena', 7.90, 'Acetaia di Modena')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (2, 'Salsa de tomate', 'Salsa elaborada a partir de tomates frescos y especias', 2.30, 'Tomates del Huerto')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (2, 'Aceite de aguacate', 'Aceite obtenido a partir del aguacate Hass', 8.60, 'Aguacates del Sur')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (2, 'Vinagre de manzana', 'Vinagre elaborado a partir de manzanas frescas', 4.50, 'Manzanas del Valle')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (2, 'Salsa picante', 'Elaborada con chiles y especias', 2.90, 'Chiles del Huerto')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (2, 'Aceite de sésamo', 'Aceite de semillas de sésamo tostadas', 6.20, 'Sésamo Ltda.')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (2, 'Vinagre de arroz', 'Vinagre elaborado a partir de arroz', 3.80, 'Arrozal S.A.')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (2, 'Salsa de curry', 'Salsa de origen indio con mezcla de especias', 4.50, 'Curry del Sur')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (2, 'Aceite de cacahuete', 'Aceite de cacahuetes tostados', 5.90, 'Cacahuetes S.A.')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (2, 'Vinagre de sidra', 'Vinagre elaborado a partir de manzanas de sidra', 6.80, 'Sidrería El Pomar')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (2, 'Salsa de queso azul', 'Salsa cremosa con sabor a queso azul', 3.50, 'Quesos del Valle')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (2, 'Aceite de nuez', 'Aceite de nueces prensadas en frío', 7.60, 'Nueces del Bosque')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (2, 'Vinagre de Jerez', 'Vinagre de la región española de Jerez', 8.50, 'Bodegas La Gitana')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (2, 'Salsa barbacoa', 'Salsa dulce y ahumada para carnes a la parrilla', 2.80, 'Barbacoa S.A.')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (2, 'Aceite de trufa', 'Aceite de oliva con aroma y sabor a trufa negra', 12.50, 'Trufas del Norte')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (2, 'Vinagre de vino blanco', 'Vinagre elaborado a partir de vino blanco', 3.20, 'Bodega El Palomar')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (2, 'Salsa de pesto', 'Salsa italiana con base de albahaca y piñones', 4.90, 'Pesto di Genova')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (2, 'Aceite de romero', 'Aceite de oliva con aroma y sabor a romero', 8.90, 'Romero del Huerto')
