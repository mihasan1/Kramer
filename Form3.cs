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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            double[,] arr = new double[2,2];//массив матрицы
            double[] b = new double[2];//массив правой части СЛАР
            // заполнение массивов
            arr[0, 0] = Convert.ToDouble(textBox1.Text);
            arr[0, 1] = Convert.ToDouble(textBox2.Text);
            arr[1, 0] = Convert.ToDouble(textBox3.Text);
            arr[1, 1] = Convert.ToDouble(textBox4.Text);

            b[0] = Convert.ToDouble(textBox10.Text);
            b[1] = Convert.ToDouble(textBox11.Text);

            Class1 Kramer = new Class1(2, arr, b); // Инициализация класса, передача размера и массивов в класс
            if (Kramer.SLAU_kramer() == 1) // Проверка на решаемость. Если == 1 то ошибка
                MessageBox.Show("Помилка! Визначник дорівнює 0!");
            else // в другом случае вывод результатов
                label3.Visible = true;
            richTextBox1.Visible = true;
            richTextBox1.Text = "X1=" + Kramer.solve[0] + "\nX2=" + Kramer.solve[1]; // Вывод результатов
        }
    }
}
