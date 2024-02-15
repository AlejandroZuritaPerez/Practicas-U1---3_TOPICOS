using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejecicios1_Cap2_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int Lados;


            // Leer el número de lados del polígono
            while (!int.TryParse(textBox1.Text, out Lados) || Lados < 3)
            {
                Console.WriteLine("Número de lados inválido. Debe ser un número entero mayor o igual a 3.");
                Console.WriteLine("Ingrese el número de lados del polígono regular:");
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double longitudLado;


            // Leer la longitud de un lado del polígono
            while (!double.TryParse(textBox2.Text, out longitudLado) || longitudLado <= 0)
            {
                Console.WriteLine("Longitud de lado inválida. Debe ser un número positivo.");
                Console.WriteLine("Ingrese la longitud de un lado del polígono regular:");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int lados;
            double longitudLado;

            // Leer el número de lados del polígono
            if (!int.TryParse(textBox1.Text, out lados) || lados < 3)
            {
                MessageBox.Show("Número de lados inválido. Debe ser un número entero mayor o igual a 3.");
                return;
            }

            // Leer la longitud de un lado del polígono
            if (!double.TryParse(textBox2.Text, out longitudLado) || longitudLado <= 0)
            {
                MessageBox.Show("Longitud de lado inválida. Debe ser un número positivo.");
                return;
            }

            // Calcular el perímetro del polígono regular
            double perimetro = lados * longitudLado;

            // Mostrar el resultado
            MessageBox.Show($"El perímetro del polígono regular con {lados} lados y longitud de lado {longitudLado} es: {perimetro}");


        }
    }
}
