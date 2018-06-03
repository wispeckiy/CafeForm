using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeForm.Classes
{
    class Cafe
    {
        int balance;
        CurrentClient client;
       

        public Cafe()
        {
            balance = 10;
            food = new List<string>();
            food.Add("Tea".ToUpper());
            food.Add("Coffee".ToUpper());
            food.Add("Ice cream".ToUpper());
           
        }
    }
}
