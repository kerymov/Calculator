using System;

namespace myApp
{
    class AdvancedCalc : OrdinaryCalc
    {
        public AdvancedCalc() { }

        public double cos(double num) {
            return Math.Cos(num);
        }
    }
}