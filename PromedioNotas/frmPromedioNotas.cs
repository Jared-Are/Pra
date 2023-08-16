using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PromedioNotas
{
    public partial class frmPromedioNotas : Form
    {
        public frmPromedioNotas()
        {
            InitializeComponent();
        }

        private void textpromedio_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double nota_1, nota_2, nota_3, promedio;
            String estado;

            nota_1 = double.Parse(textnota1.Text);
            nota_2 = double.Parse(textnota2.Text);
            nota_3 = double.Parse(textnota3.Text);

            promedio = (nota_1 + nota_2 + nota_3) / 3;

            if (promedio <0 || promedio > 100)
            {
                estado = "Datos incorrectos";
                textestado.Text = estado;
            }
            else if (promedio >= 0 && promedio < 60)
            {
                estado = "Reprobado";
                textpromedio.Text = promedio.ToString("N2");
                textestado.Text = estado;
            }
            else if (promedio >= 60 && promedio <= 100)
            {
                estado = "Aprobado";
                textpromedio.Text = promedio.ToString("N2");
                textestado.Text = estado;
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            textnota1.Clear();
            textnota2.Clear();
            textnota3.Clear();
            textpromedio.Clear();
            textestado.Clear();
            textnota1.Focus();
        }
    }
}
