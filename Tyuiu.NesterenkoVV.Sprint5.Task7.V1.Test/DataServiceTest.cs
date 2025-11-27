using Tyuiu.NesterenkoVV.Sprint5.Task7.V1.Lib;
namespace Tyuiu.NesterenkoVV.Sprint5.Task7.V1.Test
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
