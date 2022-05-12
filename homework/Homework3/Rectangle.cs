using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Rectangle : Shape
    {
        private double _length;
        private double _width;
        public double length
        {
            get { return _length; }
            set { _length = value; }
        }
        public double width
        {
            get { return _width; }
            set { _width = value; }
        }

        public Rectangle(double length, double width)
        {
            this._length = length;
            this._width = width;
        }

        public override double getArea()
        {
            return _length * _width;
        }

        public override bool isLegal()
        {
            return (_length > 0 && _width > 0);
        }
    }
}
