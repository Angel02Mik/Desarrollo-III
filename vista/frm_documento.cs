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
    public partial class frm_documento : Form
    {

        CDocumento objDocumento = new CDocumento();
        DataView dv = new DataView();

        //alamenando los pk
        int pk_edith = 0;
        int pk_registro = 0;

        public frm_documento()
        {
            InitializeComponent();
        }
       
        public void listarDocumento()
        {
            dv = objDocumento.listarDocumento();
            dg_documento.DataSource = dv;
        }

        public void estiloDg()
        {

            dg_documento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg_documento.AllowUserToAddRows = false;
            dg_documento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_documento.ReadOnly = true;

            dg_documento.Columns["pk_documento"].Visible = false;
            dg_documento.Columns["codigo"].HeaderText = "CODIGO";
            dg_documento.Columns["nombre"].HeaderText = "NOMBRE";
            dg_documento.Columns["serie"].HeaderText = "SERIE";
            dg_documento.Columns["numero"].HeaderText = "NUMERO";

            dg_documento.Columns["codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_documento.Columns["nombre"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_documento.Columns["serie"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_documento.Columns["numero"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void Frm_documento_Load(object sender, EventArgs e)
        {
            listarDocumento();
            estiloDg();
            totalRegistro();
        }

        private void Bt_insertar_Click(object sender, EventArgs e)
        {
            frm_modal_nuevo_documento modal = new frm_modal_nuevo_documento();
            DialogResult resultado = modal.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                MessageBox.Show("Se agrego correctamente", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                listarDocumento();
                totalRegistro();
            }
        }
        private void modificarDocumento()
        {
            MDocumento obj = new MDocumento();
            obj = objDocumento.modificarDocumento(pk_registro);
            frm_modal_modificar_documento modal = new frm_modal_modificar_documento();
            pk_edith = obj.pk_documento;
            modal.txt_codigo.Text = obj.codigo;
            modal.txt_nombre.Text = obj.nombre;
            modal.txt_serie.Text = obj.serie;
            modal.txt_numero.Text = obj.numero;

            if (pk_registro > 0)
            {
                DialogResult resultado = modal.ShowDialog();
                if (resultado == DialogResult.OK)
                {

                    MDocumento update = new MDocumento();

                    update.pk_documento = pk_edith;
                    update.codigo = modal.txt_codigo.Text;
                    update.nombre = modal.txt_nombre.Text;
                    update.serie = modal.txt_serie.Text;
                    update.numero = modal.txt_numero.Text;

                    objDocumento.actualizarDocumento(update);

                    MessageBox.Show("Se actualizo correctamente", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    listarDocumento();
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
            modificarDocumento();
        }
 
        private void Dg_documento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pk_registro = Convert.ToInt32(dg_documento.CurrentRow.Cells["pk_documento"].Value.ToString());
        }

        private void Bt_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Estas seguro que queieres eliminar el registro..?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                objDocumento.eliminarDocumento(pk_registro);
                listarDocumento();
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
            lb_totalRegistro.Text = "Total registro: " + dg_documento.RowCount.ToString();
        }

    }
}
