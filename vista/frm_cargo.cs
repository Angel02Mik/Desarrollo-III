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
    public partial class frm_cargo : Form
    {
        CCargo objCargo = new CCargo();
        DataView dv = new DataView();

        //alamenando los pk
        int pk_edith = 0;
        int pk_registro = 0;
        public frm_cargo()
        {
            InitializeComponent();
        }

        public void listarCargo()
        {
            dv = objCargo.listarCargo();
            dg_cargo.DataSource = dv;
        }

        public void estiloDg()
        {

            dg_cargo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg_cargo.AllowUserToAddRows = false;
            dg_cargo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_cargo.ReadOnly = true;

            dg_cargo.Columns["pk_cargo"].Visible = false;
            dg_cargo.Columns["cargo"].HeaderText = "CARGO";
         

            //dg_cargo.Columns["cargo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void Frm_cargo_Load(object sender, EventArgs e)
        {
            listarCargo();
            estiloDg();
            totalRegistro();
        }
 
        private void Bt_insertar_Click(object sender, EventArgs e)
        {
            frm_modal_nuevo_cargo modal = new frm_modal_nuevo_cargo();
            DialogResult resultado = modal.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                MessageBox.Show("Se agrego correctamente", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                listarCargo();
                totalRegistro();
            }
        }
        private void modificarCargo()
        {
            MCargo obj = new MCargo();
            obj = objCargo.modificarCargo(pk_registro);
            frm_modal_modificar_cargo modal = new frm_modal_modificar_cargo();
            pk_edith = obj.pk_cargo;
            modal.txt_cargo.Text = obj.cargo;
          
            if (pk_registro > 0)
            {
                DialogResult resultado = modal.ShowDialog();
                if (resultado == DialogResult.OK)
                {

                    MCargo update = new MCargo();

                    update.pk_cargo = pk_edith;
                    update.cargo = modal.txt_cargo.Text;
                  
                    objCargo.actualizarCargo(update);

                    MessageBox.Show("Se actualizo correctamente", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    listarCargo();
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
            modificarCargo();
        }

        private void Dg_cargo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pk_registro = Convert.ToInt32(dg_cargo.CurrentRow.Cells["pk_cargo"].Value.ToString());
        }

        private void Bt_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Estas seguro que queieres eliminar el registro..?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                objCargo.eliminarCargo(pk_registro);
                listarCargo();
                totalRegistro();
                MessageBox.Show("Registro eliminado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Txt_busqueda_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = ("cargo like '%" + txt_busqueda.Text + "%'");
            totalRegistro();
        }

        private void totalRegistro()
        {
            lb_totalRegistro.Text = "Total registro: " + dg_cargo.RowCount.ToString();
        }
    }
}
