using DomainModel;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsForms
{
    public partial class FPrincipal : Form
    {
        IServiceCliente cService;
        IServicePresupuesto pService;
        IServiceVehiculo vService;

        public FPrincipal(IServiceCliente cs, IServicePresupuesto ps, IServiceVehiculo vs)
        {
            InitializeComponent();
            cService = cs;
            pService = ps;
            vService = vs;
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FClienteAlta(this.cService);
            f.Show();
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ICollection<Cliente> clientes = cService.GetAll();
            if (clientes != null)
            {
                foreach (Cliente c in clientes)
                {
                    Console.WriteLine(c.Nombre);
                }
            }
        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FClienteBaja(this.cService);
            f.Show();
        }
    }
}
