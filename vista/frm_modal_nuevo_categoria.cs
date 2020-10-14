using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using controlador;
using modelo;

namespace vista
{
    public partial class frm_modal_nuevo_categoria : Form
    {
        CCategoria objCategoria = new CCategoria();
        public frm_modal_nuevo_categoria()
        {
            InitializeComponent();
        }

        int posY = 0;
        int posX = 0;
        private void Pn_header_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
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

        private void insertarCategoria()
        {
            MCategoria obj = new MCategoria();

            obj.categoria = txt_categoria.Text;
           
            objCategoria.insertarCategoria(obj);

        }

        private void Bt_insertar_Click(object sender, EventArgs e)
        {
            insertarCategoria();
            this.DialogResult = DialogResult.OK;
        }

        private void Bt_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        
    }
}
