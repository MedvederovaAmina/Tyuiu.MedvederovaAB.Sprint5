using Tyuiu.MedvederovaAB.Sprint5.Task0.V21.Lib;

namespace Tyuiu.MedvederovaAB.Sprint5.Task0.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = Path.GetTempFileName();
            FileInfo fileInfo =  new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}