namespace Tyuiu.MedvederovaAB.Sprint5.Task2.V24.Lib;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        int[,] matrix = new int[3, 3] { { 6, 0, 6 }, { -1, -8, 7 }, {5, 1, 0 } };
        int rows = matrix.GetUpperBound(0) + 1;
        int columns = matrix.Length / rows;
        Console.Title = "Спринт #5  |  Выполнила: Медведерова А. Б.   |  ПКТб-24-1";
        Console.WriteLine("*****************************************************************");
        Console.WriteLine("* Спринт #5                                                     *");
        Console.WriteLine("* Тема: Запись структурированных данных в текстовый файл.       *");
        Console.WriteLine("* Задание #2                                                    *");
        Console.WriteLine("* Вариант #24                                                   *");
        Console.WriteLine("* Выполнила: Медведерова Амина Борисовна | ПКТб-24-1            *");
        Console.WriteLine("*****************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                      *");
        Console.WriteLine("* Написать программу, которая заменяет положительные значения в *");
        Console.WriteLine("* массиве на 0, а отрицательные - на 1.                         *");
        Console.WriteLine("*                                                               *");
        Console.WriteLine("*****************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                              *");
        Console.WriteLine("*****************************************************************");

        Console.WriteLine("Массив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{matrix[i, j]}\t");
                
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("*****************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
        Console.WriteLine("*****************************************************************");
        string res = ds.SaveToFileTextData(matrix);
        Console.WriteLine("Файл" + res);
        Console.WriteLine("Создан!");

        Console.ReadKey();
    }
}
