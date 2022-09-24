using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число 1");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("введите число 2");
            int b = int.Parse(Console.ReadLine());
        int ack1_9 = 0;
        Console.WriteLine("1 сложить числа");
        Console.WriteLine("2 Вычесть первое из второго");
        Console.WriteLine("3 Перемножить два числа");
        Console.WriteLine("4 Разделить первое на второе");
        Console.WriteLine("5 Возвести в степень N первое число");
        Console.WriteLine("6. Найти квадратный корень из числа");
        Console.WriteLine("7. Найти 1 процент от числа");
        Console.WriteLine("8. Найти факториал из числа");
        Console.WriteLine("9. Выйти из программы");   
        while (ack1_9 != 9)
        {
             ack1_9 = int.Parse(Console.ReadLine());
            switch (ack1_9)
            {
                case 1:
                    Console.WriteLine(a+b);
                    break;
                case 2:
                    Console.WriteLine(a-b);
                    break;
                case 3:
                    Console.WriteLine(a*b) ;    
                    break;
                case 4:
                    Console.WriteLine(a/b);
                    break;
                case 5:
                    Console.WriteLine(Math.Pow(a,b));
                    break;
                case 6:
                    Console.WriteLine(Math.Sqrt(a));
                    break;
                case 7:
                    Console.WriteLine(a*0.01);
                    break;
                case 8:
                    int kpp = 1;
                    for (int i = 0; i <= a; i++)
                    {
                        kpp = kpp * i;
                    }
                    Console.WriteLine(kpp);
                    break;


            }

        }
        }
    }


   







