using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica300921
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //instancia del cliente en linea 
            ClienteEnLinea clienteenlinea = new ClienteEnLinea();
            clienteenlinea.clientname = "Daniel";
            clienteenlinea.clientid = 001;
            clienteenlinea.clientamount = 25;
            clienteenlinea.clientprice = 0.30d;
            clienteenlinea.password = "123456";

            MessageBox.Show(clienteenlinea.getinfocliente());
            MessageBox.Show(clienteenlinea.info_compra());
            MessageBox.Show(clienteenlinea.cobrar());

            //instancia del cliente normal

            ClienteNormal clientenormal = new ClienteNormal();
            clientenormal.clientname = "Diego";
            clientenormal.clientid = 2;
            clientenormal.clientamount = 56;
            clientenormal.clientprice = 5.45d;
            MessageBox.Show(clientenormal.getinfocliente());
            MessageBox.Show(clientenormal.info_compra());
            MessageBox.Show(clientenormal.cobrar());
        }
    }
}
