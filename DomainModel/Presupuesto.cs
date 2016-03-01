using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace DomainModel
{
    public class Presupuesto
    {
        public int Id { get; private set; }
        public string Estado { get; private set; }
        public double Importe { get; private set; }

        [ForeignKey("Cliente")]
        public int ClienteId { get; set; }
        public virtual Vehiculo vehiculo { get; set; }

        [ForeignKey("Vehiculo")]
        public int VehiculoId { get; set; }
        public virtual Cliente cliente { get; set; }

        public Vehiculo Vehiculo
	    {
		    get { return vehiculo;}
		    set {
                vehiculo = value;
                vehiculo.AddPresupuesto(this);
            }
	    }

	    public Cliente Cliente
	    {
		    get { return cliente;}
		    set {
                cliente = value;
                cliente.AddPresupuesto(this);
            }
	    }

        public Presupuesto(int id, string estado, double importe)
        {
            this.Id = id;
            this.Estado = estado;
            this.Importe = importe;
        }

        public Presupuesto()
        {
        }

    }
}
