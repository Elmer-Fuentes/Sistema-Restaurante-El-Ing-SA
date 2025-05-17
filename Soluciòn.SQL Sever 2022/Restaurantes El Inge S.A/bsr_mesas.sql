select codigo_mesa as 'Codigo Mesa',
numero_mesa as 'Numero de Mesa',
cantidad_sillas as 'Cantidad de Sillas',
ubicacion as 'Ubicacion',
tipo_mesa as 'Tipo de Mesa',
estado as 'Estado',
usuario_sistema as 'Usuario de el Sistema',
FechaSistema as 'Fecha'
from tbl_mesas where lower(usuario_sistema) like '%' +@usuario_sistema +'%'