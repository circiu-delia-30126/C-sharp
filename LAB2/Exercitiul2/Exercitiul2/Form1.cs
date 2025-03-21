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

namespace Exercitiul2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("fisier2.txt");

            string line;
            while ((line = sr.ReadLine()) != null)
            {
                listBox1.Items.Add(line);
            }
            sr.Close();

            listBox1.SelectionMode = SelectionMode.MultiSimple;

        }

        
        private void btnCopiaza_Click(object sender, EventArgs e)
            {
                for (int i = 0; i < listBox1.Items.Count; i++) {
                    if (listBox1.GetSelected(i) == true) {
                        listBox2.Items.Add(listBox1.Items[i].ToString());
                    }
                }
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    listBox1.SetSelected(i, false);
                }
            }
        }
    }
