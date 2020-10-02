using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_3___2018
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("El campo se encuentra vacío.");
            }
            else
            {
                String player = textBox1.Text;
                Form2 f2 = new Form2(player);
                f2.Show();
                this.Hide();
            }
        }
    }
}