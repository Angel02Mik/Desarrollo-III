using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using modelo;
using controlador;

namespace vista
{
    public partial class frm_inicio : Form
    {
        CUsuario objUsuario = new CUsuario();
        CProducto objProducto = new CProducto();
        CCliente objCliente = new CCliente();
        CPersonal objPersonal = new CPersonal();
        public frm_inicio()
        {
            InitializeComponent();
        }

        private void SplitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cantidadUsuario()
        {
            int totalUsuario = objUsuario.cantidadUsuario();
            lb_totalUsuario.Text ="Total: "+ totalUsuario.ToString();
        }

        private void cantidadProducto()
        {
            int totalProduco = objProducto.cantidadProducto();
            lb_totalProducto.Text ="Total: "+ totalProduco.ToString();
        }

        private void cantidadStock()
        {
            int totalStock = objProducto.cantidadStock();
            lb_totalStock.Text = "Total Stock: " + totalStock.ToString();
        }

        private void cantidadCliente()
        {
            int totalCliente = objCliente.cantidadCliente();
            lb_totalCliente.Text = "Total: " + totalCliente.ToString();
        }

        private void cantidadPersonal()
        {
            int totalPersonal = objPersonal.cantidadPersonal();
            lb_totalPersonal.Text ="Total: "+ totalPersonal.ToString();
        }
        private void Frm_inicio_Load(object sender, EventArgs e)
        {
            cantidadUsuario();
            cantidadProducto();
            cantidadStock();
            cantidadCliente();
            cantidadPersonal();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lb_fechaActual.Text = DateTime.Now.ToLongDateString();
        }
    }
}
