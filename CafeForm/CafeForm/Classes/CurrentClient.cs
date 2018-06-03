﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeForm.Classes
{
    class CurrentClient : Client
    {
        public CurrentClient()
        {
            tryCount = 3;
            Random rand = new Random();
            state = rand.Next(1, 3);
            imageGeneration();
        }

        public override void imageGeneration()
        {
            Random rand = new Random();
            manType = rand.Next(0, 6);
            myImage = images[manType, state];
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
        }

        public override void StateDecrement()
        {
            state--;
            tryCount--;
        }

        public override int Pay()
        {
            if (state == 0) return -10;
            else return state * 10;
        }
    }
}
