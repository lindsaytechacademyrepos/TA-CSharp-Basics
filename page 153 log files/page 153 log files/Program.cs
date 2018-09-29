using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace page_153_log_files
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string userInput = Console.ReadLine();
            string logFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "log.txt");
            using (StreamWriter file = new StreamWriter(logFilePath, true))
            {
                file.WriteLine(userInput);
            }
            Console.WriteLine("Here are the updated values of the file logged at {0}:", logFilePath);
            Console.WriteLine(File.ReadAllText(logFilePath));

            //launches the text file reader:
            //System.Diagnostics.Process.Start(logFilePath);

            Console.Read();
        }
    }
}
