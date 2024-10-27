using Tyuiu.KorolevES.Sprint3.Task5.V25.Lib;
namespace Tyuiu.KorolevES.Sprint3.Task5.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeriesTest()
        {
            DataService ds = new DataService();
            int x =1,start1=1,end1 =2,start2 =1,end2 =2;
            double res = ds.GetSumSumSeries(x,start1,start2,end1,end2);
            double wait = 4.248;
            Assert.AreEqual(wait,res);
        }
    }
}