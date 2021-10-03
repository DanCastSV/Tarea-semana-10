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
        public double clientprice { get; set; }
        public string clientname  { get; set; }
        public double clienttotal { get; set; }


        public virtual string getinfocliente()
        {
            return "Su id es: 00" + clientid + " y su nombre es: " + clientname; 
        }

        public virtual string info_compra()
        {
            return "La cantidad de articulos que usted cobra es de  " + clientamount + ", cada articulo tiene un valor de $" + clientprice;


        }
        public virtual  double infocobrar()
        {
            clienttotal = clientamount * clientprice;
            return  clienttotal;  
        
        }

        public virtual string cobrar()
        {
            return "EL total a pagar es: $" + infocobrar();
        
        }


          

    }
}
