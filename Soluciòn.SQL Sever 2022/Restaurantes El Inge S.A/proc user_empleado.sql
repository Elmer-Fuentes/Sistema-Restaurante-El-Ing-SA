Alter procedure USP_BusEmpleadoSin_Usuario
    @Empleado_nombre VARCHAR(50)
AS
BEGIN
   	select 
			--a.codigo_usuario as 'Uid',
			e.codigo_empleado as 'Còdigo Empleado',
			e.nombre as 'Nombre Colaborador',
			--a.nombre_usuario as 'Nombre Del Usuario',
			e.Cargo as 'Puesto de Trabajo',
			e.Fecha_Contratacion as 'Fecha De Contrataciòn',
			e.Estado,
			Case when nombre != '' then 'Empleados sin Usuarios' end as 'Observaciòn'  
	from tbl_usuarios a
	 right join tbl_empleados e on a.codigo_empleado = e.codigo_empleado
	 where a.nombre_usuario is null and
  UPPER(TRIM(nombre)) LIKE '%' + UPPER(TRIM(@Empleado_nombre)) + '%';
END;




Create proc Ups_Data_Dash_Emp_user 
 @Empleado_nombre VARCHAR(50)
as
begin
	Select aux.* from (

			select 
					--a.codigo_usuario as 'Uid',
					e.codigo_empleado as 'Código_Empleado',
					e.nombre as 'Nombre_Colaborador',
					--a.nombre_usuario as 'Nombre Del Usuario',
					e.Cargo as 'Puesto_de_Trabajo',
					e.Fecha_Contratacion as 'Fecha_De_Contratación',
					e.Estado,
					Case when nombre != '' then 'Sin Usuarios' end as 'Observación',
					 '' as codigo_usuario,
					'Sin Asignación' as nombre_usuario,
					'No Asignado' as Rol,
					null as 'Fecha_Creación_Usuarios'
			from tbl_usuarios a
			 right join tbl_empleados e on a.codigo_empleado = e.codigo_empleado
			 where a.nombre_usuario is null 
			 Union all
			 	select 
					--a.codigo_usuario as 'Uid',
					e.codigo_empleado as 'Código_Empleado',
					e.nombre as 'Nombre_Colaborador',
					--a.nombre_usuario as 'Nombre Del Usuario',
					e.Cargo as 'Puesto_de_Trabajo',
					e.Fecha_Contratacion as 'Fecha_De_Contratación',
					e.Estado,
					Case when nombre != '' then 'Con Usuarios' end as 'Observación',
					a.codigo_usuario
					,a.nombre_usuario
					,a.Rol
					,a.FechaSistema as 'Fecha_Creación_Usuarios'
			from tbl_usuarios a
			 right join tbl_empleados e on a.codigo_empleado = e.codigo_empleado
			 where a.nombre_usuario is not null 
			 ) aux
			 where UPPER(TRIM(aux.Nombre_Colaborador)) LIKE '%' + UPPER(TRIM(@Empleado_nombre)) + '%';
end 

