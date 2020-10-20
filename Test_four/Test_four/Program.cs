using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq.Expressions;
using System.Xml;

namespace Test_four
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            double sum = 0, sumn = 0, max = -10000000;
            Console.WriteLine("Input n");
            n = Convert.ToInt32(Console.ReadLine());

            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;

            var new_out1 = new StreamWriter(@"input.txt");
            Console.SetOut(new_out1);

            double[] array = new double[n];
            Console.WriteLine("N = " + n);

            for (int i = 0; i < n; i++)
            {

                //Создание объекта для генерации чисел
                Random rnd = new Random();

                //Получить случайное число (в диапазоне от 0 до 10)
                array[i] = rnd.Next(-25, 35);
                if (array[i] > 0)
                { 

                    sum += array[i];
                    sumn++;
                }
                if (array[i] < 0 && array[i]>max)
                {
                    max = array[i];
                }

                Console.Write(array[i] + " ");

            }
            Console.WriteLine();
           
            Console.SetOut(save_out); new_out1.Close();


            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);

            for (int i = 0; i < n; i++)
            {

                if (array[i] < 0) array[i] = 0;
                if (array[i] > 0) array[i] = 1;
                Console.Write(array[i] + " ");
            }
                                   

            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
            Console.ReadKey();
        }
    }
}
