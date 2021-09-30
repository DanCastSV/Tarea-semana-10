using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica300921
{
    class Cliente
    {
        public int clientid { get; set; }
        public int clientamount { get; set; }
        public double clietprice { get; set; }
        public string clientname  { get; set; }
        public double clienttotal { get; set; }


        public string getinfocliente()
        {
            return "Su id es: " + clientid + "y su nombre es: " + clientname; 
        }
     
    }
}
