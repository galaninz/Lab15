using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Да я грипповал, очень много кто болеет у нас. Берегите себя.
            ArithProgression arithProgression = new ArithProgression();
            GeomProgression geomProgression = new GeomProgression();
            Console.WriteLine("Введите количество шагов");
            int stepNumbers = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Какой тип прогрессии будем смотреть?\n 1 - Арифметическая\n 2 - Геометрическая");
            int type = Convert.ToInt32(Console.ReadLine());
            if (type == 1)
            {
                Console.WriteLine("Введите стартовое значение");
                arithProgression.setStart(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Введите шаг последовательности");
                arithProgression.setStep(Convert.ToInt32(Console.ReadLine()));
                for (int i = 0; i < stepNumbers; i++)
                {
                    Console.WriteLine(arithProgression.getNext());
                }
            }
            else if (type == 2)
            {
                Console.WriteLine("Введите стартовое значение");
                geomProgression.setStart(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Введите шаг последовательности");
                geomProgression.setStep(Convert.ToInt32(Console.ReadLine()));
                for (int i = 0; i < stepNumbers; i++)
                {
                    Console.WriteLine(geomProgression.getNext());
                }
            }
            else
            {
                Console.WriteLine("Неверный код операции");
            }
            Console.ReadKey();



        }
    }
}
