using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercitiul4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }





        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string msg = string.Empty;
            foreach (RadioButton radioButton in groupBox1.Controls)
            {
                if (radioButton.Checked == true)
                {
                    msg = radioButton.Text; ;
                }
            }
            foreach (RadioButton radioButton in groupBox2.Controls)
            {
                if (radioButton.Checked == true)
                {
                    msg = msg + " with " + radioButton.Text;
                }
            }
            MessageBox.Show("You have chosen pizza " + msg + " sauce!", "Selection");
        }

        private void lstCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            String op = lstCities.SelectedItem.ToString();
            switch (op)
            {
                case "Londra": PictureBox1.Image = Image.FromFile("Londra.jpg");
                    break;

                case "Cluj-Napoca": PictureBox1.Image = Image.FromFile("CJ.jpg");
                    break;

                case "Paris": PictureBox1.Image = Image.FromFile("Paris.jpg");
                    break;



            }
        }
    }
}
        
    

       