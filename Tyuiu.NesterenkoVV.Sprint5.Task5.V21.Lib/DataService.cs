using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.NesterenkoVV.Sprint5.Task5.V21.Lib
{
    public class DataService : ISprint5Task5V21
    {
        public double LoadFromDataFile(string path)
        {
            double max = -10000;
            double result = 1;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Replace(".", ",");
                    double x = double.Parse(line);
                    if (x % 2 == 0 && x>max)
                    {
                        max = x;
                    }
                }
            }
            for (int i = 2; i <= max; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
