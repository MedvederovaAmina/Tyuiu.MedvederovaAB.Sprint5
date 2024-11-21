using Tyuiu.MedvederovaAB.Sprint5.Task3.V3.Lib;

namespace Tyuiu.MedvederovaAB.Sprint5.Task3.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 3;
            Console.Title = "Спринт #5  |  Выполнила: Медведерова А. Б.   |  ПКТб-24-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #5                                                     *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл.          *");
            Console.WriteLine("* Задание #3                                                    *");
            Console.WriteLine("* Вариант #3                                                    *");
            Console.WriteLine("* Выполнила: Медведерова Амина Борисовна | ПКТб-24-1            *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      *");
            Console.WriteLine("* Написать программу, которая вычисляет выпажение по формуле    *");
            Console.WriteLine("* при х = 3.                                                    *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("*****************************************************************");

            Console.WriteLine("x = " + x);

            Console.WriteLine();
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл" + res);
            Console.WriteLine("Создан!");

            Console.ReadKey();

        }
    }
}
