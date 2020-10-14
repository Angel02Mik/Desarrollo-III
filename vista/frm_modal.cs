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
    public partial class frm_modal : Form
    {
        CProducto objProducto = new CProducto();
        CCategoria objCategoria = new CCategoria();
        DataView dv = new DataView();
        public frm_modal()
        {
            InitializeComponent();
        }

        private void cargarCategoria()
        {
            dv = objCategoria.listarCategoria();
            cb_categoria.ValueMember = "pk_categoria";
            cb_categoria.DisplayMember = "categoria";
            cb_categoria.SelectedValue = "pk_categoria";
            cb_categoria.DataSource = dv;
           
        }
        private void Frm_modal_Load(object sender, EventArgs e)
        {
            cargarCategoria();
        }

        private void Bt_cancelar_Click(object sender, EventArgs e)
        {
           
            this.DialogResult = DialogResult.Cancel;
        }

        int posY = 0;
        int posX = 0;
        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        private void insertarProducto()
        {
            MProducto obj = new MProducto();

            obj.fk_categoria = Convert.ToInt32(cb_categoria.SelectedValue);//Convert.ToInt32(cb_categoria.Text);
            obj.nombre = txt_nombre.Text;
            obj.descripcion = txt_descripcion.Text;
            obj.marca = txt_marca.Text;
            double precio_compra = Convert.ToDouble(txt_precioCompra.Text);
            double precio_venta = Convert.ToDouble(txt_precioVenta.Text);
            obj.precio_compra = Convert.ToDouble(txt_precioCompra.Text);
            obj.precio_venta = Convert.ToDouble(txt_precioVenta.Text);
            DateTime dt = new DateTime(dt_fechaCompra.Value.Year, dt_fechaCompra.Value.Month, dt_fechaCompra.Value.Day);
            obj.fecha_compra = dt.ToString("yyyy-MM-dd");

            DateTime dt_2 = new DateTime(dt_fechaVencimiento.Value.Year, dt_fechaVencimiento.Value.Month, dt_fechaVencimiento.Value.Day);
            obj.fecha_vencimiento = dt_2.ToString("yyyy-MM-dd");

            double stock  = Convert.ToDouble(txt_stock.Text);
            obj.stock = Convert.ToDouble(txt_stock.Text);
            obj.unidad_medida = "unidad";// txt_unidadMedida.Text;
            double ganancia = (precio_venta - precio_compra);
            obj.ganancia = ganancia * stock;
            obj.foto = "mmm.jpg";

            objProducto.insertarProducto(obj);
            
        }

        private void Bt_insertar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            insertarProducto();
            
        }
    }
}
