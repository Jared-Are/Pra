using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletaVenta
{
    public class Boleta
    {
        private int cantidadProducto;

        public int numero { get; set; }
        public String nombreCliente { get; set; }
        public String direccionCliente { get; set; }
        public String cedulaCliente { get; set; }
        public DateTime fechaRegistro { get; set; }
        public String descripcionProducto { get; set; }
        public String cantidad { get; set; }


        // Método para determinar el precio del producto 
        public double DeterminaPrecio()
        {
            switch(descripcionProducto)
            {
                case "PS5 + 1 MANDO PS5": return 500;
                case "PS4 + 1 MANDO PS4": return 619;
                case "1 MANDO PS5": return 69;
                case "1 MANDO PS4": return 60;
            }

            return 0;
        }

        //Método para determinar el importe
        public double CalculaImporte()
        {
            return cantidadProducto * DeterminaPrecio();
        }

       
    }
}
