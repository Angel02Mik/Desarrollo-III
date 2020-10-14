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
    public partial class frm_configuracion : Form
    {
        CUsuario objUsuario = new CUsuario();
        CConfiguracion objConfiguracion = new CConfiguracion();
        DataView dv = new DataView();
        public frm_configuracion()
        {
            InitializeComponent();
        }

        private void Bt_cargarLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog seleccionar = new OpenFileDialog();
            seleccionar.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            DialogResult resultado = seleccionar.ShowDialog();
            if(resultado == DialogResult.OK)
            {

                pb_mostrarLogo.Image = Image.FromFile(seleccionar.FileName);

               
            }
        }

        private void listarUsuario()
        {
            dv = objUsuario.listarUsuario();
            cb_usuario.ValueMember = "pk_usuario";
            cb_usuario.DisplayMember = "nombre";
            cb_usuario.SelectedValue = "pk_usuario";
            cb_usuario.DataSource = dv;
        }
        private void Frm_configuracion_Load(object sender, EventArgs e)
        {
            listarUsuario();
            bt_guardar.Enabled = false;
        }


        private void insertarLogo()
        {
            string ahora = Convert.ToString(DateTime.Now - DateTime.Parse("00:00:00"));
            string[] nuevo_nombre = ahora.Split(new string[] { "." }, StringSplitOptions.RemoveEmptyEntries);

            pb_mostrarLogo.Image.Save(@"recursos/" + nuevo_nombre[1]+".png");

            MConfiguracion obj = new MConfiguracion();
            obj.foto = nuevo_nombre[1];
            obj.nombre = txt_nombreNegocio.Text;
            objConfiguracion.insertarConfiguracion(obj);
        }
        private void Bt_guardar_Click(object sender, EventArgs e)
        {
             DialogResult resultado = MessageBox.Show("Guardado correctamente ", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
             if(resultado == DialogResult.OK)
             {
                 insertarLogo();
                MessageBox.Show("Necesitas reiniciar par ver cambios", "Reiniciar.?", MessageBoxButtons.OK, MessageBoxIcon.Information);   
            }

            
        }

        private void Txt_nombreNegocio_TextChanged(object sender, EventArgs e)
        {
            var bl = !string.IsNullOrEmpty(txt_nombreNegocio.Text);
            bt_guardar.Enabled = bl;
        }
    }
}
