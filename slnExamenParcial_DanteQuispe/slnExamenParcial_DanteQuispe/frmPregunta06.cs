﻿using System;
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
    public partial class frmPregunta06 : Form
    {
        public frmPregunta06()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            GenerarSueldo();
        }
        private void GenerarSueldo()
        {
            // Limpiar el ListBox y el Label
            lstBox1.Items.Clear();
            lbl1.Text = "";
            lbl2.Text = "";
            lbl3.Text = "";
            lbl4.Text = "";

            // Variables para almacenar los sueldos y cálculos
            Random random = new Random();
            double[] sueldos = new double[120];
            double sumaSueldos = 0;
            double sueldoMaximo = double.MinValue;
            double sueldoMinimo = double.MaxValue;
            int empleadosInferior1000 = 0;
            double sueldoPromedio = 0;

            // Generar sueldos aleatorios y realizar cálculos
            for (int i = 0; i < 120; i++)
            {
                sueldos[i] = random.Next(800, 1701); // Rango entre 800 y 1700
                lstBox1.Items.Add($"Empleado {i + 1}: S/. {sueldos[i]}");
                sumaSueldos += sueldos[i];
                sueldoMaximo = Math.Max(sueldoMaximo, sueldos[i]);
                sueldoMinimo = Math.Min(sueldoMinimo, sueldos[i]);
                sueldoPromedio = sumaSueldos / 120;
                sueldoPromedio = Math.Round(sueldoPromedio, 2); //  redondear a 2 dígitos
                if (sueldos[i] < 1000)
                    empleadosInferior1000++;
            }

            // Mostrar la suma total de los sueldos
            lbl1.Text = $"El Sueldo Promedio es: S/. {sueldoPromedio}";
            lbl2.Text = $"El Sueldo Máximo es: S/. {sueldoMaximo}";
            lbl3.Text = $"El Sueldo Mínimo es: S/. {sueldoMinimo}";
            lbl4.Text = $"Empleados que ganan un sueldo inferior a S/. 1000: {empleadosInferior1000}";
        }
    }
}
