using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment3
{
    internal class _3d_Point : IComparable , ICloneable 
    {
        public int x { get; set; }

        public int y { get; set; }


        public int z { get; set; }


        public _3d_Point(int _x, int _y)
        {

        }

        // constructor chaining
        public _3d_Point(int _x, int _y, int _z)
        {
            this.x = _x;
            this.y = _y;
            this.z = _z;
        }

        public int CompareTo(_3d_Point other)
        {
            if (this.x == other.x)
            {
                return this.y.CompareTo(other.y);
            }
            else
            {
                return this.x.CompareTo(other.x);
            }

        }
        public _3d_Point(_3d_Point pointcopy)
        {
            this.x = pointcopy.x;
            this.y = pointcopy.y;
            this.z = pointcopy.z;
        }


        public object Clone()
        {
            return new _3d_Point(x,y , z)
            { 
                x = this.x,
                y = this.y,
                z = this.z
            };
        }

        //string override method
        public override string ToString()
        {
            return $"Point Coordinates ({x},{y},{z})";
        }

       
    }
}
