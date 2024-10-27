using Tyuiu.KorolevES.Sprint3.Task1.V30.Lib;
namespace Tyuiu.KorolevES.Sprint3.Task1.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Королев Е. С.| АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Cпринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Королев Егор Сергеевич | АСОиУб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет сумму ряда   *");
            Console.WriteLine("* по формуле, при t=0,5:                                                  *");
            Console.WriteLine("*      _ 12                                                               *");
            Console.WriteLine("*  S = >     (t^k+5/(4+k))*sin(t)                                         *");
            Console.WriteLine("*      - k=1                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            int start = 1, end = 12;
            double t = 0.5;
            Console.WriteLine("Переменная t = " + t);
            Console.WriteLine("Старт шага = " + start);
            Console.WriteLine("Конец шага = " + end);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма ряда= " + ds.GetSumSeries(t,start, end));
            Console.ReadKey();
        }
    }
}
