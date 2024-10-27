using Tyuiu.KorolevES.Sprint3.Task0.V3.Lib;
namespace Tyuiu.KorolevES.Sprint3.Task0.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSumSeriesTest()
        {
            DataService ds = new DataService();
            int start = 1;
            int end = 2;
            double res =Math.Round(ds.GetSumSeries(start, end),5);
            double wait = 0.43769;
            Assert.AreEqual(wait,res);
        }
    }
}