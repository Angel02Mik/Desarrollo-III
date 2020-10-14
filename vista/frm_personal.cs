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
    public partial class frm_personal : Form
    {
        CPersonal objPersonal = new CPersonal();
        DataView dv = new DataView();

        //alamenando los pk
        int pk_edith = 0;
        int pk_registro = 0;
        public frm_personal()
        {
            InitializeComponent();
        }


        public void listarPersonal()
        {
            dv = objPersonal.listarPersonal();
            dg_personal.DataSource = dv;
        }

        public void estiloDg()
        {

            dg_personal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg_personal.AllowUserToAddRows = false;
            dg_personal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_personal.ReadOnly = true;

            dg_personal.Columns["pk_personal"].Visible = false;
            dg_personal.Columns["nombres"].HeaderText = "NOMBRES";
            dg_personal.Columns["apellidos"].HeaderText = "APELLIDOS";
            dg_personal.Columns["sexo"].HeaderText = "SEXO";
            dg_personal.Columns["dni"].HeaderText = "DNI";
            dg_personal.Columns["direccion"].HeaderText = "DIRECCION";
            dg_personal.Columns["telefono"].HeaderText = "TELEFONO";

            dg_personal.Columns["sexo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dg_personal.Columns["telefono"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        private void Frm_personal_Load(object sender, EventArgs e)
        {
            listarPersonal();
            estiloDg();
            totalRegistro();
        }

        private void Bt_insertar_Click_1(object sender, EventArgs e)
        {
            frm_modal_nuevo_personal modal = new frm_modal_nuevo_personal();
            DialogResult resultado = modal.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                MessageBox.Show("Se agrego correctamente", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                listarPersonal();
                totalRegistro();
            }
        }
        private void modificarPersonal()
        {
            MPersonal obj = new MPersonal();
            obj = objPersonal.modificarPersonal(pk_registro);
            frm_modal_modificar_personal modal = new frm_modal_modificar_personal();
            pk_edith = obj.pk_personal;
            modal.cb_cargo.Text = "moso";
            modal.txt_nombres.Text = obj.nombres;
            modal.txt_apellidos.Text = obj.apellidos;
            modal.txt_sexo.Text = obj.sexo;
            modal.txt_dni.Text = obj.dni;
            modal.txt_direccion.Text = obj.direccion;
            modal.txt_telefono.Text = obj.telefono.ToString();


            if (pk_registro > 0)
            {
                DialogResult resultado = modal.ShowDialog();
                if (resultado == DialogResult.OK)
                {

                    MPersonal update = new MPersonal();

                    update.pk_personal = pk_edith;
                    update.fk_cargo = 2;//modal.cb_cargo.Text;
                    update.nombres = modal.txt_nombres.Text;
                    update.apellidos = modal.txt_apellidos.Text;
                    update.sexo = modal.txt_sexo.Text;
                    update.dni = modal.txt_dni.Text;
                    update.direccion = modal.txt_direccion.Text;
                    update.telefono = int.Parse(modal.txt_telefono.Text);


                    objPersonal.actualizarPersonal(update);

                    MessageBox.Show("Se actualizo correctamente", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    listarPersonal();
                    totalRegistro();
                }
            }
            else
            {
                MessageBox.Show("Selecciona un registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        private void Bt_modificar_Click_1(object sender, EventArgs e)
        {
            modificarPersonal();
        }

        private void Dg_personal_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            pk_registro = Convert.ToInt32(dg_personal.CurrentRow.Cells["pk_personal"].Value.ToString());
        }

        private void Bt_eliminar_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Estas seguro que queieres eliminar el registro..?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                objPersonal.eliminarPersonal(pk_registro);
                listarPersonal();
                totalRegistro();
                MessageBox.Show("Registro eliminado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Txt_busqueda_TextChanged_1(object sender, EventArgs e)
        {
            dv.RowFilter = ("nombres like '%" + txt_busqueda.Text + "%'");
            totalRegistro();
        }

        private void totalRegistro()
        {
            lb_totalRegistro.Text = "Total registro: " + dg_personal.RowCount.ToString();
        }

        

      


        
       
    }
}
