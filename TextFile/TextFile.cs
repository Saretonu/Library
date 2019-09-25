using System;
using System.Collections.Generic;
using System.IO;

namespace Core
{
    public static class TextFile
    {
        public static void CreateFile()
        {

        }

        public static List<string> ReadFile(string fileLocation)
        {
            if (!File.Exists(fileLocation))
                return null;
            List<string> ret = new List<string>();
            string line = null;
            
            using(StreamReader fileData = new StreamReader(fileLocation))
            {
                while ((line = fileData.ReadLine()) != null)
                {
                    ret.Add(line);
                }
            }
            return ret;
        }
        public static bool WriteFile(List<string> lines, string fileLocation)
        {
            if (!File.Exists(fileLocation))
                return false;
            using (StreamWriter fileData = new StreamWriter(fileLocation))
            {
                fileData.Flush();
                foreach (string i in lines)
                {
                    fileData.WriteLine(i);
                }
            }
            return true;
        }
    }
}
