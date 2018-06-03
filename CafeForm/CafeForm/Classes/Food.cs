using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using CafeForm.Properties;

namespace CafeForm.Classes
{
    class Food
    {
        Image[] images = {  Resources.food_03, Resources.food_02, Resources.food_01};

        public Image this[int index1]
        {
            get
            {
                return images[index1];
            }

        }

        //public void AddFood
    }
}
