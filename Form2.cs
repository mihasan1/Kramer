using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KramerVisual
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[,] arr = new double[3,3];// Массив матрицы
            double[] b = new double[3]; // массив правой части СЛАУ
            //заполнение массива матрицы
            arr[0, 0] = Convert.ToDouble(textBox1.Text);
            arr[0, 1] = Convert.ToDouble(textBox2.Text);
            arr[0, 2] = Convert.ToDouble(textBox3.Text);
            arr[1, 0] = Convert.ToDouble(textBox4.Text);
            arr[1, 1] = Convert.ToDouble(textBox5.Text);
            arr[1, 2] = Convert.ToDouble(textBox6.Text);
            arr[2, 0] = Convert.ToDouble(textBox7.Text);
            arr[2, 1] = Convert.ToDouble(textBox8.Text);
            arr[2, 2] = Convert.ToDouble(textBox9.Text);
            //заполнение массива правой части СЛАУ
            b[0]=Convert.ToDouble(textBox10.Text);
            b[1]=Convert.ToDouble(textBox11.Text);
            b[2]=Convert.ToDouble(textBox12.Text);
            //иницализация класса, передача размеров и массивов в класс
            Class1 Kramer = new Class1(3,arr,b);
            if (Kramer.SLAU_kramer() == 1) // если == 1 то СЛАР не решается
                MessageBox.Show("Помилка! Визначник дорівнює 0!");
            else // в другом случае выводится результат
                label3.Visible = true;
                richTextBox1.Visible = true;
                richTextBox1.Text = "X1=" + Kramer.solve[0] + "\nX2=" + Kramer.solve[1] + "\nX3=" + Kramer.solve[2];
           
        }
    }
}
