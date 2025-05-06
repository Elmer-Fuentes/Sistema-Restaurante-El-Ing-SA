use proyecto_restaurante
go

create Proc busqueda_Cod_Empleado (
@codigo int
)
as
begin
	select 
			--a.codigo_usuario as 'Còdigo Usuario',
			e.codigo_empleado as 'Còdigo Empleado',
			e.nombre as 'Nombre Colaborador'
	from tbl_empleados e 
	 where e.codigo_empleado = @codigo
end
