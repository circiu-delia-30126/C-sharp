using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercitiul1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


       

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader(path: "detalii.txt");

            String username = streamReader.ReadLine();
            String password = streamReader.ReadLine();
 

            if ((txtUsername.Text == username) && (txtPassword.Text == password))
            {
                Form2 secondForm = new Form2();
                secondForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid Text");
            }


        }
    }
}
