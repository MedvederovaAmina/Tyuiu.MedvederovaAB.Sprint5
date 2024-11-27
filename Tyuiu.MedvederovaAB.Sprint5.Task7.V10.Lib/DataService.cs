using System.IO;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MedvederovaAB.Sprint5.Task7.V10.Lib
{
    public class DataService : ISprint5Task7V10
    {
        public string LoadDataAndSave(string path)
        {
            string resPath = Path.Combine(Path.GetTempPath(), "OutPutFileTask7V10.txt");
            FileInfo fileInfo = new FileInfo(resPath);
           bool fileExsists = fileInfo.Exists;
            if (fileExsists) { File.Delete(resPath); }
            string str = File.ReadAllText(path);
            string[] words = str.Split(' ');
            for (int i = 0; i < words.Length; i ++)
            {

                if (Regex.IsMatch(words[i], "[A - Z]"))
                {
                    words[i] = words[i].ToLower();
                }
               
            }
            File.WriteAllText(resPath, String.Join(" ", words));

            return resPath;
        }
    }
}
