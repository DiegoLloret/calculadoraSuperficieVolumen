using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraSuperficieVolumen
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            int area = num * num;
            String resultado = area.ToString();
            textBox4.Text = resultado;
                
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            int volumen = num^3;
            String resultado = volumen.ToString();
            textBox4.Text = resultado;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            int b = int.Parse(textBox1.Text);
            int altura = int.Parse(textBox2.Text);
            int area =  (b*altura)/2;
            String resultado = area.ToString();
            textBox4.Text = resultado;
        }
    }
}
