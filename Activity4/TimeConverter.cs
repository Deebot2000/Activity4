using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity4
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
            int inputButton = Convert.ToInt32(textBox1.Text);
            
            if (inputButton == 60)
            {
                MessageBox.Show("1 min");
            }
            else if (inputButton <= 85999)
            {
                MessageBox.Show("1 hour");
            }
            else if (inputButton >= 86000)
            {
                MessageBox.Show("1 Day");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
