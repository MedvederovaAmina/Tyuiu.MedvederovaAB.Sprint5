﻿using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MedvederovaAB.Sprint5.Task0.V21.Lib
{
    public class DataService : ISprint5Task0V21
    {
        public string SaveToFileTextData(int x)
        {
            string[] paths = { Path.GetTempPath(), Path.GetTempFileName() };
            string path = Path.Combine(paths);
            double y = (Math.Pow(x, 2) + 1) / Math.Sqrt(4 * Math.Pow(x, 2) - 3);
            y = Math.Round(y, 3);
            File.WriteAllText(path, Convert.ToString(y));
            return path;
        }
    }
}
