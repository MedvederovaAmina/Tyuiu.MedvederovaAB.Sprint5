using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MedvederovaAB.Sprint5.Task7.V10.Lib
{
    public class DataService : ISprint5Task7V10
    {
        public string LoadDataAndSave(string path)
        {
            string pathSave = Path.Combine(Path.GetTempPath(), "outPutDataFileTask7V10.txt");

            if (File.Exists(pathSave)) File.Delete(pathSave);
            string str = File.ReadAllText(path);
            

            using (StreamReader sr = new StreamReader(path))
            {
                string? line;
                string result = "";
                string[] words = str.Split(' ');
                string strLine = "";
                int index = 0;

                
                while (index < path.Length)
                {
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

                }

                return result;
            }
           
        }
    }
}
