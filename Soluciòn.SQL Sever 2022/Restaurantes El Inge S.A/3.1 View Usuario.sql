use proyecto_restaurante 
go

select * from tbl_empleados
select * from tbl_usuarios


alter view usuario as (
	select 
			a.codigo_usuario as 'Uid',
			a.codigo_empleado as 'Còdigo Empleado',
			e.nombre as 'Nombre Colaborador',
			a.nombre_usuario as 'Nombre Del Usuario',
			a.contrasena as 'Password',
			a.Rol,
			a.Estado,
			a.usuario_sistema as 'Usuario del Sistema',
			a.Fechasistema as 'Fecha del Sistema'
	from tbl_usuarios a
	 join tbl_empleados e on a.codigo_empleado = e.codigo_empleado
)

select * from usuario --vista 