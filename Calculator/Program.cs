using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Если работа программы не завершена
            bool endApp = false;

            // Название программы
            Console.WriteLine("Консольный калькулятор на C#\r");
            Console.WriteLine("----------------------------\n");

            while (!endApp)
            {
                // Создание переменных
                string numInput1 = "";
                string numInput2 = "";

                // Просим пользователя ввести первое число
                Console.Write("\nВведите первое число и нажмите Enter: ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("Ошибка ввода\n Введите число: ");
                    numInput1 = Console.ReadLine();
                }

                // Просим пользователя ввести второе число
                Console.Write("\nВведите второе число и нажмите Enter: ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("Ошибка ввода\n Введите число: ");
                    numInput2 = Console.ReadLine();
                }

                double num1 = 0;
                double num2 = 0;
                num1 = Convert.ToDouble(numInput1);
                num2 = Convert.ToDouble(numInput2);

                // Список доступных операций
                Console.WriteLine("\nВыберите операцию из списка:");
                Console.WriteLine("\tВведите + для операции сложения");
                Console.WriteLine("\tВведите - для операции вычитания");
                Console.WriteLine("\tВведите * для операции умножения");
                Console.WriteLine("\tВведите / для операции деления");
                Console.Write("\nВведите выбранную операцию: ");

                string op = Console.ReadLine();

                // Вычисления с помощью swith
                switch (op)
                {
                    case "+":
                        Console.WriteLine($"\n{num1} + {num2} = " + (num1 + num2));
                        break;
                    case "-":
                        Console.WriteLine($"\n{num1} - {num2} = " + (num1 - num2));
                        break;
                    case "*":
                        Console.WriteLine($"\n{num1} * {num2} = " + (num1 * num2));
                        break;
                    case "/":
                        while (num2 == 0)
                        {
                            Console.WriteLine("\nДеление на ноль невозможно");

                            // Просим ввести второе число
                            Console.WriteLine("\nВведите второе число и нажмите Enter: \n");
                            num2 = Convert.ToDouble(Console.ReadLine());
                        }
                        Console.WriteLine($"\n{num1} / {num2} = " + (num1 / num2));
                        break;
                    default:
                        Console.WriteLine("\nТакой операции нет \n");
                        break;
                }
                Console.WriteLine("----------------------------\n");

                // Ждем ответа пользователя на завершение программы
                Console.Write("Если хотите завершить вычисления, введите 'да' и нажниме Enter. Если хотите продолжить, просто нажмите : Enter  ");
                if (Console.ReadLine() == "да") endApp = true;

                Console.WriteLine("\n"); 
            }
            return;
        }
    }
}