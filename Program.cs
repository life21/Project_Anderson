using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_anderson
{
    class Program
    {
        static void Main(string[] args)

        {
            try
            {
                Console.WriteLine("Задание 1:");

                Console.WriteLine("Введите число:");
                int n = Convert.ToInt32(Console.ReadLine());

                if (n > 7)
                    Console.WriteLine("Привет");
            }

            catch (ArgumentOutOfRangeException e)

            {
                Console.Write("Исключительная ситуация: " + e.Message);
            }

            Console.WriteLine("");

            Console.WriteLine("Задание 2:");

            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();

            if (name == "Вячеслав")
                Console.WriteLine("Привет, Вячеслав");
            else
                Console.WriteLine("Нет такого имени");

            try
            {

                Console.WriteLine("");

                Console.WriteLine("Задание 3:");


                int N;

                Console.WriteLine("Введите число элементов массива");
                N = Convert.ToInt16(Console.ReadLine());
                double[] arr = new double[N];
                int i = 0;

                Console.WriteLine("Введите элементы массива");

                while (i < N)
                {
                    arr[i] = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    i++;
                }
                Console.WriteLine("Элементы массива кратные трём:");

                for (i = 0; i < N; i = i + 1)
                {
                    if (arr[i] % 3 == 0)

                        Console.WriteLine("Элемент[" + i + "]: " + arr[i]);
                }
            }

            catch (ArgumentOutOfRangeException e)
            {
                Console.Write("Исключительная ситуация: " + e.Message);
            }

          Console.ReadKey();

            }
       }
    }

