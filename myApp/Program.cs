using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Hello, User!\nОберіть режим роботи калькулятора:");
            Console.WriteLine("1 - Звичайний");
            Console.WriteLine("2 - Інженерний");
            Console.WriteLine("0 - Завершити роботу");

            int mode = inputMode();

            while(true) {
                if(mode == 1) Console.WriteLine("\nРежим роботи: 'Звичайний'\n");
                else if(mode == 2) Console.WriteLine("\nРежим роботи: 'Інженерний'\n");
                else break;

                Console.Write("Оберіть одну з наступних операцій: ");
                if(mode == 1)Console.WriteLine("+, -, *, /");
                else Console.WriteLine("+, -, *, /, cos");

                string operation = inputOperation(mode);
                if(mode == 1) {
                    OrdinaryCalc calc = new OrdinaryCalc();
                    Console.WriteLine(doCalculation(calc, operation));
                } else {
                    AdvancedCalc calc = new AdvancedCalc();
                    Console.WriteLine(doCalculation(calc, operation));
                }

                Console.WriteLine("Бажаєте продовжити? Т/Н");
                string input = Console.ReadLine();
                if(input.ToLower() != "т") break;
            }

            Console.WriteLine("До побачення!");
        }

        static int inputMode() {
            int mode = -1;
            bool isOperationCorrect = false;
            while(!isOperationCorrect) {
                string input = Console.ReadLine();
                if(Int32.TryParse(input, out mode) && (mode == 1 || mode == 2 || mode == 0)) isOperationCorrect = true;
                else Console.WriteLine("Помилка! Спробуйте ще раз");
            }
            return mode;
        }

        static double inputNumber() {
            double num = -1;
            bool isNumberCorrect = false;
            while(!isNumberCorrect) {
                string input = Console.ReadLine();
                if (Double.TryParse(input, out num)) isNumberCorrect = true;
                else Console.WriteLine("Помилка! Спробуйте ще раз");
            }
            return num;
        }

        static string inputOperation(int mode) {
            string operation = "";
            bool isOperationCorrect = false;
            while(!isOperationCorrect) {
                operation = Console.ReadLine();
                if(operation == "+" || operation == "-" || operation == "*" || operation == "/" || (operation == "cos" && mode == 2)) 
                    isOperationCorrect = true;
                else Console.WriteLine("Помилка! Спробуйте ще раз");
            }
            return operation;
        }

        static double doCalculation(OrdinaryCalc calc, string operation) {
            double res;
            initNumbers(ref calc, operation);
            switch(operation) {
                case "+": res = calc.add();
                    break;
                case "-": res = calc.sub(); 
                    break;
                case "*": res = calc.mul(); 
                    break;
                case "/": res = calc.div(); 
                    break;
                default: res = 0; 
                    break;
            }
            return res;
        }

        static double doCalculation(AdvancedCalc calc, string operation) {
            double res;
            initNumbers(ref calc, operation);
            switch(operation) {
                case "+": res = calc.add();
                    break;
                case "-": res = calc.sub(); 
                    break;
                case "*": res = calc.mul(); 
                    break;
                case "/": res = calc.div(); 
                    break;
                case "cos": res = calc.cos(); 
                    break;
                default: res = 0; 
                    break;
            }
            return res;
        }

        static void initNumbers(ref OrdinaryCalc calc, string operation) {
            Console.Write("Задайте 1-е число: ");
            double num1 = inputNumber();             
            Console.Write("Задайте 2-е число: ");
            double num2 = inputNumber(); 
            calc.num1 = num1;
            calc.num2 = num2;
        }

        static void initNumbers(ref AdvancedCalc calc, string operation) {
            if(operation == "cos") {
                Console.Write("Задайте значення кута: ");
                double num = inputNumber();
                num = (num % 360) * Math.PI / 180.0;
                calc.num1 = num;
            } else {
                Console.Write("Задайте 1-е число: ");
                double num1 = inputNumber();             
                Console.Write("Задайте 2-е число: ");
                double num2 = inputNumber(); 
                calc.num1 = num1;
                calc.num2 = num2;
            }
        }
    }
}
