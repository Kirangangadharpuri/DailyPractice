using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPractice
{
    public class FileIO
    {
        string path = @"C:\Users\HP\Desktop\RFP-288\PracticeDaily\DailyPractice\DailyPractice\DailyPractice\PracticeFolder\Kiran.txt";

        public void FileExist()
        {
            if(File.Exists(path))
            {
                Console.WriteLine("File does exist");
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
        }

        public void ReadAllLine()
        {
            string[] Lines= File.ReadAllLines(path);
            foreach(string Line in Lines)
            {
                Console.WriteLine(Line);
            }
        }
        public void ReadAllText()
        {
            string Line= File.ReadAllText(path);
            Console.WriteLine(Line);
        }

        public void COpyFile()
        {
            string copyPath = @"C:\Users\HP\Desktop\RFP-288\PracticeDaily\DailyPractice\DailyPractice\DailyPractice\PracticeFolder\Puri.txt";
            File.Copy(path, copyPath);
            Console.WriteLine("File has been copied");
        }

        public void DeleteFile()
        {
            string copyPath = @"C:\Users\HP\Desktop\RFP-288\PracticeDaily\DailyPractice\DailyPractice\DailyPractice\PracticeFolder\Puri.txt";
            File.Delete(copyPath);
            Console.WriteLine("File has been deleted");
        }
        public void REadFile_UsingStreamReader()
        {
            using (StreamReader sr = File.OpenText(path))
            {
                string reader =" ";
                while((reader =sr.ReadLine()) !=null)
                {
                    Console.WriteLine(reader);
                }
            }
        }
        public void WriteFile_UsingStreamWriter()
        {
            using(StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("\nTo expertise my skills");
                sw.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
        }
    }
}
