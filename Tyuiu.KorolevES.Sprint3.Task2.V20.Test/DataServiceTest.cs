using Tyuiu.KorolevES.Sprint3.Task2.V20.Lib;
namespace Tyuiu.KorolevES.Sprint3.Task2.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeriesTest()
        {
            DataService ds = new DataService();
            int start = 1, end = 2, x = 1;
            double res = ds.GetMultiplySeries(x, start, end);
            double wait = 7.106;
            Assert.AreEqual(wait, res);
        }
    }
}