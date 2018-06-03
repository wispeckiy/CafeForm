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
            Initialize();


        }

        Random r = new Random();
        List<Int32> rand = new List<Int32>();
        private void RandomNumber(int number)
        {
            rand = new List<Int32>();
            while (rand.Count < number)
            {
                int rN = r.Next(0, number);
                if (rand.IndexOf(rN)==-1)
                    rand.Add(rN);
            }
        }

        private void Initialize() {
            client = new CurrentClient();
            //pictureBox1.BackgroundImage = 
            Cafe cafe = new Cafe();
            RandomNumber(3);
            button1.BackgroundImage = cafe.getFoodImage(rand[0]);
            button2.BackgroundImage = cafe.getFoodImage(rand[1]);
            button3.BackgroundImage = cafe.getFoodImage(rand[2]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = client[0, 0];
          
        }
    }
}
