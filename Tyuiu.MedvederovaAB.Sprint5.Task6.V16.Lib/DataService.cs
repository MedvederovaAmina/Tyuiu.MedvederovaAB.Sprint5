
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;


namespace Tyuiu.MedvederovaAB.Sprint5.Task6.V16.Lib
{
    public class DataService : ISprint5Task6V16
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            string str = File.ReadAllText(@"C:\Users\Амина Медведерова\source\repos\Tyuiu.MedvederovaAB.Sprint5\Tyuiu.MedvederovaAB.Sprint5.Task6.V16\bin\Debug\net8.0\InPutDataFileTask6V16.txt");
            string res = "";
            string[] words = str.Split(' ');

            foreach (string word in words)
            {
                if (Regex.IsMatch(word, @"^[A-Za-z!@#$%^&*()_+\-=\[\]{};':""\\|,.<>\/?]+$"))
                {
                    count += 1;
                }
            }
            return count;
        } 
    }
}
        
