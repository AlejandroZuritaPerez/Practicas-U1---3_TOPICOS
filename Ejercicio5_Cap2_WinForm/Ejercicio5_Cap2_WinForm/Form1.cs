using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5_Cap2_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double cantidad;

            // Leer la cantidad de dinero
            while (!double.TryParse(textBox1.Text, out cantidad) || cantidad <= 0)
            {
               MessageBox.Show("Cantidad inválida. Por favor, ingrese un número válido:");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double tipoCambio;

            // Leer el tipo de cambio
            while (!double.TryParse(textBox2.Text, out tipoCambio) || tipoCambio <= 0)
            {
                MessageBox.Show("Tipo de cambio inválido. Por favor, ingrese un número válido:");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double cantidad;
            double tipoCambio;

            if (!double.TryParse(textBox1.Text, out cantidad))
            {
                MessageBox.Show("Valor inválido. Por favor, ingrese un número válido.");
                return;
            }

            if (!double.TryParse(textBox2.Text, out tipoCambio))
            {
                MessageBox.Show("Valor inválido. Por favor, ingrese un número válido.");
                return;
            }

            // Realizar la conversión
            double resultado = cantidad * tipoCambio;

            // Mostrar el resultado
            MessageBox.Show($"{cantidad} dólares equivalen a {resultado} euros.");
        }
    }
}
