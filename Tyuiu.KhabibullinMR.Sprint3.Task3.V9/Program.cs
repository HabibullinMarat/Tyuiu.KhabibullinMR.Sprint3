using Tyuiu.KhabibullinMR.Sprint3.Task3.V9.Lib;

namespace Tyuiu.KhabibullinMR.Sprint3.Task3.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");

            string value = "56hy vfe4r4 vf45b";
            char item = 'w';

            Console.WriteLine("Стартовая строка: " + value);
            Console.WriteLine("Символ замены " + item);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                 ");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Конечная строка: " + ds.ReplaceNumOnChar(value, item));
        }
    }
}
