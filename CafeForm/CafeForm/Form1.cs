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
using CafeForm.Properties;

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
            cafe = new Cafe();  
            NewRoundView();


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

        private void NewRoundView() {
              cafe.NewClient();
            RandomNumber(3);
            pictureBox1.BackgroundImage = cafe.Client[cafe.Client.ManType, cafe.Client.State];
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
                if(!cafe.Client.StateIncrement())
                {
                    EndRound(cafe.Client.Winner());
                }
            
            }
            else
            {
                if(!cafe.Client.StateDecrement())
                    EndRound(cafe.Client.Winner());
            }
            ChangeLabels(b, img);
        }
        
        private void ChangeLabels(Button b, Image img)
        {
            pictureBox1.BackgroundImage = cafe.Client.MyImage;
            pictureBox2.BackgroundImage = img;
            pictureBox3.BackgroundImage = b.BackgroundImage;

        }

        private void NewRound()
        {
            button5.Enabled = false;
            WinLoseimg.Visible = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            NewRoundView();
        }
        private void EndRound(bool f)
        {
            button5.Enabled = true;
            WinLoseimg.Visible = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            if (f)
                WinLoseimg.BackgroundImage = Resources.youWin;
            else
                WinLoseimg.BackgroundImage = Resources.youLose;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            NewRound();
        }
    }


}
