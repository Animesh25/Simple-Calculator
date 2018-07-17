using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string key = "";
        double total;
        double ans;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            screen.Text += b.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            screen.Text = "";
            ans = 0;
            total = 0;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            key = b.Text;
            total = double.Parse(screen.Text);
            screen.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (screen.Text.Length>0)
            {
                double num=double.Parse(screen.Text);
                if (key=="+")
                {
                    ans = total + num;
                }
                if (key == "-")
                {
                    ans = total-num;
                }
                if (key == "*")
                {
                    ans = total*num;
                }
                if (key == "/")
                {
                    ans = total/num;
                }
                screen.Text = ans.ToString();
            }
        }
    }
}
