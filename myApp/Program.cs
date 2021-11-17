using System;

namespace myApp
{
    class OriginaryCalc
    {
        public double num1 { get; set; }
        public double num2 { get; set; }

        public OriginaryCalc() { }

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

    class Program
    {
        static void Main(string[] args)
        {   
            OriginaryCalc calc = new OriginaryCalc();
            calc.num1 = 3;
            calc.num2 = 7;
            Console.WriteLine(calc.add());
        }
    }
}
