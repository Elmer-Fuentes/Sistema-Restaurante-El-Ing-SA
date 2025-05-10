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


