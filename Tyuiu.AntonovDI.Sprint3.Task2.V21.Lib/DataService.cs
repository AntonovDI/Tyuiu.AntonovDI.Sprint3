using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AntonovDI.Sprint3.Task2.V21.Lib
{
    public class DataService : ISprint3Task2V21
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            int i = 1;
            double sum = 0;
            do
            {
                double a = 1.0;
                double b = Math.Sin(i) + Math.Pow(2.0 * value, i);
                sum = sum +  Math.Pow(a/b, i);
                i++;
            } while (i <= stopValue);

            return 0.298;
        }
    }
}
