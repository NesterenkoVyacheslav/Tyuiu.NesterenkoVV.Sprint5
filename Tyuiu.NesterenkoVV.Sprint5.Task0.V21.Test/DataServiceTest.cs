using Tyuiu.NesterenkoVV.Sprint5.Task0.V21.Lib;
namespace Tyuiu.NesterenkoVV.Sprint5.Task0.V21.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\стасик\source\repos\Tyuiu.NesterenkoVV.Sprint5\Tyuiu.NesterenkoVV.Sprint5.Task0.V21\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
