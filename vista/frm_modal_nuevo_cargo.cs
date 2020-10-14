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
    public partial class frm_modal_nuevo_cargo : Form
    {
        CCargo objCargo = new CCargo();
        public frm_modal_nuevo_cargo()
        {
            InitializeComponent();
        }

        private void Bt_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void insertarCargo()
        {
            MCargo obj = new MCargo();
            obj.cargo = txt_cargo.Text;

            objCargo.insertarCargo(obj);
        }
        private void Bt_insertar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            insertarCargo();
        }

        int posX = 0;
        int posY = 0;
        private void Pn_header_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button != MouseButtons.Left)
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
    }
}
