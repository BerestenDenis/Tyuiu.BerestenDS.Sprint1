using Tyuiu.BerestenDS.Sprint1.Task6.V17.Lib;
namespace Tyuiu.BerestenDS.Sprint1.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            Assert.AreEqual(true, new DataService().CheckPalindrome("казак"));
        }
    }
}