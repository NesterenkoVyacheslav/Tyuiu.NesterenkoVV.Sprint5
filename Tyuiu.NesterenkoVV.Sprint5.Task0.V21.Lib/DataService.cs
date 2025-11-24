using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.NesterenkoVV.Sprint5.Task0.V21.Lib
{
    public class DataService : ISprint5Task0V21
    {
        public string SaveToFileTextData(int x)
        {
            string tempPath = Path.GetTempPath();
            string path = Path.Combine(tempPath, "OutPutFileTask0.txt");
            double z = Math.Round((Math.Pow(x, 2) + 1) / (Math.Sqrt(4 * Math.Pow(x, 2) - 3)), 3);
            File.WriteAllText(path, Convert.ToString(z));
            return path;
        }
    }
}
