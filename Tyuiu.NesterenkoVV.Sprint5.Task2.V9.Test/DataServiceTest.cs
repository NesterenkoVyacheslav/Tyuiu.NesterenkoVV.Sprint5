using Tyuiu.NesterenkoVV.Sprint5.Task2.V9.Lib;
namespace Tyuiu.NesterenkoVV.Sprint5.Task2.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\стасик\AppData\Local\Temp\OutPutFileTask2.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = File.Exists(path);
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
