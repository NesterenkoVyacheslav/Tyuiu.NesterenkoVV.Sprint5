using Tyuiu.NesterenkoVV.Sprint5.Task6.V23.Lib;
namespace Tyuiu.NesterenkoVV.Sprint5.Task6.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V23.txt";
            FileInfo file = new FileInfo(path);
            bool pathExist = file.Exists;
            Assert.AreEqual(true, pathExist);
        }
    }
}
