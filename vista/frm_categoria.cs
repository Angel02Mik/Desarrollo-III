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
    public partial class frm_categoria : Form
    {
        CCategoria objCategoria = new CCategoria();
        DataView dv = new DataView();

        //almacenando los pk
        int pk_registro = 0;
        int pk_edith = 0;
        public frm_categoria()
        {
            InitializeComponent();
        }
        
        public void listarCategoria()
        {
            dv = objCategoria.listarCategoria();
            dg_categoria.DataSource = dv;
        }

        public void estiloDg()
        {

            dg_categoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg_categoria.AllowUserToAddRows = false;
            dg_categoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_categoria.ReadOnly = true;

            dg_categoria.Columns["pk_categoria"].Visible = false;
            dg_categoria.Columns["foto_cat"].Visible = false;
            dg_categoria.Columns["categoria"].HeaderText = "CATEGORIA";
        }
        private void Frm_categoria_Load(object sender, EventArgs e)
        {
            listarCategoria();
            estiloDg();
            totalRegistro();
        }

        private void Bt_insertar_Click_1(object sender, EventArgs e)
        {
            frm_modal_nuevo_categoria modal = new frm_modal_nuevo_categoria();
            DialogResult resultado = modal.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                MessageBox.Show("Se agrego correctamente", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                listarCategoria();
                totalRegistro();
            }
        }

        private void modificarCategoria()
        {
            MCategoria obj = new MCategoria();
            obj = objCategoria.modificarCategoria(pk_registro);

            frm_modal_modificar_categoria modal = new frm_modal_modificar_categoria();
            pk_edith = obj.pk_categoria;
            modal.txt_categoria.Text = obj.categoria;   

            if(pk_registro > 0)
            {
                DialogResult resultado = modal.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    MCategoria update = new MCategoria();
                    update.pk_categoria = pk_edith;
                    update.categoria = modal.txt_categoria.Text;

                    objCategoria.actualizarCategoria(update);

                    MessageBox.Show("Se actualizo correctamente", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    listarCategoria();
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
            modificarCategoria();
        }

        private void Dg_categoria_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            pk_registro = Convert.ToInt32(dg_categoria.CurrentRow.Cells["pk_categoria"].Value.ToString());
        }

        private void Bt_eliminar_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Estas seguro que queieres eliminar el registro..?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                objCategoria.eliminarCategoria(pk_registro);
                listarCategoria();
                totalRegistro();
                MessageBox.Show("Registro eliminado correctamente", "Aviso",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Txt_busqueda_TextChanged_1(object sender, EventArgs e)
        {
            dv.RowFilter = ("categoria like '%" + txt_busqueda.Text + "%'");
            totalRegistro();
        }

        private void totalRegistro()
        {
            lb_totalRegistro.Text = "Total registro: " + dg_categoria.RowCount.ToString();
        }

        
    }
}
