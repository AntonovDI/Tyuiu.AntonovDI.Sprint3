using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AntonovDI.Sprint3.Task5.V23.Lib
{
    public class DataService : ISprint3Task5V23
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double res = 0;
            int perem = x;
            int y1 = stopValue1; int y2 = stopValue2;
            for (int x1 = startValue1; x1 <= y1; x1++)
            {
                for (int x2 = startValue2; x2 <= y2; x2++)
                {
                    res += ((Math.Pow(2, x2) + 2) * (Math.Cos(x2)));
                }
            }
            return Math.Round(res, 3);
        }
    }
}
