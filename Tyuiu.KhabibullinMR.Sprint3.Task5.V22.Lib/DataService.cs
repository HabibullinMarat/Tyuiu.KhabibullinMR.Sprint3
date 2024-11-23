using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KhabibullinMR.Sprint3.Task5.V22.Lib
{
    public class DataService : ISprint3Task5V22
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sum = 0;
            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int j = startValue2; j <= stopValue2; j++)
                {
                    sum = sum + (x * x * x * Math.Sin(j)) + 2;
                }
            }
            return Math.Round(sum,3);
        }
    }
}
