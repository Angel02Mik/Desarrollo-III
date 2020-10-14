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
    public partial class frm_producto : Form
    {
        CProducto objProducto = new CProducto();
        CCategoria objCategoria = new CCategoria();
        DataView dv = new DataView();
        DataView dvCategoria = new DataView();

        //almacenando los pk
        int pk_registro = 0;
        int pk_edith = 0;
        public frm_producto()
        {
            InitializeComponent();
        }

        public void listarProducto()
        {
            dv = objProducto.listarProducto();
            dg_producto.DataSource = dv;
        }

        public void estiloDg()
        {

            dg_producto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg_producto.AllowUserToAddRows = false;
            dg_producto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_producto.ReadOnly = true;

            dg_producto.Columns["pk_producto"].Visible = false;
            dg_producto.Columns["nombre"].HeaderText = "NOMBRE";
            dg_producto.Columns["descripcion"].HeaderText = "DESCRIPCION";
            dg_producto.Columns["categoria"].HeaderText = "CATEGORIA";
            dg_producto.Columns["marca"].HeaderText = "MARCA";
            dg_producto.Columns["precio_venta"].HeaderText = "PRECIO VENT";
            dg_producto.Columns["fecha_vencimiento"].HeaderText = "F/V";
            dg_producto.Columns["stock"].HeaderText = "STOCK";
            dg_producto.Columns["unidad_medida"].HeaderText = "UNIDAD-MEDIDA";
            dg_producto.Columns["ganancia"].HeaderText = "GANANCIA";

            dg_producto.Columns["ganancia"].DefaultCellStyle.Format = "C";
            dg_producto.Columns["precio_venta"].DefaultCellStyle.Format = "C";

            dg_producto.Columns["categoria"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_producto.Columns["marca"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_producto.Columns["fecha_vencimiento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_producto.Columns["nombre"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_producto.Columns["unidad_medida"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_producto.Columns["stock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_producto.Columns["precio_venta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dg_producto.Columns["ganancia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        private void Frm_producto_Load(object sender, EventArgs e)
        {
            listarProducto();
            estiloDg();
            totalRegistro();
        }

        private void Bt_insertar_Click(object sender, EventArgs e)
        {

            frm_modal modal = new frm_modal();
            DialogResult resultado = modal.ShowDialog();
            if(resultado == DialogResult.OK)
            {
                MessageBox.Show("Se agrego correctamente","Aviso",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                listarProducto();
                totalRegistro();
            }
        }

        private void modificarProducto()
        {
            MProducto obj = new MProducto();

            MCategoria objCat = new MCategoria();
            obj = objProducto.modificarProducto(pk_registro);


            int fk = obj.fk_categoria;
          

            frm_modal_modificar_producto modal = new frm_modal_modificar_producto();
            pk_edith = obj.pk_producto;

            dvCategoria = objCategoria.listarCategoria();
            modal.cb_categoria.DisplayMember = "categoria";
            modal.cb_categoria.SelectedValue = "pk_categoria";
            modal.cb_categoria.ValueMember = "pk_categoria";
            modal.cb_categoria.DataSource = dvCategoria;
            modal.cb_categoria.SelectedValue = fk;
            modal.txt_nombre.Text = obj.nombre;
            modal.txt_descripcion.Text = obj.descripcion;
            modal.txt_marca.Text = obj.marca;
            modal.txt_precioCompra.Text = obj.precio_compra.ToString();
            modal.txt_precioVenta.Text = obj.precio_venta.ToString();
            modal.dt_fechaCompra.Text = Convert.ToString(obj.fecha_compra);
            modal.dt_fechaVencimiento.Text = Convert.ToString(obj.fecha_vencimiento);
            modal.txt_stock.Text = obj.stock.ToString();
            modal.txt_unidadMedida.Text = obj.unidad_medida;

            DialogResult resultado = modal.ShowDialog();
            if (resultado == DialogResult.OK)
            {

                MProducto update = new MProducto();

                update.pk_producto = pk_edith;
                update.fk_categoria = Convert.ToInt32(modal.cb_categoria.SelectedValue);
                update.nombre = modal.txt_nombre.Text;
                update.descripcion = modal.txt_descripcion.Text;
                update.marca = modal.txt_marca.Text;
                update.precio_compra = Convert.ToDouble(modal.txt_precioCompra.Text);
                update.precio_venta = Convert.ToDouble(modal.txt_precioVenta.Text);
         
                DateTime dt = new DateTime(modal.dt_fechaCompra.Value.Year, modal.dt_fechaCompra.Value.Month, modal.dt_fechaCompra.Value.Day);
                update.fecha_compra = dt.ToString("yyyy-MM-dd");

                DateTime dt_2 = new DateTime(modal.dt_fechaVencimiento.Value.Year, modal.dt_fechaVencimiento.Value.Month, modal.dt_fechaVencimiento.Value.Day);
                update.fecha_vencimiento = dt_2.ToString("yyyy-MM-dd");

                double stock = Convert.ToDouble(modal.txt_stock.Text);
                update.stock = Convert.ToDouble(modal.txt_stock.Text);
                update.unidad_medida = "unidad";//modal.txt_unidadMedida.Text;

                double precioCompra = Convert.ToDouble(modal.txt_precioCompra.Text);
                double precioVenta = Convert.ToDouble(modal.txt_precioVenta.Text);
                double ganancia = (precioVenta - precioCompra);
                update.ganancia = ganancia * stock;

                objProducto.actualizarProducto(update);

                MessageBox.Show("Se actualizo correctamente", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                listarProducto();
                totalRegistro();
            }

        }

        private void Bt_modificar_Click(object sender, EventArgs e)
        {
            modificarProducto();
     
        }

        private void Dg_producto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pk_registro = Convert.ToInt32(dg_producto.CurrentRow.Cells["pk_producto"].Value.ToString());
        }

        private void Bt_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Estas seguro que queieres eliminar el registro..?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(resultado == DialogResult.Yes)
            {
                objProducto.eliminarProducto(pk_registro);
                listarProducto();
                totalRegistro();
            }
        }

        private void Txt_busqueda_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = ("nombre like '%"+txt_busqueda.Text+"%'");
            totalRegistro();
        }

        private void totalRegistro()
        {
            lb_totalRegistro.Text = "Total registro: "+ dg_producto.RowCount.ToString();
        }
    }
}
