using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CafeForm.Classes
{
    class CurrentClient : Client
    {
        public CurrentClient()
        {
            tryCount = 3;
            Random rand = new Random();
            state = rand.Next(1, 3);
            myImage = imageGeneration();
        }

        public Image imageGeneration()
        {
            Random rand = new Random();
            manType = rand.Next(0, 6);
            myImage = images[manType, state];
            return myImage;
        }

        public Image MyImage
        {
            get { return myImage; }
            set { myImage = value; }
        }

        public int ManType
        {
            get { return manType; }
        }

        public int State
        {
            get { return state; }
        }

        public int TryCount
        {
            get { return tryCount; }
        }

        public override bool StateIncrement()
        {
            if (state > 3 || tryCount <= 0) return false;
            state++;
            tryCount--;
            myImage = images[manType, state];
            return true;
        }

        public override bool StateDecrement()
        {
            if (state <= 0 || tryCount <= 0) return false;
            state--;
            tryCount--;
            myImage = images[manType, state];
            return true;
        }

        public override int Pay()
        {
            if (state == 0) return -10;
            else return state * 10;
        }
    }
}
