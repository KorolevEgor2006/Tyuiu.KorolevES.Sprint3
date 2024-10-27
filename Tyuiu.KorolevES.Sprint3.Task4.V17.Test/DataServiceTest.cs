using Tyuiu.KorolevES.Sprint3.Task4.V17.Lib;
namespace Tyuiu.KorolevES.Sprint3.Task4.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateTest()
        {
            DataService ds = new DataService();
            int start =-2, end = 2;
            double res = ds.Calculate(start, end);
            double wait = -0.294;
            Assert.AreEqual(wait, res);
        }
    }
}