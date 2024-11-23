using System.IO;
using Tyuiu.MedvederovaAB.Sprint5.Task4.V14.Lib;

namespace Tyuiu.MedvederovaAB.Sprint5.Task4.V14
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
            Console.WriteLine("* Задание #4                                                    *");
            Console.WriteLine("* Вариант #14                                                   *");
            Console.WriteLine("* Выполнила: Медведерова Амина Борисовна | ПКТб-24-1            *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      *");
            Console.WriteLine("* Написать программу, которая вычисляет выпажение по формуле    *");
            Console.WriteLine("* при значении х , взятого из файла.                            *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("*****************************************************************");

            string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask4V14.txt";
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
