using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2_Cap2_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            double grados;

            // Leer el valor en grados
            while (!double.TryParse(textBox1.Text, out grados))
            {
                Console.WriteLine("Valor inválido. Por favor, ingrese un número válido:");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double grados;

            // Leer el valor en grados
            if (!double.TryParse(textBox1.Text, out grados))
            {
                MessageBox.Show("Valor inválido. Por favor, ingrese un número válido.");
                return;
            }

            // Convertir de grados a radianes
            double radianes = (grados * Math.PI) / 180;

            // Mostrar el resultado
            MessageBox.Show($"{grados} grados equivalen a {radianes} radianes.");
        }
    }
}



