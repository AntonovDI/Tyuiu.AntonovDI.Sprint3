using tyuiu.cources.programming.interfaces.Sprint3;


namespace Tyuiu.AntonovDI.Sprint3.Task7.V9.Lib
{
    public class DataService : ISprint3Task7V9
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray = new double[11];
            
            int count = 0;
            
            for (int x = startValue; x <= stopValue; x++)
            {
                if ((Math.Cos(x) - 2 * x) == 0)
                {
                    valueArray[count] = 0;
                }
                else
                {
                    valueArray[count] = Math.Round((((2 * x - 3) / (Math.Cos(x) - 2 * x)) + 5 * x - Math.Sin(x)), 2);
       
                }
                
                count++;
            }

            return valueArray;
        }
    }
}
