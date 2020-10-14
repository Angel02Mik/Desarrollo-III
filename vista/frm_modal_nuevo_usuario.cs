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
    public partial class frm_modal_nuevo_usuario : Form
    {
        CUsuario objUsuario = new CUsuario();
        public frm_modal_nuevo_usuario()
        {
            InitializeComponent();
        }

        private void Bt_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void insertarUsuario()
        {
            MUsuario obj = new MUsuario();
            obj.nombre = txt_nombre.Text;
            obj.login = txt_login.Text;
            obj.password = txt_password.Text;
            obj.privilegios = cb_privilegios.Text;
            if(cb_estado.Text == "ACTIVO")
            {
                obj.estado = "1";
            }
            else
            {
                obj.estado = "0";
            }

            objUsuario.insertarUsuario(obj);
        }

        private void Frm_modal_nuevo_usuario_Load_1(object sender, EventArgs e)
        {
            cb_privilegios.SelectedIndex = 0;
            cb_estado.SelectedIndex = 0;
        }

        private void Bt_insertar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            insertarUsuario();
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

        
    }
}
