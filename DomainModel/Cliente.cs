using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Cliente
    {
        public int Id { get; set; }
        /* He tenido que cambiar private set para que funcionara con EF */
        public string Nombre { get; set; } 
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public bool Vip { get; set; }

        public virtual ICollection<Presupuesto> Presupuestos { get; private set; }

        public Cliente(int id, string nombre, string apellidos, string telefono, bool vip)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Telefono = telefono;
            this.Vip = vip;
        }

        /* Necesario para Entity ¿? */
        public Cliente()
        {
        }

        public void AddPresupuesto(Presupuesto presupuesto)
        {
            Presupuestos.Add(presupuesto);
        }

    }
}
