﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercitiul1
{
    public partial class Form2 : Form
    {
        public Form2(string text)
        {
            InitializeComponent();= "Hello " + text + "!";
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                this.Close();
        }
    }
}
