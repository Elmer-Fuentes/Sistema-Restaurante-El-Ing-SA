Select * from tbl_pago_planillas

SELECT 
  codigo_pago_planilla AS ' Codigo Pago Planillas',
  codigo_empleado AS 'Código de Empleado',
  fecha_pago AS 'Fecha de Pago',
  salario AS 'Salario',
  bono AS 'Bono',
  horas_extras AS 'Horas Extras',
  monto_total AS 'Monto Total',
  estado AS 'Estado',
  usuario_sistema AS 'Usuario Sistema',
  fecha_sistema AS 'Fecha del Sistema'
FROM tbl_pago_planillas;