using Tyuiu.AntonovDI.Sprint3.Task5.V23.Lib;

namespace Tyuiu.AntonovDI.Sprint3.Tassk5.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            int x1 = 1;
            int x2 = 1;
            int y1 = 3;
            int y2 = 10;
            int x = 2;
            double res = ds.GetSumSumSeries(x, x1, x2, y1, y2);
            double wait = -3653.176;
            Assert.AreEqual(wait, res);
        }
    }
}
