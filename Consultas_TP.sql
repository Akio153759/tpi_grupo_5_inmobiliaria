/*
1. La inmobiliaria necesita un reporte de lo que va del año actual, por empleado, de la
cantidad de ventas concretadas, el promedio del monto de dichas operaciones
siempre y cuando el empleado haya hecho menos cantidad de ventas de las que
indica el objetivo mínimo individual anual. Este mínimo, es el promedio de ventas por
empleado del año anterior. Así de esta manera, la inmobiliaria puede actuar a
tiempo, antes que finalice el año comercial.
*/

select e.codEmpleado as 'Cód. Empleado',
e.nombreEmpleado + ' ' + e.apellidoEmpleado as 'Nombre completo',
count(*) as 'Cantidad de ventas',
avg(o.montoTotal) as 'Monto promedio'
from OPERACIONES o inner join EMPLEADOS e on o.codEmpleado =
e.codEmpleado inner join TIPOS_OPERACIONES t on o.idTipoOperacion =
t.idTipoOperacion
where year(o.fechaOperancion) = year(getdate()) and t.descripcion = 'Venta'
group by e.codEmpleado, e.nombreEmpleado + ' ' + e.apellidoEmpleado
having COUNT(*) < (select count(*)/count(distinct op.codEmpleado)
						from OPERACIONES op
							where year(op.fechaOperancion) = year(getdate()))


/*
2. La inmobiliaria desea saber cuáles fueron los barrios de mayor demanda en los
últimos 5 años. Para ello necesita un reporte por barrio con la cantidad de
operaciones realizadas (de cualquier tipo), los datos del barrio, siempre y cuando se
hayan realizado al menos 3 operaciones en esa área.
*/

select b.idBarrio as 'Cod. Barrio', b.barrio as 'Barrio', count(*) as 'Cant. Operaciones'
from OPERACIONES o inner join PROPIEDADES p on o.codPropiedad =
p.codPropiedad inner join BARRIOS b on p.idBarrio = b.idBarrio
where year(o.fechaOperancion) between year(getdate()) -5 and year(getdate())
group by b.idBarrio, b.barrio
having count(*) >= 3
order by 'Cant. Operaciones'

/*
3. La inmobiliaria desea conocer la cantidad de propiedades por barrio, que están
disponibles para alquilar.
*/

select lo.localidad ' localidad',ba.barrio'Barrio', count(pro.codPropiedad)' Cant
Propiedades'
from PROPIETARIOSxPROPIEDADES pXp join PROPIETARIOS pr on
pXp.idPropietario = pr.idPropietario
join PROPIEDADES pro on pro.codPropiedad = pxp.codPropiedad
join BARRIOS ba on pro.idBarrio = ba.idBarrio
join LOCALIDADES lo on lo.idLocalidad = ba.idLocalidad
where pro.aptoAlquiler=1
group by lo.localidad, ba.barrio
having count(ba.barrio)>1
order by lo.localidad


/*
4. La inmobiliaria desea llevar un registro de cuántas propiedades tiene cada
propietario disponibles a la venta y en alquiler, siempre que el apellido del propietario
comience con la letra A. Y también de cuentas propiedades tiene cada propietario no
disponibles para venta
*/
select pro.idPropietario' ID Propietario', pro.apellidoPropietario + ' ' +
pro.nombrePropietario 'Propietario',
count(pr.aptoVenta)'En venta', 'a la venta' Estado
from PROPIEDADES pr join PROPIETARIOSxPROPIEDADES pXp on
pr.codPropiedad = pXp.codPropiedad
join propietarios pro on pro.idPropietario = pXp.idPropietario
group by pro.idPropietario,pro.apellidoPropietario,
pro.nombrePropietario,pr.aptoVenta
having pr.aptoVenta=1 AND pro.apellidoPropietario like '[a]%'
UNION
select pro.idPropietario' ID Propietario', pro.apellidoPropietario + ' ' +
pro.nombrePropietario 'Propietario',
count(pr.aptoAlquiler)'En Alquiler', 'en alquiler'
from PROPIEDADES pr join PROPIETARIOSxPROPIEDADES pXp on
pr.codPropiedad = pXp.codPropiedad
join propietarios pro on pro.idPropietario = pXp.idPropietario
group by pro.idPropietario,pro.apellidoPropietario,
pro.nombrePropietario,pr.aptoAlquiler
having pr.aptoAlquiler=1 AND pro.apellidoPropietario like '[a]%'
order by 'Propietario'

/*
5. La inmobiliaria desea listar las propiedades que no se vendieron ni alquilaron este año.
*/
select p.codPropiedad, tp.tipoPropiedad, b.barrio
from propiedades p join tipos_propiedad tp on p.idTipoPropiedad =
tp.idTipoPropiedad
join barrios b on p.idBarrio = b.idBarrio
where not exists (select distinct o.idOperacion
from operaciones o
where o.idOperacion = p.codPropiedad
and year(o.fechaOperancion) = year(getdate())
)

/*
6. La inmobiliaria desea generar una lista de las propiedades mayor a 2 , por barrio y
por localidad, que están disponibles para alquilar, ordenando por nombre de
localidad.
*/
select lo.localidad ' localidad',ba.barrio'Barrio',
count(pro.codPropiedad)' Cant Propiedades'
from PROPIETARIOSxPROPIEDADES pXp join PROPIETARIOS pr on
pXp.idPropietario = pr.idPropietario
join PROPIEDADES pro on pro.codPropiedad = pxp.codPropiedad
join BARRIOS ba on pro.idBarrio = ba.idBarrio
join LOCALIDADES lo on lo.idLocalidad = ba.idLocalidad
where pro.aptoAlquiler=1
group by lo.localidad, ba.barrio
having count(ba.barrio)>1
order by lo.localidad



