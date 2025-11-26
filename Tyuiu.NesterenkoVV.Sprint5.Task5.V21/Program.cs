using Tyuiu.NesterenkoVV.Sprint5.Task5.V21.Lib;
namespace Tyuiu.NesterenkoVV.Sprint5.Task5.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask4V17.txt";
            Console.Title = "Спринт #5 | Выполнил: Нестеренко В.В. | ИИПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема:  Чтение набора данных из текстового файла                         *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Нестеренко Вячеслав Владимирович | ИИПб-25-1                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найти факториал целочисленного значения, которое делиться на 2          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");

            string q = @"C:\DataSprint5\InPutDataFileTask5V21.txt";
            Console.WriteLine("Данные находятся в файле: " + q);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            var res = ds.LoadFromDataFile(q);
            Console.WriteLine(res);
        }
    }
}
