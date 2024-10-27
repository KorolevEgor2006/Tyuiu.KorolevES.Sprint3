using Tyuiu.KorolevES.Sprint3.Task2.V20.Lib;
namespace Tyuiu.KorolevES.Sprint3.Task2.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Королев Е. С.| АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Cпринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла do-while                                           *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Королев Егор Сергеевич | АСОиУб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу  используя цикл do...while, которая вычисляет        *");
            Console.WriteLine("* произведение ряда по формуле, при х=1:                                  *");
            Console.WriteLine("*      6                                                                  *");
            Console.WriteLine("*  P = П (2/(cos(x)+0.5))^k                                               *");
            Console.WriteLine("*      k=1                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            int start = 1, end = 6;
            int x = 1;
            Console.WriteLine("Переменная x = " + x);
            Console.WriteLine("Старт шага = " + start);
            Console.WriteLine("Конец шага = " + end);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Произведение ряда = "+ ds.GetMultiplySeries(x,start,end));
            Console.ReadKey();

        }
    }
}
