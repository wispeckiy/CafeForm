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
        CurrentClient client;
        Food food;

        public Cafe()
        {
            balance = 10;
            food = new Classes.Food();

        }

        public Image getFoodImage(int i) {
            return food[i];
        }

        //public List<Image> getFoodImages()
        //{
        //    List<Image> list= new List<Image>();
        //    for (int i = 0; i < food)
        //        list.Add(im);
        //    return list;
        //}
    }
}
