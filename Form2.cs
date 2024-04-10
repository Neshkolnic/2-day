using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_day
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] P1 = { 4, 3 }; // Левый нижний угол R1
            double[] P2 = { 7, 6 }; // Правый верхний угол R1
            double[] P3 = { 5, 3 }; // Левый нижний угол R2
            double[] P4 = { 7, 5 }; // Правый верхний угол R2

            // Проверяем пересекаются ли прямоугольники
            if (Intersects(P1, P2, P3, P4))
            {
                // Находим координаты P5 и P6
                double[] P5 = { Math.Max(P1[0], P3[0]), Math.Max(P1[1], P3[1]) }; // Верхний правый угол пересечения
                double[] P6 = { Math.Min(P2[0], P4[0]), Math.Min(P2[1], P4[1]) }; // Нижний левый угол пересечения

                string result = $"Прямоугольники пересекаются.\r\nКоординаты P5: ({P5[0]}, {P5[1]})\r\nКоординаты P6: ({P6[0]}, {P6[1]})";

                // Выводим результат в TextBox
                textBox9.Text = result;
            }
            else
            { textBox9.Text = "Не пересекаются прямоугольники"; }

          
        }
        static bool Intersects(double[] P1, double[] P2, double[] P3, double[] P4)
        {
            // Проверяем, не пересекаются ли прямоугольники по осям x или y
            if (P1[0] > P4[0] || P3[0] > P2[0] || P1[1] > P4[1] || P3[1] > P2[1])
                return false;
            else
                return true;
        }
    }
}
