using Tyuiu.KorolevES.Sprint3.Task1.V30.Lib;
namespace Tyuiu.KorolevES.Sprint3.Task1.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSumSeriesTest()
        {
            DataService ds = new DataService();
            int start = 1,end = 2;
            double t = 1;
            double wait =3.226;
            double res =ds.GetSumSeries(t,start,end);
            Assert.AreEqual(wait,res);
        }
    }
}