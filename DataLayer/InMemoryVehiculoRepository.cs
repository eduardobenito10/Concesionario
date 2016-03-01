using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class class InMemoryVehiculoRepository implements IVehiculoRepository {
		
    private ICollection<Vehiculo> vehiculos;
	
	public ICollection<Vehiculo> findAll(){}
		public Vehiculo findVehiculoByID(string id){}
		public void addVehiculo(Vehiculo vehiculo){}
		public void removeVehiculo(Vehiculo vehiculo){}

	}

}
