using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tauxChange
{
    public partial class Form1 : Form
    {
        string valeur1;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }
        private void button_Click(object sender, EventArgs e)
        {
            label1.Text += ((Button)sender).Text;
            valeur1 = label1.Text;
        }
        List<Button> listBouton = new List<Button>();

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = " ";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
            float x = (float.Parse(valeur1)) * 1.10f; 
               label1.Text = x.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            float y = float.Parse(valeur1) * 0.86f;
                      label1.Text = y.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label1.Text = valeur1;
        }
    }
}