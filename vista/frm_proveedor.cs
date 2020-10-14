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
    public partial class frm_proveedor : Form
    {
        CProveedor objProveedor = new CProveedor();
        DataView dv = new DataView();

        //alamenando los pk
        int pk_edith = 0;
        int pk_registro = 0;
        public frm_proveedor()
        {
            InitializeComponent();
        }
       
        public void listarProveedor()
        {
            dv = objProveedor.listarProveedor();
            dg_proveedor.DataSource = dv;
        }

        public void estiloDg()
        {

            dg_proveedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg_proveedor.AllowUserToAddRows = false;
            dg_proveedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_proveedor.ReadOnly = true;

            dg_proveedor.Columns["pk_proveedor"].Visible = false;
            dg_proveedor.Columns["nombre"].HeaderText = "NOMBRE";
            dg_proveedor.Columns["direccion"].HeaderText = "DIRECCION";
            dg_proveedor.Columns["ruc"].HeaderText = "RUC";
            dg_proveedor.Columns["telefono"].HeaderText = "TELEFONO";
            dg_proveedor.Columns["correo"].HeaderText = "CORREO";
            dg_proveedor.Columns["deuda"].HeaderText = "DEUDA";
            dg_proveedor.Columns["deuda"].DefaultCellStyle.Format = "C";

            dg_proveedor.Columns["deuda"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void Frm_proveedor_Load(object sender, EventArgs e)
        {
            listarProveedor();
            estiloDg();
            totalRegistro();
        }

        private void Bt_insertar_Click(object sender, EventArgs e)
        {
            frm_modal_nuevo_proveedor modal = new frm_modal_nuevo_proveedor();
            DialogResult resultado = modal.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                MessageBox.Show("Se agrego correctamente", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                listarProveedor();
                totalRegistro();
            }
        }
        private void modificarProveedor()
        {
            MProveedor obj = new MProveedor();
            obj = objProveedor.modificarProveedor(pk_registro);
            frm_modal_modificar_proveedor modal = new frm_modal_modificar_proveedor();
            pk_edith = obj.pk_proveedor;
            modal.txt_nombre.Text = obj.nombre;
            modal.txt_direccion.Text = obj.direccion;
            modal.txt_ruc.Text = obj.ruc.ToString();
            modal.txt_telefono.Text = obj.telefono;
            modal.txt_correo.Text = obj.correo;
            modal.txt_deuda.Text = obj.deuda.ToString();

            if (pk_registro > 0)
            {
                DialogResult resultado = modal.ShowDialog();
                if (resultado == DialogResult.OK)
                {

                    MProveedor update = new MProveedor();

                    update.pk_proveedor = pk_edith;
                    update.nombre = modal.txt_nombre.Text;
                    update.direccion = modal.txt_direccion.Text;
                    update.ruc = modal.txt_ruc.Text;
                    update.telefono = modal.txt_telefono.Text;
                    update.correo = modal.txt_correo.Text;
                    update.deuda = Convert.ToDouble(modal.txt_deuda.Text);

                    objProveedor.actualizarProveedor(update);

                    MessageBox.Show("Se actualizo correctamente", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    listarProveedor();
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
            modificarProveedor();
        }

        private void Dg_proveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pk_registro = Convert.ToInt32(dg_proveedor.CurrentRow.Cells["pk_proveedor"].Value.ToString());
        }
        private void Bt_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Estas seguro que queieres eliminar el registro..?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                objProveedor.eliminarProveedor(pk_registro);
                listarProveedor();
                totalRegistro();
                MessageBox.Show("Se elimino correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Txt_busqueda_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = ("nombre like '%" + txt_busqueda.Text + "%'");
            totalRegistro();
        }
        private void totalRegistro()
        {
            lb_totalRegistro.Text = "Total registro: " + dg_proveedor.RowCount.ToString();
        }

        
    }
}
