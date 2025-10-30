using Tyuiu.AntonovDI.Sprint3.Task7.V9.Lib;

namespace Tyuiu.AntonovDI.Sprint3.Task7.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = 0.75;
            valueWaitArray[1] = 0.75;
            valueWaitArray[2] = 0.75;
            valueWaitArray[3] = 0.75;
            valueWaitArray[4] = 0.75;
            valueWaitArray[5] = 0.75;
            valueWaitArray[6] = 0.75;
            valueWaitArray[7] = 0.75;
            valueWaitArray[8] = 0.75;
            valueWaitArray[9] = 0.75;
            valueWaitArray[10] = 0.75;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);

        }
    }
}
