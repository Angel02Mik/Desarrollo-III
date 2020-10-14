using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace vista
{
    public partial class frm_caja : Form
    {
        public frm_caja()
        {
            InitializeComponent();
        }

        private void mostrarChar()
        {
           
            Color[] colores = new Color[] { Color.FromArgb(130, 124, 131), Color.FromArgb(31, 227, 111), Color.FromArgb(255, 2, 59), Color.FromArgb(35, 245, 82), Color.FromArgb(245, 35, 35), Color.FromArgb(0, 228, 255) };
            char_caja.Series["serie_uno"].Points.AddXY("S/  150","150");//MONTO INICIAL
            char_caja.Series["serie_uno"].Points.AddXY("S/  140","140" );//INGRESO
            char_caja.Series["serie_uno"].Points.AddXY("S/ 100", "100");//DEVOLUCIONES
            char_caja.Series["serie_uno"].Points.AddXY("S/ 230","230");//DEUDA A COBRAR
            char_caja.Series["serie_uno"].Points.AddXY("S/ 300", "300");//DEUDA A PAGAR
            char_caja.Series["serie_uno"].Points.AddXY("S/ 1000", "1000");//GASTOS
            char_caja.Series["serie_uno"].Points.AddXY("S/ 1200", "1200");//INGRESO TOTAL

            char_caja.Palette = ChartColorPalette.None;
            char_caja.PaletteCustomColors = colores;
        }
        private void Frm_caja_Load(object sender, EventArgs e)
        {
            mostrarChar();
        }

        private void Bt_movimiento_Click(object sender, EventArgs e)
        {

        }

        private void Bt_cerrarCaja_Click(object sender, EventArgs e)
        {

        }

        private void Bt_abrirCaja_Click(object sender, EventArgs e)
        {

        }
    }
}
