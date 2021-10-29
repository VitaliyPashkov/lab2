void piCounter() { 
            bool flag = true;
            while (flag) {
                int count = 0;
                while (true) {
                    Console.WriteLine("Введите количество слагаемых:");
                    if (Int32.TryParse(Console.ReadLine(), out count) && count > 0)
                        break;
                    else
                        Console.WriteLine("Введено неверное значение. Попробуйте еще раз.");
                }

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
                bool checkResponse = true;
                    while (checkResponse)
                    {
                        Console.WriteLine("Повторить расчеты еще раз? (да/нет):");
                        string response = Console.ReadLine();
                        if (response == "да")
                        {
                            checkResponse = false;
                        }
                        else if (response == "нет")
                        {
                            flag = false;
                            break;
                        }
                        else Console.WriteLine("Ошибка ввода. Попробуйте еще раз.");
                    }
                }
            }
