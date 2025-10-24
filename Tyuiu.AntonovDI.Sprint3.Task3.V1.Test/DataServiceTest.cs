using Tyuiu.AntonovDI.Sprint3.Task3.V1.Lib;

namespace Tyuiu.AntonovDI.Sprint3.Task3.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCharCount()
        {
            DataService ds = new DataService();
            string value = "have a nice time";
            char chr = 'a';
            int res = ds.GetCharCount(value, chr);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}
