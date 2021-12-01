using System;

namespace myApp
{
    class OrdinaryCalc : AbstractCalc
    {
        public double num1 { get; set; }
        public double num2 { get; set; }

        public OrdinaryCalc() { }

        public override double add()
        {
            return num1 + num2;
        }

        public override double sub()
        {
            return num1 - num2;
        }

        public override double mul()
        {
            return num1 * num2;
        }

        public override double div()
        {
            return num1 / num2;
        }
    }

}