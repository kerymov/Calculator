using System;

namespace myApp
{
    class OrdinaryCalc
    {
        public double num1 { get; set; }
        public double num2 { get; set; }

        public OrdinaryCalc() { }

        public double add() { 
            return num1 + num2;
        }

        public double sub() { 
            return num1 - num2;
        }

        public double mul() { 
            return num1 * num2;
        }

        public double div() { 
            return num1 / num2;
        }
    }

}