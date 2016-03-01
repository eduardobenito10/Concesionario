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
    public partial class FClienteAlta : Form
    {
        IServiceCliente cService;

        public FClienteAlta(IServiceCliente cs)
        {
            InitializeComponent();
            cService = cs;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string apellidos = this.txtApellidos.Text;
            string telefono = this.txtTelefono.Text;
            bool VIP = this.chkVIP.Checked;
            Cliente nuevo = new Cliente(id, nombre, apellidos, telefono, VIP);
            this.cService.Add(nuevo);

            Console.WriteLine(nuevo.Id);
            Console.WriteLine(nuevo.Nombre);
        }
    }
}
