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
        readonly int manType;
        bool flagWin = false;
        public CurrentClient()
        {
            tryCount = 3;
            Random rand = new Random();
            manType = rand.Next(0, 6);
            state = rand.Next(1, 3);
            myImage = images[manType, state];
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

        public override void StateIncrement()
        {
            state++;
            tryCount--;
            myImage = images[manType, state];
        }

        public override void StateDecrement()
        {
            state--;
            tryCount--;
            myImage = images[manType, state];
        }

        public override int Pay()
        {
            if (state == 0) return -10;
            else return state * 10;
        }

        
    }
}
