using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cosinne
{
    public partial class Form1 : Form
    {
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tx1 = textBox1.Text;
            string tx2 = textBox2.Text;
            string tx3 = dateTimePicker1.Text;

            if(tx1.Length == 0 || tx2.Length == 0)
            {
                MessageBox.Show("Nie podano wszystkich danych.");
            }
            else { MessageBox.Show("Podane imie: " + tx1 +", "+ "nazwisko: " + tx2 + ", " + "data urodzenia: " + tx3); }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
