using Tyuiu.MedvederovaAB.Sprint5.Task7.V10.Lib;

namespace Tyuiu.MedvederovaAB.Sprint5.Task7.V10
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
            Console.WriteLine("* Задание #6                                                    *");
            Console.WriteLine("* Вариант #16                                                   *");
            Console.WriteLine("* Выполнила: Медведерова Амина Борисовна | ПКТб-24-1            *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      *");
            Console.WriteLine("* Написать программу, которая меняет заглавные латинские буквы  *");
            Console.WriteLine("* на строчные в тексте , взятого из файла.                      *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("*****************************************************************");

            string path = @"C:\Users\Амина Медведерова\source\repos\Tyuiu.MedvederovaAB.Sprint5\Tyuiu.MedvederovaAB.Sprint5.Task7.V10\bin\Debug\net8.0\InPutDataFileTask7V10.txt";
            Console.WriteLine("Данные находятся в файле: " + path);



            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            
            Console.WriteLine(ds.LoadDataAndSave(path));


            Console.ReadKey();
        }
    }
}
