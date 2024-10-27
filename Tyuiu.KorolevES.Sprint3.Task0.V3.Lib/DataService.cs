﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KorolevES.Sprint3.Task0.V3.Lib
{
    public class DataService : ISprint3Task0V3
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sumSeries = 0;
            for (int i = startValue; i <= stopValue; i++) 
            {
                sumSeries += Math.Sin(i) * 0.5 * 0.5;
            }
            return Math.Round(sumSeries,3);
        }
    }
}
