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
    public partial class frm_login : Form
    {
        CUsuario objUsuario = new CUsuario();
        CConfiguracion objConfiguracion = new CConfiguracion();
        public frm_login()
        {
            InitializeComponent();
        }

        private void mostrarNombreNegocio()
        {
            MConfiguracion obj = new MConfiguracion();
            obj = objConfiguracion.mostrarNombre();
            lb_nombreNegocio.Text = obj.nombre; 
        }
        private void Frm_login_Load(object sender, EventArgs e)
        {
            mostrarNombreNegocio();
        }

        private void Bt_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        int posX = 0;
        int posY = 0;
        private void Frm_login_MouseMove(object sender, MouseEventArgs e)
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

        private void Bt_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Bt_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void comprobarUsuario()
        {
            
            MUsuario obj = new MUsuario();
           
            obj.login = txt_usuario.Text;
            obj.password = txt_password.Text;
           


            if (obj.comprobarUsuario(obj.login, obj.password))
            {
                this.Hide();
                string login = txt_usuario.Text;
                obj = objUsuario.nombreUsuario(login);

                frm_principal principal = new frm_principal();
                principal.lb_nombreUsuario.Text = obj.nombre;
                principal.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña no coincide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Bt_ingresar_Click(object sender, EventArgs e)
        {
            comprobarUsuario();  
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lb_hora.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
