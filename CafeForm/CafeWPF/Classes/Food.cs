using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using CafeWPF.Properties;

namespace CafeWPF.Classes
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

        public void AddFood(Image newImage)
        {
            Array.Resize(ref images, images.Length + 1);
            images[images.Length - 1] = newImage;
        }

        public void RemoveFood(int index)
        {
            images[index] = null;
            for (int i = index; i < images.Length - 1; i++)
            {
                images[i] = images[i + 1];
            }
        }

        public int GetLenght()
        {
            return images.Length;
        }
    }
}
