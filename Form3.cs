using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _2_day
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("ColumnX", "X");
            dataGridView1.Columns.Add("ColumnF", "F");
        }
        private double CalculateFunction(int a, int b, int c, double x)
        {
            double result;

            // Ваша реализация расчета функции
            if (c < 0 && x != 0)
            {
                result = -a * x - c;
            }
            else if (c > 0 && x == 0)
            {
                result = (x - a) / -c;
            }
            else
            {
                result = (b * x) / (c - a);
            }

            // Новое условие для возвращения действительного или целого значения
            // Вычисляем целые части a, b, c
            int intA = (int)a;
            int intB = (int)b;
            int intC = (int)c;

            // Проверяем наличие ненулевых битов в целых частях a, b, c
            if ((intA | intB | intC) != 0)
            {
                // Если хотя бы один из битов ненулевой, возвращаем действительное значение
                return result;
            }
            else
            {
                // Иначе, возвращаем целое значение
                return (int)result;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
             try
            {
                double xStart = double.Parse(textBox1.Text);
                double xEnd = double.Parse(textBox2.Text);
                double step = double.Parse(textBox3.Text);
                int a = int.Parse(textBox4.Text);
                int b = int.Parse(textBox5.Text);
                int c = int.Parse(textBox6.Text);

                // Очищаем DataGridView перед добавлением новых данных
                dataGridView1.Rows.Clear();

                // Вычисляем и выводим значения функции F на интервале от Xнач. до Xкон. с шагом dX
                for (double x = xStart; x <= xEnd; x += step)
                {
                    double result = CalculateFunction(a, b, c, x);
                    dataGridView1.Rows.Add(x, result);
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
