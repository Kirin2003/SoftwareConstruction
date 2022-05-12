using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Triangle : Shape
    {
        private double _a;
        private double _b;
        private double _c;
        public double a
        {
            get { return _a; }
            set { _a = value; }
        }
        public double b
        {

            get { return _b; }
            set { _b = value; }
        }

        public double c
        {
            get { return _c; }
            set { _c = value; }
        }

        public Triangle(double a, double b, double c)
        {
            this._a = a;
            this._b = b;
            this._c = c;
        }

        public override double getArea()
        {
            double p = (_a + _b + _c) / 2;
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }

        public override bool isLegal()
        {
            return _a > 0 && _b > 0 && _c > 0 && (_a + _b) > _c && (_b + _c) > a && (_c + _a) > _b;
        }
    }
    }
