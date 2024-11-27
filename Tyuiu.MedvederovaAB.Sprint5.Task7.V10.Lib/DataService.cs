using System.IO;

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
            string text = File.ReadAllText(path);
            foreach (char c in text)
            {

                if (c >= 'A' && c <= 'Z')
                {

                    resPath.Append(char.ToLower(c));
                }
                else
                {

                    resPath.Append(c);
                }
            }
            File.AppendAllText(resPath, text);

            return resPath;
        }
    }
}
