USE CATALOGO_P3_DB
go


INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) 
VALUES ('R60U ', 'Motorola Razr 60 Ultra ','Celular Alta gama ',1,2,525000);
INSERT INTO IMAGENES (IdArticulo, ImagenUrl)
VALUES (26, 'https://armoto.vtexassets.com/arquivos/ids/169820-1200-auto?v=638913855128530000&width=1200&height=auto&aspect=true');
INSERT INTO IMAGENES (IdArticulo, ImagenUrl)
VALUES (26, 'https://armoto.vtexassets.com/arquivos/ids/168115-1200-auto?v=638793755551000000&width=1200&height=auto&aspect=true');
INSERT INTO IMAGENES (IdArticulo, ImagenUrl)
VALUES (26, 'https://armoto.vtexassets.com/arquivos/ids/168116-1200-auto?v=638793755551130000&width=1200&height=auto&aspect=true');
INSERT INTO IMAGENES (IdArticulo, ImagenUrl)
VALUES (26, 'https://armoto.vtexassets.com/arquivos/ids/168120-1200-auto?v=638793755551770000&width=1200&height=auto&aspect=true');
INSERT INTO IMAGENES (IdArticulo, ImagenUrl)
VALUES (26, 'https://armoto.vtexassets.com/arquivos/ids/168124-1200-auto?v=638793755552530000&width=1200&height=auto&aspect=true');



INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) 
VALUES ('ME15 ', 'Moto E 15 ','Celular gama media ',1,2,250000);

INSERT INTO IMAGENES (IdArticulo, ImagenUrl)
VALUES (27, 'https://armoto.vtexassets.com/arquivos/ids/167825-1200-auto?v=638749631706000000&width=1200&height=auto&aspect=true');
INSERT INTO IMAGENES (IdArticulo, ImagenUrl)
VALUES (27, 'https://armoto.vtexassets.com/arquivos/ids/167827-1200-auto?v=638749631706170000&width=1200&height=auto&aspect=true');
INSERT INTO IMAGENES (IdArticulo, ImagenUrl)
VALUES (27, 'https://armoto.vtexassets.com/arquivos/ids/167832-1200-auto?v=638749631706300000&width=1200&height=auto&aspect=true');
INSERT INTO IMAGENES (IdArticulo, ImagenUrl)
VALUES (27, 'https://armoto.vtexassets.com/arquivos/ids/167835-1200-auto?v=638749631381230000&width=1200&height=auto&aspect=true');




SELECT * FROM ARTICULOS
select * from CATEGORIAS, MARCAS
SELECT * FROM IMAGENES order by ImagenUrl;
