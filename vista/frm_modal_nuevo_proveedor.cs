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
    public partial class frm_modal_nuevo_proveedor : Form
    {
        CProveedor objProveedor = new CProveedor();
        public frm_modal_nuevo_proveedor()
        {
            InitializeComponent();
        }

        private void insertarProveedor()
        {
            MProveedor obj = new MProveedor();
            obj.nombre = txt_nombre.Text;
            obj.direccion = txt_direccion.Text;
            obj.ruc = txt_ruc.Text;
            obj.telefono = txt_telefono.Text;
            obj.correo = txt_correo.Text;
            obj.deuda = Convert.ToDouble(txt_deuda.Text);

            objProveedor.insertarProveedor(obj);
        }
        private void Bt_insertar_Click(object sender, EventArgs e)
        {
            insertarProveedor();
            this.DialogResult = DialogResult.OK;
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

        private void Bt_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
