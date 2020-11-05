select lo.localidad ' localidad',
		ba.barrio'Barrio', 
		count(pro.codPropiedad)' CantPropiedades'
from PROPIETARIOSxPROPIEDADES pXp join PROPIETARIOS pr on
	pXp.idPropietario = pr.idPropietario
	join PROPIEDADES pro on pro.codPropiedad = pxp.codPropiedad
	join BARRIOS ba on pro.idBarrio = ba.idBarrio
	join LOCALIDADES lo on lo.idLocalidad = ba.idLocalidad
where pro.aptoAlquiler=1 
	group by lo.localidad, ba.barrio
		having count(ba.barrio)>1
		order by lo.localidad