using System;

namespace myApp
{
    class AdvancedCalc : OrdinaryCalc, IAdvanced
    {
        public AdvancedCalc() { }

        public double cos()
        {
            return Math.Cos(num1);
        }
    }
}