﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Actbtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void Ctgbtn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void Drcbtn_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void Mvsbtn_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }
    }
}
