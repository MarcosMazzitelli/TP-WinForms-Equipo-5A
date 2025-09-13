USE CATALOGO_P3_DB
go
insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) output inserted.Id values ('aa2','CeluPRueba','pRUEBA',2,3,500);

select * from articulos

delete from ARTICULOS where Id in (14,15,16,17,18,19,20)

SELECT * FROM IMAGENES

INSERT INTO IMAGENES (IdArticulo, ImagenUrl) Values (@idArticulo,@imagenUrl)

INSERT INTO IMAGENES (IdArticulo, ImagenUrl) Values (3,2)

delete from	Imagenes where Id=11