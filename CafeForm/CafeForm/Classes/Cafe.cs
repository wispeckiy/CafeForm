using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace CafeForm.Classes
{
    class Cafe
    {
        int balance;
        public CurrentClient Client { get; set; }
        Food food;

        public Cafe()
        {
            balance = 10;
            food = new Classes.Food();
         //   Client = new CurrentClient();
        }

        public void ChangeBalance(int value)
        {
            balance += value;
        }

        public int GetBalance() { return balance; }

        public Image getFoodImage(int i) {
            return food[i];
        }

        public void NewClient()
        {
            Client = new CurrentClient();
        }

        //public List<Image> getFoodImages()
        //{
        //    List<Image> list= new List<Image>();
        //    for (int i = 0; i < food)
        //        list.Add(im);
        //    return list;
        //}

        public Image GetClientWish()
        {
            return food[Client.RandomWish(food.GetLenght())];
        }
        
        public int CheckBalance()
        {
            if (balance >= 0 && balance < 100) return 0;
            else if (balance >= 100) return 1;
            else return -1;
        }

        public int EndClientCheck()  // -1 - програш, 0 - продовження гри, 1 - виграш
        {
            if (Client.TryCount == 0)
            {
                if (Client.State == 0) return -1;
                else return 1;
            }
            if (Client.State == 0) return -1;
            if (Client.State == 3) return 1;
            return 0;
        }

        public int EndGameCheck()
        {
            if (balance >= 100) return 1;
            else if (balance < 0) return -1;
            else return 0;
        }
    }
}
