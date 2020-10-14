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
    public partial class frm_unidad_medida : Form
    {
        CUnidad_medida objUnidad_medida = new CUnidad_medida();
        DataView dv = new DataView();

        //alamenando los pk
        int pk_edith = 0;
        int pk_registro = 0;

        public frm_unidad_medida()
        {
            InitializeComponent();
        }
   

        public void listarUnidad_medida()
        {
            dv = objUnidad_medida.listarUnidad_medida();
            dg_unidad_medida.DataSource = dv;
        }

        public void estiloDg()
        {

            dg_unidad_medida.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg_unidad_medida.AllowUserToAddRows = false;
            dg_unidad_medida.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_unidad_medida.ReadOnly = true;

            dg_unidad_medida.Columns["pk_unidad_medida"].Visible = false;
            dg_unidad_medida.Columns["unidad_medida"].HeaderText = "UNIDAD-MEDIDA";
            dg_unidad_medida.Columns["moneda"].HeaderText = "MONEDA";


            //dg_unidad_medida.Columns["unidad_medida"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void Frm_unidad_medida_Load(object sender, EventArgs e)
        {
            listarUnidad_medida();
            estiloDg();
            totalRegistro();
        }

        private void Bt_insertar_Click_1(object sender, EventArgs e)
        {
            frm_modal_nuevo_unidad_medida modal = new frm_modal_nuevo_unidad_medida();
            DialogResult resultado = modal.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                MessageBox.Show("Se agrego correctamente", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                listarUnidad_medida();
                totalRegistro();
            }
        }
        private void modificarUnidad_medida()
        {
            MUnidad_medida obj = new MUnidad_medida();
            obj = objUnidad_medida.modificarUnidad_medida(pk_registro);

            frm_modal_modificar_unidad_medida modal = new frm_modal_modificar_unidad_medida();
            pk_edith = obj.pk_unidad_medida;
            modal.txt_medida.Text = obj.unidad_medida;
            modal.txt_moneda.Text = obj.moneda;

            if (pk_registro > 0)
            {
                DialogResult resultado = modal.ShowDialog();
                if (resultado == DialogResult.OK)
                {

                    MUnidad_medida update = new MUnidad_medida();

                    update.pk_unidad_medida = pk_edith;
                    update.unidad_medida = modal.txt_medida.Text;
                    update.moneda = modal.txt_moneda.Text;

                    objUnidad_medida.actualizarUnidad_medida(update);

                    MessageBox.Show("Se actualizo correctamente", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    listarUnidad_medida();
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
            modificarUnidad_medida();
        }

        private void Dg_unidad_medida_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            pk_registro = Convert.ToInt32(dg_unidad_medida.CurrentRow.Cells["pk_unidad_medida"].Value.ToString());
        }
        private void Bt_eliminar_Click_1(object sender, EventArgs e)
        {
            if (pk_registro > 0)
            {
                DialogResult resultado = MessageBox.Show("Estas seguro que queieres eliminar el registro..?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    objUnidad_medida.eliminarUnidad_medida(pk_registro);
                    listarUnidad_medida();
                    totalRegistro();
                    MessageBox.Show("Registro eliminado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un registro","Aviso",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Txt_busqueda_TextChanged_1(object sender, EventArgs e)
        {
            dv.RowFilter = ("unidad_medida like '%" + txt_busqueda.Text + "%'");
            totalRegistro();
        }
        private void totalRegistro()
        {
            lb_totalRegistro.Text = "Total registro: " + dg_unidad_medida.RowCount.ToString();
        }
        
    }
}
