using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.NesterenkoVV.Sprint5.Task4.V17.Lib
{
    public class DataService : ISprint5Task4V17
    {
        public double LoadFromDataFile(string path)
        {
            string strx = File.ReadAllText(path);
            double x = double.Parse(strx);
            double y = Math.Round(Math.Sin(2 / (3 * x)) + Math.Pow(x, 2), 3);
            return y;
        }
    }
}
