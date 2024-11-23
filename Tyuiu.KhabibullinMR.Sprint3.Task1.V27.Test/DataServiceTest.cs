using Tyuiu.KhabibullinMR.Sprint3.Task1.V27.Lib;

namespace Tyuiu.KhabibullinMR.Sprint3.Task1.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int start = 1;
            int stop = 5;
            double count = 0.75;
            double res = ds.GetMultiplySeries(count, start, stop);
            double wait = 419028.1;
            Assert.AreEqual(wait, res);
        }
    }
}