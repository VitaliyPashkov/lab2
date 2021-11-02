using System;

namespace IndTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
        
            int x;
            Console.WriteLine("Введите произвольное число");
            while (!int.TryParse(Console.ReadLine(), out x))
                Console.WriteLine("Ошибка ввода. Попробуйте еще раз:");

            string strX = x.ToString();

            
            if (strX.Length < 4) 
                Console.WriteLine(strX.Length);
            else 
                Console.WriteLine("BIG");
            
            if (x < 0)
                Console.WriteLine("NEG");


            //2
            for (int i = 10; i < 100; i++)
            {
                if (i.ToString()[0] == '4' || i.ToString()[1] == '4')
                {
                    if (i % 4 != 0)
                        Console.WriteLine(i);
                }
            }


        }
    }
}
