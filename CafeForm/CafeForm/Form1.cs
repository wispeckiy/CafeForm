﻿using CafeForm.Classes;
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
            Balance_Label.Text = "Balance: " + cafe.GetBalance().ToString();
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
                if (rand.IndexOf(rN) == -1)
                    rand.Add(rN);
            }
        }

        private void NewRoundView()
        {
            cafe.NewClient();
            RandomNumber(3);
            Earned_Label.Text = "";
            pictureBox1.BackgroundImage = cafe.Client[cafe.Client.ManType, cafe.Client.State];
            button1.BackgroundImage = cafe.getFoodImage(rand[0]);
            button2.BackgroundImage = cafe.getFoodImage(rand[1]);
            button3.BackgroundImage = cafe.getFoodImage(rand[2]);

            button5.Visible = false;
            button5.Enabled = false;

            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }



        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Image img = cafe.GetClientWish();
            
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;

            if (b.BackgroundImage.Equals(img))
            {
                cafe.Client.StateIncrement();
                EndRound(cafe.EndClientCheck());
            }
            else
            {
                cafe.Client.StateDecrement();
                EndRound(cafe.EndClientCheck());
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
            WinLoseimg.Visible = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;

            NewRoundView();
        }
        private void EndRound(int f)
        {
            if (f == 0) return;
            Utilities.ResetEndRoundControls(this);
            int earned = 0;
            if (f == -1)
            {
                earned = -10;
                WinLoseimg.BackgroundImage = Resources.youLose;
            }
            else if (f == 1)
            {
                earned = cafe.Client.State * 10;
                WinLoseimg.BackgroundImage = Resources.youWin;
            }
            Earned_Label.Text = "Earned: " + earned.ToString();
            cafe.ChangeBalance(earned);
            Balance_Label.Text = "Balance: " + cafe.GetBalance().ToString();

            int endGameFlag = cafe.EndGameCheck();

            if (endGameFlag == 0) return;
            else EndGame(endGameFlag);
        }

        private void EndGame(int endGameFlag)
        {

            Utilities.ResetAllControls(this);

            if (endGameFlag == 1) this.BackgroundImage = Resources.youWin;
            else this.BackgroundImage = Resources.youLose;
        }






        /* private void EndGameCheck()
        {
            int flag = cafe.CheckBalance();
            if (flag== 0)
            {
                return;
            }
            else
            {
                if (flag == 1)  
            }
        }*/

        private void button5_Click(object sender, EventArgs e)
        {
            NewRound();
        }
    }
}


