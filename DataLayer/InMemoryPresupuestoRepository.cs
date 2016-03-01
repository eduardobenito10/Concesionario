using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class class InMemoryPresupuestoRepository implements IPresupuestoRepository {
		
    private ICollection<Presupuesto> presupuestos;
	
	public ICollection<Presupuesto> findAll(){}
		public Presupuesto findPresupuestoByID(string id){}
		public void addPresupuesto(Presupuesto presupuesto){}
		public void removePresupuesto(Presupuesto presupuesto){}

	}

}
