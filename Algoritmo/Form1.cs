using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Somente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);
            bool apenasPositivos = checkBox1.Checked;
            dataGridView1.Rows.Clear();

            // dataGridView1.Rows.Add(a, a);
            Euclides(a, b);


            if (apenasPositivos)
            {
                
            }
            else
            {

            }
        }

        private void Euclides(int a, int b)
        {

            int dividendo, divisor, resto, quociente;
            int mdc;

            dividendo = a;
            divisor = b;
            quociente = dividendo / divisor;
            resto = dividendo % divisor;

            while (resto > 0)
            {
                dividendo = divisor;
                divisor = resto;
                quociente = dividendo / divisor;
                resto = dividendo % divisor;

            }

            mdc = divisor;


        }
    }
}
