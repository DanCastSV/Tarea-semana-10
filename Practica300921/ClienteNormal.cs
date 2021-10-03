using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica300921
{
    class ClienteNormal:Cliente
    {
        private double TAX = 0.16d;


        public double gettax()
        {
            return TAX;

        }

        public override string getinfocliente()
        {
            return base.getinfocliente();
        }

        public override string info_compra()
        {
            return base.info_compra() + " mas el impuesto que es:" + TAX;
        }

        public override double infocobrar()
        {
            return base.infocobrar();
        }

        public override string cobrar()
        {
            return base.cobrar() + " y por separado el impiesto que es de " + TAX + "ctvs";
        }


    }
}
