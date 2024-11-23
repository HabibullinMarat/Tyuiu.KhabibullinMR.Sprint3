using Tyuiu.KhabibullinMR.Sprint3.Task4.V2.Lib;

namespace Tyuiu.KhabibullinMR.Sprint3.Task4.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int start = -5;
            int end = 5;
            double wait = 0.104;
            double res = ds.Calculate(start, end);
            Assert.AreEqual(wait, res);
        }
    }
}