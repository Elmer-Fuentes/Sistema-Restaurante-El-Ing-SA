--script para agregar datos a la db



select * from tbl_clientes
insert into tbl_clientes(nombre, nit, telefono, categoria, estado, usuario_sistema, fecha_sistema) values ('test', '13246', '123132', 'Estasd', 'jdjdjd', 'Temach', '20250101');

--query utilizado en Csharp
insert into tbl_clientes(nombre, nit, telefono, categoria, estado, usuario_sistema, fecha_sistema) values (@nombre, @nit, @telefono, @categoria, @estado, @usuario_sistema, @fecha_sistema);