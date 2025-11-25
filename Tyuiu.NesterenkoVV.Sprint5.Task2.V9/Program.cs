using Tyuiu.NesterenkoVV.Sprint5.Task2.V9.Lib;
namespace Tyuiu.NesterenkoVV.Sprint5.Task2.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Нестеренко В.В. | ИИПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Нестеренко Вячеслав Владимирович | ИИПб-25-1                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный        *");
            Console.WriteLine("* с клавиатуры. Заменить нечетные элементы массива на 0. Результат        *");
            Console.WriteLine("* сохранить в файл OutPutFileTask2.csv и вывести на консоль.              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[,] matrix = new int[3, 3] { { 6, 8, 3 }, { 2, 6, 8 }, { 1, 7, 1 } };
            int columbs = matrix.GetLength(1);
            int rows = matrix.GetLength(0);
            
            DataService ds = new DataService();
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columbs; j++) 
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(matrix);

            Console.WriteLine($"Файл {res} Создан!");
            Console.ReadKey();
        }
    }
}
