using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counter___شمارنده
{
    public partial class Form2 : Form
    {
        public void setStarterNumber(int starterNumber)
        {
            label2.Text = Convert.ToString(starterNumber);
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void LastNumber(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBox1.Text);
            Form1 form1 = new Form1();
            form1.setNewStarterNumber(number);
            form1.Show();
            Hide();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
