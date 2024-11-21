using Tyuiu.MedvederovaAB.Sprint5.Task1.V21.Lib;

namespace Tyuiu.MedvederovaAB.Sprint5.Task1.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int startvalue = -5;
            int stopvalue = 5;
            Console.Title = "Спринт #5  |  Выполнила: Медведерова А. Б.   |  ПКТб-24-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #5                                                     *");
            Console.WriteLine("* Тема:  Класс File. Запись набора данных в текстовый файл.     *");
            Console.WriteLine("* Задание #1                                                    *");
            Console.WriteLine("* Вариант #21                                                   *");
            Console.WriteLine("* Выполнила: Медведерова Амина Борисовна | ПКТб-24-1            *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение по фоормуле   *");
            Console.WriteLine("* и произвести табулирование.                                   *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("*****************************************************************");

            Console.WriteLine("StartValue = " + startvalue);
            Console.WriteLine("StopValue = " + stopvalue);

            Console.WriteLine();
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            string res = ds.SaveToFileTextData(startvalue, stopvalue);
            Console.WriteLine("Файл" + res);
            Console.WriteLine("Создан!");

            Console.ReadKey();
        }
    }
}
