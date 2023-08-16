using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda_de_abarrotes
{
    public partial class frmTienda : Form
    {
        public frmTienda()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int cantidad;
            double precio, Total;

            precio = double.Parse(txtPr.Text);
            cantidad = int.Parse(txtCan.Text);

            Total = precio * cantidad;

            if (Total > 0)
            {
                txtTo.Text = Total.ToString("N2");
            }

        }

        private void brnNuevo_Click(object sender, EventArgs e)
        {
            txtTo.Clear();
            txtPr.Clear();
            txtCan.Clear();
            txtTo.Focus();
        }
    }
}
