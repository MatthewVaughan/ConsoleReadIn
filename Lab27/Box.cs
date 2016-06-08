using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab27
{
    class Box
    {
        //Declare some int fields
        private int height;
        private int width;
        private int depth;

        //Create a constructor to set the values in the fields
        public Box(int p1, int p2, int p3)
        {
            //Set each field with the appropriate parameter
            height = p1;
            width = p2;
            depth = p3;
        }

        //Create a method that
        public int GetVolume()
        {
            //Return the volume
            return (height * width * depth);
        }
    }
}
