using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Square : Shape
    {
        private double _side;
        public double side
        {
            get { return _side; }
            set { _side = value; }
        }

        public Square(double side)
        {
            this._side = side;
        }

        public override double getArea()
        {
            return _side * _side;
        }

        public override bool isLegal()
        {
            return (_side > 0);
        }
    }
}
