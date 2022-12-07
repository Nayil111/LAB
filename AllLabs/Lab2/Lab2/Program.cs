using System;

namespace Lab2
{
    class Program
    {
        static bool Main(string[] args)
        {
            Console.WriteLine("Введите число от 1 до 7");
            int num = 0;
            while (true)
            {
                string str = Console.ReadLine();
                bool res = int.TryParse(str, out num);
                if ((res == true))
                {
                    if ((num < 8) && (num > -1))
                    {
                        string month = "";

                        switch (num)

                        {
                            case 1:
                                month = "понедельник";
                                break;
                            case 2:
                                month = "вторник";
                                break;
                            case 3:
                                month = "среда";
                                break;
                            case 4:
                                month = "четверг";
                                break;
                            case 5:
                                month = "пятница";
                                break;
                            case 6:
                                month = "суббота";
                                break;
                            case 7:
                                month = "воскресенье";
                                break;
                        }
                        Console.WriteLine(month);
                        Console.WriteLine();

                    }
                    else Console.WriteLine("FAIL");

                }

                Console.WriteLine("Номер 2");
                int nn = 15;
                if ((nn % 3 == 0) && (nn % 5 == 0)) ;
                {
                    Console.WriteLine("BuzzFizz");
                
                else if (nn % 3 == 0) ;
                {
                    Console.WriteLine("Buzz");
                }
{}
                    else (nn % 5 == 0);
                {
                    Console.WriteLine("Fizz");
                }
                Console.WriteLine("Введите первое число");
                int a1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                int b1 = Convert.ToInt32(Console.ReadLine());
            }
    }
}
