using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Vehiculo
    {
        public int Id { get; private set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Potencia { get; set; }

        public virtual ICollection<Presupuesto> Presupuestos { get; private set; }

        public Vehiculo(int id, string marca, string modelo, int potencia)
        {
            this.Id = id;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Potencia = potencia;
        }

        public Vehiculo()
        {
        }

        public void AddPresupuesto(Presupuesto presupuesto)
        {
            Presupuestos.Add(presupuesto);
        }
    }
}
