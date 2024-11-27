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

            string strLine = "";

            using (StreamReader sr = new StreamReader(path))
            {
                string? line;

                char[] charArray = pathSave.ToCharArray();

                while ((line = sr.ReadLine()) != null)
                {
                    for (int i = 0; i < charArray.Length; i++)
                    {
                        if (path == null) return string.Empty;
                        return path.ToLower();
                    }
                    File.AppendAllText(pathSave, strLine + Environment.NewLine);
                    strLine = "";
                }
            }
            return pathSave;
        }
    }
}
