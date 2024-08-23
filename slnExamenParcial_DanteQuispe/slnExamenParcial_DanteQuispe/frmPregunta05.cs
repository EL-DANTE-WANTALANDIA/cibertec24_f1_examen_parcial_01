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
    public partial class frmPregunta05 : Form
    {
        public frmPregunta05()
        {
            InitializeComponent();
            cmbBox1.Items.Add("A");
            cmbBox1.Items.Add("B");
            cmbBox1.Items.Add("C");
            cmbBox1.Items.Add("D");
        }

        private void cmbBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalcularPension();
        }


        private void CalcularPension()
        {
            //throw new NotImplementedException();
            //Constantes
            int pensionA = 550, pensionB = 500, pensionC = 460, pensionD = 400;

            //Variables
            double descuento = 0.0, pensionActual = 0.0;

            //Entrada
            var categoria = cmbBox1.SelectedItem;
            double promedio = Convert.ToDouble(numericUpDown1.Text);

            //Proceso
            switch (categoria)
            {
                case "A":
                    if (0 <= promedio && promedio <= 13.99)
                    {
                        descuento = 0;
                        pensionActual = pensionA;
                    }
                    else if (14.00 <= promedio && promedio <= 15.99)
                    {
                        descuento = pensionA * 0.1;
                        pensionActual = pensionA - descuento;
                    }
                    else if (16.00 <= promedio && promedio <= 17.99)
                    {
                        descuento = pensionA * 0.12;
                        pensionActual = pensionA - descuento;
                    }
                    else
                    {
                        descuento = pensionA * 0.15;
                        pensionActual = pensionA - descuento;
                    }

                    //Salida
                    txtBox1.Text = "S/." + pensionA.ToString();
                    txtBox2.Text = "S/." + descuento.ToString();
                    txtBox3.Text = "S/." + pensionActual.ToString();
                    break;

                case "B":
                    if (0 <= promedio && promedio <= 13.99)
                    {
                        descuento = 0;
                        pensionActual = pensionB;
                    }
                    else if (14.00 <= promedio && promedio <= 15.99)
                    {
                        descuento = pensionB * 0.1;
                        pensionActual = pensionB - descuento;
                    }
                    else if (16.00 <= promedio && promedio <= 17.99)
                    {
                        descuento = pensionB * 0.12;
                        pensionActual = pensionB - descuento;
                    }
                    else
                    {
                        descuento = pensionB * 0.15;
                        pensionActual = pensionB - descuento;
                    }

                    //Salida
                    txtBox1.Text = "S/." + pensionB.ToString();
                    txtBox2.Text = "S/." + descuento.ToString();
                    txtBox3.Text = "S/." + pensionActual.ToString();
                    break;

                case "C":
                    if (0 <= promedio && promedio <= 13.99)
                    {
                        descuento = 0;
                        pensionActual = pensionC;
                    }
                    else if (14.00 <= promedio && promedio <= 15.99)
                    {
                        descuento = pensionC * 0.1;
                        pensionActual = pensionC - descuento;
                    }
                    else if (16.00 <= promedio && promedio <= 17.99)
                    {
                        descuento = pensionC * 0.12;
                        pensionActual = pensionC - descuento;
                    }
                    else
                    {
                        descuento = pensionC * 0.15;
                        pensionActual = pensionC - descuento;
                    }

                    //Salida
                    txtBox1.Text = "S/." + pensionC.ToString();
                    txtBox2.Text = "S/." + descuento.ToString();
                    txtBox3.Text = "S/." + pensionActual.ToString();
                    break;

                default:
                    if (0 <= promedio && promedio <= 13.99)
                    {
                        descuento = 0;
                        pensionActual = pensionD;
                    }
                    else if (14.00 <= promedio && promedio <= 15.99)
                    {
                        descuento = pensionD * 0.1;
                        pensionActual = pensionD - descuento;
                    }
                    else if (16.00 <= promedio && promedio <= 17.99)
                    {
                        descuento = pensionD * 0.12;
                        pensionActual = pensionD - descuento;
                    }
                    else
                    {
                        descuento = pensionD * 0.15;
                        pensionActual = pensionD - descuento;
                    }

                    //Salida
                    txtBox1.Text = "S/." + pensionD.ToString();
                    txtBox2.Text = "S/." + descuento.ToString();
                    txtBox3.Text = "S/." + pensionActual.ToString();
                    break;
            };

            //Salida

        }

        private void frmPregunta05_Load(object sender, EventArgs e)
        {

        }
    }
}
