using Tyuiu.MedvederovaAB.Sprint5.Task7.V10.Lib;

namespace Tyuiu.MedvederovaAB.Sprint5.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            string path = @"C:\Users\Амина Медведерова\source\repos\Tyuiu.MedvederovaAB.Sprint5\Tyuiu.MedvederovaAB.Sprint5.Task7.V10\bin\Debug\net8.0\InPutDataFileTask7V10.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}