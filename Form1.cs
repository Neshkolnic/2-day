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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            try { 
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);

            label4.Text = NOD(a, b).ToString();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            
            }
        }

        // По условию нельзя использовать умножение и деление, поэтому алгоритм такой
        private int NOD(int a, int b)
        {
            int nod = 1;
            for (int i = 1; i < a; i++)
            {
                if ((a % i == 0) && (b % i == 0))
                { 
                nod = i;
                }
            
            }

            return nod;
        }

        private void заданиеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void заданиеToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.ShowDialog();
        }
    }
}
