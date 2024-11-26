using Tyuiu.MedvederovaAB.Sprint5.Task6.V16.Lib;

namespace Tyuiu.MedvederovaAB.Sprint5.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\����� �����������\source\repos\Tyuiu.MedvederovaAB.Sprint5\Tyuiu.MedvederovaAB.Sprint5.Task6.V16\bin\Debug\net8.0\InPutDataFileTask6V16.txt";
            var res = ds.LoadFromDataFile(path);
            int wait =  6;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void LoadFromDataFile()
        {
            string path = @"C:\Users\����� �����������\source\repos\Tyuiu.MedvederovaAB.Sprint5\Tyuiu.MedvederovaAB.Sprint5.Task6.V16\bin\Debug\net8.0\InPutDataFileTask6V16.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}