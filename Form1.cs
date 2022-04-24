using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4_S_A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ToAddForm moder = new ToAddForm();
            moder.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ToRedForm moder = new ToRedForm();
            moder.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ToViewers klient = new ToViewers();
            klient.Show();
            this.Hide();
        }
    }
}
