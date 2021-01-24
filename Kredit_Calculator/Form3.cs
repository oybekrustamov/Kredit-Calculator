using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kredit_Calculator
{
    public partial class Form3 : Form
    {
        double summa = 0;
        double protsent = 0;
        double summa2 = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Visible = true;
            Visible = false;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 36; i++) dataGridView1.Rows.Clear();
            summa = Convert.ToDouble(textBox1.Text);
            double chislo = summa;
            summa2 = chislo/Convert.ToDouble(trackBar1.Value);
            protsent = Convert.ToDouble(trackBar2.Value)/100;
            double[] summa3 = new double[Convert.ToInt32(trackBar1.Value+1)];
            for (int i = 1; i <= Convert.ToInt32(trackBar1.Value); i++)
            {
                summa3[i] = summa2 + (summa - summa2 * i) * (protsent / 12);
            }
            int count = 0;
            for (int i = 1; i <= Convert.ToInt32(trackBar1.Value); i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[count].Cells[0].Value = i;
                dataGridView1.Rows[count].Cells[1].Value = Math.Round(summa3[i], 3);
                count++;
            }

            double fin_summa = 0;
            for (int i = 0; i < Convert.ToInt32(trackBar1.Value); i++)
            {
                fin_summa+=summa3[i];
            }
            label8.Text = Convert.ToString(Math.Round(fin_summa,3));
        }

        private void Godovoy_trackbar_move(object sender, MouseEventArgs e)
        {
            label6.Text = Convert.ToString(trackBar2.Value)+"%";
        }

        private void srok_pogash_trackbar_move(object sender, MouseEventArgs e)
        {
            label4.Text = Convert.ToString(trackBar1.Value) + " месяцев";
        }
    }
}
