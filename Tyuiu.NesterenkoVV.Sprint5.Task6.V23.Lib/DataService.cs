using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.NesterenkoVV.Sprint5.Task6.V23.Lib
{
    public class DataService : ISprint5Task6V23
    {
        public int LoadFromDataFile(string path)
        {
            string text =File.ReadAllText(path);
            int count = text.Count(x=>x == '-');
            return count;

        }
    }
}
