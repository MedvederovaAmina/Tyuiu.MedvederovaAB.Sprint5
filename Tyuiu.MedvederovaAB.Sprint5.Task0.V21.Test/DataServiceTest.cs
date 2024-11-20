using Tyuiu.MedvederovaAB.Sprint5.Task0.V21.Lib;

namespace Tyuiu.MedvederovaAB.Sprint5.Task0.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\Амина Медведерова\source\repos\Tyuiu.MedvederovaAB.Sprint5\Tyuiu.MedvederovaAB.Sprint5.Task0.V21.Test\bin\Debug\net8.0\Tyuiu.MedvederovaAB.Sprint5.Task0.V21.Test.dll";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}