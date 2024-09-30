
using Tyuiu.BushlyaYaV.Sprint1.Task3.V7.Lib;


namespace Tyuiu.BushlyaYaV.Sprint1.Task3.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double verst = 1;
            double wait = 1066.8;
            var res = ds.VerstsToKilometers(verst);
            Assert.AreEqual(wait, res);


        }
    }
}