Alter view Empleados_conYsin_Usuarios as(	
	select 
			--a.codigo_usuario as 'Uid',
			e.codigo_empleado as 'Código Empleado',
			e.nombre as 'Nombre Colaborador',
			--a.nombre_usuario as 'Nombre Del Usuario',
			e.Cargo as 'Puesto de Trabajo',
			e.Fecha_Contratacion as 'Fecha De Contratación',
			e.Estado,
			Case when nombre != '' then 'Sin Usuarios' end as 'Observación',
			 '' as codigo_usuario,
			'Sin Asignación' as nombre_usuario,
			'No Asignado' as Rol,
			null as 'Fecha Creación Usuarios'
	from tbl_usuarios a
	 right join tbl_empleados e on a.codigo_empleado = e.codigo_empleado
	 where a.nombre_usuario is null 
	 Union all
	 	select 
			--a.codigo_usuario as 'Uid',
			e.codigo_empleado as 'Código Empleado',
			e.nombre as 'Nombre Colaborador',
			--a.nombre_usuario as 'Nombre Del Usuario',
			e.Cargo as 'Puesto de Trabajo',
			e.Fecha_Contratacion as 'Fecha De Contratación',
			e.Estado,
			Case when nombre != '' then 'Con Usuarios' end as 'Observación',
			a.codigo_usuario
			,a.nombre_usuario
			,a.Rol
			,a.FechaSistema as 'Fecha Creación Usuarios'
	from tbl_usuarios a
	 right join tbl_empleados e on a.codigo_empleado = e.codigo_empleado
	 where a.nombre_usuario is not null 
)



select * from Empleados_conYSin_usuarios
