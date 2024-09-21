using Tyuiu.BerestenDS.Sprint1.Task0.V5.Lib;

namespace Tyuiu.BerestenDS.Sprint1.Task0.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(2, res);
        }
    }
}