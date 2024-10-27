using Tyuiu.KorolevES.Sprint3.Task6.V21.Lib;
namespace Tyuiu.KorolevES.Sprint3.Task6.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisorsTest()
        {
            DataService ds = new DataService();
            int start = 19, end = 20, wait = 62;
            int res = ds.GetSumTheDivisors(start, end);
            Assert.AreEqual(wait, res);
        }
    }
}