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




    }
}
