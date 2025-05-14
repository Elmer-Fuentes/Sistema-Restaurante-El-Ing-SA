--use Proyecto_Restaurante
--go

--Create proc Usp_sel_empleados 
--	@nombre varchar (50)
--as
--begin 
--	select 
--	a.codigo_empleado 
--	,a.nombre as Nombre_Empleado
--	,a.cargo
--	,a.salario
--	,a.fecha_contratacion
--	,a.estado
--	,a.usuario_sistema
--	,a.fecha_sistema	
--	from tbl_empleados a
--	where Upper(Trim(a.nombre)) like + '%'+ Upper(Trim(@nombre)) +'%'
--end


--create proc Ups_usuarios
--	@nombre_usuario varchar(50)
--as
--begin 
--select 
--	a.codigo_usuario
--	,a.codigo_empleado
--	,a.nombre_usuario
--	,a.contrasena
--	,a.rol
--	,a.estado
--	,a.usuario_sistema
--	,a.FechaSistema
--from tbl_usuarios a
--where Upper(Trim(a.nombre_usuario)) like '%' + Upper(Trim(@nombre_usuario))+ '%'
--end


SELECT table_name
FROM information_schema.tables

--Alter proc Usp_Pago_Planilla
--@nombre varchar(50)
--as 
--Begin 
--		select 
--		 q.codigo_pago_planilla
--		,q.codigo_empleado
--		,r.nombre
--		,r.cargo
--		,cast(r.fecha_contratacion as date) as Fecha_Contratacion
--		,r.estado as Estado_Colaborador
--		,cast(q.fecha_pago as date) as Fecha_Pago
--		,q.salario
--		,q.bono
--		,q.horas_extras
--		,q.monto_total
--		,q.estado
--		,q.usuario_sistema
--		,q.fecha_sistema
--		from tbl_pago_planillas q
--		left join tbl_empleados r on q.codigo_empleado = r.codigo_empleado
--		where lower(Trim(r.nombre)) like +'%'+Lower(Trim(@nombre)) + '%'
--end


--execute Usp_Pago_Planilla '%'