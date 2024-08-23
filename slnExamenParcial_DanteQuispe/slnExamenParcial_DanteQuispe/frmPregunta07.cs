using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slnExamenParcial_DanteQuispe
{
    public partial class frmPregunta07 : Form
    {
        public frmPregunta07()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            GenerarFibonacci();
        }

        private void GenerarFibonacci()
        {
            //throw new NotImplementedException();
            // Limpiar el ListBox
            lstBox1.Items.Clear();
            lbl2.Text = "";

            //Constantes
            int primerNumero = 0, segundoNumero = 1, siguienteNumero = 0;

            //Variables
            int tamanio = 0;

            //Entrada

            //Proceso
            tamanio = int.Parse(txtBox1.Text);

            if (tamanio < 2)
            {
                lbl2.Text = $"El tamaño de la serie tiene que ser superios a: {tamanio}";
                return;
            }
            else
            {
                lstBox1.Items.Add($"{primerNumero}");
                lstBox1.Items.Add($"{segundoNumero}");
                lstBox1.Text = $"{primerNumero}, {segundoNumero}";
            }

            for (int i = 2; i < tamanio; i++) 
            {
                siguienteNumero = primerNumero + segundoNumero;
                //lstBox1.Text += $"{siguienteNumero},";
                lstBox1.Items.Add($"{siguienteNumero}");
                lstBox1.Text += $"{siguienteNumero},";
                primerNumero = segundoNumero;
                segundoNumero = siguienteNumero;
            }

            //Salida

        }
    }
}
