﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KhabibullinMR.Sprint3.Task2.V20.Lib
{
    public class DataService : ISprint3Task2V20
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double res = 0;
            do
            {
                res = res + Math.Pow(2 / (Math.Cos(value) + 0.5), startValue);
                startValue++;
            } while(startValue<=stopValue);
            return Math.Round(res,3);
        }

    }
}
