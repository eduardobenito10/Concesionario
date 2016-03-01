using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Repositories;
using Services;

namespace WpfPresentation
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            //string cadCon = "Data Source=GAJOVA\\SQLEXPRESS; Integrated security=SSPI; Initial Catalog=Concesionario;";
            //AdoUoW auow = new AdoUoW(cadCon);
            EntityUoW auow = new EntityUoW();
            Window mw = new MainWindow(new ServiceCliente(auow), new ServicePresupuesto(auow), new ServiceVehiculo(auow));
            mw.Show();
        }
    }
}
