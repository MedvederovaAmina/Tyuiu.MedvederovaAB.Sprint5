using Tyuiu.MedvederovaAB.Sprint5.Task5.V14.Lib;

namespace Tyuiu.MedvederovaAB.Sprint5.Task5.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5  |  Выполнила: Медведерова А. Б.   |  ПКТб-24-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #5                                                     *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла.                      *");
            Console.WriteLine("* Задание #5                                                    *"); 
            Console.WriteLine("* Вариант #14                                                   *");
            Console.WriteLine("* Выполнила: Медведерова Амина Борисовна | ПКТб-24-1            *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение по формуле    *");
            Console.WriteLine("* при значении х , взятого из файла.                            *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("*****************************************************************");

            string path = @"C:\Users\Амина Медведерова\source\repos\Tyuiu.MedvederovaAB.Sprint5\Tyuiu.MedvederovaAB.Sprint5.Task5.V14\bin\Debug\net8.0\InPutDataFileTask5V14.txt";
            Console.WriteLine("Данные находятся в файле: " + path);



            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);


            Console.ReadKey();
        }
    }
}
