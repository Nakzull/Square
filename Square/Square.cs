using System;
using System.Collections.Generic;
using System.Text;

namespace Square
{
    class Square
    {
        private int side;

        public int Side
        {
            get { return this.side; }
            set { this.side = value; }
        }
        public Square(int Side)
        {
            side = Side;
        }

        public int Perimeter(int side)
        {
            return side * 4;
        }
        public int Area(int side)
        {
            return side * side;
        }
    }
}
