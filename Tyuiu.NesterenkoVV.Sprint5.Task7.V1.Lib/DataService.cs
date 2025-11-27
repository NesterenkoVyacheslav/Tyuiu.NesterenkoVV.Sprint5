using Microsoft.VisualBasic.FileIO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.NesterenkoVV.Sprint5.Task7.V1.Lib
{
    public class DataService : ISprint5Task7V1
    {
        public string LoadDataAndSave(string path)
        {
            string temppath = Path.GetTempPath();
            string newpath = Path.Combine(temppath, "OutPutFileTask7.txt");
            FileInfo fileinfo = new FileInfo(newpath);

            if (fileinfo.Exists )
            {
                File.Delete(newpath);
            }

            string text = File.ReadAllText(path);
            string newtext = "";
            foreach (char c in text) 
            {
                if (!(char.IsDigit(c) || c=='.')) 
                {
                newtext += c;
                }
            }
            File.AppendAllText(newpath, newtext);
            return newpath;
        }
    }
}
