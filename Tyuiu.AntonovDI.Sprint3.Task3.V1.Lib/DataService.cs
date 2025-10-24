using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AntonovDI.Sprint3.Task3.V1.Lib
{
    public class DataService : ISprint3Task3V1
    {
        int counter = 0;
        public int GetCharCount(string value, char item)
        {
            foreach (char chr in value)
            {
                if (chr == 'a')
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
