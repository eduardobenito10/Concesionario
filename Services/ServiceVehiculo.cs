﻿using Contracts;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServiceVehiculo : IServiceVehiculo
    {
        IUoW uow;

        public ServiceVehiculo(IUoW uow)
        {
            this.uow = uow;
        }

        public void AñadirPresupuesto(Vehiculo v, Presupuesto p)
        {
            try
            {
                uow.Comenzar();
                v.AddPresupuesto(p);
                uow.RVehiculos.Update(v);
                uow.SaveChanges();
            }
            catch (Exception e)
            {
                uow.RollBack();
            }
            finally
            {
                uow.Terminar();
            }
        }

        public ICollection<Presupuesto> PresupuestosPorVehiculo(Vehiculo v)
        {
            ICollection<Presupuesto> presupuestos = null;
            try
            {
                uow.Comenzar();
                presupuestos = v.Presupuestos;
                uow.SaveChanges();
            }
            catch (Exception e)
            {
                uow.RollBack();
            }
            finally
            {
                uow.Terminar();
            }

            return presupuestos;
        }

        public void Add(Vehiculo t)
        {
            try
            {
                uow.Comenzar();
                uow.RVehiculos.Add(t);
                uow.SaveChanges();
            }
            catch (Exception e)
            {
                uow.RollBack();
            }
            finally
            {
                uow.Terminar();
            }
        }

        public void Remove(Vehiculo t)
        {
            try
            {
                uow.Comenzar();
                uow.RVehiculos.Delete(t);
                uow.SaveChanges();
            }
            catch (Exception e)
            {
                uow.RollBack();
            }
            finally
            {
                uow.Terminar();
            }
        }

        public Vehiculo Get(int id)
        {
            Vehiculo v = null;
            try
            {
                uow.Comenzar();
                v = uow.RVehiculos.GetById(id);
                uow.SaveChanges();
            }
            catch (Exception e)
            {
                uow.RollBack();
            }
            finally
            {
                uow.Terminar();
            }
            return v;
        }

        public ICollection<Vehiculo> GetAll()
        {
            ICollection<Vehiculo> vehiculos = null;
            try
            {
                uow.Comenzar();
                vehiculos = uow.RVehiculos.GetAll();
                uow.SaveChanges();
            }
            catch (Exception e)
            {
                uow.RollBack();
            }
            finally
            {
                uow.Terminar();
            }
            return vehiculos;
        }

    }
}
