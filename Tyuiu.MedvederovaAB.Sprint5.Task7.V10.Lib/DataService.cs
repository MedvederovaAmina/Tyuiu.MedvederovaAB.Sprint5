using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MedvederovaAB.Sprint5.Task7.V10.Lib
{
    public class DataService : ISprint5Task7V10
    {
        public string LoadDataAndSave(string path)
        {

            int count = 0;
            string str = File.ReadAllText(path);
            string result = "";
            string[] words = str.Split(' ');

            foreach (char c in path)
            {

                if (c >= 'A' && c <= 'Z')
                {

                    result.Append(char.ToLower(c));
                }
                else
                {

                    result.Append(c);


                }
         
            }
            return result;
        }
    }
}
