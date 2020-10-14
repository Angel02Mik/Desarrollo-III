using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vista
{
    public partial class frm_modal_modificar_producto : Form
    {
        public frm_modal_modificar_producto()
        {
            InitializeComponent();
        }

        private void Bt_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Bt_actualizar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Cb_categoria_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }
    }
}
