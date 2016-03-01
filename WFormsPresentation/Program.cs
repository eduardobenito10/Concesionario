using Repositories;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string cadCon = "Data Source=GAJOVA\\SQLEXPRESS; Integrated security=SSPI; Initial Catalog=Concesionario;";
            AdoUoW auow = new AdoUoW(cadCon);

            Application.Run(new FPrincipal(new ServiceCliente(auow), new ServicePresupuesto(auow), new ServiceVehiculo(auow)));
        }
    }
}
