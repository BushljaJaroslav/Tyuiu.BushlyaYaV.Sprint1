
using Tyuiu.BushlyaYaV.Sprint1.Task6.V16.Lib;

namespace Tyuiu.BushlyaYaV.Sprint1.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Тиу лучший вуз!?";
            DataService ds = new DataService();
            bool res = ds.CheckSpecSymbols(strTest);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}