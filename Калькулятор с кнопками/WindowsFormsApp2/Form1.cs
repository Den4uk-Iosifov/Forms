﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double  a = Convert.ToSingle(textBox1.Text);
            double b = Convert.ToSingle(textBox2.Text);
            double c = a + b;
            textBox3.Text = Convert.ToString(c);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
