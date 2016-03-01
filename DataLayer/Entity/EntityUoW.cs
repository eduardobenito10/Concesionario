using Contracts;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class EntityUoW : IUoW
    {
        ConcesionarioEntities Context;

        IRepositoryCliente rClientes;
        public IRepositoryCliente RClientes { get; set; }
        IRepositoryVehiculo rVehiculos;
        public IRepositoryVehiculo RVehiculos { get; set; }
        IRepositoryPresupuesto rPresupuestos;
        public IRepositoryPresupuesto RPresupuestos { get; set; }

        public EntityUoW()
        {
            Context = new ConcesionarioEntities();
            Context.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
        }

        public void Comenzar()
        {
            try
            {
                this.RClientes = new EFRepositoryCliente(Context);
                this.rClientes = this.RClientes;
                this.RVehiculos = new EFRepositoryVehiculo(Context);
                this.rVehiculos = this.RVehiculos;
                this.RPresupuestos = new EFRepositoryPresupuesto(Context);
                this.rPresupuestos = this.RPresupuestos;
            }
            catch (Exception e)
            {
            }
        }

        public void RollBack()
        {
            try
            {
                if (Context.Database != null)
                    Context.Database.CurrentTransaction.Rollback();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }

        public void Terminar()
        {
            //Context.Dispose();
        }

    }
}
