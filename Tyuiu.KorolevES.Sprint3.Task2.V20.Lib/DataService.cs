using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KorolevES.Sprint3.Task2.V20.Lib
{
    public class DataService : ISprint3Task2V20
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            int k = startValue;
            double result = 1;
            do
            {
                result *= Math.Pow(2/(Math.Cos(value)+0.5),k);
                k++;
            } while (k <= stopValue);
            return Math.Round(result,3);
        }
    }
}
