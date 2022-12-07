using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
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
                        }
    }
}
