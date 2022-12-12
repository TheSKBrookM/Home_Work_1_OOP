using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_3
{
    internal class Point
    {

        private int x, y;
        private string pointName;

        public int X 
        {
            get
            {  
                return x;
            }
        }
        public int Y 
        {
            get
            { 
                return y;
            }
        }  
        public string PointName 
        {
            get
            {
                return pointName;
            }
        }

        public Point(int x, int y, string pointName)
        { 
            this.x = x;
            this.y = y;
            this.pointName = pointName;
        }
    }
}
