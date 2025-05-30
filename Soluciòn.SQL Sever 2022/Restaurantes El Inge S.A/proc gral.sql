use Proyecto_Restaurante
go

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




-- tala de menu

--select 
--	 a.codigo_menu
--	,a.nombre
--	,a.ingredientes
--	,a.categoria
--	,a.precio
--	,a.estado
--	,a.usuario_sistema
--	,a.fecha_sistema
-- from tbl_menus a


--create proc USP_Inventario_Menu
--	@nombre varchar (50)
--as
--begin
--select 
--	 i.codigo_inventario
--	,i.codigo_menu
--	,a.nombre as 'Nombre_Menu'
--	,a.Precio
--	,i.categoria
--	,i.cantidad
--	,i.fecha_entrada
--	,i.fecha_vencimiento
--	,i.dias_vigencia
--	,i.usuario_sistema
--	,i.fecha_sistema
--from tbl_inventarios i
--	left join tbl_menus a on i.codigo_menu = a.codigo_menu
--	where Lower(Trim(a.nombre)) like '%'+ Lower(Trim(@nombre))+'%'
--end






--Alter procedure Usp_mesas (
--@tipomesas varchar(50)

--)
--as
--begin 
--select Codigo_Mesa
--,Numero_Mesa
--,Cantidad_Sillas
--,Ubicacion
--,Tipo_Mesa
--,Estado
--,Usuario_Sistema
--,FechaSistema
--from tbl_mesas
--end




--Alter procedure Usp_mesas (
--@tipomesas varchar(50)

--)
--as
--begin 
--select Codigo_Mesa
--,Numero_Mesa
--,Cantidad_Sillas
--,Ubicacion
--,Tipo_Mesa
--,Estado
--,Usuario_Sistema
--,FechaSistema
--from tbl_mesas
--end




--alter proc Usp_Encabezado_ordenes(
-- @nombre_cliente varchar(50)

--)
--as
--begin
--select 
--a.Codigo_Orden_Enc
--,a.Codigo_Cliente,
--c.Nombre as Nombre_Cliente,
--c.Categoria,
--a.Codigo_Mesa,
--Concat('Nùmero De Mesa: ',m.numero_mesa,' - Cantidad Sillas:',m.cantidad_sillas) as 'Detalle_Mesa',
--a.Codigo_Empleado,
--Concat(' - Nombre Empleado:', e.nombre, ' - Cargo: ',e.cargo) as 'Detalle_Empleado',
--a.Fecha_Orden,
--a.Monto_Total_Orden,
--a.Estado,
--a.Usuario_Sistema,
--a.Fecha_Sistema
--from tbl_encabezado_ordenes a
-- left join tbl_clientes c on a.codigo_cliente = c.codigo_cliente
-- left join tbl_mesas m on a.codigo_mesa = m.codigo_mesa
-- left join tbl_empleados e  on a.codigo_empleado = e.codigo_empleado
--end


select table_name from information_schema.Tables


select * from tbl_empleados
select * from tbl_detalles_ordenes


create proc Usp_detalles_ordenes (
@detalle_ordenes varchar(100) 
)
as
	begin 

		select 
		de.Codigo_Orden_Det,
		de.Codigo_Orden_Enc,
		Concat('Codigo Cliente: ',en.codigo_cliente,' - Codigo Mesa: ',en.codigo_mesa, ' - Codigo_Empleado: ',en.Codigo_Empleado ) as 'Detalle_Ordenes',
		de.Codigo_Menu,
		+'Platillo: '+ m.nombre+ ' -- Ingredientes: '+m.ingredientes as 'Descripcion_Menu',
		de.Cantidad,
		de.Precio_Unitario,
		de.Precio_Total,
		de.Usuario_Sistema,
		de.Fecha_Sistema
		from tbl_detalles_ordenes de 
		left join tbl_encabezado_ordenes en on de.codigo_orden_enc = en. codigo_orden_enc
		left join tbl_menus m on de.codigo_menu = m.codigo_menu
	end


	execute Usp_detalles_ordenes ''