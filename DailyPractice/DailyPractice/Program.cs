using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                FileIO fileIO = new FileIO();
                Console.WriteLine("1- Check File exist or not");
                Console.WriteLine("2- Read all lines");
                Console.WriteLine("3- Read all text");
                Console.WriteLine("4- Copy file");
                Console.WriteLine("5-  Delete File ");
                Console.WriteLine("6-read file using stream reader");
                Console.WriteLine("7- Write text in file using StreamWriter");
                Console.WriteLine("Choose above options");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        fileIO.FileExist();
                        break;
                    case 2:
                        fileIO.ReadAllLine();
                        break;
                    case 3:
                        fileIO.ReadAllText();
                        break;
                    case 4:
                        fileIO.COpyFile();
                        break;
                    case 5:
                        fileIO.DeleteFile();
                        break;
                    case 6:
                        fileIO.REadFile_UsingStreamReader();
                        break;
                    case 7:
                        fileIO.WriteFile_UsingStreamWriter();
                        break;
                }
            }
        }
    }
}
