using Tyuiu.KorolevES.Sprint3.Task3.V18.Lib;
namespace Tyuiu.KorolevES.Sprint3.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceNumOnCharTest()
        {
            DataService ds = new DataService();
            string str = "4n5nvf 56 bgy";
            char item = 'n';
            string wait = "nnnnvf nn bgy";
            string res = ds.ReplaceNumOnChar(str, item);
            Assert.AreEqual(wait, res);
        }
    }
}