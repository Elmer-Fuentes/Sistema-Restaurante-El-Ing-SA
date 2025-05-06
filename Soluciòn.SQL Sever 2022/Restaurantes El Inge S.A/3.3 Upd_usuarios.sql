select * from tbl_usuarios


--query para entorno de csharp
update tbl_usuarios set codigo_empleado=@codigo_empleado,nombre_usuario=@nombre_usuario,contrasena=@contrasena,roll=@roll,estado=@estado,usuario_sistema=@usuario_sistema, fecha_sistema=@fecha_sistema	where codigo_usuario = @codigo_usuario


	--query para actualizar registros
update tbl_usuarios set 
	codigo_empleado=1,
	nombre_usuario='dadhhhal',
	contrasena='asda',
	rol='asdad',
	estado='asd',
	usuario_sistema='ads',
	fechasistema='20240101'
	where codigo_usuario = 3

