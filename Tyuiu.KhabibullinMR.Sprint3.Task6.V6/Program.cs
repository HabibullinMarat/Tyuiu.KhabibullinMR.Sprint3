using Tyuiu.KhabibullinMR.Sprint3.Task6.V6.Lib;

namespace Tyuiu.KhabibullinMR.Sprint3.Task6.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");

            int startValue = 16;
            int stopValue = 24;

            Console.WriteLine("Начало отрезка = " + startValue);
            Console.WriteLine("Конец отрезка = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                 ");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Количество делителей = " + ds.GetSumTheDivisors(startValue,stopValue));
            Console.ReadKey();
        }
    }
}
