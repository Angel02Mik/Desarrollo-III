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
    public partial class frm_modal_nuevo_personal : Form
    {
        CPersonal objPersonal = new CPersonal();
        public frm_modal_nuevo_personal()
        {
            InitializeComponent();
        }

        private void Bt_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Bt_insertar_Click(object sender, EventArgs e)
        {
            MPersonal obj = new MPersonal();
            obj.fk_cargo = 2;
            obj.nombres = txt_nombres.Text;
            obj.apellidos = txt_apellidos.Text;
            obj.sexo = txt_sexo.Text;
            obj.dni = txt_dni.Text;
            obj.direccion = txt_direccion.Text;
            obj.telefono = int.Parse(txt_telefono.Text);

            objPersonal.insertarPersonal(obj);
            this.DialogResult = DialogResult.OK;
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
