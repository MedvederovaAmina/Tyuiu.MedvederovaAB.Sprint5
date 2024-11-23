using Tyuiu.MedvederovaAB.Sprint5.Task4.V14.Lib;

namespace Tyuiu.MedvederovaAB.Sprint5.Task4.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\Users\Амина Медведерова\Desktop\DataSprint5\InPutDataFileTask4V14.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
            
        }
    }
}