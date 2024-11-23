using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KhabibullinMR.Sprint3.Task3.V9.Lib
{
    public class DataService : ISprint3Task3V9
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            foreach (char itm in value)
            {
                if (Char.IsDigit(itm))
                {
                    value  = value.Replace(itm, item);
                }
            }
            return value;
        }
    }
}
