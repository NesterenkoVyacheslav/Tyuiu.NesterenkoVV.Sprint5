using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.NesterenkoVV.Sprint5.Task2.V9.Lib
{
    public class DataService : ISprint5Task2V9
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string temppath = Path.GetTempPath();
            string path = Path.Combine(temppath, "OutPutFileTask2.csv");
            bool Exist = File.Exists(path);
            if (Exist)
            {
                File.Delete(path);
            }

            for (int i = 0; i < matrix.GetLength(0); i++) 
            {
                for (int j = 0; j < matrix.GetLength(1); j++) 
                {
                    if (matrix[i, j] % 2 !=0) 
                    { 
                    matrix[i, j] = 0;
                    }
                }
            }


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string  str = "";
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j != matrix.GetLength(1) - 1)
                    {
                        str = str + matrix[i, j] + ";";
                    }
                    else
                    {
                        str = str + matrix[i, j];
                    }
                }
                if (i != matrix.GetLength(0) - 1)
                {
                    File.AppendAllText(path, str + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, str);
                }
            }
            return path;
        }
    }
}
