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
            pictureBox1.Visible = true;
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
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            int num = int.Parse(textBox1.Text);
            int volumen = num * num*num;
            String resultado = volumen.ToString();
            textBox4.Text = resultado;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
            int b = int.Parse(textBox1.Text);
            int altura = int.Parse(textBox2.Text);
            double area = b*altura/2.0;
            String resultado = area.ToString();
            textBox4.Text = resultado;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
            //int area_base = int.Parse(textBox3.Text);
            int altura = int.Parse(textBox2.Text);

            double volumen_tetraedro = ((Math.Sqrt(2))/12)*(altura*altura*altura);
            String resultado = volumen_tetraedro.ToString();
            textBox4.Text = resultado;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = true;
            int radio = int.Parse(textBox2.Text);
            double area = System.Math.PI * radio * radio;
            String resultado = area.ToString();
            textBox4.Text = resultado;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = true;
            int radio = int.Parse(textBox2.Text);
            double volumen_esfera = (4  * System.Math.PI * (radio * radio * radio))/3;
            String resultado = volumen_esfera.ToString();
            textBox4.Text = resultado;
        }
    }
    }
