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
    public partial class frm_usuario : Form
    {
        CUsuario objUsuario = new CUsuario();
        DataView dv = new DataView();

        //alamenando los pk
        int pk_edith = 0;
        int pk_registro = 0;
        public frm_usuario()
        {
            InitializeComponent();
        }

        public void listarUsuario()
        {
            dv = objUsuario.listarUsuario();
            dg_usuario.DataSource = dv;
        }

        public void estiloDg()
        {

            dg_usuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg_usuario.AllowUserToAddRows = false;
            dg_usuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_usuario.ReadOnly = true;

            dg_usuario.Columns["pk_usuario"].Visible = false;
            dg_usuario.Columns["nombre"].HeaderText = "NOMBRE";
            dg_usuario.Columns["login"].HeaderText = "LOGIN";
            dg_usuario.Columns["password"].HeaderText = "PASSWORD";
            dg_usuario.Columns["privilegios"].HeaderText = "PRIVILEGIOS";
            dg_usuario.Columns["estado"].HeaderText = "ESTADO";
        }
        private void Frm_usuario_Load(object sender, EventArgs e)
        {
            listarUsuario();
            estiloDg();
            totalRegistro();
        }

        private void Bt_insertar_Click(object sender, EventArgs e)
        {
            frm_modal_nuevo_usuario modal = new frm_modal_nuevo_usuario();
            DialogResult resultado = modal.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                MessageBox.Show("Se agrego correctamente", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                listarUsuario();
                totalRegistro();
            }
        }
        private void modificarUsuario()
        {
            MUsuario obj = new MUsuario();
            obj = objUsuario.modificarUsuario(pk_registro);
            frm_modal_modificar_usuario modal = new frm_modal_modificar_usuario();
            pk_edith = obj.pk_usuario;
            modal.txt_nombre.Text = obj.nombre;
            modal.txt_login.Text = obj.login;
            modal.txt_password.Text = obj.password;
            modal.cb_privilegios.Text = obj.privilegios;

            if(obj.estado == "1")
            {
                modal.cb_estado.Text = "ACTIVO";
            }
            else
            {
                modal.cb_estado.Text = "INACTIVO";
            }
           


            if (pk_registro > 0)
            {
                DialogResult resultado = modal.ShowDialog();
                if (resultado == DialogResult.OK)
                {

                    MUsuario update = new MUsuario();

                    update.pk_usuario = pk_edith;
                    update.nombre = modal.txt_nombre.Text;
                    update.login = modal.txt_login.Text;
                    update.password = modal.txt_password.Text;
                    update.privilegios = modal.cb_privilegios.Text;
                    if(modal.cb_estado.Text == "ACTIVO")
                    {
                        update.estado = "1";
                    }
                    else
                    {
                        update.estado = "0";
                    }
                    

                    objUsuario.actualizarUsuario(update);

                    MessageBox.Show("Se actualizo correctamente", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    listarUsuario();
                    totalRegistro();
                }
            }
            else
            {
                MessageBox.Show("Selecciona un registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Bt_modificar_Click(object sender, EventArgs e)
        {
            modificarUsuario();
        }

        private void Dg_usuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pk_registro = Convert.ToInt32(dg_usuario.CurrentRow.Cells["pk_usuario"].Value.ToString());
        }
        private void Bt_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Estas seguro que queieres eliminar el registro..?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                objUsuario.eliminarUsuario(pk_registro);
                listarUsuario();
                totalRegistro();
                MessageBox.Show("Registro eliminado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Txt_busqueda_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = ("nombre like '%" + txt_busqueda.Text + "%'");
            totalRegistro();
        }

        private void totalRegistro()
        {
            lb_totalRegistro.Text = "Total registro: " + dg_usuario.RowCount.ToString();
        }
   
       
    }
}
