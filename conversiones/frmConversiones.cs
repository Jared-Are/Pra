using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conversiones
{
    public partial class frmConversiones : Form
    {
        public frmConversiones()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double me, ft, pulgadas, cm, yarda;

            me = double.Parse(txtM.Text);


            cm = me * 100;
            pulgadas = cm / 2.54;
            ft = pulgadas / 12;
            yarda = ft / 3;

            if (me > 0)
            {
                txtcm.Text = cm.ToString("N2");
                txtPul.Text = pulgadas.ToString("N2");
                txtpi.Text = ft.ToString("N2");
                txtya.Text = yarda.ToString("N2");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtM.Clear();
            txtcm.Clear();
            txtPul.Clear();
            txtpi.Clear();
            txtya.Clear();
            txtya.Focus();
        }
    }
}
