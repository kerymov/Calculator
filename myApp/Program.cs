using System;

namespace myApp
{
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
