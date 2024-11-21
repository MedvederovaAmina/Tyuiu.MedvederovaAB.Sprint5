using System.Text;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MedvederovaAB.Sprint5.Task3.V3.Lib
{
    public class DataService : ISprint5Task3V3
    {
        public string SaveToFileTextData(int x)
        {
            string[] paths = { Path.GetTempPath(), Path.GetTempFileName() };
            string path = Path.Combine(paths);

            double result = Math.Round(x * Math.Sqrt(x + 3), 3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(result));
            }
            return path;
        }
    }
}
