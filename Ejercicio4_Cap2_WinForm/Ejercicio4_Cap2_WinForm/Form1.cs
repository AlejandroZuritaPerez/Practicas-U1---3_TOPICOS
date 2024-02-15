using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4_Cap2_WinForm
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
            double celsius;

            // Leer la temperatura en grados Celsius
            while (!double.TryParse(textBox1.Text, out celsius))
            {
                Console.WriteLine("Valor inválido. Por favor, ingrese un número válido:");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double celsius;

            if (!double.TryParse(textBox1.Text, out celsius))
            {
                MessageBox.Show("Valor inválido. Por favor, ingrese un número válido.");
                return;
            }

            // Convertir de Celsius a Fahrenheit
            double fahrenheit = (celsius * 9 / 5) + 32;

            // Mostrar el resultado
            MessageBox.Show($"{celsius} grados Celsius equivalen a {fahrenheit} grados Fahrenheit.");

        }
    }
}
