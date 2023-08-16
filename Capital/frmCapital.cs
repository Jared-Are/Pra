using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capital
{
    public partial class frmCapital : Form
    {
        public frmCapital()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double socio_1, socio_2, socio_3, Total, por_1, por_2, por_3;

            socio_1 = double.Parse(txtS1.Text);
            socio_2 = double.Parse(txtS2.Text);
            socio_3 = double.Parse(txtS3.Text);

            Total = socio_1 + socio_2 + socio_3;

            if (Total > 0)
            {
                txtTo.Text = Total.ToString("N2");
                por_1 = (socio_1 / Total) * 100;
                txtp1.Text = por_1.ToString("N2");
                por_2 = (socio_2 / Total) * 100;
                txtp2.Text = por_2.ToString("N2");
                por_3 = (socio_3 / Total) * 100;
                txtp3.Text = por_3.ToString("N2");

            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtTo.Clear();
            txtp1.Clear();
            txtp2.Clear();
            txtp3.Clear();
            txtS1.Clear();
            txtS2.Clear();
            txtS3.Clear();
            txtS1.Focus();
        }
    }
}
