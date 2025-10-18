using Tyuiu.AntonovDI.Sprint3.Task1.V18.Lib;

namespace Tyuiu.AntonovDI.Sprint3.Task1.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 15;
            
            double wait = 0.121;
            double res = ds.GetSumSeries(startValue, stopValue);
            Assert.AreEqual(wait, res);
        }
    }
}
