using CafeForm.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeForm.Classes
{
    abstract class Client : IClient
    {
        protected int tryCount;
        protected int state;
       

        protected Image myImage = Resources.ClearImage;
        protected Image[,] images = {
            { Resources.Boy_02,Resources.Boy_04,Resources.Boy_03,Resources.Boy_01},
            { Resources.Girl_02,Resources.Girl_04,Resources.Girl_03,Resources.Girl_01 },
            { Resources.Man_02,Resources.Man_04,Resources.Man_03,Resources.Man_01 },
            { Resources.Woman_02,Resources.Woman_04,Resources.Woman_03,Resources.Woman_01 },
            { Resources.Grandfather_02,Resources.Grandfather_04,Resources.Grandfather_03,Resources.Grandfather_01},
            { Resources.GrandMather_02,Resources.GrandMather_04,Resources.GrandMather_03,Resources.GrandMather_01 }
        };

        public Image this[int index1, int index2]
        {
            get
            {
                return images[index1, index2];
            }
           
        }
        

        public Client()
        {
           // Console.WriteLine("ntt");
        }

        public int RandomWish(int n)
        {
            return new Random().Next(0, n);
        }

        public abstract int Pay();

        public abstract bool StateIncrement();

        public abstract bool StateDecrement();
    }
}
