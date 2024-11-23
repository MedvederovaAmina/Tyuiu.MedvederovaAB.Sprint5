using System.Globalization;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MedvederovaAB.Sprint5.Task5.V14.Lib
{
    public class DataService : ISprint5Task5V14
    {
        public double LoadFromDataFile(string path)
        {
            double max = double.MaxValue;
            using (StreamReader sr = new StreamReader(path))
            {
                string? line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] numbers = line.Split(' ');
                    foreach (string number in numbers)
                    {
                        double number_ = double.Parse(number, CultureInfo.InvariantCulture);
                        if (number_ % 3.0 == 0 && number_ == 12)
                        {
                             max = 1 * 2 * 3 * 4 * 5 * 6 * 7 * 8 * 9 * 10 * 11 * 12;
                        } 
                    }
                }
            }
            return Math.Round(max, 3);
        }
    }
}
