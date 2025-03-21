using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercitiul3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double op1 = 0;
        double op2 = 0;
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void txtOperatori_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isNum1 = double.TryParse(txtNumar1.Text, out op1);
            bool isNum2 = double.TryParse(txtNumar2.Text, out op2);

            if (isNum1 && isNum2)
            {
                txtRezultat.Text = (op1 + op2).ToString();
            }
            else MessageBox.Show("Insert numbers!", "Error");
        }

        private void subToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isNum1 = double.TryParse(txtNumar1.Text, out op1);
            bool isNum2 = double.TryParse(txtNumar2.Text, out op2);

            if (isNum1 && isNum2)
            {
                txtRezultat.Text = (op1 - op2).ToString();
            }
            else MessageBox.Show("Insert numbers!", "Error");

        }

        private void mulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isNum1 = double.TryParse(txtNumar1.Text, out op1);
            bool isNum2 = double.TryParse(txtNumar2.Text, out op2);

            if (isNum1 && isNum2)
            {
                txtRezultat.Text = (op1 * op2).ToString();
            }
            else MessageBox.Show("Insert numbers!", "Error");
        }

        private void divToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isNum1 = double.TryParse(txtNumar1.Text, out op1);
            bool isNum2 = double.TryParse(txtNumar2.Text, out op2);

            if (isNum1 && isNum2)
            {
                txtRezultat.Text = (op1/op2).ToString();
            }
            else MessageBox.Show("Insert numbers!", "Error");
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtRezultat.Text = " ";
            txtNumar1.Text = " ";
            txtNumar2.Text = " ";

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();

        }
    }
}