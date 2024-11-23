using Tyuiu.KhabibullinMR.Sprint3.Task2.V20.Lib;

namespace Tyuiu.KhabibullinMR.Sprint3.Task2.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");

            int value = 1;
            int startValue = 1;
            int stopValue = 6;

            Console.WriteLine("Переменная X: " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                 ");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма ряда = " + ds.GetMultiplySeries(value, startValue, stopValue));
            Console.ReadKey();
        }
    }
}
