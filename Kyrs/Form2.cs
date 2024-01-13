using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Kyrs
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            cursapple.Enabled = true;
            curstesla.Enabled = true;
            cursmicrosoft.Enabled = true;
            cursdollar.Enabled = true;
            curseuro.Enabled = true;
            ac11.Text = "0";
            ac22.Text = "0";
            ac33.Text = "0";
        }

        private void Exit1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exit1_MouseLeave(object sender, EventArgs e)
        {
            Exit1.ForeColor = Color.White;
        }
        Point lastPoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void cursapple_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (valuta1.Text == "Гривні")
            {
                int a = rnd.Next(2500, 3600);
                rist1.Text = a.ToString();
            }
            else if (valuta1.Text == "Євро")
            {
                int a = rnd.Next(80, 100);
                rist1.Text = a.ToString();
            }
            else if (valuta1.Text == "Долари")
            {
                int a = rnd.Next(100, 120);
                rist1.Text = a.ToString();
            }
            else
            {
                rist1.Text = "Немає валюти";
            }
            cursapple.Interval = 1000;
        }

        private void Exit1_MouseEnter(object sender, EventArgs e)
        {
            Exit1.ForeColor = Color.Red;
        }

        private void curstesla_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (valuta2.Text == "Гривні")
            {
                int a = rnd.Next(14000, 15000);
                rist2.Text = a.ToString();
            }
            else if (valuta2.Text == "Євро")
            {
                int a = rnd.Next(360, 400);
                rist2.Text = a.ToString();
            }
            else if (valuta2.Text == "Долари")
            {
                int a = rnd.Next(450, 500);
                rist2.Text = a.ToString();
            }
            else
            {
                rist2.Text = "Немає валюти";
            }
            curstesla.Interval = 1000;
        }

        private void cursmicrosoft_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (valuta3.Text == "Гривні")
            {
                int a = rnd.Next(5500, 6500);
                rist3.Text = a.ToString();
            }
            else if (valuta3.Text == "Євро")
            {
                int a = rnd.Next(160, 220);
                rist3.Text = a.ToString();
            }
            else if (valuta3.Text == "Долари")
            {
                int a = rnd.Next(180, 240);
                rist3.Text = a.ToString();
            }
            else
            {
                rist3.Text = "Немає валюти";
            }
            cursmicrosoft.Interval = 1000;
        }

        private void cursdollar_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int a = rnd.Next(26, 29);
            dollarcup.Text = a.ToString();
            int b = rnd.Next(27, 30);
            dollarprod.Text = b.ToString();
            cursdollar.Interval = 1000;
        }

        private void curseuro_Tick(object sender, EventArgs e)
        {
            Random rn = new Random();
            int a1 = rn.Next(31, 35);
            eurocup.Text = a1.ToString();
            int b1 = rn.Next(32, 36);
            europrod.Text = b1.ToString();
            curseuro.Interval = 1000;
        }

        private void Converted_Click(object sender, EventArgs e)
        {
            double M = double.Parse(money1.Text);
            double a1 = double.Parse(dollarcup.Text);
            double a2 = double.Parse(dollarprod.Text);
            double b1 = double.Parse(eurocup.Text);
            double b2 = double.Parse(europrod.Text);
            double c1 = double.Parse(grivna1.Text);
            double c2 = double.Parse(euro1.Text);
            double c3 = double.Parse(dollar1.Text);
            double d,D;
            double R;
            if(z.Text == "Гривні" && v.Text == "Євро")
            {
                R = M / b2;
                plusmoney.Text = "Ви отримали - " + Math.Round(R,2) + " Євро";
                d = c2 + R;
                euro1.Text = Math.Round(d,2).ToString();
                D = c1 - M;
                grivna1.Text = Math.Round(D,2).ToString();
            }
            else if (z.Text == "Гривні" && v.Text == "Долари")
            {
                R = M / a2;
                plusmoney.Text = "Ви отримали - " + Math.Round(R, 2) + " Доларів";
                d = c3 + R;
                dollar1.Text = Math.Round(d, 2).ToString();
                D = c1 - M;
                grivna1.Text = Math.Round(D, 2).ToString();
            }
            else if (z.Text == "Долари" && v.Text == "Гривні")
            {
                R = M * a2;
                plusmoney.Text = "Ви отримали - " + Math.Round(R, 2) + " Гривень";
                d = c1 + R;
                grivna1.Text = Math.Round(d, 2).ToString();
                D = c3 - M;
                dollar1.Text = Math.Round(D, 2).ToString();
            }
            else if (z.Text == "Євро" && v.Text == "Гривні")
            {
                R = M * b2;
                plusmoney.Text = "Ви отримали - " + Math.Round(R, 2) + " Євро";
                d = c2 + R;
                grivna1.Text = Math.Round(d, 2).ToString();
                D = c1 - M;
                euro1.Text = Math.Round(D, 2).ToString();
            }
            else if (z.Text == "Долари" && v.Text == "Євро")
            {
                R = M * a2 / b2;
                plusmoney.Text = "Ви отримали - " + Math.Round(R, 2) + " Євро";
                d = c2 + R;
                euro1.Text = Math.Round(d, 2).ToString();
                D = c3 - M;
                dollar1.Text = Math.Round(D, 2).ToString();
            }
            else if (z.Text == "Євро" && v.Text == "Долари")
            {
                R = M * b2 / a2;
                plusmoney.Text = "Ви отримали - " + Math.Round(R, 2) + " Доларів";
                d = c3 + R;
                dollar1.Text = Math.Round(d, 2).ToString();
                D = c2 - M;
                euro1.Text = Math.Round(D, 2).ToString();
            }
            else
            {
                plusmoney.Text = "Помилка!";
            }
        }

        private void buy1_Click(object sender, EventArgs e)
        {
            double c1 = double.Parse(grivna1.Text);
            double c2 = double.Parse(euro1.Text);
            double c3 = double.Parse(dollar1.Text);
            double cup = double.Parse(cup1.Text);
            double prod = double.Parse(prod1.Text);
            double rist = double.Parse(rist1.Text);
            double M,D,H,P;
            double c11 = double.Parse(ac11.Text);
            if (valuta1.Text == "Гривні")
            {
                M = (cup * rist) - (prod * rist);
                D = c1 - M;
                grivna1.Text = Math.Round(D, 2).ToString();
                H = cup - prod;
                P = c11 + H;
                ac11.Text = Math.Round(P, 2).ToString();
            }
            else if (valuta1.Text == "Євро")
            {
                M = (cup * rist) - (prod * rist);
                D = c2 - M;
                euro1.Text = Math.Round(D, 2).ToString();
                H = cup - prod;
                P = c11 + H;
                ac11.Text = Math.Round(P, 2).ToString();
            }
            else if (valuta1.Text == "Долари")
            {
                M = (cup * rist) - (prod * rist);
                D = c3 - M;
                dollar1.Text = Math.Round(D, 2).ToString();
                H = cup - prod;
                P = c11 + H;
                ac11.Text = Math.Round(P, 2).ToString();
            }
            else
                ac1.Text = "Помилка!";
        }

        private void buy2_Click(object sender, EventArgs e)
        {
            double c1 = double.Parse(grivna1.Text);
            double c2 = double.Parse(euro1.Text);
            double c3 = double.Parse(dollar1.Text);
            double cup = double.Parse(cup2.Text);
            double prod = double.Parse(prod2.Text);
            double rist = double.Parse(rist2.Text);
            double M, D, H, P;
            double c22 = double.Parse(ac22.Text);
            if (valuta2.Text == "Гривні")
            {
                M = (cup * rist) - (prod * rist);
                D = c1 - M;
                grivna1.Text = Math.Round(D, 2).ToString();
                H = cup - prod;
                P = c22 + H;
                ac22.Text = Math.Round(P, 2).ToString();
            }
            else if (valuta2.Text == "Євро")
            {
                M = (cup * rist) - (prod * rist);
                D = c2 - M;
                euro1.Text = Math.Round(D, 2).ToString();
                H = cup - prod;
                P = c22 + H;
                ac22.Text = Math.Round(P, 2).ToString();
            }
            else if (valuta2.Text == "Долари")
            {
                M = (cup * rist) - (prod * rist);
                D = c3 - M;
                dollar1.Text = Math.Round(D, 2).ToString();
                H = cup - prod;
                P = c22 + H;
                ac22.Text = Math.Round(P, 2).ToString();
            }
            else
                ac2.Text = "Помилка!";
        }

        private void buy3_Click(object sender, EventArgs e)
        {
            double c1 = double.Parse(grivna1.Text);
            double c2 = double.Parse(euro1.Text);
            double c3 = double.Parse(dollar1.Text);
            double cup = double.Parse(cup3.Text);
            double prod = double.Parse(prod3.Text);
            double rist = double.Parse(rist3.Text);
            double M, D, H, P;
            double c33 = double.Parse(ac33.Text);
            if (valuta3.Text == "Гривні")
            {
                M = (cup * rist) - (prod * rist);
                D = c1 - M;
                grivna1.Text = Math.Round(D, 2).ToString();
                H = cup - prod;
                P = c33 + H;
                ac33.Text = Math.Round(P, 2).ToString();
            }
            else if (valuta3.Text == "Євро")
            {
                M = (cup * rist) - (prod * rist);
                D = c2 - M;
                euro1.Text = Math.Round(D, 2).ToString();
                H = cup - prod;
                P = c33 + H;
                ac33.Text = Math.Round(P, 2).ToString();
            }
            else if (valuta3.Text == "Долари")
            {
                M = (cup * rist) - (prod * rist);
                D = c3 - M;
                dollar1.Text = Math.Round(D, 2).ToString();
                H = cup - prod;
                P = c33 + H;
                ac33.Text = Math.Round(P, 2).ToString();
            }
            else
                ac3.Text = "Помилка!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.DefaultExt = ".txt";
            saveFileDialog1.Filter = "Test files|*.txt";
            string a = ac11.Text;
            string b = ac22.Text;
            string c = ac33.Text;
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFileDialog1.FileName.Length > 0)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, true))
                {
                    sw.WriteLine("Name - " + name1.Text);
                    sw.WriteLine("Гривні - " + grivna1.Text);
                    sw.WriteLine("Євро - " + euro1.Text);
                    sw.WriteLine("Долари - " + dollar1.Text);
                    sw.WriteLine("Кількість акцій Apple - " + a);
                    sw.WriteLine("Кількість акцій Tesla - " + b);
                    sw.WriteLine("Кількість акцій Microsoft - " + c);
                    sw.Close();
                }
            }
        }
    }
}
