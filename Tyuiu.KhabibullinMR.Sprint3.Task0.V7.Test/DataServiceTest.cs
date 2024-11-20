using Tyuiu.KhabibullinMR.Sprint3.Task0.V7.Lib;

namespace Tyuiu.KhabibullinMR.Sprint3.Task0.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0.75;
            int start = 1;
            int end = 20;
            double res = ds.GetSumSeries(x, start, end);
            double wait = 0.333;
            Assert.AreEqual(wait, res);
        }
    }
}