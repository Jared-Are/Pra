using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_ventas
{
    public partial class frmControlVentas : Form
    {
        public frmControlVentas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cantidad;
            double precio, subtotal, total, descuento;

            precio = double.Parse(txtpre.Text);
            cantidad = int.Parse(txtPr.Text);

            subtotal = precio * cantidad;
            descuento = subtotal * 0.11;
            total = subtotal - descuento;

            if (precio > 0 && cantidad > 0)
            {
                txtsub.Text = subtotal.ToString("N2");
                txtdes.Text = descuento.ToString("N2");
                txtto.Text = total.ToString("N2");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtsub.Clear();
            txtdes.Clear();
            txtto.Clear();
            txtPr.Clear();
            txtpre.Clear();
            txtPr.Focus();
        }
    }
}
