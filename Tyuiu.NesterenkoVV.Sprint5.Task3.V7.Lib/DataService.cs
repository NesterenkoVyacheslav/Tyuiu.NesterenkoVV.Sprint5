using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.NesterenkoVV.Sprint5.Task3.V7.Lib
{
    public class DataService : ISprint5Task3V7
    {
        public string SaveToFileTextData(int x)
        {
            string temppath = Path.GetTempPath();
            string path = Path.Combine(temppath, "OutPutFileTask3.bin");
            double z = Math.Round(1.6 * Math.Pow(x, 3) - 2.1 * Math.Pow(x, 2) + 7 * x, 3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(z));
            }
            return path;
        }
    }
}
