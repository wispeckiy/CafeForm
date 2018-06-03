using CafeForm.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CafeForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CurrentClient client;
        private void Form1_Load(object sender, EventArgs e)
        {
            //Console.Title = "CAFE";
            //Cafe start = new Cafe();
          client = new CurrentClient();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = client[0, 0];
        }
    }
}
