using Tyuiu.KorolevES.Sprint3.Task0.V3.Lib;
namespace Tyuiu.KorolevES.Sprint3.Task0.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Королев Е. С.| АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Cпринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Королев Егор Сергеевич | АСОиУб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет сумму ряда     *");
            Console.WriteLine("* по формуле:                                                             *");
            Console.WriteLine("*      _ 10                                                               *");
            Console.WriteLine("*  S = >     sin(i)*(0.5)^2                                               *");
            Console.WriteLine("*      - i=1                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            int start = 1, end = 10;
            Console.WriteLine("Старт шага = "+ start);
            Console.WriteLine("Конец шага = " + end);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма ряда= " + ds.GetSumSeries(start,end));
            Console.ReadKey();
        }
    }
}
