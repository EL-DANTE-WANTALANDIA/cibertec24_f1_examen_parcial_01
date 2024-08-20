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
    public partial class frmPregunta1 : Form
    {

        public frmPregunta1()
        {
            InitializeComponent();
        }

        private void frmPregunta1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalcularCalorias();
        }

        private void CalcularCalorias()
        {
            //throw new NotImplementedException();
            //Constantes
            double caloriasPorMinutoDormido = 1.08;
            double caloriasPorMinutoEnReposo = 1.66;
            //Variables
            //Proceso
            double horasDormidas = Convert.ToDouble(txtBox1.Text);
            double horasEnReposo = Convert.ToDouble(txtBox2.Text);

            var horasDormidasEnMinutos = horasDormidas * 60;
            var horasEnReposoEnMinutos = horasEnReposo * 60;

            var subTotalCalorias1 = horasDormidasEnMinutos * caloriasPorMinutoDormido;
            var subTotalCalorias2 = horasEnReposoEnMinutos * caloriasPorMinutoEnReposo;
            //Salida
            double totalCalorias = subTotalCalorias1 + subTotalCalorias2;

            txtBox3.Text = totalCalorias.ToString();

        }
    }
}
