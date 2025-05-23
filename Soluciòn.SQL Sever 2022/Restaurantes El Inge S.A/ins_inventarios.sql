--script para ingresar datos a la tabla inventarios
insert  into tbl_inventarios (codigo_menu, categoria, cantidad, fecha_entrada, fecha_vencimiento, dias_vigencia, usuario_sistema, fecha_sistema)
values(1, 'Caro', 3,'20250523', '20260523', 365, 'Dcruz', '20250523')
--script que se usara en el entorno de desarrollo de c-sharp
--insert  into tbl_inventarios (codigo_menu, categoria, cantidad, fecha_entrada, fecha_vencimiento, dias_vigencia, usuario_sistema, fecha_sistema)
--values(@codigo_menu, @categoria, @cantidad, @fecha_entrada, @fecha_vencimiento, @dias_vigencia, @usuario_sistema, @fecha_sistema)

