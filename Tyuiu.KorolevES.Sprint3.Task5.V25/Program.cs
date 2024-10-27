using Tyuiu.KorolevES.Sprint3.Task5.V25.Lib;
namespace Tyuiu.KorolevES.Sprint3.Task5.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Королев Е. С.| АСОиУб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Cпринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Королев Егор Сергеевич | АСОиУб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя вложенные циклы найти значение функции     *");
            Console.WriteLine("* при x = 2.                                                              *");
            Console.WriteLine("*    3  10                                                                *");
            Console.WriteLine("* Y= E  E  (x^k+cos(k))                                                   *");
            Console.WriteLine("*   i=1 k=1                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            int start1 = 1, end1 = 3, start2 = 1, end2 = 10, x = 2;
            Console.WriteLine("Переменная x = "+x);
            Console.WriteLine("Старт шага первой суммы ряда = " + start1);
            Console.WriteLine("Конец шага первой суммы ряда = " + end1);
            Console.WriteLine("Старт шага второй суммы ряда = " + start2);
            Console.WriteLine("Конец шага второй суммы ряда = " + end2);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма ряда = " + ds.GetSumSumSeries(x,start1,start2,end1,end2));
            Console.ReadKey();
        }
    }
}
