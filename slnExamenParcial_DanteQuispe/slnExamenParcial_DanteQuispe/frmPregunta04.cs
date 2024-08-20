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
    public partial class frmPregunta04 : Form
    {
        public frmPregunta04()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DestinarDonacion();
        }

        private void DestinarDonacion()
        {
            //throw new NotImplementedException();
            //Constantes
 
            //Variables
            double donacionAnual = Convert.ToDouble(txtBox1.Text);

            //Proceso
            double totalImporteCentroSalud = 0.0;
            double totalImporteComedorNinios = 0.0;
            double totalBolsa = 0.0;

            if (donacionAnual > 10000)
            {
                totalImporteCentroSalud = donacionAnual * 0.3;
                totalImporteComedorNinios = donacionAnual * 0.5;
                totalBolsa = donacionAnual * 0.2;

                totalImporteCentroSalud = Math.Round(totalImporteCentroSalud, 2); //  redondear a 2 dígitos
                totalImporteComedorNinios = Math.Round(totalImporteComedorNinios, 2); //  redondear a 2 dígitos
                totalBolsa = Math.Round(totalBolsa, 2); //  redondear a 2 dígitos
            }
            else
            {
                totalImporteCentroSalud = donacionAnual * 0.25;
                totalImporteComedorNinios = donacionAnual * 0.6;
                totalBolsa = donacionAnual * 0.15;

                totalImporteCentroSalud = Math.Round(totalImporteCentroSalud, 2); //  redondear a 2 dígitos
                totalImporteComedorNinios = Math.Round(totalImporteComedorNinios, 2); //  redondear a 2 dígitos
                totalBolsa = Math.Round(totalBolsa, 2); //  redondear a 2 dígitos
            }

            //Salida
            txtBox2.Text = "$." + totalImporteCentroSalud.ToString();
            txtBox3.Text = "$." + totalImporteComedorNinios.ToString();
            txtBox4.Text = "$." + totalBolsa.ToString();
        }
    }
}
