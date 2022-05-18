using System;
using myApp.Exceptions;

namespace myApp
{
    class Math : IMath, IAdvanced
    {
        public Math() { }

        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Sub(double x, double y)
        {
            return x - y;
        }

        public double Mul(double x, double y)
        {
            return x * y;
        }

        public double Div(double x, double y)
        {
            return x / y;
        }

        public double Tan(double x)
        {
            return System.Math.Tan(x);
        }
    }

}