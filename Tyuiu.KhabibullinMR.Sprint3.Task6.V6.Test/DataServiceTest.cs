using Tyuiu.KhabibullinMR.Sprint3.Task6.V6.Lib;

namespace Tyuiu.KhabibullinMR.Sprint3.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = 16;
            int end = 24;
            int wait = 11;
            int res = ds.GetSumTheDivisors(start, end);
            Assert.AreEqual(wait,res);
        }
    }
}