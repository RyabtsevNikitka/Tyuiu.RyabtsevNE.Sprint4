using Tyuiu.RyabtsevNE.Sprint4.Task0.V16.Lib;

namespace Tyuiu.RyabtsevNE.Sprint4.Task0.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestClass]
        public class DataServiceTest
        {
            [TestMethod]
            public void TestMethod1()
            {
                DataService ds = new DataService();

                int[] numsArray = { 2, 6, 2, 3, 4, 5, 4, 9, 7, 8 };
                int res = ds.GetMultEvenArrEl(numsArray);
                int Wait = 3072;

                Assert.AreEqual(Wait, res);
            }
    }
}
