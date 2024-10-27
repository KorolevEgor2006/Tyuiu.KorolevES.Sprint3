using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KorolevES.Sprint3.Task1.V30.Lib
{
    public class DataService : ISprint3Task1V30
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            int k = startValue;
            while (k <= stopValue) 
            {
                double s = Math.Pow(value, k) + (5.0 / (4.0 + k));
                sumSeries = sumSeries+s*Math.Sin(value);
                k++;
            }
            return Math.Round(sumSeries,3);
        }
    }
}
