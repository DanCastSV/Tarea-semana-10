using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica300921
{
    class ClienteEnLinea : Cliente
    {
        public string password { get; set; }
        private double SHIPPING = 98d;

        public double getshipping()
        {
            return SHIPPING;

        }

        public override string getinfocliente()
        {
            return base.getinfocliente() + "" + " y su contraseña es " + password;
        }
        public override string info_compra()
        {
            return base.info_compra() + " junto al gasto de envio que es de " + SHIPPING + " dolares extras";
        }

        public override double infocobrar()
        {
            return base.infocobrar();
        }

        public override string cobrar()
        {
            return base.cobrar() + " junto el total de los productos debera cancelar por separado los 98$ de envio";
        }

    }
}
