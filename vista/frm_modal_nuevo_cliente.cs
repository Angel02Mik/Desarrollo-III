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
    public partial class frm_modal_nuevo_cliente : Form
    {
        CCliente objCliente = new CCliente();
        public frm_modal_nuevo_cliente()
        {
            InitializeComponent();
        }

        int posX = 0;
        int posY = 0;
        private void Pn_header_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        private void insertarCliente()
        {
            MCliente obj = new MCliente();
            obj.nombres = txt_nombres.Text;
            obj.apellidos = txt_apellidos.Text;
            obj.direccion = txt_direccion.Text;
            obj.dni = Convert.ToInt32(txt_dni.Text);
            obj.telefono = txt_telefono.Text;
            obj.correo = txt_correo.Text;
            obj.deuda = Convert.ToDouble(txt_deuda.Text);

            objCliente.insertarCliente(obj);           

        }

        private void Bt_actualizar_Click(object sender, EventArgs e)
        {
            insertarCliente();
            this.DialogResult = DialogResult.OK;
        }

        private void Bt_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
