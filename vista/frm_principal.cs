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
    public partial class frm_principal : Form
    {
        
      
        public frm_principal()
        {
            InitializeComponent();

        }
      

        //cambiar color te texto de button
        private void cambiarColorButton()
        {
            bt_inicio.ForeColor = Color.White;
            bt_venta.ForeColor = Color.White;
            bt_producto.ForeColor = Color.White;
            bt_categoria.ForeColor = Color.White;
            bt_cliente.ForeColor = Color.White;
            bt_proveedor.ForeColor = Color.White;
            bt_compras.ForeColor = Color.White;
            bt_documento.ForeColor = Color.White;
            bt_cargo.ForeColor = Color.White;
            bt_personal.ForeColor = Color.White;
            bt_caja.ForeColor = Color.White;
            bt_unidadMedida.ForeColor = Color.White;
            bt_usuario.ForeColor = Color.White;

        }


        private void Bt_inicio_Click(object sender, EventArgs e)
        {
            if (pn_principal.Controls.Count > 0)
                pn_principal.Controls.RemoveAt(0);
            frm_inicio inicio = new frm_inicio();
            if (inicio.Size.Width > Size.Width || inicio.Size.Height > Size.Height)
            {
                Size = new Size(inicio.Width + bt_inicio.Size.Width, inicio.Height + bt_inicio.Size.Height);
            }

            inicio.FormBorderStyle = FormBorderStyle.None;
            inicio.Dock = DockStyle.Fill;
            inicio.TopLevel = false;
            pn_principal.Controls.Add(inicio);
            pn_principal.Tag = inicio;
            inicio.Show();

            cambiarColorButton();
            bt_inicio.ForeColor = Color.FromArgb(0, 177, 205);
        }

        private void Bt_venta_Click(object sender, EventArgs e)
        {
            cambiarColorButton();
            bt_venta.ForeColor = Color.FromArgb(0, 177, 205);
        }


        private void Bt_producto_Click(object sender, EventArgs e)
        {
            if (pn_principal.Controls.Count > 0)
                pn_principal.Controls.RemoveAt(0);
            frm_producto producto = new frm_producto();
            if (producto.Size.Width > Size.Width || producto.Size.Height > Size.Height)
            {
                Size = new Size(producto.Width + bt_producto.Size.Width, producto.Height + bt_producto.Size.Height);
            }

            producto.FormBorderStyle = FormBorderStyle.None;
            producto.Dock = DockStyle.Fill;
            producto.TopLevel = false;
            pn_principal.Controls.Add(producto);
            pn_principal.Tag = producto;
            producto.Show();

            cambiarColorButton();
            bt_producto.ForeColor = Color.FromArgb(0, 177, 205);
        }

        private void Bt_categoria_Click(object sender, EventArgs e)
        {
            if (pn_principal.Controls.Count > 0)
                pn_principal.Controls.RemoveAt(0);
            frm_categoria categoria = new frm_categoria();
            if(categoria.Size.Width > Size.Width || categoria.Size.Height > Size.Height)
            {
                Size = new Size(categoria.Width + bt_categoria.Size.Width,categoria.Height+bt_categoria.Size.Height);
            }
            categoria.FormBorderStyle = FormBorderStyle.None;
            categoria.Dock = DockStyle.Fill;
            categoria.TopLevel = false;
            pn_principal.Controls.Add(categoria);
            pn_principal.Tag = categoria;
            categoria.Show();

            cambiarColorButton();
            bt_categoria.ForeColor = Color.FromArgb(0, 177, 205);
        }

        private void Bt_cliente_Click(object sender, EventArgs e)
        {
            if (pn_principal.Controls.Count > 0)
                pn_principal.Controls.RemoveAt(0);
            frm_cliente cliente = new frm_cliente();
            if(cliente.Size.Width > Size.Width || cliente.Size.Height > Size.Height)
            {
                Size = new Size(cliente.Width + bt_cliente.Size.Width, cliente.Height + bt_cliente.Size.Height);
            }

            cliente.FormBorderStyle = FormBorderStyle.None;
            cliente.Dock = DockStyle.Fill;
            cliente.TopLevel = false;
            pn_principal.Controls.Add(cliente);
            pn_principal.Tag = cliente;
            cliente.Show();

            cambiarColorButton();
            bt_cliente.ForeColor = Color.FromArgb(0, 177, 205);
        }

        private void Bt_proveedor_Click(object sender, EventArgs e)
        {
            if (pn_principal.Controls.Count > 0)
                pn_principal.Controls.RemoveAt(0);
            frm_proveedor proveedor = new frm_proveedor();
            if(proveedor.Size.Width > Size.Width || proveedor.Size.Height > Size.Height)
            {
                Size = new Size(proveedor.Width + bt_proveedor.Size.Width, proveedor.Height + bt_proveedor.Size.Height);
            }
            proveedor.FormBorderStyle = FormBorderStyle.None;
            proveedor.Dock = DockStyle.Fill;
            proveedor.TopLevel = false;
            pn_principal.Controls.Add(proveedor);
            pn_principal.Tag = proveedor;
            proveedor.Show();

            cambiarColorButton();
            bt_proveedor.ForeColor = Color.FromArgb(0, 177, 205);
        }

        private void Bt_compras_Click(object sender, EventArgs e)
        {
            cambiarColorButton();
            bt_compras.ForeColor = Color.FromArgb(0, 177, 205);
        }

        private void Bt_usuario_Click(object sender, EventArgs e)
        {
            if (pn_principal.Controls.Count > 0)
                pn_principal.Controls.RemoveAt(0);
            frm_usuario usuario = new frm_usuario();
            if (usuario.Size.Width > Size.Width || usuario.Size.Height > Size.Height)
            {
                Size = new Size(usuario.Width + bt_usuario.Size.Width, usuario.Height + bt_usuario.Size.Height);
            }

            usuario.FormBorderStyle = FormBorderStyle.None;
            usuario.Dock = DockStyle.Fill;
            usuario.TopLevel = false;
            pn_principal.Controls.Add(usuario);
            pn_principal.Tag = usuario;
            usuario.Show();

            cambiarColorButton();
            bt_usuario.ForeColor = Color.FromArgb(0, 177, 205);
        }

        private void Bt_documento_Click(object sender, EventArgs e)
        {
            if (pn_principal.Controls.Count > 0)
                pn_principal.Controls.RemoveAt(0);
            frm_documento documento = new frm_documento();
            if (documento.Size.Width > Size.Width || documento.Size.Height > Size.Height)
            {
                Size = new Size(documento.Width + bt_documento.Size.Width, documento.Height + bt_documento.Size.Height);
            }

            documento.FormBorderStyle = FormBorderStyle.None;
            documento.Dock = DockStyle.Fill;
            documento.TopLevel = false;
            pn_principal.Controls.Add(documento);
            pn_principal.Tag = documento;
            documento.Show();

            cambiarColorButton();
            bt_documento.ForeColor = Color.FromArgb(0, 177, 205);
        }

        private void Bt_personal_Click(object sender, EventArgs e)
        {

            if (pn_principal.Controls.Count > 0)
                pn_principal.Controls.RemoveAt(0);
             frm_personal personal = new frm_personal();
            if (personal.Size.Width > Size.Width || personal.Size.Height > Size.Height)
            {
                Size = new Size(personal.Width + bt_personal.Size.Width, personal.Height + bt_personal.Size.Height);
            }

            personal.FormBorderStyle = FormBorderStyle.None;
            personal.Dock = DockStyle.Fill;
            personal.TopLevel = false;
            pn_principal.Controls.Add(personal);
            pn_principal.Tag = personal;
            personal.Show();

            cambiarColorButton();
            bt_personal.ForeColor = Color.FromArgb(0, 177, 205);
        }

        private void Bt_cargo_Click(object sender, EventArgs e)
        {
            if (pn_principal.Controls.Count > 0)
                pn_principal.Controls.RemoveAt(0);
            frm_cargo cargo = new frm_cargo();
            if (cargo.Size.Width > Size.Width || cargo.Size.Height > Size.Height)
            {
                Size = new Size(cargo.Width + bt_cargo.Size.Width, cargo.Height + bt_cargo.Size.Height);
            }

            cargo.FormBorderStyle = FormBorderStyle.None;
            cargo.Dock = DockStyle.Fill;
            cargo.TopLevel = false;
            pn_principal.Controls.Add(cargo);
            pn_principal.Tag = cargo;
            cargo.Show();

            cambiarColorButton();
            bt_cargo.ForeColor = Color.FromArgb(0, 177, 205);
        }

        private void Bt_caja_Click(object sender, EventArgs e)
        {

            if (pn_principal.Controls.Count > 0)
                pn_principal.Controls.RemoveAt(0);
            frm_caja caja = new frm_caja();
            if (caja.Size.Width > Size.Width || caja.Size.Height > Size.Height)
            {
                Size = new Size(caja.Width + bt_caja.Size.Width, caja.Height + bt_caja.Size.Height);
            }

            caja.FormBorderStyle = FormBorderStyle.None;
            caja.Dock = DockStyle.Fill;
            caja.TopLevel = false;
            pn_principal.Controls.Add(caja);
            pn_principal.Tag = caja;
            caja.Show();

            cambiarColorButton();
            bt_caja.ForeColor = Color.FromArgb(0, 177, 205);
        }

        private void Bt_unidadMedida_Click(object sender, EventArgs e)
        {
            if (pn_principal.Controls.Count > 0)
                pn_principal.Controls.RemoveAt(0);
            frm_unidad_medida unidad_medida = new frm_unidad_medida();
            if (unidad_medida.Size.Width > Size.Width || unidad_medida.Size.Height > Size.Height)
            {
                Size = new Size(unidad_medida.Width + bt_unidadMedida.Size.Width, unidad_medida.Height + bt_unidadMedida.Size.Height);
            }

            unidad_medida.FormBorderStyle = FormBorderStyle.None;
            unidad_medida.Dock = DockStyle.Fill;
            unidad_medida.TopLevel = false;
            pn_principal.Controls.Add(unidad_medida);
            pn_principal.Tag = unidad_medida;
            unidad_medida.Show();

            cambiarColorButton();
            bt_unidadMedida.ForeColor = Color.FromArgb(0, 177, 205);
        }

        private void Bt_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Bt_configuracion_Click(object sender, EventArgs e)
        {
            if (pn_principal.Controls.Count > 0)
                pn_principal.Controls.RemoveAt(0);
            frm_configuracion configuracion = new frm_configuracion();
            if (configuracion.Size.Width > Size.Width || configuracion.Size.Height > Size.Height)
            {
                Size = new Size(configuracion.Width + bt_configuracion.Size.Width, configuracion.Height + bt_configuracion.Size.Height);
            }

            configuracion.FormBorderStyle = FormBorderStyle.None;
            configuracion.Dock = DockStyle.Fill;
            configuracion.TopLevel = false;
            pn_principal.Controls.Add(configuracion);
            pn_principal.Tag = configuracion;
            configuracion.Show();

        }

        //boton normal
        private void Bt_maximizar_Click(object sender, EventArgs e)
        {
            bt_completo.Visible = true;
            bt_maximizar.Visible = false;
            this.WindowState = FormWindowState.Normal;
        }

        private void Bt_minimizar_Click(object sender, EventArgs e)
        {
           
            this.WindowState = FormWindowState.Minimized;
        }

        private void Bt_completo_Click(object sender, EventArgs e)
        {
            bt_maximizar.Visible = true;
            bt_completo.Visible = false;
            this.WindowState = FormWindowState.Maximized;
        }


        int posX = 0;
        int posY = 0;
        private void Pn_header_MouseMove(object sender, MouseEventArgs e)
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

        private void Bt_cerrarSesion_Click(object sender, EventArgs e)
        {
            frm_login login = new frm_login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        CConfiguracion objConfiguracion = new CConfiguracion();

        private void lanzarInicio()
        {
            if (pn_principal.Controls.Count > 0)
                pn_principal.Controls.RemoveAt(0);
            frm_inicio inicio = new frm_inicio();
            if (inicio.Size.Width > Size.Width || inicio.Size.Height > Size.Height)
            {
                Size = new Size(inicio.Size.Width, inicio.Size.Height);
            }

            inicio.FormBorderStyle = FormBorderStyle.None;
            inicio.Dock = DockStyle.Fill;
            inicio.TopLevel = false;
            pn_principal.Controls.Add(inicio);
            pn_principal.Tag = inicio;
            inicio.Show();
        }


        private void Frm_principal_Load(object sender, EventArgs e)
        {

            MConfiguracion obj = new MConfiguracion();
            obj = objConfiguracion.mostrarFoto();
            string nombre = obj.foto;
            pb_logo.Image = Image.FromFile(@"recursos/"+nombre+".png");

            lanzarInicio();
         
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lb_hora.Text = DateTime.Now.ToLongTimeString();
            lb_fecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
