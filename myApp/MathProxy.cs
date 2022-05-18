using System;
using myApp.Exceptions;

namespace myApp
{
    public class MathProxy : IMath, IAdvanced
    {
        private static MathProxy instance;

        public static MathProxy GetInstance()
        {
            if (instance == null) { instance = new(); }

            return instance;
        }

        private IMath _math;

        public MathProxy()
        {
            Math math = new();
            _math = math;
        }

        public double Add(double x, double y)
        {
            return _math.Add(x, y);
        }

        public double Sub(double x, double y)
        {
            return _math.Sub(x, y);
        }

        public double Mul(double x, double y)
        {
            return _math.Mul(x, y);
        }

        public double Div(double x, double y)
        {
            if (y == 0)
            {
                throw new ArithmeticException("Attempted to divide by zero.");
            }
            return _math.Div(x, y);
        }

        public double Tan(double x)
        {
            if (x <= -90 || x >= 90)
            {
                throw new AdvancedOperationException("Attempted to set transcendent value.");
            }

            double valueInRadians = x * System.Math.PI / 180.0;
            return (_math as Math).Tan(valueInRadians);
        }
    }
}
