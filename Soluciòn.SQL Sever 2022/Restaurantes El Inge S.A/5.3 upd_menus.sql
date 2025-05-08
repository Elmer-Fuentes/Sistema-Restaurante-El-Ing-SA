use Proyecto_Restaurante
go


select * from tbl_menus

update tbl_menus set nombre='teeeqq',ingredientes='teee',categoria='teee',precio=555,estado='teee',usuario_sistema='teee',fecha_sistema='25240101' where codigo_menu = 1


/* query utilizado en csharp

update tbl_menus set nombre=@nombre,ingredientes=@ingredientes,categoria=@categoria,precio=@precio,estado=@estado,usuario_sistema=@usuario_sistema,fecha_sistema=@fecha_sistema where codigo_menu = @codigo_menu



*/
