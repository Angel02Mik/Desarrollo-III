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
    public partial class frm_modal_nuevo_unidad_medida : Form
    {
        CUnidad_medida objUnidad_medida = new CUnidad_medida();
        public frm_modal_nuevo_unidad_medida()
        {
            InitializeComponent();
        }

        private void Bt_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void insertarUnidadMedida()
        {
            MUnidad_medida obj = new MUnidad_medida();
            obj.unidad_medida = txt_medida.Text;
            obj.moneda = txt_moneda.Text;

            objUnidad_medida.insertarUnidad_medida(obj);
        }

        private void Bt_insertar_Click(object sender, EventArgs e)
        {
            insertarUnidadMedida();
            this.DialogResult = DialogResult.OK;
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
    }
}
