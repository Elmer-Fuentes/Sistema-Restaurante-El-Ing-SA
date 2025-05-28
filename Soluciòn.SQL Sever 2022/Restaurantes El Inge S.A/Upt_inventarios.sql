--script para editar en el entrono de desarrollo de c-sharp
--update tbl_inventarios set codigo_menu = @codigo_menu, categoria = @categoria, cantidad = @cantidad, fecha_entrada = @fecha_entrada, fecha_vencimiento = @fecha_vencimiento, dias_vigencia = @dias_vigencia, usuario_sistema = @usuario_sistema, fecha_sistema = @fecha_sistema   where codigo_inventario = @codigo_inventario

select *  from tbl_inventarios