--Vista 1 en este query.
--Create view Analisiss_orden_clientes_empleados_mesas as
--select 
--    o.codigo_orden_enc,
--    o.fecha_orden,
--    c.nombre as nombre_cliente,
--    e.nombre as nombre_empleado,
--    m.numero_mesa,
--    o.monto_total_orden,
--    o.estado as estado_orden
--from tbl_encabezado_ordenes o
--join tbl_clientes c ON o.codigo_cliente = c.codigo_cliente
--join tbl_empleados e ON o.codigo_empleado = e.codigo_empleado
--join tbl_mesas m ON o.codigo_mesa = m.codigo_mesa;



--Vista 2
--Detalle de ordenes por menus
--Create view detalle_orden_enc_orden_por_menu as
--SELECT 
--    do.codigo_orden_det,
--    do.codigo_orden_enc,
--    me.nombre AS nombre_menu,
--    me.categoria AS categoria_menu,
--    do.cantidad,
--    do.precio_unitario,
--    do.precio_total
--FROM tbl_detalles_ordenes do
--JOIN tbl_menus me ON do.codigo_menu = me.codigo_menu;


--Desgloce pago finzas
--create view Pago_orden_desgloce_Orden_det_menu as
--select
--    p.codigo_pago,
--    o.fecha_orden,
--    c.nombre AS cliente,
--    p.monto_orden,
--    p.propina,
--    p.impuesto,
--    p.descuento,
--    p.total_pago,
--    p.metodo_pago
--from tbl_pago_ordenes p
--join  tbl_encabezado_ordenes o ON p.codigo_orden_enc = o.codigo_orden_enc
--join tbl_clientes c ON o.codigo_cliente = c.codigo_cliente;




--Empleado con m·s participacion en ventas.
--create view empleado_con_mas_ventas_e_ingresos_enc_orde as
--SELECT 
--    e.nombre AS empleado,
--    e.cargo,
--    COUNT(o.codigo_orden_enc) AS total_ordenes,
--    SUM(o.monto_total_orden) AS total_ingresos
--FROM tbl_encabezado_ordenes o
--JOIN tbl_empleados e ON o.codigo_empleado = e.codigo_empleado
--GROUP BY e.nombre, e.cargo;



--Producto m·S VENDIDO
--create view producto_mas_vendido as
--SELECT 
--    m.nombre AS menu,
--    m.categoria,
--    SUM(d.cantidad) AS cantidad_total,
--    SUM(d.precio_total) AS ingresos_totales
--FROM tbl_detalles_ordenes d
--JOIN tbl_menus m ON d.codigo_menu = m.codigo_menu
--GROUP BY m.nombre, m.categoria



select table_name from information_schema.tables