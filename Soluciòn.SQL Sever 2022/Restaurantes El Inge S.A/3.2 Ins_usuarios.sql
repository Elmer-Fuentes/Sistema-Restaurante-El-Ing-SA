select * from tbl_usuarios
select * from tbl_empleados



--query para insertar en la base de datos
insert into tbl_usuarios (codigo_empleado,nombre_usuario,contrasena,rol,estado,usuario_sistema,FechaSistema)
		Values(1,'Elmer De La Cruz','sources','Administrador','Activo','Elmer De La Cruz','20250501')
	insert into tbl_usuarios (codigo_empleado,nombre_usuario,contrasena,rol,estado,usuario_sistema,FechaSistema)	values (2, 'david cruz', '12345', 'Administrador', 'Activo', 'Dcruzg0802','20250503')

	

/*Query utilizado en el entorno desarrollo csharp

insert into tbl_usuarios (codigo_empleado,nombre_usuario,contrasena,rol,estado,usuario_sistema,FechaSistema) 
			Values(@codigo_empleado,@nombre_usuario,@contrasena,@rol,@estado,@usuario_sistema,@FechaSistema)

*/