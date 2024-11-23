using Tyuiu.KhabibullinMR.Sprint3.Task5.V22.Lib;

namespace Tyuiu.KhabibullinMR.Sprint3.Task5.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int x = 2;
            int start1 = 1;
            int end1 = 3;
            int start2 = 1;
            int end2 = 12;
            double wait = 68.991;
            double res = ds.GetSumSumSeries(x, start1, start2,end1, end2);
            Assert.AreEqual(wait, res);
        }
    }
}