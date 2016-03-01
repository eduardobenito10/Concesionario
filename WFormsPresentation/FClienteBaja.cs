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
    public partial class FClienteBaja : Form
    {
        IServiceCliente cService;

        public FClienteBaja(IServiceCliente cs)
        {
            InitializeComponent();
            cService = cs;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(this.txtId.Text);
            Cliente c = cService.Get(id);
            if (c != null) {
                this.cService.Remove(c);
                Console.WriteLine("El cliente con ID:" + id + " ha sido eliminado.");
            }
        }
    }
}
