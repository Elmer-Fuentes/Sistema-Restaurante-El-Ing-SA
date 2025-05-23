USE Proyecto_Restaurante
GO

--1. tabla clientes
create table tbl_clientes (
			codigo_cliente int primary key identity (1,1) not null,
			nombre varchar(50) not null,
			nit varchar(20),
			telefono varchar(15),
			categoria varchar(50) not null,
			estado varchar(20) not null,
			usuario_sistema varchar(50) not null,
			fecha_sistema datetime
);

--2. tabla empleado
create table tbl_empleados(
			codigo_empleado int primary key identity (1,1) not null,
			nombre varchar(50) not null,
			cargo varchar(20) not null,
			salario decimal (10,2) not null,
			fecha_contratacion datetime not null,
			estado varchar(20) not null,
			usuario_sistema varchar(50) not null,
			fecha_sistema datetime
);

--3. tabla usuarios
create table tbl_usuarios (
			codigo_usuario int primary key identity (1,1) not null,
			codigo_empleado int not null unique,
			nombre_usuario varchar(50) not null,
			contrasena varchar(50) not null,
			rol varchar(50) not null,
			estado varchar(50) not null,
			usuario_sistema varchar(50) not null,
			FechaSistema datetime,
			foreign key (codigo_empleado) references tbl_empleados (codigo_empleado)
);

--4. tabla pago planilla
create table tbl_pago_planillas (
			codigo_pago_planilla int primary key identity (1,1),
			codigo_empleado int not null,
			fecha_pago datetime not null,
			salario decimal(10,2) not null,
			bono decimal(10,2) not null,
			horas_extras int not null,
			monto_total decimal(10,2) not null,
			estado varchar(50) not null,
			usuario_sistema varchar(50) not null,
			fecha_sistema datetime,
			foreign key (codigo_empleado) references tbl_empleados (codigo_empleado)
);

--5. tabla mesas
create table tbl_mesas (
			codigo_mesa int primary key identity (1,1) not null,
			numero_mesa int not null,
			cantidad_sillas int not null,
			ubicacion varchar(50) not null,
			tipo_mesa varchar(50) not null,
			estado varchar(50) not null,
			usuario_sistema varchar(50) not null,
			FechaSistema datetime
);

--6. tabla encabezado ordenes
create table tbl_encabezado_ordenes(
			codigo_orden_enc int primary key identity (1,1) not null,
			codigo_cliente int not null,
			codigo_mesa int not null,
			codigo_empleado int not null,
			fecha_orden datetime not null,
			monto_total_orden decimal (10,2) not null,
			estado varchar(20) not null,
			usuario_sistema varchar(50) not null,
			fecha_sistema datetime,
			foreign key (codigo_cliente) references tbl_clientes (codigo_cliente),
			foreign key (codigo_mesa) references tbl_mesas (codigo_mesa),
			foreign key (codigo_empleado) references tbl_empleados (codigo_empleado)
);

--7. tabla encabezado ordenes
create table tbl_pago_ordenes(
			codigo_pago int primary key identity (1,1) not null,
			codigo_orden_enc int not null,
			monto_orden decimal (10,2) not null,
			propina decimal (10,2),
			impuesto decimal (10,2) not null,
			descuento decimal (10,2),
			total_pago decimal (10,2) not null,
			metodo_pago varchar(50) not null,
			estado varchar(50) not null,
			fecha_pago datetime not null,
			usuario_sistema varchar(50) not null,		
			fecha_sistema datetime,
			foreign key (codigo_orden_enc) references tbl_encabezado_ordenes (codigo_orden_enc)
);

--8. tabla menus
create table tbl_menus(
			codigo_menu int primary key identity (1,1) not null,
			nombre varchar(50) not null,
			ingredientes varchar(225) not null,
			categoria varchar(50) not null,
			precio decimal(10,2) not null,
			estado varchar(50) not null,
			usuario_sistema varchar(50) not null,		
			fecha_sistema datetime
);

--9. tabla detalle ordenes
create table tbl_detalles_ordenes(
			codigo_orden_det int primary key identity (1,1) not null,
			codigo_orden_enc int not null,
			codigo_menu int not null,
			cantidad int not null, 
			precio_unitario decimal(10,2) not null,
			precio_total decimal(10,2) not null,
			usuario_sistema varchar(50) not null,		
			fecha_sistema datetime,
			foreign key (codigo_orden_enc) references tbl_encabezado_ordenes (codigo_orden_enc),
			foreign key (codigo_menu) references tbl_menus (codigo_menu)
);

--10. tabla_inventarios
create table tbl_inventarios(
			codigo_inventario int primary key identity (1,1) not null,
			codigo_menu int not null,
			categoria varchar(50) not null,
			cantidad int not null, 
			fecha_entrada datetime,
			fecha_vencimiento datetime,
			dias_vigencia int not null,
			usuario_sistema varchar(50) not null,		
			fecha_sistema datetime,
			foreign key (codigo_menu) references tbl_menus (codigo_menu)
);

begin
/*Combinados (CHAR(13) + CHAR(10)) generan un salto de línea estándar en Windows.*/
PRINT('')
PRINT 'Tablas creadas correctamente Modo Guerra mi compaaaaaaaaa' + CHAR(13) + CHAR(10) +
+CHAR(13) + CHAR(10) + 'para ver las tablas' +char(13)+CHAR(10)+
'Escribe o copia en la New Query las 3 siguientes Lineas'+ CHAR(13) + CHAR(10) ++ CHAR(13) + CHAR(10) ++ CHAR(13) + CHAR(10) +
'Use Proyecto_Restaurante'+ CHAR(13) + CHAR(10) +'go'+char(13)+char(10)+
'EXEC MODO_GUERRA ''mi compaaaaaaaaa'';'+char(13)+char(10)
end