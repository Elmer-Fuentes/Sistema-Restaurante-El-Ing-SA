UPDATE tbl_pago_planillas  
SET 
    codigo_empleado = 1,
    fecha_pago = '2025-05-20',
    salario = 3500.00,
    bono = 500.00,
    horas_extras = 8,
    monto_total = 4000.00,
    estado = 'Activo',
    usuario_sistema = 'sarai123',
    fecha_sistema = GETDATE()
WHERE 
    codigo_pago_planilla = 101;
	   