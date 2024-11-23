using Tyuiu.KhabibullinMR.Sprint3.Task5.V22.Lib;

namespace Tyuiu.KhabibullinMR.Sprint3.Task5.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");

            int x = 2;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 12;

            Console.WriteLine("Старт шага первого ряда = " + startValue1);
            Console.WriteLine("Конец шага первого ряда = " + stopValue1);
            Console.WriteLine("Старт шага второго ряда = " + startValue2);
            Console.WriteLine("Конец шага второго ряда = " + stopValue2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                 ");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма ряда = " + ds.GetSumSumSeries(x,startValue1,startValue2,stopValue1,stopValue2));
            Console.ReadKey();
        }
    }
}
