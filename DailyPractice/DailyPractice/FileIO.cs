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
    }
}
