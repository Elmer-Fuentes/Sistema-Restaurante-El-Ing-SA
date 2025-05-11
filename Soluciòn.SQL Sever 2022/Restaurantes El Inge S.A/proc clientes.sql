alter procedure USP_BusCliente
    @nombre VARCHAR(50)
AS
BEGIN
   	select 
	c.codigo_cliente As 'Codigo Cliente',
	c.nombre As 'Nombre del Cliente',
	c.Nit,
	c.Telefono,
	c.Categoria,
	c.Estado,
	c.usuario_sistema  As 'Usuario Del Sistema',
	c.fecha_sistema
	from tbl_clientes c
	 where UPPER(TRIM(c.nombre)) LIKE '%' + UPPER(TRIM(@nombre)) + '%';
END;


exec USP_BusCliente 'david'


select * from tbl_Clientes