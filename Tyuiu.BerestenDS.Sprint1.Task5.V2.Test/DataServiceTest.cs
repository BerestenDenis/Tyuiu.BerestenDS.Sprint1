using Tyuiu.BerestenDS.Sprint1.Task5.V2.Lib;
namespace Tyuiu.BerestenDS.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x = 106;
            DataService ds = new DataService();
            double res = ds.FahrenheitTo—elsius(x);

            int result = Convert.ToInt32(res);

            int wait = 41;
            Assert.AreEqual(wait, result);
        }
    }
}