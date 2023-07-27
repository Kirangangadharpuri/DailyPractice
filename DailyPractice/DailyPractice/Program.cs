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
                Console.WriteLine("Choose above options");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        fileIO.FileExist();
                        break;
                }
            }
        }
    }
}
