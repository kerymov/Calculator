using System;
using myApp.Exceptions;

namespace myApp
{
    class Program
    {
        private static readonly MathProxy s_mathProxy = MathProxy.GetInstance();

        static void Main(string[] args)
        {
            Console.Write("Hello, User!\n");

            while (true)
            {
                Console.Write("Оберіть одну з наступних операцій: ");
                Console.WriteLine("+, -, *, /, tg");

                string operation = InputOperation();

                double? result = DoCalculation(operation);
                Console.WriteLine(result);

                Console.WriteLine("Бажаєте продовжити? Т/Н");
                string input = Console.ReadLine();
                if (input.ToLower() != "т") { break; }
            }

            Console.WriteLine("До побачення!");
        }

        // Input

        private static double InputNumber() {
            while (true) {
                string input = Console.ReadLine();
                if (Double.TryParse(input, out double num)) return num;
                else Console.WriteLine("Помилка! Спробуйте ще раз");
            }
        }

        private static string InputOperation() {
            while (true) {
                string operation = Console.ReadLine();
                if (
                    operation == "+"
                    || operation == "-"
                    || operation == "*"
                    || operation == "/"
                    || (operation == "tg"))
                {
                    return operation;
                }
                else Console.WriteLine("Помилка! Спробуйте ще раз");
            }
        }

        // Calculation

        private static double? DoCalculation(string operation)
        {
            if (operation == "tg")
            {
                try
                {
                    SetCornerValue(out double x);
                    return s_mathProxy.Tan(x);
                }
                catch (AdvancedOperationException e)
                {
                    Console.WriteLine($"ArithmeticException Handler: {e}");
                    return null;
                }
            }
            else
            {
                InitNumbers(out double x, out double y);

                switch (operation)
                {
                    case "+":
                        return s_mathProxy.Add(x, y);
                    case "-":
                        return s_mathProxy.Sub(x, y);
                    case "*":
                        return s_mathProxy.Mul(x, y);
                    case "/":
                        try
                        {
                            return s_mathProxy.Div(x, y);
                        }
                        catch (ArithmeticException e)
                        {
                            Console.WriteLine($"ArithmeticException Handler: {e}");
                            return null;
                        }
                    default:
                        return null;
                }
            }
        }

        // Initialization

        private static void InitNumbers(out double x, out double y)
        {
            Console.Write("Задайте 1-е число: ");
            x = InputNumber();             
            Console.Write("Задайте 2-е число: ");
            y = InputNumber();
        }

        private static void SetCornerValue(out double x)
        {
            Console.Write("Задайте значення кута в межах від -90 до 90 градусів: ");
            x = InputNumber();
        }
    }
}
