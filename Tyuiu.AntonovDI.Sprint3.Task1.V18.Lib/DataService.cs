using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AntonovDI.Sprint3.Task1.V18.Lib
{
    public class DataService : ISprint3Task1V18
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sum = 0;
            while (startValue < stopValue + 1)
            {
                sum += (Math.Sin(startValue));
                startValue += 1;
            }
            sum *= Math.Pow(0.25, 2);
            return Math.Round(sum, 3);
        }
        
    }
}
