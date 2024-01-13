using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kyrs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Exit1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Page = new Form2();
            if (name.Text == "")
                name.Text = "Nick";
            if (grivna.Text == "")
                grivna.Text = "0";
            if (euro.Text == "")
                euro.Text = "0";
            if (dollar.Text == "")
                dollar.Text = "0";
            Page.name1.Text = this.name.Text;
            Page.grivna1.Text = this.grivna.Text;
            Page.euro1.Text = this.euro.Text;
            Page.dollar1.Text = this.dollar.Text;
            this.Hide();
            Page.Show();
        }

        private void Exit1_MouseLeave(object sender, EventArgs e)
        {
            Exit1.ForeColor = Color.White;
        }
        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
             lastPoint = new Point(e.X, e.Y);
        }

        private void Exit1_MouseEnter(object sender, EventArgs e)
        {
            Exit1.ForeColor = Color.Red;
        }
    }
}
