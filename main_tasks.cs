using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            static double isCorrect()
            {
                double num;
                while (!double.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Введено неверное значение. Попробуйте еще раз");
                }

                return num;

            }
            void quadratic()
            {
                double a, b, c;

                Console.WriteLine("Введите коэффициент a:");
                a = isCorrect();

                Console.WriteLine("Введите коэффициент b:");
                b = isCorrect();

                Console.WriteLine("Введите коэффициент c:");
                c = isCorrect();

                double D = b * b - 4 * a * c;

                if (a != 0)
                {
                    if (D > 0)
                    {
                        double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                        double x2 = (-b - Math.Sqrt(D)) / (2 * a);

                        Console.WriteLine($"x1 = {x1}\nx2 = {x2}");
                    }
                    else if (D == 0)
                    {
                        double x = -b / (2 * a);
                        Console.WriteLine($"x = {x}");
                    }
                    else if (D < 0)
                    {
                        Console.WriteLine($"Действительных корней нет. Комплексные корни:\nx1 = {-b / (2 * a)} + i * { Math.Sqrt(-D) / (2 * a)}");
                        Console.WriteLine($"x2 = {-b / (2 * a)} - i * { Math.Sqrt(-D) / (2 * a)}");

                    }

                }
                else if (b != 0)
                    Console.WriteLine($"Уравнение является линейным. x = {-c / b}");
                else
                    Console.WriteLine("Корней нет");
            }


            //2
            void piCounter()
            {

                int count;
                Console.WriteLine("Введите точность:"); 
                while (!int.TryParse(Console.ReadLine(), out count) && count < 0)
                    Console.WriteLine("Ошибка ввода. Попробуйте еще раз:");

                double pi = 0;
                double oddNum = 1;
                for (int i = 0; i < count; i++)
                {
                    if (i % 2 == 0)
                    {
                        pi += (1 / oddNum);
                    }
                    else
                    {
                        pi -= (1 / oddNum);
                    }
                    oddNum += 2;
                }
                Console.WriteLine($"число Пи равно {pi * 4}\nПосчитано с точностью {count}\n");

            }

            //3 - только функция. Само решение задания ниже в switch
            int Fib(int n)
            {
                if (n == 1 || n == 2) return 1;
                else return Fib(n - 1) + Fib(n - 2);
            }    
                
            //4
            void calcCosinus()
            {
                double x, q;

                Console.WriteLine("Введите число x (градусы):");
                while (!double.TryParse(Console.ReadLine(), out x))
                    Console.WriteLine("Ошибка ввода. Попробуйте еще раз:");

                x = Math.PI / 180 * Math.Abs(x);
                Console.WriteLine("Введите число q:");
                while (!double.TryParse(Console.ReadLine(), out q))
                    Console.WriteLine("Ошибка ввода. Попробуйте еще раз:");

                int Factorial(int n)
                {
                    int factorial = 1;
                    for (int i = 2; i < n + 1; i++)
                    {
                        factorial *= i;
                    }
                    return factorial;
                }

                double term = 1;
                int counter = 0;
                double cos = 0;
                int sign = -1;
                for (int i = 2; Math.Abs(term) >= q; i += 2)
                {
                    cos += term;
                    term = (Math.Pow(x, i) / Factorial(i)) * sign;
                    sign = -sign;
                    counter++;

                }
                Console.WriteLine($"значение косинуса:{cos}\nПосчитано с помощью {counter} слагаемых ");

            }

            //5 
            void decomposition()
            {

                int N, isHave = 0;
                Console.WriteLine("Введите натуральное число:");
                while (!int.TryParse(Console.ReadLine(), out N) && N <= 0)
                    Console.WriteLine("Ошибка ввода. Попробуйте еще раз.\nВведите натуральное число:");

                for (int x = 1; x < N; x++)
                {
                    for (int y = 1; y < N; y++)
                    {
                        for (int z = 1; z < N; z++)
                        {
                            if (Math.Pow(x, 3) + Math.Pow(y, 3) + Math.Pow(z, 3) == N)
                            {
                                Console.WriteLine($"{Math.Pow(x, 3)} + {Math.Pow(y, 3)} + {Math.Pow(z, 3)} = {N}");
                                isHave++;
                            }
                        }
                    }
                }
                if (isHave == 0)
                    Console.WriteLine("No such combinations!");
            }

            //6
            void years()
            {

                int unit, year;
                Console.WriteLine("Введите год:");
                while (!int.TryParse(Console.ReadLine(), out year) && year < 0 && year > 100)
                    Console.WriteLine("Ошибка ввода. Попробуйте еще раз:");
                //while (year < 101) { 
                unit = year % 10;
                if (unit == 1 && year != 11)
                    Console.WriteLine(year + " год");
                else if (unit > 0 && unit < 5 && (year < 10 || year > 20))
                    Console.WriteLine(year + " года");
                else
                    Console.WriteLine(year + " лет");
                //    year++;
                //}
            }
            //_______________________________________________________________________________________________________________//

            bool checkResponse = true;
            while (checkResponse)
            {
                int choice;
                Console.WriteLine("Введите номер задания(1-6):");
                while (!int.TryParse(Console.ReadLine(), out choice) && choice > 0 && choice < 7)
                    Console.WriteLine("Ошибка ввода. Попробуйте еще раз:");

                switch (choice)
                {
                    case 1:
                        quadratic();
                        break;
                    case 2:
                        piCounter();
                        break;
                    case 3:
                        int counter = 0;
                        for (int n = 1; Fib(n) < 10000; n++)
                        {
                            if (Fib(n) > 999 && Fib(n) < 10000)
                            {
                                Console.Write(Fib(n) + " ");
                                counter++;
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine($"Количество четырехзначных чисел в ряду Фибоначчи: {counter}");

                        break;
                    case 4:
                        calcCosinus();
                        break;
                    case 5:
                        decomposition();
                        break;
                    case 6:
                        years();
                        break;
                    default:
                        Console.WriteLine("ошибка ввода.");
                        break;
                }
                while (checkResponse)
                {
                    Console.WriteLine("Повторить расчеты еще раз? (да/нет):");
                    string response = Console.ReadLine();
                    if (response == "да")
                    {
                        break;
                    }
                    else if (response == "нет")
                    {
                        checkResponse = false;
                        break;
                    }
                    else Console.WriteLine("Ошибка ввода. Попробуйте еще раз.");
                }
            }
        }
    }
}
    



       
