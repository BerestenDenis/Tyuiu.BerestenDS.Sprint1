using System.Reflection.Metadata;
using Tyuiu.BerestenDS.Sprint1.Task7.V29.Lib;
namespace Tyuiu.BerestenDS.Sprint1.Task7.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            var ds = new DataService();
            double x = 2;
            double y = 3;
            double wait = 2.081;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}