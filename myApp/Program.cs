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

    class AdvancedCalc : OrdinaryCalc
    {
        public AdvancedCalc() { }

        public double cos(double num) {
            return Math.Cos(num);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {   
            AdvancedCalc calc = new AdvancedCalc();
            Console.WriteLine(calc.cos(9));
            calc.num1 = 12;
            calc.num2 = 10;
            Console.WriteLine(calc.mul());
        }
    }
}
