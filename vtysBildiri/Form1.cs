﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vtysBildiri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kurumlar_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            f2.Show();
        }
        private void katilimcilar_Click(object sender, EventArgs e)
        {
            Form f3 = new Form3();
            f3.Show();
        }
        private void salonlar_Click(object sender, EventArgs e)
        {
            Form f4 = new Form4();
            f4.Show();
        }
        private void bildiriler_Click(object sender, EventArgs e)
        {
            Form f5 = new Form5();
            f5.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f6 = new Form6();
            f6.Show();

        }
    }
}
