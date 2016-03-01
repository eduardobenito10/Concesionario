using Contracts;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class AdoUoW : IUoW
    {
        string cadCon;
        SqlConnection cn;
        public SqlConnection Cn { get; set; }
        public SqlTransaction T { get; set; }
        SqlTransaction t;
        IRepositoryCliente rClientes = null;
        public IRepositoryCliente RClientes { get; set; }
        IRepositoryVehiculo rVehiculos;
        public IRepositoryVehiculo RVehiculos { get; set; }
        IRepositoryPresupuesto rPresupuestos;
        public IRepositoryPresupuesto RPresupuestos { get; set; }

        public AdoUoW(string cadCon)
        {
            this.cadCon = cadCon;
            this.cn = new SqlConnection(this.cadCon);
        }

        public void Comenzar()
        {
            this.cn.Open();
            this.t = cn.BeginTransaction();
            this.RClientes = new RepositoryCliente(cn, t);
            this.RVehiculos = new RepositoryVehiculo(cn, t);
            //this.RPresupuestos = new RepositoryPresupuesto(cn, t);
        }

        public void RollBack()
        {
            if (t != null)
            {
                t.Rollback();
            }
        }

        public void SaveChanges()
        {
            if (t != null)
                t.Commit();
        }

        public void Terminar()
        {
            cn.Close();
        }
    }
}
