using System.Data;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.NesterenkoVV.Sprint5.Task1.V9.Lib
{
    public class DataService : ISprint5Task1V9
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string tempPath = Path.GetTempPath();
            string path = Path.Combine(tempPath, "OutPutFileTask1.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists =fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }
            double y;
            string stry;

            for (int i = startValue; i <= stopValue; i++)
            {
                y = Math.Sin(i) + (Math.Cos(2 * i)) / 2 - 1.5 * i; ;
                if (double.IsNaN(y) || double.IsInfinity(y))
                {
                    y = 0;
                }
                y = Math.Round(y, 2);
                stry = Convert.ToString(y);
                if (i != stopValue)
                {
                    File.AppendAllText(path, stry + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, stry);
                }
            }
            return path;

        }
    }
}
