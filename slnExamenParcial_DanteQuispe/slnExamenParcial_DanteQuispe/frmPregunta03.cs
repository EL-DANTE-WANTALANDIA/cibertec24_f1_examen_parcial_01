using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace slnExamenParcial_DanteQuispe
{
    public partial class frmPregunta03 : Form
    {
        public frmPregunta03()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalcularImporte();
        }

        private void CalcularImporte()
        {
            //Constantes
            double descuentoMayor50 = 0.15;
            double descuentoMenor50 = 0.05;

            double precioUnitario_1_50 = 25.5;
            double precioUnitario_51_100 = 22.5;
            double precioUnitario_101_150 = 20.0;
            double precioUnitario_101_mas = 18.0;

            //Variables

            //Proceso
            int unidadesAdquiridas = Convert.ToInt32(txtBox1.Text);
            double subTotalImporte = 0.0;
            double totalImporte = 0.0;
            double totalDescuento = 0.0;
            var precioUnit = 0.0;
            var descuento = 0.0;
            if (1 <= unidadesAdquiridas && unidadesAdquiridas <= 50)
            {
                precioUnit = precioUnitario_1_50;
                descuento = descuentoMenor50 * 100;
                subTotalImporte = unidadesAdquiridas * precioUnitario_1_50;
                totalDescuento = subTotalImporte * descuentoMenor50;
                totalImporte = subTotalImporte - totalDescuento;
                totalDescuento = Math.Round(totalDescuento, 2); //  redondear a 2 dígitos
                totalImporte = Math.Round(totalImporte, 2); //  redondear a 2 dígitos
            }
            else if (51 <= unidadesAdquiridas && unidadesAdquiridas <= 100)
            {
                precioUnit = precioUnitario_51_100;
                descuento = descuentoMayor50 * 100;
                subTotalImporte = unidadesAdquiridas * precioUnitario_51_100;
                totalDescuento = subTotalImporte * descuentoMayor50;
                totalImporte = subTotalImporte - totalDescuento;
                totalDescuento = Math.Round(totalDescuento, 2); //  redondear a 2 dígitos
                totalImporte = Math.Round(totalImporte, 2); //  redondear a 2 dígitos
            }
            else if (101 <= unidadesAdquiridas && unidadesAdquiridas <= 150)
            {
                precioUnit = precioUnitario_101_150;
                descuento = descuentoMayor50 * 100;
                subTotalImporte = unidadesAdquiridas * precioUnitario_101_150;
                totalDescuento = subTotalImporte * descuentoMayor50;
                totalImporte = subTotalImporte - totalDescuento;
                totalDescuento = Math.Round(totalDescuento, 2); //  redondear a 2 dígitos
                totalImporte = Math.Round(totalImporte, 2); //  redondear a 2 dígitos
            }
            else
            {
                precioUnit = precioUnitario_101_mas;
                descuento = descuentoMayor50 * 100;
                subTotalImporte = unidadesAdquiridas * precioUnitario_101_mas;
                totalDescuento = subTotalImporte * descuentoMayor50;
                totalImporte = subTotalImporte - totalDescuento;
                totalDescuento = Math.Round(totalDescuento, 2); //  redondear a 2 dígitos
                totalImporte = Math.Round(totalImporte, 2); //  redondear a 2 dígitos
            }

            //Salida
            txtBox3.Text = "S/." + totalDescuento.ToString();
            txtBox2.Text = "S/." + totalImporte.ToString();
            txtBox4.Text = "S/." + precioUnit.ToString();
            txtBox5.Text = descuento.ToString()+"%";
        }

        private void lbl5_Click(object sender, EventArgs e)
        {

        }
    }
}
