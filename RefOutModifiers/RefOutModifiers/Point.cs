using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOutModifiers
{
    public class Point
    {

        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(Point newPoint)
        {
            this.x = newPoint.x;
            this.y = newPoint.y;
        }
    }
}
