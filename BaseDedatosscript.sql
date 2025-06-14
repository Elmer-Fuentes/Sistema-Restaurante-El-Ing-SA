/****** Object:  Database [Proyecto_Restaurante]    Script Date: 2/6/2025 16:43:02 ******/
CREATE DATABASE [Proyecto_Restaurante]  (EDITION = 'GeneralPurpose', SERVICE_OBJECTIVE = 'GP_S_Gen5_4', MAXSIZE = 32 GB) WITH CATALOG_COLLATION = SQL_Latin1_General_CP1_CI_AS, LEDGER = OFF;
GO
ALTER DATABASE [Proyecto_Restaurante] SET COMPATIBILITY_LEVEL = 170
GO
ALTER DATABASE [Proyecto_Restaurante] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Proyecto_Restaurante] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Proyecto_Restaurante] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Proyecto_Restaurante] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Proyecto_Restaurante] SET ARITHABORT OFF 
GO
ALTER DATABASE [Proyecto_Restaurante] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Proyecto_Restaurante] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Proyecto_Restaurante] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Proyecto_Restaurante] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Proyecto_Restaurante] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Proyecto_Restaurante] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Proyecto_Restaurante] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Proyecto_Restaurante] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Proyecto_Restaurante] SET ALLOW_SNAPSHOT_ISOLATION ON 
GO
ALTER DATABASE [Proyecto_Restaurante] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Proyecto_Restaurante] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [Proyecto_Restaurante] SET  MULTI_USER 
GO
ALTER DATABASE [Proyecto_Restaurante] SET ENCRYPTION ON
GO
ALTER DATABASE [Proyecto_Restaurante] SET QUERY_STORE = ON
GO
ALTER DATABASE [Proyecto_Restaurante] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 100, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
/*** Los scripts de las configuraciones con ámbito de base de datos en Azure deben ejecutarse dentro de la conexión de base de datos de destino. ***/
GO
-- ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 8;
GO
/****** Object:  Table [dbo].[tbl_empleados]    Script Date: 2/6/2025 16:43:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_empleados](
	[codigo_empleado] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[cargo] [varchar](20) NOT NULL,
	[salario] [decimal](10, 2) NOT NULL,
	[fecha_contratacion] [datetime] NOT NULL,
	[estado] [varchar](20) NOT NULL,
	[usuario_sistema] [varchar](50) NOT NULL,
	[fecha_sistema] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_empleado] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_usuarios]    Script Date: 2/6/2025 16:43:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_usuarios](
	[codigo_usuario] [int] IDENTITY(1,1) NOT NULL,
	[codigo_empleado] [int] NOT NULL,
	[nombre_usuario] [varchar](50) NOT NULL,
	[contrasena] [varchar](50) NOT NULL,
	[rol] [varchar](50) NOT NULL,
	[estado] [varchar](50) NOT NULL,
	[usuario_sistema] [varchar](50) NOT NULL,
	[FechaSistema] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_usuario] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[usuario]    Script Date: 2/6/2025 16:43:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[usuario] as (
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
GO
/****** Object:  View [dbo].[Empleados_conYsin_Usuarios]    Script Date: 2/6/2025 16:43:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[Empleados_conYsin_Usuarios] as(	
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

GO
/****** Object:  Table [dbo].[tbl_clientes]    Script Date: 2/6/2025 16:43:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_clientes](
	[codigo_cliente] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[nit] [varchar](20) NULL,
	[telefono] [varchar](15) NULL,
	[categoria] [varchar](50) NOT NULL,
	[estado] [varchar](20) NOT NULL,
	[usuario_sistema] [varchar](50) NOT NULL,
	[fecha_sistema] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_cliente] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_mesas]    Script Date: 2/6/2025 16:43:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_mesas](
	[codigo_mesa] [int] IDENTITY(1,1) NOT NULL,
	[numero_mesa] [int] NOT NULL,
	[cantidad_sillas] [int] NOT NULL,
	[ubicacion] [varchar](50) NOT NULL,
	[tipo_mesa] [varchar](50) NOT NULL,
	[estado] [varchar](50) NOT NULL,
	[usuario_sistema] [varchar](50) NOT NULL,
	[FechaSistema] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_mesa] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_encabezado_ordenes]    Script Date: 2/6/2025 16:43:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_encabezado_ordenes](
	[codigo_orden_enc] [int] IDENTITY(1,1) NOT NULL,
	[codigo_cliente] [int] NOT NULL,
	[codigo_mesa] [int] NOT NULL,
	[codigo_empleado] [int] NOT NULL,
	[fecha_orden] [datetime] NOT NULL,
	[monto_total_orden] [decimal](10, 2) NOT NULL,
	[estado] [varchar](20) NOT NULL,
	[usuario_sistema] [varchar](50) NOT NULL,
	[fecha_sistema] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_orden_enc] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Analisiss_orden_clientes_empleados_mesas]    Script Date: 2/6/2025 16:43:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[Analisiss_orden_clientes_empleados_mesas] as
select 
    o.codigo_orden_enc,
    cast(o.fecha_orden as date) as fecha_orden,
	c.nombre as nombre_cliente,
    e.nombre as nombre_empleado,
    m.numero_mesa,
    o.monto_total_orden,
    o.estado as estado_orden
from tbl_encabezado_ordenes o
join tbl_clientes c ON o.codigo_cliente = c.codigo_cliente
join tbl_empleados e ON o.codigo_empleado = e.codigo_empleado
join tbl_mesas m ON o.codigo_mesa = m.codigo_mesa;
GO
/****** Object:  Table [dbo].[tbl_menus]    Script Date: 2/6/2025 16:43:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_menus](
	[codigo_menu] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[ingredientes] [varchar](225) NOT NULL,
	[categoria] [varchar](50) NOT NULL,
	[precio] [decimal](10, 2) NOT NULL,
	[estado] [varchar](50) NOT NULL,
	[usuario_sistema] [varchar](50) NOT NULL,
	[fecha_sistema] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_menu] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_detalles_ordenes]    Script Date: 2/6/2025 16:43:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_detalles_ordenes](
	[codigo_orden_det] [int] IDENTITY(1,1) NOT NULL,
	[codigo_orden_enc] [int] NOT NULL,
	[codigo_menu] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[precio_unitario] [decimal](10, 2) NOT NULL,
	[precio_total] [decimal](10, 2) NOT NULL,
	[usuario_sistema] [varchar](50) NOT NULL,
	[fecha_sistema] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_orden_det] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[detalle_orden_enc_orden_por_menu]    Script Date: 2/6/2025 16:43:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create view [dbo].[detalle_orden_enc_orden_por_menu] as
SELECT 
    do.codigo_orden_det,
    do.codigo_orden_enc,
    me.nombre AS nombre_menu,
    me.categoria AS categoria_menu,
    do.cantidad,
    do.precio_unitario,
    do.precio_total
FROM tbl_detalles_ordenes do
JOIN tbl_menus me ON do.codigo_menu = me.codigo_menu;
GO
/****** Object:  Table [dbo].[tbl_pago_ordenes]    Script Date: 2/6/2025 16:43:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_pago_ordenes](
	[codigo_pago] [int] IDENTITY(1,1) NOT NULL,
	[codigo_orden_enc] [int] NOT NULL,
	[monto_orden] [decimal](10, 2) NOT NULL,
	[propina] [decimal](10, 2) NULL,
	[impuesto] [decimal](10, 2) NOT NULL,
	[descuento] [decimal](10, 2) NULL,
	[total_pago] [decimal](10, 2) NOT NULL,
	[metodo_pago] [varchar](50) NOT NULL,
	[estado] [varchar](50) NOT NULL,
	[fecha_pago] [datetime] NOT NULL,
	[usuario_sistema] [varchar](50) NOT NULL,
	[fecha_sistema] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_pago] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Pago_orden_desgloce_Orden_det_menu]    Script Date: 2/6/2025 16:43:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create view [dbo].[Pago_orden_desgloce_Orden_det_menu] as
select
    p.codigo_pago,
    o.fecha_orden,
    c.nombre AS cliente,
    p.monto_orden,
    p.propina,
    p.impuesto,
    p.descuento,
    p.total_pago,
    p.metodo_pago
from tbl_pago_ordenes p
join  tbl_encabezado_ordenes o ON p.codigo_orden_enc = o.codigo_orden_enc
join tbl_clientes c ON o.codigo_cliente = c.codigo_cliente;
GO
/****** Object:  View [dbo].[empleado_con_mas_ventas_e_ingresos_enc_orde]    Script Date: 2/6/2025 16:43:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[empleado_con_mas_ventas_e_ingresos_enc_orde] as
SELECT 
    e.nombre AS empleado,
    e.cargo,
    COUNT(o.codigo_orden_enc) AS total_ordenes,
    SUM(o.monto_total_orden) AS total_ingresos
FROM tbl_encabezado_ordenes o
JOIN tbl_empleados e ON o.codigo_empleado = e.codigo_empleado
GROUP BY e.nombre, e.cargo;
GO
/****** Object:  View [dbo].[producto_mas_vendido]    Script Date: 2/6/2025 16:43:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[producto_mas_vendido] as
SELECT 
    m.nombre AS menu,
    m.categoria,

	m.ingredientes,
    SUM(d.cantidad) AS cantidad_total,
    SUM(d.precio_total) AS ingresos_totales
FROM tbl_detalles_ordenes d
JOIN tbl_menus m ON d.codigo_menu = m.codigo_menu
GROUP BY m.nombre, m.categoria,m.ingredientes
GO
/****** Object:  Table [dbo].[tbl_inventarios]    Script Date: 2/6/2025 16:43:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_inventarios](
	[codigo_inventario] [int] IDENTITY(1,1) NOT NULL,
	[codigo_menu] [int] NOT NULL,
	[categoria] [varchar](50) NOT NULL,
	[cantidad] [int] NOT NULL,
	[fecha_entrada] [datetime] NULL,
	[fecha_vencimiento] [datetime] NULL,
	[dias_vigencia] [int] NOT NULL,
	[usuario_sistema] [varchar](50) NOT NULL,
	[fecha_sistema] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_inventario] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_pago_planillas]    Script Date: 2/6/2025 16:43:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_pago_planillas](
	[codigo_pago_planilla] [int] IDENTITY(1,1) NOT NULL,
	[codigo_empleado] [int] NOT NULL,
	[fecha_pago] [datetime] NOT NULL,
	[salario] [decimal](10, 2) NOT NULL,
	[bono] [decimal](10, 2) NOT NULL,
	[horas_extras] [int] NOT NULL,
	[monto_total] [decimal](10, 2) NOT NULL,
	[estado] [varchar](50) NOT NULL,
	[usuario_sistema] [varchar](50) NOT NULL,
	[fecha_sistema] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_pago_planilla] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_clientes] ON 

INSERT [dbo].[tbl_clientes] ([codigo_cliente], [nombre], [nit], [telefono], [categoria], [estado], [usuario_sistema], [fecha_sistema]) VALUES (1, N'Laura', N'123456-1', N'555111', N'Frecuente', N'Activo', N'Ing.David', CAST(N'2025-05-31T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_clientes] ([codigo_cliente], [nombre], [nit], [telefono], [categoria], [estado], [usuario_sistema], [fecha_sistema]) VALUES (5, N'Carlos', N'234567-2', N'555222', N'Nuevo', N'Inactivo', N'Ing.David', CAST(N'2025-05-31T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_clientes] ([codigo_cliente], [nombre], [nit], [telefono], [categoria], [estado], [usuario_sistema], [fecha_sistema]) VALUES (6, N'Ana', N'345678-3', N'555333', N'Exclusivo', N'Activo', N'Ing.David', CAST(N'2025-05-31T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_clientes] ([codigo_cliente], [nombre], [nit], [telefono], [categoria], [estado], [usuario_sistema], [fecha_sistema]) VALUES (10, N'David', N'975456--5', N'8764396', N'Nuevo', N'Inactivo', N'Ing.David', CAST(N'2025-05-31T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_clientes] ([codigo_cliente], [nombre], [nit], [telefono], [categoria], [estado], [usuario_sistema], [fecha_sistema]) VALUES (11, N'David Cruz', N'12345', N'41423346', N'Exclusivo', N'Activo', N'Admin', CAST(N'2025-05-30T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_clientes] ([codigo_cliente], [nombre], [nit], [telefono], [categoria], [estado], [usuario_sistema], [fecha_sistema]) VALUES (15, N'Miguel', N'456789-4', N'555444', N'Ocasional', N'Inactivo', N'Ing.David', CAST(N'2025-05-31T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_clientes] ([codigo_cliente], [nombre], [nit], [telefono], [categoria], [estado], [usuario_sistema], [fecha_sistema]) VALUES (19, N'Carlos Rosales', N'8729835', N'9765456', N'Frecuente', N'Inactivo', N'Admin', CAST(N'2025-05-31T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_clientes] ([codigo_cliente], [nombre], [nit], [telefono], [categoria], [estado], [usuario_sistema], [fecha_sistema]) VALUES (20, N'Lucía', N'567890-5', N'555555', N'Frecuente', N'Activo', N'Ing.David', CAST(N'2025-01-01T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_clientes] ([codigo_cliente], [nombre], [nit], [telefono], [categoria], [estado], [usuario_sistema], [fecha_sistema]) VALUES (21, N'Jorge', N'678901-6', N'555666', N'Nuevo', N'Activo', N'Ing.David', CAST(N'2025-01-01T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_clientes] ([codigo_cliente], [nombre], [nit], [telefono], [categoria], [estado], [usuario_sistema], [fecha_sistema]) VALUES (22, N'Elena', N'789012-7', N'555777', N'Ocasional', N'Inactivo', N'Admin', CAST(N'2025-01-01T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_clientes] ([codigo_cliente], [nombre], [nit], [telefono], [categoria], [estado], [usuario_sistema], [fecha_sistema]) VALUES (23, N'Juan Lopez', N'456123', N'4123-1231', N'Nuevo', N'Activo', N'Admin', CAST(N'2025-06-01T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[tbl_clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_detalles_ordenes] ON 

INSERT [dbo].[tbl_detalles_ordenes] ([codigo_orden_det], [codigo_orden_enc], [codigo_menu], [cantidad], [precio_unitario], [precio_total], [usuario_sistema], [fecha_sistema]) VALUES (2, 11, 1, 1, CAST(100.00 AS Decimal(10, 2)), CAST(100.00 AS Decimal(10, 2)), N'Admin', CAST(N'2025-05-24T09:53:25.827' AS DateTime))
INSERT [dbo].[tbl_detalles_ordenes] ([codigo_orden_det], [codigo_orden_enc], [codigo_menu], [cantidad], [precio_unitario], [precio_total], [usuario_sistema], [fecha_sistema]) VALUES (13, 9, 2, 12, CAST(20.00 AS Decimal(10, 2)), CAST(240.00 AS Decimal(10, 2)), N'Admin', CAST(N'2025-05-22T21:42:32.277' AS DateTime))
INSERT [dbo].[tbl_detalles_ordenes] ([codigo_orden_det], [codigo_orden_enc], [codigo_menu], [cantidad], [precio_unitario], [precio_total], [usuario_sistema], [fecha_sistema]) VALUES (33, 20, 2, 1, CAST(20.00 AS Decimal(10, 2)), CAST(20.00 AS Decimal(10, 2)), N'Edgar', CAST(N'2025-05-30T18:55:05.327' AS DateTime))
INSERT [dbo].[tbl_detalles_ordenes] ([codigo_orden_det], [codigo_orden_enc], [codigo_menu], [cantidad], [precio_unitario], [precio_total], [usuario_sistema], [fecha_sistema]) VALUES (35, 23, 4, 10, CAST(20.00 AS Decimal(10, 2)), CAST(200.00 AS Decimal(10, 2)), N'Edgar', CAST(N'2025-05-30T18:55:24.237' AS DateTime))
INSERT [dbo].[tbl_detalles_ordenes] ([codigo_orden_det], [codigo_orden_enc], [codigo_menu], [cantidad], [precio_unitario], [precio_total], [usuario_sistema], [fecha_sistema]) VALUES (37, 24, 2, 10, CAST(20.00 AS Decimal(10, 2)), CAST(200.00 AS Decimal(10, 2)), N'Edgar', CAST(N'2025-05-30T18:55:46.133' AS DateTime))
INSERT [dbo].[tbl_detalles_ordenes] ([codigo_orden_det], [codigo_orden_enc], [codigo_menu], [cantidad], [precio_unitario], [precio_total], [usuario_sistema], [fecha_sistema]) VALUES (38, 16, 1, 10, CAST(35.00 AS Decimal(10, 2)), CAST(350.00 AS Decimal(10, 2)), N'Edgar', CAST(N'2025-05-30T18:55:57.000' AS DateTime))
INSERT [dbo].[tbl_detalles_ordenes] ([codigo_orden_det], [codigo_orden_enc], [codigo_menu], [cantidad], [precio_unitario], [precio_total], [usuario_sistema], [fecha_sistema]) VALUES (39, 25, 2, 20, CAST(20.00 AS Decimal(10, 2)), CAST(400.00 AS Decimal(10, 2)), N'Edgar', CAST(N'2025-05-30T18:56:10.803' AS DateTime))
INSERT [dbo].[tbl_detalles_ordenes] ([codigo_orden_det], [codigo_orden_enc], [codigo_menu], [cantidad], [precio_unitario], [precio_total], [usuario_sistema], [fecha_sistema]) VALUES (41, 13, 6, 10, CAST(12.00 AS Decimal(10, 2)), CAST(120.00 AS Decimal(10, 2)), N'Edgar', CAST(N'2025-05-30T18:57:06.647' AS DateTime))
INSERT [dbo].[tbl_detalles_ordenes] ([codigo_orden_det], [codigo_orden_enc], [codigo_menu], [cantidad], [precio_unitario], [precio_total], [usuario_sistema], [fecha_sistema]) VALUES (48, 26, 4, 2, CAST(20.00 AS Decimal(10, 2)), CAST(40.00 AS Decimal(10, 2)), N'Admin', CAST(N'2025-06-01T09:26:50.523' AS DateTime))
INSERT [dbo].[tbl_detalles_ordenes] ([codigo_orden_det], [codigo_orden_enc], [codigo_menu], [cantidad], [precio_unitario], [precio_total], [usuario_sistema], [fecha_sistema]) VALUES (49, 27, 2, 20, CAST(20.00 AS Decimal(10, 2)), CAST(400.00 AS Decimal(10, 2)), N'Admin', CAST(N'2025-06-01T09:28:17.130' AS DateTime))
SET IDENTITY_INSERT [dbo].[tbl_detalles_ordenes] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_empleados] ON 

INSERT [dbo].[tbl_empleados] ([codigo_empleado], [nombre], [cargo], [salario], [fecha_contratacion], [estado], [usuario_sistema], [fecha_sistema]) VALUES (1, N'Ing. Elmer De La Cruz', N'Gerente', CAST(25000.00 AS Decimal(10, 2)), CAST(N'2025-01-01T00:00:00.000' AS DateTime), N'Activo', N'Edgar', CAST(N'2025-05-28T13:40:54.597' AS DateTime))
INSERT [dbo].[tbl_empleados] ([codigo_empleado], [nombre], [cargo], [salario], [fecha_contratacion], [estado], [usuario_sistema], [fecha_sistema]) VALUES (2, N'Edgar Arevalo', N'Gerente', CAST(25000.00 AS Decimal(10, 2)), CAST(N'2020-01-01T00:00:00.000' AS DateTime), N'Activo', N'Edgar', CAST(N'2025-05-28T13:39:27.303' AS DateTime))
INSERT [dbo].[tbl_empleados] ([codigo_empleado], [nombre], [cargo], [salario], [fecha_contratacion], [estado], [usuario_sistema], [fecha_sistema]) VALUES (3, N'Dr. David Genio Incomprendido', N'Gerente', CAST(25000.00 AS Decimal(10, 2)), CAST(N'2001-01-01T00:00:00.000' AS DateTime), N'Activo', N'Edgar', CAST(N'2025-05-28T13:40:44.040' AS DateTime))
INSERT [dbo].[tbl_empleados] ([codigo_empleado], [nombre], [cargo], [salario], [fecha_contratacion], [estado], [usuario_sistema], [fecha_sistema]) VALUES (44, N'Kristel', N'Gerente', CAST(25000.00 AS Decimal(10, 2)), CAST(N'2025-05-30T10:27:13.250' AS DateTime), N'Activo', N'Admin', CAST(N'2025-05-30T10:27:25.660' AS DateTime))
INSERT [dbo].[tbl_empleados] ([codigo_empleado], [nombre], [cargo], [salario], [fecha_contratacion], [estado], [usuario_sistema], [fecha_sistema]) VALUES (45, N'Elias Melgar', N'Mesero', CAST(6000.00 AS Decimal(10, 2)), CAST(N'2025-05-30T18:49:19.400' AS DateTime), N'Inactivo', N'Edgar', CAST(N'2025-05-30T18:49:32.087' AS DateTime))
INSERT [dbo].[tbl_empleados] ([codigo_empleado], [nombre], [cargo], [salario], [fecha_contratacion], [estado], [usuario_sistema], [fecha_sistema]) VALUES (46, N'Miguel Galván', N'Mesero', CAST(6000.00 AS Decimal(10, 2)), CAST(N'2025-05-30T18:49:33.730' AS DateTime), N'Suspendido', N'Edgar', CAST(N'2025-05-30T18:49:50.013' AS DateTime))
INSERT [dbo].[tbl_empleados] ([codigo_empleado], [nombre], [cargo], [salario], [fecha_contratacion], [estado], [usuario_sistema], [fecha_sistema]) VALUES (47, N'Juan Arévalo', N'Mesero', CAST(6000.00 AS Decimal(10, 2)), CAST(N'2025-05-30T18:49:51.203' AS DateTime), N'Activo', N'Edgar', CAST(N'2025-05-30T18:50:06.903' AS DateTime))
INSERT [dbo].[tbl_empleados] ([codigo_empleado], [nombre], [cargo], [salario], [fecha_contratacion], [estado], [usuario_sistema], [fecha_sistema]) VALUES (48, N'Luis Montaner', N'Cocinero', CAST(15000.00 AS Decimal(10, 2)), CAST(N'2025-05-30T18:50:08.203' AS DateTime), N'Suspendido', N'Edgar', CAST(N'2025-05-30T18:50:27.590' AS DateTime))
INSERT [dbo].[tbl_empleados] ([codigo_empleado], [nombre], [cargo], [salario], [fecha_contratacion], [estado], [usuario_sistema], [fecha_sistema]) VALUES (49, N'Alejandro Fernandez', N'Gerente', CAST(25000.00 AS Decimal(10, 2)), CAST(N'2025-05-30T18:50:29.017' AS DateTime), N'Suspendido', N'Edgar', CAST(N'2025-05-30T18:50:42.277' AS DateTime))
INSERT [dbo].[tbl_empleados] ([codigo_empleado], [nombre], [cargo], [salario], [fecha_contratacion], [estado], [usuario_sistema], [fecha_sistema]) VALUES (50, N'Ernesto Beltran', N'Cajero', CAST(7000.00 AS Decimal(10, 2)), CAST(N'2025-05-30T18:52:12.263' AS DateTime), N'Suspendido', N'Edgar', CAST(N'2025-05-30T18:52:27.910' AS DateTime))
INSERT [dbo].[tbl_empleados] ([codigo_empleado], [nombre], [cargo], [salario], [fecha_contratacion], [estado], [usuario_sistema], [fecha_sistema]) VALUES (51, N'Eugenio Derbez', N'Gerente', CAST(25000.00 AS Decimal(10, 2)), CAST(N'2025-05-30T20:58:46.427' AS DateTime), N'Activo', N'Edgar', CAST(N'2025-05-30T20:59:14.687' AS DateTime))
INSERT [dbo].[tbl_empleados] ([codigo_empleado], [nombre], [cargo], [salario], [fecha_contratacion], [estado], [usuario_sistema], [fecha_sistema]) VALUES (52, N'Emerson Juarez', N'Gerente', CAST(25000.00 AS Decimal(10, 2)), CAST(N'2025-06-01T09:20:42.000' AS DateTime), N'Activo', N'Admin', CAST(N'2025-06-01T09:20:58.747' AS DateTime))
SET IDENTITY_INSERT [dbo].[tbl_empleados] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_encabezado_ordenes] ON 

INSERT [dbo].[tbl_encabezado_ordenes] ([codigo_orden_enc], [codigo_cliente], [codigo_mesa], [codigo_empleado], [fecha_orden], [monto_total_orden], [estado], [usuario_sistema], [fecha_sistema]) VALUES (9, 1, 1, 1, CAST(N'2024-05-10T12:30:00.000' AS DateTime), CAST(150.00 AS Decimal(10, 2)), N'Creado', N'Edgar', CAST(N'2025-05-26T18:48:07.410' AS DateTime))
INSERT [dbo].[tbl_encabezado_ordenes] ([codigo_orden_enc], [codigo_cliente], [codigo_mesa], [codigo_empleado], [fecha_orden], [monto_total_orden], [estado], [usuario_sistema], [fecha_sistema]) VALUES (10, 11, 2, 2, CAST(N'2025-05-24T06:10:49.490' AS DateTime), CAST(40.00 AS Decimal(10, 2)), N'Preparacion', N'Edgar', CAST(N'2025-05-24T06:11:15.000' AS DateTime))
INSERT [dbo].[tbl_encabezado_ordenes] ([codigo_orden_enc], [codigo_cliente], [codigo_mesa], [codigo_empleado], [fecha_orden], [monto_total_orden], [estado], [usuario_sistema], [fecha_sistema]) VALUES (11, 5, 2, 2, CAST(N'2024-05-10T13:15:00.000' AS DateTime), CAST(300.00 AS Decimal(10, 2)), N'activa', N'Edgar', CAST(N'2025-05-24T06:06:25.157' AS DateTime))
INSERT [dbo].[tbl_encabezado_ordenes] ([codigo_orden_enc], [codigo_cliente], [codigo_mesa], [codigo_empleado], [fecha_orden], [monto_total_orden], [estado], [usuario_sistema], [fecha_sistema]) VALUES (13, 5, 7, 2, CAST(N'2025-05-24T05:31:22.000' AS DateTime), CAST(300.00 AS Decimal(10, 2)), N'Preparacion', N'Edgar', CAST(N'2025-05-24T05:49:26.663' AS DateTime))
INSERT [dbo].[tbl_encabezado_ordenes] ([codigo_orden_enc], [codigo_cliente], [codigo_mesa], [codigo_empleado], [fecha_orden], [monto_total_orden], [estado], [usuario_sistema], [fecha_sistema]) VALUES (16, 5, 2, 3, CAST(N'2025-05-24T10:30:33.750' AS DateTime), CAST(175.00 AS Decimal(10, 2)), N'Entregado', N'Admin', CAST(N'2025-05-24T10:31:03.053' AS DateTime))
INSERT [dbo].[tbl_encabezado_ordenes] ([codigo_orden_enc], [codigo_cliente], [codigo_mesa], [codigo_empleado], [fecha_orden], [monto_total_orden], [estado], [usuario_sistema], [fecha_sistema]) VALUES (19, 10, 1, 2, CAST(N'2025-05-24T10:55:09.000' AS DateTime), CAST(240.00 AS Decimal(10, 2)), N'Entregado', N'Edgar', CAST(N'2025-05-24T10:56:13.330' AS DateTime))
INSERT [dbo].[tbl_encabezado_ordenes] ([codigo_orden_enc], [codigo_cliente], [codigo_mesa], [codigo_empleado], [fecha_orden], [monto_total_orden], [estado], [usuario_sistema], [fecha_sistema]) VALUES (20, 5, 2, 2, CAST(N'2025-05-24T13:54:34.000' AS DateTime), CAST(20.00 AS Decimal(10, 2)), N'Finalizado', N'Edgar', CAST(N'2025-05-24T13:55:17.057' AS DateTime))
INSERT [dbo].[tbl_encabezado_ordenes] ([codigo_orden_enc], [codigo_cliente], [codigo_mesa], [codigo_empleado], [fecha_orden], [monto_total_orden], [estado], [usuario_sistema], [fecha_sistema]) VALUES (23, 5, 1, 3, CAST(N'2025-05-24T14:08:50.000' AS DateTime), CAST(20.00 AS Decimal(10, 2)), N'Creado', N'Edgar', CAST(N'2025-05-24T14:09:36.230' AS DateTime))
INSERT [dbo].[tbl_encabezado_ordenes] ([codigo_orden_enc], [codigo_cliente], [codigo_mesa], [codigo_empleado], [fecha_orden], [monto_total_orden], [estado], [usuario_sistema], [fecha_sistema]) VALUES (24, 6, 2, 2, CAST(N'2025-05-25T09:14:30.470' AS DateTime), CAST(0.00 AS Decimal(10, 2)), N'Preparacion', N'Edgar', CAST(N'2025-05-25T09:15:04.217' AS DateTime))
INSERT [dbo].[tbl_encabezado_ordenes] ([codigo_orden_enc], [codigo_cliente], [codigo_mesa], [codigo_empleado], [fecha_orden], [monto_total_orden], [estado], [usuario_sistema], [fecha_sistema]) VALUES (25, 6, 2, 2, CAST(N'2025-05-25T09:14:30.000' AS DateTime), CAST(20.00 AS Decimal(10, 2)), N'Preparacion', N'Edgar', CAST(N'2025-05-25T09:15:41.500' AS DateTime))
INSERT [dbo].[tbl_encabezado_ordenes] ([codigo_orden_enc], [codigo_cliente], [codigo_mesa], [codigo_empleado], [fecha_orden], [monto_total_orden], [estado], [usuario_sistema], [fecha_sistema]) VALUES (26, 1, 2, 3, CAST(N'2025-05-29T20:12:29.727' AS DateTime), CAST(100.00 AS Decimal(10, 2)), N'Entregado', N'Edgar', CAST(N'2025-05-29T20:12:40.873' AS DateTime))
INSERT [dbo].[tbl_encabezado_ordenes] ([codigo_orden_enc], [codigo_cliente], [codigo_mesa], [codigo_empleado], [fecha_orden], [monto_total_orden], [estado], [usuario_sistema], [fecha_sistema]) VALUES (27, 19, 1, 2, CAST(N'2025-05-29T20:35:57.000' AS DateTime), CAST(100.00 AS Decimal(10, 2)), N'Cancelado', N'Admin', CAST(N'2025-06-01T09:24:29.587' AS DateTime))
SET IDENTITY_INSERT [dbo].[tbl_encabezado_ordenes] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_inventarios] ON 

INSERT [dbo].[tbl_inventarios] ([codigo_inventario], [codigo_menu], [categoria], [cantidad], [fecha_entrada], [fecha_vencimiento], [dias_vigencia], [usuario_sistema], [fecha_sistema]) VALUES (2, 8, N'Nuevo ', 7, CAST(N'2025-05-01T00:00:00.000' AS DateTime), CAST(N'2027-08-14T00:00:00.000' AS DateTime), 835, N'Admin', CAST(N'2025-05-31T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_inventarios] ([codigo_inventario], [codigo_menu], [categoria], [cantidad], [fecha_entrada], [fecha_vencimiento], [dias_vigencia], [usuario_sistema], [fecha_sistema]) VALUES (4, 8, N'Frecuente ', 90, CAST(N'2025-05-27T00:00:00.000' AS DateTime), CAST(N'2027-03-26T00:00:00.000' AS DateTime), 668, N'Admin', CAST(N'2025-05-31T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_inventarios] ([codigo_inventario], [codigo_menu], [categoria], [cantidad], [fecha_entrada], [fecha_vencimiento], [dias_vigencia], [usuario_sistema], [fecha_sistema]) VALUES (7, 10, N'Genio Incomprendido ', 2, CAST(N'2025-05-28T00:00:00.000' AS DateTime), CAST(N'2026-02-08T00:00:00.000' AS DateTime), 256, N'Admin', CAST(N'2025-05-31T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_inventarios] ([codigo_inventario], [codigo_menu], [categoria], [cantidad], [fecha_entrada], [fecha_vencimiento], [dias_vigencia], [usuario_sistema], [fecha_sistema]) VALUES (9, 10, N'Frecuente ', 3, CAST(N'2025-05-31T00:00:00.000' AS DateTime), CAST(N'2025-06-30T00:00:00.000' AS DateTime), 30, N'Ing.David', CAST(N'2025-05-31T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_inventarios] ([codigo_inventario], [codigo_menu], [categoria], [cantidad], [fecha_entrada], [fecha_vencimiento], [dias_vigencia], [usuario_sistema], [fecha_sistema]) VALUES (10, 10, N'Nuevo ', 4, CAST(N'2025-05-31T00:00:00.000' AS DateTime), CAST(N'2025-07-26T00:00:00.000' AS DateTime), 56, N'Admin', CAST(N'2025-05-31T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_inventarios] ([codigo_inventario], [codigo_menu], [categoria], [cantidad], [fecha_entrada], [fecha_vencimiento], [dias_vigencia], [usuario_sistema], [fecha_sistema]) VALUES (11, 6, N'Exclusivo ', 11, CAST(N'2025-05-20T00:00:00.000' AS DateTime), CAST(N'2025-05-31T00:00:00.000' AS DateTime), 11, N'Admin', CAST(N'2025-05-31T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_inventarios] ([codigo_inventario], [codigo_menu], [categoria], [cantidad], [fecha_entrada], [fecha_vencimiento], [dias_vigencia], [usuario_sistema], [fecha_sistema]) VALUES (12, 2, N'Ocasional ', 7, CAST(N'2025-05-30T00:00:00.000' AS DateTime), CAST(N'2026-04-01T00:00:00.000' AS DateTime), 306, N'Admin', CAST(N'2025-05-31T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_inventarios] ([codigo_inventario], [codigo_menu], [categoria], [cantidad], [fecha_entrada], [fecha_vencimiento], [dias_vigencia], [usuario_sistema], [fecha_sistema]) VALUES (13, 1, N'Frecuente ', 7, CAST(N'2025-05-14T00:00:00.000' AS DateTime), CAST(N'2025-08-01T00:00:00.000' AS DateTime), 79, N'Admin', CAST(N'2025-05-31T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_inventarios] ([codigo_inventario], [codigo_menu], [categoria], [cantidad], [fecha_entrada], [fecha_vencimiento], [dias_vigencia], [usuario_sistema], [fecha_sistema]) VALUES (14, 13, N'Exclusivo ', 4, CAST(N'2025-05-12T00:00:00.000' AS DateTime), CAST(N'2026-02-03T00:00:00.000' AS DateTime), 267, N'Admin', CAST(N'2025-05-31T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_inventarios] ([codigo_inventario], [codigo_menu], [categoria], [cantidad], [fecha_entrada], [fecha_vencimiento], [dias_vigencia], [usuario_sistema], [fecha_sistema]) VALUES (15, 10, N'Exclusivo ', 3, CAST(N'2025-05-31T00:00:00.000' AS DateTime), CAST(N'2025-12-26T00:00:00.000' AS DateTime), 209, N'Admin', CAST(N'2025-05-31T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[tbl_inventarios] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_menus] ON 

INSERT [dbo].[tbl_menus] ([codigo_menu], [nombre], [ingredientes], [categoria], [precio], [estado], [usuario_sistema], [fecha_sistema]) VALUES (1, N'Carne de re', N'Res', N'Ocasional', CAST(35.00 AS Decimal(10, 2)), N'activo', N'Elmer De La Cruz', CAST(N'2025-05-13T11:56:03.830' AS DateTime))
INSERT [dbo].[tbl_menus] ([codigo_menu], [nombre], [ingredientes], [categoria], [precio], [estado], [usuario_sistema], [fecha_sistema]) VALUES (2, N'Pechuga de pollo', N'Pollo, Con Papás', N'Frecuente', CAST(20.00 AS Decimal(10, 2)), N'Activo', N'Elmer De La Cruz', CAST(N'2025-05-13T11:56:44.057' AS DateTime))
INSERT [dbo].[tbl_menus] ([codigo_menu], [nombre], [ingredientes], [categoria], [precio], [estado], [usuario_sistema], [fecha_sistema]) VALUES (4, N'Pollo', N'Pollo', N'Ocasional', CAST(20.00 AS Decimal(10, 2)), N'Activo', N'Ing. Guzman', CAST(N'2025-05-13T12:20:36.080' AS DateTime))
INSERT [dbo].[tbl_menus] ([codigo_menu], [nombre], [ingredientes], [categoria], [precio], [estado], [usuario_sistema], [fecha_sistema]) VALUES (6, N'Arroz', N'Agua, Arroz, tomate', N'Ocasional', CAST(12.00 AS Decimal(10, 2)), N'Activo', N'Elmer De La Cruz', CAST(N'2025-05-13T11:57:24.343' AS DateTime))
INSERT [dbo].[tbl_menus] ([codigo_menu], [nombre], [ingredientes], [categoria], [precio], [estado], [usuario_sistema], [fecha_sistema]) VALUES (8, N'Pollo', N'Carne ', N'Ocasional', CAST(100.00 AS Decimal(10, 2)), N'Inactivo', N'Edgar Arévalo', CAST(N'2025-05-15T19:50:19.243' AS DateTime))
INSERT [dbo].[tbl_menus] ([codigo_menu], [nombre], [ingredientes], [categoria], [precio], [estado], [usuario_sistema], [fecha_sistema]) VALUES (9, N'David ', N'Carne ', N'Ocasional', CAST(100.00 AS Decimal(10, 2)), N'Activo', N'Admin', CAST(N'2025-05-20T16:49:03.160' AS DateTime))
INSERT [dbo].[tbl_menus] ([codigo_menu], [nombre], [ingredientes], [categoria], [precio], [estado], [usuario_sistema], [fecha_sistema]) VALUES (10, N'Domingonn', N'Test', N'Nuevo', CAST(50.00 AS Decimal(10, 2)), N'Activo', N'Admin', CAST(N'2025-05-22T21:57:19.207' AS DateTime))
INSERT [dbo].[tbl_menus] ([codigo_menu], [nombre], [ingredientes], [categoria], [precio], [estado], [usuario_sistema], [fecha_sistema]) VALUES (13, N'Cesar', N'Carne', N'Ocasional', CAST(100.00 AS Decimal(10, 2)), N'Inactivo', N'Edgar', CAST(N'2025-05-30T20:21:29.787' AS DateTime))
INSERT [dbo].[tbl_menus] ([codigo_menu], [nombre], [ingredientes], [categoria], [precio], [estado], [usuario_sistema], [fecha_sistema]) VALUES (14, N'Pollo', N'Pollo, con papas', N'Nuevo', CAST(50.00 AS Decimal(10, 2)), N'Activo', N'Admin', CAST(N'2025-06-01T09:22:16.797' AS DateTime))
SET IDENTITY_INSERT [dbo].[tbl_menus] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_mesas] ON 

INSERT [dbo].[tbl_mesas] ([codigo_mesa], [numero_mesa], [cantidad_sillas], [ubicacion], [tipo_mesa], [estado], [usuario_sistema], [FechaSistema]) VALUES (1, 2, 7, N'Santa Rosa', N'Juegos', N'Activo', N'Edgar', CAST(N'2025-05-23T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_mesas] ([codigo_mesa], [numero_mesa], [cantidad_sillas], [ubicacion], [tipo_mesa], [estado], [usuario_sistema], [FechaSistema]) VALUES (2, 1, 3, N'Oratorio', N'Privadas', N'Inactivo', N'david cruz', CAST(N'2025-05-03T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_mesas] ([codigo_mesa], [numero_mesa], [cantidad_sillas], [ubicacion], [tipo_mesa], [estado], [usuario_sistema], [FechaSistema]) VALUES (7, 2, 5, N'Las cabezas', N'Exterior', N'Inactivo', N'Edgar Arévalo', CAST(N'2025-05-20T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_mesas] ([codigo_mesa], [numero_mesa], [cantidad_sillas], [ubicacion], [tipo_mesa], [estado], [usuario_sistema], [FechaSistema]) VALUES (10, 3, 1, N'Santa Rosa', N'Interior', N'Inactivo', N'Admin', CAST(N'2025-05-29T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_mesas] ([codigo_mesa], [numero_mesa], [cantidad_sillas], [ubicacion], [tipo_mesa], [estado], [usuario_sistema], [FechaSistema]) VALUES (11, 3, 2, N'Las Marias', N'Exterior', N'Inactivo', N'Admin', CAST(N'2025-05-29T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_mesas] ([codigo_mesa], [numero_mesa], [cantidad_sillas], [ubicacion], [tipo_mesa], [estado], [usuario_sistema], [FechaSistema]) VALUES (12, 4, 7, N'Las cabezas', N'Juegos', N'Inactivo', N'Admin', CAST(N'2025-05-29T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_mesas] ([codigo_mesa], [numero_mesa], [cantidad_sillas], [ubicacion], [tipo_mesa], [estado], [usuario_sistema], [FechaSistema]) VALUES (13, 11, 6, N'Moyuta', N'Juegos', N'Activo', N'Admin', CAST(N'2025-05-29T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_mesas] ([codigo_mesa], [numero_mesa], [cantidad_sillas], [ubicacion], [tipo_mesa], [estado], [usuario_sistema], [FechaSistema]) VALUES (14, 9, 8, N'barbe', N'Exterior', N'Activo', N'Admin', CAST(N'2025-05-29T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_mesas] ([codigo_mesa], [numero_mesa], [cantidad_sillas], [ubicacion], [tipo_mesa], [estado], [usuario_sistema], [FechaSistema]) VALUES (15, 5, 8, N'Santa Izabel', N'Juegos', N'Activo', N'Ing.David', CAST(N'2025-05-31T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_mesas] ([codigo_mesa], [numero_mesa], [cantidad_sillas], [ubicacion], [tipo_mesa], [estado], [usuario_sistema], [FechaSistema]) VALUES (16, 1, 4, N'Cuilapa', N'Interior', N'Inactivo', N'Ing.David', CAST(N'2025-05-31T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_mesas] ([codigo_mesa], [numero_mesa], [cantidad_sillas], [ubicacion], [tipo_mesa], [estado], [usuario_sistema], [FechaSistema]) VALUES (17, 1, 2, N'test', N'Interior', N'Activo', N'Admin', CAST(N'2025-06-01T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[tbl_mesas] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_pago_ordenes] ON 

INSERT [dbo].[tbl_pago_ordenes] ([codigo_pago], [codigo_orden_enc], [monto_orden], [propina], [impuesto], [descuento], [total_pago], [metodo_pago], [estado], [fecha_pago], [usuario_sistema], [fecha_sistema]) VALUES (15, 19, CAST(240.00 AS Decimal(10, 2)), CAST(24.00 AS Decimal(10, 2)), CAST(28.80 AS Decimal(10, 2)), CAST(7.20 AS Decimal(10, 2)), CAST(285.60 AS Decimal(10, 2)), N'Efectivo', N'Completado', CAST(N'2025-05-26T18:49:21.007' AS DateTime), N'Edgar', CAST(N'2025-05-26T18:50:21.357' AS DateTime))
INSERT [dbo].[tbl_pago_ordenes] ([codigo_pago], [codigo_orden_enc], [monto_orden], [propina], [impuesto], [descuento], [total_pago], [metodo_pago], [estado], [fecha_pago], [usuario_sistema], [fecha_sistema]) VALUES (16, 11, CAST(300.00 AS Decimal(10, 2)), CAST(30.00 AS Decimal(10, 2)), CAST(36.00 AS Decimal(10, 2)), CAST(9.00 AS Decimal(10, 2)), CAST(357.00 AS Decimal(10, 2)), N'Tarjeta', N'Completado', CAST(N'2025-05-27T10:49:13.893' AS DateTime), N'Edgar', CAST(N'2025-05-27T10:49:25.727' AS DateTime))
INSERT [dbo].[tbl_pago_ordenes] ([codigo_pago], [codigo_orden_enc], [monto_orden], [propina], [impuesto], [descuento], [total_pago], [metodo_pago], [estado], [fecha_pago], [usuario_sistema], [fecha_sistema]) VALUES (17, 25, CAST(20.00 AS Decimal(10, 2)), CAST(2.00 AS Decimal(10, 2)), CAST(2.40 AS Decimal(10, 2)), CAST(0.40 AS Decimal(10, 2)), CAST(24.00 AS Decimal(10, 2)), N'Efectivo', N'Parcial', CAST(N'2025-05-30T18:53:47.160' AS DateTime), N'Edgar', CAST(N'2025-05-30T18:53:54.607' AS DateTime))
INSERT [dbo].[tbl_pago_ordenes] ([codigo_pago], [codigo_orden_enc], [monto_orden], [propina], [impuesto], [descuento], [total_pago], [metodo_pago], [estado], [fecha_pago], [usuario_sistema], [fecha_sistema]) VALUES (18, 11, CAST(300.00 AS Decimal(10, 2)), CAST(30.00 AS Decimal(10, 2)), CAST(36.00 AS Decimal(10, 2)), CAST(9.00 AS Decimal(10, 2)), CAST(357.00 AS Decimal(10, 2)), N'Transferencia', N'Parcial', CAST(N'2025-05-30T18:53:55.580' AS DateTime), N'Edgar', CAST(N'2025-05-30T18:54:02.133' AS DateTime))
INSERT [dbo].[tbl_pago_ordenes] ([codigo_pago], [codigo_orden_enc], [monto_orden], [propina], [impuesto], [descuento], [total_pago], [metodo_pago], [estado], [fecha_pago], [usuario_sistema], [fecha_sistema]) VALUES (19, 19, CAST(240.00 AS Decimal(10, 2)), CAST(24.00 AS Decimal(10, 2)), CAST(28.80 AS Decimal(10, 2)), CAST(7.20 AS Decimal(10, 2)), CAST(285.60 AS Decimal(10, 2)), N'Efectivo', N'Parcial', CAST(N'2025-05-30T18:54:03.203' AS DateTime), N'Edgar', CAST(N'2025-05-30T18:54:08.373' AS DateTime))
INSERT [dbo].[tbl_pago_ordenes] ([codigo_pago], [codigo_orden_enc], [monto_orden], [propina], [impuesto], [descuento], [total_pago], [metodo_pago], [estado], [fecha_pago], [usuario_sistema], [fecha_sistema]) VALUES (20, 25, CAST(20.00 AS Decimal(10, 2)), CAST(2.00 AS Decimal(10, 2)), CAST(2.40 AS Decimal(10, 2)), CAST(0.40 AS Decimal(10, 2)), CAST(24.00 AS Decimal(10, 2)), N'Transferencia', N'Pendiente', CAST(N'2025-05-12T18:54:09.000' AS DateTime), N'Edgar', CAST(N'2025-05-30T18:54:17.390' AS DateTime))
INSERT [dbo].[tbl_pago_ordenes] ([codigo_pago], [codigo_orden_enc], [monto_orden], [propina], [impuesto], [descuento], [total_pago], [metodo_pago], [estado], [fecha_pago], [usuario_sistema], [fecha_sistema]) VALUES (21, 19, CAST(240.00 AS Decimal(10, 2)), CAST(24.00 AS Decimal(10, 2)), CAST(28.80 AS Decimal(10, 2)), CAST(7.20 AS Decimal(10, 2)), CAST(285.60 AS Decimal(10, 2)), N'Tarjeta', N'Parcial', CAST(N'2025-05-30T18:54:18.693' AS DateTime), N'Edgar', CAST(N'2025-05-30T18:54:26.410' AS DateTime))
INSERT [dbo].[tbl_pago_ordenes] ([codigo_pago], [codigo_orden_enc], [monto_orden], [propina], [impuesto], [descuento], [total_pago], [metodo_pago], [estado], [fecha_pago], [usuario_sistema], [fecha_sistema]) VALUES (22, 16, CAST(175.00 AS Decimal(10, 2)), CAST(17.50 AS Decimal(10, 2)), CAST(21.00 AS Decimal(10, 2)), CAST(5.25 AS Decimal(10, 2)), CAST(208.25 AS Decimal(10, 2)), N'Efectivo', N'Completado', CAST(N'2025-05-13T18:54:27.000' AS DateTime), N'Edgar', CAST(N'2025-05-30T18:54:36.737' AS DateTime))
INSERT [dbo].[tbl_pago_ordenes] ([codigo_pago], [codigo_orden_enc], [monto_orden], [propina], [impuesto], [descuento], [total_pago], [metodo_pago], [estado], [fecha_pago], [usuario_sistema], [fecha_sistema]) VALUES (23, 19, CAST(240.00 AS Decimal(10, 2)), CAST(24.00 AS Decimal(10, 2)), CAST(28.80 AS Decimal(10, 2)), CAST(7.20 AS Decimal(10, 2)), CAST(285.60 AS Decimal(10, 2)), N'Tarjeta', N'Completado', CAST(N'2025-05-13T18:54:37.000' AS DateTime), N'Edgar', CAST(N'2025-05-30T18:54:44.773' AS DateTime))
INSERT [dbo].[tbl_pago_ordenes] ([codigo_pago], [codigo_orden_enc], [monto_orden], [propina], [impuesto], [descuento], [total_pago], [metodo_pago], [estado], [fecha_pago], [usuario_sistema], [fecha_sistema]) VALUES (24, 10, CAST(40.00 AS Decimal(10, 2)), CAST(4.00 AS Decimal(10, 2)), CAST(4.80 AS Decimal(10, 2)), CAST(0.80 AS Decimal(10, 2)), CAST(48.00 AS Decimal(10, 2)), N'Efectivo', N'Parcial', CAST(N'2025-05-30T20:22:38.450' AS DateTime), N'Edgar', CAST(N'2025-05-30T20:22:50.610' AS DateTime))
INSERT [dbo].[tbl_pago_ordenes] ([codigo_pago], [codigo_orden_enc], [monto_orden], [propina], [impuesto], [descuento], [total_pago], [metodo_pago], [estado], [fecha_pago], [usuario_sistema], [fecha_sistema]) VALUES (25, 25, CAST(20.00 AS Decimal(10, 2)), CAST(2.00 AS Decimal(10, 2)), CAST(2.40 AS Decimal(10, 2)), CAST(0.40 AS Decimal(10, 2)), CAST(24.00 AS Decimal(10, 2)), N'Transferencia', N'Pendiente', CAST(N'2025-05-12T18:54:09.000' AS DateTime), N'Edgar', CAST(N'2025-05-31T12:53:44.927' AS DateTime))
SET IDENTITY_INSERT [dbo].[tbl_pago_ordenes] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_pago_planillas] ON 

INSERT [dbo].[tbl_pago_planillas] ([codigo_pago_planilla], [codigo_empleado], [fecha_pago], [salario], [bono], [horas_extras], [monto_total], [estado], [usuario_sistema], [fecha_sistema]) VALUES (41, 1, CAST(N'2025-05-26T15:11:58.097' AS DateTime), CAST(15000.00 AS Decimal(10, 2)), CAST(1500.00 AS Decimal(10, 2)), 1, CAST(16515.00 AS Decimal(10, 2)), N'Pendiente ', N'Edgar', CAST(N'2025-05-26T15:12:09.630' AS DateTime))
INSERT [dbo].[tbl_pago_planillas] ([codigo_pago_planilla], [codigo_empleado], [fecha_pago], [salario], [bono], [horas_extras], [monto_total], [estado], [usuario_sistema], [fecha_sistema]) VALUES (42, 2, CAST(N'2025-05-26T15:12:10.957' AS DateTime), CAST(25000.00 AS Decimal(10, 2)), CAST(2500.00 AS Decimal(10, 2)), 12, CAST(27680.00 AS Decimal(10, 2)), N'Pendiente ', N'Edgar', CAST(N'2025-05-26T15:12:21.803' AS DateTime))
INSERT [dbo].[tbl_pago_planillas] ([codigo_pago_planilla], [codigo_empleado], [fecha_pago], [salario], [bono], [horas_extras], [monto_total], [estado], [usuario_sistema], [fecha_sistema]) VALUES (43, 3, CAST(N'2025-05-26T15:12:22.927' AS DateTime), CAST(15000.00 AS Decimal(10, 2)), CAST(1500.00 AS Decimal(10, 2)), 18, CAST(16770.00 AS Decimal(10, 2)), N'Pagado ', N'Edgar', CAST(N'2025-05-26T15:12:32.833' AS DateTime))
INSERT [dbo].[tbl_pago_planillas] ([codigo_pago_planilla], [codigo_empleado], [fecha_pago], [salario], [bono], [horas_extras], [monto_total], [estado], [usuario_sistema], [fecha_sistema]) VALUES (44, 1, CAST(N'2025-05-27T10:48:53.823' AS DateTime), CAST(15000.00 AS Decimal(10, 2)), CAST(1500.00 AS Decimal(10, 2)), 1, CAST(16515.00 AS Decimal(10, 2)), N'Pagado ', N'Edgar', CAST(N'2025-05-27T10:49:02.757' AS DateTime))
INSERT [dbo].[tbl_pago_planillas] ([codigo_pago_planilla], [codigo_empleado], [fecha_pago], [salario], [bono], [horas_extras], [monto_total], [estado], [usuario_sistema], [fecha_sistema]) VALUES (45, 44, CAST(N'2025-05-30T10:29:43.727' AS DateTime), CAST(25000.00 AS Decimal(10, 2)), CAST(2500.00 AS Decimal(10, 2)), 1, CAST(27515.00 AS Decimal(10, 2)), N'Proceso ', N'Kristel', CAST(N'2025-05-30T10:29:59.427' AS DateTime))
INSERT [dbo].[tbl_pago_planillas] ([codigo_pago_planilla], [codigo_empleado], [fecha_pago], [salario], [bono], [horas_extras], [monto_total], [estado], [usuario_sistema], [fecha_sistema]) VALUES (46, 50, CAST(N'2025-05-30T18:52:31.337' AS DateTime), CAST(7000.00 AS Decimal(10, 2)), CAST(700.00 AS Decimal(10, 2)), 1, CAST(7715.00 AS Decimal(10, 2)), N'Pagado ', N'Edgar', CAST(N'2025-05-30T18:52:40.663' AS DateTime))
INSERT [dbo].[tbl_pago_planillas] ([codigo_pago_planilla], [codigo_empleado], [fecha_pago], [salario], [bono], [horas_extras], [monto_total], [estado], [usuario_sistema], [fecha_sistema]) VALUES (47, 49, CAST(N'2025-05-30T18:52:42.057' AS DateTime), CAST(25000.00 AS Decimal(10, 2)), CAST(2500.00 AS Decimal(10, 2)), 1, CAST(27515.00 AS Decimal(10, 2)), N'Pendiente ', N'Edgar', CAST(N'2025-05-30T18:52:57.117' AS DateTime))
INSERT [dbo].[tbl_pago_planillas] ([codigo_pago_planilla], [codigo_empleado], [fecha_pago], [salario], [bono], [horas_extras], [monto_total], [estado], [usuario_sistema], [fecha_sistema]) VALUES (48, 48, CAST(N'2025-05-30T18:52:58.297' AS DateTime), CAST(15000.00 AS Decimal(10, 2)), CAST(1500.00 AS Decimal(10, 2)), 1, CAST(16515.00 AS Decimal(10, 2)), N'Proceso ', N'Edgar', CAST(N'2025-05-30T18:53:08.550' AS DateTime))
INSERT [dbo].[tbl_pago_planillas] ([codigo_pago_planilla], [codigo_empleado], [fecha_pago], [salario], [bono], [horas_extras], [monto_total], [estado], [usuario_sistema], [fecha_sistema]) VALUES (49, 45, CAST(N'2025-05-30T18:53:09.870' AS DateTime), CAST(6000.00 AS Decimal(10, 2)), CAST(600.00 AS Decimal(10, 2)), 2, CAST(6630.00 AS Decimal(10, 2)), N'Proceso ', N'Edgar', CAST(N'2025-05-30T18:53:21.520' AS DateTime))
INSERT [dbo].[tbl_pago_planillas] ([codigo_pago_planilla], [codigo_empleado], [fecha_pago], [salario], [bono], [horas_extras], [monto_total], [estado], [usuario_sistema], [fecha_sistema]) VALUES (50, 46, CAST(N'2025-05-30T18:53:22.487' AS DateTime), CAST(6000.00 AS Decimal(10, 2)), CAST(600.00 AS Decimal(10, 2)), 1, CAST(6615.00 AS Decimal(10, 2)), N'Pagado ', N'Edgar', CAST(N'2025-05-30T18:53:31.030' AS DateTime))
SET IDENTITY_INSERT [dbo].[tbl_pago_planillas] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_usuarios] ON 

INSERT [dbo].[tbl_usuarios] ([codigo_usuario], [codigo_empleado], [nombre_usuario], [contrasena], [rol], [estado], [usuario_sistema], [FechaSistema]) VALUES (11, 2, N'Edgar', N'123', N'Administrador', N'Activo', N'Dr.Edgar Arevalo', CAST(N'2025-05-23T15:44:54.640' AS DateTime))
INSERT [dbo].[tbl_usuarios] ([codigo_usuario], [codigo_empleado], [nombre_usuario], [contrasena], [rol], [estado], [usuario_sistema], [FechaSistema]) VALUES (18, 3, N'Ing.David', N'123', N'Administrador', N'Activo', N'Elmer De La Cruz', CAST(N'2025-05-07T22:32:55.477' AS DateTime))
INSERT [dbo].[tbl_usuarios] ([codigo_usuario], [codigo_empleado], [nombre_usuario], [contrasena], [rol], [estado], [usuario_sistema], [FechaSistema]) VALUES (33, 44, N'Kristel', N'123', N'Caja', N'Activo', N'Admin', CAST(N'2025-06-01T08:43:31.087' AS DateTime))
INSERT [dbo].[tbl_usuarios] ([codigo_usuario], [codigo_empleado], [nombre_usuario], [contrasena], [rol], [estado], [usuario_sistema], [FechaSistema]) VALUES (36, 47, N'JuanA', N'123', N'Admin', N'Activo', N'Edgar', CAST(N'2025-05-30T20:48:39.717' AS DateTime))
INSERT [dbo].[tbl_usuarios] ([codigo_usuario], [codigo_empleado], [nombre_usuario], [contrasena], [rol], [estado], [usuario_sistema], [FechaSistema]) VALUES (37, 46, N'MGalvan', N'159', N'Admin', N'Activo', N'Edgar', CAST(N'2025-05-30T20:59:47.193' AS DateTime))
INSERT [dbo].[tbl_usuarios] ([codigo_usuario], [codigo_empleado], [nombre_usuario], [contrasena], [rol], [estado], [usuario_sistema], [FechaSistema]) VALUES (38, 48, N'LMontaner', N'147', N'Cocina', N'Activo', N'Edgar', CAST(N'2025-05-30T21:00:06.493' AS DateTime))
INSERT [dbo].[tbl_usuarios] ([codigo_usuario], [codigo_empleado], [nombre_usuario], [contrasena], [rol], [estado], [usuario_sistema], [FechaSistema]) VALUES (39, 50, N'Ebeltran', N'162', N'Cocina', N'Activo', N'Edgar', CAST(N'2025-05-30T21:00:24.727' AS DateTime))
INSERT [dbo].[tbl_usuarios] ([codigo_usuario], [codigo_empleado], [nombre_usuario], [contrasena], [rol], [estado], [usuario_sistema], [FechaSistema]) VALUES (40, 49, N'AFernandez', N'789', N'Admin', N'Activo', N'Edgar', CAST(N'2025-05-30T21:00:45.953' AS DateTime))
INSERT [dbo].[tbl_usuarios] ([codigo_usuario], [codigo_empleado], [nombre_usuario], [contrasena], [rol], [estado], [usuario_sistema], [FechaSistema]) VALUES (41, 1, N'Admin', N'123', N'Administrador', N'Activo', N'Ing.David', CAST(N'2025-06-01T08:47:11.377' AS DateTime))
SET IDENTITY_INSERT [dbo].[tbl_usuarios] OFF
GO
/****** Object:  Index [UQ_tbl_detalles_ordenes_codigo_orden_enc]    Script Date: 2/6/2025 16:43:04 ******/
ALTER TABLE [dbo].[tbl_detalles_ordenes] ADD  CONSTRAINT [UQ_tbl_detalles_ordenes_codigo_orden_enc] UNIQUE NONCLUSTERED 
(
	[codigo_orden_enc] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_tbl_detalles_ordenes]    Script Date: 2/6/2025 16:43:04 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_tbl_detalles_ordenes] ON [dbo].[tbl_detalles_ordenes]
(
	[codigo_orden_det] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UQ_tbl_usuarios_codigo_empleado]    Script Date: 2/6/2025 16:43:04 ******/
ALTER TABLE [dbo].[tbl_usuarios] ADD  CONSTRAINT [UQ_tbl_usuarios_codigo_empleado] UNIQUE NONCLUSTERED 
(
	[codigo_empleado] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbl_detalles_ordenes]  WITH CHECK ADD FOREIGN KEY([codigo_orden_enc])
REFERENCES [dbo].[tbl_encabezado_ordenes] ([codigo_orden_enc])
GO
ALTER TABLE [dbo].[tbl_detalles_ordenes]  WITH CHECK ADD FOREIGN KEY([codigo_menu])
REFERENCES [dbo].[tbl_menus] ([codigo_menu])
GO
ALTER TABLE [dbo].[tbl_encabezado_ordenes]  WITH CHECK ADD FOREIGN KEY([codigo_cliente])
REFERENCES [dbo].[tbl_clientes] ([codigo_cliente])
GO
ALTER TABLE [dbo].[tbl_encabezado_ordenes]  WITH CHECK ADD FOREIGN KEY([codigo_mesa])
REFERENCES [dbo].[tbl_mesas] ([codigo_mesa])
GO
ALTER TABLE [dbo].[tbl_encabezado_ordenes]  WITH CHECK ADD FOREIGN KEY([codigo_empleado])
REFERENCES [dbo].[tbl_empleados] ([codigo_empleado])
GO
ALTER TABLE [dbo].[tbl_inventarios]  WITH CHECK ADD FOREIGN KEY([codigo_menu])
REFERENCES [dbo].[tbl_menus] ([codigo_menu])
GO
ALTER TABLE [dbo].[tbl_pago_ordenes]  WITH CHECK ADD FOREIGN KEY([codigo_orden_enc])
REFERENCES [dbo].[tbl_encabezado_ordenes] ([codigo_orden_enc])
GO
ALTER TABLE [dbo].[tbl_pago_planillas]  WITH CHECK ADD FOREIGN KEY([codigo_empleado])
REFERENCES [dbo].[tbl_empleados] ([codigo_empleado])
GO
ALTER TABLE [dbo].[tbl_usuarios]  WITH CHECK ADD FOREIGN KEY([codigo_empleado])
REFERENCES [dbo].[tbl_empleados] ([codigo_empleado])
GO
/****** Object:  StoredProcedure [dbo].[busqueda_Cod_Empleado]    Script Date: 2/6/2025 16:43:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create Proc [dbo].[busqueda_Cod_Empleado] (
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
GO
/****** Object:  StoredProcedure [dbo].[MODO_GUERRA]    Script Date: 2/6/2025 16:43:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MODO_GUERRA] (
    @sources VARCHAR(20)
)
AS
BEGIN
    SET @sources = LOWER('%mi_compa%');

    IF @sources LIKE '%mi_compa%'
    BEGIN
        SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES;
    END;
END;
GO
/****** Object:  StoredProcedure [dbo].[Ups_Data_Dash_Emp_user]    Script Date: 2/6/2025 16:43:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[Ups_Data_Dash_Emp_user] 
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
GO
/****** Object:  StoredProcedure [dbo].[Ups_usuarios]    Script Date: 2/6/2025 16:43:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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


create proc [dbo].[Ups_usuarios]
	@nombre_usuario varchar(50)
as
begin 
select 
	a.codigo_usuario
	,a.codigo_empleado
	,a.nombre_usuario
	,a.contrasena
	,a.rol
	,a.estado
	,a.usuario_sistema
	,a.FechaSistema
from tbl_usuarios a
where Upper(Trim(a.nombre_usuario)) like '%' + Upper(Trim(@nombre_usuario))+ '%'
end
GO
/****** Object:  StoredProcedure [dbo].[USP_BusCliente]    Script Date: 2/6/2025 16:43:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[USP_BusCliente]
    @nombre VARCHAR(50)
AS
BEGIN
   	select 
	c.codigo_cliente As 'CodigoCliente',
	c.nombre As 'NombredelCliente',
	c.Nit,
	c.Telefono,
	c.Categoria,
	c.Estado,
	c.usuario_sistema  As 'UsuarioDelSistema',
	c.fecha_sistema
	from tbl_clientes c
	 where UPPER(TRIM(c.nombre)) LIKE '%' + UPPER(TRIM(@nombre)) + '%';
END;

GO
/****** Object:  StoredProcedure [dbo].[USP_BusEmpleadoSin_Usuario]    Script Date: 2/6/2025 16:43:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[USP_BusEmpleadoSin_Usuario]
    @Empleado_nombre VARCHAR(50)
AS
BEGIN
   	select 
			--a.codigo_usuario as 'Uid',
			e.codigo_empleado as 'Codigo_Empleado',
			e.nombre as 'Nombre_Colaborador',
			--a.nombre_usuario as 'Nombre Del Usuario',
			e.Cargo as 'Puesto_de_Trabajo',
			e.Fecha_Contratacion as 'Fecha_De_Contrataciòn',
			e.Estado,
			Case when nombre != '' then 'Empleados_sin_Usuarios' end as 'Observaciòn'  
	from tbl_usuarios a
	 right join tbl_empleados e on a.codigo_empleado = e.codigo_empleado
	 where a.nombre_usuario is null and
  UPPER(TRIM(nombre)) LIKE '%' + UPPER(TRIM(@Empleado_nombre)) + '%';
END;


GO
/****** Object:  StoredProcedure [dbo].[Usp_detalles_ordenes]    Script Date: 2/6/2025 16:43:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Usp_detalles_ordenes] (
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
GO
/****** Object:  StoredProcedure [dbo].[Usp_Encabezado_ordenes]    Script Date: 2/6/2025 16:43:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[Usp_Encabezado_ordenes](
 @nombre_cliente varchar(50)

)
as
begin
select 
a.Codigo_Orden_Enc
,a.Codigo_Cliente,
c.Nombre as Nombre_Cliente,
c.Categoria,
a.Codigo_Mesa,
Concat('Nùmero De Mesa: ',m.numero_mesa,' - Cantidad Sillas:',m.cantidad_sillas) as 'Detalle_Mesa',
a.Codigo_Empleado,
Concat(' - Nombre Empleado:', e.nombre, ' - Cargo: ',e.cargo) as 'Detalle_Empleado',
a.Fecha_Orden,
a.Monto_Total_Orden,
a.Estado,
a.Usuario_Sistema,
a.Fecha_Sistema
from tbl_encabezado_ordenes a
 left join tbl_clientes c on a.codigo_cliente = c.codigo_cliente
 left join tbl_mesas m on a.codigo_mesa = m.codigo_mesa
 left join tbl_empleados e  on a.codigo_empleado = e.codigo_empleado
end
GO
/****** Object:  StoredProcedure [dbo].[USP_Inventario_Menu]    Script Date: 2/6/2025 16:43:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_Inventario_Menu]
	@nombre varchar (50)
as
begin
select 
	 i.codigo_inventario
	,i.codigo_menu
	,a.nombre as 'Nombre_Menu'
	,a.Precio
	,i.categoria
	,i.cantidad
	,i.fecha_entrada
	,i.fecha_vencimiento
	,i.dias_vigencia
	,i.usuario_sistema
	,i.fecha_sistema
from tbl_inventarios i
	left join tbl_menus a on i.codigo_menu = a.codigo_menu
	where Lower(Trim(a.nombre)) like '%'+ Lower(Trim(@nombre))+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[Usp_mesas]    Script Date: 2/6/2025 16:43:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[Usp_mesas] (
@tipomesas varchar(50)

)
as
begin 
select Codigo_Mesa
,Numero_Mesa
,Cantidad_Sillas
,Ubicacion
,Tipo_Mesa
,Estado
,Usuario_Sistema
,FechaSistema
from tbl_mesas
end
GO
/****** Object:  StoredProcedure [dbo].[Usp_pago_ordenes]    Script Date: 2/6/2025 16:43:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[Usp_pago_ordenes]
(
@informacion_cliente varchar(50)
)
as
begin 
select 
p.Codigo_Pago,
p.Codigo_Orden_Enc,
Concat('Codigo: ',e.codigo_cliente,' - Nombre',c.nombre) as Informacion_Cliente,
Concat('Codigo: ',e.codigo_mesa,' - Total Sillas: ',m.cantidad_sillas,' - Tipo De Mesa: ' ,m.tipo_mesa) as Descripcion_Mesa,
Cast(e.codigo_empleado as varchar) + ' - '+ em.nombre as Empleado,
p.Monto_Orden,
p.Propina,
p.Impuesto,
p.Descuento,
p.Total_Pago,
p.Metodo_Pago,
p.Estado,
p.Fecha_Pago,
p.Usuario_Sistema,
p.Fecha_Sistema
from tbl_pago_ordenes p
join tbl_encabezado_ordenes e on p.codigo_orden_enc = e.codigo_orden_enc
join tbl_clientes c on  e.codigo_cliente = c.codigo_cliente
join tbl_mesas m on e.codigo_mesa = m.codigo_mesa
join tbl_empleados em on e.codigo_empleado = em.codigo_empleado
end
GO
/****** Object:  StoredProcedure [dbo].[Usp_Pago_Planilla]    Script Date: 2/6/2025 16:43:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[Usp_Pago_Planilla]
@nombre varchar(50)
as 
Begin 
		select 
		 q.codigo_pago_planilla
		,q.codigo_empleado
		,r.nombre
		,r.cargo
		,cast(r.fecha_contratacion as date) as Fecha_Contratacion
		,r.estado as Estado_Colaborador
		,cast(q.fecha_pago as date) as Fecha_Pago
		,q.salario
		,q.bono
		,q.horas_extras
		,q.monto_total
		,q.estado
		,q.usuario_sistema
		,q.fecha_sistema
		from tbl_pago_planillas q
		left join tbl_empleados r on q.codigo_empleado = r.codigo_empleado
		where lower(Trim(r.nombre)) like +'%'+Lower(Trim(@nombre)) + '%'
end

GO
/****** Object:  StoredProcedure [dbo].[Usp_sel_empleados]    Script Date: 2/6/2025 16:43:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[Usp_sel_empleados] 
	@nombre varchar (50)
as
begin 
	select 
	a.codigo_empleado 
	,a.nombre as Nombre_Empleado
	,a.cargo
	,a.salario
	,a.fecha_contratacion
	,a.estado
	,a.usuario_sistema
	,a.fecha_sistema	
	from tbl_empleados a
	where Upper(Trim(a.nombre)) like + '%'+ Upper(Trim(@nombre)) +'%'
end
GO
ALTER DATABASE [Proyecto_Restaurante] SET  READ_WRITE 
GO
