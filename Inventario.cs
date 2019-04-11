using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciaGaleras
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MDIFarmacia form = new MDIFarmacia();
            form.Show();
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MDIFarmacia form = new MDIFarmacia();
            form.Show();
            this.Hide();
        }

        private void txtCantidadDisponible_TextChanged(object sender, EventArgs e)
        {
            int CantidadDisponible = 0;
            int.TryParse(txtCantidadDisponible.Text, out CantidadDisponible);
            if (CantidadDisponible < 10)
            {
                erpMensaje.SetError(txtCantidadDisponible, "El producto esta proximo agotarse");
            }
            else
            {
                erpMensaje.SetError(txtCantidadDisponible, null);
            }
        }
    }
}
