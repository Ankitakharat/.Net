using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.button1.Click += button1_Click;
            this.button2.Click += button2_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button 1 is clicked");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button 2 is clicked");
        }
    }
}
