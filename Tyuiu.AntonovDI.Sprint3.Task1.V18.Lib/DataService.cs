using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AntonovDI.Sprint3.Task1.V18.Lib
{
    public class DataService : ISprint3Task1V18
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sum = 0;
            int i = 1;
            while (i < stopValue)
            {
                sum += (Math.Sin(i) + Math.Pow(0.25, 2));
                i+=1;
            }
            return Math.Round(sum, 3);
        }
    }
}
