USE CATALOGO_P3_DB
go

SELECT * FROM IMAGENES order by Id;

INSERT INTO IMAGENES (IdArticulo, ImagenUrl) Values (@idArticulo,@imagenUrl)

INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) 
VALUES ('S21 '), ('Samsung S21 '),('Celular Alta gama '),(1),(2),(500);
