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
    public partial class Form2 : Form
    {
        private int protsent = 0;
        private double summa_kredit = 0;
        private double summa_kredit2 = 0;
        public Form2()
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

        private void summa(object sender, KeyEventArgs e)
        {
            if (textBox1.Text != "")
            {
                summa_kredit = (Convert.ToDouble(textBox1.Text) / 100) * Convert.ToDouble(trackBar1.Value);
                label5.Text = summa_kredit + "";
            }
            check();
        }

        private void move2_trackbar(object sender, MouseEventArgs e)
        {
            if (textBox1.Text != "")
            {
                summa_kredit = (Convert.ToDouble(textBox1.Text) / 100) * Convert.ToDouble(trackBar1.Value);
                label5.Text = summa_kredit + "";
            }
            label4.Text = trackBar1.Value + "%";
            label7.Text = trackBar2.Value + " месяц";
            if (trackBar2.Value > 48)
            {
                protsent = 34;
                label9.Text = protsent + "%";
                summa_kredit2 = protsent * Convert.ToDouble(textBox1.Text) / 100;
                label11.Text = Convert.ToDouble(textBox1.Text) - summa_kredit - summa_kredit2 + "";
            }
            if (trackBar2.Value < 48)
            {
                protsent = 30;
                label9.Text = protsent + "%";
                summa_kredit2 = protsent * Convert.ToDouble(textBox1.Text) / 100;
                label11.Text = Convert.ToDouble(textBox1.Text) - summa_kredit - summa_kredit2 + "";
            }
            if (trackBar2.Value < 24)
            {
                protsent = 20;
                label9.Text = protsent + "%";
                summa_kredit2 = protsent * Convert.ToDouble(textBox1.Text) / 100;
                label11.Text = Convert.ToDouble(textBox1.Text) - summa_kredit - summa_kredit2 + "";
            }
            if (trackBar2.Value < 18)
            {
                protsent = 15;
                label9.Text = protsent + "%";
                summa_kredit2 = protsent * Convert.ToDouble(textBox1.Text) / 100;
                label11.Text = Convert.ToDouble(textBox1.Text) - summa_kredit - summa_kredit2 + "";
            }
            if (trackBar2.Value < 12)
            {
                protsent = 9;
                label9.Text = protsent + "%";
                summa_kredit2 = protsent * Convert.ToDouble(textBox1.Text) / 100;
                label11.Text = Convert.ToDouble(textBox1.Text) - summa_kredit - summa_kredit2 + "";
            }
            check();
        }

        private void move3_trackbar(object sender, MouseEventArgs e)
        {
            label7.Text = trackBar2.Value + " месяц";
            if (trackBar2.Value > 36)
            {
                protsent = 34;
                label9.Text = protsent + "%";
                summa_kredit2 = protsent * Convert.ToDouble(textBox1.Text) / 100;
                label11.Text = Convert.ToDouble(textBox1.Text) - summa_kredit - summa_kredit2 + "";
            }
            if (trackBar2.Value < 36)
            {
                protsent = 30;
                label9.Text = protsent + "%";
                summa_kredit2 = protsent * Convert.ToDouble(textBox1.Text) / 100;
                label11.Text = Convert.ToDouble(textBox1.Text) - summa_kredit - summa_kredit2 + "";
            }
            if (trackBar2.Value < 24)
            {
                protsent = 20;
                label9.Text = protsent + "%";
                summa_kredit2 = protsent * Convert.ToDouble(textBox1.Text) / 100;
                label11.Text = Convert.ToDouble(textBox1.Text) - summa_kredit - summa_kredit2 + "";
            }
            if (trackBar2.Value < 18)
            {
                protsent = 15;
                label9.Text = protsent + "%";
                summa_kredit2 = protsent * Convert.ToDouble(textBox1.Text) / 100;
                label11.Text = Convert.ToDouble(textBox1.Text) - summa_kredit - summa_kredit2 + "";
            }
            if (trackBar2.Value < 12)
            {
                protsent = 9;
                label9.Text = protsent + "%";
                summa_kredit2 = protsent * Convert.ToDouble(textBox1.Text) / 100;
                label11.Text = Convert.ToDouble(textBox1.Text) - summa_kredit - summa_kredit2 + "";
            }
        }
        private void check()
        {
            label7.Text = trackBar2.Value + " месяц";
            if (trackBar2.Value > 36)
            {
                protsent = 34;
                label9.Text = protsent + "%";
                summa_kredit2 = protsent * Convert.ToDouble(textBox1.Text) / 100;
                label11.Text = Convert.ToDouble(textBox1.Text) - summa_kredit - summa_kredit2 + "";
            }
            if (trackBar2.Value < 36)
            {
                protsent = 30;
                label9.Text = protsent + "%";
                summa_kredit2 = protsent * Convert.ToDouble(textBox1.Text) / 100;
                label11.Text = Convert.ToDouble(textBox1.Text) - summa_kredit - summa_kredit2 + "";
            }
            if (trackBar2.Value < 24)
            {
                protsent = 20;
                label9.Text = protsent + "%";
                summa_kredit2 = protsent * Convert.ToDouble(textBox1.Text) / 100;
                label11.Text = Convert.ToDouble(textBox1.Text) - summa_kredit - summa_kredit2 + "";
            }
            if (trackBar2.Value < 18)
            {
                protsent = 15;
                label9.Text = protsent + "%";
                summa_kredit2 = protsent * Convert.ToDouble(textBox1.Text) / 100;
                label11.Text = Convert.ToDouble(textBox1.Text) - summa_kredit - summa_kredit2 + "";
            }
            if (trackBar2.Value < 12)
            {
                protsent = 9;
                label9.Text = protsent + "%";
                summa_kredit2 = protsent * Convert.ToDouble(textBox1.Text) / 100;
                label11.Text = Convert.ToDouble(textBox1.Text) - summa_kredit - summa_kredit2 + "";
            }
        }
    }
}
