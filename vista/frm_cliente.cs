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
    public partial class frm_cliente : Form
    {
        CCliente objCliente = new CCliente();
        DataView dv = new DataView();

        //alamenando los pk
        int pk_edith = 0;
        int pk_registro = 0;
        public frm_cliente()
        {
            InitializeComponent();
        }

        public void listarCliente()
        {
            dv = objCliente.listarCliente();
            dg_cliente.DataSource = dv;
        }

        public void estiloDg()
        {

            dg_cliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg_cliente.AllowUserToAddRows = false;
            dg_cliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_cliente.ReadOnly = true;

            dg_cliente.Columns["pk_cliente"].Visible = false;
            dg_cliente.Columns["nombres"].HeaderText = "NOMBRE";
            dg_cliente.Columns["apellidos"].HeaderText = "APELLIDO";
            dg_cliente.Columns["direccion"].HeaderText = "DIRECCION";
            dg_cliente.Columns["dni"].HeaderText = "DNI";
            dg_cliente.Columns["telefono"].HeaderText = "TELEFONO";
            dg_cliente.Columns["correo"].HeaderText = "CORREO";
            dg_cliente.Columns["deuda"].HeaderText = "DEUDA";
            dg_cliente.Columns["deuda"].DefaultCellStyle.Format = "C";

            dg_cliente.Columns["deuda"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void Frm_cliente_Load(object sender, EventArgs e)
        {
            listarCliente();
            estiloDg();
            totalRegistro();
        }

        private void Bt_insertar_Click_1(object sender, EventArgs e)
        {

            frm_modal_nuevo_cliente modal = new frm_modal_nuevo_cliente();
            DialogResult resultado = modal.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                MessageBox.Show("Se agrego correctamente", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                listarCliente();
                totalRegistro();
            }
        }
        private void modificarCliente()
        {
            MCliente obj = new MCliente();
            obj = objCliente.modificarCliente(pk_registro);
            frm_modal_modificar_cliente modal = new frm_modal_modificar_cliente();
            pk_edith = obj.pk_cliente;
            modal.txt_nombres.Text = obj.nombres;
            modal.txt_apellidos.Text = obj.apellidos;
            modal.txt_direccion.Text = obj.direccion;
            modal.txt_dni.Text = obj.dni.ToString();
            modal.txt_telefono.Text = obj.telefono;
            modal.txt_correo.Text = obj.correo;
            modal.txt_deuda.Text = obj.deuda.ToString();

            if(pk_registro > 0)
            {
                DialogResult resultado = modal.ShowDialog();
                if (resultado == DialogResult.OK)
                {

                    MCliente update = new MCliente();

                    update.pk_cliente = pk_edith;
                    update.nombres = modal.txt_nombres.Text;
                    update.apellidos = modal.txt_apellidos.Text;
                    update.direccion = modal.txt_direccion.Text;
                    update.dni = Convert.ToInt32(modal.txt_dni.Text);
                    update.telefono = modal.txt_telefono.Text;
                    update.correo = modal.txt_correo.Text;
                    update.deuda = Convert.ToDouble(modal.txt_deuda.Text);

                    objCliente.actualizarCliente(update);

                    MessageBox.Show("Se actualizo correctamente", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    listarCliente();
                    totalRegistro();
                }
            }
            else
            {
                MessageBox.Show("Selecciona un registro","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
           
        }

        private void Bt_modificar_Click_1(object sender, EventArgs e)
        {
            modificarCliente();

        }
     
        private void Dg_cliente_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            pk_registro = Convert.ToInt32(dg_cliente.CurrentRow.Cells["pk_cliente"].Value.ToString());
        }

        private void Bt_eliminar_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Estas seguro que queieres eliminar el registro..?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                objCliente.eliminarCliente(pk_registro);
                listarCliente();
                totalRegistro();
            }
        }

        private void Txt_busqueda_TextChanged_1(object sender, EventArgs e)
        {
            dv.RowFilter = ("nombres like '%" + txt_busqueda.Text + "%'");
            totalRegistro();
        }
        private void totalRegistro()
        {
            lb_totalRegistro.Text = "Total registro: " + dg_cliente.RowCount.ToString();
        }

       
    }
}
