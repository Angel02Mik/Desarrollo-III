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
    public partial class frm_modal_nuevo_documento : Form
    {
        CDocumento objDocumento = new CDocumento();
        public frm_modal_nuevo_documento()
        {
            InitializeComponent();
        }

        private void insertarDocumento()
        {
            MDocumento obj = new MDocumento();
            obj.codigo = txt_codigo.Text;
            obj.nombre = txt_nombre.Text;
            obj.serie = txt_serie.Text;
            obj.numero = txt_numero.Text;

            objDocumento.insertarDocumento(obj);
        }
        private void Bt_insertar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            insertarDocumento();
        }

        private void Bt_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
