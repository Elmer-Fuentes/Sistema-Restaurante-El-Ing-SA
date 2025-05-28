--script para buscar por fecha de entrada
select codigo_inventario as 'Codigo Inventario',
codigo_menu as 'Codigo Menu',
categoria as 'Categoria',
cantidad as 'Cantidad',
fecha_entrada as 'Fecha Entrada', 
fecha_vencimiento as 'Fecha Vencimiento',
dias_vigencia as 'Dias de Vigencia',
usuario_sistema as 'Usuario Sistema',
fecha_sistema as 'Fecha del Sistema'
from tbl_inventarios where fecha_entrada = @fecha_entrada 