using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace terceiro_designer
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }




        int Nota1;
        int Nota2;
        int Nota3;

        double resultado;

        private void button1_Click(object sender, EventArgs e)
        {
            resultado = (Nota1 + Nota2 + Nota3) / 3;
            box_resultado.Text = resultado.ToString("f2");

            if (resultado < 7)
                aprovacao.Text = "REPROVADO";

            else
                aprovacao.Text = "APROVADO";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Nota1 = int.Parse(textBox1.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Nota2 = int.Parse(textBox4.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Nota3 = int.Parse(textBox3.Text);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void box_resultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void aprovacao_Click(object sender, EventArgs e)
        {

        }
    }
}
