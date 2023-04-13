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
	descripcion NVARCHAR(250) NOT NULL,
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

-- CARRITO
CREATE TABLE carrito
(
	id_usuario INT PRIMARY KEY,
	id_producto INT NOT NULL,
	cantidad INT NOT NULL,
	CONSTRAINT constraint_id_usuario_carrito_fk FOREIGN KEY (id_usuario) REFERENCES usuario (id_usuario),
	CONSTRAINT constraint_id_producto_carrito_fk FOREIGN KEY (id_producto) REFERENCES producto (id_producto)
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
--CATEGORIA 1
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
-- SUBCATEGORIA 3
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (3, 'Galletas de avena', 'Galletas de avena caseras. Ideal para el desayuno', 3.99, 'Productor A')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (3, 'Mermelada de fresa', 'Mermelada de fresa natural y sin conservantes', 4.99, 'Productor B')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (3, 'Cereal de granola', 'Cereal de granola casero, hecho con nueces y miel', 6.99, 'Productor C')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (3, 'Barra de cereales', 'Barra de cereales con chocolate y almendras', 2.49, 'Productor D')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (3, 'Té de jengibre y limón', 'Té de jengibre y limón para despertar refrescante', 3.99, 'Productor E')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (3, 'Café colombiano', 'Café colombiano de origen, con un sabor aromático', 9.99, 'Productor F')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (3, 'Pan de molde integral', 'Pan de molde integral, ideal para el desayuno', 2.99, 'Productor G')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (3, 'Mermelada de arándanos', 'Mermelada de arándanos casera para tostadas', 5.99, 'Productor B')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (3, 'Cereal de copos de maíz', 'Cereal de copos de maíz con un toque de miel', 4.49, 'Productor C')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (3, 'Barra de cereales de avena', 'Barra de cereales de avena con pasas y almendras', 2.99, 'Productor D')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (3, 'Té de menta', 'Té de menta refrescante para empezar el día', 2.99, 'Productor E')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (3, 'Café de especialidad', 'Café de especialidad de origen único', 12.99, 'Productor F')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (3, 'Mermelada de frutos del bosque', 'Mermelada de frutos del bosque con un toque ácido', 6.99, 'Productor B')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (3, 'Cereal de copos de avena', 'Cereal de copos de avena con pasas y nueces', 5.49, 'Productor C')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (3, 'Barra de cereales de frutos secos', 'Barra de cereales de frutos secos con miel', 2.99, 'Productor D')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (3, 'Té de manzanilla', 'Té de manzanilla relajante para antes de dormir', 2.99, 'Productor E')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (3, 'Café de tueste medio', 'Café de tueste medio con cacao y frutos secos', 11.99, 'Productor F')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (3, 'Bollos de leche', 'Bollos de leche suaves y esponjosos', 4.99, 'Productor G')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (3, 'Mermelada de ciruela', 'Mermelada de ciruela casera, con trozos de fruta', 5.99, 'Productor B')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (3, 'Cereal de arroz inflado', 'Cereal de arroz inflado con miel y canela', 3.99, 'Productor C')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (3, 'Barra de cereales de chocolate negro', 'Barra de cereales de chocolate negro con avellanas', 2.49, 'Productor D')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (3, 'Té de rosa mosqueta', 'Té de rosa mosqueta con vitamina C', 3.99, 'Productor E')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (3, 'Café de tueste oscuro', 'Café de tueste oscuro con sabor intenso y ahumado', 10.99, 'Productor F')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (3, 'Galletas de avena y pasas', 'Galletas de avena con pasas', 3.99, 'Productor G')
-- SUBCATEGORIA 4
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (4, 'Conserva de tomate', 'Deliciosa conserva de tomate de primera calidad', 2.50, 'La Huerta')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (4, 'Conserva de pimiento', 'Exquisita conserva de pimiento rojo asado', 3.00, 'La Venta')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (4, 'Conserva de berenjena', 'Deliciosa conserva de berenjena con un toque de ajo', 2.75, 'La Casona')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (4, 'Conserva de alcachofa', 'Deliciosa conserva de alcachofa en aceite de oliva', 4.50, 'La Huerta')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (4, 'Conserva de pimiento rojo', 'Exquisita conserva de pimiento rojo en aceite de oliva', 3.25, 'La Venta')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (4, 'Conserva de champiñón', 'Deliciosa conserva de champiñón en escabeche', 2.90, 'La Casona')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (4, 'Conserva de espárragos', 'Exquisita conserva de espárragos verdes en aceite de oliva', 5.20, 'La Huerta')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (4, 'Conserva de alcachofa y berenjena', 'Deliciosa conserva de alcachofa y berenjena con aceitunas negras', 3.75, 'La Casona')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (4, 'Conserva de tomate y aceitunas', 'Exquisita conserva de tomate con aceitunas verdes y negras', 4.20, 'La Venta')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (4, 'Conserva de pimientos y cebolla', 'Deliciosa conserva de pimientos rojos y cebolla en escabeche', 3.50, 'La Huerta')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (4, 'Conserva de setas y trufa', 'Exquisita conserva de setas y trufa negra en aceite de oliva', 7.50, 'La Casona')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (4, 'Conserva de espárragos y jamón', 'Deliciosa conserva de espárragos verdes con jamón serrano', 6.25, 'La Venta')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (4, 'Conserva de tomate seco', 'Exquisita conserva de tomate seco en aceite de oliva y hierbas provenzales', 5.75, 'La Huerta')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (4, 'Conserva de pimiento y berenjena', 'Deliciosa conserva de pimiento y berenjena en escabeche', 3.50, 'La Casona')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (4, 'Conserva de berenjena y pimiento rojo', 'Exquisita conserva de berenjena y pimiento rojo en aceite de oliva', 4.00, 'La Venta')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (4, 'Conserva de zanahoria', 'Deliciosa conserva de zanahoria en escabeche', 2.50, 'La Huerta')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (4, 'Conserva de calabacín', 'Exquisita conserva de calabacín con un toque de vinagre', 2.90, 'La Casona')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (4, 'Conserva de coliflor', 'Deliciosa conserva de coliflor en escabeche', 3.25, 'La Venta')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (4, 'Conserva de aceitunas', 'Exquisita conserva de aceitunas verdes y negras en aceite de oliva', 2.75, 'La Huerta')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (4, 'Conserva de pimiento y aceitunas', 'Deliciosa conserva de pimiento y aceitunas en escabeche', 3.50, 'La Casona')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (4, 'Conserva de guindillas', 'Exquisita conserva de guindillas en escabeche', 3.00, 'La Venta');
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (4, 'Conserva de pimientos y ajos', 'Deliciosa conserva de pimientos rojos y ajos en aceite de oliva', 4.50, 'La Huerta')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (4, 'Conserva de setas y espárragos', 'Exquisita conserva de setas y espárragos verdes en aceite de oliva', 6.75, 'La Casona')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (4, 'Conserva de tomate y berenjena', 'Deliciosa conserva de tomate y berenjena con un toque de orégano', 4.20, 'La Venta')
-- SUBCATEGORIA 5
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (5, 'Sushi roll', 'Sushi roll de salmón y aguacate', 12.99, 'Sushi Itto')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (5, 'Curry indio', 'Curry de pollo al estilo indio', 14.99, 'Taj Mahal')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (5, 'Tacos mexicanos', 'Tacos de carne asada con salsa picante', 8.99, 'Taco Bell')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (5, 'Pizza italiana', 'Pizza margherita con tomate y queso fresco', 10.99, 'Pizza Hut')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (5, 'Pho vietnamita', 'Pho de ternera con fideos de arroz', 9.99, 'Pho 79')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (5, 'Samosa indio', 'Samosa de vegetales con chutney de menta', 2.99, 'Saffron Indian Cuisine')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (5, 'Paella española', 'Paella de mariscos con arroz y azafrán', 19.99, 'Casa Mono')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (5, 'Hamburguesa americana', 'Hamburguesa con queso, tocino y papas fritas', 11.99, 'Five Guys')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (5, 'Sopa de miso japonés', 'Sopa de miso con tofu y cebolla verde', 4.99, 'Benihana')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (5, 'Pad thai tailandés', 'Pad thai con camarones y cacahuates', 13.99, 'Bangkok Thai')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (5, 'Ramen japonés', 'Ramen de cerdo con huevo y alga nori', 11.99, 'Ippudo')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (5, 'Empanadas argentinas', 'Empanadas de carne con cebolla y huevo', 2.99, 'La Empanada Llama')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (5, 'Kebab turco', 'Kebab de pollo con ensalada y salsa de yogur', 6.99, 'Turkish Kebab House')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (5, 'Gyudon japonés', 'Gyudon de ternera con arroz y cebolla', 8.99, 'Yoshinoya')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (5, 'Fish and chips inglés', 'Fish and chips de merluza con papas fritas', 9.99, 'The Fryers Delight')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (5, 'Enchiladas mexicanas', 'Enchiladas de pollo con salsa verde y queso', 7.99, 'El Torito')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (5, 'Banh mi vietnamita', 'Banh mi de cerdo con zanahoria y cilantro', 5.99, 'Banh Mi Boys')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (5, 'Lasagna italiana', 'Lasagna de carne con salsa boloñesa y queso', 12.99, 'Olive Garden')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (5, 'Arroz con pollo peruano', 'Arroz con pollo a la peruana con cilantro y ajo', 15.99, 'Ceviche 105')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (5, 'Goulash húngaro', 'Goulash de ternera con paprika y patatas', 16.99, 'Budapest Bistro')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (5, 'Croque-monsieur francés', 'Croque-monsieur de jamón y queso gratinado', 7.99, 'Le Pain Quotidien')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (5, 'Fajitas mexicanas', 'Fajitas de carne con pimiento y cebolla', 10.99, 'Chilis')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (5, 'Bibimbap coreano', 'Bibimbap de cerdo con arroz y verduras', 9.99, 'Bibigo')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (5, 'Lomo saltado peruano', 'Lomo saltado con papas fritas y arroz', 17.99, 'Pio Pio')
-- SUBCATEGORIA 6
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (6, 'Proteína en polvo', 'Suplemento de proteína en polvo para la nutrición deportiva', 30.99, 'Optimum Nutrition')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (6, 'Barra de proteína', 'Barra de proteína para la nutrición deportiva', 2.99, 'Quest Nutrition')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (6, 'Multivitamínico', 'Suplemento multivitamínico para la nutrición deportiva', 19.99, 'Garden of Life')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (6, 'BCAA en polvo', 'Suplemento de BCAA en polvo para la nutrición deportiva', 27.99, 'Scivation')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (6, 'Creatina en polvo', 'Suplemento de creatina en polvo para la nutrición deportiva', 12.99, 'MuscleTech')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (6, 'Omega 3', 'Suplemento de omega 3 para la nutrición deportiva', 14.99, 'NOW Foods')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (6, 'Pre-entrenamiento', 'Suplemento pre-entrenamiento para la nutrición deportiva', 29.99, 'Cellucor')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (6, 'Glutamina en polvo', 'Suplemento de glutamina en polvo para la nutrición deportiva', 21.99, 'Optimum Nutrition')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (6, 'Barra de carbohidratos', 'Barra de carbohidratos para la nutrición deportiva', 1.99, 'PowerBar')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (6, 'Caseína en polvo', 'Suplemento de caseína en polvo para la nutrición deportiva', 34.99, 'Dymatize')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (6, 'Cafeína en pastillas', 'Suplemento de cafeína en pastillas para la nutrición deportiva', 9.99, 'Natrol')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (6, 'Aminoácidos esenciales en polvo', 'Suplemento de aminoácidos esenciales en polvo para la nutrición deportiva', 29.99, 'Optimum Nutrition')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (6, 'Galleta de proteína', 'Galleta de proteína para la nutrición deportiva', 2.49, 'Lenny & Larry')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (6, 'Barra energética', 'Barra energética para la nutrición deportiva', 1.79, 'Clif Bar')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (6, 'Batido de proteína', 'Batido de proteína para la nutrición deportiva', 4.99, 'Premier Protein')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (6, 'Quemador de grasa', 'Suplemento quemador de grasa para la nutrición deportiva', 24.99, 'Cellucor')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (6, 'Aislado de proteína de suero', 'Suplemento de aislado de proteína de suero para la nutrición deportiva', 49.99, 'Isopure')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (6, 'Barrita de proteína', 'Barrita de proteína para la nutrición deportiva', 1.99, 'MusclePharm')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (6, 'Probióticos', 'Suplemento de probióticos para la nutrición deportiva', 29.99, 'Renew Life')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (6, 'Bebida isotónica', 'Bebida isotónica para la nutrición deportiva', 2.49, 'Gatorade')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (6, 'Barra de proteína vegana', 'Barra de proteína vegana para la nutrición deportiva', 2.99, 'Vega')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (6, 'Bebida energética', 'Bebida energética para la nutrición deportiva', 2.99, 'Monster Energy')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (6, 'Avena instantánea', 'Avena instantánea para la nutrición deportiva', 4.99, 'Quaker Oats')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (6, 'Barra de proteína sin gluten', 'Barra de proteína sin gluten para la nutrición deportiva', 2.99, 'Kind Snacks')
-- CATEGORIA 2
-- SUBCATEGORIA 7
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (7, 'Tomate', 'Tomate fresco de huerta', 2.5, 'Huerta Don José')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (7, 'Lechuga', 'Lechuga de hoja verde', 1.5, 'Huerta Los Amigos')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (7, 'Cebolla', 'Cebolla blanca dulce', 1.0, 'Huerta La Esperanza')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (7, 'Zanahoria', 'Zanahoria fresca y crujiente', 2.0, 'Huerta San Miguel')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (7, 'Espinacas', 'Espinacas frescas de temporada', 2.5, 'Huerta Las Flores')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (7, 'Pimiento', 'Pimiento rojo y dulce', 3.0, 'Huerta La Palma')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (7, 'Calabacín', 'Calabacín fresco y jugoso', 1.5, 'Huerta El Sol')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (7, 'Patata', 'Patata de piel fina', 1.0, 'Huerta Los Olivos')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (7, 'Berenjena', 'Berenjena morada y firme', 2.0, 'Huerta La Sierra')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (7, 'Ajo', 'Ajo blanco y sabroso', 0.5, 'Huerta El Paraíso')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (7, 'Pepino', 'Pepino fresco y crujiente', 1.5, 'Huerta Los Pinos')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (7, 'Champiñones', 'Champiñones frescos de cultivo', 2.5, 'Huerta El Valle')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (7, 'Coliflor', 'Coliflor fresca de huerta', 2.0, 'Huerta Las Palmas')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (7, 'Brócoli', 'Brócoli fresco y saludable', 2.5, 'Huerta Los Robles')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (7, 'Judías verdes', 'Judías verdes tiernas y frescas', 2.0, 'Huerta El Encanto')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (7, 'Calabaza', 'Calabaza dulce y sabrosa', 2.5, 'Huerta Los Naranjos')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (7, 'Escarola', 'Escarola de hoja rizada', 1.0, 'Huerta La Cruz')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (7, 'Puerro', 'Puerro fresco de temporada', 1.5, 'Huerta Los Girasoles')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (7, 'Rábano', 'Rábano fresco y picante', 1.0, 'Huerta El Arroyo')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (7, 'Coles de Bruselas', 'Coles de Bruselas frescas y saludables', 2.5, 'Huerta Las Amapolas')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (7, 'Hinojo', 'Hinojo fresco y aromático', 2.0, 'Huerta Los Fresnos')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (7, 'Alcachofa', 'Alcachofa fresca y sabrosa', 3.0, 'Huerta La Montaña')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (7, 'Acelga', 'Acelga fresca de huerta', 1.5, 'Huerta Las Margaritas')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (7, 'Col', 'Col fresca y crujiente', 2.0, 'Huerta La Pradera')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (7, 'Rúcula', 'Rúcula fresca y sabrosa', 2.5, 'Huerta El Bosque')
-- SUBCATEGORIA 8
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (8, 'Queso Gouda', 'Queso de origen holandés, de pasta prensada no cocida y sabor suave.', 12.99, 'Fábrica de quesos La Holandesa')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (8, 'Queso Roquefort', 'Queso francés de pasta azul con sabor fuerte y característico.', 15.99, 'Fábrica de quesos Société')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (8, 'Queso Parmesano', 'Queso italiano de pasta dura y granulosa, ideal para rallar.', 9.99, 'Fábrica de quesos Parmigiano Reggiano')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (8, 'Queso Cheddar', 'Queso inglés de pasta prensada, color amarillo y sabor suave.', 11.99, 'Fábrica de quesos Cabot')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (8, 'Queso Brie', 'Queso francés de pasta blanda y corteza blanca comestible.', 14.99, 'Fábrica de quesos President')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (8, 'Queso Gorgonzola', 'Queso italiano de pasta azul y sabor picante.', 13.99, 'Fábrica de quesos Galbani')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (8, 'Queso Manchego', 'Queso español de pasta dura y sabor intenso.', 16.99, 'Fábrica de quesos Manchego')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (8, 'Queso Edam', 'Queso de origen holandés de pasta semidura y sabor suave.', 10.99, 'Fábrica de quesos Edam')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (8, 'Queso Emmental', 'Queso suizo de pasta prensada, agujereado y sabor dulce.', 13.99, 'Fábrica de quesos Emmental')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (8, 'Queso Feta', 'Queso griego de pasta blanda y sabor salado.', 9.99, 'Fábrica de quesos Dodoni')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (8, 'Queso Fontina', 'Queso italiano de pasta semiblanda y sabor delicado.', 12.99, 'Fábrica de quesos Fontina')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (8, 'Queso Gouda Viejo', 'Queso holandés de pasta prensada no cocida, con sabor intenso y madurado por varios meses.', 18.99, 'Fábrica de quesos La Holandesa')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (8, 'Queso de Cabra', 'Queso de leche de cabra de pasta blanda y sabor característico.', 13.99, 'Fábrica de quesos Caprichos del Pastor')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (8, 'Queso Azul', 'Queso de pasta azul con sabor fuerte y notas picantes.', 14.99, 'Fábrica de quesos Valdeón')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (8, 'Queso Provolone', 'Queso italiano de pasta hilada y sabor ahumado.', 11.99, 'Fábrica de quesos Auricchio')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (8, 'Queso Ricotta', 'Queso italiano de pasta blanca, suave y granulosa, elaborado con suero de leche.', 8.99, 'Fábrica de quesos Calabro')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (8, 'Queso Panela', 'Queso mexicano de pasta blanda y sabor suave, ideal para derretir.', 9.99, 'Fábrica de quesos Panela')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (8, 'Queso Cottage', 'Queso de origen inglés de pasta blanda, granulosa y bajo contenido de grasa.', 7.99, 'Fábrica de quesos Friendship Dairies')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (8, 'Queso Chihuahua', 'Queso mexicano de pasta semidura y sabor suave, similar al queso cheddar.', 10.99, 'Fábrica de quesos Chihuahua')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (8, 'Queso Tilsit', 'Queso alemán de pasta semidura y sabor suave, con notas a nuez.', 13.99, 'Fábrica de quesos Tilsit')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (8, 'Queso Cottage con Hierbas', 'Queso de pasta blanda, granulosa y bajo contenido de grasa, con hierbas finas.', 8.99, 'Fábrica de quesos Friendship Dairies')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (8, 'Queso Parmesano', 'Queso italiano de pasta dura y sabor intenso, ideal para rallar.', 16.99, 'Fábrica de quesos Parmigiano Reggiano')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (8, 'Queso Manchego', 'Queso español de pasta dura y sabor característico, elaborado con leche de oveja.', 14.99, 'Fábrica de quesos Manchego')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (8, 'Queso de Cabra con Miel', 'Queso de leche de cabra de pasta blanda y sabor suave, con miel añadida.', 15.99, 'Fábrica de quesos Caprichos del Pastor')
-- SUBCATEGORIA 9
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (9, 'Carne de res premium', 'Carne de res de alta calidad, perfecta para asados y parrilladas', 25.99, 'Carnes Finas SA de CV')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (9, 'Filete de res', 'Filete de res tierno y jugoso, ideal para preparaciones gourmet', 32.99, 'Carnes de la Finca')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (9, 'Costillas de cerdo', 'Costillas de cerdo marinadas y listas para cocinar en el horno o a la parrilla', 18.99, 'Carnes San Miguel')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (9, 'Carne molida de res', 'Carne molida de res de primera calidad, perfecta para preparar hamburguesas y tacos', 12.99, 'Carnes de la Frontera')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (9, 'Lomo de cerdo', 'Lomo de cerdo fresco y suave, ideal para guisados y estofados', 20.99, 'Carnes San Lucas')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (9, 'Bistec de res', 'Bistec de res jugoso y tierno, perfecto para asar o cocinar en la sartén', 22.99, 'Carnes de la Montaña')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (9, 'Chorizo de cerdo', 'Chorizo de cerdo picante y delicioso, perfecto para preparar tacos y antojitos', 9.99, 'Carnes de la Sierra')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (9, 'Milanesa de res', 'Milanesa de res empanizada y lista para freír, perfecta para hacer un sándwich de milanesa', 15.99, 'Carnes de la Costa')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (9, 'Chuletas de cerdo', 'Chuletas de cerdo frescas y deliciosas, ideales para asar a la parrilla o cocinar en el horno', 16.99, 'Carnes de la Pradera')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (9, 'Carne para tacos al pastor', 'Carne de cerdo marinada y lista para cocinar en el trompo, perfecta para hacer tacos al pastor', 14.99, 'Carnes de la Huasteca')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (9, 'Arrachera marinada', 'Arrachera de res marinada y lista para asar, perfecta para preparar fajitas o tacos de arrachera', 28.99, 'Carnes de la Tierra Caliente')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (9, 'Chuletón de res', 'Chuletón de res grueso y sabroso, ideal para asar en la parrilla', 35.99, 'Carnes de la Sierra Madre')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (9, 'Carnitas de cerdo', 'Carnitas de cerdo suaves y jugosas, perfectas para hacer tacos o tortas', 17.99, 'Carnes del Valle')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (9, 'Costillitas de res', 'Costillitas de res tiernas y con mucho sabor, ideales para cocinar en la olla o en el horno', 21.99, 'Carnes del Rancho')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (9, 'Tacos de lengua', 'Tacos de lengua de res cocida y deshebrada, perfectos para los amantes de los tacos de lengua', 12.99, 'Carnes de la Región')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (9, 'Cecina de res', 'Cecina de res curada y lista para cocinar, ideal para hacer tacos o preparar antojitos', 18.99, 'Carnes de la Tradición')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (9, 'Puntas de filete', 'Puntas de filete de res suaves y jugosas, perfectas para saltear o cocinar en la sartén', 19.99, 'Carnes del Oriente')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (9, 'Pierna de cerdo', 'Pierna de cerdo fresca y jugosa, ideal para hornear o cocinar en el asador', 23.99, 'Carnes del Occidente')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (9, 'Tacos de suadero', 'Tacos de suadero de res suave y delicioso, perfectos para hacer una taquiza', 14.99, 'Carnes de la Costa del Pacífico')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (9, 'Machaca de res', 'Machaca de res seca y deshebrada, perfecta para preparar machacado con huevo', 9.99, 'Carnes del Altiplano')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (9, 'Ternera', 'Ternera tierna y suave, perfecta para cocinar a la plancha o en el horno', 29.99, 'Carnes de la Montaña')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (9, 'Corte Ribeye', 'Corte Ribeye de res, jugoso y lleno de sabor, ideal para asar en la parrilla', 42.99, 'Carnes del Rancho')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (9, 'Pollo entero', 'Pollo entero fresco y listo para cocinar, ideal para hornear o hacer a la parrilla', 14.99, 'Carnes del Valle')
-- SUBCATEGORIA 10
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (10, 'Jamón Serrano', 'Delicioso jamón curado de cerdo serrano', 12.99, 'Embutidos La Pradera')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (10, 'Chorizo Ibérico', 'Chorizo de cerdo ibérico con un sabor intenso y picante', 7.99, 'Embutidos La Montaña')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (10, 'Salchichón de Vic', 'Salchichón artesanal de cerdo de la región de Vic', 9.99, 'Embutidos La Cumbre')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (10, 'Lomo Embuchado', 'Lomo de cerdo embuchado y curado', 14.99, 'Embutidos La Sierra')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (10, 'Butifarra Catalana', 'Butifarra blanca de cerdo típica de Cataluña', 5.99, 'Embutidos Els Porquets')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (10, 'Fuet de Vic', 'Fuet de cerdo curado de la región de Vic', 6.99, 'Embutidos La Fonda')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (10, 'Longaniza de Aragón', 'Longaniza artesanal de cerdo de Aragón', 8.99, 'Embutidos La Artesana')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (10, 'Sobrasada Mallorquina', 'Sobrasada típica de Mallorca hecha con carne de cerdo y pimentón', 10.99, 'Embutidos El Castillo')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (10, 'Mortadela de Bolonia', 'Mortadela italiana hecha con carne de cerdo y pistachos', 6.99, 'Embutidos La Bella Italia')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (10, 'Salami Milano', 'Salami italiano con un sabor suave y ligeramente picante', 7.99, 'Embutidos Milano')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (10, 'Panceta Curada', 'Panceta de cerdo curada con sal y especias', 11.99, 'Embutidos La Curación')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (10, 'Cecina de León', 'Cecina de vacuno curada y ahumada de la región de León', 16.99, 'Embutidos La Montaña')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (10, 'Chistorra Navarra', 'Chistorra de cerdo de la región de Navarra con un sabor intenso y picante', 9.99, 'Embutidos El Caserío')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (10, 'Jamón Ibérico', 'Jamón curado de cerdo ibérico con un sabor y aroma únicos', 29.99, 'Embutidos La Dehesa')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (10, 'Lacón Gallego', 'Lacón de cerdo gallego salado y curado', 12.99, 'Embutidos A Rúa')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (10, 'Queso Manchego', 'Queso de oveja curado de la región de La Mancha', 8.99, 'Quesos El Valle')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (10, 'Queso de Cabra', 'Queso de cabra semicurado con un sabor intenso y cremoso', 7.99, 'Quesos La Montaña')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (10, 'Queso Azul', 'Queso azul de leche de vaca con un sabor fuerte y picante', 9.99, 'Quesos La Roquefort')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (10, 'Aceitunas rellenas', 'Aceitunas verdes rellenas de anchoa', 4.99, 'Conservas La Española')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (10, 'Paté de Campaña', 'Paté de hígado de cerdo con un toque de cognac', 6.99, 'Conservas La Granja')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (10, 'Anchoas del Cantábrico', 'Anchoas del Cantábrico en aceite de oliva', 16.99, 'Conservas La Lata')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (10, 'Sardinas en aceite', 'Sardinas en aceite de oliva de las Rías Gallegas', 5.99, 'Conservas El Faro')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (10, 'Mermelada de higos', 'Mermelada casera de higos frescos', 4.99, 'Dulces La Abuela')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (10, 'Turrón de Jijona', 'Turrón blando de almendras y miel de la región de Jijona', 7.99, 'Dulces El Artesano')
-- SUBCATEGORIA 11
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (11, 'Atún', 'Atún fresco de la costa del Pacífico, ideal para cocinar a la parrilla o en sushi', 25.99, 'Pescados del Pacífico')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (11, 'Langostinos', 'Langostinos frescos de la costa del Atlántico, ideales para cocinar a la parrilla o en guisos', 29.99, 'Pescados y Mariscos del Atlántico')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (11, 'Pulpo', 'Pulpo fresco de Galicia, ideal para cocinar a la parrilla o en guisos', 34.99, 'Pescados y Mariscos Gallegos')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (11, 'Gambas', 'Gambas frescas de la costa andaluza, ideales para cocinar a la parrilla o en guisos', 22.99, 'Mariscos del Sur')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (11, 'Cangrejos', 'Cangrejos frescos de la costa gallega, ideales para cocinar a la parrilla o en guisos', 39.99, 'Pescados y Mariscos Gallegos')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (11, 'Salmón', 'Salmón fresco de la costa del Atlántico, ideal para cocinar a la parrilla o en sushi', 18.99, 'Pescados del Atlántico')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (11, 'Vieiras', 'Vieiras frescas de la costa gallega, ideales para cocinar a la parrilla o en guisos', 42.99, 'Pescados y Mariscos Gallegos')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (11, 'Percebes', 'Percebes frescos de la costa gallega, ideales para cocinar al vapor o comer en crudo', 89.99, 'Pescados y Mariscos Gallegos')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (11, 'Merluza', 'Merluza fresca de la costa del Atlántico, ideal para cocinar a la parrilla o en guisos', 13.99, 'Pescados del Atlántico')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (11, 'Bacalao', 'Bacalao fresco de la costa del Atlántico, ideal para cocinar a la parrilla o en guisos', 21.99, 'Pescados del Atlántico')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (11, 'Mejillones', 'Mejillones frescos de la costa gallega, ideales para cocinar al vapor o en guisos', 8.99, 'Pescados y Mariscos Gallegos')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (11, 'Pargo', 'Pargo fresco de la costa del Pacífico, ideal para cocinar a la parrilla o en guisos', 27.99, 'Pescados del Pacífico')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (11, 'Ostras', 'Ostras frescas de la costa atlántica, ideales para comer en crudo o cocidas', 47.99, 'Pescados y Mariscos del Atlántico')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (11, 'Calamar gigante', 'Calamar gigante fresco del Mediterráneo, ideal para cocinar a la parrilla o en guisos', 59.99, 'Mariscos del Sur')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (11, 'Camarones', 'Camarones frescos de la costa del Pacífico, ideales para cocinar a la parrilla o en guisos', 31.99, 'Pescados del Pacífico')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (11, 'Bogavante', 'Bogavante fresco de la costa del Atlántico, ideal para cocinar a la parrilla o en guisos', 69.99, 'Pescados y Mariscos del Atlántico')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (11, 'Pez espada', 'Pez espada fresco de la costa del Pacífico, ideal para cocinar a la parrilla o en guisos', 23.99, 'Pescados del Pacífico')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (11, 'Almejas', 'Almejas frescas de la costa gallega, ideales para cocinar al vapor o en guisos', 12.99, 'Pescados y Mariscos Gallegos')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (11, 'Cigalas', 'Cigalas frescas de la costa mediterránea, ideales para cocinar a la parrilla o en guisos', 45.99, 'Mariscos del Sur')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (11, 'Lenguado', 'Lenguado fresco de la costa del Atlántico, ideal para cocinar a la parrilla o en guisos', 16.99, 'Pescados del Atlántico')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (11, 'Calamares', 'Calamares frescos del Mediterráneo, ideales para cocinar a la parrilla o en guisos', 8.99, 'Mariscos del Sur')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (11, 'Langosta', 'Langosta fresca de la costa del Atlántico, ideal para cocinar a la parrilla o en guisos', 89.99, 'Pescados y Mariscos del Atlántico')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (11, 'Gambas', 'Gambas frescas de la costa mediterránea, ideales para cocinar a la parrilla o en guisos', 24.99, 'Mariscos del Sur')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (11, 'Pulpo', 'Pulpo fresco de la costa gallega, ideal para cocinar a la parrilla o en guisos', 19.99, 'Pescados y Mariscos Gallegos')
-- SUBCATEGORIA 12
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (12, 'Sushi Roll California', 'Rollo de sushi relleno de aguacate, cangrejo, pepino y mayonesa japonesa.', 8.99, 'Sushi World')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (12, 'Sushi Roll Tempura', 'Rollo de sushi frito relleno de camarones tempura, aguacate, queso crema y cebolla verde.', 10.99, 'Sushi Time')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (12, 'Sashimi de Salmón', 'Lonjas finas de salmón fresco cortado en forma de abanico.', 12.50, 'Sushi Bar')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (12, 'Nigiri de Atún', 'Bola de arroz cubierta con una fina lámina de atún fresco.', 6.99, 'Sushi World')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (12, 'Gyoza de camarón', 'Empanadilla japonesa rellena de camarones y verduras.', 5.99, 'Sushi Time')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (12, 'Uramaki de Aguacate', 'Rollo de sushi invertido con aguacate, pepino y queso crema.', 7.99, 'Sushi Bar')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (12, 'Temaki de Atún Picante', 'Cucurucho de alga nori relleno de arroz, atún picante, aguacate y cebolla verde.', 9.50, 'Sushi World')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (12, 'Edamame', 'Vainas de soja salteadas con sal marina.', 3.99, 'Sushi Time')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (12, 'Yakitori de Pollo', 'Brochetas de pollo marinadas y asadas a la parrilla.', 4.99, 'Sushi Bar')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (12, 'Rollito de Primavera', 'Rollos crujientes rellenos de vegetales y fideos de arroz.', 3.99, 'Sushi World')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (12, 'Tartar de Salmón', 'Dados de salmón fresco marinados con soja, jengibre y cebolla.', 11.99, 'Sushi Time')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (12, 'Gunkan de Ikura', 'Bolas de arroz envueltas en alga nori y coronadas con huevas de salmón.', 9.99, 'Sushi Bar')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (12, 'Tempura de Camarones', 'Camarones rebozados en masa de tempura y fritos hasta dorar.', 13.50, 'Sushi World')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (12, 'Uramaki de Philadelphia', 'Rollo de sushi invertido con salmón ahumado, queso crema y aguacate.', 8.99, 'Sushi Time')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (12, 'Tataki de Atún', 'Atún fresco sellado y cortado en rodajas finas, servido con salsa de soja y jengibre.', 15.99, 'Sushi Bar')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (12, 'Nigiri de Salmón', 'Bola de arroz cubierta con una fina lámina de salmón fresco.', 7.99, 'Sushi World')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (12, 'Rollitos de Papel de Arroz', 'Rollitos de papel de arroz rellenos de camarones, lechuga, menta y fideos de arroz.', 6.50, 'Sushi Time')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (12, 'Uramaki de Spicy Tuna', 'Rollo de sushi invertido con atún picante, aguacate y cebolla verde.', 9.99, 'Sushi Bar')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (12, 'Sunomono de Pulpo', 'Ensalada de pulpo cocido con pepino, cebolla morada y vinagre de arroz.', 12.99, 'Sushi World')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (12, 'Tempura de Vegetales', 'Vegetales variados rebozados en masa de tempura y fritos hasta dorar.', 6.99, 'Sushi Time')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (12, 'Sushi Roll Dragón', 'Rollo de sushi frito relleno de langostinos, aguacate, queso crema y cubierto con anguila.', 14.99, 'Sushi Bar')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (12, 'Nigiri de Vieira', 'Bola de arroz cubierta con una fina lámina de vieira fresca.', 9.99, 'Sushi World')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (12, 'Tartar de Atún', 'Dados de atún fresco marinados con soja, jengibre y cebolla.', 13.99, 'Sushi Time')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (12, 'Sake Nigiri', 'Bola de arroz cubierta con una fina lámina de salmón fresco.', 8.50, 'Sushi Bar')
-- CATEGORIA 3
-- SUBCATEGORIA 13
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (13, 'Pizza Congelada de Queso', 'Pizza congelada de queso mozzarella y salsa de tomate', 5.99, 'Marca Congelados')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (13, 'Hamburguesas Vegetarianas Congeladas', 'Hamburguesas vegetarianas a base de soja y verduras congeladas', 3.99, 'Marca Congelados')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (13, 'Empanadillas de Pollo y Verduras Congeladas', 'Empanadillas rellenas de pollo y verduras congeladas', 2.99, 'Marca Congelados')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (13, 'Croquetas de Jamón Congeladas', 'Croquetas de jamón serrano congeladas', 4.99, 'Marca Congelados')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (13, 'Pescado Congelado Meunière', 'Filetes de pescado congelado con una capa de pan rallado y mantequilla', 6.99, 'Marca Congelados')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (13, 'Verduras Congeladas para Saltear', 'Mezcla de verduras congeladas para saltear', 1.99, 'Marca Congelados')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (13, 'Pizzas Congeladas de Pepperoni', 'Pizzas congeladas de pepperoni y queso', 5.99, 'Marca Congelados')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (13, 'Langostinos Congelados', 'Langostinos congelados crudos', 8.99, 'Marca Congelados')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (13, 'Ensaladilla Rusa Congelada', 'Ensaladilla rusa congelada con mayonesa', 3.99, 'Marca Congelados')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (13, 'Filetes de Pollo Congelados', 'Filetes de pollo congelados', 7.99, 'Marca Congelados')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (13, 'Arroz Tres Delicias Congelado', 'Arroz tres delicias congelado', 2.99, 'Marca Congelados')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (13, 'Cazuela de Mariscos Congelada', 'Cazuela de mariscos congelada', 9.99, 'Marca Congelados')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (13, 'Cazuela de Mariscos Congelada', 'Cazuela de mariscos congelada', 9.99, 'Marca Congelados')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (13, 'Judías Verdes Congeladas', 'Judías verdes congeladas', 1.99, 'Marca Congelados')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (13, 'Lasaña Congelada', 'Lasaña de carne congelada', 6.99, 'Marca Congelados')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (13, 'Pollo al Limón Congelado', 'Pollo al limón congelado', 7.99, 'Marca Congelados')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (13, 'Pescado Congelado a la Parrilla', 'Filetes de pescado congelado a la parrilla', 6.99, 'Marca Congelados')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (13, 'Tarta de Manzana Congelada', 'Tarta de manzana congelada', 4.99, 'Marca Congelados')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (13, 'Gambas Congeladas', 'Gambas congeladas crudas', 10.99, 'Marca Congelados')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (13, 'Patatas Fritas Congeladas', 'Patatas fritas congeladas', 1.99, 'Marca Congelados')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (13, 'Cazuela de Pollo Congelada', 'Cazuela de pollo congelada', 7.99, 'Marca Congelados')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (13, 'Canelones Congelados', 'Canelones de carne congelados', 6.99, 'Marca Congelados')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (13, 'Bacalao Congelado', 'Bacalao congelado', 8.99, 'Marca Congelados')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (13, 'Pollo al Curry Congelado', 'Pollo al curry congelado', 7.99, 'Marca Congelados')
-- SUBCATEGORIA 14
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (14, 'Tarta de Chocolate', 'Tarta de chocolate con bizcocho y crema de chocolate', 7.99, 'Postres del Chef')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (14, 'Tarta de Queso', 'Tarta de queso cremosa con base de galleta', 6.99, 'Postres del Chef')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (14, 'Tarta de Limón', 'Tarta de limón con merengue y base de masa quebrada', 8.99, 'Postres del Chef')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (14, 'Helado de Vainilla', 'Helado cremoso de vainilla', 3.99, 'Helados San Francisco')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (14, 'Helado de Chocolate', 'Helado cremoso de chocolate', 3.99, 'Helados San Francisco')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (14, 'Helado de Fresa', 'Helado cremoso de fresa', 3.99, 'Helados San Francisco')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (14, 'Mousse de Chocolate', 'Mousse de chocolate con nata y bizcocho', 4.99, 'Postres del Chef')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (14, 'Tarta de Manzana', 'Tarta de manzana con base de masa quebrada', 6.99, 'Postres del Chef')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (14, 'Natillas', 'Natillas de vainilla con galleta y canela', 2.99, 'Postres del Chef')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (14, 'Coulant de Chocolate', 'Bizcocho caliente de chocolate con helado de vainilla', 7.99, 'Postres del Chef')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (14, 'Cheesecake de Fresa', 'Cheesecake con base de galleta y fresas frescas', 8.99, 'Postres del Chef')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (14, 'Tarta de Tiramisú', 'Tarta de tiramisú con bizcocho, café y mascarpone', 7.99, 'Postres del Chef')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (14, 'Gofres con Nata y Chocolate', 'Gofres recién hechos con nata y sirope de chocolate', 4.99, 'Postres del Chef')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (14, 'Tarta de Frutas', 'Tarta de frutas frescas con base de masa quebrada', 8.99, 'Postres del Chef')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (14, 'Crema Catalana', 'Crema catalana con caramelo quemado', 5.99, 'Postres del Chef')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (14, 'Flan de Huevo', 'Flan de huevo casero con caramelo', 3.99, 'Postres del Chef')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (14, 'Tarta de Santiago', 'Tarta de almendra típica de Galicia', 7.99, 'Postres del Chef')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (14, 'Brownie de Chocolate', 'Brownie de chocolate con nueces y helado de vainilla', 6.99, 'Postres del Chef')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (14, 'Tarta de Tres Leches', 'Tarta de bizcocho bañado en tres leches y nata', 8.99, 'Postres del Chef')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (14, 'Tarta de Chocolate Blanco', 'Tarta de chocolate blanco con fresas frescas', 7.99, 'Postres del Chef')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (14, 'Tarta de Zanahoria', 'Tarta de zanahoria con nueces y queso crema', 6.99, 'Postres del Chef')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (14, 'Helado de Turrón', 'Helado cremoso de turrón', 3.99, 'Helados San Francisco')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (14, 'Mousse de Fresa', 'Mousse de fresa con nata y bizcocho', 4.99, 'Postres del Chef')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (14, 'Gelatina de Limón', 'Gelatina de limón con trozos de fruta', 2.99, 'Postres del Chef')
-- SUBCATEGORIA 15
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (15, 'Pastel de Chocolate', 'Pastel de chocolate con capas de ganache y frutas', 12.99, 'Pasteles de la Abuela')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (15, 'Pastel de Vainilla', 'Pastel de vainilla con frosting de queso crema', 9.99, 'Pasteles de la Abuela')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (15, 'Pastel de Fresa', 'Pastel de fresa con relleno de crema y decoración de merengue', 10.99, 'Pasteles de la Abuela')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (15, 'Pastel de Zanahoria', 'Pastel de zanahoria con frosting de queso crema', 11.99, 'Pasteles de la Abuela')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (15, 'Pastel de Manzana', 'Pastel de manzana con canela y nueces', 8.99, 'Pasteles de la Abuela')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (15, 'Pastel de Crepas', 'Pastel de crepas con relleno de frutas y crema batida', 14.99, 'Pasteles de la Abuela')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (15, 'Tarta de Queso', 'Tarta de queso horneada con base de galleta', 12.99, 'Pasteles de la Abuela')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (15, 'Tarta de Limón', 'Tarta de limón con base de galleta y merengue', 11.99, 'Pasteles de la Abuela')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (15, 'Torta de Tres Leches', 'Torta de bizcocho bañado en tres leches y decoración de frutas', 13.99, 'Pasteles de la Abuela')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (15, 'Tarta de Frutas', 'Tarta de frutas frescas con base de masa quebrada', 15.99, 'Pasteles de la Abuela')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (15, 'Tarta Selva Negra', 'Tarta de chocolate con cerezas y crema', 14.99, 'Pasteles de la Abuela')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (15, 'Pastel de Caramelo', 'Pastel de caramelo con frosting de crema de mantequilla', 11.99, 'Pasteles de la Abuela')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (15, 'Tarta de Manzana', 'Tarta de manzana con canela y crumble', 10.99, 'Pasteles de la Abuela')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (15, 'Tarta de Queso y Frambuesa', 'Tarta de queso con topping de frambuesas', 13.99, 'Pasteles de la Abuela')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (15, 'Pastel de Canela y Nuez', 'Pastel de canela y nuez con frosting de queso crema', 12.99, 'Pasteles de la Abuela')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (15, 'Tarta de Chocolate y Avellanas', 'Tarta de chocolate y avellanas con base de galleta', 14.99, 'Pasteles de la Abuela')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (15, 'Pastel de Coco', 'Pastel de coco con frosting de coco', 9.99, 'Pasteles de la Abuela')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (15, 'Torta de Almendras', 'Torta de almendras con base de bizcocho', 11.99, 'Pasteles de la Abuela')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (15, 'Tarta de Limón y Merengue', 'Tarta de limón con merengue suizo', 13.99, 'Pasteles de la Abuela')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (15, 'Pastel de Naranja', 'Pastel de naranja con frosting de queso crema', 10.99, 'Pasteles de la Abuela')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (15, 'Tarta de Peras y Almendras', 'Tarta de peras y almendras con base de masa quebrada', 15.99, 'Pasteles de la Abuela')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (15, 'Tarta de Arándanos', 'Tarta de arándanos con base de galleta', 12.99, 'Pasteles de la Abuela')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (15, 'Tarta de Fresas y Crema', 'Tarta de fresas con crema batida', 14.99, 'Pasteles de la Abuela')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (15, 'Pastel de Miel', 'Pastel de miel con frosting de queso crema', 11.99, 'Pasteles de la Abuela')
-- SUBCATEGORIA 16
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (16, 'Mantequilla sin Sal Marca A', 'Mantequilla sin sal de alta calidad', 2.99, 'Marca A')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (16, 'Mantequilla con Sal Marca A', 'Mantequilla con sal de alta calidad', 2.99, 'Marca A')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (16, 'Mantequilla sin Sal Marca B', 'Mantequilla sin sal de alta calidad', 3.49, 'Marca B')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (16, 'Mantequilla con Sal Marca B', 'Mantequilla con sal de alta calidad', 3.49, 'Marca B')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (16, 'Mantequilla sin Sal Marca C', 'Mantequilla sin sal de alta calidad', 3.99, 'Marca C')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (16, 'Mantequilla con Sal Marca C', 'Mantequilla con sal de alta calidad', 3.99, 'Marca C')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (16, 'Margarina sin Sal Marca A', 'Margarina sin sal de alta calidad', 1.99, 'Marca A')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (16, 'Margarina con Sal Marca A', 'Margarina con sal de alta calidad', 1.99, 'Marca A')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (16, 'Margarina sin Sal Marca B', 'Margarina sin sal de alta calidad', 2.49, 'Marca B')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (16, 'Margarina con Sal Marca B', 'Margarina con sal de alta calidad', 2.49, 'Marca B')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (16, 'Margarina sin Sal Marca C', 'Margarina sin sal de alta calidad', 2.99, 'Marca C')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (16, 'Margarina con Sal Marca C', 'Margarina con sal de alta calidad', 2.99, 'Marca C')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (16, 'Margarina de Ajo Marca A', 'Margarina de ajo de alta calidad', 2.49, 'Marca A')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (16, 'Margarina de Ajo Marca B', 'Margarina de ajo de alta calidad', 2.99, 'Marca B')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (16, 'Margarina de Ajo Marca C', 'Margarina de ajo de alta calidad', 3.49, 'Marca C')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (16, 'Margarina de Hierbas Finas Marca A', 'Margarina de hierbas finas de alta calidad', 2.49, 'Marca A')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (16, 'Margarina de Hierbas Finas Marca B', 'Margarina de hierbas finas de alta calidad', 2.99, 'Marca B')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (16, 'Margarina de Hierbas Finas Marca C', 'Margarina de hierbas finas de alta calidad', 3.49, 'Marca C')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (16, 'Margarina con Aceite de Oliva Marca A', 'Margarina con aceite de oliva de alta calidad', 2.99, 'Marca A')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (16, 'Margarina con Aceite de Oliva Marca B', 'Margarina con aceite de oliva de alta calidad', 3.49, 'Marca B')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (16, 'Margarina con Aceite de Oliva Marca C', 'Margarina con aceite de oliva de alta calidad', 3.99, 'Marca C')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (16, 'Nata Líquida sin Lactosa Marca A', 'Nata líquida sin lactosa de alta calidad', 4.49, 'Marca A')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (16, 'Nata Líquida sin Lactosa Marca B', 'Nata líquida sin lactosa de alta calidad', 4.99, 'Marca B')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (16, 'Nata Líquida sin Lactosa Marca C', 'Nata líquida sin lactosa de alta calidad', 5.49, 'Marca C')
-- SUBCATEGORIA 17
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (17, 'Arroz con pollo', 'Plato preparado de arroz con pollo', 5.99, 'Knorr')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (17, 'Fideos con salsa boloñesa', 'Plato preparado de fideos con salsa boloñesa', 4.99, 'Maggi')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (17, 'Lasaña de carne', 'Plato preparado de lasaña de carne', 6.99, 'Buitoni')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (17, 'Pollo al curry', 'Plato preparado de pollo al curry', 7.99, 'Knorr')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (17, 'Macarrones con queso', 'Plato preparado de macarrones con queso', 3.99, 'Kraft')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (17, 'Estofado de ternera', 'Plato preparado de estofado de ternera', 8.99, 'Campofrío')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (17, 'Puré de patatas con carne', 'Plato preparado de puré de patatas con carne', 4.49, 'Maggi')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (17, 'Guiso de lentejas', 'Plato preparado de guiso de lentejas', 6.49, 'Knorr')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (17, 'Paella de marisco', 'Plato preparado de paella de marisco', 9.99, 'Buitoni')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (17, 'Pollo al horno con patatas', 'Plato preparado de pollo al horno con patatas', 7.49, 'Campofrío')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (17, 'Sopa de pollo', 'Plato preparado de sopa de pollo', 2.99, 'Knorr')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (17, 'Ensalada de pasta', 'Plato preparado de ensalada de pasta', 3.99, 'Maggi')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (17, 'Chili con carne', 'Plato preparado de chili con carne', 5.99, 'Campofrío')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (17, 'Risotto de setas', 'Plato preparado de risotto de setas', 6.99, 'Buitoni')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (17, 'Risotto de setas', 'Plato preparado de risotto de setas', 6.99, 'Buitoni')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (17, 'Judías verdes con jamón', 'Plato preparado de judías verdes con jamón', 4.49, 'Maggi')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (17, 'Cuscús con pollo', 'Plato preparado de cuscús con pollo', 7.49, 'Knorr')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (17, 'Empanada de atún', 'Plato preparado de empanada de atún', 5.99, 'Buitoni')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (17, 'Garbanzos con espinacas', 'Plato preparado de garbanzos con espinacas', 4.99, 'Campofrío')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (17, 'Pizza cuatro quesos', 'Plato preparado de pizza cuatro quesos', 8.99, 'Buitoni')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (17, 'Cazuela de pollo', 'Plato preparado de cazuela de pollo', 6.99, 'Campofrío')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (17, 'Salteado de verduras', 'Plato preparado de salteado de verduras', 5.49, 'Knorr')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (17, 'Gazpacho', 'Plato preparado de gazpacho', 3.99, 'Maggi')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (17, 'Tortilla de patatas', 'Plato preparado de tortilla de patatas', 4.99, 'Campofrío')
-- SUBCATEGORIA 18
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (18, 'Fideos', 'Fideos largos y delgados hechos con harina de trigo', 1.50, 'Marca A')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (18, 'Tallarines', 'Fideos planos y anchos hechos con harina de trigo', 2.00, 'Marca B')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (18, 'Espaguetis', 'Fideos largos y delgados con forma cilíndrica hechos con harina de trigo', 1.75, 'Marca C')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (18, 'Lasaña', 'Placas de pasta para hacer lasaña hechas con harina de trigo', 3.50, 'Marca D')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (18, 'Canelones', 'Tubos de pasta para hacer canelones hechos con harina de trigo', 3.00, 'Marca E')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (18, 'Ñoquis', 'Bolas pequeñas de pasta hechas con harina de trigo y patata', 2.50, 'Marca F')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (18, 'Fusilli', 'Pasta corta con forma de hélice hecha con harina de trigo', 1.90, 'Marca G')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (18, 'Spätzle', 'Pasta típica de la cocina alemana hecha con harina de trigo y huevo', 4.00, 'Marca H')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (18, 'Raviolis', 'Pasta rellena con forma de cuadrado hecha con harina de trigo y queso', 3.50, 'Marca I')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (18, 'Tortellini', 'Pasta rellena con forma de anillo hecha con harina de trigo y carne', 3.75, 'Marca J')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (18, 'Tagliatelle', 'Fideos planos y anchos hechos con harina de trigo y huevo', 2.50, 'Marca K')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (18, 'Macarrones', 'Pasta corta y cilíndrica hecha con harina de trigo', 1.50, 'Marca L')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (18, 'Farfalle', 'Pasta con forma de mariposa hecha con harina de trigo', 2.25, 'Marca M')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (18, 'Penne', 'Pasta corta y tubular con forma de punta de pluma hecha con harina de trigo', 1.80, 'Marca N')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (18, 'Orecchiette', 'Pasta con forma de oreja hecha con harina de trigo', 2.50, 'Marca O')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (18, 'Gnocchi', 'Bolas pequeñas de pasta hechas con puré de patata y harina de trigo', 2.75, 'Marca P')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (18, 'Linguine', 'Fideos largos y delgados similares a los espaguetis, pero planos y estrechos', 2.25, 'Marca Q')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (18, 'Pappardelle', 'Fideos planos y anchos hechos con harina de trigo y huevo', 3.00, 'Marca R')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (18, 'Cavatappi', 'Pasta con forma de tornillo hecha con harina de trigo', 2.10, 'Marca S')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (18, 'Rigatoni', 'Pasta corta y tubular con forma de surco y extremos rectos hecha con harina de trigo', 1.90, 'Marca T')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (18, 'Fusilli bucati', 'Pasta con forma de hélice y agujero en el centro hecha con harina de trigo', 2.40, 'Marca U')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (18, 'Conchiglie', 'Pasta con forma de concha hecha con harina de trigo', 2.20, 'Marca V')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (18, 'Paccheri', 'Pasta corta y tubular con forma de cilindro ancho hecha con harina de trigo', 2.70, 'Marca W')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (18, 'Mezzelune', 'Pasta rellena con forma de media luna hecha con harina de trigo y queso', 3.80, 'Marca X')
-- CATEGORIA 4
-- SUBCATEGORIA 19
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (19, 'Jugo de manzana 500ml', 'Jugo de manzana 100% natural', 2.50, 'Jugos Naturales SA')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (19, 'Jugo de manzana 1L', 'Jugo de manzana 100% natural', 4.00, 'Jugos Naturales SA')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (19, 'Jugo de naranja 500ml', 'Jugo de naranja 100% natural', 2.50, 'Jugos Naturales SA')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (19, 'Jugo de naranja 1L', 'Jugo de naranja 100% natural', 4.00, 'Jugos Naturales SA')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (19, 'Jugo de piña 500ml', 'Jugo de piña 100% natural', 2.50, 'Jugos Naturales SA')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (19, 'Jugo de piña 1L', 'Jugo de piña 100% natural', 4.00, 'Jugos Naturales SA')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (19, 'Jugo de fresa 500ml', 'Jugo de fresa 100% natural', 2.50, 'Jugos Naturales SA')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (19, 'Jugo de fresa 1L', 'Jugo de fresa 100% natural', 4.00, 'Jugos Naturales SA')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (19, 'Jugo de pera 500ml', 'Jugo de pera 100% natural', 2.50, 'Jugos Naturales SA')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (19, 'Jugo de pera 1L', 'Jugo de pera 100% natural', 4.00, 'Jugos Naturales SA')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (19, 'Jugo de mango 500ml', 'Jugo de mango 100% natural', 2.50, 'Jugos Naturales SA')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (19, 'Jugo de mango 1L', 'Jugo de mango 100% natural', 4.00, 'Jugos Naturales SA')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (19, 'Jugo de uva 500ml', 'Jugo de uva 100% natural', 2.50, 'Jugos Naturales SA')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (19, 'Jugo de uva 1L', 'Jugo de uva 100% natural', 4.00, 'Jugos Naturales SA')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (19, 'Jugo de arándano 500ml', 'Jugo de arándano 100% natural', 2.50, 'Jugos Naturales SA')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (19, 'Jugo de arándano 1L', 'Jugo de arándano 100% natural', 4.00, 'Jugos Naturales SA')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (19, 'Jugo de sandía 500ml', 'Jugo de sandía 100% natural', 2.50, 'Jugos Naturales SA')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (19, 'Jugo de sandía 1L', 'Jugo de sandía 100% natural', 4.00, 'Jugos Naturales SA')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (19, 'Jugo de limón 500ml', 'Jugo de limón 100% natural', 2.50, 'Jugos Naturales SA')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (19, 'Jugo de limón 1L', 'Jugo de limón 100% natural', 4.00, 'Jugos Naturales SA')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (19, 'Jugo de toronja 500ml', 'Jugo de toronja 100% natural', 2.50, 'Jugos Naturales SA')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (19, 'Jugo de toronja 1L', 'Jugo de toronja 100% natural', 4.00, 'Jugos Naturales SA')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (19, 'Jugo de maracuyá 500ml', 'Jugo de maracuyá 100% natural', 2.50, 'Jugos Naturales SA')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (19, 'Jugo de maracuyá 1L', 'Jugo de maracuyá 100% natural', 4.00, 'Jugos Naturales SA')
-- SUBCATEGORIA 20
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (20, 'Agua sin gas 500ml', 'Agua pura y cristalina sin gas', 1.50, 'Manantial SA')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (20, 'Agua sin gas 1L', 'Agua pura y cristalina sin gas', 2.50, 'Manantial SA')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (20, 'Agua con gas 500ml', 'Agua burbujeante con gas', 1.80, 'Manantial SA')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (20, 'Agua con gas 1L', 'Agua burbujeante con gas', 2.80, 'Manantial SA')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (20, 'Agua con gas y sabor a limón 500ml', 'Agua burbujeante con gas y sabor a limón', 2.00, 'Manantial SA')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (20, 'Agua con gas y sabor a limón 1L', 'Agua burbujeante con gas y sabor a limón', 3.00, 'Manantial SA')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (20, 'Agua con gas y sabor a naranja 500ml', 'Agua burbujeante con gas y sabor a naranja', 2.00, 'Manantial SA')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (20, 'Agua con gas y sabor a naranja 1L', 'Agua burbujeante con gas y sabor a naranja', 3.00, 'Manantial SA')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (20, 'Agua de coco 500ml', 'Agua de coco natural', 2.50, 'Coco Loco SA')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (20, 'Agua de coco 1L', 'Agua de coco natural', 4.50, 'Coco Loco SA')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (20, 'Soda limon 500ml', 'Soda con sabor a limón', 2.00, 'Sodas SA')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (20, 'Soda limon 1L', 'Soda con sabor a limón', 3.00, 'Sodas SA')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (20, 'Soda naranja 1L', 'Soda con sabor a naranja', 3.00, 'Sodas SA')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (20, 'Soda cola 500ml', 'Soda con sabor a cola', 2.00, 'Sodas SA')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (20, 'Soda cola 1L', 'Soda con sabor a cola', 3.00, 'Sodas SA')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (20, 'Soda uva 500ml', 'Soda con sabor a uva', 2.00, 'Sodas SA')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (20, 'Soda uva 1L', 'Soda con sabor a uva', 3.00, 'Sodas SA')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (20, 'Soda lima-limón 500ml', 'Soda con sabor a lima-limón', 2.00, 'Sodas SA')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (20, 'Soda lima-limón 1L', 'Soda con sabor a lima-limón', 3.00, 'Sodas SA')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (20, 'Soda toronja 500ml', 'Soda con sabor a toronja', 2.00, 'Sodas SA')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (20, 'Soda toronja 1L', 'Soda con sabor a toronja', 3.00, 'Sodas SA')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (20, 'Gaseosa cola 500ml', 'Gaseosa con sabor a cola', 2.50, 'Gaseosas SA')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (20, 'Gaseosa cola 1L', 'Gaseosa con sabor a cola', 4.00, 'Gaseosas SA')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (20, 'Gaseosa naranja 500ml', 'Gaseosa con sabor a naranja', 2.50, 'Gaseosas SA')
-- SUBCATEGORIA 21
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (21, 'Vodka Absolut', 'Vodka sueco destilado continuamente desde 1879.', 20.99, 'The Absolut Company')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (21, 'Ron Bacardi Superior', 'Ron blanco, ligero y suave con un sabor equilibrado.', 18.99, 'Bacardi Limited')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (21, 'Tequila Patrón Silver', 'Tequila 100% agave destilado en pequeñas cantidades.', 39.99, 'Patrón Spirits Company')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (21, 'Ginebra Bombay Sapphire', 'Ginebra inglesa con una mezcla de diez botánicos.', 22.99, 'Bombay Sapphire Distillery Limited')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (21, 'Whisky Jameson', 'Whisky irlandés triple destilado y envejecido en barricas de roble.', 24.99, 'Jameson Irish Whiskey')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (21, 'Brandy Torres 10', 'Brandy español envejecido durante diez años en barricas de roble.', 36.99, 'Miguel Torres SA')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (21, 'Vino tinto Rioja Crianza', 'Vino tinto español envejecido durante un mínimo de dos años.', 15.99, 'Bodegas Bilbaínas')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (21, 'Cerveza Corona', 'Cerveza mexicana de estilo pilsner con un toque de lima.', 12.99, 'Grupo Modelo')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (21, 'Champán Veuve Clicquot Brut', 'Champán francés con una mezcla de uvas Pinot Noir, Chardonnay y Pinot Meunier.', 49.99, 'Veuve Clicquot Ponsardin')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (21, 'Licor Baileys Original', 'Licor irlandés con una mezcla de whisky y crema.', 16.99, 'R. A. Bailey & Co.')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (21, 'Ron Malibu', 'Ron con sabor a coco y un toque de piña.', 14.99, 'Pernod Ricard')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (21, 'Tequila Don Julio Reposado', 'Tequila 100% agave envejecido durante ocho meses.', 49.99, 'Diageo')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (21, 'Vodka Grey Goose', 'Vodka francés elaborado con trigo de invierno y agua de manantial.', 29.99, 'Grey Goose Company')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (21, 'Ginebra Hendrick''s', 'Ginebra escocesa con una mezcla de once botánicos.', 34.99, 'William Grant & Sons')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (21, 'Whisky Jack Daniel''s', 'Whisky americano elaborado en Tennessee.', 22.99, 'Jack Daniel''s Distillery')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (21, 'Brandy Carlos I Imperial', 'Brandy español envejecido durante más de veinte años en barricas de roble.', 99.99, 'Osborne')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (21, 'Vino blanco Rueda Verdejo', 'Vino blanco español elaborado con uvas Verdejo.', 11.99, 'Bodegas Naia')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (21, 'Cerveza Guinness Draught', 'Cerveza negra irlandesa con una cremosa espuma.', 13.99, 'Diageo')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (21, 'Champán Moët & Chandon Brut Impérial', 'Champán francés elaborado con uvas Pinot Noir, Pinot Meunier y Chardonnay.', 59.99, 'Moët & Chandon')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (21, 'Licor Amaretto Disaronno', 'Licor italiano con sabor a almendras amargas.', 18.99, 'I.L.L.V.A. Saronno Holding')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (21, 'Ron Havana Club 7 años', 'Ron cubano envejecido durante siete años.', 34.99, 'Pernod Ricard')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (21, 'Tequila José Cuervo Especial', 'Tequila mexicano elaborado con agave azul.', 19.99, 'Jose Cuervo')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (21, 'Vodka Belvedere', 'Vodka polaco elaborado con centeno y agua pura.', 34.99, 'LVMH')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (21, 'Ginebra Bombay Sapphire', 'Ginebra inglesa con una mezcla de diez botánicos.', 27.99, 'Bacardi Limited')
-- SUBCATEGORIA 22
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (22, 'Champagne Moët & Chandon Imperial Brut', 'Este champagne de elegante frescura combina notas de pera, manzana y flores blancas.', 49.99, 'Moët & Chandon')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (22, 'Cava Codorníu Clásico Brut', 'Este cava presenta una burbuja fina y persistente con aromas de frutas maduras y un toque de pan tostado.', 12.99, 'Codorníu')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (22, 'Sidra Trabanco Selección', 'Esta sidra asturiana tiene un aroma intenso y complejo con notas florales y de manzana madura.', 7.99, 'Sidra Trabanco')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (22, 'Champagne Dom Pérignon Vintage 2010', 'Este champagne ofrece una complejidad única con notas de frutas blancas, almendras, tostados y especias.', 199.99, 'Dom Pérignon')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (22, 'Cava Freixenet Reserva Real', 'Este cava destaca por su elegancia y equilibrio con aromas de frutas blancas y una burbuja fina y persistente.', 29.99, 'Freixenet')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (22, 'Sidra Viuda de Angelón Extra', 'Esta sidra asturiana tiene un sabor fresco y equilibrado con notas de manzana y una acidez muy bien integrada.', 5.99, 'Viuda de Angelón')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (22, 'Champagne Veuve Clicquot Brut Yellow Label', 'Este champagne destaca por su frescura y potencia con aromas de manzana, pera y brioche.', 39.99, 'Veuve Clicquot')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (22, 'Cava Gramona III Lustros Gran Reserva Brut Nature', 'Este cava ofrece una complejidad única con notas de frutas blancas, pan tostado y brioche.', 49.99, 'Gramona')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (22, 'Sidra Mayador Selección Especial', 'Esta sidra asturiana tiene un sabor intenso y equilibrado con notas de manzana y un final largo y persistente.', 8.99, 'Mayador')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (22, 'Champagne Krug Grande Cuvée', 'Este champagne destaca por su complejidad y elegancia con aromas de frutas maduras, brioche y miel.', 249.99, 'Krug')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (22, 'Cava Recaredo Terrers Brut Nature Gran Reserva', 'Este cava es un homenaje a la tierra y al terruño con notas de frutas maduras y un toque mineral.', 44.99, 'Recaredo')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (22, 'Sidra El Gaitero Brut Nature', 'Esta sidra asturiana tiene una burbuja fina y elegante con notas de manzana y un sabor fresco y equilibrado.', 6.99, 'El Gaitero')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (22, 'Champagne Laurent-Perrier Cuvée Rosé Brut', 'Este champagne rosado destaca por su frescura y elegancia con aromas de frutas rojas y un toque de especias.', 59.99, 'Laurent-Perrier')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (22, 'Cava Mestres Visol Gran Reserva Brut Nature', 'Este cava destaca por su complejidad y elegancia con notas de frutas maduras y un toque de levaduras.', 32.99, 'Mestres')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (22, 'Sidra Peñón del Águila Brut Nature', 'Esta sidra asturiana tiene una burbuja fina y elegante con notas de manzana y un sabor fresco y equilibrado con un toque de acidez.', 9.99, 'Peñón del Águila')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (22, 'Champagne Ruinart Blanc de Blancs', 'Este champagne destaca por su frescura y elegancia con aromas de frutas blancas y un toque de miel.', 79.99, 'Ruinart')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (22, 'Cava Juvé y Camps Reserva de la Familia', 'Este cava es una expresión de la elegancia y la complejidad con notas de frutas maduras y un toque de pan tostado.', 21.99, 'Juvé y Camps')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (22, 'Sidra Fanjul Selección', 'Esta sidra asturiana tiene un sabor intenso y complejo con notas de manzana madura y un toque de madera.', 11.99, 'Fanjul')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (22, 'Champagne Bollinger Special Cuvée Brut', 'Este champagne destaca por su complejidad y elegancia con aromas de frutas maduras, pan tostado y miel, y un toque de nueces.', 89.99, 'Bollinger')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (22, 'Cava Gramona III Lustros Gran Reserva Brut Nature', 'Este cava destaca por su complejidad y elegancia con notas de frutas maduras, levaduras y un toque mineral.', 45.99, 'Gramona')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (22, 'Sidra Trabanco Selección', 'Esta sidra asturiana tiene un sabor intenso y complejo con notas de manzana madura y un toque de madera y acidez.', 14.99, 'Trabanco')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (22, 'Champagne Moët & Chandon Impérial Brut', 'Este champagne destaca por su frescura y elegancia con notas de frutas blancas, cítricos y un toque de miel.', 49.99, 'Moët & Chandon')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (22, 'Cava Torelló 225 Gran Reserva Brut Nature', 'Este cava es una expresión de la elegancia y la complejidad con notas de frutas maduras, tostados y un toque de hierbas.', 29.99, 'Torelló')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (22, 'Sidra Mayador Esteban Ferrer Brut Nature', 'Esta sidra asturiana tiene una burbuja fina y elegante con notas de manzana y un sabor fresco y equilibrado con un toque de acidez y mineralidad.', 8.99, 'Mayador Esteban Ferrer')
-- SUBCATEGORIA 23
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (23, 'Agua mineral ecológica Solán de Cabras', 'Agua mineral natural con una mineralización débil, obtenida directamente de manantial, envasada en botella de vidrio reciclable y etiqueta de papel ecológico.', 1.99, 'Solán de Cabras')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (23, 'Vino ecológico tinto Raíz de Guzmán Crianza', 'Vino tinto elaborado con uvas ecológicas tempranillo y envejecido en barrica de roble durante 12 meses, con un sabor intenso y equilibrado con notas de frutas maduras y especias.', 17.99, 'Raíz de Guzmán')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (23, 'Cerveza ecológica La Sagra IPA', 'Cerveza artesana de estilo India Pale Ale elaborada con maltas y lúpulos ecológicos, con un sabor amargo y afrutado y un toque de cítricos.', 2.99, 'La Sagra')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (23, 'Zumo ecológico de naranja Natura', 'Zumo de naranja 100% natural y ecológico, obtenido por prensado directo de las naranjas frescas, sin conservantes ni aditivos.', 3.99, 'Natura')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (23, 'Infusión ecológica de jengibre y limón Yogi Tea', 'Infusión ecológica de hierbas y especias con jengibre, limón y otros ingredientes naturales, con propiedades digestivas y energizantes.', 4.99, 'Yogi Tea')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (23, 'Leche ecológica de avena Oatly', 'Leche vegetal ecológica elaborada a partir de avena, sin lactosa ni gluten, envasada en botella de cartón reciclable y tapón de rosca.', 2.49, 'Oatly')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (23, 'Zumosol multifrutas ecológico', 'Zumo de frutas ecológico con una mezcla de manzana, naranja, plátano y piña, sin azúcares añadidos ni conservantes artificiales.', 1.99, 'Zumosol')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (23, 'Cerveza ecológica Alhambra Reserva 1925', 'Cerveza artesana de estilo lager elaborada con maltas y lúpulos ecológicos, con un sabor suave y refrescante y un toque de notas florales y cítricas.', 3.99, 'Alhambra')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (23, 'Café ecológico molido Bonka', 'Café molido 100% ecológico de alta calidad, con un sabor intenso y aroma fresco y natural, envasado en paquete de papel reciclable.', 5.99, 'Bonka')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (23, 'Té verde ecológico con jazmín Biográ', 'Té verde ecológico con hojas de jazmín y otros ingredientes naturales, con propiedades antioxidantes y un aroma suave y floral.', 2.99, 'Biográ')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (23, 'Cerveza ecológica Ambar Especial', 'Cerveza artesana de estilo amber ale elaborada con maltas y lúpulos ecológicos, con un sabor equilibrado y un toque de caramelo y frutos secos.', 3.49, 'Ambar')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (23, 'Agua de coco ecológica Pago', 'Agua de coco 100% ecológica y natural, obtenida de cocos frescos y envasada en botella de vidrio reciclable.', 2.99, 'Pago')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (23, 'Té negro ecológico English Breakfast Clipper', 'Té negro ecológico de alta calidad con hojas de té seleccionadas y un sabor intenso y profundo, envasado en bolsitas de té biodegradables.', 3.99, 'Clipper')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (23, 'Cerveza ecológica Heineken 0.0', 'Cerveza sin alcohol y ecológica de la marca Heineken, con un sabor refrescante y un bajo contenido calórico.', 2.49, 'Heineken')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (23, 'Infusión ecológica de manzanilla La Tetera Azul', 'Infusión ecológica de manzanilla seleccionada y otros ingredientes naturales, con propiedades relajantes y un sabor suave y dulce.', 4.49, 'La Tetera Azul')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (23, 'Cerveza ecológica Estrella Galicia', 'Cerveza artesana de estilo lager elaborada con maltas y lúpulos ecológicos, con un sabor suave y un toque de notas florales y herbales.', 3.99, 'Estrella Galicia')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (23, 'Zumo ecológico de arándanos Azulberry', 'Zumo de arándanos 100% natural y ecológico, obtenido por prensado directo de las frutas frescas y envasado en botella de vidrio reciclable.', 3.99, 'Azulberry')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (23, 'Leche de almendras ecológica EcoMil', 'Leche de almendras ecológica y sin lactosa, con un alto contenido en calcio y vitaminas, y envasada en tetrabrik reciclable.', 2.99, 'EcoMil')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (23, 'Vino tinto ecológico Rioja Vega Crianza', 'Vino tinto ecológico de la Denominación de Origen Rioja, con una crianza de 12 meses en barrica de roble francés y un sabor intenso y complejo.', 12.99, 'Rioja Vega')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (23, 'Té verde ecológico con menta Pompadour', 'Té verde ecológico con hojas de menta fresca y otros ingredientes naturales, con propiedades digestivas y un sabor refrescante y aromático.', 2.49, 'Pompadour')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (23, 'Cerveza ecológica Alhambra Reserva 1925', 'Cerveza artesana de estilo pilsen elaborada con maltas y lúpulos ecológicos, con un sabor suave y un toque de notas florales y cítricas.', 4.99, 'Alhambra')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (23, 'Zumo ecológico de naranja Valencia Natural', 'Zumo de naranja 100% natural y ecológico, obtenido por prensado directo de las frutas frescas y envasado en botella de vidrio reciclable.', 2.99, 'Valencia Natural')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (23, 'Infusión ecológica de rooibos Yogi Tea', 'Infusión ecológica de rooibos y otros ingredientes naturales, con propiedades relajantes y un sabor suave y dulce con toques especiados.', 4.99, 'Yogi Tea')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (23, 'Cerveza ecológica Mahou Cinco Estrellas', 'Cerveza artesana de estilo lager elaborada con maltas y lúpulos ecológicos, con un sabor suave y un toque de notas florales y herbales.', 3.49, 'Mahou')
-- SUBCATEGORIA 24
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (24, 'Refresco de cola Coca-Cola', 'Refresco de cola con gas y sin alcohol, con un sabor único y refrescante que lo convierte en uno de los más populares del mundo.', 1.50, 'Coca-Cola')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (24, 'Agua mineral natural San Pellegrino', 'Agua mineral natural carbonatada, con un sabor suave y un toque de notas minerales, ideal para acompañar cualquier comida o para refrescarse en cualquier momento.', 1.20, 'San Pellegrino')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (24, 'Tónica Schweppes', 'Tónica con gas y sin alcohol, con un sabor amargo y ligeramente dulce que combina perfectamente con el gin tonic o se puede disfrutar sola.', 1.80, 'Schweppes')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (24, 'Zumo de manzana natural Don Simon', 'Zumo de manzana 100% natural y sin conservantes, obtenido por prensado directo de las frutas frescas y envasado en botella de vidrio reciclable.', 2.00, 'Don Simon')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (24, 'Refresco de limón Kas', 'Refresco de limón con gas y sin alcohol, con un sabor suave y refrescante que lo convierte en una opción perfecta para cualquier ocasión.', 1.30, 'Kas')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (24, 'Agua de coco Vita Coco', 'Agua de coco 100% natural y sin conservantes, con un sabor suave y refrescante que hidrata y proporciona una gran cantidad de nutrientes al organismo.', 2.50, 'Vita Coco')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (24, 'Refresco de naranja Fanta', 'Refresco de naranja con gas y sin alcohol, con un sabor afrutado y refrescante que lo convierte en una opción perfecta para cualquier momento del día.', 1.30, 'Fanta')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (24, 'Agua mineral natural Evian', 'Agua mineral natural sin gas, con un sabor suave y un toque de notas minerales, ideal para acompañar cualquier comida o para refrescarse en cualquier momento.', 1.50, 'Evian')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (24, 'Zumo de tomate natural Choví', 'Zumo de tomate 100% natural y sin conservantes, obtenido por prensado directo de los tomates frescos y envasado en botella de vidrio reciclable.', 2.50, 'Choví')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (24, 'Refresco de lima y limón Sprite', 'Refresco de lima y limón con gas y sin alcohol, con un sabor cítrico y refrescante que lo convierte en una opción perfecta para cualquier ocasión.', 1.30, 'Sprite')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (24, 'Agua de manantial Lanjarón', 'Agua de manantial natural sin gas, con un sabor suave y una gran cantidad de minerales que la convierten en una opción saludable y refrescante.', 1.20, 'Lanjarón')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (24, 'Refresco de lima Schweppes', 'Refresco de lima con gas y sin alcohol, con un sabor suave y refrescante que se puede disfrutar sola o combinada con otras bebidas.', 1.80, 'Schweppes')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (24, 'Agua de coco Zico', 'Agua de coco 100% natural y sin conservantes, con un sabor suave y refrescante que hidrata y proporciona una gran cantidad de nutrientes al organismo.', 2.50, 'Zico')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (24, 'Refresco de pomelo Kas', 'Refresco de pomelo con gas y sin alcohol, con un sabor suave y refrescante que lo convierte en una opción perfecta para cualquier momento del día.', 1.30, 'Kas')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (24, 'Agua mineral natural Perrier', 'Agua mineral natural con gas, con un sabor suave y un toque de notas minerales, ideal para acompañar cualquier comida o para refrescarse en cualquier momento.', 1.80, 'Perrier')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (24, 'Zumo de naranja natural Granini', 'Zumo de naranja 100% natural y sin conservantes, obtenido por prensado directo de las frutas frescas y envasado en botella de vidrio reciclable.', 2.00, 'Granini')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (24, 'Refresco de limón y té Lipton', 'Refresco de limón y té con gas y sin alcohol, con un sabor suave y refrescante que lo convierte en una opción ideal para cualquier momento del día.', 1.50, 'Lipton')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (24, 'Agua mineral natural Vichy Catalán', 'Agua mineral natural con gas, con un sabor suave y un toque de notas minerales, ideal para acompañar cualquier comida o para refrescarse en cualquier momento.', 1.50, 'Vichy Catalán')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (24, 'Bebida isotónica Gatorade', 'Bebida isotónica para deportistas, con un sabor suave y refrescante que ayuda a reponer los electrolitos perdidos durante el ejercicio físico intenso.', 2.00, 'Gatorade')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (24, 'Tónica Schweppes', 'Tónica con gas y sin alcohol, con un sabor suave y refrescante que lo convierte en la opción ideal para combinar con cualquier tipo de bebida.', 1.80, 'Schweppes')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (24, 'Zumo de piña natural Minute Maid', 'Zumo de piña 100% natural y sin conservantes, obtenido por prensado directo de las frutas frescas y envasado en botella de vidrio reciclable.', 2.20, 'Minute Maid')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (24, 'Refresco de cola Coca-Cola', 'Refresco de cola con gas y sin alcohol, con un sabor único y refrescante que lo convierte en una opción perfecta para cualquier momento del día.', 1.50, 'Coca-Cola')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (24, 'Agua mineral natural Bezoya', 'Agua mineral natural sin gas, con un sabor suave y una gran cantidad de minerales que la convierten en una opción saludable y refrescante.', 1.20, 'Bezoya')
INSERT INTO producto (id_subcategoria, nombre, descripcion, precio, fabricante) VALUES (24, 'Refresco de lima y hierbabuena Kas', 'Refresco de lima y hierbabuena con gas y sin alcohol, con un sabor suave y refrescante que lo convierte en una opción ideal para cualquier momento del día.', 1.30, 'Kas')
-- CATEGORIA 5
-- CATEGORIA 6
-- CATEGORIA 7
-- CATEGORIA 8
-- CATEGORIA 9