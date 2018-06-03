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

        
        Cafe cafe;
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
            cafe = new Cafe();
            pictureBox1.BackgroundImage = cafe.Client.MyImage;
            RandomNumber(3);
            pictureBox1.BackgroundImage = cafe.Client[r.Next(0,6), r.Next(1,3)];
            button1.BackgroundImage = cafe.getFoodImage(rand[0]);
            button2.BackgroundImage = cafe.getFoodImage(rand[1]);
            button3.BackgroundImage = cafe.getFoodImage(rand[2]);
        }



        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Image img = cafe.GetClientWish();
            if (b.BackgroundImage.Equals(img))
            {
                if(cafe.Client.StateIncrement());
            }
            else
            {
                if(cafe.Client.StateDecrement());
            }
            ChangeLabels(b, img);
        }
        
        private void ChangeLabels(Button b, Image img)
        {

            pictureBox1.BackgroundImage = cafe.Client.MyImage;
            pictureBox2.BackgroundImage = img;
            pictureBox3.BackgroundImage = b.BackgroundImage;
        }
    }
}
