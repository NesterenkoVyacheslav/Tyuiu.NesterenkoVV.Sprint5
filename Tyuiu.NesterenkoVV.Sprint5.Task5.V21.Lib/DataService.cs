using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.NesterenkoVV.Sprint5.Task5.V21.Lib
{
    public class DataService : ISprint5Task5V21
    {
        public double LoadFromDataFile(string path)
        {
            double max = -10000;

            string list = File.ReadAllText(path);
            string[] numbers = list.Split(new[] { ' ', '\n', '\r' });

            foreach (string str in numbers)
            {
                double res = Math.Round(Convert.ToDouble(str.Replace('.', ',')), 3);
                if (res % 2 == 0 && res > max)
                {
                    max = res;
                }
            }
            
            if (max < 0)
            {
                return 0;
            }


            double result = 1;
            for (int i = 1; i <= max; i++)
            {
                result *= i;
            }
            return result;

        }
    }
}
