using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Clear();
        }

        private void button15_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                string calculation = textBox1.Text;
                DataTable dt = new DataTable();
                double result = Convert.ToDouble(dt.Compute(calculation, ""));
                textBox1.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
