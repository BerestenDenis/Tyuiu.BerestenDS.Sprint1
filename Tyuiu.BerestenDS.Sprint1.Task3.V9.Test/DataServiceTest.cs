using Tyuiu.BerestenDS.Sprint1.Task3.V9.Lib;
namespace Tyuiu.BerestenDS.Sprint1.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExperssion()
        {
            DataService ds = new DataService();
            int x = 150;
            int hours = 2;
            var res = ds.ConvertMinutesToHours(x);
            Assert.AreEqual(hours, res);
        }
    }
}