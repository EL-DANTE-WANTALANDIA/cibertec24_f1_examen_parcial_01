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

namespace slnExamenParcial_DanteQuispe
{
    public partial class frmPregunta02 : Form
    {
        public frmPregunta02()
        {
            InitializeComponent();
        }

        private void frmPregunta02_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            DeterminarMonto();
        }
        private void DeterminarMonto()
        {
            //throw new NotImplementedException();
            // Limpiar el LabelText
            lbl3.Text = "";
            lbl4.Text = "";
            //Constantes
            double IGV = 0.18;
            double descuento = 0.12;
            //Variables
            //Proceso
            double precioCompras = Convert.ToDouble(txtBox1.Text);
            var precioDescuento = precioCompras * descuento;
            var precioConDescuento = precioCompras - precioDescuento;
            var totalIGV = precioConDescuento * IGV;

            //Salida
            double totalMonto = precioConDescuento + totalIGV;

            txtBox2.Text = totalMonto.ToString();
            lbl3.Text = $"Descuento: {precioDescuento}";
            lbl4.Text = $"IGV: {totalIGV}";

        }


    }
}
