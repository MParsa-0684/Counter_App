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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
 
        }
        public void setNewStarterNumber(int newStarterNumber)
        {
            this.label1.Text = Convert.ToString(newStarterNumber);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(label1.Text);
            number++;
            label1.Text = Convert.ToString(number);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void giveStarterNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int starterNumber = Convert.ToInt32(label1.Text);
            Form2 form2 = new Form2();
            form2.setStarterNumber(starterNumber);
            form2.Show();
            Hide();
        }

        private void a(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
    
}
